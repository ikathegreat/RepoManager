using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepoManager.Models;

namespace RepoManager.Views
{
    public partial class OtherFoldersForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public OtherFoldersForm()
        {
            InitializeComponent();
        }

        private void OtherFoldersForm_Load(object sender, EventArgs e)
        {
            scanNonGitRepos();
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

                barSelectionStatus.Caption = "Refreshing repository lists...";
                var reposList = await Utilities.ScanForRepositoriesAsync(reposPath, false);
                gridControl1.DataSource = reposList;
            }
            catch
            {
            }
        }
    }
}
