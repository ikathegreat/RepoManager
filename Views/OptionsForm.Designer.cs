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
            this.buttonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonOK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialFlatButtonRepoBrowse = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButtonDoubleClick = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBoxRepoSearchPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkBoxAnalytics = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxShowWebShortcuts = new MaterialSkin.Controls.MaterialCheckBox();
            this.buttonRepoSkipBrowse = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelRepoSkipCount = new MaterialSkin.Controls.MaterialLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelPATToken = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPATValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelAzureDevOpsPassword = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxAzureDevOpsPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelAzureDevOpsUsername = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxAzureDevOpsUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radioButtonPAT = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonUserNamePassword = new MaterialSkin.Controls.MaterialRadioButton();
            this.labelHostUrl = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxHostUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxGitHubPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxGitHubUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.gitFetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitPullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBinobjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletevsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLocalFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRemoteURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferredSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(899, 44);
            this.panel1.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancel.Depth = 0;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Icon = null;
            this.buttonCancel.Location = new System.Drawing.Point(822, 4);
            this.buttonCancel.MinimumSize = new System.Drawing.Size(75, 0);
            this.buttonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Primary = true;
            this.buttonCancel.Size = new System.Drawing.Size(75, 36);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOK.Depth = 0;
            this.buttonOK.Icon = null;
            this.buttonOK.Location = new System.Drawing.Point(739, 4);
            this.buttonOK.MinimumSize = new System.Drawing.Size(75, 0);
            this.buttonOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Primary = true;
            this.buttonOK.Size = new System.Drawing.Size(75, 36);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(901, 53);
            this.materialTabSelector1.TabIndex = 6;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.Padding = new System.Drawing.Point(0, 0);
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(899, 371);
            this.materialTabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialFlatButtonRepoBrowse);
            this.tabPage1.Controls.Add(this.materialFlatButtonDoubleClick);
            this.tabPage1.Controls.Add(this.textBoxRepoSearchPath);
            this.tabPage1.Controls.Add(this.checkBoxAnalytics);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.checkBoxShowWebShortcuts);
            this.tabPage1.Controls.Add(this.buttonRepoSkipBrowse);
            this.tabPage1.Controls.Add(this.labelRepoSkipCount);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preferences";
            // 
            // materialFlatButtonRepoBrowse
            // 
            this.materialFlatButtonRepoBrowse.AutoSize = true;
            this.materialFlatButtonRepoBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonRepoBrowse.Depth = 0;
            this.materialFlatButtonRepoBrowse.Icon = null;
            this.materialFlatButtonRepoBrowse.Location = new System.Drawing.Point(597, 9);
            this.materialFlatButtonRepoBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonRepoBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonRepoBrowse.Name = "materialFlatButtonRepoBrowse";
            this.materialFlatButtonRepoBrowse.Primary = false;
            this.materialFlatButtonRepoBrowse.Size = new System.Drawing.Size(32, 36);
            this.materialFlatButtonRepoBrowse.TabIndex = 22;
            this.materialFlatButtonRepoBrowse.Text = "...";
            this.materialFlatButtonRepoBrowse.UseVisualStyleBackColor = true;
            this.materialFlatButtonRepoBrowse.Click += new System.EventHandler(this.materialFlatButtonRepoBrowse_Click);
            // 
            // materialFlatButtonDoubleClick
            // 
            this.materialFlatButtonDoubleClick.AutoSize = true;
            this.materialFlatButtonDoubleClick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonDoubleClick.Depth = 0;
            this.materialFlatButtonDoubleClick.Icon = null;
            this.materialFlatButtonDoubleClick.Location = new System.Drawing.Point(219, 54);
            this.materialFlatButtonDoubleClick.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonDoubleClick.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonDoubleClick.Name = "materialFlatButtonDoubleClick";
            this.materialFlatButtonDoubleClick.Primary = false;
            this.materialFlatButtonDoubleClick.Size = new System.Drawing.Size(262, 36);
            this.materialFlatButtonDoubleClick.TabIndex = 21;
            this.materialFlatButtonDoubleClick.Text = "materialFlatButtonDoubleClick";
            this.materialFlatButtonDoubleClick.UseVisualStyleBackColor = true;
            this.materialFlatButtonDoubleClick.Click += new System.EventHandler(this.materialFlatButton1_Click);
            this.materialFlatButtonDoubleClick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.materialFlatButton1_MouseDown);
            // 
            // textBoxRepoSearchPath
            // 
            this.textBoxRepoSearchPath.Depth = 0;
            this.textBoxRepoSearchPath.Hint = "";
            this.textBoxRepoSearchPath.Location = new System.Drawing.Point(228, 17);
            this.textBoxRepoSearchPath.MaxLength = 32767;
            this.textBoxRepoSearchPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxRepoSearchPath.Name = "textBoxRepoSearchPath";
            this.textBoxRepoSearchPath.PasswordChar = '\0';
            this.textBoxRepoSearchPath.SelectedText = "";
            this.textBoxRepoSearchPath.SelectionLength = 0;
            this.textBoxRepoSearchPath.SelectionStart = 0;
            this.textBoxRepoSearchPath.Size = new System.Drawing.Size(362, 23);
            this.textBoxRepoSearchPath.TabIndex = 19;
            this.textBoxRepoSearchPath.TabStop = false;
            this.textBoxRepoSearchPath.Text = "materialSingleLineTextField1";
            this.textBoxRepoSearchPath.UseSystemPasswordChar = false;
            // 
            // checkBoxAnalytics
            // 
            this.checkBoxAnalytics.AutoSize = true;
            this.checkBoxAnalytics.Depth = 0;
            this.checkBoxAnalytics.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBoxAnalytics.Location = new System.Drawing.Point(25, 190);
            this.checkBoxAnalytics.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAnalytics.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxAnalytics.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxAnalytics.Name = "checkBoxAnalytics";
            this.checkBoxAnalytics.Ripple = true;
            this.checkBoxAnalytics.Size = new System.Drawing.Size(207, 30);
            this.checkBoxAnalytics.TabIndex = 18;
            this.checkBoxAnalytics.Text = "Send anonymous usage data";
            this.checkBoxAnalytics.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(21, 17);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(165, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Repository Search Path";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(21, 62);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(180, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Repo Double Click Action";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 108);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(115, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Repos to Ignore";
            // 
            // checkBoxShowWebShortcuts
            // 
            this.checkBoxShowWebShortcuts.AutoSize = true;
            this.checkBoxShowWebShortcuts.Depth = 0;
            this.checkBoxShowWebShortcuts.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBoxShowWebShortcuts.Location = new System.Drawing.Point(25, 148);
            this.checkBoxShowWebShortcuts.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxShowWebShortcuts.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxShowWebShortcuts.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxShowWebShortcuts.Name = "checkBoxShowWebShortcuts";
            this.checkBoxShowWebShortcuts.Ripple = true;
            this.checkBoxShowWebShortcuts.Size = new System.Drawing.Size(256, 30);
            this.checkBoxShowWebShortcuts.TabIndex = 14;
            this.checkBoxShowWebShortcuts.Text = "Show web shortcuts in context menu";
            this.checkBoxShowWebShortcuts.UseVisualStyleBackColor = true;
            // 
            // buttonRepoSkipBrowse
            // 
            this.buttonRepoSkipBrowse.AutoSize = true;
            this.buttonRepoSkipBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRepoSkipBrowse.Depth = 0;
            this.buttonRepoSkipBrowse.Icon = null;
            this.buttonRepoSkipBrowse.Location = new System.Drawing.Point(290, 97);
            this.buttonRepoSkipBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRepoSkipBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRepoSkipBrowse.Name = "buttonRepoSkipBrowse";
            this.buttonRepoSkipBrowse.Primary = false;
            this.buttonRepoSkipBrowse.Size = new System.Drawing.Size(32, 36);
            this.buttonRepoSkipBrowse.TabIndex = 12;
            this.buttonRepoSkipBrowse.Text = "...";
            this.buttonRepoSkipBrowse.UseVisualStyleBackColor = true;
            this.buttonRepoSkipBrowse.Click += new System.EventHandler(this.buttonRepoSkipBrowse_Click_1);
            // 
            // labelRepoSkipCount
            // 
            this.labelRepoSkipCount.AutoSize = true;
            this.labelRepoSkipCount.Depth = 0;
            this.labelRepoSkipCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelRepoSkipCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRepoSkipCount.Location = new System.Drawing.Point(224, 108);
            this.labelRepoSkipCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRepoSkipCount.Name = "labelRepoSkipCount";
            this.labelRepoSkipCount.Size = new System.Drawing.Size(59, 19);
            this.labelRepoSkipCount.TabIndex = 10;
            this.labelRepoSkipCount.Text = "0 repos";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(-529, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(164, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Send anonymous usage data";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-350, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonRepoSkipBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-407, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "0 repos";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(-529, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show web shortcuts in context menu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-531, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repos to Ignore";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Git Fetch",
            "Git Pull",
            "Git Reset",
            "Run Batch",
            "Delete bin/obj",
            "Delete .vs",
            "Open Local Folder",
            "Open Remote URL",
            "Open Preferred Solution"});
            this.comboBox2.Location = new System.Drawing.Point(-404, -14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-531, -50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Repository Search Path";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-531, -11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Repo Double Click Action";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-140, -53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonRepoSearchPathBrowse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-404, -53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialTabControl2);
            this.tabPage2.Controls.Add(this.materialTabSelector2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(891, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authentication";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage3);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl2.Location = new System.Drawing.Point(0, 53);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(891, 292);
            this.materialTabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.labelPATToken);
            this.tabPage3.Controls.Add(this.textBoxPATValue);
            this.tabPage3.Controls.Add(this.labelAzureDevOpsPassword);
            this.tabPage3.Controls.Add(this.textBoxAzureDevOpsPassword);
            this.tabPage3.Controls.Add(this.labelAzureDevOpsUsername);
            this.tabPage3.Controls.Add(this.textBoxAzureDevOpsUserName);
            this.tabPage3.Controls.Add(this.radioButtonPAT);
            this.tabPage3.Controls.Add(this.radioButtonUserNamePassword);
            this.tabPage3.Controls.Add(this.labelHostUrl);
            this.tabPage3.Controls.Add(this.textBoxHostUrl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(883, 266);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Azure DevOps";
            // 
            // labelPATToken
            // 
            this.labelPATToken.AutoSize = true;
            this.labelPATToken.Depth = 0;
            this.labelPATToken.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPATToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPATToken.Location = new System.Drawing.Point(59, 179);
            this.labelPATToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPATToken.Name = "labelPATToken";
            this.labelPATToken.Size = new System.Drawing.Size(51, 19);
            this.labelPATToken.TabIndex = 18;
            this.labelPATToken.Text = "Token";
            this.labelPATToken.Visible = false;
            // 
            // textBoxPATValue
            // 
            this.textBoxPATValue.Depth = 0;
            this.textBoxPATValue.Hint = "";
            this.textBoxPATValue.Location = new System.Drawing.Point(156, 179);
            this.textBoxPATValue.MaxLength = 32767;
            this.textBoxPATValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPATValue.Name = "textBoxPATValue";
            this.textBoxPATValue.PasswordChar = '\0';
            this.textBoxPATValue.SelectedText = "";
            this.textBoxPATValue.SelectionLength = 0;
            this.textBoxPATValue.SelectionStart = 0;
            this.textBoxPATValue.Size = new System.Drawing.Size(235, 23);
            this.textBoxPATValue.TabIndex = 17;
            this.textBoxPATValue.TabStop = false;
            this.textBoxPATValue.Text = "textBoxPATValue";
            this.textBoxPATValue.UseSystemPasswordChar = false;
            this.textBoxPATValue.Visible = false;
            // 
            // labelAzureDevOpsPassword
            // 
            this.labelAzureDevOpsPassword.AutoSize = true;
            this.labelAzureDevOpsPassword.Depth = 0;
            this.labelAzureDevOpsPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAzureDevOpsPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAzureDevOpsPassword.Location = new System.Drawing.Point(59, 119);
            this.labelAzureDevOpsPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAzureDevOpsPassword.Name = "labelAzureDevOpsPassword";
            this.labelAzureDevOpsPassword.Size = new System.Drawing.Size(75, 19);
            this.labelAzureDevOpsPassword.TabIndex = 16;
            this.labelAzureDevOpsPassword.Text = "Password";
            // 
            // textBoxAzureDevOpsPassword
            // 
            this.textBoxAzureDevOpsPassword.Depth = 0;
            this.textBoxAzureDevOpsPassword.Hint = "";
            this.textBoxAzureDevOpsPassword.Location = new System.Drawing.Point(156, 119);
            this.textBoxAzureDevOpsPassword.MaxLength = 32767;
            this.textBoxAzureDevOpsPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAzureDevOpsPassword.Name = "textBoxAzureDevOpsPassword";
            this.textBoxAzureDevOpsPassword.PasswordChar = '*';
            this.textBoxAzureDevOpsPassword.SelectedText = "";
            this.textBoxAzureDevOpsPassword.SelectionLength = 0;
            this.textBoxAzureDevOpsPassword.SelectionStart = 0;
            this.textBoxAzureDevOpsPassword.Size = new System.Drawing.Size(235, 23);
            this.textBoxAzureDevOpsPassword.TabIndex = 15;
            this.textBoxAzureDevOpsPassword.TabStop = false;
            this.textBoxAzureDevOpsPassword.Text = "textBoxAzureDevOpsPassword";
            this.textBoxAzureDevOpsPassword.UseSystemPasswordChar = false;
            // 
            // labelAzureDevOpsUsername
            // 
            this.labelAzureDevOpsUsername.AutoSize = true;
            this.labelAzureDevOpsUsername.Depth = 0;
            this.labelAzureDevOpsUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAzureDevOpsUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAzureDevOpsUsername.Location = new System.Drawing.Point(59, 89);
            this.labelAzureDevOpsUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAzureDevOpsUsername.Name = "labelAzureDevOpsUsername";
            this.labelAzureDevOpsUsername.Size = new System.Drawing.Size(77, 19);
            this.labelAzureDevOpsUsername.TabIndex = 14;
            this.labelAzureDevOpsUsername.Text = "Username";
            // 
            // textBoxAzureDevOpsUserName
            // 
            this.textBoxAzureDevOpsUserName.Depth = 0;
            this.textBoxAzureDevOpsUserName.Hint = "";
            this.textBoxAzureDevOpsUserName.Location = new System.Drawing.Point(156, 89);
            this.textBoxAzureDevOpsUserName.MaxLength = 32767;
            this.textBoxAzureDevOpsUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAzureDevOpsUserName.Name = "textBoxAzureDevOpsUserName";
            this.textBoxAzureDevOpsUserName.PasswordChar = '\0';
            this.textBoxAzureDevOpsUserName.SelectedText = "";
            this.textBoxAzureDevOpsUserName.SelectionLength = 0;
            this.textBoxAzureDevOpsUserName.SelectionStart = 0;
            this.textBoxAzureDevOpsUserName.Size = new System.Drawing.Size(235, 23);
            this.textBoxAzureDevOpsUserName.TabIndex = 13;
            this.textBoxAzureDevOpsUserName.TabStop = false;
            this.textBoxAzureDevOpsUserName.Text = "textBoxAzureDevOpsUserName";
            this.textBoxAzureDevOpsUserName.UseSystemPasswordChar = false;
            this.textBoxAzureDevOpsUserName.Click += new System.EventHandler(this.textBoxAzureDevOpsUserName_Click);
            // 
            // radioButtonPAT
            // 
            this.radioButtonPAT.AutoSize = true;
            this.radioButtonPAT.Depth = 0;
            this.radioButtonPAT.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonPAT.Location = new System.Drawing.Point(21, 149);
            this.radioButtonPAT.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonPAT.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonPAT.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonPAT.Name = "radioButtonPAT";
            this.radioButtonPAT.Ripple = true;
            this.radioButtonPAT.Size = new System.Drawing.Size(174, 30);
            this.radioButtonPAT.TabIndex = 12;
            this.radioButtonPAT.Text = "Personal Access Token";
            this.radioButtonPAT.UseVisualStyleBackColor = true;
            this.radioButtonPAT.Visible = false;
            this.radioButtonPAT.CheckedChanged += new System.EventHandler(this.radioCheckChanged);
            // 
            // radioButtonUserNamePassword
            // 
            this.radioButtonUserNamePassword.AutoSize = true;
            this.radioButtonUserNamePassword.Checked = true;
            this.radioButtonUserNamePassword.Depth = 0;
            this.radioButtonUserNamePassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonUserNamePassword.Location = new System.Drawing.Point(21, 57);
            this.radioButtonUserNamePassword.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonUserNamePassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonUserNamePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonUserNamePassword.Name = "radioButtonUserNamePassword";
            this.radioButtonUserNamePassword.Ripple = true;
            this.radioButtonUserNamePassword.Size = new System.Drawing.Size(182, 30);
            this.radioButtonUserNamePassword.TabIndex = 11;
            this.radioButtonUserNamePassword.TabStop = true;
            this.radioButtonUserNamePassword.Text = "Username and Password";
            this.radioButtonUserNamePassword.UseVisualStyleBackColor = true;
            this.radioButtonUserNamePassword.CheckedChanged += new System.EventHandler(this.radioCheckChanged);
            // 
            // labelHostUrl
            // 
            this.labelHostUrl.AutoSize = true;
            this.labelHostUrl.Depth = 0;
            this.labelHostUrl.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelHostUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelHostUrl.Location = new System.Drawing.Point(17, 20);
            this.labelHostUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelHostUrl.Name = "labelHostUrl";
            this.labelHostUrl.Size = new System.Drawing.Size(73, 19);
            this.labelHostUrl.TabIndex = 10;
            this.labelHostUrl.Text = "Host URL";
            // 
            // textBoxHostUrl
            // 
            this.textBoxHostUrl.Depth = 0;
            this.textBoxHostUrl.Hint = "";
            this.textBoxHostUrl.Location = new System.Drawing.Point(120, 20);
            this.textBoxHostUrl.MaxLength = 32767;
            this.textBoxHostUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxHostUrl.Name = "textBoxHostUrl";
            this.textBoxHostUrl.PasswordChar = '\0';
            this.textBoxHostUrl.SelectedText = "";
            this.textBoxHostUrl.SelectionLength = 0;
            this.textBoxHostUrl.SelectionStart = 0;
            this.textBoxHostUrl.Size = new System.Drawing.Size(271, 23);
            this.textBoxHostUrl.TabIndex = 9;
            this.textBoxHostUrl.TabStop = false;
            this.textBoxHostUrl.Text = "textBoxHostUrl";
            this.textBoxHostUrl.UseSystemPasswordChar = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.materialLabel7);
            this.tabPage4.Controls.Add(this.textBoxGitHubPassword);
            this.tabPage4.Controls.Add(this.materialLabel8);
            this.tabPage4.Controls.Add(this.textBoxGitHubUsername);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(883, 266);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "GitHub";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(21, 63);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(75, 19);
            this.materialLabel7.TabIndex = 20;
            this.materialLabel7.Text = "Password";
            // 
            // textBoxGitHubPassword
            // 
            this.textBoxGitHubPassword.Depth = 0;
            this.textBoxGitHubPassword.Hint = "";
            this.textBoxGitHubPassword.Location = new System.Drawing.Point(118, 63);
            this.textBoxGitHubPassword.MaxLength = 32767;
            this.textBoxGitHubPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxGitHubPassword.Name = "textBoxGitHubPassword";
            this.textBoxGitHubPassword.PasswordChar = '*';
            this.textBoxGitHubPassword.SelectedText = "";
            this.textBoxGitHubPassword.SelectionLength = 0;
            this.textBoxGitHubPassword.SelectionStart = 0;
            this.textBoxGitHubPassword.Size = new System.Drawing.Size(235, 23);
            this.textBoxGitHubPassword.TabIndex = 19;
            this.textBoxGitHubPassword.TabStop = false;
            this.textBoxGitHubPassword.Text = "textBoxGitHubPassword";
            this.textBoxGitHubPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(21, 33);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(77, 19);
            this.materialLabel8.TabIndex = 18;
            this.materialLabel8.Text = "Username";
            // 
            // textBoxGitHubUsername
            // 
            this.textBoxGitHubUsername.Depth = 0;
            this.textBoxGitHubUsername.Hint = "";
            this.textBoxGitHubUsername.Location = new System.Drawing.Point(118, 33);
            this.textBoxGitHubUsername.MaxLength = 32767;
            this.textBoxGitHubUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxGitHubUsername.Name = "textBoxGitHubUsername";
            this.textBoxGitHubUsername.PasswordChar = '\0';
            this.textBoxGitHubUsername.SelectedText = "";
            this.textBoxGitHubUsername.SelectionLength = 0;
            this.textBoxGitHubUsername.SelectionStart = 0;
            this.textBoxGitHubUsername.Size = new System.Drawing.Size(235, 23);
            this.textBoxGitHubUsername.TabIndex = 17;
            this.textBoxGitHubUsername.TabStop = false;
            this.textBoxGitHubUsername.Text = "textBoxGitHubUsername";
            this.textBoxGitHubUsername.UseSystemPasswordChar = false;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(891, 53);
            this.materialTabSelector2.TabIndex = 1;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialTabControl1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 417);
            this.panel2.TabIndex = 7;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitFetchToolStripMenuItem,
            this.gitPullToolStripMenuItem,
            this.gitResetToolStripMenuItem,
            this.runBatchToolStripMenuItem,
            this.deleteBinobjToolStripMenuItem,
            this.deletevsToolStripMenuItem,
            this.openLocalFolderToolStripMenuItem,
            this.openRemoteURLToolStripMenuItem,
            this.openPreferredSolutionToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(202, 202);
            this.materialContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.materialContextMenuStrip1_Opening);
            // 
            // gitFetchToolStripMenuItem
            // 
            this.gitFetchToolStripMenuItem.Name = "gitFetchToolStripMenuItem";
            this.gitFetchToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gitFetchToolStripMenuItem.Tag = "0";
            this.gitFetchToolStripMenuItem.Text = "Git Fetch";
            this.gitFetchToolStripMenuItem.Click += new System.EventHandler(this.gitFetchToolStripMenuItem_Click);
            // 
            // gitPullToolStripMenuItem
            // 
            this.gitPullToolStripMenuItem.Name = "gitPullToolStripMenuItem";
            this.gitPullToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gitPullToolStripMenuItem.Tag = "1";
            this.gitPullToolStripMenuItem.Text = "Git Pull";
            this.gitPullToolStripMenuItem.Click += new System.EventHandler(this.gitFetchToolStripMenuItem_Click);
            // 
            // gitResetToolStripMenuItem
            // 
            this.gitResetToolStripMenuItem.Name = "gitResetToolStripMenuItem";
            this.gitResetToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gitResetToolStripMenuItem.Tag = "2";
            this.gitResetToolStripMenuItem.Text = "Git Reset";
            this.gitResetToolStripMenuItem.Click += new System.EventHandler(this.gitFetchToolStripMenuItem_Click);
            // 
            // runBatchToolStripMenuItem
            // 
            this.runBatchToolStripMenuItem.Name = "runBatchToolStripMenuItem";
            this.runBatchToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.runBatchToolStripMenuItem.Tag = "3";
            this.runBatchToolStripMenuItem.Text = "Run Batch";
            this.runBatchToolStripMenuItem.Click += new System.EventHandler(this.gitFetchToolStripMenuItem_Click);
            // 
            // deleteBinobjToolStripMenuItem
            // 
            this.deleteBinobjToolStripMenuItem.Name = "deleteBinobjToolStripMenuItem";
            this.deleteBinobjToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deleteBinobjToolStripMenuItem.Tag = "4";
            this.deleteBinobjToolStripMenuItem.Text = "Delete bin/obj";
            this.deleteBinobjToolStripMenuItem.Click += new System.EventHandler(this.gitFetchToolStripMenuItem_Click);
            // 
            // deletevsToolStripMenuItem
            // 
            this.deletevsToolStripMenuItem.Name = "deletevsToolStripMenuItem";
            this.deletevsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deletevsToolStripMenuItem.Tag = "5";
            this.deletevsToolStripMenuItem.Text = "Delete .vs";
            this.deletevsToolStripMenuItem.Click += new System.EventHandler(this.gitFetchToolStripMenuItem_Click);
            // 
            // openLocalFolderToolStripMenuItem
            // 
            this.openLocalFolderToolStripMenuItem.Name = "openLocalFolderToolStripMenuItem";
            this.openLocalFolderToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openLocalFolderToolStripMenuItem.Tag = "6";
            this.openLocalFolderToolStripMenuItem.Text = "Open Local Folder";
            this.openLocalFolderToolStripMenuItem.Click += new System.EventHandler(this.gitFetchToolStripMenuItem_Click);
            // 
            // openRemoteURLToolStripMenuItem
            // 
            this.openRemoteURLToolStripMenuItem.Name = "openRemoteURLToolStripMenuItem";
            this.openRemoteURLToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openRemoteURLToolStripMenuItem.Tag = "7";
            this.openRemoteURLToolStripMenuItem.Text = "Open Remote URL";
            this.openRemoteURLToolStripMenuItem.Click += new System.EventHandler(this.gitFetchToolStripMenuItem_Click);
            // 
            // openPreferredSolutionToolStripMenuItem
            // 
            this.openPreferredSolutionToolStripMenuItem.Name = "openPreferredSolutionToolStripMenuItem";
            this.openPreferredSolutionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openPreferredSolutionToolStripMenuItem.Tag = "8";
            this.openPreferredSolutionToolStripMenuItem.Text = "Open Preferred Solution";
            this.openPreferredSolutionToolStripMenuItem.Click += new System.EventHandler(this.gitFetchToolStripMenuItem_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxShowWebShortcuts;
        private MaterialSkin.Controls.MaterialRaisedButton buttonOK;
        private MaterialSkin.Controls.MaterialFlatButton buttonRepoSkipBrowse;
        private MaterialSkin.Controls.MaterialLabel labelRepoSkipCount;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxAnalytics;
        private MaterialSkin.Controls.MaterialRaisedButton buttonCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxRepoSearchPath;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel labelHostUrl;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxHostUrl;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialLabel labelPATToken;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPATValue;
        private MaterialSkin.Controls.MaterialLabel labelAzureDevOpsPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAzureDevOpsPassword;
        private MaterialSkin.Controls.MaterialLabel labelAzureDevOpsUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAzureDevOpsUserName;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonPAT;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonUserNamePassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxGitHubPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxGitHubUsername;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonDoubleClick;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gitFetchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitPullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBinobjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletevsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLocalFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRemoteURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferredSolutionToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonRepoBrowse;
    }
}