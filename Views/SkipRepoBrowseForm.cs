using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using RepoManager.Analytics;
using RepoManager.Models;

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
            var initialDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var initGitPath = Path.Combine(initialDir, "source", "repos");
            if (Directory.Exists(initGitPath))
            {
                initialDir = initGitPath;
            }

            if (Directory.Exists(textBoxPath.Text))
            {
                initialDir = textBoxPath.Text;
            }

            var dialog = new CommonOpenFileDialog
            {
                InitialDirectory = initialDir, 
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxPath.Text = dialog.FileName;
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

            buttonAction.Enabled = listBoxPaths.Items.Count != 0;
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
                textBoxPath.Text = listBoxPaths.SelectedItem.ToString();
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPath.Text))
                return;

            if (buttonAction.Text == "Remove")
            {
                listBoxPaths.Items.Remove(textBoxPath.Text);
                textBoxPath.Text = "";
            }
            else
            {
                var repoGitFolder = Path.Combine(textBoxPath.Text, ".git");
                if (!Directory.Exists(repoGitFolder))
                {
                    if (MessageBox.Show("Selected directory does not have a .git folder. Add anyway?",
                            "Add Non-Git Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
                listBoxPaths.Items.Add(textBoxPath.Text);
            }

            Track.DoTrackEvent(TrackCategories.Option, "addRepoToIgnore");
            buttonAction.Text = listBoxPaths.Items.Contains(textBoxPath.Text) ? "Remove" : "Add";
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            buttonAction.Enabled = !string.IsNullOrEmpty(textBoxPath.Text);
            buttonAction.Text = listBoxPaths.Items.Contains(textBoxPath.Text) ? "Remove" : "Add";
        }
    }
}
