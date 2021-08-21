namespace ZetaResourceEditor.UI.FileGroups
{
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Nodes;
    using ExtendedControlsLibrary.Skinning.CustomTreeList;
    using RuntimeBusinessLogic.FileGroups;
    using RuntimeBusinessLogic.ProjectFolders;
    using RuntimeBusinessLogic.Projects;
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class FileGroupSelectionControl :
        MyTreeList
    {
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.Utils.ImageCollection treeImageList;
        private System.ComponentModel.IContainer components;
        private FileGroup _ignoreFileGroup;
        private Project _project { get; set; }
        private Font _boldFont;

        private Font boldFont => _boldFont ??= new Font(Font, FontStyle.Bold);

        public FileGroupSelectionControl()
        {
            InitializeComponent();
        }

        private void treeView_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node.Tag is ProjectFolder)
            {
                e.Appearance.Font = boldFont;
            }
        }

        public void Initialize(Project project, FileGroup ignoreFileGroup)
        {
            _project = project;
            _ignoreFileGroup = ignoreFileGroup;

            fillFromProject();

            ExpandAll();
        }

        public FileGroup[] GetSelectedFileGroups()
        {
            var result = new List<FileGroup>();

            NodesIterator.DoOperation(node =>
            {
                if (node.Checked && node.Tag is FileGroup fileGroup)
                {
                    result.Add(fileGroup);
                }
            });

            return result.ToArray();
        }

        private void fillFromProject()
        {
            Nodes.Clear();

            if (_project != null)
            {
                var rootNode = AppendNode(new object[] { null }, null);

                rootNode[0] = _project.Name;
                rootNode.ImageIndex = rootNode.SelectImageIndex = getImageIndex(@"root");
                rootNode.Tag = _project;

                // --

                foreach (var fileGroup in _project.GetRootProjectFolders())
                {
                    addProjectFolderToTree(rootNode, fileGroup);
                }

                foreach (var fileGroup in _project.GetRootFileGroups())
                {
                    addFileGroupToTree(rootNode, fileGroup);
                }

                // --

                rootNode.Expanded = true;
            }
        }

        private static int getImageIndex(string key)
        {
            return key switch
            {
                @"root" => 0,
                @"group" => 1,
                @"file" => 2,
                @"projectfolder" => 3,
                _ => throw new ArgumentException()
            };
        }

        private void addProjectFolderToTree(TreeListNode parentNode,
            ProjectFolder projectFolder)
        {
            var projectFolderNode =
                AppendNode(
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
        }

        private void updateProjectFolderInTree(
            TreeListNode projectFolderNode,
            ProjectFolder projectFolder)
        {
            projectFolderNode[0] = projectFolder.Name;
            projectFolderNode.ImageIndex = projectFolderNode.SelectImageIndex = getImageIndex(@"projectfolder");
            projectFolderNode.Tag = projectFolder;
        }

        private void addFileGroupToTree(TreeListNode parentNode,
            FileGroup fileGroup)
        {
            if (_ignoreFileGroup != null && _ignoreFileGroup.UniqueID == fileGroup.UniqueID) return;

            var fileGroupNode =
                AppendNode(
                    new object[]
                    {
                        null
                    },
                    parentNode);

            // --

            updateFileGroupInTree(
                fileGroupNode,
                fileGroup);
        }

        private void updateFileGroupInTree(
            TreeListNode fileGroupNode,
            FileGroup fileGroup)
        {
            fileGroupNode[0] = fileGroup.GetNameIntelligent(_project);
            fileGroupNode.ImageIndex = fileGroupNode.SelectImageIndex = getImageIndex(@"group");
            fileGroupNode.Tag = fileGroup;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FileGroupSelectionControl));
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeImageList = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)this.treeImageList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            this.SuspendLayout();
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
            // treeImageList
            // 
            this.treeImageList.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("treeImageList.ImageStream");
            this.treeImageList.Images.SetKeyName(0, "root");
            this.treeImageList.Images.SetKeyName(1, "group");
            this.treeImageList.Images.SetKeyName(2, "file");
            this.treeImageList.Images.SetKeyName(3, "projectfolder");
            // 
            // FileGroupSelectionControl
            // 
            this.AllowDrop = true;
            this.Columns.AddRange(new[] {
            this.treeListColumn1});
            this.OptionsBehavior.AllowExpandOnDblClick = false;
            this.OptionsBehavior.AllowIncrementalSearch = true;
            this.OptionsBehavior.ImmediateEditor = false;
            this.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Single;
            this.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.OptionsView.FocusRectStyle = DrawFocusRectStyle.None;
            this.OptionsView.ShowCheckBoxes = true;
            this.OptionsView.ShowColumns = false;
            this.OptionsView.ShowHorzLines = false;
            this.OptionsView.ShowIndicator = false;
            this.OptionsView.ShowRoot = false;
            this.OptionsView.ShowVertLines = false;
            this.SelectImageList = this.treeImageList;
            this.NodeCellStyle += this.treeView_NodeCellStyle;
            this.AfterCheckNode += this.FileGroupSelectionControl_AfterCheckNode;
            ((System.ComponentModel.ISupportInitialize)this.treeImageList).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            this.ResumeLayout(false);

        }

        public event EventHandler NodeChecked;

        private void FileGroupSelectionControl_AfterCheckNode(object sender, NodeEventArgs e)
        {
            // Dieser Handler hier wird wohl nur für manuell, durch den Benutzer ausgelöste
            // Checks aufgerufen.

            // Untergeordnete Knoten weitergeben.
            if (e.Node.Tag.GetType() == typeof(Project) ||
                e.Node.Tag.GetType() == typeof(ProjectFolder))
            {
                NodesIterator.DoLocalOperation(
                    node =>
                    {
                        node.Checked = e.Node.Checked;
                    },
                    new TreeListNodes(this) {e.Node});
            }

            NodeChecked?.Invoke(this, EventArgs.Empty);
        }
    }
}