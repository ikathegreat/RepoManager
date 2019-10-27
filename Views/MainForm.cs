using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using RepoManager.Analytics;
using RepoManager.Models;

namespace RepoManager
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string RepoManagerAppData = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Repo Manager");

        public static string SavedRepoSelectionsXml = Path.Combine(RepoManagerAppData, "SelectedRepos.xml");
        public static string OptionsIni = Path.Combine(RepoManagerAppData, "Options.ini");
        public static string RunBatchIni = Path.Combine(RepoManagerAppData, "RunBatch.ini");
        public static string RepoPropertiesIni = Path.Combine(RepoManagerAppData, "RepoProperties.ini");
        public static string GridLayoutXml = Path.Combine(RepoManagerAppData, "GridLayout.xml");
        public static string GridRecentFilesXml = Path.Combine(RepoManagerAppData, "GridRecentFiles.xml");
        public static string GridCommitHistoryXml = Path.Combine(RepoManagerAppData, "GridCommitHistory.xml");
        public static string GridRunBatchFilesXml = Path.Combine(RepoManagerAppData, "GridRunBatchFiles.xml");
        public static string GridSummaryXml = Path.Combine(RepoManagerAppData, "GridSummary.xml");
        public static string GridNugetPackagesXml = Path.Combine(RepoManagerAppData, "GridNugetPackages.xml");
        public static string GridNugetToUpgradeXml = Path.Combine(RepoManagerAppData, "GridNugetToUpgrade.xml");

        /*
         * This project heavily relies on libgit2sharp
         * https://github.com/libgit2/libgit2sharp
         *
         * Bump the project version if you make changes.
         *
         * Cleanup nuget packages
         * Change history spark graph
         * SmartScreen/signing issue
         * Move files paths to separate class
         * Ribbon tooltips with keyboard shortcuts
         * Individual repo refresh, auto refresh on directory change
         * Find in files in directories
         * Whats new
         * Size column sort is alphabetical instead of lexicographical
         * Ability to have repo-specific credentials
         * Dark mode
         * Skip repo subscans if grid column is hidden
         * Ability to list and checkout remote branches
         * Last fetch time
         *
         */


        private CancellationTokenSource cts;

        public FormMain()
        {
            InitializeComponent();

            if (!Directory.Exists(RepoManagerAppData))
                Directory.CreateDirectory(RepoManagerAppData);

            var iniFile = new IniFile(OptionsIni);

            var isMaximized = iniFile.ReadBool("Window", "IsMaximized", false);
            WindowState = isMaximized ? FormWindowState.Maximized : FormWindowState.Normal;

            if (WindowState == FormWindowState.Normal)
            {
                Width = iniFile.ReadInteger("Window", "Width", 1200);
                Height = iniFile.ReadInteger("Window", "Height", 600);
            }
        }

        private void setUIEnable(bool enable)
        {
            ribbonControl1.Enabled = gridControl1.Enabled = enable;
            Cursor = enable ? Cursors.Default : Cursors.WaitCursor;
        }

        private async void SearchRepos()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            if (gridView1.RowCount > 0)
                SaveSelectedRepos();

            List<RepoModel> reposList;
            setUIEnable(false);
            try
            {
                var iniFile = new IniFile(OptionsIni);
                var defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");
                var slnSearchPath = iniFile.ReadString(OptionsForm.PreferencesSection, "RepoPath", defaultPath);


                if (!Directory.Exists(slnSearchPath))
                {
                    barStaticItemFocusedRepo.Caption = "";
                    barStaticItemFocusedRepoStatus.Caption = "";
                    return;
                }

                barSelectionStatus.Caption = "Refreshing repository lists...";
                reposList = await Utilities.ScanForRepositoriesAsync(slnSearchPath);
                gridControl1.DataSource = reposList;


                LoadPreviouslySelectedRepoSelections();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                setUIEnable(true);
            }

            panelProgressBar.Visible = true;
            var listOfTasks = new List<Task>();
            barSelectionStatus.Caption = "Getting repository information...";

            //Debug.Write();

            cts?.Cancel();

            cts = new CancellationTokenSource();
            var ct = cts.Token;
            progressBarControl1.EditValue = 0;
            foreach (var repoModel in reposList)
            {
                listOfTasks.Add(Utilities.GetRepoGitInfoAsync(repoModel, ct));
                listOfTasks.Add(Utilities.GetRepoModelSolutionsList(repoModel, ct));
                if (repoModel.SkipScan)
                    continue;
                listOfTasks.Add(Utilities.GetRepositorySize(repoModel, ct));
                listOfTasks.Add(Utilities.GetRepoNumberOfFiles(repoModel, ct));
                listOfTasks.Add(Utilities.GetRepositoryChanges(repoModel, ct));

            }
            progressBarControl1.Properties.Maximum = listOfTasks.Count;

            var entireTask1 = Task.WhenAll(listOfTasks);
            while (await Task.WhenAny(entireTask1, Task.Delay(100, ct)) != entireTask1)
            {
                if (ct.IsCancellationRequested)
                    break;
                var completeCount = listOfTasks.Count(x => x.Status == TaskStatus.RanToCompletion);
                progressBarControl1.EditValue = completeCount;

                barSelectionStatus.Caption = $"Getting repository information ({completeCount}/{listOfTasks.Count})...";
                gridControl1.RefreshDataSource();
            }

            var doDummyData = false;

            if (doDummyData)
            {
                var index = 0;
                foreach (var repoModel in reposList)
                {
                    repoModel.Name = DummyRepoData.RepoNames[index];
                    repoModel.CommitMessage = $"{DummyRepoData.DevNames[index]}: {DummyRepoData.CommitMessages[index]}";
                    index++;
                }
            }

            //gridView1.BestFitColumns();
            progressBarControl1.EditValue = 0;
            panelProgressBar.Visible = false;

            barSelectionStatus.Caption = "";
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;
            Track.DoTrackEvent(TrackCategories.Application, "searchRepos", reposList.Count.ToString());
            Debug.WriteLine($"SearchRepos: {ts.Hours:D2}h:{ts.Minutes:D2}m:{ts.Seconds:D2}s:{ts.Milliseconds:D3}ms");
        }

        private void LoadPreviouslySelectedRepoSelections()
        {
            if (!File.Exists(SavedRepoSelectionsXml)) return;
            var selectReposList = Utilities.LoadStringList(SavedRepoSelectionsXml);

            for (var i = 0; i < gridView1.DataRowCount; i++)
            {
                var row = gridView1.GetRow(i);
                if (!(row is RepoModel repoModel)) continue;

                if (selectReposList.Contains(repoModel.Name))
                    gridView1.SelectRow(i);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(GridLayoutXml))
                gridView1.RestoreLayoutFromXml(GridLayoutXml);

            InitializeAnalytics();

            Track.DoTrackEvent(TrackCategories.Application, "version",
                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);


            panelProgressBar.Visible = false;
            SearchRepos();

            var fileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

            barStaticItemVersion.Caption = $"{fileVersionInfo.FileMajorPart}.{fileVersionInfo.FileMinorPart}";
        }

        private static void InitializeAnalytics()
        {
            var iniFile = new IniFile(OptionsIni);

            var doTracking = iniFile.ReadBool(OptionsForm.PreferencesSection, "DoAnalytics", true);

            Track.DoTracking = doTracking;

            if (!Track.DoTracking)
                return;

            var originalFID = iniFile.ReadString(OptionsForm.PreferencesSection, "ClientID", "");

            Track.Register(originalFID);
            Track.TrackingID = "UA-150937562-1";
            Track.ApplicationName = "Repo Manager";

            if (!string.IsNullOrEmpty(Track.ClientID))
                iniFile.WriteString(OptionsForm.PreferencesSection, "ClientID", Track.ClientID);

        }

        private void barButtonItemOpenRepo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoRepoAction(RepoActionEnum.Open);
        }

        private void barButtonItemDeleteRepo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoRepoAction(RepoActionEnum.Delete);
        }

        private void DoRepoAction(RepoActionEnum repoActionEnum, bool useFocusedRow = false)
        {
            var selectedRepoModelList = new List<RepoModel>();
            if (useFocusedRow)
            {
                if (!(gridView1.GetFocusedRow() is RepoModel repoModel)) return;
                selectedRepoModelList.Add(repoModel);
            }
            else
            {

                for (var i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    var row = gridView1.GetSelectedRows()[i];
                    if (!(gridView1.GetRow(row) is RepoModel repoModel)) continue;
                    selectedRepoModelList.Add(repoModel);
                }
            }

            if (selectedRepoModelList.Count == 0)
                return;

            if (repoActionEnum == RepoActionEnum.ManageNuget)
            {
                Track.DoTrackEvent(TrackCategories.Application, "manageNugetForm.ShowDialog");
                var manageNugetForm = new ManageNugetForm { ReposList = selectedRepoModelList };

                manageNugetForm.ShowDialog();
                return;
            }

            var totalBatchFileCount = 0;
            if (repoActionEnum == RepoActionEnum.RunBatch)
            {
                foreach (var repoModel in selectedRepoModelList)
                {
                    totalBatchFileCount += GetBatchFileCount(repoModel);
                }

                var countAndRepoMsg = selectedRepoModelList.Count == 1 ?
                    $"{selectedRepoModelList.First().Name}" : $"{selectedRepoModelList.Count} repositories";

                switch (totalBatchFileCount)
                {
                    case 0:
                        XtraMessageBox.Show($"No selected batch files found in {countAndRepoMsg}",
                            "Run Batch Files",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    case 1:
                        {
                            if (XtraMessageBox.Show($"Run {GetFirstSelectedBatchFileName(selectedRepoModelList.First())} in {countAndRepoMsg}?",
                                    "Run Batch Files",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                return;
                            break;
                        }
                    default:
                        {
                            if (XtraMessageBox.Show($"Run {totalBatchFileCount} batch files in {countAndRepoMsg}?",
                                    "Run Batch Files",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                return;
                            break;
                        }
                }

            }
            else if (repoActionEnum != RepoActionEnum.Open)
            {
                if (selectedRepoModelList.Count == 1)
                {
                    var repoName = selectedRepoModelList.First().Name;
                    if (XtraMessageBox.Show(
                            $"{Utilities.GetDescription(repoActionEnum)} {repoName}?",
                            $"{repoActionEnum} {repoName}",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                }
                else
                {
                    if (XtraMessageBox.Show(
                            $"{Utilities.GetDescription(repoActionEnum)} {selectedRepoModelList.Count} repositories?",
                            $"{repoActionEnum} Repositories",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                }

            }

            ProcessRepositories(repoActionEnum, selectedRepoModelList);
        }

        private void ProcessRepositories(RepoActionEnum repoActionEnum,
            IReadOnlyCollection<RepoModel> selectedRepoModelList)
        {
            panelProgressBar.Visible = true;
            setUIEnable(false);

            var summaryRecordList = new List<SummaryRecord>();

            progressBarControl1.EditValue = 0;
            progressBarControl1.Properties.Maximum = selectedRepoModelList.Count;
            Application.DoEvents();
            var showSummaryIfNoErrors = true;
            var refreshAtEnd = true;

            foreach (var repoModel in selectedRepoModelList)
            {
                barSelectionStatus.Caption = $"Working on {repoModel.Name}";

                Application.DoEvents();
                var summaryRecord = new SummaryRecord(repoModel)
                {
                    RepoActionEnum = repoActionEnum,
                    Result = "Success",
                    Message = ""
                };


                // ReSharper disable once ConvertIfStatementToSwitchStatement
                if (repoActionEnum == RepoActionEnum.Open)
                {
                    showSummaryIfNoErrors = false;
                    try
                    {
                        Process.Start(repoModel.Path);
                        refreshAtEnd = false;
                    }
                    catch (Exception ex)
                    {
                        summaryRecord.Result = "Error";
                        summaryRecord.Message = $"Failed to start process: {ex.Message}";
                    }
                }

                if (repoActionEnum == RepoActionEnum.DeleteBinObj || repoActionEnum == RepoActionEnum.DeleteVS
                                                                  || repoActionEnum == RepoActionEnum.Delete)
                {
                    var directoriesToDelete = new List<string>();

                    // ReSharper disable once SwitchStatementMissingSomeCases
                    switch (repoActionEnum)
                    {
                        case RepoActionEnum.DeleteBinObj:
                            directoriesToDelete.AddRange(Directory.EnumerateDirectories(repoModel.Path, "bin",
                                SearchOption.AllDirectories).ToList());
                            directoriesToDelete.AddRange(Directory.EnumerateDirectories(repoModel.Path, "obj",
                                SearchOption.AllDirectories).ToList());
                            refreshAtEnd = false;
                            break;
                        case RepoActionEnum.DeleteVS:
                            directoriesToDelete.AddRange(Directory.EnumerateDirectories(repoModel.Path, ".vs",
                                SearchOption.AllDirectories).ToList());
                            refreshAtEnd = false;
                            break;
                        case RepoActionEnum.Delete:
                            directoriesToDelete.Add(repoModel.Path);
                            break;
                    }

                    var actionName = repoActionEnum.ToString();
                    if (actionName != string.Empty && char.IsUpper(actionName[0]))
                        actionName = char.ToLower(actionName[0]) + actionName.Substring(1);

                    Track.DoTrackEvent(TrackCategories.LocalAction, actionName, directoriesToDelete.Count.ToString());

                    foreach (var directory in directoriesToDelete)
                    {
                        if (Utilities.TryDeleteDirectory(directory))
                            continue;
                        summaryRecord.Result = "Error";
                        summaryRecord.Message = "Failed to delete directory. Check to see if it is in use.";
                    }

                }

                if (repoActionEnum == RepoActionEnum.RunBatch)
                {
                    try
                    {
                        var batFiles = Directory.EnumerateFiles(repoModel.Path,
                            "*.bat", SearchOption.AllDirectories).ToList();

                        var listOfBatchFilesToRun = new List<string>();

                        var iniFile = new IniFile(RunBatchIni);
                        foreach (var batFile in batFiles)
                        {
                            if (iniFile.ReadBool(repoModel.Path, batFile, false))
                                listOfBatchFilesToRun.Add(batFile);
                        }

                        if (batFiles.Count == 0)
                            summaryRecord.Message = "No batch files found to run";
                        else if (listOfBatchFilesToRun.Count == 0)
                            summaryRecord.Message = $"No batch files enabled to run ({batFiles.Count} found)";

                        Parallel.ForEach(listOfBatchFilesToRun, batchFile =>
                        {
                            var process = Process.Start(batchFile);
                            if (process == null) return;
                            process.WaitForExit();
                            //if (process.ExitCode == 0)
                            //    successCount++;
                        });
                        Track.DoTrackEvent(TrackCategories.LocalAction, "runBatchFiles", listOfBatchFilesToRun.ToString());
                        summaryRecord.Message = $"Ran {listOfBatchFilesToRun.Count} .bat files";
                    }
                    catch (Exception ex)
                    {
                        summaryRecord.Result = "Error";
                        summaryRecord.Message = ex.Message;
                    }
                }

                if (repoActionEnum == RepoActionEnum.GitReset)
                {
                    try
                    {
                        Track.DoTrackEvent(TrackCategories.GitAction, "gitReset");
                        Utilities.DoGitReset(repoModel, ref summaryRecord);
                    }
                    catch (Exception ex)
                    {
                        summaryRecord.Result = "Error";
                        summaryRecord.Message = ex.Message;
                    }
                }

                if (repoActionEnum == RepoActionEnum.GitPull)
                {
                    try
                    {
                        Track.DoTrackEvent(TrackCategories.GitAction, "gitPull");
                        Utilities.DoGitPull(repoModel, ref summaryRecord);
                    }
                    catch (Exception ex)
                    {
                        summaryRecord.Result = "Error";
                        summaryRecord.Message = ex.Message;
                    }

                }

                if (repoActionEnum == RepoActionEnum.GitFetch)
                {
                    try
                    {
                        Track.DoTrackEvent(TrackCategories.GitAction, "gitFetch");
                        Utilities.DoGitFetch(repoModel, ref summaryRecord);
                    }
                    catch (Exception ex)
                    {
                        summaryRecord.Result = "Error";
                        summaryRecord.Message = ex.Message;
                    }
                }

                summaryRecordList.Add(summaryRecord);

                progressBarControl1.Increment(1);
                Application.DoEvents();
            }


            //Summary
            if (showSummaryIfNoErrors || summaryRecordList.Any(x => x.Result != "Success"))
            {
                if (summaryRecordList.Count > 0)
                {
                    var summaryForm = new SummaryForm { SummaryRecordList = summaryRecordList };
                    summaryForm.Show();
                }
            }

            panelProgressBar.Visible = false;
            setUIEnable(true);
            if (refreshAtEnd)
                SearchRepos(); //Todo: optimize this 
        }

        private int GetBatchFileCount(RepoModel repoModel)
        {
            var batFiles = Directory.EnumerateFiles(repoModel.Path,
                "*.bat", SearchOption.AllDirectories).ToList();

            var batchToRunCount = 0;

            var iniFile = new IniFile(RunBatchIni);
            foreach (var batFile in batFiles)
            {
                if (iniFile.ReadBool(repoModel.Path, batFile, false))
                    batchToRunCount++;
            }

            return batchToRunCount;

        }

        private string GetFirstSelectedBatchFileName(RepoModel repoModel)
        {
            var iniFile = new IniFile(RunBatchIni);
            foreach (var batFile in Directory.EnumerateFiles(repoModel.Path,
                "*.bat", SearchOption.AllDirectories).ToList())
            {
                if (iniFile.ReadBool(repoModel.Path, batFile, false))
                    return Path.GetFileName(batFile);
            }

            return string.Empty;

        }

        private void barButtonItemDeleteBinObj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoRepoAction(RepoActionEnum.DeleteBinObj);
        }

        private void barButtonItemGitGetLatest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoRepoAction(RepoActionEnum.GitPull);
        }

        private void barButtonItemReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoRepoAction(RepoActionEnum.GitReset);
        }

        private void barButtonItemDeleteVs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoRepoAction(RepoActionEnum.DeleteVS);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts?.Cancel();

            var directory = Path.GetDirectoryName(OptionsIni);
            if (!Directory.Exists(directory))
                if (directory != null)
                    Directory.CreateDirectory(directory);

            var iniFile = new IniFile(OptionsIni);
            iniFile.WriteBool("Window", "IsMaximized", WindowState == FormWindowState.Maximized);

            if (WindowState != FormWindowState.Normal)
            {
                iniFile.WriteInteger("Window", "Width", Width);
                iniFile.WriteInteger("Window", "Height", Height);
            }

            gridView1.SaveLayoutToXml(GridLayoutXml);

            Track.DoTrackEvent(TrackCategories.Application, "shutdown");
            SaveSelectedRepos();
        }

        private void SaveSelectedRepos()
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                var selectReposList = new List<string>();
                for (var i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    var row = gridView1.GetSelectedRows()[i];
                    if (!(gridView1.GetRow(row) is RepoModel repoModel)) continue;
                    selectReposList.Add(repoModel.Name);
                }

                Utilities.SaveStringList(SavedRepoSelectionsXml, selectReposList);
            }
            else
            {
                if (File.Exists(SavedRepoSelectionsXml))
                    File.Delete(SavedRepoSelectionsXml);
            }
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (!e.HitInfo.InRow)
                return;
            if (!(sender is GridView view))
                return;

            view.FocusedRowHandle = e.HitInfo.RowHandle;

            if (!(view.GetFocusedRow() is RepoModel repoModel))
                return;
            Cursor = Cursors.WaitCursor;
            try
            {
                solutionsToolStripMenuItem.DropDownItems.Clear();

                var solutionsList = repoModel.GetSolutionList();

                var toolStripItemList = new List<ToolStripMenuItem>();

                foreach (var solutionPath in solutionsList)
                {
                    var toolStripItem = new ToolStripMenuItem("", null, SolutionItemClick) { Text = solutionPath };

                    //var item = solutionsToolStripMenuItem.DropDownItems.Add(solutionPath);
                    //item.Click += SolutionItemClick; //libgit2sharp doesn't support switching local branches yet

                    toolStripItemList.Add(toolStripItem);
                }

                // ReSharper disable once CoVariantArrayConversion
                solutionsToolStripMenuItem.DropDownItems.AddRange(toolStripItemList.ToArray());

                var solCount = solutionsList.Count == 0 ? "None" : solutionsList.Count.ToString();
                solutionsToolStripMenuItem.Text = $"Solutions ({solCount})";


                branchesToolStripMenuItem.DropDownItems.Clear();
                var branchesList = repoModel.GetBranchesList();
                foreach (var branch in branchesList)
                {
                    var item = branchesToolStripMenuItem.DropDownItems.Add(branch);
                    item.Click += BranchItemClick;
                    item.Enabled = false;
                }

                var branchCount = branchesList.Count == 0 ? "None" : branchesList.Count.ToString();
                branchesToolStripMenuItem.Text = $"Branches ({branchCount})";

                var iniFile = new IniFile(OptionsIni);
                var showWebShortcuts = iniFile.ReadBool(OptionsForm.PreferencesSection, "ShowWebShortcuts", true);

                toolStripSeparator5.Visible = showWebShortcuts;
                toolStripMenuItemAzureDevOps.Visible = repoModel.RepoSourceType == RepoSourceTypeEnum.AzureDevOps && showWebShortcuts;
                remoteURLToolStripMenuItem.Visible = repoModel.RepoSourceType == RepoSourceTypeEnum.AzureDevOps && showWebShortcuts;
                toolStripMenuItemAdoCommits.Visible = repoModel.RepoSourceType == RepoSourceTypeEnum.AzureDevOps && showWebShortcuts;
                toolStripMenuItemAdoPushes.Visible = repoModel.RepoSourceType == RepoSourceTypeEnum.AzureDevOps && showWebShortcuts;
                toolStripMenuItemAdoBranches.Visible = repoModel.RepoSourceType == RepoSourceTypeEnum.AzureDevOps && showWebShortcuts;
                toolStripMenuItemAdoPulLRequests.Visible = repoModel.RepoSourceType == RepoSourceTypeEnum.AzureDevOps && showWebShortcuts;

                gitHubToolStripMenuItem.Visible = repoModel.RepoSourceType == RepoSourceTypeEnum.GitHub && showWebShortcuts;
                gitHubCodeToolStripMenuItem.Visible = repoModel.RepoSourceType == RepoSourceTypeEnum.GitHub && showWebShortcuts;
                gitHubIssuesToolStripMenuItem.Visible = repoModel.RepoSourceType == RepoSourceTypeEnum.GitHub && showWebShortcuts;

            }
            finally
            {
                Cursor = Cursors.Default;
            }

            focusedRepoNameToolStripMenuItem.Text = repoModel.Name;

            contextMenuStrip.Show(view.GridControl, e.Point);
        }

        private static void BranchItemClick(object sender, EventArgs e)
        {
            //libgit2sharp doesn't support switching local branches yet

            //if (!(gridView1.GetFocusedRow() is RepoModel repoModel))
            //    return;


            //using (var repo = new Repository(repoModel.Path))
            //{
            //    Debug.WriteLine($"{repoModel.Name} active branch: {repo.Head.UpstreamBranchCanonicalName}");

            //    var branchNameNoRefHead =
            //        repo.Head.UpstreamBranchCanonicalName.Replace("refs/heads/", "");

            //    repoModel.BranchName = branchNameNoRefHead;

            //    var branchesList = new List<string>();

            //    //Get local branches
            //    foreach (var b in repo.Branches.Where(b => !b.IsRemote))
            //    {
            //        var tempBranchNameNoRefHead =
            //            b.UpstreamBranchCanonicalName.Replace("refs/heads/", "");
            //        branchesList.Add(tempBranchNameNoRefHead);
            //    }

            //    // repoModel.BranchesList = branchesList;
            //}
        }

        private void SolutionItemClick(object sender, EventArgs e)
        {
            if (!(sender is ToolStripItem item))
                return;

            WindowState = FormWindowState.Minimized;

            Process.Start(item.Text);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRepoAction(RepoActionEnum.Open, true);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRepoAction(RepoActionEnum.Delete, true);
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            barSelectionStatus.Caption = $"{gridView1.SelectedRowsCount} selected";
        }

        private void barButtonItemOptions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Track.DoTrackEvent(TrackCategories.Application, "optionsForm.ShowDialog");
            var optionsForm = new OptionsForm();
            optionsForm.ShowDialog();
        }

        private void barButtonItemFetch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoRepoAction(RepoActionEnum.GitFetch);
        }

        private void fetchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRepoAction(RepoActionEnum.GitFetch, true);
        }

        private void pullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRepoAction(RepoActionEnum.GitPull, true);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRepoAction(RepoActionEnum.GitReset, true);
        }

        private void deleteBinobjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRepoAction(RepoActionEnum.DeleteBinObj, true);
        }

        private void deletevsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRepoAction(RepoActionEnum.DeleteVS, true);
        }

        private void remoteURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel)) return;

            Track.DoTrackEvent(TrackCategories.Web, "azureDevOpsCode");
            Process.Start(repoModel.RemoteURL);
        }

        private void barButtonItemAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Track.DoTrackEvent(TrackCategories.Application, "aboutForm.ShowDialog");
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();

        }

        private void barButtonItemClone_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Track.DoTrackEvent(TrackCategories.Application, "cloneForm.ShowDialog");
            var iniFile = new IniFile(OptionsIni);
            var defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");
            var repoPath = iniFile.ReadString(OptionsForm.PreferencesSection, "RepoPath", defaultPath);

            var cloneForm = new CloneForm { RootDirectory = repoPath };
            if (cloneForm.ShowDialog() != DialogResult.OK)
                return;

            if (cloneForm.RepoSourceTypeEnum == RepoSourceTypeEnum.Unknown)
                return;

            CloneGitRepo(cloneForm);
        }

        private static async void CloneGitRepo(CloneForm cloneForm)
        {
            await Utilities.CloneGitRepoAsync(cloneForm.RemoteURL, cloneForm.LocalPath, cloneForm.RepoSourceTypeEnum);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel))
                return;
            barStaticItemFocusedRepo.Caption = $"{repoModel.Name}";
            barStaticItemFocusedRepoStatus.Caption = $"{repoModel.ChangeString}";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridRowDoubleClick();
        }

        private void GridRowDoubleClick()
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel))
                return;

            var gridHitInfo = gridView1.CalcHitInfo(gridControl1.PointToClient(Cursor.Position));

            if (!gridHitInfo.InRowCell)
                return;


            var iniFile = new IniFile(OptionsIni);
            var actionIndex = iniFile.ReadInteger(OptionsForm.PreferencesSection, "DoubleClickAction", 6);
            Track.DoTrackEvent(TrackCategories.Application, "gridRowDoubleClick", actionIndex.ToString());
            switch (actionIndex)
            {
                case 0:
                    DoRepoAction(RepoActionEnum.GitFetch, true);
                    break;
                case 1:
                    DoRepoAction(RepoActionEnum.GitPull, true);
                    break;
                case 2:
                    DoRepoAction(RepoActionEnum.GitReset, true);
                    break;
                case 3:
                    DoRepoAction(RepoActionEnum.RunBatch, true);
                    break;
                case 4:
                    DoRepoAction(RepoActionEnum.DeleteBinObj, true);
                    break;
                case 5:
                    DoRepoAction(RepoActionEnum.DeleteVS, true);
                    break;
                case 6:
                    DoRepoAction(RepoActionEnum.Open, true);
                    break;
                case 7:
                    Process.Start(repoModel.RemoteURL);
                    break;
                case 8:
                    OpenPreferredSolutionFile(repoModel);
                    break;
                default:
                    Debug.WriteLine($"Unknown action index {actionIndex}");
                    break;
            }
        }

        private void OpenPreferredSolutionFile(RepoModel repoModel)
        {
            var filePath = Utilities.GetRepoPreferredSolution(repoModel);

            if (!string.IsNullOrEmpty(filePath))
            {
                WindowState = FormWindowState.Minimized;

                var iniFile = new IniFile(RepoPropertiesIni);
                var asAdmin = iniFile.ReadBool(repoModel.Name, "OpenPreferredSolutionAsAdmin", false);

                Track.DoTrackEvent(TrackCategories.LocalAction, "openPreferredSolutionFile");
                if (asAdmin)
                {
                    //This gives "No Application is associated with specified file for this operation" error
                    //var info = new ProcessStartInfo(filePath) { UseShellExecute = true, Verb = "", ErrorDialog = true};
                    //Process.Start(info);

                    var startInfo = new ProcessStartInfo
                    {
                        WindowStyle = ProcessWindowStyle.Hidden,
                        FileName = "cmd.exe",
                        Arguments = $"/C \"{filePath}\"",
                        Verb = "runas"
                    };
                    var process = new Process { StartInfo = startInfo };
                    process.Start();
                }
                else
                {
                    Process.Start(filePath);
                }
            }
            else
            {
                if (XtraMessageBox.Show(
                        "Preferred solution not set or file not found. Do you want to configure this now?",
                        "Cannot Find Preferred Solution",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    showRepoProperties();
                }
            }
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            var row = gridView1.GetRow(e.RowHandle);
            if (!(row is RepoModel repoModel)) return;

            e.Appearance.ForeColor = repoModel.SkipScan ? Color.Gray : Color.Black;
        }

        private void barButtonItemFeedback_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Track.DoTrackEvent(TrackCategories.Application, "feedback");
            Process.Start("https://github.com/ikathegreat/RepoManager/issues");
        }

        private void ignoreRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel))
                return;

            if (repoModel.SkipScan)
            {
                //Remove from ignore list
                const string skipReposSection = SkipRepoBrowseForm.SkipReposSection;
                var paths = new List<string>();

                var iniFile = new IniFile(OptionsIni);
                iniFile.ReadSection(skipReposSection, out var repoSectionList);

                foreach (var repo in repoSectionList)
                {
                    var item = iniFile.ReadString(skipReposSection, repo, "");
                    if (!string.IsNullOrEmpty(item))
                        paths.Add(item);
                }

                paths.Remove(repoModel.Path);

                iniFile.DeleteSection(skipReposSection);
                for (var i = 0; i < paths.Count; i++)
                {
                    iniFile.WriteString(skipReposSection, i.ToString(), paths[i]);
                }
            }
            else
            {
                //Add to ignore list
                const string skipReposSection = SkipRepoBrowseForm.SkipReposSection;
                var paths = new List<string>();

                var iniFile = new IniFile(OptionsIni);
                iniFile.ReadSection(skipReposSection, out var repoSectionList);

                foreach (var repo in repoSectionList)
                {
                    var item = iniFile.ReadString(skipReposSection, repo, "");
                    if (!string.IsNullOrEmpty(item))
                        paths.Add(item);
                }

                paths.Add(repoModel.Path);

                iniFile.DeleteSection(skipReposSection);
                for (var i = 0; i < paths.Count; i++)
                {
                    iniFile.WriteString(skipReposSection, i.ToString(), paths[i]);
                }

            }
            Track.DoTrackEvent(TrackCategories.Application, "toggleIgnoreRepo",
                repoModel.SkipScan ? "include" : "ignore");

            repoModel.SkipScan = !repoModel.SkipScan;
            gridView1.RefreshRow(gridView1.FocusedRowHandle);

            //Todo: Update row color now
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!(gridView1.GetFocusedRow() is RepoModel repoModel))
                return;

            ignoreRepoToolStripMenuItem.Text = repoModel.SkipScan ? "Include Repo in Scan" : "Ignore Repo";
        }

        private void toolStripMenuItemAdoPulLRequests_Click(object sender, EventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel)) return;
            Track.DoTrackEvent(TrackCategories.Web, "azureDevOpsPullRequests");
            Process.Start($"{repoModel.RemoteURL}/pullrequests?_a=active");
        }

        private void toolStripMenuItemAdoBranches_Click(object sender, EventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel)) return;
            Track.DoTrackEvent(TrackCategories.Web, "azureDevOpsBranches");
            Process.Start($"{repoModel.RemoteURL}/branches?_a=all");
        }

        private void toolStripMenuItemAdoPushes_Click(object sender, EventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel)) return;
            Track.DoTrackEvent(TrackCategories.Web, "azureDevOpsPushes");
            Process.Start($"{repoModel.RemoteURL}/pushes?itemVersion=GBmaster");
        }

        private void toolStripMenuItemAdoCommits_Click(object sender, EventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel)) return;
            Track.DoTrackEvent(TrackCategories.Web, "azureDevOpsCommits");
            Process.Start($"{repoModel.RemoteURL}/commits?itemPath=%2F&itemVersion=GBmaster");
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SearchRepos();
        }

        private void EditRunBatchFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel))
                return;

            Track.DoTrackEvent(TrackCategories.Application, "runBatFilesForm.ShowDialog");
            var runBatFilesForm = new RunBatFilesForm { RepoPath = repoModel.Path };
            runBatFilesForm.ShowDialog();
        }

        private void RunBatchFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRepoAction(RepoActionEnum.RunBatch, true);
        }

        private void BarButtonItemRunBatch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoRepoAction(RepoActionEnum.RunBatch);
        }

        private void CodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel)) return;
            Track.DoTrackEvent(TrackCategories.Web, "gitHubCode");

            Process.Start(repoModel.RemoteURL);
        }

        private void GitHubIssuesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!(gridView1.GetFocusedRow() is RepoModel repoModel)) return;
            Track.DoTrackEvent(TrackCategories.Web, "gitHubIssues");
            Process.Start($"{repoModel.RemoteURL.Replace(".git", "")}/issues");
        }

        private void toolStripMenuItemProperties_Click(object sender, EventArgs e)
        {
            showRepoProperties();
        }

        private void barButtonItemProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showRepoProperties();
        }

        private void showRepoProperties()
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel))
                return;

            Track.DoTrackEvent(TrackCategories.Application, "propertiesForm.ShowDialog");
            var propertiesForm = new RepoPropertiesForm(repoModel);
            propertiesForm.ShowDialog();
        }

        private void barButtonItemOpenPreferredSln_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!(gridView1.GetFocusedRow() is RepoModel repoModel))
                return;
            OpenPreferredSolutionFile(repoModel);
        }

        private void barButtonItemManageNuget_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoRepoAction(RepoActionEnum.ManageNuget);
        }

        private void nugetPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRepoAction(RepoActionEnum.ManageNuget, true);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Space:
                    Track.DoTrackEvent(TrackCategories.Application, "keyboardShortcut", "Space");
                    GridRowDoubleClick();
                    return true;
                case Keys.F5:
                    Track.DoTrackEvent(TrackCategories.Application, "keyboardShortcut", "F5");
                    SearchRepos();
                    return true;
                case Keys.Control | Keys.F:
                    Track.DoTrackEvent(TrackCategories.Application, "keyboardShortcut", "Ctrl+F");
                    DoRepoAction(RepoActionEnum.GitFetch);
                    return true;
                case Keys.Control | Keys.P:
                    Track.DoTrackEvent(TrackCategories.Application, "keyboardShortcut", "Ctrl+P");
                    DoRepoAction(RepoActionEnum.GitPull);
                    return true;
                case Keys.Control | Keys.R:
                    Track.DoTrackEvent(TrackCategories.Application, "keyboardShortcut", "Ctrl+R");
                    DoRepoAction(RepoActionEnum.GitReset);
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
