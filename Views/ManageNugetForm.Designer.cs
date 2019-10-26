namespace RepoManager
{
    partial class ManageNugetForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageNugetForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox2Upgrade = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewPackagesToUpgrade = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUpgrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutOfDatePackages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxPackagesList = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridViewPackagesList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSolutionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectTargetFramework = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackageName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetFramework = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSolutionFullPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProjectFullPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxUpgradeMethod = new System.Windows.Forms.GroupBox();
            this.hyperlinkLabelControlManualHelp = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControlLastUsedHelp = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.radioButtonManual = new System.Windows.Forms.RadioButton();
            this.radioButtonLatestUsed = new System.Windows.Forms.RadioButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.contextMenuStripPackagesList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSolutionFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPackagesConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxRepos = new System.Windows.Forms.ListBox();
            this.openNugetSourceFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2Upgrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackagesToUpgrade)).BeginInit();
            this.groupBoxPackagesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackagesList)).BeginInit();
            this.groupBoxUpgradeMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.contextMenuStripPackagesList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxUpgradeMethod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(174, 626);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(174, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 626);
            this.panel2.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(174, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 626);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2Upgrade);
            this.panel4.Controls.Add(this.splitter2);
            this.panel4.Controls.Add(this.groupBoxPackagesList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1110, 626);
            this.panel4.TabIndex = 10;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(10, 360);
            this.splitter2.Name = "splitter2";
            this.splitter2.Padding = new System.Windows.Forms.Padding(5);
            this.splitter2.Size = new System.Drawing.Size(1090, 3);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // groupBox2Upgrade
            // 
            this.groupBox2Upgrade.Controls.Add(this.gridControl2);
            this.groupBox2Upgrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2Upgrade.Location = new System.Drawing.Point(10, 363);
            this.groupBox2Upgrade.Name = "groupBox2Upgrade";
            this.groupBox2Upgrade.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2Upgrade.Size = new System.Drawing.Size(1090, 253);
            this.groupBox2Upgrade.TabIndex = 1;
            this.groupBox2Upgrade.TabStop = false;
            this.groupBox2Upgrade.Text = "Nuget Packages to Upgrade";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(10, 26);
            this.gridControl2.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.gridControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl2.MainView = this.gridViewPackagesToUpgrade;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1070, 217);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPackagesToUpgrade});
            // 
            // gridViewPackagesToUpgrade
            // 
            this.gridViewPackagesToUpgrade.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUpgrade,
            this.colPackageName,
            this.colVersion,
            this.colOutOfDatePackages});
            this.gridViewPackagesToUpgrade.GridControl = this.gridControl2;
            this.gridViewPackagesToUpgrade.Name = "gridViewPackagesToUpgrade";
            this.gridViewPackagesToUpgrade.OptionsFind.AlwaysVisible = true;
            this.gridViewPackagesToUpgrade.OptionsSelection.MultiSelect = true;
            // 
            // colUpgrade
            // 
            this.colUpgrade.FieldName = "Upgrade";
            this.colUpgrade.Name = "colUpgrade";
            this.colUpgrade.Visible = true;
            this.colUpgrade.VisibleIndex = 0;
            // 
            // colPackageName
            // 
            this.colPackageName.FieldName = "PackageName";
            this.colPackageName.Name = "colPackageName";
            this.colPackageName.OptionsColumn.AllowEdit = false;
            this.colPackageName.OptionsColumn.ReadOnly = true;
            this.colPackageName.Visible = true;
            this.colPackageName.VisibleIndex = 1;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.Visible = true;
            this.colVersion.VisibleIndex = 2;
            // 
            // colOutOfDatePackages
            // 
            this.colOutOfDatePackages.FieldName = "OutOfDatePackages";
            this.colOutOfDatePackages.Name = "colOutOfDatePackages";
            this.colOutOfDatePackages.OptionsColumn.AllowEdit = false;
            this.colOutOfDatePackages.OptionsColumn.ReadOnly = true;
            this.colOutOfDatePackages.Visible = true;
            this.colOutOfDatePackages.VisibleIndex = 3;
            // 
            // groupBoxPackagesList
            // 
            this.groupBoxPackagesList.Controls.Add(this.gridControl1);
            this.groupBoxPackagesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPackagesList.Location = new System.Drawing.Point(10, 10);
            this.groupBoxPackagesList.Name = "groupBoxPackagesList";
            this.groupBoxPackagesList.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxPackagesList.Size = new System.Drawing.Size(1090, 350);
            this.groupBoxPackagesList.TabIndex = 0;
            this.groupBoxPackagesList.TabStop = false;
            this.groupBoxPackagesList.Text = "Packages List";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStripPackagesList;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(10, 26);
            this.gridControl1.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridViewPackagesList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1070, 314);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridViewPackagesList});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridViewPackagesList
            // 
            this.gridViewPackagesList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSolutionName,
            this.colProjectName,
            this.colProjectTargetFramework,
            this.colPackageName1,
            this.colVersion1,
            this.colTargetFramework,
            this.gridColumnSolutionFullPath,
            this.gridColumnProjectFullPath});
            this.gridViewPackagesList.GridControl = this.gridControl1;
            this.gridViewPackagesList.Name = "gridViewPackagesList";
            this.gridViewPackagesList.OptionsFind.AlwaysVisible = true;
            this.gridViewPackagesList.OptionsSelection.MultiSelect = true;
            this.gridViewPackagesList.OptionsView.ColumnAutoWidth = false;
            this.gridViewPackagesList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewPackagesList_SelectionChanged);
            // 
            // colSolutionName
            // 
            this.colSolutionName.FieldName = "SolutionName";
            this.colSolutionName.Name = "colSolutionName";
            this.colSolutionName.OptionsColumn.AllowEdit = false;
            this.colSolutionName.Visible = true;
            this.colSolutionName.VisibleIndex = 0;
            // 
            // colProjectName
            // 
            this.colProjectName.FieldName = "ProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.OptionsColumn.AllowEdit = false;
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 1;
            // 
            // colProjectTargetFramework
            // 
            this.colProjectTargetFramework.Caption = "Project Target Framework";
            this.colProjectTargetFramework.FieldName = "ProjectTargetFramework";
            this.colProjectTargetFramework.Name = "colProjectTargetFramework";
            this.colProjectTargetFramework.OptionsColumn.AllowEdit = false;
            this.colProjectTargetFramework.Visible = true;
            this.colProjectTargetFramework.VisibleIndex = 2;
            // 
            // colPackageName1
            // 
            this.colPackageName1.FieldName = "PackageName";
            this.colPackageName1.Name = "colPackageName1";
            this.colPackageName1.OptionsColumn.AllowEdit = false;
            this.colPackageName1.OptionsColumn.ReadOnly = true;
            this.colPackageName1.Visible = true;
            this.colPackageName1.VisibleIndex = 3;
            // 
            // colVersion1
            // 
            this.colVersion1.Caption = "Package Version";
            this.colVersion1.FieldName = "Version";
            this.colVersion1.Name = "colVersion1";
            this.colVersion1.OptionsColumn.AllowEdit = false;
            this.colVersion1.OptionsColumn.ReadOnly = true;
            this.colVersion1.Visible = true;
            this.colVersion1.VisibleIndex = 4;
            // 
            // colTargetFramework
            // 
            this.colTargetFramework.Caption = "Package Target Framework";
            this.colTargetFramework.FieldName = "TargetFramework";
            this.colTargetFramework.Name = "colTargetFramework";
            this.colTargetFramework.OptionsColumn.AllowEdit = false;
            this.colTargetFramework.OptionsColumn.ReadOnly = true;
            this.colTargetFramework.Visible = true;
            this.colTargetFramework.VisibleIndex = 5;
            // 
            // gridColumnSolutionFullPath
            // 
            this.gridColumnSolutionFullPath.Caption = "Solution Path";
            this.gridColumnSolutionFullPath.FieldName = "SolutionFullPath";
            this.gridColumnSolutionFullPath.Name = "gridColumnSolutionFullPath";
            this.gridColumnSolutionFullPath.OptionsColumn.AllowEdit = false;
            this.gridColumnSolutionFullPath.Visible = true;
            this.gridColumnSolutionFullPath.VisibleIndex = 6;
            // 
            // gridColumnProjectFullPath
            // 
            this.gridColumnProjectFullPath.Caption = "Project Path";
            this.gridColumnProjectFullPath.FieldName = "ProjectFullPath";
            this.gridColumnProjectFullPath.Name = "gridColumnProjectFullPath";
            this.gridColumnProjectFullPath.OptionsColumn.AllowEdit = false;
            this.gridColumnProjectFullPath.Visible = true;
            this.gridColumnProjectFullPath.VisibleIndex = 7;
            // 
            // groupBoxUpgradeMethod
            // 
            this.groupBoxUpgradeMethod.Controls.Add(this.hyperlinkLabelControlManualHelp);
            this.groupBoxUpgradeMethod.Controls.Add(this.hyperlinkLabelControlLastUsedHelp);
            this.groupBoxUpgradeMethod.Controls.Add(this.radioButtonLatestUsed);
            this.groupBoxUpgradeMethod.Controls.Add(this.radioButtonManual);
            this.groupBoxUpgradeMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUpgradeMethod.Location = new System.Drawing.Point(5, 5);
            this.groupBoxUpgradeMethod.Name = "groupBoxUpgradeMethod";
            this.groupBoxUpgradeMethod.Size = new System.Drawing.Size(164, 89);
            this.groupBoxUpgradeMethod.TabIndex = 5;
            this.groupBoxUpgradeMethod.TabStop = false;
            this.groupBoxUpgradeMethod.Text = "Upgrade Method";
            // 
            // hyperlinkLabelControlManualHelp
            // 
            this.hyperlinkLabelControlManualHelp.Location = new System.Drawing.Point(84, 52);
            this.hyperlinkLabelControlManualHelp.Name = "hyperlinkLabelControlManualHelp";
            this.hyperlinkLabelControlManualHelp.Size = new System.Drawing.Size(11, 15);
            this.hyperlinkLabelControlManualHelp.TabIndex = 3;
            this.hyperlinkLabelControlManualHelp.Text = " ? ";
            this.hyperlinkLabelControlManualHelp.Click += new System.EventHandler(this.hyperlinkLabelControlManualHelp_Click);
            // 
            // hyperlinkLabelControlLastUsedHelp
            // 
            this.hyperlinkLabelControlLastUsedHelp.Location = new System.Drawing.Point(103, 27);
            this.hyperlinkLabelControlLastUsedHelp.Name = "hyperlinkLabelControlLastUsedHelp";
            this.hyperlinkLabelControlLastUsedHelp.Size = new System.Drawing.Size(11, 15);
            this.hyperlinkLabelControlLastUsedHelp.TabIndex = 2;
            this.hyperlinkLabelControlLastUsedHelp.Text = " ? ";
            this.hyperlinkLabelControlLastUsedHelp.Click += new System.EventHandler(this.hyperlinkLabelControlLastUsedHelp_Click);
            // 
            // radioButtonManual
            // 
            this.radioButtonManual.AutoSize = true;
            this.radioButtonManual.Location = new System.Drawing.Point(17, 51);
            this.radioButtonManual.Name = "radioButtonManual";
            this.radioButtonManual.Size = new System.Drawing.Size(65, 19);
            this.radioButtonManual.TabIndex = 1;
            this.radioButtonManual.Text = "Manual";
            this.radioButtonManual.UseVisualStyleBackColor = true;
            // 
            // radioButtonLatestUsed
            // 
            this.radioButtonLatestUsed.AutoSize = true;
            this.radioButtonLatestUsed.Checked = true;
            this.radioButtonLatestUsed.Location = new System.Drawing.Point(17, 26);
            this.radioButtonLatestUsed.Name = "radioButtonLatestUsed";
            this.radioButtonLatestUsed.Size = new System.Drawing.Size(85, 19);
            this.radioButtonLatestUsed.TabIndex = 0;
            this.radioButtonLatestUsed.TabStop = true;
            this.radioButtonLatestUsed.Text = "Latest Used";
            this.radioButtonLatestUsed.UseVisualStyleBackColor = true;
            this.radioButtonLatestUsed.CheckedChanged += new System.EventHandler(this.upgradeMethodRadioChanged);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl1.Location = new System.Drawing.Point(3, 7);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarControl1.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.progressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(1090, 21);
            this.progressBarControl1.TabIndex = 1;
            this.progressBarControl1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.progressBarControl1);
            this.panel5.Controls.Add(this.buttonOK);
            this.panel5.Controls.Add(this.buttonCancel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 626);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(1284, 35);
            this.panel5.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(1099, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 25);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Upgrade";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(1189, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 25);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // contextMenuStripPackagesList
            // 
            this.contextMenuStripPackagesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSolutionFolderToolStripMenuItem,
            this.openProjectFolderToolStripMenuItem,
            this.toolStripSeparator2,
            this.openNugetSourceFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.openSolutionToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.openPackagesConfigToolStripMenuItem});
            this.contextMenuStripPackagesList.Name = "contextMenuStripPackagesList";
            this.contextMenuStripPackagesList.Size = new System.Drawing.Size(215, 148);
            // 
            // openSolutionFolderToolStripMenuItem
            // 
            this.openSolutionFolderToolStripMenuItem.Name = "openSolutionFolderToolStripMenuItem";
            this.openSolutionFolderToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openSolutionFolderToolStripMenuItem.Text = "Open Solution Folder";
            this.openSolutionFolderToolStripMenuItem.Click += new System.EventHandler(this.openSolutionFolderToolStripMenuItem_Click);
            // 
            // openProjectFolderToolStripMenuItem
            // 
            this.openProjectFolderToolStripMenuItem.Name = "openProjectFolderToolStripMenuItem";
            this.openProjectFolderToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openProjectFolderToolStripMenuItem.Text = "Open Project Folder";
            this.openProjectFolderToolStripMenuItem.Click += new System.EventHandler(this.openProjectFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // openSolutionToolStripMenuItem
            // 
            this.openSolutionToolStripMenuItem.Name = "openSolutionToolStripMenuItem";
            this.openSolutionToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openSolutionToolStripMenuItem.Text = "Open Solution";
            this.openSolutionToolStripMenuItem.Click += new System.EventHandler(this.openSolutionToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // openPackagesConfigToolStripMenuItem
            // 
            this.openPackagesConfigToolStripMenuItem.Name = "openPackagesConfigToolStripMenuItem";
            this.openPackagesConfigToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openPackagesConfigToolStripMenuItem.Text = "Open packages.config";
            this.openPackagesConfigToolStripMenuItem.Click += new System.EventHandler(this.openPackagesConfigToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxRepos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(164, 527);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repos";
            // 
            // listBoxRepos
            // 
            this.listBoxRepos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRepos.FormattingEnabled = true;
            this.listBoxRepos.ItemHeight = 15;
            this.listBoxRepos.Location = new System.Drawing.Point(10, 26);
            this.listBoxRepos.Name = "listBoxRepos";
            this.listBoxRepos.Size = new System.Drawing.Size(144, 491);
            this.listBoxRepos.TabIndex = 0;
            // 
            // openNugetSourceFolderToolStripMenuItem
            // 
            this.openNugetSourceFolderToolStripMenuItem.Name = "openNugetSourceFolderToolStripMenuItem";
            this.openNugetSourceFolderToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openNugetSourceFolderToolStripMenuItem.Text = "Open Nuget Source Folder";
            this.openNugetSourceFolderToolStripMenuItem.Click += new System.EventHandler(this.openNugetSourceFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // ManageNugetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "ManageNugetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Nuget Packages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageNugetForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageNugetForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2Upgrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackagesToUpgrade)).EndInit();
            this.groupBoxPackagesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackagesList)).EndInit();
            this.groupBoxUpgradeMethod.ResumeLayout(false);
            this.groupBoxUpgradeMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.contextMenuStripPackagesList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox2Upgrade;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPackagesToUpgrade;
        private DevExpress.XtraGrid.Columns.GridColumn colUpgrade;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageName;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colOutOfDatePackages;
        private System.Windows.Forms.GroupBox groupBoxPackagesList;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPackagesList;
        private DevExpress.XtraGrid.Columns.GridColumn colSolutionName;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectTargetFramework;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageName1;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetFramework;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSolutionFullPath;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProjectFullPath;
        private System.Windows.Forms.GroupBox groupBoxUpgradeMethod;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControlManualHelp;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControlLastUsedHelp;
        private System.Windows.Forms.RadioButton radioButtonLatestUsed;
        private System.Windows.Forms.RadioButton radioButtonManual;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPackagesList;
        private System.Windows.Forms.ToolStripMenuItem openSolutionFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openSolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPackagesConfigToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxRepos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openNugetSourceFolderToolStripMenuItem;
    }
}