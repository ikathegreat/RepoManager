namespace RepoManager.Views
{
    partial class OtherFoldersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherFoldersForm));
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
            this.barStaticItemFocusedRepo = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemFocusedRepoStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemFeedback = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItemVersion = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRunBatch = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemProperties = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenPreferredSln = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemManageNuget = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCloneMultipleItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCloneItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOtherFolders = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupRepoUtilities = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupRepoOrganization = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewOtherFolders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberOfFiles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeString = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOtherFolders)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(1098, 62);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItemGitGetLatest
            // 
            this.barButtonItemGitGetLatest.Caption = "Pull";
            this.barButtonItemGitGetLatest.Id = 1;
            this.barButtonItemGitGetLatest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemGitGetLatest.ImageOptions.Image")));
            this.barButtonItemGitGetLatest.Name = "barButtonItemGitGetLatest";
            // 
            // barButtonItemReset
            // 
            this.barButtonItemReset.Caption = "Reset";
            this.barButtonItemReset.Id = 1;
            this.barButtonItemReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemReset.ImageOptions.Image")));
            this.barButtonItemReset.Name = "barButtonItemReset";
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
            // 
            // barButtonItemDeleteRepo
            // 
            this.barButtonItemDeleteRepo.Caption = "Delete";
            this.barButtonItemDeleteRepo.Id = 5;
            this.barButtonItemDeleteRepo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteRepo.ImageOptions.Image")));
            this.barButtonItemDeleteRepo.Name = "barButtonItemDeleteRepo";
            // 
            // barButtonItemDeleteVs
            // 
            this.barButtonItemDeleteVs.Caption = "Delete .vs";
            this.barButtonItemDeleteVs.Id = 6;
            this.barButtonItemDeleteVs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteVs.ImageOptions.Image")));
            this.barButtonItemDeleteVs.Name = "barButtonItemDeleteVs";
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
            // 
            // barButtonItemFetch
            // 
            this.barButtonItemFetch.Caption = "Fetch";
            this.barButtonItemFetch.Id = 10;
            this.barButtonItemFetch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemFetch.ImageOptions.Image")));
            this.barButtonItemFetch.Name = "barButtonItemFetch";
            // 
            // barButtonItemAbout
            // 
            this.barButtonItemAbout.Caption = "About";
            this.barButtonItemAbout.Id = 11;
            this.barButtonItemAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAbout.ImageOptions.Image")));
            this.barButtonItemAbout.Name = "barButtonItemAbout";
            // 
            // barButtonItemClone
            // 
            this.barButtonItemClone.ActAsDropDown = true;
            this.barButtonItemClone.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemClone.Caption = "Clone";
            this.barButtonItemClone.Id = 12;
            this.barButtonItemClone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemClone.ImageOptions.Image")));
            this.barButtonItemClone.Name = "barButtonItemClone";
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
            // 
            // barButtonItemRunBatch
            // 
            this.barButtonItemRunBatch.Caption = "Run Batch";
            this.barButtonItemRunBatch.Id = 19;
            this.barButtonItemRunBatch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemRunBatch.ImageOptions.Image")));
            this.barButtonItemRunBatch.Name = "barButtonItemRunBatch";
            this.barButtonItemRunBatch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRunBatch_ItemClick);
            // 
            // barButtonItemProperties
            // 
            this.barButtonItemProperties.Caption = "Properties";
            this.barButtonItemProperties.Id = 20;
            this.barButtonItemProperties.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemProperties.ImageOptions.Image")));
            this.barButtonItemProperties.Name = "barButtonItemProperties";
            // 
            // barButtonItemOpenPreferredSln
            // 
            this.barButtonItemOpenPreferredSln.Caption = "Open .sln";
            this.barButtonItemOpenPreferredSln.Id = 21;
            this.barButtonItemOpenPreferredSln.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpenPreferredSln.ImageOptions.Image")));
            this.barButtonItemOpenPreferredSln.Name = "barButtonItemOpenPreferredSln";
            // 
            // barButtonItemManageNuget
            // 
            this.barButtonItemManageNuget.Caption = "Nuget Packages...";
            this.barButtonItemManageNuget.Id = 23;
            this.barButtonItemManageNuget.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemManageNuget.ImageOptions.Image")));
            this.barButtonItemManageNuget.Name = "barButtonItemManageNuget";
            // 
            // barButtonItemCloneMultipleItem
            // 
            this.barButtonItemCloneMultipleItem.Caption = "Clone Multiple...";
            this.barButtonItemCloneMultipleItem.Id = 24;
            this.barButtonItemCloneMultipleItem.Name = "barButtonItemCloneMultipleItem";
            // 
            // barButtonItemCloneItem
            // 
            this.barButtonItemCloneItem.Caption = "Clone";
            this.barButtonItemCloneItem.Id = 25;
            this.barButtonItemCloneItem.Name = "barButtonItemCloneItem";
            // 
            // barButtonItemOtherFolders
            // 
            this.barButtonItemOtherFolders.Caption = "Other Folders...";
            this.barButtonItemOtherFolders.Id = 26;
            this.barButtonItemOtherFolders.Name = "barButtonItemOtherFolders";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupRepoUtilities,
            this.ribbonPageGroupRepoOrganization});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
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
            this.ribbonPageGroupRepoOrganization.Name = "ribbonPageGroupRepoOrganization";
            this.ribbonPageGroupRepoOrganization.Text = "Repo Organization";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 62);
            this.gridControl1.MainView = this.gridViewOtherFolders;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1098, 437);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOtherFolders});
            // 
            // gridViewOtherFolders
            // 
            this.gridViewOtherFolders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPath,
            this.colNumberOfFiles,
            this.colSizeString});
            this.gridViewOtherFolders.GridControl = this.gridControl1;
            this.gridViewOtherFolders.Name = "gridViewOtherFolders";
            this.gridViewOtherFolders.OptionsFind.AlwaysVisible = true;
            this.gridViewOtherFolders.OptionsSelection.MultiSelect = true;
            this.gridViewOtherFolders.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewOtherFolders.OptionsView.ColumnAutoWidth = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colPath
            // 
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            this.colPath.OptionsColumn.AllowEdit = false;
            // 
            // colNumberOfFiles
            // 
            this.colNumberOfFiles.Caption = "Files";
            this.colNumberOfFiles.FieldName = "NumberOfFilesString";
            this.colNumberOfFiles.Name = "colNumberOfFiles";
            this.colNumberOfFiles.OptionsColumn.AllowEdit = false;
            this.colNumberOfFiles.Visible = true;
            this.colNumberOfFiles.VisibleIndex = 3;
            // 
            // colSizeString
            // 
            this.colSizeString.Caption = "Size";
            this.colSizeString.FieldName = "SizeString";
            this.colSizeString.Name = "colSizeString";
            this.colSizeString.OptionsColumn.AllowEdit = false;
            this.colSizeString.Visible = true;
            this.colSizeString.VisibleIndex = 2;
            // 
            // OtherFoldersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 499);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtherFoldersForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other Folders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtherFoldersForm_FormClosing);
            this.Load += new System.EventHandler(this.OtherFoldersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOtherFolders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGitGetLatest;
        private DevExpress.XtraBars.BarButtonItem barButtonItemReset;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteBinObj;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenRepo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteRepo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteVs;
        private DevExpress.XtraBars.BarStaticItem barSelectionStatus;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOptions;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFetch;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAbout;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClone;
        private DevExpress.XtraBars.BarStaticItem barStaticItemFocusedRepo;
        private DevExpress.XtraBars.BarStaticItem barStaticItemFocusedRepoStatus;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFeedback;
        private DevExpress.XtraBars.BarStaticItem barStaticItemVersion;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRunBatch;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProperties;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenPreferredSln;
        private DevExpress.XtraBars.BarButtonItem barButtonItemManageNuget;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCloneMultipleItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCloneItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOtherFolders;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupRepoUtilities;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupRepoOrganization;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOtherFolders;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPath;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberOfFiles;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeString;
    }
}