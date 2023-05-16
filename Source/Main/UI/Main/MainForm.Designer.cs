namespace ZetaResourceEditor.UI.Main
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
			mainFormMainSplitContainer = new SplitContainerControl();
			ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(components);
			barSubRecentFiles = new BarSubItem();
			barSubRecentProjects = new BarSubItem();
			infoButton = new BarButtonItem();
			buttonExit = new BarButtonItem();
			buttonOnlineManual = new BarButtonItem();
			buttonWebsite = new BarButtonItem();
			buttonOpenResourceFiles = new BarButtonItem();
			buttonSaveResourceFiles = new BarButtonItem();
			buttonSaveAllFiles = new BarButtonItem();
			buttonCloseResourceFiles = new BarButtonItem();
			buttonCloseAllDocuments = new BarButtonItem();
			buttonOpenProjectFile = new BarButtonItem();
			buttonSaveProjectFile = new BarButtonItem();
			buttonCloseProject = new BarButtonItem();
			buttonFind = new BarButtonItem();
			buttonFindNext = new BarButtonItem();
			buttonTranslateMissingLanguages = new BarButtonItem();
			buttonAddNewTag = new BarButtonItem();
			buttonDeleteTag = new BarButtonItem();
			buttonRenameTag = new BarButtonItem();
			buttonQuickTranslate = new BarButtonItem();
			buttonRefresh = new BarButtonItem();
			buttonOptions = new BarButtonItem();
			buttonCreateNewProject = new BarButtonItem();
			buttonAutomaticallyAddFileGroupsToProject = new BarButtonItem();
			buttonAddFileGroupToProject = new BarButtonItem();
			buttonRemoveFileGroupFromProject = new BarButtonItem();
			buttonEditFileGroupSettings = new BarButtonItem();
			buttonAddFilesToFileGroup = new BarButtonItem();
			buttonRemoveFileFromGroup = new BarButtonItem();
			buttonEditProjectSettings = new BarButtonItem();
			barMdiChildrenListItem1 = new BarMdiChildrenListItem();
			barMdiChildrenListItem2 = new BarMdiChildrenListItem();
			barListItem1 = new BarListItem();
			buttonUpdateAvailable = new BarButtonItem();
			buttonOpenFileGroupFolder = new BarButtonItem();
			buttonExport = new BarButtonItem();
			buttonImport = new BarButtonItem();
			buttonMoveDown = new BarButtonItem();
			buttonMoveUp = new BarButtonItem();
			buttonShowHideProjectPanel = new BarButtonItem();
			buttonCreateNewFile = new BarButtonItem();
			buttonCreateNewFiles = new BarButtonItem();
			resetLayoutButton = new BarButtonItem();
			buttonAddFromVisualStudio = new BarButtonItem();
			buttonConfigureLanguageColumns = new BarButtonItem();
			buttonReplace = new BarButtonItem();
			ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			updateRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
			clientPanel = new ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl();
			updateAvailableCheckerBackgroundWorker = new BackgroundWorker();
			updateAvailableBlinkTimer = new System.Windows.Forms.Timer(components);
			((ISupportInitialize)mainFormMainSplitContainer).BeginInit();
			((ISupportInitialize)mainFormMainSplitContainer.Panel1).BeginInit();
			((ISupportInitialize)mainFormMainSplitContainer.Panel2).BeginInit();
			mainFormMainSplitContainer.SuspendLayout();
			((ISupportInitialize)ribbon).BeginInit();
			((ISupportInitialize)applicationMenu1).BeginInit();
			((ISupportInitialize)repositoryItemHyperLinkEdit1).BeginInit();
			((ISupportInitialize)clientPanel).BeginInit();
			clientPanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainFormMainSplitContainer
			// 
			mainFormMainSplitContainer.CollapsePanel = SplitCollapsePanel.Panel1;
			mainFormMainSplitContainer.Dock = DockStyle.Fill;
			mainFormMainSplitContainer.Location = new Point(0, 0);
			mainFormMainSplitContainer.Name = "mainFormMainSplitContainer";
			// 
			// mainFormMainSplitContainer.Panel1
			// 
			mainFormMainSplitContainer.Panel1.MinSize = 250;
			mainFormMainSplitContainer.Panel1.Text = "Panel1";
			mainFormMainSplitContainer.Size = new Size(656, 393);
			mainFormMainSplitContainer.SplitterPosition = 200;
			mainFormMainSplitContainer.TabIndex = 0;
			mainFormMainSplitContainer.Text = "splitContainerControl1";
			// 
			// ribbon
			// 
			ribbon.ApplicationButtonDropDownControl = applicationMenu1;
			ribbon.ApplicationButtonText = null;
			ribbon.ExpandCollapseItem.Id = 0;
			ribbon.Items.AddRange(new BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, infoButton, buttonExit, buttonOnlineManual, buttonWebsite, buttonOpenResourceFiles, buttonSaveResourceFiles, buttonSaveAllFiles, buttonCloseResourceFiles, buttonCloseAllDocuments, buttonOpenProjectFile, buttonSaveProjectFile, buttonCloseProject, buttonFind, buttonFindNext, buttonTranslateMissingLanguages, buttonAddNewTag, buttonDeleteTag, buttonRenameTag, buttonQuickTranslate, buttonRefresh, buttonOptions, buttonCreateNewProject, buttonAutomaticallyAddFileGroupsToProject, buttonAddFileGroupToProject, buttonRemoveFileGroupFromProject, buttonEditFileGroupSettings, buttonAddFilesToFileGroup, buttonRemoveFileFromGroup, buttonEditProjectSettings, barMdiChildrenListItem1, barMdiChildrenListItem2, barListItem1, buttonUpdateAvailable, buttonOpenFileGroupFolder, buttonExport, buttonImport, barSubRecentFiles, barSubRecentProjects, buttonMoveDown, buttonMoveUp, buttonShowHideProjectPanel, buttonCreateNewFile, buttonCreateNewFiles, resetLayoutButton, buttonAddFromVisualStudio, buttonConfigureLanguageColumns, buttonReplace });
			ribbon.ItemsVertAlign = VertAlignment.Top;
			ribbon.Location = new Point(0, 0);
			ribbon.MaxItemId = 75;
			ribbon.Name = "ribbon";
			ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage4, ribbonPage3 });
			ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemHyperLinkEdit1 });
			ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
			ribbon.Size = new Size(656, 158);
			// 
			// applicationMenu1
			// 
			applicationMenu1.ItemLinks.Add(barSubRecentFiles);
			applicationMenu1.ItemLinks.Add(barSubRecentProjects);
			applicationMenu1.Name = "applicationMenu1";
			applicationMenu1.Ribbon = ribbon;
			applicationMenu1.BeforePopup += applicationMenu1_BeforePopup;
			// 
			// barSubRecentFiles
			// 
			barSubRecentFiles.Caption = "Recent resource files";
			barSubRecentFiles.Description = "Loads recently opened resource files";
			barSubRecentFiles.Id = 50;
			barSubRecentFiles.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barSubRecentFiles.ImageOptions.SvgImage");
			barSubRecentFiles.Name = "barSubRecentFiles";
			// 
			// barSubRecentProjects
			// 
			barSubRecentProjects.Caption = "Recent projects";
			barSubRecentProjects.Description = "Loads a recently opened project";
			barSubRecentProjects.Id = 52;
			barSubRecentProjects.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barSubRecentProjects.ImageOptions.SvgImage");
			barSubRecentProjects.Name = "barSubRecentProjects";
			// 
			// infoButton
			// 
			infoButton.Caption = "Info";
			infoButton.Description = "Displays application and version information";
			infoButton.Id = 0;
			infoButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("infoButton.ImageOptions.SvgImage");
			infoButton.Name = "infoButton";
			infoButton.ItemClick += aboutZetaResxEditorToolStripMenuItem_Click;
			// 
			// buttonExit
			// 
			buttonExit.Caption = "Exit";
			buttonExit.Description = "Exits the application";
			buttonExit.Id = 1;
			buttonExit.Name = "buttonExit";
			buttonExit.ItemClick += buttonExit_ItemClick;
			// 
			// buttonOnlineManual
			// 
			buttonOnlineManual.Caption = "Online manual";
			buttonOnlineManual.Hint = "Shows the online manual";
			buttonOnlineManual.Id = 2;
			buttonOnlineManual.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonOnlineManual.ImageOptions.SvgImage");
			buttonOnlineManual.ItemShortcut = new BarShortcut(Keys.F1);
			buttonOnlineManual.Name = "buttonOnlineManual";
			buttonOnlineManual.ItemClick += onlineManualToolStripMenuItem_Click;
			// 
			// buttonWebsite
			// 
			buttonWebsite.Caption = "Website";
			buttonWebsite.Id = 3;
			buttonWebsite.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonWebsite.ImageOptions.SvgImage");
			buttonWebsite.Name = "buttonWebsite";
			buttonWebsite.ItemClick += visitVendorsWebsiteToolStripMenuItem_Click;
			// 
			// buttonOpenResourceFiles
			// 
			buttonOpenResourceFiles.Caption = "Open resource files";
			buttonOpenResourceFiles.Hint = "Opens existing resource files";
			buttonOpenResourceFiles.Id = 5;
			buttonOpenResourceFiles.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonOpenResourceFiles.ImageOptions.SvgImage");
			buttonOpenResourceFiles.ItemShortcut = new BarShortcut(Keys.Control | Keys.O);
			buttonOpenResourceFiles.Name = "buttonOpenResourceFiles";
			buttonOpenResourceFiles.ItemClick += openToolStripMenuItem_Click;
			// 
			// buttonSaveResourceFiles
			// 
			buttonSaveResourceFiles.Caption = "Save files";
			buttonSaveResourceFiles.Hint = "Saves the currently opened resource file group";
			buttonSaveResourceFiles.Id = 6;
			buttonSaveResourceFiles.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveResourceFiles.ImageOptions.SvgImage");
			buttonSaveResourceFiles.ItemShortcut = new BarShortcut(Keys.Control | Keys.S);
			buttonSaveResourceFiles.Name = "buttonSaveResourceFiles";
			buttonSaveResourceFiles.ItemClick += saveToolStripMenuItem_Click;
			// 
			// buttonSaveAllFiles
			// 
			buttonSaveAllFiles.Caption = "Save all files";
			buttonSaveAllFiles.Hint = "Saves all modified resource files and the project itself";
			buttonSaveAllFiles.Id = 7;
			buttonSaveAllFiles.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveAllFiles.ImageOptions.SvgImage");
			buttonSaveAllFiles.ItemShortcut = new BarShortcut(Keys.Control | Keys.Shift | Keys.S);
			buttonSaveAllFiles.Name = "buttonSaveAllFiles";
			buttonSaveAllFiles.ItemClick += saveAllToolStripButton_Click;
			// 
			// buttonCloseResourceFiles
			// 
			buttonCloseResourceFiles.Caption = "Close resource files";
			buttonCloseResourceFiles.Hint = "Close the currently open resource file data grid";
			buttonCloseResourceFiles.Id = 8;
			buttonCloseResourceFiles.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonCloseResourceFiles.ImageOptions.SvgImage");
			buttonCloseResourceFiles.ItemShortcut = new BarShortcut(Keys.Control | Keys.F4);
			buttonCloseResourceFiles.Name = "buttonCloseResourceFiles";
			buttonCloseResourceFiles.ItemClick += closeToolStripMenuItem_Click;
			// 
			// buttonCloseAllDocuments
			// 
			buttonCloseAllDocuments.Caption = "Close all documents";
			buttonCloseAllDocuments.Hint = "Closes all open resource file group editor windows";
			buttonCloseAllDocuments.Id = 9;
			buttonCloseAllDocuments.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonCloseAllDocuments.ImageOptions.SvgImage");
			buttonCloseAllDocuments.ItemShortcut = new BarShortcut(Keys.Control | Keys.Shift | Keys.W);
			buttonCloseAllDocuments.Name = "buttonCloseAllDocuments";
			buttonCloseAllDocuments.ItemClick += closeAllDocumentsToolStripMenuItem_Click;
			// 
			// buttonOpenProjectFile
			// 
			buttonOpenProjectFile.Caption = "Open project file";
			buttonOpenProjectFile.Hint = "Opens an existing project file";
			buttonOpenProjectFile.Id = 10;
			buttonOpenProjectFile.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonOpenProjectFile.ImageOptions.SvgImage");
			buttonOpenProjectFile.ItemShortcut = new BarShortcut(Keys.Control | Keys.Shift | Keys.O);
			buttonOpenProjectFile.Name = "buttonOpenProjectFile";
			buttonOpenProjectFile.ItemClick += openProjectFileToolStripMenuItem_Click;
			// 
			// buttonSaveProjectFile
			// 
			buttonSaveProjectFile.Caption = "Save project file";
			buttonSaveProjectFile.Id = 11;
			buttonSaveProjectFile.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonSaveProjectFile.ImageOptions.SvgImage");
			buttonSaveProjectFile.Name = "buttonSaveProjectFile";
			buttonSaveProjectFile.ItemClick += saveProjectFileToolStripMenuItem_Click;
			// 
			// buttonCloseProject
			// 
			buttonCloseProject.Caption = "Close project";
			buttonCloseProject.Id = 12;
			buttonCloseProject.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonCloseProject.ImageOptions.SvgImage");
			buttonCloseProject.Name = "buttonCloseProject";
			buttonCloseProject.ItemClick += closeProjectFileToolStripMenuItem_Click;
			// 
			// buttonFind
			// 
			buttonFind.Caption = "Find";
			buttonFind.Hint = "Searches for text in the currently opened resource file group data grid";
			buttonFind.Id = 13;
			buttonFind.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonFind.ImageOptions.SvgImage");
			buttonFind.ItemShortcut = new BarShortcut(Keys.Control | Keys.F);
			buttonFind.Name = "buttonFind";
			buttonFind.ItemClick += findToolStripMenuItem_Click;
			// 
			// buttonFindNext
			// 
			buttonFindNext.Caption = "Find next";
			buttonFindNext.Hint = "Continues a previously started search";
			buttonFindNext.Id = 14;
			buttonFindNext.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonFindNext.ImageOptions.SvgImage");
			buttonFindNext.ItemShortcut = new BarShortcut(Keys.F3);
			buttonFindNext.Name = "buttonFindNext";
			buttonFindNext.ItemClick += findNextToolStripMenuItem_Click;
			// 
			// buttonTranslateMissingLanguages
			// 
			buttonTranslateMissingLanguages.Caption = "Translate missing languages";
			buttonTranslateMissingLanguages.Id = 15;
			buttonTranslateMissingLanguages.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonTranslateMissingLanguages.ImageOptions.SvgImage");
			buttonTranslateMissingLanguages.Name = "buttonTranslateMissingLanguages";
			buttonTranslateMissingLanguages.ItemClick += translateMissingLanguagesToolStripMenuItem_Click;
			// 
			// buttonAddNewTag
			// 
			buttonAddNewTag.Caption = "Add new tag";
			buttonAddNewTag.Hint = "Adds a new tag to the currently open resource file group data grid";
			buttonAddNewTag.Id = 18;
			buttonAddNewTag.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonAddNewTag.ImageOptions.SvgImage");
			buttonAddNewTag.ItemShortcut = new BarShortcut(Keys.Control | Keys.N);
			buttonAddNewTag.Name = "buttonAddNewTag";
			buttonAddNewTag.ItemClick += addTagToolStripMenuItem_Click;
			// 
			// buttonDeleteTag
			// 
			buttonDeleteTag.Caption = "Delete tag";
			buttonDeleteTag.Hint = "Deletes the currently selected row";
			buttonDeleteTag.Id = 19;
			buttonDeleteTag.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonDeleteTag.ImageOptions.SvgImage");
			buttonDeleteTag.ItemShortcut = new BarShortcut(Keys.Control | Keys.Delete);
			buttonDeleteTag.Name = "buttonDeleteTag";
			buttonDeleteTag.ItemClick += deleteTagToolStripMenuItem_Click;
			// 
			// buttonRenameTag
			// 
			buttonRenameTag.Caption = "Rename tag";
			buttonRenameTag.Hint = "Renames the currently selected tag";
			buttonRenameTag.Id = 20;
			buttonRenameTag.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonRenameTag.ImageOptions.SvgImage");
			buttonRenameTag.ItemShortcut = new BarShortcut(Keys.Control | Keys.R);
			buttonRenameTag.Name = "buttonRenameTag";
			buttonRenameTag.ItemClick += renameTagToolStripMenuItem_Click;
			// 
			// buttonQuickTranslate
			// 
			buttonQuickTranslate.Caption = "Quick translate";
			buttonQuickTranslate.Hint = "Opens the Quick translate window";
			buttonQuickTranslate.Id = 21;
			buttonQuickTranslate.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonQuickTranslate.ImageOptions.SvgImage");
			buttonQuickTranslate.ItemShortcut = new BarShortcut(Keys.F9);
			buttonQuickTranslate.Name = "buttonQuickTranslate";
			buttonQuickTranslate.ItemClick += quickTranslationToolStripMenuItem_Click;
			// 
			// buttonRefresh
			// 
			buttonRefresh.Caption = "Refresh file list";
			buttonRefresh.Hint = "Refreshes the project file list";
			buttonRefresh.Id = 22;
			buttonRefresh.ImageOptions.LargeImageIndex = 1;
			buttonRefresh.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonRefresh.ImageOptions.SvgImage");
			buttonRefresh.ItemShortcut = new BarShortcut(Keys.F5);
			buttonRefresh.Name = "buttonRefresh";
			buttonRefresh.ItemClick += refreshProjectFilesListToolStripMenuItem_Click;
			// 
			// buttonOptions
			// 
			buttonOptions.Caption = "Options";
			buttonOptions.Id = 23;
			buttonOptions.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonOptions.ImageOptions.SvgImage");
			buttonOptions.ItemShortcut = new BarShortcut(Keys.Alt | Keys.F7);
			buttonOptions.Name = "buttonOptions";
			buttonOptions.ItemClick += optionsToolStripMenuItem1_Click;
			// 
			// buttonCreateNewProject
			// 
			buttonCreateNewProject.Caption = "Create new project";
			buttonCreateNewProject.Hint = "Creates a new project";
			buttonCreateNewProject.Id = 24;
			buttonCreateNewProject.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonCreateNewProject.ImageOptions.SvgImage");
			buttonCreateNewProject.ItemShortcut = new BarShortcut(Keys.Control | Keys.Shift | Keys.N);
			buttonCreateNewProject.Name = "buttonCreateNewProject";
			buttonCreateNewProject.ItemClick += createNewProjectToolStripMenuItem_Click;
			// 
			// buttonAutomaticallyAddFileGroupsToProject
			// 
			buttonAutomaticallyAddFileGroupsToProject.Caption = "Automatically add multiple files";
			buttonAutomaticallyAddFileGroupsToProject.Id = 25;
			buttonAutomaticallyAddFileGroupsToProject.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonAutomaticallyAddFileGroupsToProject.ImageOptions.SvgImage");
			buttonAutomaticallyAddFileGroupsToProject.Name = "buttonAutomaticallyAddFileGroupsToProject";
			buttonAutomaticallyAddFileGroupsToProject.ItemClick += automaticallyAddMultipleFileGroupsToolStripMenuItem_Click;
			// 
			// buttonAddFileGroupToProject
			// 
			buttonAddFileGroupToProject.Caption = "Add file group to project";
			buttonAddFileGroupToProject.Id = 26;
			buttonAddFileGroupToProject.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonAddFileGroupToProject.ImageOptions.SvgImage");
			buttonAddFileGroupToProject.Name = "buttonAddFileGroupToProject";
			buttonAddFileGroupToProject.ItemClick += addResourceFilesToProjectToolStripMenuItem_Click;
			// 
			// buttonRemoveFileGroupFromProject
			// 
			buttonRemoveFileGroupFromProject.Caption = "Remove file group from project";
			buttonRemoveFileGroupFromProject.Id = 27;
			buttonRemoveFileGroupFromProject.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonRemoveFileGroupFromProject.ImageOptions.SvgImage");
			buttonRemoveFileGroupFromProject.Name = "buttonRemoveFileGroupFromProject";
			buttonRemoveFileGroupFromProject.ItemClick += removeResourceFilesFromProjectToolStripMenuItem_Click;
			// 
			// buttonEditFileGroupSettings
			// 
			buttonEditFileGroupSettings.Caption = "Edit file group settings";
			buttonEditFileGroupSettings.Id = 28;
			buttonEditFileGroupSettings.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonEditFileGroupSettings.ImageOptions.SvgImage");
			buttonEditFileGroupSettings.Name = "buttonEditFileGroupSettings";
			buttonEditFileGroupSettings.ItemClick += editResourceFilesSettingsToolStripMenuItem_Click;
			// 
			// buttonAddFilesToFileGroup
			// 
			buttonAddFilesToFileGroup.Caption = "Add files to file group";
			buttonAddFilesToFileGroup.Id = 29;
			buttonAddFilesToFileGroup.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonAddFilesToFileGroup.ImageOptions.SvgImage");
			buttonAddFilesToFileGroup.Name = "buttonAddFilesToFileGroup";
			buttonAddFilesToFileGroup.ItemClick += addFilesToFileGroupToolStripMenuItem_Click;
			// 
			// buttonRemoveFileFromGroup
			// 
			buttonRemoveFileFromGroup.Caption = "Remove file from group";
			buttonRemoveFileFromGroup.Id = 30;
			buttonRemoveFileFromGroup.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonRemoveFileFromGroup.ImageOptions.SvgImage");
			buttonRemoveFileFromGroup.Name = "buttonRemoveFileFromGroup";
			buttonRemoveFileFromGroup.ItemClick += removeFileFromGroupToolStripMenuItem_Click;
			// 
			// buttonEditProjectSettings
			// 
			buttonEditProjectSettings.Caption = "Edit project settings";
			buttonEditProjectSettings.Id = 31;
			buttonEditProjectSettings.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonEditProjectSettings.ImageOptions.SvgImage");
			buttonEditProjectSettings.Name = "buttonEditProjectSettings";
			buttonEditProjectSettings.ItemClick += editProjectSettingsToolStripMenuItem_Click;
			// 
			// barMdiChildrenListItem1
			// 
			barMdiChildrenListItem1.Caption = "Recent projects";
			barMdiChildrenListItem1.Id = 32;
			barMdiChildrenListItem1.ImageOptions.LargeImageIndex = 35;
			barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
			// 
			// barMdiChildrenListItem2
			// 
			barMdiChildrenListItem2.Caption = "Recent files";
			barMdiChildrenListItem2.Id = 33;
			barMdiChildrenListItem2.ImageOptions.LargeImageIndex = 36;
			barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
			// 
			// barListItem1
			// 
			barListItem1.Caption = "barListItem1";
			barListItem1.Id = 34;
			barListItem1.Name = "barListItem1";
			// 
			// buttonUpdateAvailable
			// 
			buttonUpdateAvailable.Caption = "An update is available!";
			buttonUpdateAvailable.Id = 37;
			buttonUpdateAvailable.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonUpdateAvailable.ImageOptions.SvgImage");
			buttonUpdateAvailable.Name = "buttonUpdateAvailable";
			buttonUpdateAvailable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
			buttonUpdateAvailable.ItemClick += buttonUpdateAvailable_ItemClick;
			// 
			// buttonOpenFileGroupFolder
			// 
			buttonOpenFileGroupFolder.Caption = "Open folder";
			buttonOpenFileGroupFolder.Id = 40;
			buttonOpenFileGroupFolder.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonOpenFileGroupFolder.ImageOptions.SvgImage");
			buttonOpenFileGroupFolder.Name = "buttonOpenFileGroupFolder";
			buttonOpenFileGroupFolder.ItemClick += openFolderOfCurrentResourceFileToolStripMenuItem_Click;
			// 
			// buttonExport
			// 
			buttonExport.Caption = "Export to Microsoft Excel";
			buttonExport.Id = 48;
			buttonExport.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonExport.ImageOptions.SvgImage");
			buttonExport.Name = "buttonExport";
			buttonExport.ItemClick += buttonExport_ItemClick;
			// 
			// buttonImport
			// 
			buttonImport.Caption = "Import from Microsoft Excel";
			buttonImport.Id = 49;
			buttonImport.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonImport.ImageOptions.SvgImage");
			buttonImport.Name = "buttonImport";
			buttonImport.ItemClick += buttonImport_ItemClick;
			// 
			// buttonMoveDown
			// 
			buttonMoveDown.Caption = "Move down";
			buttonMoveDown.Hint = "Move the selected item in the project files tree down by one";
			buttonMoveDown.Id = 53;
			buttonMoveDown.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonMoveDown.ImageOptions.SvgImage");
			buttonMoveDown.ItemShortcut = new BarShortcut(Keys.Control | Keys.Down);
			buttonMoveDown.Name = "buttonMoveDown";
			buttonMoveDown.ItemClick += buttonMoveDown_ItemClick;
			// 
			// buttonMoveUp
			// 
			buttonMoveUp.Caption = "Move up";
			buttonMoveUp.Hint = "Move the selected item in the project files tree up by one";
			buttonMoveUp.Id = 54;
			buttonMoveUp.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonMoveUp.ImageOptions.SvgImage");
			buttonMoveUp.ItemShortcut = new BarShortcut(Keys.Control | Keys.Up);
			buttonMoveUp.Name = "buttonMoveUp";
			buttonMoveUp.ItemClick += buttonMoveUp_ItemClick;
			// 
			// buttonShowHideProjectPanel
			// 
			buttonShowHideProjectPanel.ButtonStyle = BarButtonStyle.Check;
			buttonShowHideProjectPanel.Caption = "Show project panel";
			buttonShowHideProjectPanel.Id = 55;
			buttonShowHideProjectPanel.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonShowHideProjectPanel.ImageOptions.SvgImage");
			buttonShowHideProjectPanel.Name = "buttonShowHideProjectPanel";
			buttonShowHideProjectPanel.ItemClick += buttonShowHideProjectPanel_ItemClick;
			// 
			// buttonCreateNewFile
			// 
			buttonCreateNewFile.Caption = "Create new file for language";
			buttonCreateNewFile.Id = 56;
			buttonCreateNewFile.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonCreateNewFile.ImageOptions.SvgImage");
			buttonCreateNewFile.Name = "buttonCreateNewFile";
			buttonCreateNewFile.ItemClick += buttonCreateNewFile_ItemClick;
			// 
			// buttonCreateNewFiles
			// 
			buttonCreateNewFiles.Caption = "Create new files for language";
			buttonCreateNewFiles.Id = 57;
			buttonCreateNewFiles.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonCreateNewFiles.ImageOptions.SvgImage");
			buttonCreateNewFiles.Name = "buttonCreateNewFiles";
			buttonCreateNewFiles.ItemClick += buttonCreateNewFiles_ItemClick;
			// 
			// resetLayoutButton
			// 
			resetLayoutButton.Caption = "Reset layout";
			resetLayoutButton.Id = 59;
			resetLayoutButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("resetLayoutButton.ImageOptions.SvgImage");
			resetLayoutButton.Name = "resetLayoutButton";
			resetLayoutButton.ItemClick += resetLayoutButton_ItemClick;
			// 
			// buttonAddFromVisualStudio
			// 
			buttonAddFromVisualStudio.Caption = "Automatically add from Visual Studio solution";
			buttonAddFromVisualStudio.Id = 60;
			buttonAddFromVisualStudio.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonAddFromVisualStudio.ImageOptions.SvgImage");
			buttonAddFromVisualStudio.Name = "buttonAddFromVisualStudio";
			buttonAddFromVisualStudio.ItemClick += buttonAddFromVisualStudio_ItemClick;
			// 
			// buttonConfigureLanguageColumns
			// 
			buttonConfigureLanguageColumns.Caption = "Configure language columns";
			buttonConfigureLanguageColumns.Id = 63;
			buttonConfigureLanguageColumns.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonConfigureLanguageColumns.ImageOptions.SvgImage");
			buttonConfigureLanguageColumns.Name = "buttonConfigureLanguageColumns";
			buttonConfigureLanguageColumns.ItemClick += buttonConfigureLanguageColumns_ItemClick;
			// 
			// buttonReplace
			// 
			buttonReplace.Caption = "Replace";
			buttonReplace.Id = 68;
			buttonReplace.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("buttonReplace.ImageOptions.SvgImage");
			buttonReplace.ItemShortcut = new BarShortcut(Keys.Control | Keys.H);
			buttonReplace.Name = "buttonReplace";
			buttonReplace.ItemClick += barButtonItem1_ItemClick;
			// 
			// ribbonPage1
			// 
			ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { updateRibbonPageGroup, ribbonPageGroup2, ribbonPageGroup10, ribbonPageGroup1, ribbonPageGroup5, ribbonPageGroup3 });
			ribbonPage1.Name = "ribbonPage1";
			ribbonPage1.Text = "Start";
			// 
			// updateRibbonPageGroup
			// 
			updateRibbonPageGroup.AllowTextClipping = false;
			updateRibbonPageGroup.CaptionButtonVisible = DefaultBoolean.False;
			updateRibbonPageGroup.ItemLinks.Add(buttonUpdateAvailable);
			updateRibbonPageGroup.Name = "updateRibbonPageGroup";
			updateRibbonPageGroup.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
			updateRibbonPageGroup.Text = "Update";
			updateRibbonPageGroup.Visible = false;
			// 
			// ribbonPageGroup2
			// 
			ribbonPageGroup2.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup2.ItemLinks.Add(buttonOpenProjectFile);
			ribbonPageGroup2.ItemLinks.Add(buttonCreateNewProject);
			ribbonPageGroup2.ItemLinks.Add(buttonSaveProjectFile);
			ribbonPageGroup2.ItemLinks.Add(buttonCloseProject);
			ribbonPageGroup2.ItemLinks.Add(buttonEditProjectSettings);
			ribbonPageGroup2.ItemLinks.Add(buttonShowHideProjectPanel);
			ribbonPageGroup2.Name = "ribbonPageGroup2";
			ribbonPageGroup2.Text = "Project files";
			// 
			// ribbonPageGroup10
			// 
			ribbonPageGroup10.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup10.ItemLinks.Add(buttonExport);
			ribbonPageGroup10.ItemLinks.Add(buttonImport);
			ribbonPageGroup10.Name = "ribbonPageGroup10";
			ribbonPageGroup10.Text = "Import/export";
			// 
			// ribbonPageGroup1
			// 
			ribbonPageGroup1.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup1.ItemLinks.Add(buttonSaveResourceFiles);
			ribbonPageGroup1.ItemLinks.Add(buttonSaveAllFiles);
			ribbonPageGroup1.ItemLinks.Add(buttonOpenResourceFiles);
			ribbonPageGroup1.ItemLinks.Add(buttonCloseResourceFiles);
			ribbonPageGroup1.ItemLinks.Add(buttonCloseAllDocuments);
			ribbonPageGroup1.Name = "ribbonPageGroup1";
			ribbonPageGroup1.Text = "Resource files";
			// 
			// ribbonPageGroup5
			// 
			ribbonPageGroup5.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup5.ItemLinks.Add(buttonRefresh);
			ribbonPageGroup5.ItemLinks.Add(buttonMoveUp);
			ribbonPageGroup5.ItemLinks.Add(buttonMoveDown);
			ribbonPageGroup5.ItemLinks.Add(resetLayoutButton);
			ribbonPageGroup5.ItemLinks.Add(buttonConfigureLanguageColumns);
			ribbonPageGroup5.Name = "ribbonPageGroup5";
			ribbonPageGroup5.Text = "View";
			// 
			// ribbonPageGroup3
			// 
			ribbonPageGroup3.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup3.ItemLinks.Add(buttonQuickTranslate);
			ribbonPageGroup3.ItemLinks.Add(buttonTranslateMissingLanguages);
			ribbonPageGroup3.ItemLinks.Add(buttonFind);
			ribbonPageGroup3.ItemLinks.Add(buttonFindNext);
			ribbonPageGroup3.ItemLinks.Add(buttonReplace);
			ribbonPageGroup3.Name = "ribbonPageGroup3";
			ribbonPageGroup3.Text = "Edit";
			// 
			// ribbonPage4
			// 
			ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup8, ribbonPageGroup9, ribbonPageGroup4 });
			ribbonPage4.Name = "ribbonPage4";
			ribbonPage4.Text = "File groups and tags";
			// 
			// ribbonPageGroup8
			// 
			ribbonPageGroup8.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup8.ItemLinks.Add(buttonAutomaticallyAddFileGroupsToProject);
			ribbonPageGroup8.ItemLinks.Add(buttonAddFromVisualStudio);
			ribbonPageGroup8.ItemLinks.Add(buttonAddFileGroupToProject);
			ribbonPageGroup8.ItemLinks.Add(buttonEditFileGroupSettings);
			ribbonPageGroup8.ItemLinks.Add(buttonRemoveFileGroupFromProject);
			ribbonPageGroup8.ItemLinks.Add(buttonOpenFileGroupFolder);
			ribbonPageGroup8.Name = "ribbonPageGroup8";
			ribbonPageGroup8.Text = "File groups";
			// 
			// ribbonPageGroup9
			// 
			ribbonPageGroup9.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup9.ItemLinks.Add(buttonAddFilesToFileGroup);
			ribbonPageGroup9.ItemLinks.Add(buttonCreateNewFile);
			ribbonPageGroup9.ItemLinks.Add(buttonRemoveFileFromGroup);
			ribbonPageGroup9.ItemLinks.Add(buttonCreateNewFiles);
			ribbonPageGroup9.Name = "ribbonPageGroup9";
			ribbonPageGroup9.Text = "Files";
			// 
			// ribbonPageGroup4
			// 
			ribbonPageGroup4.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup4.ItemLinks.Add(buttonAddNewTag);
			ribbonPageGroup4.ItemLinks.Add(buttonRenameTag);
			ribbonPageGroup4.ItemLinks.Add(buttonDeleteTag);
			ribbonPageGroup4.Name = "ribbonPageGroup4";
			ribbonPageGroup4.Text = "Tags";
			// 
			// ribbonPage3
			// 
			ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup7, ribbonPageGroup6, ribbonPageGroup11 });
			ribbonPage3.Name = "ribbonPage3";
			ribbonPage3.Text = "Extras";
			// 
			// ribbonPageGroup7
			// 
			ribbonPageGroup7.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup7.ItemLinks.Add(buttonOptions);
			ribbonPageGroup7.Name = "ribbonPageGroup7";
			ribbonPageGroup7.Text = "Extras";
			// 
			// ribbonPageGroup6
			// 
			ribbonPageGroup6.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup6.ItemLinks.Add(buttonOnlineManual);
			ribbonPageGroup6.ItemLinks.Add(buttonWebsite);
			ribbonPageGroup6.Name = "ribbonPageGroup6";
			ribbonPageGroup6.Text = "Help";
			// 
			// ribbonPageGroup11
			// 
			ribbonPageGroup11.CaptionButtonVisible = DefaultBoolean.False;
			ribbonPageGroup11.ItemLinks.Add(infoButton);
			ribbonPageGroup11.Name = "ribbonPageGroup11";
			ribbonPageGroup11.Text = "Info";
			// 
			// repositoryItemHyperLinkEdit1
			// 
			repositoryItemHyperLinkEdit1.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			repositoryItemHyperLinkEdit1.Appearance.Options.UseFont = true;
			repositoryItemHyperLinkEdit1.AutoHeight = false;
			repositoryItemHyperLinkEdit1.BorderStyle = BorderStyles.NoBorder;
			repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
			repositoryItemHyperLinkEdit1.SingleClick = true;
			repositoryItemHyperLinkEdit1.Tag = "http://www.zeta-producer.com/producer.html?from=zre";
			// 
			// clientPanel
			// 
			clientPanel.BorderStyle = BorderStyles.NoBorder;
			clientPanel.Controls.Add(mainFormMainSplitContainer);
			clientPanel.Dock = DockStyle.Fill;
			clientPanel.Location = new Point(0, 158);
			clientPanel.Name = "clientPanel";
			clientPanel.Size = new Size(656, 393);
			clientPanel.TabIndex = 2;
			// 
			// updateAvailableCheckerBackgroundWorker
			// 
			updateAvailableCheckerBackgroundWorker.DoWork += updateAvailableCheckerBackgroundWorker_DoWork;
			updateAvailableCheckerBackgroundWorker.RunWorkerCompleted += updateAvailableCheckerBackgroundWorker_RunWorkerCompleted;
			// 
			// updateAvailableBlinkTimer
			// 
			updateAvailableBlinkTimer.Interval = 500;
			updateAvailableBlinkTimer.Tick += updateAvailableBlinkTimer_Tick;
			// 
			// MainForm
			// 
			Appearance.Options.UseFont = true;
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(656, 551);
			Controls.Add(clientPanel);
			Controls.Add(ribbon);
			IconOptions.Icon = (Icon)resources.GetObject("MainForm.IconOptions.Icon");
			Name = "MainForm";
			Ribbon = ribbon;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Zeta Resource Editor";
			FormClosing += mainForm_FormClosing;
			Load += mainForm_Load;
			Shown += mainForm_Shown;
			DragDrop += mainForm_DragDrop;
			DragEnter += mainForm_DragEnter;
			((ISupportInitialize)mainFormMainSplitContainer.Panel1).EndInit();
			((ISupportInitialize)mainFormMainSplitContainer.Panel2).EndInit();
			((ISupportInitialize)mainFormMainSplitContainer).EndInit();
			mainFormMainSplitContainer.ResumeLayout(false);
			((ISupportInitialize)ribbon).EndInit();
			((ISupportInitialize)applicationMenu1).EndInit();
			((ISupportInitialize)repositoryItemHyperLinkEdit1).EndInit();
			((ISupportInitialize)clientPanel).EndInit();
			clientPanel.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private ExtendedControlsLibrary.Skinning.CustomPanel.MyPanelControl clientPanel;
		private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
		private BarButtonItem infoButton;
		private BarButtonItem buttonExit;
		private BackgroundWorker updateAvailableCheckerBackgroundWorker;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
		private BarButtonItem buttonOnlineManual;
		private BarButtonItem buttonWebsite;
		private BarButtonItem buttonOpenResourceFiles;
		private BarButtonItem buttonSaveResourceFiles;
		private BarButtonItem buttonSaveAllFiles;
		private BarButtonItem buttonCloseResourceFiles;
		private BarButtonItem buttonCloseAllDocuments;
		private BarButtonItem buttonOpenProjectFile;
		private BarButtonItem buttonSaveProjectFile;
		private BarButtonItem buttonCloseProject;
		private BarButtonItem buttonFind;
		private BarButtonItem buttonFindNext;
		private BarButtonItem buttonTranslateMissingLanguages;
		private BarButtonItem buttonAddNewTag;
		private BarButtonItem buttonDeleteTag;
		private BarButtonItem buttonRenameTag;
		private BarButtonItem buttonQuickTranslate;
		private BarButtonItem buttonRefresh;
		private BarButtonItem buttonOptions;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
		private BarButtonItem buttonCreateNewProject;
		private BarButtonItem buttonAutomaticallyAddFileGroupsToProject;
		private BarButtonItem buttonAddFileGroupToProject;
		private BarButtonItem buttonRemoveFileGroupFromProject;
		private BarButtonItem buttonEditFileGroupSettings;
		private BarButtonItem buttonAddFilesToFileGroup;
		private BarButtonItem buttonRemoveFileFromGroup;
		private BarButtonItem buttonEditProjectSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
		private BarMdiChildrenListItem barMdiChildrenListItem1;
		private BarMdiChildrenListItem barMdiChildrenListItem2;
		private BarListItem barListItem1;
		private SplitContainerControl mainFormMainSplitContainer;
		private BarButtonItem buttonUpdateAvailable;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup updateRibbonPageGroup;
		private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
		private BarButtonItem buttonOpenFileGroupFolder;
		private BarButtonItem buttonExport;
		private BarButtonItem buttonImport;
		private BarSubItem barSubRecentFiles;
		private BarSubItem barSubRecentProjects;
		private BarButtonItem buttonMoveDown;
		private BarButtonItem buttonMoveUp;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private BarButtonItem buttonShowHideProjectPanel;
		private BarButtonItem buttonCreateNewFile;
		private BarButtonItem buttonCreateNewFiles;
		private BarButtonItem resetLayoutButton;
		private BarButtonItem buttonAddFromVisualStudio;
		private BarButtonItem buttonConfigureLanguageColumns;
		private BarButtonItem buttonReplace;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
		private System.Windows.Forms.Timer updateAvailableBlinkTimer;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
	}
}