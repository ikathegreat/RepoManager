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
            this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMerges = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRecentFiles = new System.Windows.Forms.TabPage();
            this.tabPageCommitHistory = new System.Windows.Forms.TabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDateChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeKind = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaysAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPageChangeTrends = new System.Windows.Forms.TabPage();
            this.colChangeCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageRecentFiles.SuspendLayout();
            this.tabPageCommitHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.gridControl1.Size = new System.Drawing.Size(943, 382);
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
            // colAuthor
            // 
            this.colAuthor.Caption = "Author";
            this.colAuthor.FieldName = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.OptionsColumn.AllowEdit = false;
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 2;
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
            // colMerges
            // 
            this.colMerges.Caption = "Merges";
            this.colMerges.FieldName = "Merges";
            this.colMerges.Name = "colMerges";
            this.colMerges.OptionsColumn.AllowEdit = false;
            this.colMerges.Visible = true;
            this.colMerges.VisibleIndex = 3;
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageRecentFiles);
            this.tabControl1.Controls.Add(this.tabPageCommitHistory);
            this.tabControl1.Controls.Add(this.tabPageChangeTrends);
            this.tabControl1.Location = new System.Drawing.Point(15, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 416);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageRecentFiles
            // 
            this.tabPageRecentFiles.Controls.Add(this.gridControl2);
            this.tabPageRecentFiles.Location = new System.Drawing.Point(4, 24);
            this.tabPageRecentFiles.Name = "tabPageRecentFiles";
            this.tabPageRecentFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecentFiles.Size = new System.Drawing.Size(949, 388);
            this.tabPageRecentFiles.TabIndex = 0;
            this.tabPageRecentFiles.Text = "Recent Files";
            this.tabPageRecentFiles.UseVisualStyleBackColor = true;
            // 
            // tabPageCommitHistory
            // 
            this.tabPageCommitHistory.Controls.Add(this.gridControl1);
            this.tabPageCommitHistory.Location = new System.Drawing.Point(4, 24);
            this.tabPageCommitHistory.Name = "tabPageCommitHistory";
            this.tabPageCommitHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommitHistory.Size = new System.Drawing.Size(949, 388);
            this.tabPageCommitHistory.TabIndex = 1;
            this.tabPageCommitHistory.Text = "Commit History";
            this.tabPageCommitHistory.UseVisualStyleBackColor = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(943, 382);
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
            // colFile
            // 
            this.colFile.Caption = "File";
            this.colFile.FieldName = "FileNameWithExtension";
            this.colFile.Name = "colFile";
            this.colFile.OptionsColumn.AllowEdit = false;
            this.colFile.Visible = true;
            this.colFile.VisibleIndex = 3;
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
            // colChangeAuthor
            // 
            this.colChangeAuthor.Caption = "Author";
            this.colChangeAuthor.FieldName = "ChangeAuthor";
            this.colChangeAuthor.Name = "colChangeAuthor";
            this.colChangeAuthor.Visible = true;
            this.colChangeAuthor.VisibleIndex = 4;
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
            // colDaysAge
            // 
            this.colDaysAge.Caption = "Day Age";
            this.colDaysAge.FieldName = "DaysAge";
            this.colDaysAge.Name = "colDaysAge";
            this.colDaysAge.OptionsColumn.AllowEdit = false;
            this.colDaysAge.Visible = true;
            this.colDaysAge.VisibleIndex = 1;
            // 
            // tabPageChangeTrends
            // 
            this.tabPageChangeTrends.Location = new System.Drawing.Point(4, 24);
            this.tabPageChangeTrends.Name = "tabPageChangeTrends";
            this.tabPageChangeTrends.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChangeTrends.Size = new System.Drawing.Size(949, 388);
            this.tabPageChangeTrends.TabIndex = 2;
            this.tabPageChangeTrends.Text = "Change Trend";
            this.tabPageChangeTrends.UseVisualStyleBackColor = true;
            // 
            // colChangeCount
            // 
            this.colChangeCount.Caption = "Change Count";
            this.colChangeCount.FieldName = "ChangeCount";
            this.colChangeCount.Name = "colChangeCount";
            this.colChangeCount.Visible = true;
            this.colChangeCount.VisibleIndex = 1;
            // 
            // RepoPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.tabPageCommitHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
    }
}