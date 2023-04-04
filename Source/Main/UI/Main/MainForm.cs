namespace ZetaResourceEditor.UI.Main;

using Code;
using ExportImportExcel;
using ExtendedControlsLibrary;
using ExtendedControlsLibrary.General.Base;
using Helper.Base;
using LeftTree;
using Properties;
using RightContent;
using Runtime.Events;
using RuntimeBusinessLogic.BL;
using RuntimeBusinessLogic.DL;
using RuntimeBusinessLogic.FileGroups;
using RuntimeBusinessLogic.Projects;
using RuntimeBusinessLogic.WebServices;
using RuntimeUserInterface.Shell;
using ServiceReference1;
using System.IO;
using Tools;
using Translation;
using Zeta.VoyagerLibrary.Core.Common;
using Zeta.VoyagerLibrary.Core.Common.IO;
using Zeta.VoyagerLibrary.Core.Tools.Storage;
using Zeta.VoyagerLibrary.Core.WinForms.Common;
using Zeta.VoyagerLibrary.Core.WinForms.Persistance;

public partial class MainForm :
    RibbonFormBase
{
    public void NotifyFileGroupStateChanged(IGridEditableData gridEditableData)
    {
        FileGroupStateChanged.Raise(this, new FileGroupStateChangedEventArgs(gridEditableData));
    }

    private FastSmartWeakEvent<EventHandler<FileGroupStateChangedEventArgs>>? _fileGroupStateChanged;
    private UpdateCheckInfo2? _updateCheckInfo;

    public FastSmartWeakEvent<EventHandler<FileGroupStateChangedEventArgs>> FileGroupStateChanged
    {
        get
        {
            // ReSharper disable ConvertIfStatementToNullCoalescingExpression
            if (_fileGroupStateChanged == null)
            // ReSharper restore ConvertIfStatementToNullCoalescingExpression
            {
                _fileGroupStateChanged = new();
            }

            return _fileGroupStateChanged;
        }
    }

    #region Properties

    // ------------------------------------------------------------------

    /// <summary>
    /// Current instance.
    /// </summary>
    /// <value>The current instance.</value>
    public static MainForm? Current { get; private set; }

    public static IPersistentPairStorage UserStorageIntelligent =>
        Current?.ProjectFilesControl?.Project?.DynamicSettingsUser ?? PersistanceHelper.Storage;

    // Muss public bleiben für Forms-Designer.
    public ProjectFilesUserControl? ProjectFilesControl { get; }

    // Muss public bleiben für Forms-Designer.
    public GroupFilesUserControl? GroupFilesControl { get; }

    // ------------------------------------------------------------------

    #endregion

    public MainForm()
    {
        InitializeComponent();
        Current = this;

        if (!DesignModeHelper.IsDesignMode)
        {
	        base.MinimumSize = new(400, 400);

            ProjectFilesControl = new();
            GroupFilesControl = new();

            mainFormMainSplitContainer.Panel1.Controls.Add(ProjectFilesControl);
            mainFormMainSplitContainer.Panel2.Controls.Add(GroupFilesControl);

            // 
            // projectFilesUserControl
            // 
            ProjectFilesControl.Appearance.Font = new("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            ProjectFilesControl.Appearance.Options.UseFont = true;
            ProjectFilesControl.Dock = DockStyle.Fill;
            ProjectFilesControl.Location = new(0, 0);
            ProjectFilesControl.Name = "ProjectFilesControl";
            ProjectFilesControl.Size = new(250, 408);
            ProjectFilesControl.TabIndex = 0;
            // 
            // groupFilesControl
            // 
            GroupFilesControl.Appearance.Font = new("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            GroupFilesControl.Appearance.Options.UseFont = true;
            GroupFilesControl.Dock = DockStyle.Fill;
            GroupFilesControl.Location = new(0, 0);
            GroupFilesControl.Name = "GroupFilesControl";
            GroupFilesControl.Size = new(430, 408);
            GroupFilesControl.TabIndex = 0;
        }
    }

    private void saveToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        SaveWithDialog(SaveOptions.None);
        UpdateUI();
    }

    internal void SaveWithDialog(SaveOptions saveOptions)
    {
        GroupFilesControl.CurrentFileGroupControl?.DoSaveFiles(saveOptions);
    }

    private void openToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        GroupFilesControl.OpenWithDialog();
        UpdateUI();
    }

    #region MRU handling, both for files and projects.

    // ------------------------------------------------------------------

    /*
            private const int MruMaxCharSize = 250;
    */
    private const int MruMaxMruItems = 16;

    private static SuperToolTip createToolTip(string file)
    {
        var result = new SuperToolTip { MaxWidth = 400 };

        result.Items.Add(
            new ToolTipTitleItem
            {
                Text = ZspPathHelper.GetFileNameFromFilePath(file.TrimEnd())
            });
        result.Items.Add(
            new ToolTipItem { Text = file });

        return result;
    }

    private void loadMruFileFiles()
    {
        barSubRecentFiles.ItemLinks.Clear();

        var files = coreLoadMruFileFiles();

        if (files.Length <= 0)
        {
            barSubRecentFiles.Visibility = BarItemVisibility.Never;
            barSubRecentFiles.Enabled = false;
        }
        else
        {
            barSubRecentFiles.Visibility = BarItemVisibility.Always;
            barSubRecentFiles.Enabled = true;

            var index = 0;
            foreach (var file in files)
            {
                var splitted = FileGroup.SplitFilePaths(file);

                if (splitted.Length > 0)
                {
                    var bbi =
                        new BarButtonItem
                        {
                            Caption =
                                $@"{index + 1} {ZspPathHelper.GetFileNameFromFilePath(splitted[0])}",
                            //Description =
                            //    ZrePathHelper.ShortenPathName(
                            //        splitted[0],
                            //        MruMaxCharSize),
                            SuperTip = createToolTip(splitted[0]),
                            Tag = file,
                            Enabled = true,
                            Visibility = BarItemVisibility.Always,
                            LargeImageIndex = 41,
                        };

                    bbi.ItemClick += bbi_ItemClick;

                    barSubRecentFiles.ItemLinks.Add(bbi);

                    index++;
                }
            }

            // --

            if (barSubRecentFiles.ItemLinks.Count > 0)
            {
                var bbi =
                    new BarButtonItem
                    {
                        Caption =
                            Resources.SR_MainFormNew_loadMruFileFiles_ClearRecentFilesList,
                        Description = Resources.SR_MainFormNew_loadMruFileProjects_RemovesAllItemsFromTheListAbove,
                        Enabled = true,
                        Visibility = BarItemVisibility.Always
                    };

                bbi.ItemClick +=
                    delegate
                    {
                        coreStoreMruFileFiles(new string[] { });
                        UpdateUI();
                        loadMruFileFiles();
                        checkShowApplicationMenuButton();
                    };

                barSubRecentFiles.ItemLinks.Add(bbi, true);
            }
        }
    }

    private void loadMruFileProjects()
    {
        barSubRecentProjects.ItemLinks.Clear();

        var files = coreLoadMruProjectFiles();

        if (files.Length <= 0)
        {
            barSubRecentProjects.Visibility = BarItemVisibility.Never;
            barSubRecentProjects.Enabled = false;
        }
        else
        {
            barSubRecentProjects.Visibility = BarItemVisibility.Always;
            barSubRecentProjects.Enabled = true;

            var index = 0;
            foreach (var file in files)
            {
                var bbi =
                    new BarButtonItem
                    {
                        Caption =
                            $@"{index + 1} {ZspPathHelper.GetFileNameWithoutExtension(file)}",
                        //Description =
                        //    ZrePathHelper.ShortenPathName(
                        //        file,
                        //        MruMaxCharSize),
                        SuperTip = createToolTip(file),
                        Tag = file,
                        Enabled = true,
                        Visibility = BarItemVisibility.Always,
                        LargeImageIndex = 40
                    };

                bbi.ItemClick += bbi_ItemClick2;

                barSubRecentProjects.ItemLinks.Add(bbi);

                index++;
            }

            // --

            if (barSubRecentProjects.ItemLinks.Count > 0)
            {
                var bbi =
                    new BarButtonItem
                    {
                        Caption =
                            Resources.SR_MainFormNew_loadMruFileProjects_ClearRecentProjectsList,
                        Description = Resources.SR_MainFormNew_loadMruFileProjects_RemovesAllItemsFromTheListAbove,
                        Enabled = true,
                        Visibility = BarItemVisibility.Always
                    };

                bbi.ItemClick +=
                    delegate
                    {
                        coreStoreMruProjectFiles(new string[] { });
                        UpdateUI();
                        loadMruFileProjects();
                        checkShowApplicationMenuButton();
                    };

                barSubRecentProjects.ItemLinks.Add(bbi, true);
            }
        }
    }

    private void bbi_ItemClick(object sender, ItemClickEventArgs e)
    {
        var paths = FileGroup.SplitFilePaths((string)e.Item.Tag);

        if (paths.Length > 0)
        {
            DialogResult r;
            if (GroupFilesControl.CurrentFileGroupControl != null)
            {
                r = GroupFilesControl.CurrentFileGroupControl.DoSaveFiles(
                    SaveOptions.OnlyIfModified |
                    SaveOptions.AskConfirm);
            }
            else
            {
                r = DialogResult.OK;
            }

            if (r == DialogResult.OK)
            {
                addMruFilesFile(FileGroup.JoinFilePaths(paths));
                //_mruFilesMenu.SetFirstFile( e.Number );

                GroupFilesControl.DoLoadFiles(
                    FileGroup.CheckCreate(
                        ProjectFilesControl.Project,
                        paths),
                    ProjectFilesControl.Project);
            }
        }
        else
        {
            removeMruFilesFile(FileGroup.JoinFilePaths(paths));
            //_mruFilesMenu.RemoveFile( e.Number );
        }
        UpdateUI();
    }

    private void bbi_ItemClick2(object sender, ItemClickEventArgs e)
    {
        var path = (string)e.Item.Tag;

        if (!string.IsNullOrEmpty(path))
        {
            DialogResult r;

            if (GroupFilesControl.CurrentFileGroupControl != null)
            {
                r = GroupFilesControl.CurrentFileGroupControl.DoSaveFiles(
                    SaveOptions.OnlyIfModified |
                    SaveOptions.AskConfirm);
            }
            else
            {
                r = DialogResult.OK;
            }

            if (r == DialogResult.OK)
            {
                //_mruProjectsMenu.SetFirstFile( e.Number );
                addMruProjectFile(path);

                ProjectFilesControl.DoLoadProject(new(path));
            }
        }
        else
        {
            //_mruProjectsMenu.RemoveFile( e.Number );
            removeMruProjectFile(path);
        }
        UpdateUI();
    }

    private static string[] coreLoadMruFileFiles()
    {
        var paths =
            ConvertHelper.ToString(
                PersistanceHelper.RestoreValue(
                    @"Mru.FileFiles",
                    string.Empty),
                string.Empty);

        var result = new List<string>(
            paths.Split(new[] { @"###~~~###" },
                StringSplitOptions.RemoveEmptyEntries));

        while (result.Count > MruMaxMruItems)
        {
            result.RemoveAt(result.Count - 1);
        }

        return result.ToArray();
    }

    private static void coreStoreMruFileFiles(
        string?[] paths)
    {
        var splitted =
            paths == null
                ? string.Empty
                : string.Join(@"###~~~###", paths);

        PersistanceHelper.SaveValue(@"Mru.FileFiles", splitted);
    }

    private static string[] coreLoadMruProjectFiles()
    {
        var paths =
            ConvertHelper.ToString(
                PersistanceHelper.RestoreValue(
                    @"Mru.ProjectFiles",
                    string.Empty),
                string.Empty);

        var result = new List<string>(
            paths.Split(new[] { @"###~~~###" },
                StringSplitOptions.RemoveEmptyEntries));

        while (result.Count > MruMaxMruItems)
        {
            result.RemoveAt(result.Count - 1);
        }

        return result.ToArray();
    }

    private static void coreStoreMruProjectFiles(
        string[] paths)
    {
        var splitted =
            paths == null
                ? string.Empty
                : string.Join(@"###~~~###", paths);

        PersistanceHelper.SaveValue(@"Mru.ProjectFiles", splitted);
    }

    private static void addMruFilesFile(
        string? file)
    {
        if (!string.IsNullOrEmpty(file))
        {
            var items = new List<string?>(coreLoadMruFileFiles());

            for (var index = 0; index < items.Count; ++index)
            {
                if (string.Compare(items[index], file, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    items.RemoveAt(index);
                    break;
                }
            }

            //if ( ZspIOHelper.FileExists( file ) )
            {
                items.Insert(0, file);
            }

            coreStoreMruFileFiles(items.ToArray());
        }
    }

    private static void addMruProjectFile(
        string file)
    {
        if (!string.IsNullOrEmpty(file))
        {
            var items = new List<string>(coreLoadMruProjectFiles());

            for (var index = 0; index < items.Count; ++index)
            {
                if (string.Compare(items[index], file, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    items.RemoveAt(index);
                    break;
                }
            }

            if (File.Exists(file))
            {
                items.Insert(0, file);
            }

            coreStoreMruProjectFiles(items.ToArray());
        }
    }

    private static void removeMruFilesFile(
        string? file)
    {
        if (!string.IsNullOrEmpty(file))
        {
            var items = new List<string>(coreLoadMruFileFiles());

            for (var index = 0; index < items.Count; ++index)
            {
                if (string.Compare(items[index], file, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    items.RemoveAt(index);
                    break;
                }
            }

            coreStoreMruFileFiles(items.ToArray());
        }
    }

    private static void removeMruProjectFile(
        string file)
    {
        if (!string.IsNullOrEmpty(file))
        {
            var items = new List<string>(coreLoadMruProjectFiles());

            for (var index = 0; index < items.Count; ++index)
            {
                if (string.Compare(items[index], file, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    items.RemoveAt(index);
                    break;
                }
            }

            coreStoreMruProjectFiles(items.ToArray());
        }
    }

    public static void AddMruFiles(string? files)
    {
        addMruFilesFile(files);
    }

    public static void AddMruProject(string file)
    {
        addMruProjectFile(file);
    }

    // ------------------------------------------------------------------

    #endregion

    private void aboutZetaResxEditorToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        using (var about = new AboutForm())
        {
            about.ShowDialog(this);
        }
        UpdateUI();
    }

    private void renameTagToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        GroupFilesControl.CurrentFileGroupControl.RenameTag();
        UpdateUI();
    }

    private void deleteTagToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        GroupFilesControl.CurrentFileGroupControl.DeleteTag();
        UpdateUI();
    }

    private void addTagToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        GroupFilesControl.CurrentFileGroupControl.AddTag();
        UpdateUI();
    }

    private void optionsToolStripMenuItem1_Click(
        object sender,
        ItemClickEventArgs e)
    {
        using (var form = new OptionsForm())
        {
            form.ShowDialog(this);
        }

        UpdateUI();
    }

    private void closeToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        GroupFilesControl.CloseAndSaveDataGrid();
        UpdateUI();
    }

    /// <summary>
    /// Updates the UserControls
    /// </summary>
    public override void UpdateUI()
    {
        base.UpdateUI();

        buttonImport.Enabled =
            buttonExport.Enabled =
                ProjectFilesControl.Project != null &&
                ProjectFilesControl.Project != Project.Empty;

        buttonSaveResourceFiles.Enabled =
            GroupFilesControl.CanSave;
        buttonCloseResourceFiles.Enabled =
            GroupFilesControl.CanClose;
        buttonAddNewTag.Enabled =
            GroupFilesControl.CurrentFileGroupControl is { CanAddTag: true };
        buttonDeleteTag.Enabled =
            GroupFilesControl.CurrentFileGroupControl is { CanDeleteTag: true };
        buttonRenameTag.Enabled =
            GroupFilesControl.CurrentFileGroupControl is { CanRenameTag: true };

        buttonTranslateMissingLanguages.Enabled =
            GroupFilesControl.CurrentFileGroupControl is { CanAutoTranslateMissingTranslations: true };

        buttonCloseAllDocuments.Enabled =
            GroupFilesControl.CanCloseAllDocuments;

        buttonOpenFileGroupFolder.Enabled =
            GroupFilesControl.CanOpenFolderOfCurrentResourceFile;

        buttonOpenProjectFile.Enabled =
            ProjectFilesControl != null && ProjectFilesUserControl.CanOpenProjectFile;
        buttonSaveProjectFile.Enabled =
            ProjectFilesControl is { CanSaveProjectFile: true };
        buttonCloseProject.Enabled =
            ProjectFilesControl is { CanCloseProjectFile: true };
        buttonAddFilesToFileGroup.Enabled =
            ProjectFilesControl is { CanAddFilesToFileGroup: true };
        buttonRemoveFileFromGroup.Enabled =
            ProjectFilesControl is { CanRemoveFileFromFileGroup: true };
        buttonCreateNewFile.Enabled =
            ProjectFilesControl is { CanCreateNewFile: true };
        buttonCreateNewFiles.Enabled =
            ProjectFilesControl is { CanCreateNewFiles: true };

        buttonEditFileGroupSettings.Enabled =
            ProjectFilesControl is { CanEditFileGroupSettings: true };

        buttonCreateNewProject.Enabled =
            ProjectFilesControl != null && ProjectFilesUserControl.CanCreateNewProject;
        buttonAddFileGroupToProject.Enabled =
            buttonAutomaticallyAddFileGroupsToProject.Enabled =
                buttonAddFromVisualStudio.Enabled =
                    ProjectFilesControl is { CanAddResourceFilesToProject: true };
        buttonRemoveFileGroupFromProject.Enabled =
            ProjectFilesControl is { CanRemoveResourceFilesFromProject: true };
        buttonEditProjectSettings.Enabled =
            ProjectFilesControl is { CanEditProjectSettings: true };

        buttonFind.Enabled =
            buttonReplace.Enabled =
                GroupFilesControl.CurrentFileGroupControl is { CanFind: true };
        buttonFindNext.Enabled =
            GroupFilesControl.CurrentFileGroupControl is { CanFindNext: true };

        buttonRefresh.Enabled =
            ProjectFilesControl is { CanRefresh: true };

        buttonMoveUp.Enabled =
            ProjectFilesControl is { CanMoveUp: true };
        buttonMoveDown.Enabled =
            ProjectFilesControl is { CanMoveDown: true };

        if (mainFormMainSplitContainer.PanelVisibility ==
            SplitPanelVisibility.Both)
        {
            buttonShowHideProjectPanel.Caption =
                Resources.SR_MainForm_UpdateUI_HideProjectPanel;
            buttonShowHideProjectPanel.Down = true;
        }
        else
        {
            buttonShowHideProjectPanel.Caption =
                Resources.SR_MainForm_UpdateUI_ShowProjectPanel;
            buttonShowHideProjectPanel.Down = false;
        }

        resetLayoutButton.Enabled =
            GroupFilesControl is { CanResetLayout: true };

        buttonConfigureLanguageColumns.Enabled =
            ProjectFilesControl is { CanConfigureLanguageColumns: true };
    }

    private void mainForm_Load(
        object sender,
        EventArgs e)
    {
        DataProcessing.CanOverwrite += dataProcessing_CanOverwrite;

        var rr = WinFormsPersistanceHelper.RestoreState(
            this,
            new()
            {
                SuggestZoomPercent = 90,
                RespectWindowRatio = false
            });
        if (!rr.DidMoveForm) CenterToScreen();

        ribbon.SelectedPage = ribbonPage1;
        FormBase.RestoreState(ribbon);
        DevExpressXtraFormBase.RestoreState(mainFormMainSplitContainer);

        loadMruFileProjects();
        loadMruFileFiles();

        checkShowApplicationMenuButton();

        if (!handleProjectOnCommandLine())
        {
            ProjectFilesControl.LoadRecentProject();
        }

        Application.Idle += application_Idle;

        UpdateUI();
    }

    private void checkShowApplicationMenuButton()
    {
        ribbon.ShowApplicationButton =
            barSubRecentProjects.Visibility != BarItemVisibility.Never ||
            barSubRecentFiles.Visibility != BarItemVisibility.Never
                ? DefaultBoolean.True
                : DefaultBoolean.False;
    }

    private AskOverwriteResult dataProcessing_CanOverwrite(FileInfo filePath)
    {
        var dr = XtraMessageBox.Show(
            this,
            string.Format(Resources.ConfirmOverwrite, filePath.Name),
            @"Zeta Resource Editor",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);

        return dr switch
        {
            DialogResult.Yes => AskOverwriteResult.Overwrite,
            DialogResult.No => AskOverwriteResult.Skip,
            _ => AskOverwriteResult.Fail
        };
    }

    /// <summary>
    /// Return TRUE if OK, FALSE if want to cancel.
    /// </summary>
    private bool checkAskSaveEverything()
    {
        var b1 = GroupFilesControl.SaveState();
        var b2 = ProjectFilesControl.SaveState();

        if (!b1 || !b2)
        {
            return false;
        }
        else
        {
            ProjectFilesControl.SaveRecentProjectInfo();
            GroupFilesControl.SaveRecentFilesInfo();

            return true;
        }
    }

    private void mainForm_FormClosing(
        object sender,
        FormClosingEventArgs e)
    {
        if (!checkAskSaveEverything())
        {
            e.Cancel = true;
        }
        else
        {
            ProjectFilesControl.CloseProject();

            FormBase.SaveState(ribbon);
            DevExpressXtraFormBase.SaveState(mainFormMainSplitContainer);

            WinFormsPersistanceHelper.SaveState(this);
            ((PersistentXmlFilePairStorage)PersistanceHelper.Storage).Flush();
        }
    }

    private void application_Idle(
        object sender,
        EventArgs e)
    {
        UpdateUI();

        GroupFilesControl.CurrentFileGroupControl?.UpdateUI();
    }

    private void mainForm_Shown(
        object sender,
        EventArgs e)
    {
        try
        {
            updateAvailableCheckerBackgroundWorker.RunWorkerAsync();
        }
        catch (Exception x)
        {
            // Catch and forget.
            LogCentral.Current.LogError(
                @"Error starting checking for updates.", x);
        }

        QuickTranslationForm.CheckRestoreShowForm();

        UpdateUI();
    }

    private void findToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        GroupFilesControl.CurrentFileGroupControl.Find();
        UpdateUI();
    }

    private void findNextToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        GroupFilesControl.CurrentFileGroupControl.FindNext();
        UpdateUI();
    }

    private void openFolderOfCurrentResourceFileToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        GroupFilesControl.CurrentFileGroupControl.OpenFolder();
        UpdateUI();
    }

    private void openProjectFileToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.OpenWithDialog();
        UpdateUI();
    }

    private void saveProjectFileToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.DoSaveFile(SaveOptions.None);
        UpdateUI();
    }

    private void closeProjectFileToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.CloseAndSaveProject();
        UpdateUI();
    }

    private void addResourceFilesToProjectToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.AddExistingResourceFilesWithDialog();
        UpdateUI();
    }

    private void removeResourceFilesFromProjectToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.RemoveResourceFilesWithDialog();
        UpdateUI();
    }

    private void editProjectSettingsToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.EditProjectSettingsWithDialog();
        UpdateUI();
    }

    private void createNewProjectToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.CreateNewProject();
        GroupFilesControl.CloseAllDocuments();
        UpdateUI();
    }

    private void closeAllDocumentsToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        GroupFilesControl.CloseAllDocuments();
        UpdateUI();
    }

    private void saveAllToolStripButton_Click(object sender, ItemClickEventArgs e)
    {
        SaveAllWithDialog();
    }

    private void visitVendorsWebsiteToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        var sei =
            new ShellExecuteInformation
            {
                FileName = @"https://zeta.li/zre-home"
            };
        sei.Execute();
    }

    private void addFilesToFileGroupToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.AddFilesToFileGroupWithDialog();
        UpdateUI();
    }

    private void removeFileFromGroupToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        ProjectFilesControl.RemoveFileFromFileGroupWithDialog();
        UpdateUI();
    }

    private void editResourceFilesSettingsToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        ProjectFilesControl.EditFileGroupSettingsWithDialog();
        UpdateUI();
    }

    private void onlineManualToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        var sei =
            new ShellExecuteInformation
            {
                FileName = @"https://zeta.li/zre-online-manual"
            };
        sei.Execute();
    }

    internal bool SaveAllWithDialog()
    {
        var a = ProjectFilesControl.SaveState(SaveOptions.OnlyIfModified);
        var b = a && GroupFilesControl.SaveState(SaveOptions.OnlyIfModified);

        return b;
    }

    private void buttonUpdateAvailable_ItemClick(
        object sender,
        ItemClickEventArgs e)
    {
        updateAvailableBlinkTimer.Stop();

        if (checkAskSaveEverything())
        {
            var result = (UpdatePresentResult2)buttonUpdateAvailable.Tag;

            var ws = WebServiceManager.Current.UpdateCheckerWS;
            new SetupDownloadController(ws).DownloadAndRunSetup(
                this,
                _updateCheckInfo,
                result.DownloadWebsiteUrl);

            // Exit myself to be updateable.
            Close();
        }
        else
        {
            updateAvailableBlinkTimer.Start();
        }
    }

    private void updateAvailableCheckerBackgroundWorker_DoWork(
        object sender,
        DoWorkEventArgs e)
    {
        try
        {
            Host.ApplyLanguageSettingsToCurrentThread();

            _updateCheckInfo =
                new()
                {
                    ApiKey = @"658b513f-8c69-482c-86ab-4be029377d18",
                    VersionNumber = FileVersionHelper.GetAssemblyVersion(Assembly.GetEntryAssembly()?.Location)
                        .ToString(),
                    // ReSharper disable once AssignNullToNotNullAttribute
                    VersionDate = File.GetLastWriteTime(Assembly.GetEntryAssembly()?.Location),
                    Culture = CultureInfo.CurrentUICulture.LCID
                };

            var ws = WebServiceManager.Current.UpdateCheckerWS;
            var info = ws.IsUpdateAvailable2(_updateCheckInfo);

            e.Result = info.IsPresent ? info : null;
        }
        catch (Exception x)
        {
            // Catch and forget.
            LogCentral.Current.LogError(
                @"Error during checking for updates.", x);
        }
    }

    private void updateAvailableCheckerBackgroundWorker_RunWorkerCompleted(
        object sender,
        RunWorkerCompletedEventArgs e)
    {
        try
        {
            if (e is { Cancelled: false, Error: null, Result: UpdatePresentResult2 result })
            {
                // Yes, we do have an update, pass the URL to the
                // toolbar button and make it visible.

                buttonUpdateAvailable.Tag = result;
                updateRibbonPageGroup.Visible = true;
                updateAvailableBlinkTimer.Start();
            }
            else if (e.Error != null)
            {
                _updateCheckInfo = null;
                throw e.Error;
            }
        }
        catch (Exception x)
        {
            // Catch and forget.
            LogCentral.Current.LogError(
                @"Error after checking for updates.", x);
        }
    }

    /// <summary>
    /// Handles the project on command line.
    /// </summary>
    private bool handleProjectOnCommandLine()
    {
        var args = Environment.GetCommandLineArgs();

        if (args.Length < 2)
        {
            return false;
        }
        else
        {
            for (var index = 1; index < args.Length; index++)
            {
                var file = args[index];

                if (string.Compare(
                        Project.ProjectFileExtension,
                        ZspPathHelper.GetExtension(file),
                        StringComparison.OrdinalIgnoreCase) == 0 &&
                    File.Exists(file))
                {
                    ProjectFilesControl.DoLoadProject(new(file));

                    return true;
                }
            }

            return false;
        }
    }

    #region Event Handler

    // ------------------------------------------------------------------

    private void mainForm_DragDrop(
        object sender,
        DragEventArgs e)
    {
        if (e.Data?.GetDataPresent(DataFormats.FileDrop) ?? false)
        {
            var files = (string[])e.Data.GetData(
                DataFormats.FileDrop);

            if (files is { Length: > 0 })
            {
                foreach (var file in files)
                {
                    // Allow dropping of project files.
                    if (string.Compare(Project.ProjectFileExtension, ZspPathHelper.GetExtension(file),
                            StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        ProjectFilesControl.DoLoadProject(new(file));
                        return;
                    }
                }
            }
        }
    }

    private void mainForm_DragEnter(
        object sender,
        DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files is { Length: > 0 })
            {
                foreach (var file in files)
                {
                    // Allow dropping of project files.
                    if (string.Compare(
                            Project.ProjectFileExtension,
                            ZspPathHelper.GetExtension(file),
                            StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        e.Effect = DragDropEffects.Copy;
                        return;
                    }
                }
            }

            // Not found.
            e.Effect = DragDropEffects.None;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }

    private void automaticallyAddMultipleFileGroupsToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        ProjectFilesControl.AutomaticallyAddAddResourceFilesWithDialog();
        UpdateUI();
    }

    private void refreshProjectFilesListToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        using (new WaitCursor(this, WaitCursorOption.ShortSleep))
        {
            ProjectFilesControl.RefreshItems();
        }
    }

    private void quickTranslationToolStripMenuItem_Click(object sender, ItemClickEventArgs e)
    {
        QuickTranslationForm.ShowTheForm();
    }

    private void translateMissingLanguagesToolStripMenuItem_Click(
        object sender,
        ItemClickEventArgs e)
    {
        using var form = new AutoTranslateForm();
        form.Initialize(GroupFilesControl.CurrentFileGroupControl);
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            GroupFilesControl.CurrentFileGroupControl.UpdateUI();
            UpdateUI();
        }
    }

    private void buttonExit_ItemClick(object sender, ItemClickEventArgs e)
    {
        Close();
    }

    // ------------------------------------------------------------------

    #endregion

    private void buttonExport_ItemClick(object sender, ItemClickEventArgs e)
    {
        SaveWithDialog(SaveOptions.OnlyIfModified);

        // Get groups from project
        var groups = ProjectFilesControl.Project.FileGroups;

        // Get groups from tabs
        foreach (var group in GroupFilesControl.GridEditableDatas)
        {
            if (group.FileGroup != null && !groups.Contains(group.FileGroup))
            {
                groups.Add(group.FileGroup);
            }
        }

        using var wizard = new ExcelExportWizardForm();
        wizard.Initialize(groups, ProjectFilesControl.Project);

        if (wizard.ShowDialog(this) == DialogResult.OK)
        {
            ProjectFilesControl.RefreshItems();
            UpdateUI();
        }
    }

    private void buttonImport_ItemClick(object sender, ItemClickEventArgs e)
    {
        SaveWithDialog(SaveOptions.OnlyIfModified);

        // Get groups from project
        var groups = ProjectFilesControl.Project.FileGroups;

        // Get groups from tabs
        foreach (var group in GroupFilesControl.GridEditableDatas)
        {
            if (group.FileGroup != null && !groups.Contains(group.FileGroup))
            {
                groups.Add(group.FileGroup);
            }
        }

        using var wizard = new ExcelImportWizardForm();
        wizard.Initialize(groups, ProjectFilesControl.Project);

        if (wizard.ShowDialog(this) == DialogResult.OK)
        {
            ProjectFilesControl.RefreshItems();
            UpdateUI();
        }
    }

    private void applicationMenu1_BeforePopup(
        object sender,
        CancelEventArgs e)
    {
        loadMruFileFiles();
        loadMruFileProjects();

        checkShowApplicationMenuButton();
    }

    private void buttonMoveUp_ItemClick(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.MoveUp();
    }

    private void buttonMoveDown_ItemClick(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.MoveDown();
    }

    private void buttonShowHideProjectPanel_ItemClick(
        object sender,
        ItemClickEventArgs e)
    {
        mainFormMainSplitContainer.PanelVisibility =
            mainFormMainSplitContainer.PanelVisibility ==
            SplitPanelVisibility.Both
                ? SplitPanelVisibility.Panel2
                : SplitPanelVisibility.Both;

        UpdateUI();
    }

    private void buttonCreateNewFile_ItemClick(
        object sender,
        ItemClickEventArgs e)
    {
        ProjectFilesControl.CreateNewFileWithDialog();
        UpdateUI();
    }

    private void buttonCreateNewFiles_ItemClick(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.CreateNewFilesWithDialog();
        UpdateUI();
    }

    private void resetLayoutButton_ItemClick(object sender, ItemClickEventArgs e)
    {
        GroupFilesControl.ResetLayout();
    }

    private void buttonAddFromVisualStudio_ItemClick(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.AutomaticallyAddResourceFilesFromSolutionWithDialog();
        UpdateUI();
    }

    private void buttonConfigureLanguageColumns_ItemClick(object sender, ItemClickEventArgs e)
    {
        ProjectFilesControl.ConfigureLanguageColumns();
    }

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
        GroupFilesControl.CurrentFileGroupControl.Replace();
        UpdateUI();
    }

    private int _blinkIndex = 1;

    private void updateAvailableBlinkTimer_Tick(object sender, EventArgs e)
    {
        if (buttonUpdateAvailable.Visibility == BarItemVisibility.Always)
        {
            _blinkIndex = _blinkIndex == 0 ? 1 : 0;
            var name = _blinkIndex == 0 ? @"heart-1" : @"heart-2";

            buttonUpdateAvailable.LargeGlyph = ImageCollectionHelper.Ic32.Images[name];
        }
        else
        {
            updateAvailableBlinkTimer.Stop();
        }
    }
}