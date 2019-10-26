using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NugetManagement;
using RepoManager.Models;

namespace RepoManager
{
    public partial class ManageNugetForm : Form
    {
        private readonly List<ModelFlatPackage> selectedModelFlatPackages = new List<ModelFlatPackage>();
        private readonly Processor processor;

        public ManageNugetForm()
        {
            InitializeComponent();

            var optionsIniFile = new IniFile(FormMain.OptionsIni);
            Width = optionsIniFile.ReadInteger("ManageNugetWindow", "Width", 1300);
            Height = optionsIniFile.ReadInteger("ManageNugetWindow", "Height", 700);
            groupBoxPackagesList.Height = optionsIniFile.ReadInteger("ManageNugetWindow", "PanelPackageListHeight", 660);

            var isMaximized = optionsIniFile.ReadBool("ManageNugetWindow", "IsMaximized", false);
            WindowState = isMaximized ? FormWindowState.Maximized : FormWindowState.Normal;

            processor = new Processor();
            processor.IncrementUpgradeProgressEvent += Processor_IncrementUpgradeProgressEvent;
        }

        private void Processor_IncrementUpgradeProgressEvent()
        {
            progressBarControl1.Increment(1);
        }

        public List<RepoModel> ReposList { get; set; } = new List<RepoModel>();

        private void ManageNugetForm_Load(object sender, System.EventArgs e)
        {
            ReposList.Select(x => x.Name).ToList().ForEach(y => listBoxRepos.Items.Add(y));

            ScanRepos();

            if (File.Exists(FormMain.GridNugetPackagesXml))
                gridViewPackagesList.RestoreLayoutFromXml(FormMain.GridNugetPackagesXml);

            if (File.Exists(FormMain.GridNugetToUpgradeXml))
                gridViewPackagesToUpgrade.RestoreLayoutFromXml(FormMain.GridNugetToUpgradeXml);
        }

        private void ScanRepos()
        {
            progressBarControl1.Visible = true;
            progressBarControl1.Position = 0;

            progressBarControl1.Properties.Maximum = ReposList.Count + 2;


            var searchPath = string.Empty;
            foreach (var repoModel in ReposList)
            {
                searchPath += repoModel.Path + "|";
                progressBarControl1.Increment(1);
            }

            searchPath = searchPath.TrimEnd('|');

            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
            processor.SolutionSearchPath = searchPath;

            if (!processor.IsValidSearchPath())
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            Enabled = false;
            Application.DoEvents();
            try
            {
                processor.BuildSolutionList();
                progressBarControl1.Increment(1);

                processor.BuildPackagesLists(radioButtonLatestUsed.Checked
                        ? GetUpgradePackagesMode.Latest
                        : GetUpgradePackagesMode.Manual);
                progressBarControl1.Increment(1);

                gridControl1.DataSource = processor.ModelFlatPackageList;
                gridControl2.DataSource = processor.DistinctPackagesToUpgradeList;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Enabled = true;

                progressBarControl1.Visible = false;
            }

        }

        private void ManageNugetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var optionsIniFile = new IniFile(FormMain.OptionsIni);
            optionsIniFile.WriteBool("ManageNugetWindow", "IsMaximized", WindowState == FormWindowState.Maximized);

            if (WindowState == FormWindowState.Normal)
            {
                optionsIniFile.WriteInteger("ManageNugetWindow", "Width", Width);
                optionsIniFile.WriteInteger("ManageNugetWindow", "Height", Height);
            }

            optionsIniFile.WriteInteger("ManageNugetWindow", "PanelPackageListHeight", groupBoxPackagesList.Height);

            gridViewPackagesList.SaveLayoutToXml(FormMain.GridNugetPackagesXml);
            gridViewPackagesToUpgrade.SaveLayoutToXml(FormMain.GridNugetToUpgradeXml);
        }

        private void upgradeMethodRadioChanged(object sender, EventArgs e)
        {
            ScanRepos();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!(gridControl2.DataSource is List<ModelPackageUpgrade> packageUpgradeList))
                return;

            processor.SelectedModelPackageUpgradeList = packageUpgradeList;

            var upgradeCount = processor.SelectedModelPackageUpgradeList.Count(x => x.Upgrade);

            if (upgradeCount < 1)
            {
                MessageBox.Show("You need to select some nuget packages to upgrade!", "Duh!");
                return;
            }


            if (MessageBox.Show($"Upgrade {upgradeCount} nuget package{(upgradeCount == 1 ? "" : "s")}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            //Validate again search path
            if (!processor.IsValidSearchPath())
                return;

            //Start processing
            progressBarControl1.Visible = true;
            progressBarControl1.Position = 0;

            progressBarControl1.Properties.Maximum =
                processor.ModelSolutionList.SelectMany(x => x.ProjectList).SelectMany(y => y.PackageList).Count();

            Application.DoEvents();

            var packageUpgradeCount = processor.UpgradeSelectedPackages();

            MessageBox.Show($"Nuget package upgrade processing completed.{Environment.NewLine}{Environment.NewLine}{packageUpgradeCount} packages upgraded.");

            progressBarControl1.Visible = false;
            ScanRepos();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hyperlinkLabelControlLastUsedHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Last Used will used the latest version on any of the found projects. Use this method if you are trying to consolidate all nuget package versions to use the local latest version.");

        }

        private void hyperlinkLabelControlManualHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manual will allow you to manually enter the desired nuget version. Use this method if none of the local projects are currently using a higher remote version.");

        }

        private ModelFlatPackage GetSelectedModelFlatPackage()
        {
            return selectedModelFlatPackages.Count != 1 ? null : selectedModelFlatPackages.FirstOrDefault();
        }

        private void openSolutionFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var solutionDirPath = Path.GetDirectoryName(GetSelectedModelFlatPackage()?.SolutionFullPath);

            if (!Directory.Exists(solutionDirPath))
                return;

            Process.Start(solutionDirPath);
        }

        private void openProjectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var projectDirPath = Path.GetDirectoryName(GetSelectedModelFlatPackage()?.ProjectFullPath);

            if (!Directory.Exists(projectDirPath))
                return;

            Process.Start(projectDirPath);
        }

        private void openSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var solutionPath = GetSelectedModelFlatPackage()?.SolutionFullPath;

            if (!File.Exists(solutionPath))
                return;

            if (solutionPath != null)
                Process.Start(solutionPath);
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var projectPath = GetSelectedModelFlatPackage()?.ProjectFullPath;

            if (!File.Exists(projectPath))
                return;

            if (projectPath != null)
                Process.Start(projectPath);
        }

        private void openPackagesConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var projectDirPath = Path.GetDirectoryName(GetSelectedModelFlatPackage()?.ProjectFullPath);

            if (!Directory.Exists(projectDirPath))
                return;

            var packagesConfigPath = Path.Combine(projectDirPath, "packages.config");
            if (!File.Exists(packagesConfigPath))
                return;

            Process.Start(packagesConfigPath);
        }

        private void openNugetSourceFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedModelFlatPackage = GetSelectedModelFlatPackage();
            if (selectedModelFlatPackage == null)
                return;
            var sourceFolderName = Path.Combine(
                Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)),
                "Users", Environment.UserName, ".nuget", "packages",
                selectedModelFlatPackage.PackageName,
                selectedModelFlatPackage.Version.ToString());

            if (Directory.Exists(sourceFolderName))
                Process.Start(sourceFolderName);
            else
            {
                MessageBox.Show($"Directory does not exist:" + Environment.NewLine
                                                             + Environment.NewLine
                                                             + sourceFolderName);
            }
        }

        private void gridViewPackagesList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            selectedModelFlatPackages.Clear();

            for (var i = 0; i < gridViewPackagesList.SelectedRowsCount; i++)
            {
                var row = (gridViewPackagesList.GetSelectedRows()[i]);
                if (!(gridViewPackagesList.GetRow(row) is ModelFlatPackage obj)) continue;
                selectedModelFlatPackages.Add(obj);
            }
        }
    }
}
