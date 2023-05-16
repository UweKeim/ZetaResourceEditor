namespace ZetaResourceEditor.UI.Main.LeftTree
{
	partial class ProjectFilesUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(ProjectFilesUserControl));
			treeView = new Helper.ZetaResourceEditorTreeListControl();
			treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			toolTipController1 = new ToolTipController(components);
			barDockControlTop = new BarDockControl();
			barManager = new BarManager(components);
			barDockControlBottom = new BarDockControl();
			barDockControlLeft = new BarDockControl();
			barDockControlRight = new BarDockControl();
			buttonMenuProjectEditResourceFiles = new BarButtonItem();
			buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject = new BarButtonItem();
			buttonMenuProjectAddFileGroupToProject = new BarButtonItem();
			buttonMenuProjectRemoveFileGroupFromProject = new BarButtonItem();
			buttonMenuProjectEditFileGroupSettings = new BarButtonItem();
			buttonMenuProjectAddFilesToFileGroup = new BarButtonItem();
			buttonMenuProjectRemoveFileFromFileGroup = new BarButtonItem();
			buttonMenuProjectEditProjectSettings = new BarButtonItem();
			buttonMenuProjectAddProjectFolder = new BarButtonItem();
			buttonMenuProjectRemoveProjectFolder = new BarButtonItem();
			buttonMenuProjectEditProjectFolder = new BarButtonItem();
			buttonMenuProjectMoveUp = new BarButtonItem();
			buttonMenuProjectMoveDown = new BarButtonItem();
			buttonMenuProjectCreateNewFile = new BarButtonItem();
			buttonMenuProjectCreateNewFiles = new BarButtonItem();
			buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution = new BarButtonItem();
			buttonOpenProjectMenuItem = new BarButtonItem();
			buttonSortProjectFolderChildrenAscendingAZ = new BarButtonItem();
			buttonSortChildrenProjectAZ = new BarButtonItem();
			buttonMenuProjectFolderAddFileGroupToProject = new BarButtonItem();
			buttonMenuProjectAddNewFileGroupToProject = new BarButtonItem();
			buttonMenuProjectDeleteExistingLanguage = new BarButtonItem();
			buttonMenuProjectDeleteLanguages = new BarButtonItem();
			buttonMergeIntoFileGroup = new BarButtonItem();
			guiRefreshTimer = new System.Windows.Forms.Timer(components);
			popupMenuProject = new PopupMenu(components);
			popupMenuProjectFolder = new PopupMenu(components);
			popupMenuFileGroup = new PopupMenu(components);
			popupMenuFile = new PopupMenu(components);
			popupMenuNone = new PopupMenu(components);
			updateNodeStateImageBackgroundworker = new BackgroundWorker();
			((ISupportInitialize)treeView).BeginInit();
			((ISupportInitialize)barManager).BeginInit();
			((ISupportInitialize)popupMenuProject).BeginInit();
			((ISupportInitialize)popupMenuProjectFolder).BeginInit();
			((ISupportInitialize)popupMenuFileGroup).BeginInit();
			((ISupportInitialize)popupMenuFile).BeginInit();
			((ISupportInitialize)popupMenuNone).BeginInit();
			SuspendLayout();
			// 
			// treeView
			// 
			treeView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { treeListColumn1 });
			treeView.Dock = DockStyle.Fill;
			treeView.EmptyText = "No items";
			treeView.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			treeView.Location = new Point(0, 0);
			treeView.Name = "treeView";
			treeView.OptionsBehavior.AllowExpandOnDblClick = false;
			treeView.OptionsBehavior.EditorShowMode = TreeListEditorShowMode.MouseDownFocused;
			treeView.OptionsDragAndDrop.DragNodesMode = DragNodesMode.Single;
			treeView.OptionsFind.AllowIncrementalSearch = true;
			treeView.OptionsSelection.EnableAppearanceFocusedCell = false;
			treeView.OptionsView.FocusRectStyle = DrawFocusRectStyle.None;
			treeView.OptionsView.ShowColumns = false;
			treeView.OptionsView.ShowHorzLines = false;
			treeView.OptionsView.ShowIndicator = false;
			treeView.OptionsView.ShowRoot = false;
			treeView.OptionsView.ShowVertLines = false;
			treeView.SelectedNode = null;
			treeView.Size = new Size(201, 434);
			treeView.TabIndex = 1;
			treeView.ToolTipController = toolTipController1;
			treeView.WasDoubleClick = false;
			treeView.CompareNodeValues += treeView_CompareNodeValues;
			treeView.NodeCellStyle += treeView_NodeCellStyle;
			treeView.BeforeExpand += treeView_BeforeExpand;
			treeView.BeforeCollapse += treeView_BeforeCollapse;
			treeView.CalcNodeDragImageIndex += treeView_CalcNodeDragImageIndex;
			treeView.DragDrop += treeView_DragDrop;
			treeView.DragOver += treeView_DragOver;
			treeView.DoubleClick += treeView_DoubleClick;
			treeView.KeyDown += treeView_KeyDown;
			treeView.MouseUp += treeView_MouseUp;
			// 
			// treeListColumn1
			// 
			treeListColumn1.Caption = "Name";
			treeListColumn1.FieldName = "Name";
			treeListColumn1.MinWidth = 52;
			treeListColumn1.Name = "treeListColumn1";
			treeListColumn1.OptionsColumn.AllowEdit = false;
			treeListColumn1.OptionsColumn.AllowMove = false;
			treeListColumn1.OptionsColumn.AllowSort = false;
			treeListColumn1.OptionsColumn.ReadOnly = true;
			treeListColumn1.Visible = true;
			treeListColumn1.VisibleIndex = 0;
			treeListColumn1.Width = 108;
			// 
			// toolTipController1
			// 
			toolTipController1.GetActiveObjectInfo += toolTipController1_GetActiveObjectInfo;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager;
			barDockControlTop.Size = new Size(201, 0);
			// 
			// barManager
			// 
			barManager.DockControls.Add(barDockControlTop);
			barManager.DockControls.Add(barDockControlBottom);
			barManager.DockControls.Add(barDockControlLeft);
			barManager.DockControls.Add(barDockControlRight);
			barManager.Form = this;
			barManager.Items.AddRange(new BarItem[] { buttonMenuProjectEditResourceFiles, buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject, buttonMenuProjectAddFileGroupToProject, buttonMenuProjectRemoveFileGroupFromProject, buttonMenuProjectEditFileGroupSettings, buttonMenuProjectAddFilesToFileGroup, buttonMenuProjectRemoveFileFromFileGroup, buttonMenuProjectEditProjectSettings, buttonMenuProjectAddProjectFolder, buttonMenuProjectRemoveProjectFolder, buttonMenuProjectEditProjectFolder, buttonMenuProjectMoveUp, buttonMenuProjectMoveDown, buttonMenuProjectCreateNewFile, buttonMenuProjectCreateNewFiles, buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution, buttonOpenProjectMenuItem, buttonSortProjectFolderChildrenAscendingAZ, buttonSortChildrenProjectAZ, buttonMenuProjectFolderAddFileGroupToProject, buttonMenuProjectAddNewFileGroupToProject, buttonMenuProjectDeleteExistingLanguage, buttonMenuProjectDeleteLanguages, buttonMergeIntoFileGroup });
			barManager.MaxItemId = 27;
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 434);
			barDockControlBottom.Manager = barManager;
			barDockControlBottom.Size = new Size(201, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 0);
			barDockControlLeft.Manager = barManager;
			barDockControlLeft.Size = new Size(0, 434);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(201, 0);
			barDockControlRight.Manager = barManager;
			barDockControlRight.Size = new Size(0, 434);
			// 
			// buttonMenuProjectEditResourceFiles
			// 
			buttonMenuProjectEditResourceFiles.Caption = "Edit resource files";
			buttonMenuProjectEditResourceFiles.Id = 3;
			buttonMenuProjectEditResourceFiles.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonMenuProjectEditResourceFiles.ImageOptions.SvgImage");
			buttonMenuProjectEditResourceFiles.Name = "buttonMenuProjectEditResourceFiles";
			buttonMenuProjectEditResourceFiles.ItemClick += buttonEditResourceFiles_ItemClick;
			// 
			// buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject
			// 
			buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.Caption = "Automatically add multiple file groups to project";
			buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.Id = 4;
			buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.ImageOptions.SvgImage");
			buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.Name = "buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject";
			buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.ItemClick += buttonAutomaticallyAddMultipleFileGroupsToProject_ItemClick;
			// 
			// buttonMenuProjectAddFileGroupToProject
			// 
			buttonMenuProjectAddFileGroupToProject.Caption = "Add existing file group to project";
			buttonMenuProjectAddFileGroupToProject.Id = 5;
			buttonMenuProjectAddFileGroupToProject.Name = "buttonMenuProjectAddFileGroupToProject";
			buttonMenuProjectAddFileGroupToProject.ItemClick += buttonAddFileGroupToProject_ItemClick;
			// 
			// buttonMenuProjectRemoveFileGroupFromProject
			// 
			buttonMenuProjectRemoveFileGroupFromProject.Caption = "Remove file group from project";
			buttonMenuProjectRemoveFileGroupFromProject.Id = 6;
			buttonMenuProjectRemoveFileGroupFromProject.Name = "buttonMenuProjectRemoveFileGroupFromProject";
			buttonMenuProjectRemoveFileGroupFromProject.ItemClick += buttonRemoveFileGroupFromProject_ItemClick;
			// 
			// buttonMenuProjectEditFileGroupSettings
			// 
			buttonMenuProjectEditFileGroupSettings.Caption = "Edit file group settings";
			buttonMenuProjectEditFileGroupSettings.Id = 7;
			buttonMenuProjectEditFileGroupSettings.Name = "buttonMenuProjectEditFileGroupSettings";
			buttonMenuProjectEditFileGroupSettings.ItemClick += buttonEditFileGroupSettings_ItemClick;
			// 
			// buttonMenuProjectAddFilesToFileGroup
			// 
			buttonMenuProjectAddFilesToFileGroup.Caption = "Add files to file group";
			buttonMenuProjectAddFilesToFileGroup.Id = 8;
			buttonMenuProjectAddFilesToFileGroup.Name = "buttonMenuProjectAddFilesToFileGroup";
			buttonMenuProjectAddFilesToFileGroup.ItemClick += buttonAddFilesToFileGroup_ItemClick;
			// 
			// buttonMenuProjectRemoveFileFromFileGroup
			// 
			buttonMenuProjectRemoveFileFromFileGroup.Caption = "Remove file from file group";
			buttonMenuProjectRemoveFileFromFileGroup.Id = 9;
			buttonMenuProjectRemoveFileFromFileGroup.Name = "buttonMenuProjectRemoveFileFromFileGroup";
			buttonMenuProjectRemoveFileFromFileGroup.ItemClick += buttonRemoveFileFromFileGroup_ItemClick;
			// 
			// buttonMenuProjectEditProjectSettings
			// 
			buttonMenuProjectEditProjectSettings.Caption = "Edit project settings";
			buttonMenuProjectEditProjectSettings.Id = 10;
			buttonMenuProjectEditProjectSettings.Name = "buttonMenuProjectEditProjectSettings";
			buttonMenuProjectEditProjectSettings.ItemClick += buttonEditProjectSettings_ItemClick;
			// 
			// buttonMenuProjectAddProjectFolder
			// 
			buttonMenuProjectAddProjectFolder.Caption = "Add new project folder";
			buttonMenuProjectAddProjectFolder.Id = 11;
			buttonMenuProjectAddProjectFolder.Name = "buttonMenuProjectAddProjectFolder";
			buttonMenuProjectAddProjectFolder.ItemClick += buttonAddProjectFolder_ItemClick;
			// 
			// buttonMenuProjectRemoveProjectFolder
			// 
			buttonMenuProjectRemoveProjectFolder.Caption = "Remove project folder";
			buttonMenuProjectRemoveProjectFolder.Id = 12;
			buttonMenuProjectRemoveProjectFolder.Name = "buttonMenuProjectRemoveProjectFolder";
			buttonMenuProjectRemoveProjectFolder.ItemClick += buttonRemoveProjectFolder_ItemClick;
			// 
			// buttonMenuProjectEditProjectFolder
			// 
			buttonMenuProjectEditProjectFolder.Caption = "Edit project folder";
			buttonMenuProjectEditProjectFolder.Id = 13;
			buttonMenuProjectEditProjectFolder.Name = "buttonMenuProjectEditProjectFolder";
			buttonMenuProjectEditProjectFolder.ItemClick += buttonEditProjectFolder_ItemClick;
			// 
			// buttonMenuProjectMoveUp
			// 
			buttonMenuProjectMoveUp.Caption = "Move up";
			buttonMenuProjectMoveUp.Id = 14;
			buttonMenuProjectMoveUp.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonMenuProjectMoveUp.ImageOptions.SvgImage");
			buttonMenuProjectMoveUp.Name = "buttonMenuProjectMoveUp";
			buttonMenuProjectMoveUp.ItemClick += buttonMoveUp_ItemClick;
			// 
			// buttonMenuProjectMoveDown
			// 
			buttonMenuProjectMoveDown.Caption = "Move down";
			buttonMenuProjectMoveDown.Id = 15;
			buttonMenuProjectMoveDown.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonMenuProjectMoveDown.ImageOptions.SvgImage");
			buttonMenuProjectMoveDown.Name = "buttonMenuProjectMoveDown";
			buttonMenuProjectMoveDown.ItemClick += buttonMoveDown_ItemClick;
			// 
			// buttonMenuProjectCreateNewFile
			// 
			buttonMenuProjectCreateNewFile.Caption = "Create new file for language";
			buttonMenuProjectCreateNewFile.Id = 16;
			buttonMenuProjectCreateNewFile.Name = "buttonMenuProjectCreateNewFile";
			buttonMenuProjectCreateNewFile.ItemClick += buttonCreateNewFile_ItemClick;
			// 
			// buttonMenuProjectCreateNewFiles
			// 
			buttonMenuProjectCreateNewFiles.Caption = "Create new files for language";
			buttonMenuProjectCreateNewFiles.Id = 17;
			buttonMenuProjectCreateNewFiles.Name = "buttonMenuProjectCreateNewFiles";
			buttonMenuProjectCreateNewFiles.ItemClick += buttonCreateNewFiles_ItemClick;
			// 
			// buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution
			// 
			buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Caption = "Automatically add file groups from Visual Studio solution";
			buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Id = 18;
			buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.ImageOptions.SvgImage");
			buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Name = "buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution";
			buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.ItemClick += buttonAutomaticallyAddFileGroupsFromVisualStudioSolution_ItemClick;
			// 
			// buttonOpenProjectMenuItem
			// 
			buttonOpenProjectMenuItem.Caption = "Open project file";
			buttonOpenProjectMenuItem.Id = 19;
			buttonOpenProjectMenuItem.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonOpenProjectMenuItem.ImageOptions.SvgImage");
			buttonOpenProjectMenuItem.Name = "buttonOpenProjectMenuItem";
			buttonOpenProjectMenuItem.ItemClick += buttonOpenProjectMenuItem_ItemClick;
			// 
			// buttonSortProjectFolderChildrenAscendingAZ
			// 
			buttonSortProjectFolderChildrenAscendingAZ.Caption = "Sort children alphabetically";
			buttonSortProjectFolderChildrenAscendingAZ.Id = 20;
			buttonSortProjectFolderChildrenAscendingAZ.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSortProjectFolderChildrenAscendingAZ.ImageOptions.SvgImage");
			buttonSortProjectFolderChildrenAscendingAZ.Name = "buttonSortProjectFolderChildrenAscendingAZ";
			buttonSortProjectFolderChildrenAscendingAZ.ItemClick += buttonSortAscendingAZ_ItemClick;
			// 
			// buttonSortChildrenProjectAZ
			// 
			buttonSortChildrenProjectAZ.Caption = "Sort children alphabetically";
			buttonSortChildrenProjectAZ.Id = 21;
			buttonSortChildrenProjectAZ.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSortChildrenProjectAZ.ImageOptions.SvgImage");
			buttonSortChildrenProjectAZ.Name = "buttonSortChildrenProjectAZ";
			buttonSortChildrenProjectAZ.ItemClick += buttonSortChildrenProjectAZ_ItemClick;
			// 
			// buttonMenuProjectFolderAddFileGroupToProject
			// 
			buttonMenuProjectFolderAddFileGroupToProject.Caption = "Add new file group to project";
			buttonMenuProjectFolderAddFileGroupToProject.Id = 22;
			buttonMenuProjectFolderAddFileGroupToProject.Name = "buttonMenuProjectFolderAddFileGroupToProject";
			buttonMenuProjectFolderAddFileGroupToProject.ItemClick += buttonMenuProjectFolderAddFileGroupToProject_ItemClick;
			// 
			// buttonMenuProjectAddNewFileGroupToProject
			// 
			buttonMenuProjectAddNewFileGroupToProject.Caption = "Add new file group to project";
			buttonMenuProjectAddNewFileGroupToProject.Id = 23;
			buttonMenuProjectAddNewFileGroupToProject.Name = "buttonMenuProjectAddNewFileGroupToProject";
			buttonMenuProjectAddNewFileGroupToProject.ItemClick += buttonMenuProjectAddNewFileGroupToProject_ItemClick;
			// 
			// buttonMenuProjectDeleteExistingLanguage
			// 
			buttonMenuProjectDeleteExistingLanguage.Caption = "Delete language";
			buttonMenuProjectDeleteExistingLanguage.Id = 24;
			buttonMenuProjectDeleteExistingLanguage.Name = "buttonMenuProjectDeleteExistingLanguage";
			buttonMenuProjectDeleteExistingLanguage.ItemClick += buttonMenuProjectDeleteExistingLanguage_ItemClick;
			// 
			// buttonMenuProjectDeleteLanguages
			// 
			buttonMenuProjectDeleteLanguages.Caption = "Delete language";
			buttonMenuProjectDeleteLanguages.Id = 25;
			buttonMenuProjectDeleteLanguages.Name = "buttonMenuProjectDeleteLanguages";
			buttonMenuProjectDeleteLanguages.ItemClick += buttonMenuProjectDeleteLanguages_ItemClick;
			// 
			// buttonMergeIntoFileGroup
			// 
			buttonMergeIntoFileGroup.Caption = "Merge into this file group";
			buttonMergeIntoFileGroup.Id = 26;
			buttonMergeIntoFileGroup.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonMergeIntoFileGroup.ImageOptions.SvgImage");
			buttonMergeIntoFileGroup.Name = "buttonMergeIntoFileGroup";
			buttonMergeIntoFileGroup.ItemClick += buttonMergeIntoFileGroup_ItemClick;
			// 
			// guiRefreshTimer
			// 
			guiRefreshTimer.Interval = 500;
			guiRefreshTimer.Tick += guiRefreshTimer_Tick;
			// 
			// popupMenuProject
			// 
			popupMenuProject.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(buttonMenuProjectEditResourceFiles), new LinkPersistInfo(buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject, true), new LinkPersistInfo(buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution), new LinkPersistInfo(buttonMenuProjectAddFileGroupToProject, true), new LinkPersistInfo(buttonMenuProjectAddNewFileGroupToProject), new LinkPersistInfo(buttonMenuProjectCreateNewFiles), new LinkPersistInfo(buttonMenuProjectDeleteLanguages), new LinkPersistInfo(buttonMenuProjectAddProjectFolder, true), new LinkPersistInfo(buttonMenuProjectEditProjectSettings, true), new LinkPersistInfo(buttonSortChildrenProjectAZ, true) });
			popupMenuProject.Manager = barManager;
			popupMenuProject.Name = "popupMenuProject";
			popupMenuProject.BeforePopup += optionsPopupMenu_BeforePopup;
			// 
			// popupMenuProjectFolder
			// 
			popupMenuProjectFolder.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(buttonMenuProjectEditResourceFiles), new LinkPersistInfo(buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject, true), new LinkPersistInfo(buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution), new LinkPersistInfo(buttonMenuProjectAddFileGroupToProject, true), new LinkPersistInfo(buttonMenuProjectFolderAddFileGroupToProject), new LinkPersistInfo(buttonMenuProjectCreateNewFiles), new LinkPersistInfo(buttonMenuProjectDeleteExistingLanguage), new LinkPersistInfo(buttonMenuProjectAddProjectFolder, true), new LinkPersistInfo(buttonMenuProjectRemoveProjectFolder), new LinkPersistInfo(buttonMenuProjectEditProjectFolder), new LinkPersistInfo(buttonMenuProjectEditProjectSettings, true), new LinkPersistInfo(buttonMenuProjectMoveUp, true), new LinkPersistInfo(buttonMenuProjectMoveDown), new LinkPersistInfo(buttonSortProjectFolderChildrenAscendingAZ) });
			popupMenuProjectFolder.Manager = barManager;
			popupMenuProjectFolder.Name = "popupMenuProjectFolder";
			// 
			// popupMenuFileGroup
			// 
			popupMenuFileGroup.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(buttonMenuProjectEditResourceFiles), new LinkPersistInfo(buttonMenuProjectRemoveFileGroupFromProject), new LinkPersistInfo(buttonMenuProjectEditFileGroupSettings), new LinkPersistInfo(buttonMergeIntoFileGroup), new LinkPersistInfo(buttonMenuProjectAddFilesToFileGroup, true), new LinkPersistInfo(buttonMenuProjectCreateNewFile), new LinkPersistInfo(buttonMenuProjectEditProjectSettings, true), new LinkPersistInfo(buttonMenuProjectMoveUp, true), new LinkPersistInfo(buttonMenuProjectMoveDown) });
			popupMenuFileGroup.Manager = barManager;
			popupMenuFileGroup.Name = "popupMenuFileGroup";
			// 
			// popupMenuFile
			// 
			popupMenuFile.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(buttonMenuProjectRemoveFileFromFileGroup), new LinkPersistInfo(buttonMenuProjectEditProjectSettings, true) });
			popupMenuFile.Manager = barManager;
			popupMenuFile.Name = "popupMenuFile";
			// 
			// popupMenuNone
			// 
			popupMenuNone.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(buttonOpenProjectMenuItem) });
			popupMenuNone.Manager = barManager;
			popupMenuNone.Name = "popupMenuNone";
			// 
			// updateNodeStateImageBackgroundworker
			// 
			updateNodeStateImageBackgroundworker.WorkerReportsProgress = true;
			updateNodeStateImageBackgroundworker.WorkerSupportsCancellation = true;
			updateNodeStateImageBackgroundworker.DoWork += updateNodeStateImageBackgroundworker_DoWork;
			updateNodeStateImageBackgroundworker.ProgressChanged += updateNodeStateImageBackgroundworker_ProgressChanged;
			updateNodeStateImageBackgroundworker.RunWorkerCompleted += updateNodeStateImageBackgroundworker_RunWorkerCompleted;
			// 
			// ProjectFilesUserControl
			// 
			Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(treeView);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "ProjectFilesUserControl";
			Size = new Size(201, 434);
			Load += projectFilesUserControlNew_Load;
			((ISupportInitialize)treeView).EndInit();
			((ISupportInitialize)barManager).EndInit();
			((ISupportInitialize)popupMenuProject).EndInit();
			((ISupportInitialize)popupMenuProjectFolder).EndInit();
			((ISupportInitialize)popupMenuFileGroup).EndInit();
			((ISupportInitialize)popupMenuFile).EndInit();
			((ISupportInitialize)popupMenuNone).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Timer guiRefreshTimer;
		private ZetaResourceEditor.UI.Helper.ZetaResourceEditorTreeListControl treeView;
		private BarManager barManager;
		private BarDockControl barDockControlTop;
		private BarDockControl barDockControlBottom;
		private BarDockControl barDockControlLeft;
		private BarDockControl barDockControlRight;
		private PopupMenu popupMenuProject;
		private BarButtonItem buttonMenuProjectEditResourceFiles;
		private BarButtonItem buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject;
		private BarButtonItem buttonMenuProjectAddFileGroupToProject;
		private BarButtonItem buttonMenuProjectRemoveFileGroupFromProject;
		private BarButtonItem buttonMenuProjectEditFileGroupSettings;
		private BarButtonItem buttonMenuProjectAddFilesToFileGroup;
		private BarButtonItem buttonMenuProjectRemoveFileFromFileGroup;
		private BarButtonItem buttonMenuProjectEditProjectSettings;
		private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
		private ToolTipController toolTipController1;
		private BarButtonItem buttonMenuProjectAddProjectFolder;
		private BarButtonItem buttonMenuProjectRemoveProjectFolder;
		private BarButtonItem buttonMenuProjectEditProjectFolder;
		private BarButtonItem buttonMenuProjectMoveUp;
		private BarButtonItem buttonMenuProjectMoveDown;
		private BarButtonItem buttonMenuProjectCreateNewFile;
		private BarButtonItem buttonMenuProjectCreateNewFiles;
		private BarButtonItem buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution;
		private PopupMenu popupMenuProjectFolder;
		private PopupMenu popupMenuFileGroup;
		private PopupMenu popupMenuFile;
		private PopupMenu popupMenuNone;
		private BarButtonItem buttonOpenProjectMenuItem;
		private BackgroundWorker updateNodeStateImageBackgroundworker;
		private BarButtonItem buttonSortProjectFolderChildrenAscendingAZ;
		private BarButtonItem buttonSortChildrenProjectAZ;
		private BarButtonItem buttonMenuProjectFolderAddFileGroupToProject;
		private BarButtonItem buttonMenuProjectAddNewFileGroupToProject;
		private BarButtonItem buttonMenuProjectDeleteExistingLanguage;
		private BarButtonItem buttonMenuProjectDeleteLanguages;
		private BarButtonItem buttonMergeIntoFileGroup;
	}
}
