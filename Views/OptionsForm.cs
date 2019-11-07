using System;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using RepoManager.Analytics;
using RepoManager.Models;

namespace RepoManager
{
    public partial class OptionsForm : MaterialForm
    {
        public const string AuthenticationSection = "Authentication";
        public const string PreferencesSection = "Preferences";

        private const int DefaultDoubleClickIndex = 6;

        public OptionsForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

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

            var selectedIndex = 0;
            foreach (ToolStripItem toolStripItem in materialContextMenuStrip1.Items)
            {

                if (!(toolStripItem is ToolStripMenuItem toolStripMenuItem))
                    continue;
                if (!toolStripMenuItem.Checked)
                    continue;
                selectedIndex = Convert.ToInt32(toolStripMenuItem.Tag);
            }

            if (selectedIndex != DefaultDoubleClickIndex)
                Track.DoTrackEvent(TrackCategories.Option, "changeRepoDoubleClickOption",
                    selectedIndex.ToString());

            iniFile.WriteInteger(PreferencesSection, "DoubleClickAction", selectedIndex);

            iniFile.WriteString(PreferencesSection, "RepoPath", textBoxRepoSearchPath.Text);

            iniFile.WriteString(AuthenticationSection, "AzureDevOpsHostUrl", textBoxHostUrl.Text);

            iniFile.WriteBool(AuthenticationSection, "UseUsernameAndPassword", radioButtonUserNamePassword.Checked);
            var adoPatValue = Utilities.ConvertStringToHexString(textBoxPATValue.Text);
            iniFile.WriteString(AuthenticationSection, "AzureDevOpsPAT", adoPatValue);

            if (!checkBoxShowWebShortcuts.Checked)
                Track.DoTrackEvent(TrackCategories.Option, "hideWebShortcuts");
            iniFile.WriteBool(PreferencesSection, "ShowWebShortcuts", checkBoxShowWebShortcuts.Checked);

            if (!checkBoxAnalytics.Checked)
                Track.DoTrackEvent(TrackCategories.Option, "optOutAnalytics");

            iniFile.WriteBool(PreferencesSection, "DoAnalytics", checkBoxAnalytics.Checked);

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

            var selectedIndex = iniFile.ReadInteger(PreferencesSection, "DoubleClickAction", DefaultDoubleClickIndex);

            foreach (ToolStripItem toolStripItem in materialContextMenuStrip1.Items)
            {
                if (Convert.ToInt32(toolStripItem.Tag) != selectedIndex)
                    continue;

                if (!(toolStripItem is ToolStripMenuItem toolStripMenuItem))
                    continue;
                toolStripMenuItem.Checked = true;
                materialFlatButtonDoubleClick.Text = toolStripMenuItem.Text;
            }

            iniFile.ReadSection(SkipRepoBrowseForm.SkipReposSection, out var repoSectionList);
            labelRepoSkipCount.Text = $"{repoSectionList.Count} repos";

            var defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");
            textBoxRepoSearchPath.Text = iniFile.ReadString(PreferencesSection, "RepoPath", defaultPath);

            checkBoxShowWebShortcuts.Checked = iniFile.ReadBool(PreferencesSection, "ShowWebShortcuts", true);
            checkBoxAnalytics.Checked = iniFile.ReadBool(PreferencesSection, "DoAnalytics", true);


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
        }

        private void ButtonRepoSearchPathBrowse_Click(object sender, EventArgs e)
        {
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

        private void buttonRepoSkipBrowse_Click_1(object sender, EventArgs e)
        {
            Track.DoTrackEvent(TrackCategories.Application, "skipRepoBrowseForm.ShowDialog");

            var skipRepoBrowseForm = new SkipRepoBrowseForm();
            if (skipRepoBrowseForm.ShowDialog() != DialogResult.OK) return;
            var iniFile = new IniFile(FormMain.OptionsIni);
            iniFile.ReadSection(SkipRepoBrowseForm.SkipReposSection, out var repoSectionList);
            labelRepoSkipCount.Text = $"{repoSectionList.Count} repos";

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void materialFlatButton1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                materialContextMenuStrip1.Show(PointToScreen(e.Location));

        }

        private void materialContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void gitFetchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem senderToolStripMenuItem))
                return;

            //Can't uncheck
            if (senderToolStripMenuItem.Checked)
                return;

            senderToolStripMenuItem.Checked = true;

            materialFlatButtonDoubleClick.Text = senderToolStripMenuItem.Text;

            foreach (ToolStripItem toolStripItem in materialContextMenuStrip1.Items)
            {
                if (!(toolStripItem is ToolStripMenuItem toolStripMenuItem)
                    || toolStripMenuItem == senderToolStripMenuItem)
                    continue;
                toolStripMenuItem.Checked = false;
            }
        }

        private void materialFlatButtonRepoBrowse_Click(object sender, EventArgs e)
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

        private void textBoxAzureDevOpsUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
