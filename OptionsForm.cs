using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace RepoManager
{
    public partial class OptionsForm : DevExpress.XtraEditors.XtraForm
    {
        public const string AuthenticationSection = "Authentication";
        public const string PreferencesSection = "Preferences";
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var iniFile = new IniFile(FormMain.OptionsIni);

            iniFile.WriteString(AuthenticationSection, "AzureDevOpsUserName", textBoxAzureDevOpsUserName.Text);
            var AzureDevOpsHexPassword = Utilities.ConvertStringToHexString(textBoxAzureDevOpsPassword.Text);
            iniFile.WriteString(AuthenticationSection, "AzureDevOpsPassword", AzureDevOpsHexPassword);

            iniFile.WriteString(AuthenticationSection, "GitHubUserName", textBoxGitHubUsername.Text);
            var gitHubHexPassword = Utilities.ConvertStringToHexString(textBoxGitHubPassword.Text);
            iniFile.WriteString(AuthenticationSection, "GitHubPassword", gitHubHexPassword);

            iniFile.WriteInteger(PreferencesSection, "DoubleClickAction", comboBox1.SelectedIndex);

            iniFile.WriteString(PreferencesSection, "RepoPath", textBoxRepoSearchPath.Text);

            iniFile.WriteString(AuthenticationSection, "AzureDevOpsHostUrl", textBoxHostUrl.Text);

            iniFile.WriteBool(AuthenticationSection, "UseUsernameAndPassword", radioButtonUserNamePassword.Checked);
            var adoPatValue = Utilities.ConvertStringToHexString(textBoxPATValue.Text);
            iniFile.WriteString(AuthenticationSection, "AzureDevOpsPAT", adoPatValue);

            Close();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {

            var iniFile = new IniFile(FormMain.OptionsIni);

            textBoxAzureDevOpsUserName.Text = iniFile.ReadString(AuthenticationSection, "AzureDevOpsUserName", "");
            var AzureDevOpsHexPassword = iniFile.ReadString(AuthenticationSection, "AzureDevOpsPassword", "");
            textBoxAzureDevOpsPassword.Text = Utilities.ConvertHexStringToString(AzureDevOpsHexPassword);

            textBoxGitHubUsername.Text = iniFile.ReadString(AuthenticationSection, "GitHubUserName", "");
            var gitHubHexPassword = iniFile.ReadString(AuthenticationSection, "GitHubPassword", "");
            textBoxGitHubPassword.Text = Utilities.ConvertHexStringToString(gitHubHexPassword);

            textBoxHostUrl.Text = iniFile.ReadString(AuthenticationSection, "AzureDevOpsHostUrl", "");

            radioButtonUserNamePassword.Checked =
                iniFile.ReadBool(AuthenticationSection, "UseUsernameAndPassword", true);
            radioButtonPAT.Checked = !radioButtonUserNamePassword.Checked;
            radioCheckChanged(null, null);

            var adoHexPat = iniFile.ReadString(AuthenticationSection, "AzureDevOpsPAT", "");
            textBoxPATValue.Text = Utilities.ConvertHexStringToString(adoHexPat);

            comboBox1.SelectedIndex = iniFile.ReadInteger(PreferencesSection, "DoubleClickAction", 6);

            iniFile.ReadSection(SkipRepoBrowseForm.SkipReposSection, out var repoSectionList);
            labelRepoSkipCount.Text = $"{repoSectionList.Count} repos";

            var defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");
            textBoxRepoSearchPath.Text = iniFile.ReadString(PreferencesSection, "RepoPath", defaultPath);

            //Todo: Finish this. Currently facing too many redirects error. Might be version of lib2gitsharp version.
            radioButtonPAT.Visible = false;
            labelPATToken.Visible = false;
            textBoxPATValue.Visible = false;


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRepoSkipBrowse_Click(object sender, EventArgs e)
        {
            var skipRepoBrowseForm = new SkipRepoBrowseForm();
            if (skipRepoBrowseForm.ShowDialog() != DialogResult.OK) return;
            var iniFile = new IniFile(FormMain.OptionsIni);
            iniFile.ReadSection(SkipRepoBrowseForm.SkipReposSection, out var repoSectionList);
            labelRepoSkipCount.Text = $"{repoSectionList.Count} repos";

        }

        private void ButtonRepoSearchPathBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                InitialDirectory = textBoxRepoSearchPath.Text,
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxRepoSearchPath.Text = dialog.FileName;
            }
        }

        private void radioCheckChanged(object sender, EventArgs e)
        {
            labelAzureDevOpsUsername.Enabled = radioButtonUserNamePassword.Checked;
            textBoxAzureDevOpsUserName.Enabled = radioButtonUserNamePassword.Checked;
            labelAzureDevOpsPassword.Enabled = radioButtonUserNamePassword.Checked;
            textBoxAzureDevOpsPassword.Enabled = radioButtonUserNamePassword.Checked;

            labelPATToken.Enabled = radioButtonPAT.Checked;
            textBoxPATValue.Enabled = radioButtonPAT.Checked;
        }
    }
}
