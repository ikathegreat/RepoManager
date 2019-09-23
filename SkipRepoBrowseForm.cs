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

namespace RepoManager
{
    public partial class SkipRepoBrowseForm : DevExpress.XtraEditors.XtraForm
    {
        public const string SkipReposSection = "SkipRepos";

        public SkipRepoBrowseForm()
        {
            InitializeComponent();
        }


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var folderPath = "";
            var fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.UserProfile
            };

            var dr = fbd.ShowDialog();

            if (dr != DialogResult.OK)
                return;
            folderPath = fbd.SelectedPath;
            if (folderPath != "")
            {
                textBoxPath.Text = folderPath;
            }

        }

        private void SkipRepoBrowseForm_Load(object sender, EventArgs e)
        {

            var iniFile = new IniFile(FormMain.OptionsIni);
            iniFile.ReadSection(SkipReposSection, out var repoSectionList);

            foreach (var repo in repoSectionList)
            {
                var item = iniFile.ReadString(SkipReposSection, repo, "");
                if (!string.IsNullOrEmpty(item))
                    listBoxPaths.Items.Add(item);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var iniFile = new IniFile(FormMain.OptionsIni);
            iniFile.DeleteSection(SkipReposSection);
            for (var i = 0; i < listBoxPaths.Items.Count; i++)
            {
                iniFile.WriteString(SkipReposSection, i.ToString(), listBoxPaths.Items[i].ToString());
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void listBoxPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPaths.SelectedIndex != -1)
            {
                buttonAction.Text = "Remove";
                textBoxPath.Text = listBoxPaths.SelectedItem.ToString();
            }
            else
            {
                buttonAction.Text = "Add";

            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPath.Text))
                return;

            if (buttonAction.Text == "Remove")
            {
                listBoxPaths.Items.Remove(textBoxPath.Text);
            }
            else
            {
                listBoxPaths.Items.Add(textBoxPath.Text);
            }

            textBoxPath.Text = "";
        }
    }
}
