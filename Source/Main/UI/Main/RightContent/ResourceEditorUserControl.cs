namespace ZetaResourceEditor.UI.Main.RightContent;

#region Using directives.

// ----------------------------------------------------------------------

using DevExpress.Data;
using DevExpress.Skins;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraTab;
using ExtendedControlsLibrary.General.Base;
using Helper.Base;
using Helper.Grid;
using Helper.Progress;
using Properties;
using Runtime;
using RuntimeBusinessLogic.BL;
using RuntimeBusinessLogic.DL;
using RuntimeBusinessLogic.FileGroups;
using RuntimeBusinessLogic.Language;
using RuntimeBusinessLogic.Projects;
using System.Data;
using System.Linq;
using Code;
using TagOperations;
using Tools;

// ----------------------------------------------------------------------

#endregion

public partial class ResourceEditorUserControl :
    UserControlBase
{
    public ResourceEditorUserControl()
    {
        InitializeComponent();

        tabControl1.Images = ImageCollectionHelper.Ic16;
    }

    private void resourceEditorUserControlNew_SizeChanged(object sender, EventArgs e)
    {
        // Restore the size of the spliter after finally having
        // loaded and layouted.
        if (_isLoaded && !_restoredSplitContainer)
        {
            _restoredSplitContainer = true;
            restoreSplitterState();
        }

        Trace.WriteLine(@"SizeChanged");
    }

    private void resourceEditorUserControlNew_Load(object sender, EventArgs e)
    {
        MainForm.Current.Closing += current_Closing;

        //WinFormsPersistanceHelper.RestoreState(tabControl1);

        _findText = ConvertHelper.ToString(
            PersistanceHelper.RestoreValue(@"FindText"));

        mainDataGrid.Focus();
        mainDataGrid.Select();

        _isLoaded = true;
        Trace.WriteLine(@"Load");
    }

    private void current_Closing(object sender, CancelEventArgs e)
    {
        if (!SaveState())
        {
            e.Cancel = true;
        }
    }

    private void updateInGridButton_Click(object sender, EventArgs e)
    {
        updateGridFromDetails(selectedRowHandle);
    }

    private DataRowView selectedRow
    {
        get
        {
            var h = selectedRowHandle;
            if (h == -1)
            {
                return null;
            }
            else
            {
                return (DataRowView)mainGridView.GetRow(h);
            }
        }
    }

    private int selectedRowHandle
    {
        get
        {
            var cells = mainGridView.GetSelectedCells();
            if (cells.Length > 0)
            {
                return cells[0].RowHandle;
            }
            else
            {
                var rows = mainGridView.GetSelectedRows();
                if (rows.Length > 0)
                {
                    return rows[0];
                }
                else
                {
                    return -1;
                }
            }
        }
    }

    private IEnumerable<int> selectedRowHandles
    {
        get
        {
            var result = new HashSet<int>();

            var cells = mainGridView.GetSelectedCells();
            if (cells.Length > 0)
            {
                foreach (var cell in cells)
                {
                    result.Add(cell.RowHandle);
                }
            }
            else
            {
                var rows = mainGridView.GetSelectedRows();

                foreach (var row in rows)
                {
                    result.Add(row);
                }
            }

            return result.ToArray();
        }
    }

    private bool hasSelectedRow => selectedRowHandle != -1;

    private void mainDataView_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
        // Ignore during closing.
        if (mainDataGrid.DataSource != null)
        {
            adjustCellColor(e);
        }
    }

    private void mainDataView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
        // Ignore during closing.
        if (mainDataGrid.DataSource != null)
        {
            startDoUpdateDetails();
        }
    }

    private void mainDataView_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
    {
        // Ignore during closing.
        if (mainDataGrid.DataSource != null)
        {
            startDoUpdateDetails();
        }
    }

    private void mainDataView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Ignore during closing.
        if (mainDataGrid.DataSource != null)
        {
            startDoUpdateDetails();
        }
    }

    private void doUpdateDetails()
    {
        if (_allowUpdatingDetails)
        {
            var newCurrentRowIndex = selectedRowHandle;

            // --

            // Must put details back to grid.
            if (_currentRowIndex >= 0 && newCurrentRowIndex >= 0 &&
                newCurrentRowIndex != _currentRowIndex)
            {
                updateGridFromDetails(_currentRowIndex);
            }

            // --

            _currentRowIndex = newCurrentRowIndex;

            updateDetailsFromGrid();
        }
    }

    private DataProcessing _data;
    private bool _allowUpdatingDetails = true;

    internal DialogResult DoSaveFiles(
        SaveOptions options)
    {
        if ((options & SaveOptions.OnlyIfModified) == 0 ||
            _isGridContentModified)
        {
            var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

            var createBackups =
                project is { CreateBackupFiles: true };
            var omitEmptyStrings =
                project is { OmitEmptyItems: true };

            using (new WaitCursor(this))
            {
                var dataSource = (DataTable)mainDataGrid.DataSource;

                if ((options & SaveOptions.AskConfirm) == 0)
                {
                    var use = dataSource.Rows.Count > 150;

                    using (new BackgroundWorkerLongProgressGui(
                               delegate
                               {
                                   _data.SaveDataTableToResxFiles(
                                       project,
                                       dataSource,
                                       createBackups,
                                       omitEmptyStrings);
                               },
                               Resources.ResourceEditorUserControl_DoSaveFiles_Saving_files__please_wait___,
                               use,
                               BackgroundWorkerLongProgressGui.CancellationMode.NotCancelable,
                               FindForm()))
                    {
                    }

                    // --

                    if (!use)
                    {
                        _data.SaveDataTableToResxFiles(
                            project,
                            dataSource,
                            createBackups,
                            omitEmptyStrings);
                    }

                    // --

                    markDetailsContentAsUnmodified(); // 2009-08-25, Uwe Keim.
                    markGridContentAsUnmodified();

                    return DialogResult.OK;
                }
                else
                {
                    var r2 =
                        XtraMessageBox.Show(
                            Resources.SR_MainForm_DoSaveFiles_SaveChangesToTheResourceFiles,
                            @"Zeta Resource Editor",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                    switch (r2)
                    {
                        case DialogResult.Yes:
                            _data.SaveDataTableToResxFiles(
                                project,
                                dataSource,
                                createBackups,
                                omitEmptyStrings);

                            markDetailsContentAsUnmodified(); // 2009-08-25, Uwe Keim.
                            markGridContentAsUnmodified();

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

    private void markGridContentAsUnmodified()
    {
        _isGridContentModified = false;
        notifyModifyStateChanged();
    }

    public bool IsModified => _isDetailsContentModified || _isGridContentModified;

    internal bool OpenWithDialog(
        FileGroup fileGroup)
    {
        var r = DoSaveFiles(
            SaveOptions.OnlyIfModified |
            SaveOptions.AskConfirm);

        if (r == DialogResult.OK)
        {
            DoLoadFiles(fileGroup, fileGroup.Project);

            // Immediately stores.
            MainForm.AddMruFiles(fileGroup.JoinedFilePaths);

            GridEditableData = fileGroup;
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Does the load files.
    /// </summary>
    internal void DoLoadFiles(
        IGridEditableData gridEditableData,
        ILanguageColumnFilter filter)
    {
        closeDataGrid();

        GridEditableData = gridEditableData;
        _data = new DataProcessing(gridEditableData);

        // ReSharper disable ConvertIfStatementToConditionalTernaryExpression
        if (gridEditableData.GetFileInformationsSorted().Length > 0)
            // ReSharper restore ConvertIfStatementToConditionalTernaryExpression
        {
            fileNameTextEdit.Text = gridEditableData.FolderPath.FullName;
        }
        else
        {
            fileNameTextEdit.Text = null;
        }

        tabControl1.TabPages.Clear();

        var table = _data.GetDataTableFromResxFiles(gridEditableData.Project);

        if (table == null)
        {
            CloseAndSaveDataGrid();
        }
        else
        {
            // Column 0=FileGroup checksum, column 1=Tag name.
            for (var i = 2; i < table.Columns.Count; ++i)
            {
                var imageIndex =
                    DataProcessing.CommentsAreVisible(
                        gridEditableData.Project,
                        table,
                        CommentVisibilityScope.VisualGrid) &&
                    i == table.Columns.Count - 1
                        ? 1
                        : 0;

                addDetailTabPage(
                    filter,
                    imageIndex == 1
                        ? Resources.SR_ColumnCaption_Comment
                        : table.Columns[i].Caption,
                    imageIndex == 1
                        ? string.Empty
                        : DataProcessing.ExtractCultureNameFromColumnCaption(table.Columns[i].Caption));
            }
        }

        // --

        mainDataGrid.DataSource = table;
        mainDataGrid.MainView.PopulateColumns();
        filterColumns(
            filter,
            DataProcessing.CommentsAreVisible(
                gridEditableData.Project,
                table,
                CommentVisibilityScope.VisualGrid));
        postpareStructure();

        FormBase.RestoreState(tabControl1);

        UpdateUI();

        restoreGridLayout();
        restoreSplitterState();

        // Initially.
        markGridContentAsUnmodified();
        markDetailsContentAsUnmodified();
        _currentRowIndex = -1;
        _canSaveGridLayout = true;

        // --

        updateStateImage();
    }

    private void filterColumns(
        ILanguageColumnFilter filter,
        bool commentsAreVisible)
    {
        // Column 0=FileGroup checksum, column 1=Tag name.
        // Always hide checksum.
        mainGridView.Columns[0].Visible = false;

        // --

        if (filter is { HasLanguageToDisplayFilter: true })
        {
            // http://www.devexpress.com/Support/Center/p/Q93654.aspx

            var index = 0;
            foreach (GridColumn column in mainGridView.Columns)
            {
                if (index > 1) // Column 0=FileGroup checksum, column 1=Tag name.
                {
                    if (commentsAreVisible && index <= mainGridView.Columns.Count - 2 ||
                        !commentsAreVisible && index <= mainGridView.Columns.Count - 1)
                    {
                        var languageName =
                            DataProcessing.ExtractCultureNameFromColumnCaption(column.GetCaption());

                        if (!string.IsNullOrEmpty(languageName))
                        {
                            if (!filter.WantDisplayLanguageColumnInGrid(languageName))
                            {
                                column.Visible = false;
                            }
                        }
                    }
                }

                index++;
            }
        }
    }

    private void postpareStructure()
    {
        var meRepositoryItem =
            new RepositoryItemMemoEdit
            {
                ReadOnly = true,
                AutoHeight = true,
                AcceptsReturn = false,
                AcceptsTab = false,
            };
        mainDataGrid.RepositoryItems.Add(meRepositoryItem);

        var me =
            new RepositoryItemMemoEdit
            {
                AutoHeight = true,
                AcceptsReturn = false,
                AcceptsTab = false,
            };
        mainDataGrid.RepositoryItems.Add(me);
        me.KeyDown += me_KeyDown;

        var meRtl =
            new RtlRepositoryItemMemoEdit
            {
                AutoHeight = true,
                AcceptsReturn = false,
                AcceptsTab = false,
            };
        mainDataGrid.RepositoryItems.Add(meRtl);
        meRtl.KeyDown += me_KeyDown;

        var index = 0;
        foreach (GridColumn column in mainGridView.Columns)
        {
            if (column.Visible)
            {
                // ReSharper disable ConvertIfStatementToConditionalTernaryExpression
                if (index == 0)
                    // ReSharper restore ConvertIfStatementToConditionalTernaryExpression
                {
                    column.ColumnEdit = meRepositoryItem;
                }
                else
                {
                    var languageCode = DataProcessing.ExtractCultureNameFromColumnCaption(column.GetCaption());

                    var isRtl =
                        !StringExtensionMethods.IsNullOrWhiteSpace(languageCode) &&
                        CultureHelper.CreateCultureErrorTolerant(languageCode).TextInfo.IsRightToLeft;
                    column.ColumnEdit = isRtl ? meRtl : me;
                }

                index++;
            }
        }
    }

    private static void me_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Shift && e.KeyCode == Keys.Enter)
        {
            var me = (MemoEdit)sender;

            me.SelectedText = Environment.NewLine;
            e.Handled = true;
        }
    }

    private void addDetailTabPage(
        ILanguageColumnFilter filter,
        string name,
        string languageCode)
    {
        var tabPage =
            new XtraTabPage
            {
                Text = name,
                ImageIndex = -1,
            };
        tabControl1.TabPages.Add(tabPage);

        if (!string.IsNullOrEmpty(languageCode))
        {
            if (filter != null && !filter.WantDisplayLanguageColumnInGrid(languageCode))
            {
                tabPage.PageVisible = false;
            }
        }

        var textBox = new MemoEdit();
        textBox.TextChanged += textBox_TextChanged;
        textBox.KeyDown += textBox_KeyDown;
        textBox.Name = @"ColumnText";
        tabPage.Controls.Add(textBox);

        if (!StringExtensionMethods.IsNullOrWhiteSpace(languageCode))
        {
            var isRtl = CultureHelper.CreateCultureErrorTolerant(languageCode).TextInfo.IsRightToLeft;
            if (isRtl)
            {
                textBox.RightToLeft = RightToLeft.Yes;
            }
        }

        textBox.Properties.AcceptsReturn = true;
        textBox.Properties.AcceptsTab = true;
        textBox.AllowDrop = true;
        textBox.Dock = DockStyle.Fill;
        textBox.Properties.HideSelection = false;
        textBox.Properties.ScrollBars = ScrollBars.Vertical;
        textBox.TabIndex = 0;

        // --
        // Spell checker.

        var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

        if (project is { UseSpellChecker: true })
        {
            var culture =
                new LanguageCodeDetection(project).DetectCultureFromFileName(
                    GridEditableData.ParentSettings,
                    name);

            var spellChecker = CultureHelper.CreateSpellChecker(culture);
            if (spellChecker != null)
            {
                spellChecker.ParentContainer = textBox;
                spellChecker.SetShowSpellCheckMenu(textBox, true);
            }
        }
    }

    private static void textBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.A)
        {
            ((MemoEdit)sender).SelectAll();
            e.Handled = true;
        }
    }

    private void textBox_TextChanged(
        object sender,
        EventArgs e)
    {
        markDetailsContentAsModified();
        UpdateUI();
    }

    /// <summary>
    /// Occurs when [modify state changed].
    /// </summary>
    public event EventHandler ModifyStateChanged;

    public void MarkAsModified()
    {
        markDetailsContentAsModified();
        UpdateUI();
    }

    private void markDetailsContentAsModified()
    {
        _isDetailsContentModified = true;
        notifyModifyStateChanged();
    }

    /// <summary>
    /// Notifies the modify state changed.
    /// </summary>
    private void notifyModifyStateChanged()
    {
        ModifyStateChanged?.Invoke(this, EventArgs.Empty);

        // --

        if (GridEditableData != null)
        {
            var tabPage = (XtraTabPage)Parent;

            var text = GridEditableData.GetNameIntelligent(
                MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);

            if (IsModified)
            {
                text += @" " + Project.ModifiedChar;
            }

            tabPage.Text = text;
        }
    }

    /// <summary>
    /// Renames the tag.
    /// </summary>
    public void RenameTag()
    {
        var rowHandle = selectedRowHandle;

        using var form = new RenameTagForm(DistinctTagNames);
        var oldName = mainGridHelper.GetRowCellValue(rowHandle, 1) as string;
        form.TagName = oldName;

        if (form.ShowDialog(this) == DialogResult.OK)
        {
            var newName = form.TagName;

            //--
            // Rename visually.

            // Column 0=FileGroup checksum, column 1=Tag name.
            mainGridHelper.SetRowCellValue(rowHandle, 1, newName);

            // --
            // Rename in Dataobject

            _data.RenameTag(
                oldName,
                newName);

            MarkGridContentAsModified();
            UpdateUI();
        }
    }

    public void MarkGridContentAsModified()
    {
        _isGridContentModified = true;
        notifyModifyStateChanged();
    }

    /// <summary>
    /// Deletes the tag.
    /// </summary>
    public void DeleteTag()
    {
        if (XtraMessageBox.Show(
                this,
                Resources
                    .SR_MainForm_deleteTagToolStripMenuItemClick_DoYouReallyWantToDeleteTheTagAndAllOfItsTranslations,
                @"Zeta Resource Editor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            ) == DialogResult.Yes)
        {
            var rowHandles = new List<int>(selectedRowHandles);
            rowHandles.Sort((x, y) => -x.CompareTo(y));

            foreach (var rowHandle in rowHandles)
            {
                var row = (DataRowView)mainGridView.GetRow(rowHandle);
                // Column 0=FileGroup checksum, column 1=Tag name.
                var tagName = mainGridHelper.GetRowCellValue<string>(rowHandle, 1);

                // Remove visually.
                row.Delete();

                // Remove from the DataObject
                _data.DeleteTag(tagName);
            }

            MarkGridContentAsModified();
            UpdateUI();
        }
    }

    public void AddTag()
    {
        using var form = new AddTagForm(DistinctTagNames);
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            var newTagName = form.TagName;

            //--
            // Add visually.

            var dataRow = createNewDataRow();
            // Column 0=FileGroup checksum, column 1=Tag name.
            dataRow[0] =
                GridEditableData.GetChecksum(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);
            dataRow[1] = newTagName;
            ((DataTable)mainDataGrid.DataSource).Rows.Add(dataRow);

            // --
            // Add to DataObject

            _data.AddTag(
                newTagName);

            MarkGridContentAsModified();
            UpdateUI();
        }
    }

    /// <summary>
    /// Save the files and clear the Grid and the other resources.
    /// </summary>
    private void closeDataGrid()
    {
        if (GridEditableData != null)
        {
            saveSplitterState();
            saveGridLayout();

            GridEditableData = null;
            _data = null;

            mainDataGrid.DataSource = null;
            mainDataGrid.Refresh();

            UpdateUI();
        }

        fileNameTextEdit.Text = null;
    }

    /// <summary>
    /// Updates the UserControls
    /// </summary>
    public override void UpdateUI()
    {
        base.UpdateUI();

        buttonAddTag.Enabled =
            CanAddTag;
        buttonDeleteTag.Enabled =
            CanDeleteTag;
        buttonEditTag.Enabled = CanRenameTag;

        buttonSelectAllInGrid.Enabled =
            mainGridView.RowCount > 0;
        buttonCopySelectedRowsToClipboard.Enabled =
            mainGridView.SelectedRowsCount > 0;
        buttonDeleteRowContents.Enabled =
            mainGridView.SelectedRowsCount > 0;
    }

    /// <summary>
    /// Get a list of all distinct tag names.
    /// </summary>
    public List<string> DistinctTagNames
    {
        get
        {
            var result = new List<string>();

            for (var i = 0; i < mainGridView.RowCount; ++i)
            {
                var row = (DataRowView)mainGridView.GetRow(i);
                // Column 0=FileGroup checksum, column 1=Tag name.
                var s = row[1] as string;

                if (!string.IsNullOrEmpty(s))
                {
                    result.Add(s);
                }
            }

            return result;
        }
    }

    public bool CanSave => _data != null;

    public bool CanResetLayout => _data != null;

    public bool CanClose => _data != null;

    public bool CanAddTag => _data != null &&
                             // Only allow to add when file group because otherwise
                             // it cannot be determined for which file group to add.
                             GridEditableData is { SourceType: GridSourceType.FileGroup };

    public bool CanDeleteTag => _data != null && hasSelectedRow;

    public bool CanRenameTag => _data != null && hasSelectedRow;

    public bool CanAutoTranslateMissingTranslations => _data != null && mainGridView.Columns.Count > 2;

    public bool CanOpenFolder => _data != null;

    public bool CanFind => _data != null;

    public bool CanFindNext => _data != null &&
                               !string.IsNullOrEmpty(_findText);

    internal IGridEditableData GridEditableData { get; private set; }

    public DataTable GetDataSource()
    {
        return (DataTable)mainDataGrid.DataSource;
    }

    /// <summary>
    /// 
    /// </summary>
    private DataRow createNewDataRow()
    {
        var table = (DataTable)mainDataGrid.DataSource;
        return table.NewRow();
    }

    private void saveGridLayout()
    {
        if (_canSaveGridLayout)
        {
            var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;
            if (project != null && layoutSerializer != null)
            {
                using (new SilentProjectStoreGuard(project))
                {
                    layoutSerializer.Save();
                }
            }
        }
    }

    private AllLayoutSerializer layoutSerializer
    {
        get
        {
            if (_layoutSerializer == null)
            {
                var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;
                if (project is { PersistGridSettings: true })
                {
                    _layoutSerializer =
                        new AllLayoutSerializer(
                            mainGridView,
                            project.DynamicSettingsGlobalHierarchical,
                            @"ResourceEditorGrid");
                }
            }

            return _layoutSerializer;
        }
    }

    private void restoreGridLayout()
    {
        var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;
        if (project != null)
        {
            layoutSerializer?.Restore();
        }
    }

    private void updateDetailsFromGrid()
    {
        if (hasSelectedRow && selectedRow != null)
        {
            updateInGridButton.Enabled = true;
            var row = selectedRow;

            // Column 0=FileGroup checksum, column 1=Tag name.
            labelControl1.Text = (string)row[1];

            // Column 0=FileGroup checksum, column 1=Tag name.
            for (var i = 2; i < mainGridView.Columns.Count; ++i)
            {
                var page = tabControl1.TabPages[i - 2];
                var text = row[i] as string;

                var columnText =
                    (MemoEdit)page.Controls[@"ColumnText"];

                columnText.Text = DataProcessing.AdjustLineBreaks(text);
                columnText.Enabled = true;
            }
        }
        else
        {
            updateInGridButton.Enabled = false;
            labelControl1.Text = string.Empty;

            foreach (XtraTabPage page in tabControl1.TabPages)
            {
                var columnText =
                    (MemoEdit)page.Controls[@"ColumnText"];

                columnText.Text = string.Empty;
                columnText.Enabled = false;
            }
        }

        // Reset flag.
        markDetailsContentAsUnmodified();
    }

    public void ResetLayout()
    {
        _canSaveGridLayout = false;

        mainGridView.ClearColumnsFilter();
        mainGridView.ClearGrouping();
        mainGridView.ClearSorting();

        var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;
        if (project != null && layoutSerializer != null)
        {
            using (new SilentProjectStoreGuard(project))
            {
                layoutSerializer.Reset();
            }
        }

        UpdateUI();
    }

    private bool _isGridContentModified;
    private bool _isDetailsContentModified;

    private void updateGridFromDetails(
        int rowIndex)
    {
        if (_isDetailsContentModified)
        {
            var row =
                (DataRowView)
                mainGridView.GetRow(rowIndex);

            // Column 0=FileGroup checksum, column 1=Tag name.
            for (var i = 2; i < mainGridView.Columns.Count; ++i)
            {
                var page = tabControl1.TabPages[i - 2];
                var columnText =
                    (MemoEdit)page.Controls[@"ColumnText"];

                row[i] = DataProcessing.AdjustLineBreaks(columnText.Text.Trim());
            }

            MarkGridContentAsModified();
        }

        markDetailsContentAsUnmodified();
    }

    private void markDetailsContentAsUnmodified()
    {
        _isDetailsContentModified = false;
        notifyModifyStateChanged();
    }

    private void mainDataView_CellValueChanged(
        object sender,
        CellValueChangedEventArgs e)
    {
        // Ignore during closing.
        if (mainDataGrid.DataSource != null)
        {
            MarkGridContentAsModified();

            // --

            var rowHandle = selectedRowHandle;

            // Force all other cells in this row to redraw.
            // Column 0=FileGroup checksum, column 1=Tag name.
            for (var i = 2; i < mainGridView.Columns.Count; ++i)
            {
                if (i != e.Column.AbsoluteIndex)
                {
                    mainGridView.InvalidateRowCell(rowHandle, mainGridView.Columns[i]);
                }
            }

            // --

            var state = updateStateImage();
            GridEditableData.InMemoryState = state;
            MainForm.Current.NotifyFileGroupStateChanged(GridEditableData);
        }
    }

    private void adjustCellColor(
        RowCellStyleEventArgs e)
    {
        // http://www.devexpress.com/Support/Center/KB/p/A2753.aspx
        var currentSkin = CommonSkins.GetSkin(
            DevExpress.LookAndFeel.UserLookAndFeel.Default);

        var row =
            (DataRowView)
            mainGridView.GetRow(e.RowHandle);

        var isRowSelected = e.RowHandle == selectedRowHandle;

        // --

        if (DataProcessing.CommentsAreVisible(
                MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                row.Row,
                CommentVisibilityScope.VisualGrid) &&
            e.Column.AbsoluteIndex == mainGridView.Columns.Count - 1)
        {
            // Reset.
            e.Appearance.ForeColor =
                isRowSelected
                    ? currentSkin.TranslateColor(SystemColors.HighlightText)
                    : currentSkin.TranslateColor(GridColors.CommentForeColor);
        }
        else
        {
            // Reset.
            e.Appearance.ForeColor =
                isRowSelected
                    ? currentSkin.TranslateColor(SystemColors.HighlightText)
                    : currentSkin.TranslateColor(SystemColors.WindowText);
        }

        // --

        switch (e.Column.AbsoluteIndex)
        {
            case 0:
                // Column 0=FileGroup checksum, column 1=Tag name.

                // Do nothing.
                break;
            case 1 when isCompleteRowEmpty(row):
                e.Appearance.Font = italicFont;
                e.Appearance.ForeColor =
                    isRowSelected
                        ? currentSkin.TranslateColor(SystemColors.HighlightText)
                        : currentSkin.TranslateColor(GridColors.CompleteRowEmptyForeColor);
                break;
            case 1:
                e.Appearance.Font = regularFont;
                e.Appearance.ForeColor =
                    isRowSelected
                        ? currentSkin.TranslateColor(SystemColors.HighlightText)
                        : currentSkin.TranslateColor(GridColors.TagNameForeColor);
                break;
            default:
            {
                // --
                // Make empty cells colored.

                if (ConvertHelper.ToString(e.CellValue, string.Empty).Trim().Length <= 0)
                {
                    if (!isRowSelected)
                    {
                        if (isCompleteRowEmpty(row))
                        {
                            e.Appearance.ForeColor =
                                currentSkin.TranslateColor(GridColors.CompleteRowEmptyForeColor);

                            var color =
                                currentSkin.TranslateColor(
                                    SystemColors.ControlLight);

                            e.Appearance.BackColor = color;
                            e.Appearance.BackColor2 = color;
                        }
                        else
                        {
                            if (!DataProcessing.CommentsAreVisible(
                                    MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                                    row.Row,
                                    CommentVisibilityScope.VisualGrid) ||
                                e.Column.AbsoluteIndex != mainGridView.Columns.Count - 1)
                            {
                                var color =
                                    currentSkin.TranslateColor(
                                        GridColors.EmptyCellBackColor);

                                // http://www.codeproject.com/Messages/3403105/Re-Null-vs-empty-resource-value.aspx
                                if (e.CellValue == null || DBNull.Value == e.CellValue)
                                {
                                    if (colorifyNullValues)
                                    {
                                        color = GridColors.NullCellBackColor;
                                    }
                                }

                                e.Appearance.BackColor = color;
                                e.Appearance.BackColor2 = color;
                            }
                        }
                    }
                }

                // --
                // Make rows with different number of placeholders colored.

                // AJ CHANGE, don't count the comments column.
                // Column 0=FileGroup checksum, column 1=Tag name.
                if (e.Column.AbsoluteIndex > 1)
                {
                    var comments =
                        DataProcessing.CommentsAreVisible(
                            MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                            row.Row,
                            CommentVisibilityScope.VisualGrid);

                    if (mainGridView.Columns.Count > (comments ? 3 : 2))
                    {
                        var neutralCode = neutralLanguageCode;
                        var neutralColumnIndex = findColumnIndex(row.Row.Table, neutralCode, 2);

                        var firstColumnContent = ConvertHelper.ToString(row[neutralColumnIndex]);

                        var firstPlaceholderCount =
                            FileGroup.ExtractPlaceholders(firstColumnContent);

                        // 2010-10-23, Uwe Keim: Check all others, too.
                        var yes = false;
                        for (var i = 1 + 1; i < mainGridView.Columns.Count - (comments ? 1 : 0); i++)
                        {
                            if (i != neutralColumnIndex)
                            {
                                var columnContent = ConvertHelper.ToString(row[i]);

                                // 2011-11-16, Uwe Keim: Only check if non-empty, non-default-language.
                                if (!string.IsNullOrEmpty(columnContent))
                                {
                                    var other = FileGroup.ExtractPlaceholders(columnContent);

                                    if (other != firstPlaceholderCount)
                                    {
                                        yes = true;
                                        break;
                                    }
                                }
                            }
                        }

                        if (yes)
                        {
                            e.Appearance.ForeColor =
                                isRowSelected
                                    ? currentSkin.TranslateColor(SystemColors.HighlightText)
                                    : currentSkin.TranslateColor(GridColors.PlaceHolderMismatchForeColor);
                        }
                    }
                }

                // --
                // Make translated cells that need to be reviewed different color.

                // Column 0=FileGroup checksum, column 1=Tag name.
                if (e.Column.AbsoluteIndex > 1)
                {
                    var value =
                        ConvertHelper.ToString(e.CellValue);

                    switch (string.IsNullOrEmpty(value))
                    {
                        case false when value.StartsWith(FileGroup.DefaultTranslatedPrefix):
                            e.Appearance.ForeColor =
                                isRowSelected
                                    ? currentSkin.TranslateColor(SystemColors.HighlightText)
                                    : currentSkin.TranslateColor(GridColors.TranslationSuccessForeColor);
                            e.Appearance.Font = boldFont;
                            break;
                        case false when value.StartsWith(FileGroup.DefaultTranslationErrorPrefix):
                            e.Appearance.ForeColor =
                                isRowSelected
                                    ? currentSkin.TranslateColor(SystemColors.HighlightText)
                                    : currentSkin.TranslateColor(GridColors.TranslationErrorForeColor);
                            e.Appearance.Font = boldFont;
                            break;
                        default:
                            e.Appearance.Font = regularFont;
                            break;
                    }
                }

                break;
            }
        }
    }

    protected string neutralLanguageCode
    {
        get
        {
            var p = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;
            var s = p == null ? @"en-US" : p.NeutralLanguageCode;
            return s;
        }
    }

    private static int findColumnIndex(
        DataTable table,
        string columnName,
        int fallbackIndex)
    {
        if (string.IsNullOrEmpty(columnName))
        {
            return fallbackIndex;
        }
        else
        {
            foreach (DataColumn column in table.Columns)
            {
                if (string.Compare(column.ColumnName, columnName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return column.Ordinal;
                }
            }

            return fallbackIndex;
        }
    }

    private static bool colorifyNullValues
    {
        get
        {
            var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;
            return project is { ColorifyNullCells: true };
        }
    }

    /// <summary>
    /// Gets the bold font.
    /// </summary>
    /// <value>The bold font.</value>
    private Font boldFont
    {
        get
        {
            // ReSharper disable ConvertIfStatementToNullCoalescingExpression
            if (_boldFont == null)
                // ReSharper restore ConvertIfStatementToNullCoalescingExpression
            {
                _boldFont = new Font(Font, FontStyle.Bold);
            }

            return _boldFont;
        }
    }

    private Font regularFont
    {
        get
        {
            // ReSharper disable ConvertIfStatementToNullCoalescingExpression
            if (_regularFont == null)
                // ReSharper restore ConvertIfStatementToNullCoalescingExpression
            {
                _regularFont = new Font(Font, FontStyle.Regular);
            }

            return _regularFont;
        }
    }

    private Font italicFont
    {
        get
        {
            // ReSharper disable ConvertIfStatementToNullCoalescingExpression
            if (_italicFont == null)
                // ReSharper restore ConvertIfStatementToNullCoalescingExpression
            {
                _italicFont = new Font(Font, FontStyle.Italic);
            }

            return _italicFont;
        }
    }

    /*
            private Font boldItalicFont
            {
                get
                {
                    // ReSharper disable ConvertIfStatementToNullCoalescingExpression
                    if (_boldItalicFont == null)
                    // ReSharper restore ConvertIfStatementToNullCoalescingExpression
                    {
                        _boldItalicFont = new Font(Font, FontStyle.Bold | FontStyle.Italic);
                    }

                    return _boldItalicFont;
                }
            }
    */

    private bool isCompleteRowTranslated(DataRowView row)
    {
        if (row == null)
        {
            return false;
        }
        else
        {
            var sub = DataProcessing.CommentsAreVisible(
                MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                row.Row,
                CommentVisibilityScope.VisualGrid)
                ? 1
                : 0;

            // Check both, grid and underlying table, because depending
            // on the loading stage of the grid, the grid can still be empty.

            var neutralCode = neutralLanguageCode;
            var neutralColumnIndex = findColumnIndex(row.Row.Table, neutralCode, 2);

            var ss = new List<string>();

            if (mainGridView?.Columns != null)
            {
                // Column 0=FileGroup checksum, column 1=Tag name.
                for (var i = 2; i < mainGridView.Columns.Count - sub; ++i)
                {
                    ss.Add(ConvertHelper.ToString(row[i], string.Empty).Trim());
                }
            }

            // --

            if (ss.Count <= 0)
            {
                // Column 0=FileGroup checksum, column 1=Tag name.
                for (var i = 2; i < row.Row.Table.Columns.Count - sub; ++i)
                {
                    ss.Add(ConvertHelper.ToString(row[i], string.Empty).Trim());
                }
            }

            return coreIsCompleteRowTranslated(ss.ToArray(), neutralColumnIndex - 2);
        }
    }

    private static bool coreIsCompleteRowTranslated(
        IList<string> ss,
        int neutralColumnIndex)
    {
        if (ss.Count == 1)
        {
            return !string.IsNullOrEmpty(ss[0]);
        }
        else
        {
            if (string.IsNullOrEmpty(ss[0]))
            {
                return false;
            }
            else
            {
                var lastPlaceholderCount = FileGroup.ExtractPlaceholders(ss[neutralColumnIndex]);

                for (var i = 1; i < ss.Count; ++i)
                {
                    if (string.IsNullOrEmpty(ss[i]))
                    {
                        return false;
                    }
                    else
                    {
                        if (i != neutralColumnIndex)
                        {
                            // 2011-11-16, Uwe Keim: Only check if non-empty, non-default-language.
                            if (!string.IsNullOrEmpty(ss[i]))
                            {
                                var phc = FileGroup.ExtractPlaceholders(ss[i]);
                                if (phc != lastPlaceholderCount)
                                {
                                    return false;
                                }
                                else
                                {
                                    lastPlaceholderCount = phc;
                                }
                            }
                        }
                    }
                }

                return true;
            }
        }
    }

    private bool isCompleteRowEmpty(DataRowView row)
    {
        if (row == null)
        {
            return false;
        }
        else
        {
            var sub = DataProcessing.CommentsAreVisible(
                MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                row.Row,
                CommentVisibilityScope.VisualGrid)
                ? 1
                : 0;

            // Check both, grid and underlying table, because depending
            // on the loading stage of the grid, the grid can still be empty.

            if (mainGridView?.Columns != null)
            {
                // Column 0=FileGroup checksum, column 1=Tag name.
                for (var i = 2; i < mainGridView.Columns.Count - sub; ++i)
                {
                    if (ConvertHelper.ToString(row[i], string.Empty).Trim().Length > 0)
                    {
                        return false;
                    }
                }
            }

            // --

            // Column 0=FileGroup checksum, column 1=Tag name.
            for (var i = 2; i < row.Row.Table.Columns.Count - sub; ++i)
            {
                if (ConvertHelper.ToString(row[i], string.Empty).Trim().Length > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    private GridViewHelper _mainGridHelper;

    private GridViewHelper mainGridHelper
    {
        get
        {
            // ReSharper disable ConvertIfStatementToNullCoalescingExpression
            if (_mainGridHelper == null)
                // ReSharper restore ConvertIfStatementToNullCoalescingExpression
            {
                _mainGridHelper = new GridViewHelper(mainGridView);
            }

            return _mainGridHelper;
        }
    }

    public bool AllowUpdatingDetails
    {
        get => _allowUpdatingDetails;
        set
        {
            if (_allowUpdatingDetails != value)
            {
                _allowUpdatingDetails = value;

                // Do once when enabled back.
                if (value)
                {
                    doUpdateDetails();
                    UpdateUI();
                }
            }
        }
    }

    public bool IsTranslating { get; set; }

    private int _currentRowIndex = -1;

    private string _findText;
    private bool _isLoaded;
    private bool _restoredSplitContainer;
    private Font _boldFont;
    private Font _regularFont;

    private Font _italicFont;

    public void Find()
    {
        using var form = new FindForm {TextToFind = _findText};

        if (form.ShowDialog(this) == DialogResult.OK)
        {
            _findText = form.TextToFind;
            if (!FindNext())
            {
                XtraMessageBox.Show(
                    Resources.SR_ResourceEditorUserControl_Find_TheTextWasNotFound,
                    @"Zeta Resource Editor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }

    public void Replace()
    {
        using var form = new ReplaceForm();
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            int count;
            using (new WaitCursor(this, WaitCursorOption.ShortSleep))
            {
                count = replaceAll(form.TextToFind, form.TextToReplaceWith);
            }

            XtraMessageBox.Show(
                count <= 0 ? "The text was not found." : $"{count} occurrences have been replaced.",
                @"Zeta Resource Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private int replaceAll(
        string textToFind,
        string textToReplaceWith)
    {
        var index = new Point();

        if (hasSelectedRow)
        {
            var cells = mainGridView.GetSelectedCells();
            if (cells.Length > 0)
            {
                index.X = 0; //cells[0].Column.AbsoluteIndex;
                index.Y = selectedRowHandle;
            }
            else
            {
                index.X = 0;
                index.Y = selectedRowHandle;
            }
        }
        else
        {
            index.X = 0;
            index.Y = 0;
        }

        // --

        var result = 0;

        // Only search if inside range.
        if (index.X < mainGridView.Columns.Count &&
            index.Y < mainGridView.RowCount)
        {
            var startingIndex = index;

            index = incrementGridIndex(index, true);

            while (index != startingIndex)
            {
                var text = ConvertHelper.ToString(
                    mainGridHelper.GetRowCellValue(index.Y, index.X));

                if (!string.IsNullOrEmpty(text))
                {
                    var pos = text.IndexOf(
                        textToFind,
                        StringComparison.InvariantCultureIgnoreCase);

                    if (pos >= 0)
                    {
                        mainGridView.ClearSelection();
                        mainGridHelper.SelectCell(index.Y);
                        mainGridHelper.FocusCell(index.Y);

                        var newText = text.Replace(textToFind, textToReplaceWith);

                        mainGridHelper.SetRowCellValue(index.Y, index.X, newText);

                        result++;
                    }
                }

                index = incrementGridIndex(index, false);
            }
        }

        return result;
    }

    public bool FindNext()
    {
        var index = new Point();

        if (hasSelectedRow)
        {
            var cells = mainGridView.GetSelectedCells();
            if (cells.Length > 0)
            {
                index.X = 0; //cells[0].Column.AbsoluteIndex;
                index.Y = selectedRowHandle;
            }
            else
            {
                index.X = 0;
                index.Y = selectedRowHandle;
            }
        }
        else
        {
            index.X = 0;
            index.Y = 0;
        }

        // --

        // Only search if inside range.
        if (index.X < mainGridView.Columns.Count &&
            index.Y < mainGridView.RowCount)
        {
            var startingIndex = index;

            index = incrementGridIndex(index, true);

            while (index != startingIndex)
            {
                var text = ConvertHelper.ToString(
                    mainGridHelper.GetRowCellValue(index.Y, index.X));

                if (!string.IsNullOrEmpty(text))
                {
                    var pos = text.IndexOf(
                        _findText,
                        StringComparison.InvariantCultureIgnoreCase);

                    if (pos >= 0)
                    {
                        mainGridView.ClearSelection();
                        mainGridHelper.SelectCell(index.Y);
                        mainGridHelper.FocusCell(index.Y);
                        //break;
                        return true;
                    }
                }

                index = incrementGridIndex(index, false);
            }
        }

        return false;
    }

    /// <summary>
    /// Increments the index of the grid.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <param name="wholeRowsOnly">if set to <c>true</c> [whole rows only].</param>
    /// <returns></returns>
    private Point incrementGridIndex(
        Point index,
        bool wholeRowsOnly)
    {
        index.X++;

        if (wholeRowsOnly || index.X >= mainGridView.Columns.Count)
        {
            index.X = 0;
            index.Y++;
        }

        if (index.Y >= mainGridView.RowCount)
        {
            index.Y = 0;
        }

        return index;
    }

    /// <summary>
    /// Opens the folder.
    /// </summary>
    public void OpenFolder()
    {
        ProcessStartHelper.OpenFolder(GridEditableData.FolderPath.FullName);
    }

    /// <summary>
    /// Closes the and save data grid.
    /// </summary>
    public bool CloseAndSaveDataGrid()
    {
        if (DoSaveFiles(
                SaveOptions.OnlyIfModified |
                SaveOptions.AskConfirm) == DialogResult.OK)
        {
            closeDataGrid();
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Saves the state.
    /// </summary>
    /// <returns>Returns FALSE if cancel requested.</returns>
    internal bool SaveState(
        SaveOptions options = SaveOptions.OnlyIfModified |
                              SaveOptions.AskConfirm)
    {
        PersistanceHelper.SaveValue(
            MainForm.UserStorageIntelligent,
            @"FindText", _findText);

        if (_data != null)
        {
            var r = DoSaveFiles(options);

            if (r != DialogResult.OK)
            {
                return false;
            }
        }

        //--

        saveGridLayout();
        saveSplitterState();

        FormBase.SaveState(tabControl1);

        return true;
    }

    private void saveSplitterState()
    {
        DevExpressXtraFormBase.SaveState(
            resourceEditorUserControlMainSplitContainer);
    }

    private void restoreSplitterState()
    {
        DevExpressXtraFormBase.RestoreState(
            resourceEditorUserControlMainSplitContainer);
    }

    private FileGroupStates updateStateImage()
    {

        var table = getTable();
        var state = FileGroup.DoCalculateEditingState(
            MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
            table,
            CommentVisibilityScope.VisualGrid);
        var key = FileGroup.TranslateStateToColorKey(state);

        statusPictureBox.Image = ImageCollectionHelper.Ic16.Images[key.ToString()];

        return state;
    }

    private DataTable getTable()
    {
        var table = new DataTable();

        foreach (GridColumn column in mainGridView.Columns)
        {
            table.Columns.Add(column.Name);
        }

        for (var rowHandle = 0; rowHandle < mainGridView.RowCount; ++rowHandle)
        {
            var row = table.NewRow();

            foreach (GridColumn column in mainGridView.Columns)
            {
                row[column.Name] = mainGridView.GetRowCellValue(rowHandle, column);
            }

            table.Rows.Add(row);
        }


        return table;
    }

    private void buttonAddTag_ItemClick(object sender, ItemClickEventArgs e)
    {
        AddTag();
        UpdateUI();
    }

    private void buttonEditTag_ItemClick(object sender, ItemClickEventArgs e)
    {
        RenameTag();
        UpdateUI();
    }

    private void buttonDeleteTag_ItemClick(object sender, ItemClickEventArgs e)
    {
        DeleteTag();
        UpdateUI();
    }

    private void mainGridView_MouseUp(object sender, MouseEventArgs e)
    {
        // http://www.devexpress.com/Support/Center/KB/p/A915.aspx.

        if (e.Button == MouseButtons.Right && ModifierKeys == Keys.None)
        {
            //var pt = mainDataGrid.PointToClient(MousePosition);
            //var info = mainGridView.CalcHitInfo(pt);

            //if (info.InRowCell && info.RowHandle >= 0)
            //{
            //    /*mainGridView.ClearSelection();*/
            //    mainGridHelper.SelectRow(info.RowHandle);

            //    UpdateUI();

            //    optionsPopupMenu.ShowPopup(MousePosition);
            //}
            //else
            //{
            //    mainGridView.ClearSelection();

            //    UpdateUI();

            //    optionsPopupMenu.ShowPopup(MousePosition);
            //}
        }
    }

    private readonly Dictionary<CultureInfo, SpellChecker> _gridSpellCheckers =
        new();

    private bool _canSaveGridLayout;
    private AllLayoutSerializer _layoutSerializer;

    private void mainGridView_ShownEditor(object sender, EventArgs e)
    {
        var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

        if (project is { UseSpellChecker: true })
        {
            var name = mainGridView.FocusedColumn.Caption;
            var culture = new LanguageCodeDetection(project).DetectCultureFromFileName(
                GridEditableData.ParentSettings,
                name);

            if (!_gridSpellCheckers.TryGetValue(culture, out var gridSpellChecker))
            {
                gridSpellChecker = CultureHelper.CreateSpellChecker(culture);
                if (gridSpellChecker != null)
                {
                    gridSpellChecker.ParentContainer = mainDataGrid;
                }

                _gridSpellCheckers[culture] = gridSpellChecker;
            }

            gridSpellChecker?.SetShowSpellCheckMenu(
                mainGridView.ActiveEditor,
                true);
        }
    }

    private void mainGridView_CustomRowFilter(
        object sender,
        RowFilterEventArgs e)
    {
        if (!IsTranslating)
        {
            var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

            if (project is { HideEmptyRows: true })
            {
                var row =
                    (DataRowView)
                    mainGridView.GetRow(e.ListSourceRow);

                if (isCompleteRowEmpty(row))
                {
                    e.Visible = false;
                    e.Handled = true;
                }
                else
                {
                    //e.Visible = true;
                    //e.Handled = true;
                }
            }

            if (project is { HideTranslatedRows: true })
            {
                var row = (DataRowView)mainGridView.GetRow(e.ListSourceRow);

                if (isCompleteRowTranslated(row))
                {
                    e.Visible = false;
                    e.Handled = true;
                }
                else
                {
                    //e.Visible = true;
                    //e.Handled = true;
                }
            }

            if (project is { HideInternalDesignerRows: true })
            {
                var row =
                    (DataRowView)
                    mainGridView.GetRow(e.ListSourceRow);

                if (row != null &&
                    // Column 0=FileGroup checksum, column 1=Tag name.
                    ConvertHelper.ToString(row[1], string.Empty).StartsWith(@">>"))
                {
                    e.Visible = false;
                    e.Handled = true;
                }
                else
                {
                    //e.Visible = true;
                    //e.Handled = true;
                }
            }

            //else
            //{
            //    //e.Visible = true;
            //    //e.Handled = true;
            //}

            // Immediately store.
            saveGridLayout();
        }
    }

    private void startDoUpdateDetails()
    {
        updateDetailsTimer.Stop();
        updateDetailsTimer.Start();
    }

    private void updateDetailsTimer_Tick(object sender, EventArgs e)
    {
        updateDetailsTimer.Stop();
        doUpdateDetails();
    }

    private void mainGridView_EndSorting(object sender, EventArgs e)
    {
        // Immediately store.
        saveGridLayout();
    }

    private void buttonSelectAllInGrid_ItemClick(object sender, ItemClickEventArgs e)
    {
        mainGridView.SelectAll();
    }

    private void buttonCopySelectedRowsToClipboard_ItemClick(object sender, ItemClickEventArgs e)
    {
        mainGridView.CopyToClipboard();
    }

    private void optionsPopupMenu_BeforePopup(object sender, CancelEventArgs e)
    {
        UpdateUI();
    }

    private void buttonDeleteRowContents_ItemClick(object sender, ItemClickEventArgs e)
    {
        DeleteRowContentsWithDialog();
        UpdateUI();
    }

    private void DeleteRowContentsWithDialog()
    {
        using var form = new DeleteRowContentsForm();
        form.Initialize(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);

        if (form.ShowDialog(ParentForm) == DialogResult.OK)
        {
            var languagesToDelete = new List<string>(form.GetLanguagesToDelete());

            var rowHandles = new List<int>(selectedRowHandles);
            rowHandles.Sort((x, y) => -x.CompareTo(y));

            foreach (var rowHandle in rowHandles)
            {
                var row = (DataRowView)mainGridView.GetRow(rowHandle);

                var comments =
                    DataProcessing.CommentsAreVisible(
                        MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                        row.Row,
                        CommentVisibilityScope.VisualGrid);

                var sub = !comments || form.WantDeleteComments ? 0 : 1;

                // Column 0=FileGroup checksum, column 1=Tag name.
                for (var i = 2; i < mainGridView.Columns.Count - sub; ++i)
                {
                    var languageName =
                        DataProcessing.ExtractCultureNameFromColumnCaption(
                            mainGridView.Columns[i].GetCaption());

                    if (!StringExtensionMethods.IsNullOrWhiteSpace(
                            languagesToDelete.Find(
                                y => string.Compare(y, languageName, StringComparison.OrdinalIgnoreCase) == 0)))
                    {
                        mainGridHelper.SetRowCellValue(rowHandle, i, null);
                    }
                }
            }

            MarkGridContentAsModified();
            UpdateUI();
        }
    }

    private void mainGridView_PopupMenuShowing(
        object sender,
        DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
    {
        if (e.HitInfo.InRowCell && e.HitInfo.RowHandle >= 0)
        {
            /*mainGridView.ClearSelection();*/
            mainGridHelper.SelectRow(e.HitInfo.RowHandle);

            UpdateUI();

            e.Menu = null;
            e.Allow = false;
            optionsPopupMenu.ShowPopup(MousePosition);
        }
    }
}