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
    public partial class CloneForm : DevExpress.XtraEditors.XtraForm
    {
        public CloneForm()
        {
            InitializeComponent();
            RepoSourceTypeEnum = RepoSourceTypeEnum.Unknown;
        }

        public string RootDirectory { get; set; }
        public string RemoteURL { get; set; }
        public string LocalPath { get; set; }
        public RepoSourceTypeEnum RepoSourceTypeEnum { get; set; }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CloneForm_Load(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
            labelRepoType.Visible = false;
            labelLocalPath.Text = RootDirectory;
        }

        private void textBoxRemoteUrl_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRemoteUrl.Text))
                return;
            if (textBoxRemoteUrl.Text.Contains("tfs") || textBoxRemoteUrl.Text.Contains("azure"))
                RepoSourceTypeEnum = RepoSourceTypeEnum.AzureDevOps;
            else if (textBoxRemoteUrl.Text.Contains("github.com"))
                RepoSourceTypeEnum = RepoSourceTypeEnum.GitHub;
            else
                RepoSourceTypeEnum = RepoSourceTypeEnum.Unknown;
            labelRepoType.Visible = true;
            labelRepoType.Text = RepoSourceTypeEnum.ToString();

            var lastPart = textBoxRemoteUrl.Text.Split('/').Last();
            textBoxLocalFolderName.Text = lastPart.Replace(".git", "");

            RemoteURL = textBoxRemoteUrl.Text;

        }

        private void textBoxLocalFolderName_TextChanged(object sender, EventArgs e)
        {
            labelLocalPath.Text = $"{RootDirectory}{Path.DirectorySeparatorChar}{textBoxLocalFolderName.Text}";
            labelStatus.Visible = true;
            if (string.IsNullOrEmpty(textBoxLocalFolderName.Text.Trim()))
            {
                labelStatus.Text = "Need local folder name";
                buttonOK.Enabled = false;
                return;
            }
            var dirExists = Directory.Exists(labelLocalPath.Text);
            labelStatus.Text = dirExists ? "Directory exists" : Utilities.FilePathHasInvalidChars(labelLocalPath.Text) ? "Invalid path" : "OK";

            if (RepoSourceTypeEnum == RepoSourceTypeEnum.Unknown)
                labelStatus.Text = "Unsupported git source control";
            buttonOK.Enabled = !dirExists && !Utilities.FilePathHasInvalidChars(labelLocalPath.Text) && RepoSourceTypeEnum != RepoSourceTypeEnum.Unknown;

            LocalPath = labelLocalPath.Text;
        }
    }
}
