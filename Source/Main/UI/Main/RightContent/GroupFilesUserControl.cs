namespace ZetaResourceEditor.UI.Main.RightContent
{
    using DevExpress.XtraBars;
    using DevExpress.XtraTab;
    using DevExpress.XtraTab.ViewInfo;
    using Helper.Base;
    using Properties;
    using RuntimeBusinessLogic.DL;
    using RuntimeBusinessLogic.FileGroups;
    using RuntimeBusinessLogic.Projects;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Tools.Storage;
    using ZetaLongPaths;

    public partial class GroupFilesUserControl :
        UserControlBase
    {
        public GroupFilesUserControl()
        {
            InitializeComponent();
        }

        private static ResourceEditorUserControl getFileGroupControlForTabPage(
            Control tabPage)
        {
            return (ResourceEditorUserControl)tabPage?.Controls[0];
        }

        internal ResourceEditorUserControl CurrentFileGroupControl
        {
            get
            {
                if (!mainTabControl.Visible ||
                    mainTabControl.SelectedTabPage == null)
                {
                    return null;
                }
                else
                {
                    return getFileGroupControlForTabPage(
                        mainTabControl.SelectedTabPage);
                }
            }
        }

        private IEnumerable<ResourceEditorUserControl> allFileGroupControls
        {
            get
            {
                var result = new List<ResourceEditorUserControl>();

                foreach (XtraTabPage tabPage in mainTabControl.TabPages)
                {
                    var t = getFileGroupControlForTabPage(tabPage);

                    if (t != null)
                    {
                        result.Add(t);
                    }
                }

                return result.ToArray();
            }
        }

        internal IEnumerable<IGridEditableData> GridEditableDatas
        {
            get
            {
                var groups = new List<IGridEditableData>();

                foreach (XtraTabPage tabPage in mainTabControl.TabPages)
                {
                    var control = getFileGroupControlForTabPage(tabPage);

                    if (control != null)
                    {
                        groups.Add(control.GridEditableData);
                    }
                }

                return groups.ToArray();
            }
        }

        public bool CanClose => CurrentFileGroupControl != null &&
                                CurrentFileGroupControl.CanClose;

        public bool CanResetLayout => CurrentFileGroupControl != null &&
                                      CurrentFileGroupControl.CanResetLayout;

        public bool CanCloseAllDocuments => mainTabControl.Visible && mainTabControl.TabPages.Count > 0;

        public bool CanOpenFolderOfCurrentResourceFile => mainTabControl.Visible && mainTabControl.SelectedTabPage != null &&
                                                          CurrentFileGroupControl.CanOpenFolder;

        /// <summary>
        /// Opens the with dialog.
        /// </summary>
        public void OpenWithDialog()
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

                var fileGroup =
                    FileGroup.CheckCreate(
                        MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                        ofd.FileNames);

                var editorControl =
                    checkGetAddEditorControl(fileGroup, out var isNew);

                editorControl.OpenWithDialog(fileGroup);
            }
        }

        /// <summary>
        /// Checks the get add editor control.
        /// </summary>
        /// <param name="gridEditableData">The file group.</param>
        /// <param name="isNew">if set to <c>true</c> [is new].</param>
        /// <returns></returns>
        private ResourceEditorUserControl checkGetAddEditorControl(
            IGridEditableData gridEditableData,
            out bool isNew)
        {
            var checksum = gridEditableData.GetChecksum(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);
            //FileGroup.BuildChecksum(
            //MainForm.Current.ProjectFilesControl.Project,
            //gridEditableData);

            foreach (XtraTabPage tabPage in mainTabControl.TabPages)
            {
                if (ConvertHelper.ToInt64(tabPage.Tag) == checksum)
                {
                    mainTabControl.SelectedTabPage = tabPage;
                    isNew = true;
                    return (ResourceEditorUserControl)tabPage.Controls[0];
                }
            }

            // --
            // Not found, add new.

            var newTabPage =
                new XtraTabPage
                {
                    Text = gridEditableData.GetNameIntelligent(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty),
                    Tooltip = gridEditableData.GetFullNameIntelligent(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty),
                    ImageIndex = (int)gridEditableData.SourceType,
                    Tag = checksum
                };

            var editorControl =
                new ResourceEditorUserControl
                {
                    Dock = DockStyle.Fill
                };

            newTabPage.Controls.Add(editorControl);

            mainTabControl.TabPages.Add(newTabPage);
            mainTabControl.Visible = true;
            mainTabControl.SelectedTabPage = newTabPage;

            isNew = false;
            return editorControl;
        }

        /// <summary>
        /// Does the load files.
        /// </summary>
        internal void DoLoadFiles(
            IGridEditableData gridEditableData,
            ILanguageColumnFilter filter)
        {
            var editorControl =
                checkGetAddEditorControl(gridEditableData, out var isNew);

            if (!isNew)
            {
                editorControl.DoLoadFiles(gridEditableData, filter);
            }
        }

        /// <summary>
        /// Closes the and save data grid.
        /// </summary>
        private bool closeAndSaveDataGrid(
            Control tabPage)
        {
            return closeAndSaveDataGrid(
                getFileGroupControlForTabPage(tabPage));
        }

        /// <summary>
        /// Closes the and save data grid.
        /// </summary>
        private bool closeAndSaveDataGrid(
            ResourceEditorUserControl fileGroupControl)
        {
            if (fileGroupControl == null)
            {
                return true;
            }
            else if (fileGroupControl.CloseAndSaveDataGrid())
            {
                var tabPage = (XtraTabPage)fileGroupControl.Parent;

                mainTabControl.TabPages.Remove(tabPage);
                tabPage.Dispose();

                if (mainTabControl.TabPages.Count <= 0)
                {
                    mainTabControl.Visible = false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Closes the and save data grid.
        /// </summary>
        public bool CloseAndSaveDataGrid()
        {
            return closeAndSaveDataGrid(CurrentFileGroupControl);
        }

        /// <summary>
        /// Edits the resource files.
        /// </summary>
        internal void EditResourceFiles(
            IGridEditableData gridEditableData,
            ILanguageColumnFilter filter)
        {
            var editorControl = checkGetAddEditorControl(gridEditableData, out var isNew);

            if (!isNew)
            {
                editorControl.DoLoadFiles(gridEditableData, filter);

                // --

                var files = string.Empty;

                foreach (var fileInfo in gridEditableData.GetFileInformationsSorted())
                {
                    if (files.Length > 0)
                    {
                        files += @";";
                    }

                    files += fileInfo.File.FullName;
                }

                // Immediately stores.
                MainForm.AddMruFiles(files);

                //if (gridEditableData.Project != null)
                //{
                //    gridEditableData.Project.AddMruElement(gridEditableData);
                //}
            }
        }

        /// <summary>
        /// Closes all documents.
        /// </summary>
        public void CloseAllDocuments()
        {
            while (CurrentFileGroupControl != null && CloseAndSaveDataGrid())
            {
                // Do nothing.
            }
        }

        /// <summary>
        /// Saves the recent files info.
        /// </summary>
        public void SaveRecentFilesInfo()
        {
            var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

            var text = string.Empty;

            if (project != null && project != Project.Empty)
            {
                project.ClearMruElements();
            }

            foreach (XtraTabPage tabPage in mainTabControl.TabPages)
            {
                var editorControl =
                    (ResourceEditorUserControl)tabPage.Controls[0];

                if (!string.IsNullOrEmpty(text))
                {
                    text += @"###***###";
                }

                if (editorControl.GridEditableData != null)
                {
                    text += editorControl.GridEditableData.JoinedFilePaths;
                }

                if (project != null && project != Project.Empty)
                {
                    project.AddMruElement(editorControl.GridEditableData);
                }
            }

            PersistanceHelper.SaveValue(
                MainForm.UserStorageIntelligent,
                @"RecentFiles",
                text);
        }

        /// <summary>
        /// Loads the recent files.
        /// </summary>
        public void LoadRecentFiles(
            Project project)
        {
            CloseAllDocuments();

            if (project == null)
            {
                var text = PersistanceHelper.RestoreValue(
                    MainForm.UserStorageIntelligent,
                    @"RecentFiles") as string;

                if (!string.IsNullOrEmpty(text))
                {
                    foreach (var filePathsRaw in text.Split(
                        new[] { @"###***###" },
                        StringSplitOptions.RemoveEmptyEntries))
                    {
                        var filePaths = new List<ZlpFileInfo>();

                        foreach (var filePath in filePathsRaw.Split(';'))
                        {
                            if (ZlpIOHelper.FileExists(filePath))
                            {
                                filePaths.Add(new ZlpFileInfo(filePath));
                            }
                        }

                        DoLoadFiles(
                            // TODO: Possible modify this function.
                            FileGroup.CheckCreate(
                                MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                                filePaths.ToArray()),
                            MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);
                    }
                }
            }
            else
            {
                foreach (var d in project.GetProjectMruItems())
                {
                    DoLoadFiles(d, project);
                }
            }
        }

        /// <summary>
        /// Saves the state.
        /// </summary>
        /// <returns></returns>
        internal bool SaveState(
            SaveOptions options)
        {
            foreach (XtraTabPage tabPage in mainTabControl.TabPages)
            {
                var editorControl = (ResourceEditorUserControl)tabPage.Controls[0];

                if (!editorControl.SaveState(options))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Saves the state.
        /// </summary>
        /// <returns></returns>
        internal bool SaveState()
        {
            SaveRecentFilesInfo();

            foreach (XtraTabPage tabPage in mainTabControl.TabPages)
            {
                var editorControl =
                    (ResourceEditorUserControl)tabPage.Controls[0];

                if (!editorControl.SaveState())
                {
                    return false;
                }
            }

            return true;
        }

        /*
				/// <summary>
				/// Tabs the control hit test.
				/// </summary>
				/// <param name="tabControl">The tab CTRL.</param>
				/// <param name="pt">The pt.</param>
				/// <returns></returns>
				private static int tabControlHitTest(
					XtraTabControl tabControl,
					Point pt )
				{
					// Test each tabs rectangle to see if our point is contained within it.
					for ( var x = 0; x < tabControl.TabPages.Count; ++x )
					{
						var tabPage = tabControl.TabPages[x];

						// If tab contians our rectangle return it's index.
						if ( tabControl.HeaderLocation.GetTabRect( x ).Contains( pt ) )
						{
							return x;
						}
					}

					// A tab was not located at specified point.
					return -1;
				}
		*/

        /// <summary>
        /// Update UI states, based on the state of the current selection, etc.
        /// </summary>
        public override void UpdateUI()
        {
            base.UpdateUI();

            buttonSave.Enabled =
                CanSave;
            buttonSaveAll.Enabled =
                true;
            buttonOpenFolder.Enabled =
                CanOpenFolderOfCurrentResourceFile;
            buttonClose.Enabled =
                CanClose;
            buttonCloseAllButThis.Enabled =
                canCloseAllButThis;
            buttonCloseAll.Enabled =
                CanCloseAllDocuments;
        }

        private bool canCloseAllButThis => mainTabControl.SelectedTabPage != null &&
                                           mainTabControl.TabPages.Count > 1;

        public bool CanSave => CurrentFileGroupControl != null &&
                               CurrentFileGroupControl.CanSave;

        #region Event handler.
        // ------------------------------------------------------------------

        private void optionsPopupMenu_BeforePopup(object sender, CancelEventArgs e)
        {
            UpdateUI();
        }

        private void buttonClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAndSaveDataGrid();
            UpdateUI();
        }

        private void buttonCloseAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllDocuments();
            UpdateUI();
        }

        private void buttonCloseAllButThis_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedTabIndex = mainTabControl.SelectedTabPageIndex;

            // Remove those before.
            for (var index = 0; index < selectedTabIndex; ++index)
            {
                var tabPage = mainTabControl.TabPages[0];

                if (!closeAndSaveDataGrid(tabPage))
                {
                    return;
                }
            }

            // Remove those after.
            while (mainTabControl.TabPages.Count > 1)
            {
                var tabPage = mainTabControl.TabPages[1];

                if (!closeAndSaveDataGrid(tabPage))
                {
                    return;
                }
            }

            // --

            UpdateUI();
        }

        private void buttonOpenFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurrentFileGroupControl.OpenFolder();
            UpdateUI();
        }

        private void buttonSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainForm.Current.SaveWithDialog(SaveOptions.None);
            UpdateUI();
        }

        private void buttonSaveAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainForm.Current.SaveAllWithDialog();
            UpdateUI();
        }

        private void mainTabControl_MouseUp(object sender, MouseEventArgs e)
        {
            // http://www.devexpress.com/Support/Center/KB/p/A915.aspx.

            if (e.Button == MouseButtons.Right &&
                ModifierKeys == Keys.None)
            {
                var pt = mainTabControl.PointToClient(MousePosition);
                var hi = mainTabControl.CalcHitInfo(pt);

                if (hi.HitTest == XtraTabHitTest.PageHeader ||
                    hi.HitTest == XtraTabHitTest.PageHeaderButtons)
                {
                    mainTabControl.SelectedTabPage = hi.Page;
                }

                optionsPopupMenu.ShowPopup(MousePosition);
            }
        }

        // ------------------------------------------------------------------
        #endregion

        public void ResetLayout()
        {
            foreach (var resourceEditorUserControl in allFileGroupControls)
            {
                resourceEditorUserControl.ResetLayout();
            }

            CloseAllDocuments();
        }
    }
}