namespace ZetaResourceEditor.UI.Main.LeftTree
{
	partial class ProjectFilesUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectFilesUserControl));
			this.resourceEditorProjectFilesSplitContainer = new DevExpress.XtraEditors.SplitContainerControl();
			this.treeView = new ZetaResourceEditor.UI.Helper.ZetaResourceEditorTreeListControl();
			this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.treeImageList = new DevExpress.Utils.ImageCollection(this.components);
			this.stateImageList = new DevExpress.Utils.ImageCollection(this.components);
			this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
			this.newsBrowserControl = new ZetaResourceEditor.UI.Helper.ExtendedWebBrowser.ExtendedWebBrowserUserControl();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.guiRefreshTimer = new System.Windows.Forms.Timer(this.components);
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.popupBarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
			this.buttonMenuProjectEditResourceFiles = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectAddFileGroupToProject = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectRemoveFileGroupFromProject = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectEditFileGroupSettings = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectAddFilesToFileGroup = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectRemoveFileFromFileGroup = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectEditProjectSettings = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectAddProjectFolder = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectRemoveProjectFolder = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectEditProjectFolder = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectMoveUp = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectMoveDown = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectCreateNewFile = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectCreateNewFiles = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution = new DevExpress.XtraBars.BarButtonItem();
			this.buttonOpenProjectMenuItem = new DevExpress.XtraBars.BarButtonItem();
			this.buttonSortProjectFolderChildrenAscendingAZ = new DevExpress.XtraBars.BarButtonItem();
			this.buttonSortChildrenProjectAZ = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectFolderAddFileGroupToProject = new DevExpress.XtraBars.BarButtonItem();
			this.buttonMenuProjectAddNewFileGroupToProject = new DevExpress.XtraBars.BarButtonItem();
			this.popupMenuProject = new DevExpress.XtraBars.PopupMenu(this.components);
			this.popupMenuProjectFolder = new DevExpress.XtraBars.PopupMenu(this.components);
			this.popupMenuFileGroup = new DevExpress.XtraBars.PopupMenu(this.components);
			this.popupMenuFile = new DevExpress.XtraBars.PopupMenu(this.components);
			this.popupMenuNone = new DevExpress.XtraBars.PopupMenu(this.components);
			this.updateNodeStateImageBackgroundworker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.resourceEditorProjectFilesSplitContainer)).BeginInit();
			this.resourceEditorProjectFilesSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.treeImageList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stateImageList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupBarImageCollection)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuProject)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuProjectFolder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuFileGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuFile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuNone)).BeginInit();
			this.SuspendLayout();
			// 
			// resourceEditorProjectFilesSplitContainer
			// 
			resources.ApplyResources(this.resourceEditorProjectFilesSplitContainer, "resourceEditorProjectFilesSplitContainer");
			this.resourceEditorProjectFilesSplitContainer.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
			this.resourceEditorProjectFilesSplitContainer.Horizontal = false;
			this.resourceEditorProjectFilesSplitContainer.Name = "resourceEditorProjectFilesSplitContainer";
			this.resourceEditorProjectFilesSplitContainer.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			this.resourceEditorProjectFilesSplitContainer.Panel1.Controls.Add(this.treeView);
			this.resourceEditorProjectFilesSplitContainer.Panel1.ShowCaption = true;
			resources.ApplyResources(this.resourceEditorProjectFilesSplitContainer.Panel1, "resourceEditorProjectFilesSplitContainer.Panel1");
			this.resourceEditorProjectFilesSplitContainer.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			this.resourceEditorProjectFilesSplitContainer.Panel2.Controls.Add(this.newsBrowserControl);
			this.resourceEditorProjectFilesSplitContainer.Panel2.MinSize = 120;
			resources.ApplyResources(this.resourceEditorProjectFilesSplitContainer.Panel2, "resourceEditorProjectFilesSplitContainer.Panel2");
			this.resourceEditorProjectFilesSplitContainer.SplitterPosition = 64;
			// 
			// treeView
			// 
			this.treeView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
			resources.ApplyResources(this.treeView, "treeView");
			this.treeView.Name = "treeView";
			this.treeView.OptionsBehavior.AllowExpandOnDblClick = false;
			this.treeView.OptionsBehavior.AllowIncrementalSearch = true;
			this.treeView.OptionsBehavior.DragNodes = true;
			this.treeView.OptionsBehavior.ImmediateEditor = false;
			this.treeView.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.treeView.OptionsView.ShowColumns = false;
			this.treeView.OptionsView.ShowFocusedFrame = false;
			this.treeView.OptionsView.ShowHorzLines = false;
			this.treeView.OptionsView.ShowIndicator = false;
			this.treeView.OptionsView.ShowRoot = false;
			this.treeView.OptionsView.ShowVertLines = false;
			this.treeView.SelectedNode = null;
			this.treeView.SelectImageList = this.treeImageList;
			this.treeView.StateImageList = this.stateImageList;
			this.treeView.ToolTipController = this.toolTipController1;
			this.treeView.WasDoubleClick = false;
			this.treeView.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeView_NodeCellStyle);
			this.treeView.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.treeView_BeforeExpand);
			this.treeView.BeforeCollapse += new DevExpress.XtraTreeList.BeforeCollapseEventHandler(this.treeView_BeforeCollapse);
			this.treeView.CompareNodeValues += new DevExpress.XtraTreeList.CompareNodeValuesEventHandler(this.treeView_CompareNodeValues);
			this.treeView.CalcNodeDragImageIndex += new DevExpress.XtraTreeList.CalcNodeDragImageIndexEventHandler(this.treeView_CalcNodeDragImageIndex);
			this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
			this.treeView.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
			this.treeView.DoubleClick += new System.EventHandler(this.treeView_DoubleClick);
			this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyDown);
			this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseUp);
			// 
			// treeListColumn1
			// 
			resources.ApplyResources(this.treeListColumn1, "treeListColumn1");
			this.treeListColumn1.FieldName = "Name";
			this.treeListColumn1.Name = "treeListColumn1";
			this.treeListColumn1.OptionsColumn.AllowEdit = false;
			this.treeListColumn1.OptionsColumn.AllowMove = false;
			this.treeListColumn1.OptionsColumn.AllowSort = false;
			this.treeListColumn1.OptionsColumn.ReadOnly = true;
			// 
			// treeImageList
			// 
			this.treeImageList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("treeImageList.ImageStream")));
			this.treeImageList.Images.SetKeyName(0, "root");
			this.treeImageList.Images.SetKeyName(1, "group");
			this.treeImageList.Images.SetKeyName(2, "file");
			this.treeImageList.Images.SetKeyName(3, "projectfolder");
			// 
			// stateImageList
			// 
			this.stateImageList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("stateImageList.ImageStream")));
			this.stateImageList.Images.SetKeyName(0, "grey");
			this.stateImageList.Images.SetKeyName(1, "green");
			this.stateImageList.Images.SetKeyName(2, "yellow");
			this.stateImageList.Images.SetKeyName(3, "red");
			this.stateImageList.Images.SetKeyName(4, "blue");
			// 
			// toolTipController1
			// 
			this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
			// 
			// newsBrowserControl
			// 
			this.newsBrowserControl.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("newsBrowserControl.Appearance.BackColor")));
			this.newsBrowserControl.Appearance.Options.UseBackColor = true;
			resources.ApplyResources(this.newsBrowserControl, "newsBrowserControl");
			this.newsBrowserControl.Name = "newsBrowserControl";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
			// 
			// guiRefreshTimer
			// 
			this.guiRefreshTimer.Interval = 500;
			this.guiRefreshTimer.Tick += new System.EventHandler(this.guiRefreshTimer_Tick);
			// 
			// barManager
			// 
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Images = this.popupBarImageCollection;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.buttonMenuProjectEditResourceFiles,
            this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject,
            this.buttonMenuProjectAddFileGroupToProject,
            this.buttonMenuProjectRemoveFileGroupFromProject,
            this.buttonMenuProjectEditFileGroupSettings,
            this.buttonMenuProjectAddFilesToFileGroup,
            this.buttonMenuProjectRemoveFileFromFileGroup,
            this.buttonMenuProjectEditProjectSettings,
            this.buttonMenuProjectAddProjectFolder,
            this.buttonMenuProjectRemoveProjectFolder,
            this.buttonMenuProjectEditProjectFolder,
            this.buttonMenuProjectMoveUp,
            this.buttonMenuProjectMoveDown,
            this.buttonMenuProjectCreateNewFile,
            this.buttonMenuProjectCreateNewFiles,
            this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution,
            this.buttonOpenProjectMenuItem,
            this.buttonSortProjectFolderChildrenAscendingAZ,
            this.buttonSortChildrenProjectAZ,
            this.buttonMenuProjectFolderAddFileGroupToProject,
            this.buttonMenuProjectAddNewFileGroupToProject});
			this.barManager.MaxItemId = 24;
			// 
			// popupBarImageCollection
			// 
			this.popupBarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("popupBarImageCollection.ImageStream")));
			this.popupBarImageCollection.Images.SetKeyName(0, "pencil2.png");
			this.popupBarImageCollection.Images.SetKeyName(1, "magician.png");
			this.popupBarImageCollection.Images.SetKeyName(2, "box_add.png");
			this.popupBarImageCollection.Images.SetKeyName(3, "box_delete.png");
			this.popupBarImageCollection.Images.SetKeyName(4, "box_edit.png");
			this.popupBarImageCollection.Images.SetKeyName(5, "document_add.png");
			this.popupBarImageCollection.Images.SetKeyName(6, "document_delete.png");
			this.popupBarImageCollection.Images.SetKeyName(7, "earth_edit.png");
			this.popupBarImageCollection.Images.SetKeyName(8, "arrow_up_green.png");
			this.popupBarImageCollection.Images.SetKeyName(9, "arrow_down_green.png");
			this.popupBarImageCollection.Images.SetKeyName(10, "folder_blue_new.png");
			this.popupBarImageCollection.Images.SetKeyName(11, "folder_blue_edit.png");
			this.popupBarImageCollection.Images.SetKeyName(12, "folder_blue_delete.png");
			this.popupBarImageCollection.Images.SetKeyName(13, "document_new.png");
			// 
			// buttonMenuProjectEditResourceFiles
			// 
			resources.ApplyResources(this.buttonMenuProjectEditResourceFiles, "buttonMenuProjectEditResourceFiles");
			this.buttonMenuProjectEditResourceFiles.Id = 3;
			this.buttonMenuProjectEditResourceFiles.ImageIndex = 0;
			this.buttonMenuProjectEditResourceFiles.Name = "buttonMenuProjectEditResourceFiles";
			this.buttonMenuProjectEditResourceFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditResourceFiles_ItemClick);
			// 
			// buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject
			// 
			resources.ApplyResources(this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject, "buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject");
			this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.Id = 4;
			this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.ImageIndex = 1;
			this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.Name = "buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject";
			this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAutomaticallyAddMultipleFileGroupsToProject_ItemClick);
			// 
			// buttonMenuProjectAddFileGroupToProject
			// 
			resources.ApplyResources(this.buttonMenuProjectAddFileGroupToProject, "buttonMenuProjectAddFileGroupToProject");
			this.buttonMenuProjectAddFileGroupToProject.Id = 5;
			this.buttonMenuProjectAddFileGroupToProject.ImageIndex = 2;
			this.buttonMenuProjectAddFileGroupToProject.Name = "buttonMenuProjectAddFileGroupToProject";
			this.buttonMenuProjectAddFileGroupToProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddFileGroupToProject_ItemClick);
			// 
			// buttonMenuProjectRemoveFileGroupFromProject
			// 
			resources.ApplyResources(this.buttonMenuProjectRemoveFileGroupFromProject, "buttonMenuProjectRemoveFileGroupFromProject");
			this.buttonMenuProjectRemoveFileGroupFromProject.Id = 6;
			this.buttonMenuProjectRemoveFileGroupFromProject.ImageIndex = 3;
			this.buttonMenuProjectRemoveFileGroupFromProject.Name = "buttonMenuProjectRemoveFileGroupFromProject";
			this.buttonMenuProjectRemoveFileGroupFromProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRemoveFileGroupFromProject_ItemClick);
			// 
			// buttonMenuProjectEditFileGroupSettings
			// 
			resources.ApplyResources(this.buttonMenuProjectEditFileGroupSettings, "buttonMenuProjectEditFileGroupSettings");
			this.buttonMenuProjectEditFileGroupSettings.Id = 7;
			this.buttonMenuProjectEditFileGroupSettings.ImageIndex = 4;
			this.buttonMenuProjectEditFileGroupSettings.Name = "buttonMenuProjectEditFileGroupSettings";
			this.buttonMenuProjectEditFileGroupSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditFileGroupSettings_ItemClick);
			// 
			// buttonMenuProjectAddFilesToFileGroup
			// 
			resources.ApplyResources(this.buttonMenuProjectAddFilesToFileGroup, "buttonMenuProjectAddFilesToFileGroup");
			this.buttonMenuProjectAddFilesToFileGroup.Id = 8;
			this.buttonMenuProjectAddFilesToFileGroup.ImageIndex = 5;
			this.buttonMenuProjectAddFilesToFileGroup.Name = "buttonMenuProjectAddFilesToFileGroup";
			this.buttonMenuProjectAddFilesToFileGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddFilesToFileGroup_ItemClick);
			// 
			// buttonMenuProjectRemoveFileFromFileGroup
			// 
			resources.ApplyResources(this.buttonMenuProjectRemoveFileFromFileGroup, "buttonMenuProjectRemoveFileFromFileGroup");
			this.buttonMenuProjectRemoveFileFromFileGroup.Id = 9;
			this.buttonMenuProjectRemoveFileFromFileGroup.ImageIndex = 6;
			this.buttonMenuProjectRemoveFileFromFileGroup.Name = "buttonMenuProjectRemoveFileFromFileGroup";
			this.buttonMenuProjectRemoveFileFromFileGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRemoveFileFromFileGroup_ItemClick);
			// 
			// buttonMenuProjectEditProjectSettings
			// 
			resources.ApplyResources(this.buttonMenuProjectEditProjectSettings, "buttonMenuProjectEditProjectSettings");
			this.buttonMenuProjectEditProjectSettings.Id = 10;
			this.buttonMenuProjectEditProjectSettings.ImageIndex = 7;
			this.buttonMenuProjectEditProjectSettings.Name = "buttonMenuProjectEditProjectSettings";
			this.buttonMenuProjectEditProjectSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditProjectSettings_ItemClick);
			// 
			// buttonMenuProjectAddProjectFolder
			// 
			resources.ApplyResources(this.buttonMenuProjectAddProjectFolder, "buttonMenuProjectAddProjectFolder");
			this.buttonMenuProjectAddProjectFolder.Id = 11;
			this.buttonMenuProjectAddProjectFolder.ImageIndex = 10;
			this.buttonMenuProjectAddProjectFolder.Name = "buttonMenuProjectAddProjectFolder";
			this.buttonMenuProjectAddProjectFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddProjectFolder_ItemClick);
			// 
			// buttonMenuProjectRemoveProjectFolder
			// 
			resources.ApplyResources(this.buttonMenuProjectRemoveProjectFolder, "buttonMenuProjectRemoveProjectFolder");
			this.buttonMenuProjectRemoveProjectFolder.Id = 12;
			this.buttonMenuProjectRemoveProjectFolder.ImageIndex = 12;
			this.buttonMenuProjectRemoveProjectFolder.Name = "buttonMenuProjectRemoveProjectFolder";
			this.buttonMenuProjectRemoveProjectFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRemoveProjectFolder_ItemClick);
			// 
			// buttonMenuProjectEditProjectFolder
			// 
			resources.ApplyResources(this.buttonMenuProjectEditProjectFolder, "buttonMenuProjectEditProjectFolder");
			this.buttonMenuProjectEditProjectFolder.Id = 13;
			this.buttonMenuProjectEditProjectFolder.ImageIndex = 11;
			this.buttonMenuProjectEditProjectFolder.Name = "buttonMenuProjectEditProjectFolder";
			this.buttonMenuProjectEditProjectFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditProjectFolder_ItemClick);
			// 
			// buttonMenuProjectMoveUp
			// 
			resources.ApplyResources(this.buttonMenuProjectMoveUp, "buttonMenuProjectMoveUp");
			this.buttonMenuProjectMoveUp.Id = 14;
			this.buttonMenuProjectMoveUp.ImageIndex = 8;
			this.buttonMenuProjectMoveUp.Name = "buttonMenuProjectMoveUp";
			this.buttonMenuProjectMoveUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMoveUp_ItemClick);
			// 
			// buttonMenuProjectMoveDown
			// 
			resources.ApplyResources(this.buttonMenuProjectMoveDown, "buttonMenuProjectMoveDown");
			this.buttonMenuProjectMoveDown.Id = 15;
			this.buttonMenuProjectMoveDown.ImageIndex = 9;
			this.buttonMenuProjectMoveDown.Name = "buttonMenuProjectMoveDown";
			this.buttonMenuProjectMoveDown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMoveDown_ItemClick);
			// 
			// buttonMenuProjectCreateNewFile
			// 
			resources.ApplyResources(this.buttonMenuProjectCreateNewFile, "buttonMenuProjectCreateNewFile");
			this.buttonMenuProjectCreateNewFile.Id = 16;
			this.buttonMenuProjectCreateNewFile.ImageIndex = 13;
			this.buttonMenuProjectCreateNewFile.Name = "buttonMenuProjectCreateNewFile";
			this.buttonMenuProjectCreateNewFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCreateNewFile_ItemClick);
			// 
			// buttonMenuProjectCreateNewFiles
			// 
			resources.ApplyResources(this.buttonMenuProjectCreateNewFiles, "buttonMenuProjectCreateNewFiles");
			this.buttonMenuProjectCreateNewFiles.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonMenuProjectCreateNewFiles.Glyph")));
			this.buttonMenuProjectCreateNewFiles.Id = 17;
			this.buttonMenuProjectCreateNewFiles.Name = "buttonMenuProjectCreateNewFiles";
			this.buttonMenuProjectCreateNewFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCreateNewFiles_ItemClick);
			// 
			// buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution
			// 
			resources.ApplyResources(this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution, "buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution");
			this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Glyph")));
			this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Id = 18;
			this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Name = "buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution";
			this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAutomaticallyAddFileGroupsFromVisualStudioSolution_ItemClick);
			// 
			// buttonOpenProjectMenuItem
			// 
			resources.ApplyResources(this.buttonOpenProjectMenuItem, "buttonOpenProjectMenuItem");
			this.buttonOpenProjectMenuItem.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonOpenProjectMenuItem.Glyph")));
			this.buttonOpenProjectMenuItem.Id = 19;
			this.buttonOpenProjectMenuItem.Name = "buttonOpenProjectMenuItem";
			this.buttonOpenProjectMenuItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonOpenProjectMenuItem_ItemClick);
			// 
			// buttonSortProjectFolderChildrenAscendingAZ
			// 
			resources.ApplyResources(this.buttonSortProjectFolderChildrenAscendingAZ, "buttonSortProjectFolderChildrenAscendingAZ");
			this.buttonSortProjectFolderChildrenAscendingAZ.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonSortProjectFolderChildrenAscendingAZ.Glyph")));
			this.buttonSortProjectFolderChildrenAscendingAZ.Id = 20;
			this.buttonSortProjectFolderChildrenAscendingAZ.Name = "buttonSortProjectFolderChildrenAscendingAZ";
			this.buttonSortProjectFolderChildrenAscendingAZ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSortAscendingAZ_ItemClick);
			// 
			// buttonSortChildrenProjectAZ
			// 
			resources.ApplyResources(this.buttonSortChildrenProjectAZ, "buttonSortChildrenProjectAZ");
			this.buttonSortChildrenProjectAZ.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonSortChildrenProjectAZ.Glyph")));
			this.buttonSortChildrenProjectAZ.Id = 21;
			this.buttonSortChildrenProjectAZ.Name = "buttonSortChildrenProjectAZ";
			this.buttonSortChildrenProjectAZ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSortChildrenProjectAZ_ItemClick);
			// 
			// buttonMenuProjectFolderAddFileGroupToProject
			// 
			resources.ApplyResources(this.buttonMenuProjectFolderAddFileGroupToProject, "buttonMenuProjectFolderAddFileGroupToProject");
			this.buttonMenuProjectFolderAddFileGroupToProject.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonMenuProjectFolderAddFileGroupToProject.Glyph")));
			this.buttonMenuProjectFolderAddFileGroupToProject.Id = 22;
			this.buttonMenuProjectFolderAddFileGroupToProject.Name = "buttonMenuProjectFolderAddFileGroupToProject";
			this.buttonMenuProjectFolderAddFileGroupToProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMenuProjectFolderAddFileGroupToProject_ItemClick);
			// 
			// buttonMenuProjectAddNewFileGroupToProject
			// 
			resources.ApplyResources(this.buttonMenuProjectAddNewFileGroupToProject, "buttonMenuProjectAddNewFileGroupToProject");
			this.buttonMenuProjectAddNewFileGroupToProject.Glyph = ((System.Drawing.Image)(resources.GetObject("buttonMenuProjectAddNewFileGroupToProject.Glyph")));
			this.buttonMenuProjectAddNewFileGroupToProject.Id = 23;
			this.buttonMenuProjectAddNewFileGroupToProject.Name = "buttonMenuProjectAddNewFileGroupToProject";
			this.buttonMenuProjectAddNewFileGroupToProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMenuProjectAddNewFileGroupToProject_ItemClick);
			// 
			// popupMenuProject
			// 
			this.popupMenuProject.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectEditResourceFiles),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAddFileGroupToProject, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAddNewFileGroupToProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectCreateNewFiles),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAddProjectFolder, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectEditProjectSettings, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonSortChildrenProjectAZ, true)});
			this.popupMenuProject.Manager = this.barManager;
			this.popupMenuProject.Name = "popupMenuProject";
			this.popupMenuProject.BeforePopup += new System.ComponentModel.CancelEventHandler(this.optionsPopupMenu_BeforePopup);
			// 
			// popupMenuProjectFolder
			// 
			this.popupMenuProjectFolder.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectEditResourceFiles),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAddFileGroupToProject, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectFolderAddFileGroupToProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectCreateNewFiles),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAddProjectFolder, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectRemoveProjectFolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectEditProjectFolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectEditProjectSettings, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectMoveUp, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectMoveDown),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonSortProjectFolderChildrenAscendingAZ)});
			this.popupMenuProjectFolder.Manager = this.barManager;
			this.popupMenuProjectFolder.Name = "popupMenuProjectFolder";
			// 
			// popupMenuFileGroup
			// 
			this.popupMenuFileGroup.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectEditResourceFiles),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectRemoveFileGroupFromProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectEditFileGroupSettings),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectAddFilesToFileGroup, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectCreateNewFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectEditProjectSettings, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectMoveUp, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectMoveDown)});
			this.popupMenuFileGroup.Manager = this.barManager;
			this.popupMenuFileGroup.Name = "popupMenuFileGroup";
			// 
			// popupMenuFile
			// 
			this.popupMenuFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectRemoveFileFromFileGroup),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectEditProjectSettings, true)});
			this.popupMenuFile.Manager = this.barManager;
			this.popupMenuFile.Name = "popupMenuFile";
			// 
			// popupMenuNone
			// 
			this.popupMenuNone.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonOpenProjectMenuItem)});
			this.popupMenuNone.Manager = this.barManager;
			this.popupMenuNone.Name = "popupMenuNone";
			// 
			// updateNodeStateImageBackgroundworker
			// 
			this.updateNodeStateImageBackgroundworker.WorkerReportsProgress = true;
			this.updateNodeStateImageBackgroundworker.WorkerSupportsCancellation = true;
			this.updateNodeStateImageBackgroundworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateNodeStateImageBackgroundworker_DoWork);
			this.updateNodeStateImageBackgroundworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.updateNodeStateImageBackgroundworker_ProgressChanged);
			this.updateNodeStateImageBackgroundworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updateNodeStateImageBackgroundworker_RunWorkerCompleted);
			// 
			// ProjectFilesUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.resourceEditorProjectFilesSplitContainer);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "ProjectFilesUserControl";
			resources.ApplyResources(this, "$this");
			this.Load += new System.EventHandler(this.projectFilesUserControlNew_Load);
			((System.ComponentModel.ISupportInitialize)(this.resourceEditorProjectFilesSplitContainer)).EndInit();
			this.resourceEditorProjectFilesSplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.treeView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.treeImageList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stateImageList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupBarImageCollection)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuProject)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuProjectFolder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuFileGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuFile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuNone)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer guiRefreshTimer;
		private DevExpress.Utils.ImageCollection treeImageList;
		private DevExpress.Utils.ImageCollection stateImageList;
		private ZetaResourceEditor.UI.Helper.ZetaResourceEditorTreeListControl treeView;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.Utils.ImageCollection popupBarImageCollection;
		private DevExpress.XtraBars.PopupMenu popupMenuProject;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectEditResourceFiles;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectAddFileGroupToProject;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectRemoveFileGroupFromProject;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectEditFileGroupSettings;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectAddFilesToFileGroup;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectRemoveFileFromFileGroup;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectEditProjectSettings;
		private DevExpress.XtraEditors.SplitContainerControl resourceEditorProjectFilesSplitContainer;
		private ZetaResourceEditor.UI.Helper.ExtendedWebBrowser.ExtendedWebBrowserUserControl newsBrowserControl;
		private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
		private DevExpress.Utils.ToolTipController toolTipController1;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectAddProjectFolder;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectRemoveProjectFolder;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectEditProjectFolder;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectMoveUp;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectMoveDown;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectCreateNewFile;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectCreateNewFiles;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution;
		private DevExpress.XtraBars.PopupMenu popupMenuProjectFolder;
		private DevExpress.XtraBars.PopupMenu popupMenuFileGroup;
		private DevExpress.XtraBars.PopupMenu popupMenuFile;
		private DevExpress.XtraBars.PopupMenu popupMenuNone;
		private DevExpress.XtraBars.BarButtonItem buttonOpenProjectMenuItem;
		private System.ComponentModel.BackgroundWorker updateNodeStateImageBackgroundworker;
		private DevExpress.XtraBars.BarButtonItem buttonSortProjectFolderChildrenAscendingAZ;
		private DevExpress.XtraBars.BarButtonItem buttonSortChildrenProjectAZ;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectFolderAddFileGroupToProject;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectAddNewFileGroupToProject;
	}
}
