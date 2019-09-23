namespace RepoManager
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxAuthentication = new System.Windows.Forms.GroupBox();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageAzureDevOps = new DevExpress.XtraTab.XtraTabPage();
            this.textBoxHostUrl = new System.Windows.Forms.TextBox();
            this.labelHostUrl = new System.Windows.Forms.Label();
            this.textBoxAzureDevOpsPassword = new System.Windows.Forms.TextBox();
            this.textBoxAzureDevOpsUserName = new System.Windows.Forms.TextBox();
            this.labelAzureDevOpsPassword = new System.Windows.Forms.Label();
            this.labelAzureDevOpsUsername = new System.Windows.Forms.Label();
            this.xtraTabPageGitHub = new DevExpress.XtraTab.XtraTabPage();
            this.textBoxGitHubPassword = new System.Windows.Forms.TextBox();
            this.textBoxGitHubUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRepoSearchPathBrowse = new System.Windows.Forms.Button();
            this.textBoxRepoSearchPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRepoSkipBrowse = new System.Windows.Forms.Button();
            this.labelRepoSkipCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxAuthentication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.xtraTabPageAzureDevOps.SuspendLayout();
            this.xtraTabPageGitHub.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(564, 35);
            this.panel1.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(379, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 25);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(469, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 25);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxAuthentication
            // 
            this.groupBoxAuthentication.Controls.Add(this.xtraTabControl);
            this.groupBoxAuthentication.Location = new System.Drawing.Point(12, 191);
            this.groupBoxAuthentication.Name = "groupBoxAuthentication";
            this.groupBoxAuthentication.Size = new System.Drawing.Size(540, 220);
            this.groupBoxAuthentication.TabIndex = 3;
            this.groupBoxAuthentication.TabStop = false;
            this.groupBoxAuthentication.Text = "Authentication";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.Location = new System.Drawing.Point(6, 22);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPageAzureDevOps;
            this.xtraTabControl.Size = new System.Drawing.Size(528, 186);
            this.xtraTabControl.TabIndex = 0;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageAzureDevOps,
            this.xtraTabPageGitHub});
            // 
            // xtraTabPageAzureDevOps
            // 
            this.xtraTabPageAzureDevOps.Controls.Add(this.textBoxHostUrl);
            this.xtraTabPageAzureDevOps.Controls.Add(this.labelHostUrl);
            this.xtraTabPageAzureDevOps.Controls.Add(this.textBoxAzureDevOpsPassword);
            this.xtraTabPageAzureDevOps.Controls.Add(this.textBoxAzureDevOpsUserName);
            this.xtraTabPageAzureDevOps.Controls.Add(this.labelAzureDevOpsPassword);
            this.xtraTabPageAzureDevOps.Controls.Add(this.labelAzureDevOpsUsername);
            this.xtraTabPageAzureDevOps.Name = "xtraTabPageAzureDevOps";
            this.xtraTabPageAzureDevOps.Size = new System.Drawing.Size(526, 159);
            this.xtraTabPageAzureDevOps.Text = "Azure DevOps";
            // 
            // textBoxHostUrl
            // 
            this.textBoxHostUrl.Location = new System.Drawing.Point(118, 17);
            this.textBoxHostUrl.Name = "textBoxHostUrl";
            this.textBoxHostUrl.Size = new System.Drawing.Size(188, 23);
            this.textBoxHostUrl.TabIndex = 5;
            // 
            // labelHostUrl
            // 
            this.labelHostUrl.AutoSize = true;
            this.labelHostUrl.Location = new System.Drawing.Point(37, 20);
            this.labelHostUrl.Name = "labelHostUrl";
            this.labelHostUrl.Size = new System.Drawing.Size(56, 15);
            this.labelHostUrl.TabIndex = 4;
            this.labelHostUrl.Text = "Host URL";
            // 
            // textBoxAzureDevOpsPassword
            // 
            this.textBoxAzureDevOpsPassword.Location = new System.Drawing.Point(118, 101);
            this.textBoxAzureDevOpsPassword.Name = "textBoxAzureDevOpsPassword";
            this.textBoxAzureDevOpsPassword.PasswordChar = '*';
            this.textBoxAzureDevOpsPassword.Size = new System.Drawing.Size(188, 23);
            this.textBoxAzureDevOpsPassword.TabIndex = 3;
            // 
            // textBoxAzureDevOpsUserName
            // 
            this.textBoxAzureDevOpsUserName.Location = new System.Drawing.Point(118, 66);
            this.textBoxAzureDevOpsUserName.Name = "textBoxAzureDevOpsUserName";
            this.textBoxAzureDevOpsUserName.Size = new System.Drawing.Size(188, 23);
            this.textBoxAzureDevOpsUserName.TabIndex = 2;
            // 
            // labelAzureDevOpsPassword
            // 
            this.labelAzureDevOpsPassword.AutoSize = true;
            this.labelAzureDevOpsPassword.Location = new System.Drawing.Point(37, 104);
            this.labelAzureDevOpsPassword.Name = "labelAzureDevOpsPassword";
            this.labelAzureDevOpsPassword.Size = new System.Drawing.Size(57, 15);
            this.labelAzureDevOpsPassword.TabIndex = 1;
            this.labelAzureDevOpsPassword.Text = "Password";
            // 
            // labelAzureDevOpsUsername
            // 
            this.labelAzureDevOpsUsername.AutoSize = true;
            this.labelAzureDevOpsUsername.Location = new System.Drawing.Point(37, 69);
            this.labelAzureDevOpsUsername.Name = "labelAzureDevOpsUsername";
            this.labelAzureDevOpsUsername.Size = new System.Drawing.Size(60, 15);
            this.labelAzureDevOpsUsername.TabIndex = 0;
            this.labelAzureDevOpsUsername.Text = "Username";
            // 
            // xtraTabPageGitHub
            // 
            this.xtraTabPageGitHub.Controls.Add(this.textBoxGitHubPassword);
            this.xtraTabPageGitHub.Controls.Add(this.textBoxGitHubUsername);
            this.xtraTabPageGitHub.Controls.Add(this.label3);
            this.xtraTabPageGitHub.Controls.Add(this.label4);
            this.xtraTabPageGitHub.Name = "xtraTabPageGitHub";
            this.xtraTabPageGitHub.Size = new System.Drawing.Size(526, 159);
            this.xtraTabPageGitHub.Text = "GitHub";
            // 
            // textBoxGitHubPassword
            // 
            this.textBoxGitHubPassword.Location = new System.Drawing.Point(118, 53);
            this.textBoxGitHubPassword.Name = "textBoxGitHubPassword";
            this.textBoxGitHubPassword.PasswordChar = '*';
            this.textBoxGitHubPassword.Size = new System.Drawing.Size(188, 23);
            this.textBoxGitHubPassword.TabIndex = 7;
            // 
            // textBoxGitHubUsername
            // 
            this.textBoxGitHubUsername.Location = new System.Drawing.Point(118, 18);
            this.textBoxGitHubUsername.Name = "textBoxGitHubUsername";
            this.textBoxGitHubUsername.Size = new System.Drawing.Size(188, 23);
            this.textBoxGitHubUsername.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRepoSearchPathBrowse);
            this.groupBox1.Controls.Add(this.textBoxRepoSearchPath);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonRepoSkipBrowse);
            this.groupBox1.Controls.Add(this.labelRepoSkipCount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preferences";
            // 
            // buttonRepoSearchPathBrowse
            // 
            this.buttonRepoSearchPathBrowse.Location = new System.Drawing.Point(500, 26);
            this.buttonRepoSearchPathBrowse.Name = "buttonRepoSearchPathBrowse";
            this.buttonRepoSearchPathBrowse.Size = new System.Drawing.Size(32, 24);
            this.buttonRepoSearchPathBrowse.TabIndex = 9;
            this.buttonRepoSearchPathBrowse.Text = "...";
            this.buttonRepoSearchPathBrowse.UseVisualStyleBackColor = true;
            this.buttonRepoSearchPathBrowse.Click += new System.EventHandler(this.ButtonRepoSearchPathBrowse_Click);
            // 
            // textBoxRepoSearchPath
            // 
            this.textBoxRepoSearchPath.Location = new System.Drawing.Point(192, 27);
            this.textBoxRepoSearchPath.Name = "textBoxRepoSearchPath";
            this.textBoxRepoSearchPath.Size = new System.Drawing.Size(302, 23);
            this.textBoxRepoSearchPath.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Repository Search Path";
            // 
            // buttonRepoSkipBrowse
            // 
            this.buttonRepoSkipBrowse.Location = new System.Drawing.Point(256, 114);
            this.buttonRepoSkipBrowse.Name = "buttonRepoSkipBrowse";
            this.buttonRepoSkipBrowse.Size = new System.Drawing.Size(34, 23);
            this.buttonRepoSkipBrowse.TabIndex = 6;
            this.buttonRepoSkipBrowse.Text = "...";
            this.buttonRepoSkipBrowse.UseVisualStyleBackColor = true;
            this.buttonRepoSkipBrowse.Click += new System.EventHandler(this.buttonRepoSkipBrowse_Click);
            // 
            // labelRepoSkipCount
            // 
            this.labelRepoSkipCount.AutoSize = true;
            this.labelRepoSkipCount.Location = new System.Drawing.Point(189, 118);
            this.labelRepoSkipCount.Name = "labelRepoSkipCount";
            this.labelRepoSkipCount.Size = new System.Drawing.Size(45, 15);
            this.labelRepoSkipCount.TabIndex = 5;
            this.labelRepoSkipCount.Text = "0 repos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Repos to Ignore";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Git Fetch",
            "Git Pull",
            "Git Reset",
            "Run Batch",
            "Delete bin/obj",
            "Delete .vs",
            "Open Local Folder",
            "Open Remote URL"});
            this.comboBox1.Location = new System.Drawing.Point(192, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Repo Double Click Action";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(564, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAuthentication);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxAuthentication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.xtraTabPageAzureDevOps.ResumeLayout(false);
            this.xtraTabPageAzureDevOps.PerformLayout();
            this.xtraTabPageGitHub.ResumeLayout(false);
            this.xtraTabPageGitHub.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxAuthentication;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAzureDevOps;
        private System.Windows.Forms.TextBox textBoxAzureDevOpsPassword;
        private System.Windows.Forms.TextBox textBoxAzureDevOpsUserName;
        private System.Windows.Forms.Label labelAzureDevOpsPassword;
        private System.Windows.Forms.Label labelAzureDevOpsUsername;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGitHub;
        private System.Windows.Forms.TextBox textBoxGitHubPassword;
        private System.Windows.Forms.TextBox textBoxGitHubUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRepoSkipBrowse;
        private System.Windows.Forms.Label labelRepoSkipCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRepoSearchPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHostUrl;
        private System.Windows.Forms.Label labelHostUrl;
        private System.Windows.Forms.Button buttonRepoSearchPathBrowse;
    }
}