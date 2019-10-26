using System;
using System.Diagnostics;
using System.Reflection;

namespace RepoManager
{
    public partial class AboutForm : DevExpress.XtraEditors.XtraForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label3.Text = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
        }
    }
}