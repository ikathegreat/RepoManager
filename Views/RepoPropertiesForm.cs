using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using RepoManager.Models;
using RepoManager.Views;

namespace RepoManager
{
    public partial class RepoPropertiesForm : Form
    {


        private readonly RepoModel repoModel;
        private IniFile iniFile;
        public RepoPropertiesForm(RepoModel aRepoModel)
        {
            InitializeComponent();
            repoModel = aRepoModel;


            var optionsIniFile = new IniFile(FormMain.OptionsIni);
            Width = optionsIniFile.ReadInteger("RepoPropertiesWindow", "Width", 1000);
            Height = optionsIniFile.ReadInteger("RepoPropertiesWindow", "Height", 600);

            var isMaximized = optionsIniFile.ReadBool("RepoPropertiesWindow", "IsMaximized", false);
            WindowState = isMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RepoPropertiesForm_Load(object sender, EventArgs e)
        {
            //Remove
            tabControl1.TabPages.Remove(tabPageChangeTrends);

            Cursor.Current = Cursors.WaitCursor;

            var slnList = repoModel.GetSolutionList();
            slnList.ForEach(x => comboBoxPreferredSolution.Items.Add(x));

            iniFile = new IniFile(FormMain.RepoPropertiesIni);
            comboBoxPreferredSolution.Text = iniFile.ReadString(repoModel.Name, "PreferredSolution", "");
            checkBoxOpenAsAdmin.Checked = iniFile.ReadBool(repoModel.Name, "OpenPreferredSolutionAsAdmin", false);

            gridControl1.Enabled = false;
            gridControl2.Enabled = false;
            timer1.Start();

            if (string.IsNullOrEmpty(comboBoxPreferredSolution.Text) && slnList.Count == 1)
                comboBoxPreferredSolution.SelectedIndex = 0;



            checkBoxEnableSmartGit.Checked = iniFile.ReadBool(repoModel.Name, "EnableSmartGit", false);
            panelSmartGitRepo.Enabled = checkBoxEnableSmartGit.Checked;

            var linkedReposString = iniFile.ReadString(repoModel.Name, "SmartGitLinkedRepos", "");

            if (string.IsNullOrEmpty(linkedReposString))
                listBoxSmartGitLinkedRepos.Items.Add("(Auto Detect)");
            else
                linkedReposString.Split('|').ToList().ForEach(x => listBoxSmartGitLinkedRepos.Items.Add(x));

            tabControl1.SelectedIndex = iniFile.ReadInteger(repoModel.Name, "LastTabIndex", 0);

            labelLinkedReposCount.Text = $"{repoModel.GetDependentRepoNamesList().Count} linked repo(s)";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            gridControl1.Enabled = true;

            //Todo: Option for number of commits
            var commitHistory = Utilities.DoGitCommitHistoryRetrieve(repoModel, 50);
            gridControl1.DataSource = commitHistory;
            gridView1.BestFitColumns();

            var changedFiles = Utilities.DoGitChangedFilesRetrieve(repoModel, 50);
            gridControl2.DataSource = changedFiles;
            gridView2.BestFitColumns();

            LoadChart(commitHistory);

            if (File.Exists(FormMain.GridRecentFilesXml))
                gridView2.RestoreLayoutFromXml(FormMain.GridRecentFilesXml);

            if (File.Exists(FormMain.GridCommitHistoryXml))
                gridView1.RestoreLayoutFromXml(FormMain.GridCommitHistoryXml);

            gridControl1.Enabled = true;
            gridControl2.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void LoadChart(IReadOnlyCollection<SimpleCommit> commitHistory)
        {
            return;

            var lineChart = new ChartControl();
            var series1 = new Series("Series 1", ViewType.Line);

            foreach (var dateTime in commitHistory.Select(x => x.Date).Distinct().ToList())
            {
                var sumChangeCount = commitHistory.Where(x => x.Date == dateTime).Sum(y => y.ChangeCount);
                series1.Points.Add(new SeriesPoint(dateTime, sumChangeCount));
            }

            //foreach (var commit in commitHistory.Select(x=>x.Date).Distinct().ToList())
            //{
            //    series1.Points.Add(new SeriesPoint(commit.Date, commit.ChangeCount));
            //}

            //Get oldest date, loop each day since then, and select commits matching the date and sum the change count. Wtf.

            //How is this displaying decimals for Y?

            //series1.Points.Add(new SeriesPoint(1, 2));
            //series1.Points.Add(new SeriesPoint(2, 12));
            //series1.Points.Add(new SeriesPoint(3, 14));
            //series1.Points.Add(new SeriesPoint(4, 17));

            lineChart.Series.Add(series1);
            // series1.ArgumentScaleType = ScaleType.Numerical;
            series1.ArgumentScaleType = ScaleType.DateTime;

            ((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Dash;

            ((XYDiagram)lineChart.Diagram).EnableAxisXZooming = true;

            lineChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            //lineChart.Titles.Add(new ChartTitle());
            //lineChart.Titles[0].Text = "Recent File Changes";

            lineChart.Dock = DockStyle.Fill;
            tabPageChangeTrends.Controls.Add(lineChart);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            iniFile.WriteString(repoModel.Name, "PreferredSolution", comboBoxPreferredSolution.Text);
            iniFile.WriteBool(repoModel.Name, "OpenPreferredSolutionAsAdmin", checkBoxOpenAsAdmin.Checked);

            iniFile.WriteBool(repoModel.Name, "EnableSmartGit", checkBoxEnableSmartGit.Checked);
            iniFile.WriteString(repoModel.Name, "SmartGitLinkedRepos",
                string.Join("|", listBoxSmartGitLinkedRepos.Items.OfType<string>().ToArray()));

            var linkedReposString = iniFile.ReadString(repoModel.Name, "SmartGitLinkedRepos", "");

            if (string.IsNullOrEmpty(linkedReposString))
                listBoxSmartGitLinkedRepos.Items.Add("(Auto Detect)");
            else
                linkedReposString.Split('|').ToList().ForEach(x => listBoxSmartGitLinkedRepos.Items.Add(x));

            iniFile.WriteInteger(repoModel.Name, "LastTabIndex", tabControl1.SelectedIndex);


            Close();
        }

        private void RepoPropertiesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var optionsIniFile = new IniFile(FormMain.OptionsIni);
            optionsIniFile.WriteBool("RepoPropertiesWindow", "IsMaximized", WindowState == FormWindowState.Maximized);

            if (WindowState == FormWindowState.Normal)
            {
                optionsIniFile.WriteInteger("RepoPropertiesWindow", "Width", Width);
                optionsIniFile.WriteInteger("RepoPropertiesWindow", "Height", Height);
            }

            gridView2.SaveLayoutToXml(FormMain.GridRecentFilesXml);
            gridView1.SaveLayoutToXml(FormMain.GridCommitHistoryXml);
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

            if (!(gridView2.GetFocusedRow() is SimpleFileChange simpleFileChange))
                return;

            if (File.Exists(simpleFileChange.Path))
                Process.Start(simpleFileChange.Path);
        }

        private void buttonAutoDetect_Click(object sender, EventArgs e)
        {
            if (!listBoxSmartGitLinkedRepos.Items.Contains("(Auto Detect)"))
                listBoxSmartGitLinkedRepos.Items.Add("(Auto Detect)");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxSmartGitLinkedRepos.SelectedItem;
            if (selectedItem != null)
                listBoxSmartGitLinkedRepos.Items.Remove(selectedItem);
        }

        private void buttonAddSingleRepo_Click(object sender, EventArgs e)
        {
            var defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");
            var reposPath = iniFile.ReadString(OptionsForm.PreferencesSection, "RepoPath", defaultPath);

            var reposList = new List<string>();
            Directory.EnumerateDirectories(reposPath).ToList().ForEach(x => reposList.Add(Path.GetFileName(x)));

            for (var i = reposList.Count - 1; i >= 0; i--)
            {
                if (!Directory.Exists(reposPath + "\\" + reposList[i] + "\\.git"))
                {
                    reposList.RemoveAt(i);
                }

            }

            var addLinkedRepoForm = new AddLinkedRepoForm
            {
                ReposList = reposList
            };

            if (addLinkedRepoForm.ShowDialog() != DialogResult.OK)
                return;

            if (!listBoxSmartGitLinkedRepos.Items.Contains(addLinkedRepoForm.SelectedRepo))
                listBoxSmartGitLinkedRepos.Items.Add(addLinkedRepoForm.SelectedRepo);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panelSmartGitRepo.Enabled = checkBoxEnableSmartGit.Checked;
        }

        private void buttonCheckAutoDetect_Click(object sender, EventArgs e)
        {
            var dependentRepoNamesList = repoModel.GetDependentRepoNamesList();

            if (dependentRepoNamesList.Count == 0)
            {
                MessageBox.Show($"{repoModel.Name} has no linked repos");
                return;
            }

            var reposString = string.Join(Environment.NewLine, dependentRepoNamesList);

            MessageBox.Show($"{repoModel.Name} has {dependentRepoNamesList.Count} linked repo(s):"
                            + Environment.NewLine + Environment.NewLine + reposString);
        }

    }
}
