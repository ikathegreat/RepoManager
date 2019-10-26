using System;
using System.Collections.Generic;

using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using RepoManager.Models;

namespace RepoManager
{
    public partial class SummaryForm : DevExpress.XtraEditors.XtraForm
    {
        public SummaryForm()
        {
            InitializeComponent();

            var iniFile = new IniFile(FormMain.OptionsIni);

            var isMaximized = iniFile.ReadBool("SummaryWindow", "IsMaximized", false);
            WindowState = isMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
            if (WindowState == FormWindowState.Normal)
            {
                Width = iniFile.ReadInteger("SummaryWindow", "Width", 1000);
                Height = iniFile.ReadInteger("SummaryWindow", "Height", 600);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        public List<SummaryRecord> SummaryRecordList { get; set; }

        private void SummaryForm_Load(object sender, EventArgs e)
        {

            if (SummaryRecordList != null)
                gridControl1.DataSource = SummaryRecordList;

            gridView1.BestFitColumns();

            var successCount = 0;
            var errorCount = 0;
            for (var i = 0; i < gridView1.DataRowCount; i++)
            {
                var row = gridView1.GetRow(i);
                if (!(row is SummaryRecord summaryRecord)) continue;

                switch (summaryRecord.Result)
                {
                    case "Success":
                        successCount++;
                        break;
                    case "Error":
                        errorCount++;
                        break;
                }
            }

            labelStatus.Text = $"{gridView1.DataRowCount} repositories - {successCount} OK, {errorCount} errors";


            if (File.Exists(FormMain.GridSummaryXml))
                gridView1.RestoreLayoutFromXml(FormMain.GridSummaryXml);
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            var row = gridView1.GetRow(e.RowHandle);
            if (!(row is SummaryRecord summaryRecord)) return;

            e.Appearance.ForeColor = summaryRecord.Result == "Success" ? Color.Black : Color.Red;
        }

        private void SummaryRecordBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SummaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var iniFile = new IniFile(FormMain.OptionsIni);
            iniFile.WriteBool("SummaryWindow", "IsMaximized", WindowState == FormWindowState.Maximized);

            if (WindowState == FormWindowState.Normal)
            {
                iniFile.WriteInteger("SummaryWindow", "Width", Width);
                iniFile.WriteInteger("SummaryWindow", "Height", Height);
            }


            gridView1.SaveLayoutToXml(FormMain.GridSummaryXml);
        }
    }
}
