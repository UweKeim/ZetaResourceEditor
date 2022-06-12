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
            this.treeView = new ZetaResourceEditor.UI.Helper.ZetaResourceEditorTreeListControl();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
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
            this.buttonMenuProjectDeleteExistingLanguage = new DevExpress.XtraBars.BarButtonItem();
            this.buttonMenuProjectDeleteLanguages = new DevExpress.XtraBars.BarButtonItem();
            this.buttonMergeIntoFileGroup = new DevExpress.XtraBars.BarButtonItem();
            this.guiRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.popupMenuProject = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuProjectFolder = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuFileGroup = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuFile = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuNone = new DevExpress.XtraBars.PopupMenu(this.components);
            this.updateNodeStateImageBackgroundworker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProjectFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuFileGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuNone)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.EmptyText = "No items";
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.OptionsBehavior.AllowExpandOnDblClick = false;
            this.treeView.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused;
            this.treeView.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Single;
            this.treeView.OptionsFind.AllowIncrementalSearch = true;
            this.treeView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeView.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.treeView.OptionsView.ShowColumns = false;
            this.treeView.OptionsView.ShowHorzLines = false;
            this.treeView.OptionsView.ShowIndicator = false;
            this.treeView.OptionsView.ShowRoot = false;
            this.treeView.OptionsView.ShowVertLines = false;
            this.treeView.SelectedNode = null;
            this.treeView.Size = new System.Drawing.Size(201, 434);
            this.treeView.TabIndex = 1;
            this.treeView.ToolTipController = this.toolTipController1;
            this.treeView.WasDoubleClick = false;
            this.treeView.CompareNodeValues += new DevExpress.XtraTreeList.CompareNodeValuesEventHandler(this.treeView_CompareNodeValues);
            this.treeView.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeView_NodeCellStyle);
            this.treeView.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.treeView_BeforeExpand);
            this.treeView.BeforeCollapse += new DevExpress.XtraTreeList.BeforeCollapseEventHandler(this.treeView_BeforeCollapse);
            this.treeView.CalcNodeDragImageIndex += new DevExpress.XtraTreeList.CalcNodeDragImageIndexEventHandler(this.treeView_CalcNodeDragImageIndex);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView_DragOver);
            this.treeView.DoubleClick += new System.EventHandler(this.treeView_DoubleClick);
            this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyDown);
            this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseUp);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 52;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.OptionsColumn.AllowMove = false;
            this.treeListColumn1.OptionsColumn.AllowSort = false;
            this.treeListColumn1.OptionsColumn.ReadOnly = true;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 108;
            // 
            // toolTipController1
            // 
            this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(201, 0);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
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
            this.buttonMenuProjectAddNewFileGroupToProject,
            this.buttonMenuProjectDeleteExistingLanguage,
            this.buttonMenuProjectDeleteLanguages,
            this.buttonMergeIntoFileGroup});
            this.barManager.MaxItemId = 27;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 434);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(201, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 434);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(201, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 434);
            // 
            // buttonMenuProjectEditResourceFiles
            // 
            this.buttonMenuProjectEditResourceFiles.Caption = "Edit resource files";
            this.buttonMenuProjectEditResourceFiles.Id = 3;
            this.buttonMenuProjectEditResourceFiles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuProjectEditResourceFiles.ImageOptions.Image")));
            this.buttonMenuProjectEditResourceFiles.Name = "buttonMenuProjectEditResourceFiles";
            this.buttonMenuProjectEditResourceFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditResourceFiles_ItemClick);
            // 
            // buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject
            // 
            this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.Caption = "Automatically add multiple file groups to project";
            this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.Id = 4;
            this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.ImageOptions.Image")));
            this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.Name = "buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject";
            this.buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAutomaticallyAddMultipleFileGroupsToProject_ItemClick);
            // 
            // buttonMenuProjectAddFileGroupToProject
            // 
            this.buttonMenuProjectAddFileGroupToProject.Caption = "Add existing file group to project";
            this.buttonMenuProjectAddFileGroupToProject.Id = 5;
            this.buttonMenuProjectAddFileGroupToProject.Name = "buttonMenuProjectAddFileGroupToProject";
            this.buttonMenuProjectAddFileGroupToProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddFileGroupToProject_ItemClick);
            // 
            // buttonMenuProjectRemoveFileGroupFromProject
            // 
            this.buttonMenuProjectRemoveFileGroupFromProject.Caption = "Remove file group from project";
            this.buttonMenuProjectRemoveFileGroupFromProject.Id = 6;
            this.buttonMenuProjectRemoveFileGroupFromProject.Name = "buttonMenuProjectRemoveFileGroupFromProject";
            this.buttonMenuProjectRemoveFileGroupFromProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRemoveFileGroupFromProject_ItemClick);
            // 
            // buttonMenuProjectEditFileGroupSettings
            // 
            this.buttonMenuProjectEditFileGroupSettings.Caption = "Edit file group settings";
            this.buttonMenuProjectEditFileGroupSettings.Id = 7;
            this.buttonMenuProjectEditFileGroupSettings.Name = "buttonMenuProjectEditFileGroupSettings";
            this.buttonMenuProjectEditFileGroupSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditFileGroupSettings_ItemClick);
            // 
            // buttonMenuProjectAddFilesToFileGroup
            // 
            this.buttonMenuProjectAddFilesToFileGroup.Caption = "Add files to file group";
            this.buttonMenuProjectAddFilesToFileGroup.Id = 8;
            this.buttonMenuProjectAddFilesToFileGroup.Name = "buttonMenuProjectAddFilesToFileGroup";
            this.buttonMenuProjectAddFilesToFileGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddFilesToFileGroup_ItemClick);
            // 
            // buttonMenuProjectRemoveFileFromFileGroup
            // 
            this.buttonMenuProjectRemoveFileFromFileGroup.Caption = "Remove file from file group";
            this.buttonMenuProjectRemoveFileFromFileGroup.Id = 9;
            this.buttonMenuProjectRemoveFileFromFileGroup.Name = "buttonMenuProjectRemoveFileFromFileGroup";
            this.buttonMenuProjectRemoveFileFromFileGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRemoveFileFromFileGroup_ItemClick);
            // 
            // buttonMenuProjectEditProjectSettings
            // 
            this.buttonMenuProjectEditProjectSettings.Caption = "Edit project settings";
            this.buttonMenuProjectEditProjectSettings.Id = 10;
            this.buttonMenuProjectEditProjectSettings.Name = "buttonMenuProjectEditProjectSettings";
            this.buttonMenuProjectEditProjectSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditProjectSettings_ItemClick);
            // 
            // buttonMenuProjectAddProjectFolder
            // 
            this.buttonMenuProjectAddProjectFolder.Caption = "Add new project folder";
            this.buttonMenuProjectAddProjectFolder.Id = 11;
            this.buttonMenuProjectAddProjectFolder.Name = "buttonMenuProjectAddProjectFolder";
            this.buttonMenuProjectAddProjectFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddProjectFolder_ItemClick);
            // 
            // buttonMenuProjectRemoveProjectFolder
            // 
            this.buttonMenuProjectRemoveProjectFolder.Caption = "Remove project folder";
            this.buttonMenuProjectRemoveProjectFolder.Id = 12;
            this.buttonMenuProjectRemoveProjectFolder.Name = "buttonMenuProjectRemoveProjectFolder";
            this.buttonMenuProjectRemoveProjectFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRemoveProjectFolder_ItemClick);
            // 
            // buttonMenuProjectEditProjectFolder
            // 
            this.buttonMenuProjectEditProjectFolder.Caption = "Edit project folder";
            this.buttonMenuProjectEditProjectFolder.Id = 13;
            this.buttonMenuProjectEditProjectFolder.Name = "buttonMenuProjectEditProjectFolder";
            this.buttonMenuProjectEditProjectFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditProjectFolder_ItemClick);
            // 
            // buttonMenuProjectMoveUp
            // 
            this.buttonMenuProjectMoveUp.Caption = "Move up";
            this.buttonMenuProjectMoveUp.Id = 14;
            this.buttonMenuProjectMoveUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuProjectMoveUp.ImageOptions.Image")));
            this.buttonMenuProjectMoveUp.Name = "buttonMenuProjectMoveUp";
            this.buttonMenuProjectMoveUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMoveUp_ItemClick);
            // 
            // buttonMenuProjectMoveDown
            // 
            this.buttonMenuProjectMoveDown.Caption = "Move down";
            this.buttonMenuProjectMoveDown.Id = 15;
            this.buttonMenuProjectMoveDown.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuProjectMoveDown.ImageOptions.Image")));
            this.buttonMenuProjectMoveDown.Name = "buttonMenuProjectMoveDown";
            this.buttonMenuProjectMoveDown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMoveDown_ItemClick);
            // 
            // buttonMenuProjectCreateNewFile
            // 
            this.buttonMenuProjectCreateNewFile.Caption = "Create new file for language";
            this.buttonMenuProjectCreateNewFile.Id = 16;
            this.buttonMenuProjectCreateNewFile.Name = "buttonMenuProjectCreateNewFile";
            this.buttonMenuProjectCreateNewFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCreateNewFile_ItemClick);
            // 
            // buttonMenuProjectCreateNewFiles
            // 
            this.buttonMenuProjectCreateNewFiles.Caption = "Create new files for language";
            this.buttonMenuProjectCreateNewFiles.Id = 17;
            this.buttonMenuProjectCreateNewFiles.Name = "buttonMenuProjectCreateNewFiles";
            this.buttonMenuProjectCreateNewFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonCreateNewFiles_ItemClick);
            // 
            // buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution
            // 
            this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Caption = "Automatically add file groups from Visual Studio solution";
            this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Id = 18;
            this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.ImageOptions." +
        "Image")));
            this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Name = "buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution";
            this.buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAutomaticallyAddFileGroupsFromVisualStudioSolution_ItemClick);
            // 
            // buttonOpenProjectMenuItem
            // 
            this.buttonOpenProjectMenuItem.Caption = "Open project file";
            this.buttonOpenProjectMenuItem.Id = 19;
            this.buttonOpenProjectMenuItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenProjectMenuItem.ImageOptions.Image")));
            this.buttonOpenProjectMenuItem.Name = "buttonOpenProjectMenuItem";
            this.buttonOpenProjectMenuItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonOpenProjectMenuItem_ItemClick);
            // 
            // buttonSortProjectFolderChildrenAscendingAZ
            // 
            this.buttonSortProjectFolderChildrenAscendingAZ.Caption = "Sort children alphabetically";
            this.buttonSortProjectFolderChildrenAscendingAZ.Id = 20;
            this.buttonSortProjectFolderChildrenAscendingAZ.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortProjectFolderChildrenAscendingAZ.ImageOptions.Image")));
            this.buttonSortProjectFolderChildrenAscendingAZ.Name = "buttonSortProjectFolderChildrenAscendingAZ";
            this.buttonSortProjectFolderChildrenAscendingAZ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSortAscendingAZ_ItemClick);
            // 
            // buttonSortChildrenProjectAZ
            // 
            this.buttonSortChildrenProjectAZ.Caption = "Sort children alphabetically";
            this.buttonSortChildrenProjectAZ.Id = 21;
            this.buttonSortChildrenProjectAZ.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortChildrenProjectAZ.ImageOptions.Image")));
            this.buttonSortChildrenProjectAZ.Name = "buttonSortChildrenProjectAZ";
            this.buttonSortChildrenProjectAZ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSortChildrenProjectAZ_ItemClick);
            // 
            // buttonMenuProjectFolderAddFileGroupToProject
            // 
            this.buttonMenuProjectFolderAddFileGroupToProject.Caption = "Add new file group to project";
            this.buttonMenuProjectFolderAddFileGroupToProject.Id = 22;
            this.buttonMenuProjectFolderAddFileGroupToProject.Name = "buttonMenuProjectFolderAddFileGroupToProject";
            this.buttonMenuProjectFolderAddFileGroupToProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMenuProjectFolderAddFileGroupToProject_ItemClick);
            // 
            // buttonMenuProjectAddNewFileGroupToProject
            // 
            this.buttonMenuProjectAddNewFileGroupToProject.Caption = "Add new file group to project";
            this.buttonMenuProjectAddNewFileGroupToProject.Id = 23;
            this.buttonMenuProjectAddNewFileGroupToProject.Name = "buttonMenuProjectAddNewFileGroupToProject";
            this.buttonMenuProjectAddNewFileGroupToProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMenuProjectAddNewFileGroupToProject_ItemClick);
            // 
            // buttonMenuProjectDeleteExistingLanguage
            // 
            this.buttonMenuProjectDeleteExistingLanguage.Caption = "Delete language";
            this.buttonMenuProjectDeleteExistingLanguage.Id = 24;
            this.buttonMenuProjectDeleteExistingLanguage.Name = "buttonMenuProjectDeleteExistingLanguage";
            this.buttonMenuProjectDeleteExistingLanguage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMenuProjectDeleteExistingLanguage_ItemClick);
            // 
            // buttonMenuProjectDeleteLanguages
            // 
            this.buttonMenuProjectDeleteLanguages.Caption = "Delete language";
            this.buttonMenuProjectDeleteLanguages.Id = 25;
            this.buttonMenuProjectDeleteLanguages.Name = "buttonMenuProjectDeleteLanguages";
            this.buttonMenuProjectDeleteLanguages.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMenuProjectDeleteLanguages_ItemClick);
            // 
            // buttonMergeIntoFileGroup
            // 
            this.buttonMergeIntoFileGroup.Caption = "Merge into this file group";
            this.buttonMergeIntoFileGroup.Id = 26;
            this.buttonMergeIntoFileGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonMergeIntoFileGroup.ImageOptions.Image")));
            this.buttonMergeIntoFileGroup.Name = "buttonMergeIntoFileGroup";
            this.buttonMergeIntoFileGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonMergeIntoFileGroup_ItemClick);
            // 
            // guiRefreshTimer
            // 
            this.guiRefreshTimer.Interval = 500;
            this.guiRefreshTimer.Tick += new System.EventHandler(this.guiRefreshTimer_Tick);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectDeleteLanguages),
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
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMenuProjectDeleteExistingLanguage),
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
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonMergeIntoFileGroup),
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
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ProjectFilesUserControl";
            this.Size = new System.Drawing.Size(201, 434);
            this.Load += new System.EventHandler(this.projectFilesUserControlNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuProjectFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuFileGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuNone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer guiRefreshTimer;
		private ZetaResourceEditor.UI.Helper.ZetaResourceEditorTreeListControl treeView;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.PopupMenu popupMenuProject;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectEditResourceFiles;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectAddFileGroupToProject;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectRemoveFileGroupFromProject;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectEditFileGroupSettings;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectAddFilesToFileGroup;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectRemoveFileFromFileGroup;
		private DevExpress.XtraBars.BarButtonItem buttonMenuProjectEditProjectSettings;
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
        private DevExpress.XtraBars.BarButtonItem buttonMenuProjectDeleteExistingLanguage;
        private DevExpress.XtraBars.BarButtonItem buttonMenuProjectDeleteLanguages;
        private DevExpress.XtraBars.BarButtonItem buttonMergeIntoFileGroup;
    }
}
