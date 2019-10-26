using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using RepoManager.Models;

namespace RepoManager
{
    public partial class RunBatFilesForm : Form
    {
        private readonly List<BatchFileModel> batchFileModelList = new List<BatchFileModel>();
        public RunBatFilesForm()
        {
            InitializeComponent();
        }

        public string RepoPath { get; set; }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            var iniFile = new IniFile(FormMain.RunBatchIni);
            foreach (var batFile in batchFileModelList)
            {
                var runBatchFile = iniFile.ReadBool(RepoPath,
                    batFile.FullPath, false);

                if (runBatchFile)
                    iniFile.WriteBool(RepoPath,
                        batFile.FullPath, false);

                if (batFile.RunBatchFile)
                    iniFile.WriteBool(RepoPath,
                        batFile.FullPath, true);
            }
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RunBatFilesForm_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(RepoPath))
            {
                var batFiles = Directory.GetFiles(RepoPath,
                    "*.bat", SearchOption.AllDirectories);

                var iniFile = new IniFile(FormMain.RunBatchIni);
                foreach (var batFile in batFiles)
                {

                    var batchFileModel = new BatchFileModel
                    {
                        FullPath = batFile,
                        RunBatchFile = iniFile.ReadBool(RepoPath,
                            batFile, false)
                    };

                    batchFileModelList.Add(batchFileModel);

                }
            }

            gridControl1.DataSource = batchFileModelList;
            gridView1.BestFitColumns();

            if (File.Exists(FormMain.GridRunBatchFilesXml))
                gridView1.RestoreLayoutFromXml(FormMain.GridRunBatchFilesXml);
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            RunSelectedBatchFile();
        }

        private void GridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {

            if (!e.HitInfo.InRow)
                return;
            if (!(sender is GridView view))
                return;

            view.FocusedRowHandle = e.HitInfo.RowHandle;

            if (!(view.GetFocusedRow() is BatchFileModel batchFileModel))
                return;

            contextMenuStrip.Show(view.GridControl, e.Point);
        }

        private void RunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunSelectedBatchFile();
        }

        private void RunSelectedBatchFile(bool openLocation = false)
        {

            if (!(gridView1.GetFocusedRow() is BatchFileModel batchFileModel))
                return;

            var gridHitInfo = gridView1.CalcHitInfo(gridControl1.PointToClient(Cursor.Position));

            if (!gridHitInfo.InRowCell)
                return;

            Process.Start(openLocation ? Path.GetDirectoryName(batchFileModel.FullPath) : batchFileModel.FullPath);
        }

        private void OpenLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunSelectedBatchFile(true);
        }

        private void RunBatFilesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridView1.SaveLayoutToXml(FormMain.GridRunBatchFilesXml);
        }
    }
}
