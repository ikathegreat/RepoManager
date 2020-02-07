namespace RepoManager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.repoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepoSourceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommitsAheadBehind = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChanges = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberOfFiles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommitMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemGitGetLatest = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemReset = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteBinObj = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenRepo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteRepo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteVs = new DevExpress.XtraBars.BarButtonItem();
            this.barSelectionStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemOptions = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFetch = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClone = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItemCloneItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCloneMultipleItem = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItemFocusedRepo = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemFocusedRepoStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemFeedback = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItemVersion = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRunBatch = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemProperties = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenPreferredSln = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemManageNuget = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupGit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupRepoUtilities = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupRepoOrganization = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelProgressBar = new System.Windows.Forms.Panel();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.focusedRepoNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAzureDevOps = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdoCommits = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdoPushes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdoBranches = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdoPulLRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.fetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteBinobjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletevsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runBatchFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRunBatchFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nugetPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ignoreRepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.solutionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.barButtonItemOtherFolders = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.panelProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.repoModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1383, 389);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colRepoSourceType,
            this.colPath,
            this.colBranchName,
            this.colCommitsAheadBehind,
            this.colChanges,
            this.colLastChange,
            this.colNumberOfFiles,
            this.colSizeString,
            this.colCommitMessage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colRepoSourceType
            // 
            this.colRepoSourceType.Caption = "Type";
            this.colRepoSourceType.FieldName = "RepoSourceType";
            this.colRepoSourceType.Name = "colRepoSourceType";
            this.colRepoSourceType.OptionsColumn.AllowEdit = false;
            this.colRepoSourceType.Visible = true;
            this.colRepoSourceType.VisibleIndex = 1;
            // 
            // colPath
            // 
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.OptionsColumn.AllowEdit = false;
            // 
            // colBranchName
            // 
            this.colBranchName.Caption = "Branch";
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.OptionsColumn.AllowEdit = false;
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 4;
            // 
            // colCommitsAheadBehind
            // 
            this.colCommitsAheadBehind.Caption = "Ahead/Behind";
            this.colCommitsAheadBehind.FieldName = "CommitsAheadBehind";
            this.colCommitsAheadBehind.Name = "colCommitsAheadBehind";
            this.colCommitsAheadBehind.OptionsColumn.AllowEdit = false;
            this.colCommitsAheadBehind.Visible = true;
            this.colCommitsAheadBehind.VisibleIndex = 3;
            // 
            // colChanges
            // 
            this.colChanges.Caption = "Changes";
            this.colChanges.FieldName = "Changes";
            this.colChanges.Name = "colChanges";
            this.colChanges.OptionsColumn.AllowEdit = false;
            this.colChanges.Visible = true;
            this.colChanges.VisibleIndex = 5;
            // 
            // colLastChange
            // 
            this.colLastChange.DisplayFormat.FormatString = "MM/dd/yyyy hh:mm:ss tt";
            this.colLastChange.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastChange.FieldName = "LastChange";
            this.colLastChange.Name = "colLastChange";
            this.colLastChange.OptionsColumn.AllowEdit = false;
            this.colLastChange.Visible = true;
            this.colLastChange.VisibleIndex = 6;
            // 
            // colNumberOfFiles
            // 
            this.colNumberOfFiles.Caption = "Files";
            this.colNumberOfFiles.FieldName = "NumberOfFilesString";
            this.colNumberOfFiles.Name = "colNumberOfFiles";
            this.colNumberOfFiles.OptionsColumn.AllowEdit = false;
            this.colNumberOfFiles.Visible = true;
            this.colNumberOfFiles.VisibleIndex = 9;
            // 
            // colSizeString
            // 
            this.colSizeString.Caption = "Size";
            this.colSizeString.FieldName = "SizeString";
            this.colSizeString.Name = "colSizeString";
            this.colSizeString.OptionsColumn.AllowEdit = false;
            this.colSizeString.Visible = true;
            this.colSizeString.VisibleIndex = 7;
            // 
            // colCommitMessage
            // 
            this.colCommitMessage.FieldName = "CommitMessage";
            this.colCommitMessage.Name = "colCommitMessage";
            this.colCommitMessage.OptionsColumn.AllowEdit = false;
            this.colCommitMessage.Visible = true;
            this.colCommitMessage.VisibleIndex = 8;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowKeyTips = false;
            this.ribbonControl1.AllowMdiChildButtons = false;
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.AllowTrimPageText = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemGitGetLatest,
            this.barButtonItemReset,
            this.barButtonItemDeleteBinObj,
            this.barButtonItemOpenRepo,
            this.barButtonItemDeleteRepo,
            this.barButtonItemDeleteVs,
            this.barSelectionStatus,
            this.barButtonItemOptions,
            this.barButtonItemFetch,
            this.barButtonItemAbout,
            this.barButtonItemClone,
            this.barStaticItemFocusedRepo,
            this.barStaticItemFocusedRepoStatus,
            this.barButtonItemFeedback,
            this.barStaticItemVersion,
            this.barButtonItemRefresh,
            this.barButtonItemRunBatch,
            this.barButtonItemProperties,
            this.barButtonItemOpenPreferredSln,
            this.barButtonItemManageNuget,
            this.barButtonItemCloneMultipleItem,
            this.barButtonItemCloneItem,
            this.barButtonItemOtherFolders});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 27;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1383, 62);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItemGitGetLatest
            // 
            this.barButtonItemGitGetLatest.Caption = "Pull";
            this.barButtonItemGitGetLatest.Id = 1;
            this.barButtonItemGitGetLatest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemGitGetLatest.ImageOptions.Image")));
            this.barButtonItemGitGetLatest.Name = "barButtonItemGitGetLatest";
            this.barButtonItemGitGetLatest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGitGetLatest_ItemClick);
            // 
            // barButtonItemReset
            // 
            this.barButtonItemReset.Caption = "Reset";
            this.barButtonItemReset.Id = 1;
            this.barButtonItemReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemReset.ImageOptions.Image")));
            this.barButtonItemReset.Name = "barButtonItemReset";
            this.barButtonItemReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemReset_ItemClick);
            // 
            // barButtonItemDeleteBinObj
            // 
            this.barButtonItemDeleteBinObj.Caption = "Delete bin/obj";
            this.barButtonItemDeleteBinObj.Id = 3;
            this.barButtonItemDeleteBinObj.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteBinObj.ImageOptions.Image")));
            this.barButtonItemDeleteBinObj.Name = "barButtonItemDeleteBinObj";
            this.barButtonItemDeleteBinObj.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteBinObj_ItemClick);
            // 
            // barButtonItemOpenRepo
            // 
            this.barButtonItemOpenRepo.Caption = "Open";
            this.barButtonItemOpenRepo.Id = 4;
            this.barButtonItemOpenRepo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpenRepo.ImageOptions.Image")));
            this.barButtonItemOpenRepo.Name = "barButtonItemOpenRepo";
            this.barButtonItemOpenRepo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpenRepo_ItemClick);
            // 
            // barButtonItemDeleteRepo
            // 
            this.barButtonItemDeleteRepo.Caption = "Delete";
            this.barButtonItemDeleteRepo.Id = 5;
            this.barButtonItemDeleteRepo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteRepo.ImageOptions.Image")));
            this.barButtonItemDeleteRepo.Name = "barButtonItemDeleteRepo";
            this.barButtonItemDeleteRepo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteRepo_ItemClick);
            // 
            // barButtonItemDeleteVs
            // 
            this.barButtonItemDeleteVs.Caption = "Delete .vs";
            this.barButtonItemDeleteVs.Id = 6;
            this.barButtonItemDeleteVs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteVs.ImageOptions.Image")));
            this.barButtonItemDeleteVs.Name = "barButtonItemDeleteVs";
            this.barButtonItemDeleteVs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteVs_ItemClick);
            // 
            // barSelectionStatus
            // 
            this.barSelectionStatus.Caption = "Repo Manager is here to help.";
            this.barSelectionStatus.Id = 7;
            this.barSelectionStatus.Name = "barSelectionStatus";
            // 
            // barButtonItemOptions
            // 
            this.barButtonItemOptions.Caption = "Options";
            this.barButtonItemOptions.Id = 8;
            this.barButtonItemOptions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOptions.ImageOptions.Image")));
            this.barButtonItemOptions.Name = "barButtonItemOptions";
            this.barButtonItemOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOptions_ItemClick);
            // 
            // barButtonItemFetch
            // 
            this.barButtonItemFetch.Caption = "Fetch";
            this.barButtonItemFetch.Id = 10;
            this.barButtonItemFetch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemFetch.ImageOptions.Image")));
            this.barButtonItemFetch.Name = "barButtonItemFetch";
            this.barButtonItemFetch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFetch_ItemClick);
            // 
            // barButtonItemAbout
            // 
            this.barButtonItemAbout.Caption = "About";
            this.barButtonItemAbout.Id = 11;
            this.barButtonItemAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAbout.ImageOptions.Image")));
            this.barButtonItemAbout.Name = "barButtonItemAbout";
            this.barButtonItemAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAbout_ItemClick);
            // 
            // barButtonItemClone
            // 
            this.barButtonItemClone.ActAsDropDown = true;
            this.barButtonItemClone.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemClone.Caption = "Clone";
            this.barButtonItemClone.DropDownControl = this.popupMenu1;
            this.barButtonItemClone.Id = 12;
            this.barButtonItemClone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemClone.ImageOptions.Image")));
            this.barButtonItemClone.Name = "barButtonItemClone";
            this.barButtonItemClone.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClone_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonItemCloneItem);
            this.popupMenu1.ItemLinks.Add(this.barButtonItemCloneMultipleItem);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItemCloneItem
            // 
            this.barButtonItemCloneItem.Caption = "Clone";
            this.barButtonItemCloneItem.Id = 25;
            this.barButtonItemCloneItem.Name = "barButtonItemCloneItem";
            this.barButtonItemCloneItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItemCloneMultipleItem
            // 
            this.barButtonItemCloneMultipleItem.Caption = "Clone Multiple...";
            this.barButtonItemCloneMultipleItem.Id = 24;
            this.barButtonItemCloneMultipleItem.Name = "barButtonItemCloneMultipleItem";
            this.barButtonItemCloneMultipleItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCloneMultipleItem_ItemClick);
            // 
            // barStaticItemFocusedRepo
            // 
            this.barStaticItemFocusedRepo.Caption = "FocusedRepo";
            this.barStaticItemFocusedRepo.Id = 13;
            this.barStaticItemFocusedRepo.Name = "barStaticItemFocusedRepo";
            // 
            // barStaticItemFocusedRepoStatus
            // 
            this.barStaticItemFocusedRepoStatus.Caption = "FocusedRepoStatus";
            this.barStaticItemFocusedRepoStatus.Id = 15;
            this.barStaticItemFocusedRepoStatus.Name = "barStaticItemFocusedRepoStatus";
            // 
            // barButtonItemFeedback
            // 
            this.barButtonItemFeedback.Caption = "Feedback";
            this.barButtonItemFeedback.Id = 16;
            this.barButtonItemFeedback.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemFeedback.ImageOptions.Image")));
            this.barButtonItemFeedback.Name = "barButtonItemFeedback";
            this.barButtonItemFeedback.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFeedback_ItemClick);
            // 
            // barStaticItemVersion
            // 
            this.barStaticItemVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItemVersion.Caption = "1.0.0.0";
            this.barStaticItemVersion.Id = 17;
            this.barStaticItemVersion.Name = "barStaticItemVersion";
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Refresh";
            this.barButtonItemRefresh.Id = 18;
            this.barButtonItemRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemRefresh.ImageOptions.Image")));
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // barButtonItemRunBatch
            // 
            this.barButtonItemRunBatch.Caption = "Run Batch";
            this.barButtonItemRunBatch.Id = 19;
            this.barButtonItemRunBatch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemRunBatch.ImageOptions.Image")));
            this.barButtonItemRunBatch.Name = "barButtonItemRunBatch";
            this.barButtonItemRunBatch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemRunBatch_ItemClick);
            // 
            // barButtonItemProperties
            // 
            this.barButtonItemProperties.Caption = "Properties";
            this.barButtonItemProperties.Id = 20;
            this.barButtonItemProperties.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemProperties.ImageOptions.Image")));
            this.barButtonItemProperties.Name = "barButtonItemProperties";
            this.barButtonItemProperties.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemProperties_ItemClick);
            // 
            // barButtonItemOpenPreferredSln
            // 
            this.barButtonItemOpenPreferredSln.Caption = "Open .sln";
            this.barButtonItemOpenPreferredSln.Id = 21;
            this.barButtonItemOpenPreferredSln.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpenPreferredSln.ImageOptions.Image")));
            this.barButtonItemOpenPreferredSln.Name = "barButtonItemOpenPreferredSln";
            this.barButtonItemOpenPreferredSln.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpenPreferredSln_ItemClick);
            // 
            // barButtonItemManageNuget
            // 
            this.barButtonItemManageNuget.Caption = "Nuget Packages...";
            this.barButtonItemManageNuget.Id = 23;
            this.barButtonItemManageNuget.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemManageNuget.ImageOptions.Image")));
            this.barButtonItemManageNuget.Name = "barButtonItemManageNuget";
            this.barButtonItemManageNuget.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemManageNuget_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupGit,
            this.ribbonPageGroupRepoUtilities,
            this.ribbonPageGroupRepoOrganization,
            this.ribbonPageGroupOptions,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroupGit
            // 
            this.ribbonPageGroupGit.ItemLinks.Add(this.barButtonItemFetch);
            this.ribbonPageGroupGit.ItemLinks.Add(this.barButtonItemGitGetLatest);
            this.ribbonPageGroupGit.ItemLinks.Add(this.barButtonItemReset);
            this.ribbonPageGroupGit.ItemLinks.Add(this.barButtonItemClone);
            this.ribbonPageGroupGit.Name = "ribbonPageGroupGit";
            this.ribbonPageGroupGit.Text = "Git";
            // 
            // ribbonPageGroupRepoUtilities
            // 
            this.ribbonPageGroupRepoUtilities.ItemLinks.Add(this.barButtonItemRunBatch);
            this.ribbonPageGroupRepoUtilities.ItemLinks.Add(this.barButtonItemDeleteBinObj);
            this.ribbonPageGroupRepoUtilities.ItemLinks.Add(this.barButtonItemDeleteVs);
            this.ribbonPageGroupRepoUtilities.ItemLinks.Add(this.barButtonItemManageNuget);
            this.ribbonPageGroupRepoUtilities.Name = "ribbonPageGroupRepoUtilities";
            this.ribbonPageGroupRepoUtilities.Text = "Repo Utilities";
            // 
            // ribbonPageGroupRepoOrganization
            // 
            this.ribbonPageGroupRepoOrganization.ItemLinks.Add(this.barButtonItemOpenRepo);
            this.ribbonPageGroupRepoOrganization.ItemLinks.Add(this.barButtonItemOpenPreferredSln);
            this.ribbonPageGroupRepoOrganization.ItemLinks.Add(this.barButtonItemDeleteRepo);
            this.ribbonPageGroupRepoOrganization.ItemLinks.Add(this.barButtonItemOtherFolders);
            this.ribbonPageGroupRepoOrganization.ItemLinks.Add(this.barButtonItemProperties);
            this.ribbonPageGroupRepoOrganization.Name = "ribbonPageGroupRepoOrganization";
            this.ribbonPageGroupRepoOrganization.Text = "Repo Organization";
            // 
            // ribbonPageGroupOptions
            // 
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemOptions);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemAbout);
            this.ribbonPageGroupOptions.ItemLinks.Add(this.barButtonItemFeedback);
            this.ribbonPageGroupOptions.Name = "ribbonPageGroupOptions";
            this.ribbonPageGroupOptions.Text = "Options";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemFocusedRepo);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemFocusedRepoStatus);
            this.ribbonStatusBar1.ItemLinks.Add(this.barSelectionStatus);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemVersion);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 498);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1383, 21);
            // 
            // panelProgressBar
            // 
            this.panelProgressBar.Controls.Add(this.progressBarControl1);
            this.panelProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProgressBar.Location = new System.Drawing.Point(0, 451);
            this.panelProgressBar.Name = "panelProgressBar";
            this.panelProgressBar.Size = new System.Drawing.Size(1383, 47);
            this.panelProgressBar.TabIndex = 7;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl1.Location = new System.Drawing.Point(12, 14);
            this.progressBarControl1.MenuManager = this.ribbonControl1;
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.ShowProgressInTaskBar = true;
            this.progressBarControl1.Size = new System.Drawing.Size(1359, 18);
            this.progressBarControl1.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.focusedRepoNameToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItemAzureDevOps,
            this.remoteURLToolStripMenuItem,
            this.toolStripMenuItemAdoCommits,
            this.toolStripMenuItemAdoPushes,
            this.toolStripMenuItemAdoBranches,
            this.toolStripMenuItemAdoPulLRequests,
            this.gitHubToolStripMenuItem,
            this.gitHubCodeToolStripMenuItem,
            this.gitHubIssuesToolStripMenuItem,
            this.toolStripSeparator5,
            this.fetchToolStripMenuItem,
            this.pullToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.toolStripSeparator3,
            this.deleteBinobjToolStripMenuItem,
            this.deletevsToolStripMenuItem,
            this.runBatchFilesToolStripMenuItem,
            this.editRunBatchFilesToolStripMenuItem,
            this.nugetPackagesToolStripMenuItem,
            this.toolStripSeparator4,
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.ignoreRepoToolStripMenuItem,
            this.toolStripSeparator6,
            this.solutionsToolStripMenuItem,
            this.branchesToolStripMenuItem,
            this.toolStripSeparator7,
            this.toolStripMenuItemProperties});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(178, 574);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // focusedRepoNameToolStripMenuItem
            // 
            this.focusedRepoNameToolStripMenuItem.Enabled = false;
            this.focusedRepoNameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("focusedRepoNameToolStripMenuItem.Image")));
            this.focusedRepoNameToolStripMenuItem.Name = "focusedRepoNameToolStripMenuItem";
            this.focusedRepoNameToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.focusedRepoNameToolStripMenuItem.Text = "FocusedRepoName";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // toolStripMenuItemAzureDevOps
            // 
            this.toolStripMenuItemAzureDevOps.Enabled = false;
            this.toolStripMenuItemAzureDevOps.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAzureDevOps.Image")));
            this.toolStripMenuItemAzureDevOps.Name = "toolStripMenuItemAzureDevOps";
            this.toolStripMenuItemAzureDevOps.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItemAzureDevOps.Text = "Azure DevOps";
            // 
            // remoteURLToolStripMenuItem
            // 
            this.remoteURLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("remoteURLToolStripMenuItem.Image")));
            this.remoteURLToolStripMenuItem.Name = "remoteURLToolStripMenuItem";
            this.remoteURLToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.remoteURLToolStripMenuItem.Text = "Code";
            this.remoteURLToolStripMenuItem.Click += new System.EventHandler(this.remoteURLToolStripMenuItem_Click);
            // 
            // toolStripMenuItemAdoCommits
            // 
            this.toolStripMenuItemAdoCommits.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAdoCommits.Image")));
            this.toolStripMenuItemAdoCommits.Name = "toolStripMenuItemAdoCommits";
            this.toolStripMenuItemAdoCommits.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItemAdoCommits.Text = "Commits";
            this.toolStripMenuItemAdoCommits.Click += new System.EventHandler(this.toolStripMenuItemAdoCommits_Click);
            // 
            // toolStripMenuItemAdoPushes
            // 
            this.toolStripMenuItemAdoPushes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAdoPushes.Image")));
            this.toolStripMenuItemAdoPushes.Name = "toolStripMenuItemAdoPushes";
            this.toolStripMenuItemAdoPushes.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItemAdoPushes.Text = "Pushes";
            this.toolStripMenuItemAdoPushes.Click += new System.EventHandler(this.toolStripMenuItemAdoPushes_Click);
            // 
            // toolStripMenuItemAdoBranches
            // 
            this.toolStripMenuItemAdoBranches.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAdoBranches.Image")));
            this.toolStripMenuItemAdoBranches.Name = "toolStripMenuItemAdoBranches";
            this.toolStripMenuItemAdoBranches.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItemAdoBranches.Text = "Branches";
            this.toolStripMenuItemAdoBranches.Click += new System.EventHandler(this.toolStripMenuItemAdoBranches_Click);
            // 
            // toolStripMenuItemAdoPulLRequests
            // 
            this.toolStripMenuItemAdoPulLRequests.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAdoPulLRequests.Image")));
            this.toolStripMenuItemAdoPulLRequests.Name = "toolStripMenuItemAdoPulLRequests";
            this.toolStripMenuItemAdoPulLRequests.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItemAdoPulLRequests.Text = "Pull Requests";
            this.toolStripMenuItemAdoPulLRequests.Click += new System.EventHandler(this.toolStripMenuItemAdoPulLRequests_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Enabled = false;
            this.gitHubToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gitHubToolStripMenuItem.Image")));
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // gitHubCodeToolStripMenuItem
            // 
            this.gitHubCodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gitHubCodeToolStripMenuItem.Image")));
            this.gitHubCodeToolStripMenuItem.Name = "gitHubCodeToolStripMenuItem";
            this.gitHubCodeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gitHubCodeToolStripMenuItem.Text = "Code";
            this.gitHubCodeToolStripMenuItem.Click += new System.EventHandler(this.CodeToolStripMenuItem_Click);
            // 
            // gitHubIssuesToolStripMenuItem
            // 
            this.gitHubIssuesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gitHubIssuesToolStripMenuItem.Image")));
            this.gitHubIssuesToolStripMenuItem.Name = "gitHubIssuesToolStripMenuItem";
            this.gitHubIssuesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gitHubIssuesToolStripMenuItem.Text = "Issues";
            this.gitHubIssuesToolStripMenuItem.Click += new System.EventHandler(this.GitHubIssuesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(174, 6);
            // 
            // fetchToolStripMenuItem
            // 
            this.fetchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fetchToolStripMenuItem.Image")));
            this.fetchToolStripMenuItem.Name = "fetchToolStripMenuItem";
            this.fetchToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fetchToolStripMenuItem.Text = "Fetch";
            this.fetchToolStripMenuItem.Click += new System.EventHandler(this.fetchToolStripMenuItem_Click);
            // 
            // pullToolStripMenuItem
            // 
            this.pullToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pullToolStripMenuItem.Image")));
            this.pullToolStripMenuItem.Name = "pullToolStripMenuItem";
            this.pullToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pullToolStripMenuItem.Text = "Pull";
            this.pullToolStripMenuItem.Click += new System.EventHandler(this.pullToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetToolStripMenuItem.Image")));
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(174, 6);
            // 
            // deleteBinobjToolStripMenuItem
            // 
            this.deleteBinobjToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteBinobjToolStripMenuItem.Image")));
            this.deleteBinobjToolStripMenuItem.Name = "deleteBinobjToolStripMenuItem";
            this.deleteBinobjToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteBinobjToolStripMenuItem.Text = "Delete bin/obj";
            this.deleteBinobjToolStripMenuItem.Click += new System.EventHandler(this.deleteBinobjToolStripMenuItem_Click);
            // 
            // deletevsToolStripMenuItem
            // 
            this.deletevsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletevsToolStripMenuItem.Image")));
            this.deletevsToolStripMenuItem.Name = "deletevsToolStripMenuItem";
            this.deletevsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deletevsToolStripMenuItem.Text = "Delete .vs";
            this.deletevsToolStripMenuItem.Click += new System.EventHandler(this.deletevsToolStripMenuItem_Click);
            // 
            // runBatchFilesToolStripMenuItem
            // 
            this.runBatchFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("runBatchFilesToolStripMenuItem.Image")));
            this.runBatchFilesToolStripMenuItem.Name = "runBatchFilesToolStripMenuItem";
            this.runBatchFilesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.runBatchFilesToolStripMenuItem.Text = "Run Batch Files";
            this.runBatchFilesToolStripMenuItem.Click += new System.EventHandler(this.RunBatchFilesToolStripMenuItem_Click);
            // 
            // editRunBatchFilesToolStripMenuItem
            // 
            this.editRunBatchFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editRunBatchFilesToolStripMenuItem.Image")));
            this.editRunBatchFilesToolStripMenuItem.Name = "editRunBatchFilesToolStripMenuItem";
            this.editRunBatchFilesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editRunBatchFilesToolStripMenuItem.Text = "Batch Files...";
            this.editRunBatchFilesToolStripMenuItem.Click += new System.EventHandler(this.EditRunBatchFilesToolStripMenuItem_Click);
            // 
            // nugetPackagesToolStripMenuItem
            // 
            this.nugetPackagesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nugetPackagesToolStripMenuItem.Image")));
            this.nugetPackagesToolStripMenuItem.Name = "nugetPackagesToolStripMenuItem";
            this.nugetPackagesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nugetPackagesToolStripMenuItem.Text = "Nuget Packages...";
            this.nugetPackagesToolStripMenuItem.Click += new System.EventHandler(this.nugetPackagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(174, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // ignoreRepoToolStripMenuItem
            // 
            this.ignoreRepoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ignoreRepoToolStripMenuItem.Image")));
            this.ignoreRepoToolStripMenuItem.Name = "ignoreRepoToolStripMenuItem";
            this.ignoreRepoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ignoreRepoToolStripMenuItem.Text = "Ignore Repo";
            this.ignoreRepoToolStripMenuItem.Click += new System.EventHandler(this.ignoreRepoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(174, 6);
            // 
            // solutionsToolStripMenuItem
            // 
            this.solutionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("solutionsToolStripMenuItem.Image")));
            this.solutionsToolStripMenuItem.Name = "solutionsToolStripMenuItem";
            this.solutionsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.solutionsToolStripMenuItem.Text = "Solutions";
            // 
            // branchesToolStripMenuItem
            // 
            this.branchesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("branchesToolStripMenuItem.Image")));
            this.branchesToolStripMenuItem.Name = "branchesToolStripMenuItem";
            this.branchesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.branchesToolStripMenuItem.Text = "Branches";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(174, 6);
            // 
            // toolStripMenuItemProperties
            // 
            this.toolStripMenuItemProperties.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemProperties.Image")));
            this.toolStripMenuItemProperties.Name = "toolStripMenuItemProperties";
            this.toolStripMenuItemProperties.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItemProperties.Text = "Properties";
            this.toolStripMenuItemProperties.Click += new System.EventHandler(this.toolStripMenuItemProperties_Click);
            // 
            // barButtonItemOtherFolders
            // 
            this.barButtonItemOtherFolders.Caption = "Other Folders...";
            this.barButtonItemOtherFolders.Id = 26;
            this.barButtonItemOtherFolders.Name = "barButtonItemOtherFolders";
            this.barButtonItemOtherFolders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOtherFolders_ItemClick);
            // 
            // FormMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 519);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelProgressBar);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Repo Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.panelProgressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGitGetLatest;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupGit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReset;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteBinObj;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupRepoUtilities;
        private System.Windows.Forms.BindingSource repoModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPath;
        private System.Windows.Forms.Panel panelProgressBar;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenRepo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteRepo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupRepoOrganization;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteVs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem solutionsToolStripMenuItem;
        private DevExpress.XtraBars.BarStaticItem barSelectionStatus;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private System.Windows.Forms.ToolStripMenuItem focusedRepoNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem branchesToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOptions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupOptions;
        private DevExpress.XtraGrid.Columns.GridColumn colCommitsAheadBehind;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFetch;
        private DevExpress.XtraGrid.Columns.GridColumn colLastChange;
        private DevExpress.XtraGrid.Columns.GridColumn colCommitMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colRepoSourceType;
        private System.Windows.Forms.ToolStripMenuItem fetchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem deleteBinobjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletevsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem remoteURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAbout;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClone;
        private DevExpress.XtraGrid.Columns.GridColumn colChanges;
        private DevExpress.XtraBars.BarStaticItem barStaticItemFocusedRepo;
        private DevExpress.XtraBars.BarStaticItem barStaticItemFocusedRepoStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeString;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFeedback;
        private DevExpress.XtraBars.BarStaticItem barStaticItemVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ignoreRepoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAzureDevOps;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdoPulLRequests;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdoBranches;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdoPushes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdoCommits;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberOfFiles;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRunBatch;
        private System.Windows.Forms.ToolStripMenuItem editRunBatchFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runBatchFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProperties;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProperties;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenPreferredSln;
        private DevExpress.XtraBars.BarButtonItem barButtonItemManageNuget;
        private System.Windows.Forms.ToolStripMenuItem nugetPackagesToolStripMenuItem;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCloneMultipleItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCloneItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOtherFolders;
    }
}

