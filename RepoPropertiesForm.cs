using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using RepoManager.Models;

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
            var slnList = repoModel.GetSolutionList();
            slnList.ForEach(x => comboBoxPreferredSolution.Items.Add(x));

            iniFile = new IniFile(FormMain.RepoPropertiesIni);
            comboBoxPreferredSolution.Text = iniFile.ReadString(repoModel.Name, "PreferredSolution", "");
            checkBoxOpenAsAdmin.Checked = iniFile.ReadBool(repoModel.Name, "OpenPreferredSolutionAsAdmin", false);

            if (string.IsNullOrEmpty(comboBoxPreferredSolution.Text) && slnList.Count == 1)
                comboBoxPreferredSolution.SelectedIndex = 0;

            //Todo: Option for number of commits
            var commitHistory = Utilities.DoGitCommitHistoryRetrieve(repoModel, 50);
            gridControl1.DataSource = commitHistory;
            gridView1.BestFitColumns();

            var changedFiles = Utilities.DoGitChangedFilesRetrieve(repoModel, 50);
            gridControl2.DataSource = changedFiles;
            gridView2.BestFitColumns();

            LoadChart(commitHistory);
        }

        private void LoadChart(IReadOnlyCollection<SimpleCommit> commitHistory)
        {
            tabControl1.TabPages.Remove(tabPageChangeTrends);
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

            ((LineSeriesView) series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView) series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView) series1.View).LineStyle.DashStyle = DashStyle.Dash;

            ((XYDiagram) lineChart.Diagram).EnableAxisXZooming = true;

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
            Close();
        }

        private void RepoPropertiesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var optionsIniFile = new IniFile(FormMain.OptionsIni);
            optionsIniFile.WriteBool("RepoPropertiesWindow", "IsMaximized", WindowState == FormWindowState.Maximized);
            optionsIniFile.WriteInteger("RepoPropertiesWindow", "Width", Width);
            optionsIniFile.WriteInteger("RepoPropertiesWindow", "Height", Height);
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

            if (!(gridView2.GetFocusedRow() is SimpleFileChange simpleFileChange))
                return;

            if (File.Exists(simpleFileChange.Path))
                Process.Start(simpleFileChange.Path);
        }
    }
}
