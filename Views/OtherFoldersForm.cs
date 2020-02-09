using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RepoManager.Models;

namespace RepoManager.Views
{
    public partial class OtherFoldersForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<RepoModel> selectedRepoModelList = new List<RepoModel>();

        public OtherFoldersForm()
        {
            InitializeComponent();

            var optionsIniFile = new IniFile(FormMain.OptionsIni);
            Width = optionsIniFile.ReadInteger("OtherFoldersWindow", "Width", 1100);
            Height = optionsIniFile.ReadInteger("OtherFoldersWindow", "Height", 500);

            var isMaximized = optionsIniFile.ReadBool("OtherFoldersWindow", "IsMaximized", false);
            WindowState = isMaximized ? FormWindowState.Maximized : FormWindowState.Normal;

        }

        private void OtherFoldersForm_Load(object sender, EventArgs e)
        {
            scanNonGitRepos();

            if (File.Exists(FormMain.GridOtherFoldersXml))
                gridViewOtherFolders.RestoreLayoutFromXml(FormMain.GridOtherFoldersXml);
        }

        private async void scanNonGitRepos()
        {
            //List<RepoModel> reposList;
            var iniFile = new IniFile(FormMain.OptionsIni);
            var defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");
            var reposPath = iniFile.ReadString(OptionsForm.PreferencesSection, "RepoPath", defaultPath);

            try
            {

                if (!Directory.Exists(reposPath))
                {
                    barStaticItemFocusedRepo.Caption = "";
                    barStaticItemFocusedRepoStatus.Caption = "";
                    return;
                }

                var reposList = await Utilities.ScanForRepositoriesAsync(reposPath, false);
                gridControl1.DataSource = reposList;


                var listOfTasks = new List<Task>();

                var cts = new CancellationTokenSource();
                var ct = cts.Token;
                foreach (var repoModel in reposList)
                {
                    listOfTasks.Add(Utilities.GetRepoGitInfoAsync(repoModel, ct));
                    listOfTasks.Add(Utilities.GetRepoModelSolutionsList(repoModel, reposPath, ct));
                    if (repoModel.SkipScan)
                        continue;
                    listOfTasks.Add(Utilities.GetRepositorySize(repoModel, ct));
                    listOfTasks.Add(Utilities.GetRepoNumberOfFiles(repoModel, ct));
                    listOfTasks.Add(Utilities.GetRepositoryChanges(repoModel, ct));

                }

                var entireTask1 = Task.WhenAll(listOfTasks);
                while (await Task.WhenAny(entireTask1, Task.Delay(100, ct)) != entireTask1)
                {
                    if (ct.IsCancellationRequested)
                        break;
                    var completeCount = listOfTasks.Count(x => x.Status == TaskStatus.RanToCompletion);

                    gridControl1.RefreshDataSource();
                }
            }
            catch
            {
            }
        }

        private void OtherFoldersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var optionsIniFile = new IniFile(FormMain.OptionsIni);
            optionsIniFile.WriteBool("OtherFoldersWindow", "IsMaximized", WindowState == FormWindowState.Maximized);

            if (WindowState == FormWindowState.Normal)
            {
                optionsIniFile.WriteInteger("OtherFoldersWindow", "Width", Width);
                optionsIniFile.WriteInteger("OtherFoldersWindow", "Height", Height);
            }

            gridViewOtherFolders.SaveLayoutToXml(FormMain.GridOtherFoldersXml);
        }

        private void getSelectedRepos()
        {
            selectedRepoModelList.Clear();

            for (var i = 0; i < gridViewOtherFolders.SelectedRowsCount; i++)
            {
                var row = gridViewOtherFolders.GetSelectedRows()[i];
                if (!(gridViewOtherFolders.GetRow(row) is RepoModel checkedRepoModel)) continue;
                selectedRepoModelList.Add(checkedRepoModel);
                //GetDependentRepoModelsForProcessing(checkedRepoModel, selectedRepoModelList);
            }


            selectedRepoModelList = selectedRepoModelList.Distinct().ToList();
        }

        private void barButtonItemRunBatch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            getSelectedRepos();

            if (selectedRepoModelList.Count == 0)
                return;

            var totalBatchFileCount = 0;
       
                foreach (var selectedRepoModel in selectedRepoModelList)
                {
                    totalBatchFileCount += Utilities.GetBatchFileCount(selectedRepoModel);
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
                        if (XtraMessageBox.Show($"Run {Utilities.GetFirstSelectedBatchFileName(selectedRepoModelList.First())} in {countAndRepoMsg}?",
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

        private void barButtonItemDeleteBinObj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
