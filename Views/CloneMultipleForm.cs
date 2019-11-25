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
    public partial class CloneMultipleForm : Form
    {

        private RepoSourceTypeEnum repoSourceTypeEnumToAdd;

        public CloneMultipleForm()
        {
            InitializeComponent();
        }

        public string RootDirectory { get; set; }
        public List<RepoToClone> RepoToCloneList { get; set; } = new List<RepoToClone>();


        private void textBoxRemoteUrl_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxRemoteUrl.Text))
                return;
            if (textBoxRemoteUrl.Text.Contains("tfs") || textBoxRemoteUrl.Text.Contains("azure"))
                repoSourceTypeEnumToAdd = RepoSourceTypeEnum.AzureDevOps;
            else if (textBoxRemoteUrl.Text.Contains("github.com"))
                repoSourceTypeEnumToAdd = RepoSourceTypeEnum.GitHub;
            else
                repoSourceTypeEnumToAdd = RepoSourceTypeEnum.Unknown;
            labelRepoType.Visible = true;
            labelRepoType.Text = repoSourceTypeEnumToAdd.ToString();

            var lastPart = textBoxRemoteUrl.Text.Split('/').Last();
            textBoxLocalFolderName.Text = lastPart.Replace(".git", "");
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (RowAlreadyExists(textBoxRemoteUrl.Text))
                return;

            dataGridViewReposToClone.Rows.Add(
                repoSourceTypeEnumToAdd.ToString(),
                textBoxLocalFolderName.Text,
                textBoxRemoteUrl.Text);
        }

        private bool RowAlreadyExists(string url)
        {
            for (var i = 0; i < dataGridViewReposToClone.RowCount; i++)
            {
                var rowUrl = dataGridViewReposToClone.Rows[i].Cells[2].Value.ToString();
                if (rowUrl == url)
                    return true;
            }

            return false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewReposToClone.SelectedRows.Count > 0)
                dataGridViewReposToClone.Rows.Remove(dataGridViewReposToClone.SelectedRows[0]);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataGridViewReposToClone.RowCount; i++)
            {
                var fullRepoPath = Path.Combine(RootDirectory,
                    dataGridViewReposToClone.Rows[i].Cells[1].Value.ToString());

                var typeEnum = (RepoSourceTypeEnum)Enum.Parse(typeof(RepoSourceTypeEnum),
                    dataGridViewReposToClone.Rows[i].Cells[0].Value.ToString());

                RepoToCloneList.Add(
                    new RepoToClone
                    {
                        RepoSourceTypeEnum = typeEnum,
                        LocalPath = fullRepoPath,
                        RemoteURL = dataGridViewReposToClone.Rows[i].Cells[2].Value.ToString()
                    });
            }
            Close();
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
            var dirExists = Directory.Exists(Path.Combine(RootDirectory, textBoxLocalFolderName.Text));
            labelStatus.Text = dirExists ? "Directory exists" : Utilities.FilePathHasInvalidChars(labelLocalPath.Text) ? "Invalid path" : "OK";

            if (repoSourceTypeEnumToAdd == RepoSourceTypeEnum.Unknown)
                labelStatus.Text = "Unsupported git source control";
            
            buttonAdd.Enabled = !dirExists && !Utilities.FilePathHasInvalidChars(labelLocalPath.Text) && repoSourceTypeEnumToAdd != RepoSourceTypeEnum.Unknown;

        }

        private void CloneMultipleForm_Load(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
            labelRepoType.Visible = false;
            labelLocalPath.Text = RootDirectory;
        }
    }
}
