namespace ZetaResourceEditor.UI.Main.LeftTree
{
    using DevExpress.Utils;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Nodes;
    using DevExpress.XtraTreeList.ViewInfo;
    using FileGroups;
    using Helper;
    using Helper.Base;
    using Helper.ErrorHandling;
    using Helper.Progress;
    using ProjectFolders;
    using Projects;
    using Properties;
    using RightContent;
    using RuntimeBusinessLogic.DL;
    using RuntimeBusinessLogic.FileGroups;
    using RuntimeBusinessLogic.FileInformations;
    using RuntimeBusinessLogic.ProjectFolders;
    using RuntimeBusinessLogic.Projects;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Logging;
    using Zeta.VoyagerLibrary.Tools.Storage;
    using Zeta.VoyagerLibrary.WinForms.Common;
    using ZetaAsync;
    using ZetaLongPaths;

    public partial class ProjectFilesUserControl :
        UserControlBase
    {
        public ProjectFilesUserControl()
        {
            InitializeComponent();
        }

        private void updateNodeInfo(
            TreeListNode node)
        {
            if (node?.TreeList != null && node.Tag != null)
            {
                LogCentral.Current.LogInfo(
                    $@"Updating node info of node '{node[0]}'.");

                updateNodeStateImage(node, AsynchronousMode.Asynchronous);
            }
        }

        public static bool CanOpenProjectFile => true;

        public bool CanSaveProjectFile => Project != null && Project != Project.Empty;

        public bool CanCloseProjectFile => Project != null && Project != Project.Empty;

        public bool CanEditFileGroupSettings
            => Project != null && Project != Project.Empty && treeView.SelectedNode?.Tag is FileGroup;

        public bool CanMergeIntoFileGroup
            => Project != null && Project != Project.Empty && treeView.SelectedNode?.Tag is FileGroup;

        private bool CanEditProjectFolderSettings
            => Project != null && Project != Project.Empty && treeView.SelectedNode?.Tag is ProjectFolder;

        private void AddNewResourceFilesWithDialog()
        {
            using var form = new AddNewFileGroupForm();
            var p = treeView.SelectedNode.Tag as ProjectFolder;

            form.Initialize(Project, p);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // Reload from in-memory project.
                new TreeListViewState(treeView).RestoreState(@"projectsTree");

                var node = addFileGroupToTree(treeView.SelectedNode, form.Result);

                // --

                sortTree();

                treeView.SelectedNode = node;

                // Immediately open for editing.
                editResourceFiles();

                UpdateUI();
            }
        }

        public void AddExistingResourceFilesWithDialog()
        {
            using var ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter =
                    $@"{Resources.SR_MainForm_openToolStripMenuItemClick_ResourceFiles} (*.resx;*.resw)|*.resx;*.resw",
                RestoreDirectory = true
            };

            var initialDir =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        MainForm.UserStorageIntelligent,
                        @"filesInitialDir"));
            ofd.InitialDirectory = initialDir;

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                PersistanceHelper.SaveValue(
                    MainForm.UserStorageIntelligent,
                    @"filesInitialDir",
                    ZlpPathHelper.GetDirectoryPathNameFromFilePath(ofd.FileName));

                // --

                var fileGroup = new FileGroup(Project);

                foreach (var filePath in ofd.FileNames)
                {
                    fileGroup.Add(new FileInformation(fileGroup)
                    {
                        File = new ZlpFileInfo(filePath)
                    });
                }

                // Look for same entries.
                if (Project.FileGroups.HasFileGroupWithChecksum(
                    fileGroup.GetChecksum(Project)))
                {
                    throw new MessageBoxException(
                        this,
                        Resources.SR_ProjectFilesUserControl_AddResourceFilesWithDialog_ExistsInTheProject,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (treeView.SelectedNode.Tag is ProjectFolder parentProjectFolder)
                    {
                        fileGroup.ProjectFolder = parentProjectFolder;
                    }

                    Project.FileGroups.Add(fileGroup);
                    Project.MarkAsModified();

                    var node = addFileGroupToTree(treeView.SelectedNode, fileGroup);

                    // --

                    sortTree();

                    treeView.SelectedNode = node;

                    // Immediately open for editing.
                    editResourceFiles();

                    UpdateUI();
                }
            }
        }

        /// <summary>
        /// Automatically adds multiple resource files with dialog.
        /// </summary>
        public void AutomaticallyAddAddResourceFilesWithDialog()
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = Resources
                    .SR_ProjectFilesUserControl_AutomaticallyAddAddResourceFilesWithDialog_AddedAutomatically
            };

            var initialDir =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        MainForm.UserStorageIntelligent,
                        @"filesInitialDir"));

            if (string.IsNullOrEmpty(initialDir) || !ZlpIOHelper.DirectoryExists(initialDir))
            {
                var d = Project.ProjectConfigurationFilePath.Directory;
                initialDir = d.FullName;
            }

            dialog.SelectedPath = initialDir;
            //dialog.ShowEditBox = true;

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                PersistanceHelper.SaveValue(
                    MainForm.UserStorageIntelligent,
                    @"filesInitialDir",
                    dialog.SelectedPath);

                var folderPath =
                    dialog.SelectedPath == null
                        ? null
                        : new ZlpDirectoryInfo(dialog.SelectedPath);

                var parentProjectFolder =
                    treeView.SelectedNode.Tag as ProjectFolder;

                // --

                var fileGroupCount = 0;
                var fileCount = 0;

                var enabled = guiRefreshTimer.Enabled;
                guiRefreshTimer.Enabled = false;

                using (new BackgroundWorkerLongProgressGui(
                    delegate (object sender, DoWorkEventArgs args)
                    {
                        try
                        {
                            doAutomaticallyAddResourceFiles(
                                (BackgroundWorker)sender,
                                parentProjectFolder,
                                ref fileGroupCount,
                                ref fileCount,
                                folderPath);
                        }
                        catch (OperationCanceledException)
                        {
                            // Ignore.
                        }
                    },
                    Resources.SR_ProjectFilesUserControl_AutomaticallyAddAddResourceFilesWithDialog_WillBeAdded,
                    BackgroundWorkerLongProgressGui.CancellationMode.Cancelable,
                    this))
                {
                }

                guiRefreshTimer.Enabled = enabled;

                if (fileGroupCount <= 0)
                {
                    XtraMessageBox.Show(
                        this,
                        Resources.SR_ProjectFilesUserControl_AutomaticallyAddAddResourceFilesWithDialog_WereAdded,
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    UpdateUI();
                }
                else
                {
                    XtraMessageBox.Show(
                        this,
                        string.Format(
                            Resources
                                .SR_ProjectFilesUserControl_AutomaticallyAddAddResourceFilesWithDialog_OfFilesWereAdded,
                            fileGroupCount,
                            fileCount),
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Reload from in-memory project.
                    fillFromProject();
                    new TreeListViewState(treeView).RestoreState(@"projectsTree");

                    Project.MarkAsModified();

                    sortTree();
                    UpdateUI();
                }
            }
        }

        private void doAutomaticallyAddResourceFiles(
            BackgroundWorker backgroundWorker,
            ProjectFolder parentProjectFolder,
            ref int fileGroupCount,
            ref int fileCount,
            ZlpDirectoryInfo folderPath)
        {
            if (backgroundWorker.CancellationPending)
            {
                throw new OperationCanceledException();
            }

            // Omit hidden or system folders.
            if ((folderPath.Attributes & ZetaLongPaths.Native.FileAttributes.Hidden) == 0 &&
                (folderPath.Attributes & ZetaLongPaths.Native.FileAttributes.System) == 0)
            {
                //CHANGED use comon method to look load new files:

                var filePaths = new List<ZlpFileInfo>(folderPath.GetFiles(@"*.resx"));
                filePaths.AddRange(new List<ZlpFileInfo>(folderPath.GetFiles(@"*.resw")));

                new VisualStudioImporter(Project).DoAutomaticallyAddResourceFilesFromList(
                    backgroundWorker,
                    parentProjectFolder,
                    ref fileGroupCount,
                    ref fileCount,
                    filePaths);
            }

            // 2020-10-22, Uwe Keim.
            var createFolders = Project.KeepFolderStructureOnImport;

            // Recurse childs.
            foreach (var childFolderPath in folderPath.GetDirectories())
            {
                // Neuer Unterordner, falls gewünscht.
                if (createFolders)
                {
                    var pf =
                        new ProjectFolder(Project)
                        {
                            Name = childFolderPath.Name,
                            Parent = parentProjectFolder
                        };
                    Project.ProjectFolders.Add(pf);
                    Project.MarkAsModified();

                    parentProjectFolder = pf;
                }

                doAutomaticallyAddResourceFiles(
                    backgroundWorker,
                    parentProjectFolder,
                    ref fileGroupCount,
                    ref fileCount,
                    childFolderPath);
            }
        }

        public void AutomaticallyAddResourceFilesFromSolutionWithDialog()
        {
            using var dialog = new OpenFileDialog {Title = Resources.SR_VSDialogTitle};

            var initialDir =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        MainForm.UserStorageIntelligent,
                        @"filesInitialDir"));

            if (string.IsNullOrEmpty(initialDir) ||
                !ZlpIOHelper.DirectoryExists(initialDir))
            {
                var d = Project.ProjectConfigurationFilePath.Directory;
                initialDir = d.FullName;
            }

            dialog.InitialDirectory = initialDir;
            dialog.Filter =
                $@"{Resources.SR_SlnNames}|*.csproj;*.sln";

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var proj = new ZlpFileInfo(dialog.FileName);

                var parentProjectFolder =
                    treeView.SelectedNode.Tag as ProjectFolder;

                // --

                var fileGroupCount = 0;
                var fileCount = 0;

                var enabled = guiRefreshTimer.Enabled;
                guiRefreshTimer.Enabled = false;

                using (new BackgroundWorkerLongProgressGui(
                    delegate (object sender, DoWorkEventArgs args)
                    {
                        try
                        {
                            new VisualStudioImporter(Project).DoAutomaticallyAddResourceFilesFromVsProject(
                                (BackgroundWorker)sender,
                                parentProjectFolder,
                                ref fileGroupCount,
                                ref fileCount,
                                proj);
                        }
                        catch (OperationCanceledException)
                        {
                            // Ignore.
                        }
                    },
                    Resources.SR_ProjectFilesUserControl_AutomaticallyAddAddResourceFilesWithDialog_WillBeAdded,
                    BackgroundWorkerLongProgressGui.CancellationMode.Cancelable,
                    this))
                {
                }

                guiRefreshTimer.Enabled = enabled;

                if (fileGroupCount <= 0)
                {
                    XtraMessageBox.Show(
                        this,
                        Resources.SR_ProjectFilesUserControl_AutomaticallyAddAddResourceFilesWithDialog_WereAdded,
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    UpdateUI();
                }
                else
                {
                    XtraMessageBox.Show(
                        this,
                        string.Format(
                            Resources
                                .SR_ProjectFilesUserControl_AutomaticallyAddAddResourceFilesWithDialog_OfFilesWereAdded,
                            fileGroupCount,
                            fileCount),
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Reload from in-memory project.
                    fillFromProject();
                    new TreeListViewState(treeView).RestoreState(@"projectsTree");

                    Project.MarkAsModified();

                    sortTree();
                    UpdateUI();

                    var node = treeView.SelectedNode;
                    // ReSharper disable ConditionIsAlwaysTrueOrFalse
                    if (node != null)
                        // ReSharper restore ConditionIsAlwaysTrueOrFalse
                    {
                        node.Expanded = true;
                    }
                }
            }
        }

        /// <summary>
        /// Removes the resource files with dialog.
        /// </summary>
        public void RemoveResourceFilesWithDialog()
        {
            var dr = XtraMessageBox.Show(
                this,
                Resources.SR_ProjectFilesUserControl_RemoveResourceFilesWithDialog_FromTheProject,
                @"Zeta Resource Editor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                var node = treeView.SelectedNode;

                while (node != null && !(node.Tag is FileGroup))
                {
                    node = node.ParentNode;
                }

                // ReSharper disable ConditionIsAlwaysTrueOrFalse
                if (node?.Tag is FileGroup tag)
                // ReSharper restore ConditionIsAlwaysTrueOrFalse
                {
                    Project.FileGroups.Remove(tag);
                    Project.MarkAsModified();

                    node.ParentNode.Nodes.Remove(node);
                }
            }
        }

        private void editResourceFiles()
        {
            if (CanEditResourceFiles)
            {
                MainForm.Current.GroupFilesControl.EditResourceFiles(
                    (IGridEditableData)treeView.SelectedNode.Tag,
                    Project);
            }
        }

        internal Project Project { get; private set; }

        public bool CanAddResourceFilesToProject => Project != null && Project != Project.Empty &&
                                                    treeView.SelectedNode != null &&
                                                    (
                                                        treeView.SelectedNode.Tag is Project ||
                                                        treeView.SelectedNode.Tag is ProjectFolder
                                                    );

        public bool CanRemoveResourceFilesFromProject
            => Project != null && Project != Project.Empty && treeView.SelectedNode?.Tag is FileGroup;

        private bool CanRemoveProjectFolder
            => Project != null && Project != Project.Empty && treeView.SelectedNode?.Tag is ProjectFolder;

        public bool CanEditProjectSettings => Project != null && Project != Project.Empty;

        public bool CanRefresh => Project != null && Project != Project.Empty;

        public static bool CanCreateNewProject => true;

        private bool CanEditResourceFiles
            => Project != null && Project != Project.Empty && treeView.SelectedNode?.Tag is IGridEditableData;

        public bool CanAddFilesToFileGroup
            => Project != null && Project != Project.Empty && treeView.SelectedNode?.Tag is FileGroup;

        public bool CanCreateNewFile
        {
            get
            {
                if (Project != null && Project != Project.Empty && treeView.SelectedNode?.Tag is FileGroup fg)
                {
                    // To add a new one, we must clone an existing one.
                    return fg.FilePaths.Length > 0;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool CanCreateNewFiles => Project != null && Project != Project.Empty &&
                                         treeView.SelectedNode != null &&
                                         (
                                             treeView.SelectedNode.Tag is Project ||
                                             treeView.SelectedNode.Tag is ProjectFolder
                                         );

        private bool CanAddProjectFolder => Project != null && Project != Project.Empty &&
                                            treeView.SelectedNode != null &&
                                            (
                                                treeView.SelectedNode.Tag is Project ||
                                                treeView.SelectedNode.Tag is ProjectFolder
                                            );

        public bool CanMoveUp
            =>
                Project != null && Project != Project.Empty && treeView.SelectedNode?.ParentNode != null &&
                treeView.SelectedNode.ParentNode.Nodes.Count > 1 && treeView.SelectedNode.Tag is IOrderPosition;

        private bool CanSortChildrenAlphabetically => Project != null && Project != Project.Empty &&
                                                      treeView.SelectedNode != null &&
                                                      treeView.SelectedNode.Nodes.Count > 1 &&
                                                      treeView.SelectedNode.Nodes[0].Tag is IOrderPosition;

        public bool CanMoveDown
            =>
                Project != null && Project != Project.Empty && treeView.SelectedNode?.ParentNode != null &&
                treeView.SelectedNode.ParentNode.Nodes.Count > 1 && treeView.SelectedNode.Tag is IOrderPosition;

        public bool CanRemoveFileFromFileGroup
            => Project != null && Project != Project.Empty && treeView.SelectedNode?.Tag is FileInformation;

        internal void DoLoadProject(
            ZlpFileInfo projectFilePath)
        {
            var r = DoSaveFile(
                SaveOptions.OnlyIfModified | SaveOptions.AskConfirm);

            if (r == DialogResult.OK)
            {
                doLoadProjectFile(projectFilePath);

                addToMru(projectFilePath);
            }
        }

        /// <summary>
        /// Adds to MRU.
        /// </summary>
        private void addToMru()
        {
            if (Project != null && Project != Project.Empty)
            {
                addToMru(Project.ProjectConfigurationFilePath);
            }
        }

        /// <summary>
        /// Adds to MRU.
        /// </summary>
        /// <param name="projectFilePath">The project file path.</param>
        private static void addToMru(
            ZlpFileInfo projectFilePath)
        {
            MainForm.AddMruProject(
                projectFilePath.FullName);
        }

        private void doLoadProjectFile(
            ZlpFileInfo projectFilePath)
        {
            closeProject();

            using (new WaitCursor(this, WaitCursorOption.ShortSleep))
            {
                var project = new Project();
                project.Load(projectFilePath);

                // Only assign if successfully loaded.
                Project = project;
                Project.ModifyStateChanged += project_ModifyStateChanged;

                fillFromProject();
                new TreeListViewState(treeView).RestoreState(@"projectsTree");

                // Instruct right pane to load the recent files.
                MainForm.Current.GroupFilesControl.LoadRecentFiles(project);
            }
        }

        private void closeProject()
        {
            // Store the dynamic user settings separately.
            if (Project != null && Project != Project.Empty &&
                !Project.IsModified &&
                Project.DynamicSettingsUser.IsModified)
            {
                Project.Store();
            }

            Project = null;
            treeView.Nodes.Clear();

            MainForm.Current.Text = @"Zeta Resource Editor";
        }

        private void fillFromProject()
        {
            treeView.Nodes.Clear();

            if (Project == null)
            {
                closeProject();
            }
            else
            {
                MainForm.Current.Text = $@"{Project.Name} – Zeta Resource Editor";

                var rootNode = treeView.AppendNode(new object[] { null }, null);

                rootNode[0] = Project.Name;
                rootNode.ImageIndex = rootNode.SelectImageIndex = getImageIndex(@"root");
                rootNode.Tag = Project;
                rootNode.StateImageIndex = (int)FileGroupStateColor.Grey;

                updateNodeStateImage(rootNode, AsynchronousMode.Asynchronous);

                // --

                foreach (var fileGroup in Project.GetRootProjectFolders())
                {
                    addProjectFolderToTree(rootNode, fileGroup);
                }

                foreach (var fileGroup in Project.GetRootFileGroups())
                {
                    addFileGroupToTree(rootNode, fileGroup);
                }

                // --

                rootNode.Expanded = true;
            }

            sortTree();
        }

        private TreeListNode addFileGroupToTree(
            TreeListNode parentNode,
            FileGroup fileGroup)
        {
            var fileGroupNode =
                treeView.AppendNode(
                    new object[]
                    {
                        null
                    },
                    parentNode);

            // --

            updateFileGroupInTree(
                fileGroupNode,
                fileGroup);

            // --

            addFileGroupFilesToTree(fileGroupNode);

            // --

            return fileGroupNode;
        }

        private void addFileGroupFilesToTree(
            TreeListNode fileGroupNode)
        {
            fileGroupNode.Nodes.Clear();

            if (!Project.HideFileGroupFilesInTree)
            {
                var ffis = ((FileGroup)fileGroupNode.Tag).GetFileInfos();
                foreach (var filePath in ffis)
                {
                    addFileToTree(fileGroupNode, filePath);
                }
            }
        }

        private void updateFileGroupInTree(
            TreeListNode fileGroupNode,
            FileGroup fileGroup)
        {
            fileGroupNode[0] = fileGroup.GetNameIntelligent(Project);
            fileGroupNode.ImageIndex = fileGroupNode.SelectImageIndex = getImageIndex(@"group");
            fileGroupNode.Tag = fileGroup;
            fileGroupNode.StateImageIndex = (int)FileGroupStateColor.Grey; //(int)fileGroup.TranslationStateColor;

            updateNodeStateImage(fileGroupNode, AsynchronousMode.Asynchronous);

            UpdateUI();
        }

        private void updateNodeStateImage(
            TreeListNode node,
            AsynchronousMode asynchronous)
        {
            if (node != null)
            {
                if (node.Tag is ITranslationStateInformation si)
                {
                    if (asynchronous == AsynchronousMode.Synchronous)
                    {
                        var stateImageIndex = (int)si.TranslationStateColor;

                        if (node.StateImageIndex != stateImageIndex)
                        {
                            node.StateImageIndex = stateImageIndex;

                            if (si is FileGroup)
                            {
                                foreach (TreeListNode childNode in node.Nodes)
                                {
                                    childNode.StateImageIndex = stateImageIndex;
                                }
                            }
                        }
                    }
                    else
                    {
                        // Fill with default.
                        if (node.StateImageIndex != (int)FileGroupStateColor.Grey)
                        {
                            node.StateImageIndex = (int)FileGroupStateColor.Grey;

                            if (si is FileGroup)
                            {
                                foreach (TreeListNode childNode in node.Nodes)
                                {
                                    childNode.StateImageIndex = (int)FileGroupStateColor.Grey;
                                }
                            }
                        }

                        // --

                        // Actually calculate, populate when finished calculating.
                        var info = new AsyncInfo { Node = node, StateInfo = si };
                        enqueue(info);
                    }
                }

                // --

                // Update parents.
                updateNodeStateImage(node.ParentNode, asynchronous);
            }
        }

        private readonly Queue<AsyncInfo> _queue = new Queue<AsyncInfo>();

        private void enqueue(AsyncInfo info)
        {
            lock (_queue)
            {
                _queue.Enqueue(info);
            }

            if (!updateNodeStateImageBackgroundworker.IsBusy)
            {
                updateNodeStateImageBackgroundworker.RunWorkerAsync();
            }
        }

        private class AsyncInfo
        {
            public ITranslationStateInformation StateInfo { get; set; }
            public int StateImageIndex { get; set; }

            public TreeListNode Node { get; set; }
        }

        private void updateNodeStateImageBackgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (!e.Cancel)
                {
                    if (WantPauseNodeStateUpdate)
                    {
                        Thread.Sleep(800);
                        Thread.Sleep(0);
                    }
                    else
                    {
                        AsyncInfo info;
                        lock (_queue)
                        {
                            if (_queue.Count > 0)
                            {
                                info = _queue.Dequeue();
                            }
                            else
                            {
                                return;
                            }
                        }

                        info.StateImageIndex = (int)info.StateInfo.TranslationStateColor;
                        ((BackgroundWorker)sender).ReportProgress(0, info);
                    }
                }
            }
            catch (InvalidOperationException)
            {
                // Eat.
            }
        }

        /// <summary>
        /// 2017-04-15, Uwe Keim: Während Translation keine Node-States aktualisieren.
        /// </summary>
        public bool WantPauseNodeStateUpdate { get; set; }

        private void updateNodeStateImageBackgroundworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var info = (AsyncInfo)e.UserState;

            // Apply result to tree.
            if (info.Node.StateImageIndex != info.StateImageIndex)
            {
                info.Node.StateImageIndex = info.StateImageIndex;

                if (info.StateInfo is FileGroup)
                {
                    foreach (TreeListNode childNode in info.Node.Nodes)
                    {
                        childNode.StateImageIndex = info.StateImageIndex;
                    }
                }
            }
        }

        private void updateNodeStateImageBackgroundworker_RunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs e)
        {
        }

        private TreeListNode addFileToTree(
            TreeListNode fileGroupNode,
            FileInformation filePath)
        {
            var fileNode =
                treeView.AppendNode(
                    new object[]
                    {
                        null
                    },
                    fileGroupNode);

            fileNode[0] = filePath.File.Name;

            fileNode.ImageIndex = fileNode.SelectImageIndex = getImageIndex(@"file");
            fileNode.Tag = filePath;
            fileNode.StateImageIndex = (int)FileGroupStateColor.Grey;

            updateNodeStateImage(fileNode, AsynchronousMode.Asynchronous);

            return fileNode;
        }

        private static int getImageIndex(string key)
        {
            switch (key)
            {
                case @"root":
                    return 0;
                case @"group":
                    return 1;
                case @"file":
                    return 2;
                case @"projectfolder":
                    return 3;

                default:
                    throw new ArgumentException();
            }
        }

        private TreeListNode addProjectFolderToTree(
            TreeListNode parentNode,
            ProjectFolder projectFolder)
        {
            var projectFolderNode =
                treeView.AppendNode(
                    new object[]
                    {
                        null
                    },
                    parentNode);

            // --

            updateProjectFolderInTree(
                projectFolderNode,
                projectFolder);

            // --

            foreach (var childProjectFolder in projectFolder.ChildProjectFolders)
            {
                addProjectFolderToTree(projectFolderNode, childProjectFolder);
            }

            foreach (var fileGroup in projectFolder.ChildFileGroups)
            {
                addFileGroupToTree(projectFolderNode, fileGroup);
            }

            // --

            return projectFolderNode;
        }

        private void updateProjectFolderInTree(
            TreeListNode projectFolderNode,
            ProjectFolder projectFolder)
        {
            projectFolderNode[0] = projectFolder.Name;
            projectFolderNode.ImageIndex = projectFolderNode.SelectImageIndex = getImageIndex(@"projectfolder");
            projectFolderNode.Tag = projectFolder;
            projectFolderNode.StateImageIndex = (int)FileGroupStateColor.Grey;

            updateNodeStateImage(projectFolderNode, AsynchronousMode.Asynchronous);
        }

        internal void OpenWithDialog()
        {
            using var ofd = new OpenFileDialog
            {
                Multiselect = false,
                Filter = string.Format(@"{0} (*{1})|*{1}",
                    Resources.SR_ProjectFilesUserControl_OpenWithDialog_EditorProjectFiles,
                    Project.ProjectFileExtension),
                RestoreDirectory = true
            };

            var initialDir =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        @"zreprojInitialDir"));
            ofd.InitialDirectory = initialDir;

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                PersistanceHelper.SaveValue(
                    @"zreprojInitialDir",
                    ZlpPathHelper.GetDirectoryPathNameFromFilePath(ofd.FileName));

                DoLoadProject(new ZlpFileInfo(ofd.FileName));
            }
        }

        internal DialogResult DoSaveFile(
            SaveOptions options)
        {
            if (Project == null)
            {
                return DialogResult.OK;
            }
            else
            {
                if ((options & SaveOptions.OnlyIfModified) == 0 ||
                    Project.IsModified)
                {
                    using (new WaitCursor(this, WaitCursorOption.ShortSleep))
                    {
                        if ((options & SaveOptions.AskConfirm) == 0)
                        {
                            addToMru();
                            Project.Store();

                            return DialogResult.OK;
                        }
                        else
                        {
                            var r2 =
                                XtraMessageBox.Show(
                                    Resources.SR_ProjectFilesUserControl_DoSaveFile_SaveChangesToTheProjectFile,
                                    @"Zeta Resource Editor",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Question);

                            switch (r2)
                            {
                                case DialogResult.Yes:
                                    addToMru();
                                    Project.Store();

                                    return DialogResult.OK;
                                case DialogResult.No:
                                    return DialogResult.OK;
                                default:
                                    return DialogResult.Cancel;
                            }
                        }
                    }
                }
                else
                {
                    return DialogResult.OK;
                }
            }
        }

        internal void CloseAndSaveProject()
        {
            if (DoSaveFile(
                    SaveOptions.OnlyIfModified |
                    SaveOptions.AskConfirm) == DialogResult.OK)
            {
                closeProject();
            }
        }

        public void CloseProject()
        {
            if (Project != null && Project != Project.Empty)
            {
                closeProject();
            }
        }

        public void EditProjectSettingsWithDialog()
        {
            using var form = new ProjectSettingsForm();
            form.Initialize(Project);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Project.MarkAsModified();
            }
        }

        public void EditFileGroupSettingsWithDialog()
        {
            using var form = new FileGroupSettingsForm();
            form.Initialize((FileGroup)treeView.SelectedNode.Tag);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Project.MarkAsModified();

                updateFileGroupInTree(
                    treeView.SelectedNode,
                    (FileGroup)treeView.SelectedNode.Tag);
            }
        }

        public void CreateNewFileWithDialog()
        {
            using var form = new CreateNewFileForm();
            form.Initialize((FileGroup)treeView.SelectedNode.Tag);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Project.MarkAsModified();

                addFileGroupFilesToTree(
                    treeView.SelectedNode);

                updateFileGroupInTree(
                    treeView.SelectedNode,
                    (FileGroup)treeView.SelectedNode.Tag);

                UpdateUI();
            }
        }

        public void CreateNewFilesWithDialog()
        {
            using var form = new CreateNewFilesForm();
            var p = treeView.SelectedNode.Tag as ProjectFolder;

            form.Initialize(Project, p);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // Reload from in-memory project.
                fillFromProject();
                new TreeListViewState(treeView).RestoreState(@"projectsTree");

                Project.MarkAsModified();

                sortTree();
                UpdateUI();
            }
        }

        private void DeleteLanguageWithDialog()
        {
            using var form = new DeleteLanguageForm();
            var p = treeView.SelectedNode.Tag as ProjectFolder;

            form.Initialize(Project, p);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // Reload from in-memory project.
                fillFromProject();
                new TreeListViewState(treeView).RestoreState(@"projectsTree");

                Project.MarkAsModified();

                sortTree();
                UpdateUI();
            }
        }

        private void MergeFilesWithDialog()
        {
            using var form = new MergeFileGroupForm();
            var p = (FileGroup)treeView.SelectedNode.Tag;

            form.Initialize(p, Project);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (form.DidAnything)
                {
                    // Reload from in-memory project.
                    fillFromProject();
                    new TreeListViewState(treeView).RestoreState(@"projectsTree");

                    Project.MarkAsModified();

                    sortTree();
                    UpdateUI();
                }
            }
        }

        public override void UpdateUI()
        {
            base.UpdateUI();

            buttonMenuProjectEditResourceFiles.Enabled =
                CanEditResourceFiles;
            buttonMenuProjectAddFileGroupToProject.Enabled =
                CanAddResourceFilesToProject;
            buttonMenuProjectAddNewFileGroupToProject.Enabled =
                CanAddResourceFilesToProject;
            buttonMenuProjectFolderAddFileGroupToProject.Enabled =
                CanAddResourceFilesToProject;
            buttonMenuProjectRemoveFileGroupFromProject.Enabled =
                CanRemoveResourceFilesFromProject;
            buttonMenuProjectEditProjectSettings.Enabled =
                CanEditProjectSettings;
            buttonMenuProjectAutomaticallyAddMultipleFileGroupsToProject.Enabled =
                CanAddResourceFilesToProject;
            buttonMenuProjectAutomaticallyAddFileGroupsFromVisualStudioSolution.Enabled =
                CanAddResourceFilesToProject;

            buttonMenuProjectAddFilesToFileGroup.Enabled =
                CanAddFilesToFileGroup;

            buttonMenuProjectEditFileGroupSettings.Enabled =
                CanEditFileGroupSettings;

            buttonMergeIntoFileGroup.Enabled =
                CanMergeIntoFileGroup;

            buttonMenuProjectRemoveFileFromFileGroup.Enabled =
                CanRemoveFileFromFileGroup;

            buttonMenuProjectCreateNewFile.Enabled =
                CanCreateNewFile;
            buttonMenuProjectCreateNewFiles.Enabled =
                CanCreateNewFiles;

            // --

            buttonMenuProjectRemoveProjectFolder.Enabled =
                CanRemoveProjectFolder;
            buttonMenuProjectAddProjectFolder.Enabled =
                CanAddProjectFolder;
            buttonMenuProjectEditProjectFolder.Enabled =
                CanEditProjectFolderSettings;

            buttonMenuProjectMoveUp.Enabled =
                CanMoveUp;
            buttonMenuProjectMoveDown.Enabled =
                CanMoveDown;
            buttonSortProjectFolderChildrenAscendingAZ.Enabled =
                CanSortChildrenAlphabetically;

            buttonOpenProjectMenuItem.Enabled =
                CanOpenProjectFile;
        }

        public void CreateNewProject()
        {
            using var form = new CreateNewProjectForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                var r = DoSaveFile(
                    SaveOptions.OnlyIfModified |
                    SaveOptions.AskConfirm);

                if (r == DialogResult.OK)
                {
                    closeProject();

                    // Only assign if successfully loaded.
                    Project = Project.CreateNew(
                        form.ProjectConfigurationFilePath);
                    Project.ModifyStateChanged += project_ModifyStateChanged;

                    fillFromProject();
                }
            }
        }

        private void protectDoubleClickOnNode(
            BeforeExpandEventArgs e)
        {
            // Avoid expanding/collapsing upon double click.

            if (treeView.WasDoubleClick)
            {
                if (e.Node.Level > 0)
                {
                    e.CanExpand = false;
                    treeView.WasDoubleClick = false;
                }
            }
        }

        private void protectDoubleClickOnNode(
            BeforeCollapseEventArgs e)
        {
            // Avoid expanding/collapsing upon double click.

            if (treeView.WasDoubleClick)
            {
                e.CanCollapse = false;
                treeView.WasDoubleClick = false;
            }
        }

        internal bool SaveState(
            SaveOptions options)
        {
            new TreeListViewState(treeView).PersistsState(@"projectsTree");

            if (Project == null)
            {
                return true;
            }
            else
            {
                var r = DoSaveFile(options);

                return r == DialogResult.OK;
            }
        }

        public bool SaveState()
        {
            return SaveState(
                SaveOptions.OnlyIfModified |
                SaveOptions.AskConfirm);
        }

        public void LoadRecentProject()
        {
            var filePath =
                PersistanceHelper.RestoreValue(@"RecentProject") as string;

            if (!string.IsNullOrEmpty(filePath) && ZlpIOHelper.FileExists(filePath))
            {
                DoLoadProject(new ZlpFileInfo(filePath));
            }
        }

        public void SaveRecentProjectInfo()
        {
            var filePath = Project == null ? string.Empty : Project.ProjectConfigurationFilePath.FullName;

            PersistanceHelper.SaveValue(@"RecentProject", filePath);
        }

        public void AddFilesToFileGroupWithDialog()
        {
            using var ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter =
                    $@"{Resources.SR_MainForm_openToolStripMenuItemClick_ResourceFiles} (*.resx;*.resw)|*.resx;*.resw",
                RestoreDirectory = true
            };

            var fileGroup = (FileGroup)treeView.SelectedNode.Tag;

            ofd.InitialDirectory = fileGroup.FolderPath.FullName;

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var fileName in ofd.FileNames)
                {
                    var filePath = new ZlpFileInfo(fileName);

                    if (string.Compare(
                        filePath.Directory.FullName,
                        fileGroup.FolderPath.FullName, StringComparison.OrdinalIgnoreCase) != 0)
                    {
                        throw new MessageBoxException(
                            this,
                            Resources.SR_ProjectFilesUserControl_AddFilesToFileGroupWithDialog_AlreadyPresent,
                            MessageBoxIcon.Error);
                    }
                }

                // --

                var parentNode = treeView.SelectedNode;

                foreach (var fileName in ofd.FileNames)
                {
                    var fileInfo =
                        new FileInformation(fileGroup)
                        {
                            File = new ZlpFileInfo(fileName)
                        };

                    if (!fileGroup.Contains(fileInfo))
                    {
                        fileGroup.Add(fileInfo);

                        if (!Project.HideFileGroupFilesInTree)
                        {
                            var node = addFileToTree(parentNode, fileInfo);
                            treeView.SelectedNode = node;
                        }
                    }
                }

                sortTree();

                Project.MarkAsModified();
                UpdateUI();
            }
        }

        /// <summary>
        /// Removes the file from file group with dialog.
        /// </summary>
        public void RemoveFileFromFileGroupWithDialog()
        {
            var dr = XtraMessageBox.Show(
                this,
                Resources.SR_ProjectFilesUserControl_RemoveFileFromFileGroupWithDialog_FromTheFileGroup,
                @"Zeta Resource Editor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                var node = treeView.SelectedNode;

                if (node?.Tag is FileInformation tag)
                {
                    var parentNode = node.ParentNode;

                    var fileGroup = (FileGroup)node.ParentNode.Tag;

                    fileGroup.RemoveFileInfo(tag);
                    Project.MarkAsModified();

                    if (parentNode != null)
                    {
                        treeView.SelectedNode = parentNode;
                    }

                    node.ParentNode.Nodes.Remove(node);
                }
            }
        }

        private static void sortTree()
        {
            //treeView.TreeViewNodeSorter = new NodeSorter();
            //treeView.Sort();
            //treeView.TreeViewNodeSorter = null;
        }

        public void RefreshItems()
        {
            new TreeListViewState(treeView).PersistsState(@"projectsTree");
            fillFromProject();
            new TreeListViewState(treeView).RestoreState(@"projectsTree");
        }


        public void ConfigureLanguageColumns()
        {
            using var form = new ConfigureLanguageColumnsForm();
            form.Initialize(Project);

            if (form.ShowDialog(ParentForm) == DialogResult.OK)
            {
                MainForm.Current.GroupFilesControl.CloseAllDocuments();
            }
        }

        public bool CanConfigureLanguageColumns => Project != null && Project != Project.Empty;

        private void treeView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&
                !e.Alt &&
                !e.Control &&
                !e.Shift)
            {
                if (CanEditResourceFiles)
                {
                    editResourceFiles();

                    e.Handled = true;
                }
            }
        }

        private void treeView_BeforeCollapse(object sender, BeforeCollapseEventArgs e)
        {
            // Never allow the root to be collapsed.
            if (e.Node.ParentNode == null)
            {
                e.CanCollapse = false;
            }
            else
            {
                protectDoubleClickOnNode(e);
            }
        }

        private void treeView_BeforeExpand(object sender, BeforeExpandEventArgs e)
        {
            protectDoubleClickOnNode(e);
        }

        private void projectFilesUserControlNew_Load(object sender, EventArgs e)
        {
            if (!Zeta.VoyagerLibrary.WinForms.Base.UserControlBase.IsDesignMode(this))
            {
                new TreeListViewState(treeView).RestoreState(@"projectsTree");

                var form = FindForm();
                if (form != null)
                {
                    form.Shown +=
                        delegate
                        {
                            _formShown = true;
                            /*guiRefreshTimer.Start();*/
                        };
                }

                _nodeUpdateIterator = new StepwiseTreeIterator(
                    treeView,
                    NodeUpdateInterval,
                    updateNodeInfo,
                    1);

                MainForm.Current.FileGroupStateChanged.Add(
                    (s, args) => updateNodeStateImage(locateNode(args.GridEditableData),
                        AsynchronousMode.Asynchronous));

                //if (!HostSettings.Current.ShowNewsInMainWindow)
                //{
                //    resourceEditorProjectFilesSplitContainer.PanelVisibility =
                //        SplitPanelVisibility.Panel1;
                //}
            }
        }

        private TreeListNode locateNode(IGridEditableData fileGroup)
        {
            TreeListNode result = null;

            treeView.NodesIterator.DoOperation(
                n =>
                {
                    if (result == null)
                    {
                        if (n.Tag is IGridEditableData fg && fg.GetChecksum(Project) == fileGroup.GetChecksum(Project))
                        {
                            result = n;
                        }
                    }
                });

            return result;
        }

        private void optionsPopupMenu_BeforePopup(object sender, CancelEventArgs e)
        {
            UpdateUI();
        }

        private static readonly TimeSpan NodeUpdateInterval =
            new TimeSpan(0, 0, 1);

        private StepwiseTreeIterator _nodeUpdateIterator;
        private bool _formShown;
        private Font _boldFont;

        private void guiRefreshTimer_Tick(object sender, EventArgs e)
        {
            if (_formShown)
            {
                // Update one node each idle tick.
                _nodeUpdateIterator.Step();
                UpdateUI();
            }
        }

        private void buttonEditResourceFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            editResourceFiles();
        }

        private void buttonAutomaticallyAddMultipleFileGroupsToProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            AutomaticallyAddAddResourceFilesWithDialog();
            UpdateUI();
        }

        private void buttonAddFileGroupToProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddExistingResourceFilesWithDialog();
            UpdateUI();
        }

        private void buttonRemoveFileGroupFromProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            RemoveResourceFilesWithDialog();
            UpdateUI();
        }

        private void buttonEditFileGroupSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditFileGroupSettingsWithDialog();
            Update();
        }

        private void buttonAddFilesToFileGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddFilesToFileGroupWithDialog();
            UpdateUI();
        }

        private void buttonRemoveFileFromFileGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            RemoveFileFromFileGroupWithDialog();
            UpdateUI();
        }

        private void buttonEditProjectSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditProjectSettingsWithDialog();
            UpdateUI();
        }

        private void project_ModifyStateChanged(
            object sender,
            EventArgs e)
        {
            treeView.SyncInvoke(delegate
            {
                var project = (Project)sender;
                var text = project.Name;

                if (project.IsModified)
                {
                    text += @" " + Project.ModifiedChar;
                }

                if (ConvertHelper.ToString(treeView.Nodes[0]) != text)
                {
                    treeView.Nodes[0][0] = text;
                }
            });
        }

        private void treeView_MouseUp(object sender, MouseEventArgs e)
        {
            // http://www.devexpress.com/Support/Center/KB/p/A915.aspx.
            var tree = (TreeList)sender;

            if (e.Button == MouseButtons.Right &&
                ModifierKeys == Keys.None &&
                tree.State == TreeListState.Regular)
            {
                var pt = tree.PointToClient(MousePosition);
                var info = tree.CalcHitInfo(pt);

                switch (info.HitInfoType)
                {
                    case HitInfoType.Row:
                    case HitInfoType.Cell:
                    case HitInfoType.Button:
                    case HitInfoType.StateImage:
                    case HitInfoType.SelectImage:
                        if (info.Node != null)
                        {
                            treeView.SelectedNode = info.Node;
                        }
                        break;
                }

                UpdateUI();

                // --

                var n = treeView.SelectedNode;
                var t = n?.Tag;

                switch (t)
                {
                    case null:
                        popupMenuNone.ShowPopup(MousePosition);
                        break;
                    case Project _:
                        popupMenuProject.ShowPopup(MousePosition);
                        break;
                    case ProjectFolder:
                        popupMenuProjectFolder.ShowPopup(MousePosition);
                        break;
                    case FileGroup:
                        popupMenuFileGroup.ShowPopup(MousePosition);
                        break;
                    case FileInformation:
                        popupMenuFile.ShowPopup(MousePosition);
                        break;
                    default:
                        throw new Exception(t.GetType().ToString());
                }
            }
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            if (CanEditResourceFiles)
            {
                editResourceFiles();
            }
        }

        private void treeView_CompareNodeValues(
            object sender,
            CompareNodeValuesEventArgs e)
        {
            var tx = e.Node1;
            var ty = e.Node2;

            if (tx.Tag is FileInformation tag && ty.Tag is FileInformation v)
            {
                var u = tag;

                e.Result = u.CompareTo(v);
            }
            else
            {
                // If they are the same length, call Compare.
                e.Result = string.CompareOrdinal(
                    ConvertHelper.ToString(tx[0]),
                    ConvertHelper.ToString(ty[0]));
            }
        }

        private void toolTipController1_GetActiveObjectInfo(
            object sender,
            ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            // http://www.devexpress.com/Support/Center/KB/p/A474.aspx

            if (e.SelectedControl is TreeList list)
            {
                var tree = list;
                var hit = tree.CalcHitInfo(e.ControlMousePosition);

                if (hit.HitInfoType == HitInfoType.Cell)
                {
                    var cellInfo = new TreeListCellToolTipInfo(hit.Node, hit.Column, null);

                    var tt = hit.Node.Tag switch
                    {
                        FileGroup fg => fg.GetFullNameIntelligent(Project),
                        ZlpFileInfo fsi => fsi.FullName,
                        _ => null
                    };

                    if (tt != null)
                    {
                        e.Info = new ToolTipControlInfo(cellInfo, tt);
                    }
                }
            }
        }

        private void buttonAddProjectFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            using var form = new ProjectFolderEditForm();
            var pf =
                new ProjectFolder(Project)
                {
                    Name = Resources.SR_ProjectFilesUserControl_buttonAddProjectFolderItemClick_NewProjectFolder
                };

            form.Initialize(pf);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (treeView.SelectedNode.Tag is ProjectFolder parentProjectFolder)
                {
                    pf.Parent = parentProjectFolder;
                }

                Project.ProjectFolders.Add(pf);
                Project.MarkAsModified();

                var node = addProjectFolderToTree(treeView.SelectedNode, pf);

                // --

                sortTree();

                treeView.SelectedNode = node;

                UpdateUI();
            }
        }

        private void buttonEditProjectFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            using var form = new ProjectFolderEditForm();
            form.Initialize((ProjectFolder)treeView.SelectedNode.Tag);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Project.MarkAsModified();

                updateProjectFolderInTree(
                    treeView.SelectedNode,
                    (ProjectFolder)treeView.SelectedNode.Tag);

                UpdateUI();
            }
        }

        private void buttonRemoveProjectFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dr = XtraMessageBox.Show(
                this,
                Resources.SR_ProjectFilesUserControl_buttonRemoveProjectFolder_ItemClick,
                @"Zeta Resource Editor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                var node = treeView.SelectedNode;

                removeNodeAndchilds(node);
                UpdateUI();
            }
        }

        private void removeNodeAndchilds(TreeListNode node)
        {
            if (node != null)
            {
                switch (node.Tag)
                {
                    case ProjectFolder tag:
                    {
                        // Recurse children.
                        while (node.Nodes.Count > 0)
                        {
                            removeNodeAndchilds(node.Nodes[0]);
                        }

                        Project.ProjectFolders.Remove(tag);
                        Project.MarkAsModified();

                        node.ParentNode.Nodes.Remove(node);
                        break;
                    }
                    case FileGroup tag:
                        Project.FileGroups.Remove(tag);
                        Project.MarkAsModified();

                        node.ParentNode.Nodes.Remove(node);
                        break;
                    default:
                        throw new Exception(
                            string.Format(
                                Resources.SR_ProjectFilesUserControl_removeNodeAndchilds_Unexpected_node_type,
                                node.Tag?.GetType().Name ?? @"null"));
                }
            }
        }

        private void buttonMoveUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoveUp();
        }

        private void buttonMoveDown_ItemClick(object sender, ItemClickEventArgs e)
        {
            MoveDown();
        }

        public void MoveUp()
        {
            treeView.EnsureItemsOrderPositionsSet(
                null,
                treeView.SelectedNode.ParentNode,
                AsynchronousMode.Synchronous);
            treeView.MoveItemUpByOne(treeView.SelectedNode);
            treeView.EnsureItemsOrderPositionsSet(
                null,
                treeView.SelectedNode.ParentNode,
                AsynchronousMode.Synchronous);

            Project.MarkAsModified();
            UpdateUI();
        }

        public void MoveDown()
        {
            treeView.EnsureItemsOrderPositionsSet(
                null,
                treeView.SelectedNode.ParentNode,
                AsynchronousMode.Synchronous);
            treeView.MoveItemDownByOne(treeView.SelectedNode);
            treeView.EnsureItemsOrderPositionsSet(
                null,
                treeView.SelectedNode.ParentNode,
                AsynchronousMode.Synchronous);

            Project.MarkAsModified();
            UpdateUI();
        }

        private static DragDropEffects getDragDropEffect(
            TreeList tl,
            TreeListNode dragNode)
        {
            var p = tl.PointToClient(MousePosition);
            var targetNode = tl.CalcHitInfo(p).Node;

            if (dragNode != null && targetNode != null &&
                dragNode != targetNode &&
                !ZetaResourceEditorTreeListControl.IsNodeChildNodeOf(targetNode, dragNode))
            {
                if (dragNode.Tag is FileGroup || dragNode.Tag is ProjectFolder)
                {
                    if (targetNode.Tag is ProjectFolder || targetNode.Tag is Project)
                    {
                        return DragDropEffects.Move;
                    }
                    else
                    {
                        return DragDropEffects.None;
                    }
                }
                else
                {
                    return DragDropEffects.None;
                }
            }
            else
            {
                return DragDropEffects.None;
            }
        }

        // http://www.devexpress.com/Support/Center/KB/p/A342.aspx
        private void treeView_DragOver(
            object sender,
            DragEventArgs e)
        {
            var dragNode = (TreeListNode)e.Data.GetData(typeof(TreeListNode));
            e.Effect = getDragDropEffect((TreeList)sender, dragNode);
        }

        private void treeView_DragDrop(
            object sender,
            DragEventArgs e)
        {
            var tree = (TreeList)sender;
            var p = tree.PointToClient(new Point(e.X, e.Y));

            var dragNode = (TreeListNode)e.Data.GetData(typeof(TreeListNode));
            var targetNode = tree.CalcHitInfo(p).Node;

            // --

            var oldParent = dragNode.ParentNode;

            tree.MoveNode(dragNode, targetNode, true);
            tree.SetNodeIndex(dragNode, targetNode.Nodes.Count);
            //tl.SetNodeIndex( dragNode, tl.GetNodeIndex( targetNode ) );

            var newParentProjectFolder = targetNode.Tag as ProjectFolder;

            switch (dragNode.Tag)
            {
                case FileGroup tag:
                    tag.ProjectFolder = newParentProjectFolder;
                    break;
                case ProjectFolder folder:
                    folder.Parent = newParentProjectFolder;
                    break;
                default:
                    throw new ArgumentException();
            }

            // --

            updateNodeStateImage(oldParent, AsynchronousMode.Asynchronous);
            updateNodeStateImage(dragNode, AsynchronousMode.Asynchronous);

            treeView.EnsureItemsOrderPositionsSet(
                null,
                treeView.SelectedNode.ParentNode,
                AsynchronousMode.Synchronous);
            Project.MarkAsModified();
            UpdateUI();

            // --

            // Handled.
            e.Effect = DragDropEffects.None;
        }

        private void treeView_CalcNodeDragImageIndex(
            object sender,
            CalcNodeDragImageIndexEventArgs e)
        {
            var tree = (TreeList)sender;
            if (getDragDropEffect(tree, tree.FocusedNode) == DragDropEffects.None)
            {
                e.ImageIndex = -1; // no icon
            }
            else
            {
                e.ImageIndex = 1; // the reorder icon (a curved arrow)
            }
        }

        private void buttonCreateNewFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateNewFileWithDialog();
        }

        private void buttonCreateNewFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateNewFilesWithDialog();
        }

        private Font boldFont => _boldFont ??= new Font(Appearance.Font, FontStyle.Bold);

        private void treeView_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node.Tag is ProjectFolder)
            {
                e.Appearance.Font = boldFont;
            }
        }

        private void buttonAutomaticallyAddFileGroupsFromVisualStudioSolution_ItemClick(
            object sender,
            ItemClickEventArgs e)
        {
            AutomaticallyAddResourceFilesFromSolutionWithDialog();
            UpdateUI();
        }

        private void buttonOpenProjectMenuItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWithDialog();
            UpdateUI();
        }

        private void buttonSortAscendingAZ_ItemClick(object sender, ItemClickEventArgs e)
        {
            treeView.EnsureItemsOrderPositionsSet(
                null,
                treeView.SelectedNode,
                AsynchronousMode.Synchronous);
            treeView.SortChildrenAlphabetically(treeView.SelectedNode);
            treeView.EnsureItemsOrderPositionsSet(
                null,
                treeView.SelectedNode,
                AsynchronousMode.Synchronous);

            Project.MarkAsModified();
            UpdateUI();
        }

        private void buttonSortChildrenProjectAZ_ItemClick(object sender, ItemClickEventArgs e)
        {
            treeView.EnsureItemsOrderPositionsSet(
                null,
                treeView.SelectedNode,
                AsynchronousMode.Synchronous);
            treeView.SortChildrenAlphabetically(treeView.SelectedNode);
            treeView.EnsureItemsOrderPositionsSet(
                null,
                treeView.SelectedNode,
                AsynchronousMode.Synchronous);

            Project.MarkAsModified();
            UpdateUI();
        }

        private void buttonMenuProjectAddNewFileGroupToProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddNewResourceFilesWithDialog();
            UpdateUI();
        }

        private void buttonMenuProjectFolderAddFileGroupToProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddNewResourceFilesWithDialog();
            UpdateUI();
        }

        private void buttonMenuProjectDeleteExistingLanguage_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteLanguageWithDialog();
        }

        private void buttonMenuProjectDeleteLanguages_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteLanguageWithDialog();
        }

        private void buttonMergeIntoFileGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            MergeFilesWithDialog();
        }
    }
}