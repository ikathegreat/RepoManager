namespace RepoManager
{
    partial class RepoPropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepoPropertiesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPreferredSolution = new System.Windows.Forms.Label();
            this.comboBoxPreferredSolution = new System.Windows.Forms.ComboBox();
            this.checkBoxOpenAsAdmin = new System.Windows.Forms.CheckBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMerges = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRecentFiles = new System.Windows.Forms.TabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDateChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaysAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeKind = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPageCommitHistory = new System.Windows.Forms.TabPage();
            this.tabPageChangeTrends = new System.Windows.Forms.TabPage();
            this.tabPageSmartGit = new System.Windows.Forms.TabPage();
            this.checkBoxEnableSmartGit = new System.Windows.Forms.CheckBox();
            this.listBoxSmartGitLinkedRepos = new System.Windows.Forms.ListBox();
            this.panelSmartGitRepo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddSingleRepo = new System.Windows.Forms.Button();
            this.buttonAutoDetect = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonCheckAutoDetect = new System.Windows.Forms.Button();
            this.labelLinkedReposCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageRecentFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabPageCommitHistory.SuspendLayout();
            this.tabPageSmartGit.SuspendLayout();
            this.panelSmartGitRepo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 526);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(984, 35);
            this.panel1.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(799, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 25);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(889, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 25);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPreferredSolution
            // 
            this.labelPreferredSolution.AutoSize = true;
            this.labelPreferredSolution.Location = new System.Drawing.Point(12, 20);
            this.labelPreferredSolution.Name = "labelPreferredSolution";
            this.labelPreferredSolution.Size = new System.Drawing.Size(102, 15);
            this.labelPreferredSolution.TabIndex = 4;
            this.labelPreferredSolution.Text = "Preferred Solution";
            // 
            // comboBoxPreferredSolution
            // 
            this.comboBoxPreferredSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPreferredSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPreferredSolution.FormattingEnabled = true;
            this.comboBoxPreferredSolution.Location = new System.Drawing.Point(15, 38);
            this.comboBoxPreferredSolution.Name = "comboBoxPreferredSolution";
            this.comboBoxPreferredSolution.Size = new System.Drawing.Size(957, 23);
            this.comboBoxPreferredSolution.TabIndex = 5;
            // 
            // checkBoxOpenAsAdmin
            // 
            this.checkBoxOpenAsAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOpenAsAdmin.AutoSize = true;
            this.checkBoxOpenAsAdmin.Location = new System.Drawing.Point(766, 67);
            this.checkBoxOpenAsAdmin.Name = "checkBoxOpenAsAdmin";
            this.checkBoxOpenAsAdmin.Size = new System.Drawing.Size(206, 19);
            this.checkBoxOpenAsAdmin.TabIndex = 6;
            this.checkBoxOpenAsAdmin.Text = "Open Preferred Solution as Admin";
            this.checkBoxOpenAsAdmin.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(943, 394);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colChangeCount,
            this.colAuthor,
            this.colMerges,
            this.colMessage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.DisplayFormat.FormatString = "M/d/yyyy HH:mm:ss";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colChangeCount
            // 
            this.colChangeCount.Caption = "Change Count";
            this.colChangeCount.FieldName = "ChangeCount";
            this.colChangeCount.Name = "colChangeCount";
            this.colChangeCount.Visible = true;
            this.colChangeCount.VisibleIndex = 1;
            // 
            // colAuthor
            // 
            this.colAuthor.Caption = "Author";
            this.colAuthor.FieldName = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.OptionsColumn.AllowEdit = false;
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 2;
            // 
            // colMerges
            // 
            this.colMerges.Caption = "Merges";
            this.colMerges.FieldName = "Merges";
            this.colMerges.Name = "colMerges";
            this.colMerges.OptionsColumn.AllowEdit = false;
            this.colMerges.Visible = true;
            this.colMerges.VisibleIndex = 3;
            // 
            // colMessage
            // 
            this.colMessage.Caption = "Message";
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.OptionsColumn.AllowEdit = false;
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageRecentFiles);
            this.tabControl1.Controls.Add(this.tabPageCommitHistory);
            this.tabControl1.Controls.Add(this.tabPageSmartGit);
            this.tabControl1.Controls.Add(this.tabPageChangeTrends);
            this.tabControl1.Location = new System.Drawing.Point(15, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 428);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageRecentFiles
            // 
            this.tabPageRecentFiles.Controls.Add(this.gridControl2);
            this.tabPageRecentFiles.Location = new System.Drawing.Point(4, 24);
            this.tabPageRecentFiles.Name = "tabPageRecentFiles";
            this.tabPageRecentFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecentFiles.Size = new System.Drawing.Size(949, 400);
            this.tabPageRecentFiles.TabIndex = 0;
            this.tabPageRecentFiles.Text = "Recent Files";
            this.tabPageRecentFiles.UseVisualStyleBackColor = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(943, 394);
            this.gridControl2.TabIndex = 8;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDateChanged,
            this.colDaysAge,
            this.colChangeKind,
            this.colFile,
            this.colChangeAuthor,
            this.colChangeMessage});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // colDateChanged
            // 
            this.colDateChanged.Caption = "Date";
            this.colDateChanged.DisplayFormat.FormatString = "M/d/yyyy HH:mm:ss";
            this.colDateChanged.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateChanged.FieldName = "DateChanged";
            this.colDateChanged.Name = "colDateChanged";
            this.colDateChanged.OptionsColumn.AllowEdit = false;
            this.colDateChanged.Visible = true;
            this.colDateChanged.VisibleIndex = 0;
            // 
            // colDaysAge
            // 
            this.colDaysAge.Caption = "Day Age";
            this.colDaysAge.FieldName = "DaysAge";
            this.colDaysAge.Name = "colDaysAge";
            this.colDaysAge.OptionsColumn.AllowEdit = false;
            this.colDaysAge.Visible = true;
            this.colDaysAge.VisibleIndex = 1;
            // 
            // colChangeKind
            // 
            this.colChangeKind.Caption = "Kind";
            this.colChangeKind.FieldName = "FileChangeKind";
            this.colChangeKind.Name = "colChangeKind";
            this.colChangeKind.OptionsColumn.AllowEdit = false;
            this.colChangeKind.Visible = true;
            this.colChangeKind.VisibleIndex = 2;
            // 
            // colFile
            // 
            this.colFile.Caption = "File";
            this.colFile.FieldName = "FileNameWithExtension";
            this.colFile.Name = "colFile";
            this.colFile.OptionsColumn.AllowEdit = false;
            this.colFile.Visible = true;
            this.colFile.VisibleIndex = 3;
            // 
            // colChangeAuthor
            // 
            this.colChangeAuthor.Caption = "Author";
            this.colChangeAuthor.FieldName = "ChangeAuthor";
            this.colChangeAuthor.Name = "colChangeAuthor";
            this.colChangeAuthor.Visible = true;
            this.colChangeAuthor.VisibleIndex = 4;
            // 
            // colChangeMessage
            // 
            this.colChangeMessage.Caption = "Message";
            this.colChangeMessage.FieldName = "Message";
            this.colChangeMessage.Name = "colChangeMessage";
            this.colChangeMessage.OptionsColumn.AllowEdit = false;
            this.colChangeMessage.Visible = true;
            this.colChangeMessage.VisibleIndex = 5;
            // 
            // tabPageCommitHistory
            // 
            this.tabPageCommitHistory.Controls.Add(this.gridControl1);
            this.tabPageCommitHistory.Location = new System.Drawing.Point(4, 24);
            this.tabPageCommitHistory.Name = "tabPageCommitHistory";
            this.tabPageCommitHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommitHistory.Size = new System.Drawing.Size(949, 400);
            this.tabPageCommitHistory.TabIndex = 1;
            this.tabPageCommitHistory.Text = "Commit History";
            this.tabPageCommitHistory.UseVisualStyleBackColor = true;
            // 
            // tabPageChangeTrends
            // 
            this.tabPageChangeTrends.Location = new System.Drawing.Point(4, 24);
            this.tabPageChangeTrends.Name = "tabPageChangeTrends";
            this.tabPageChangeTrends.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChangeTrends.Size = new System.Drawing.Size(949, 400);
            this.tabPageChangeTrends.TabIndex = 2;
            this.tabPageChangeTrends.Text = "Change Trend";
            this.tabPageChangeTrends.UseVisualStyleBackColor = true;
            // 
            // tabPageSmartGit
            // 
            this.tabPageSmartGit.Controls.Add(this.labelLinkedReposCount);
            this.tabPageSmartGit.Controls.Add(this.buttonCheckAutoDetect);
            this.tabPageSmartGit.Controls.Add(this.panelSmartGitRepo);
            this.tabPageSmartGit.Controls.Add(this.checkBoxEnableSmartGit);
            this.tabPageSmartGit.Location = new System.Drawing.Point(4, 24);
            this.tabPageSmartGit.Name = "tabPageSmartGit";
            this.tabPageSmartGit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSmartGit.Size = new System.Drawing.Size(949, 400);
            this.tabPageSmartGit.TabIndex = 3;
            this.tabPageSmartGit.Text = "SmartGit™";
            this.tabPageSmartGit.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableSmartGit
            // 
            this.checkBoxEnableSmartGit.AutoSize = true;
            this.checkBoxEnableSmartGit.Location = new System.Drawing.Point(21, 26);
            this.checkBoxEnableSmartGit.Name = "checkBoxEnableSmartGit";
            this.checkBoxEnableSmartGit.Size = new System.Drawing.Size(186, 19);
            this.checkBoxEnableSmartGit.TabIndex = 0;
            this.checkBoxEnableSmartGit.Text = "Enable SmartGit™ for this repo";
            this.checkBoxEnableSmartGit.UseVisualStyleBackColor = true;
            this.checkBoxEnableSmartGit.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBoxSmartGitLinkedRepos
            // 
            this.listBoxSmartGitLinkedRepos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSmartGitLinkedRepos.FormattingEnabled = true;
            this.listBoxSmartGitLinkedRepos.ItemHeight = 15;
            this.listBoxSmartGitLinkedRepos.Location = new System.Drawing.Point(0, 30);
            this.listBoxSmartGitLinkedRepos.Name = "listBoxSmartGitLinkedRepos";
            this.listBoxSmartGitLinkedRepos.Size = new System.Drawing.Size(423, 162);
            this.listBoxSmartGitLinkedRepos.TabIndex = 1;
            // 
            // panelSmartGitRepo
            // 
            this.panelSmartGitRepo.Controls.Add(this.listBoxSmartGitLinkedRepos);
            this.panelSmartGitRepo.Controls.Add(this.panel3);
            this.panelSmartGitRepo.Location = new System.Drawing.Point(21, 81);
            this.panelSmartGitRepo.Name = "panelSmartGitRepo";
            this.panelSmartGitRepo.Size = new System.Drawing.Size(423, 192);
            this.panelSmartGitRepo.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonRemove);
            this.panel3.Controls.Add(this.buttonAutoDetect);
            this.panel3.Controls.Add(this.buttonAddSingleRepo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel3.Size = new System.Drawing.Size(423, 30);
            this.panel3.TabIndex = 0;
            // 
            // buttonAddSingleRepo
            // 
            this.buttonAddSingleRepo.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddSingleRepo.Location = new System.Drawing.Point(0, 3);
            this.buttonAddSingleRepo.Name = "buttonAddSingleRepo";
            this.buttonAddSingleRepo.Size = new System.Drawing.Size(75, 24);
            this.buttonAddSingleRepo.TabIndex = 0;
            this.buttonAddSingleRepo.Text = "Add";
            this.buttonAddSingleRepo.UseVisualStyleBackColor = true;
            this.buttonAddSingleRepo.Click += new System.EventHandler(this.buttonAddSingleRepo_Click);
            // 
            // buttonAutoDetect
            // 
            this.buttonAutoDetect.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAutoDetect.Location = new System.Drawing.Point(75, 3);
            this.buttonAutoDetect.Name = "buttonAutoDetect";
            this.buttonAutoDetect.Size = new System.Drawing.Size(85, 24);
            this.buttonAutoDetect.TabIndex = 1;
            this.buttonAutoDetect.Text = "Auto Detect";
            this.buttonAutoDetect.UseVisualStyleBackColor = true;
            this.buttonAutoDetect.Click += new System.EventHandler(this.buttonAutoDetect_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRemove.Location = new System.Drawing.Point(160, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 24);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonCheckAutoDetect
            // 
            this.buttonCheckAutoDetect.Location = new System.Drawing.Point(115, 51);
            this.buttonCheckAutoDetect.Name = "buttonCheckAutoDetect";
            this.buttonCheckAutoDetect.Size = new System.Drawing.Size(130, 24);
            this.buttonCheckAutoDetect.TabIndex = 3;
            this.buttonCheckAutoDetect.Text = "View Linked Repos";
            this.buttonCheckAutoDetect.UseVisualStyleBackColor = true;
            this.buttonCheckAutoDetect.Click += new System.EventHandler(this.buttonCheckAutoDetect_Click);
            // 
            // labelLinkedReposCount
            // 
            this.labelLinkedReposCount.AutoSize = true;
            this.labelLinkedReposCount.Location = new System.Drawing.Point(18, 56);
            this.labelLinkedReposCount.Name = "labelLinkedReposCount";
            this.labelLinkedReposCount.Size = new System.Drawing.Size(38, 15);
            this.labelLinkedReposCount.TabIndex = 4;
            this.labelLinkedReposCount.Text = "label1";
            // 
            // RepoPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkBoxOpenAsAdmin);
            this.Controls.Add(this.comboBoxPreferredSolution);
            this.Controls.Add(this.labelPreferredSolution);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "RepoPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repo Properties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RepoPropertiesForm_FormClosing);
            this.Load += new System.EventHandler(this.RepoPropertiesForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRecentFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabPageCommitHistory.ResumeLayout(false);
            this.tabPageSmartGit.ResumeLayout(false);
            this.tabPageSmartGit.PerformLayout();
            this.panelSmartGitRepo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPreferredSolution;
        private System.Windows.Forms.ComboBox comboBoxPreferredSolution;
        private System.Windows.Forms.CheckBox checkBoxOpenAsAdmin;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMerges;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRecentFiles;
        private System.Windows.Forms.TabPage tabPageCommitHistory;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDateChanged;
        private DevExpress.XtraGrid.Columns.GridColumn colFile;
        private DevExpress.XtraGrid.Columns.GridColumn colChangeMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colChangeKind;
        private DevExpress.XtraGrid.Columns.GridColumn colChangeAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colDaysAge;
        private System.Windows.Forms.TabPage tabPageChangeTrends;
        private DevExpress.XtraGrid.Columns.GridColumn colChangeCount;
        private System.Windows.Forms.TabPage tabPageSmartGit;
        private System.Windows.Forms.Panel panelSmartGitRepo;
        private System.Windows.Forms.ListBox listBoxSmartGitLinkedRepos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAutoDetect;
        private System.Windows.Forms.Button buttonAddSingleRepo;
        private System.Windows.Forms.CheckBox checkBoxEnableSmartGit;
        private System.Windows.Forms.Button buttonCheckAutoDetect;
        private System.Windows.Forms.Label labelLinkedReposCount;
    }
}