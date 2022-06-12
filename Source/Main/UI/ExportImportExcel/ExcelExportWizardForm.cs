namespace ZetaResourceEditor.UI.ExportImportExcel;

using Code;
using DevExpress.XtraWizard;
using Helper;
using Helper.Base;
using Helper.ErrorHandling;
using Properties;
using Runtime;
using RuntimeBusinessLogic.ExportImportExcel;
using RuntimeBusinessLogic.ExportImportExcel.Export;
using RuntimeBusinessLogic.FileGroups;
using RuntimeBusinessLogic.Language;
using RuntimeBusinessLogic.Projects;
using System.Linq;

public partial class ExcelExportWizardForm :
    FormBase
{
    private FileGroupCollection _groups;
    private Project _project;
    private Exception _exception;
    private bool _canResetOptions = true;
    private bool _canResetAdvancedOptions = true;
    private ExcelExportInformation _latestExportInformation;
    private bool _ignoreReferenceLanguageChanges;

    public ExcelExportWizardForm()
    {
        InitializeComponent();

        if (!DesignMode)
        {
            wizardControl.Text = string.Empty;

            DevExpressExtensionMethods.MakeAutoComplete(
                destinationFileTextEdit,
                AutoCompleteMode.SuggestAppend,
                AutoCompleteSource.FileSystem);
        }
    }

    public void Initialize(
        FileGroupCollection groups,
        Project project)
    {
        _groups = groups;
        _project = project;
    }

    private string[] languageCodes
    {
        get
        {
            var codes =
                new HashSet<string>
                {
                    _project.NeutralLanguageCode
                };

            foreach (
                var lc in
                _groups.SelectMany(
                    group => group.GetLanguageCodes(_project).Where(lc => !string.IsNullOrEmpty(lc))))
            {
                codes.Add(lc);
            }

            var l = codes.ToList();
            l.Sort();

            return l.ToArray();
        }
    }

    protected override void InitiallyFillLists()
    {
        base.InitiallyFillLists();

        // --

        _groups.Sort(
            (x, y) => string.CompareOrdinal(
                x.GetNameIntelligent(_project),
                y.GetNameIntelligent(_project)));

        fileGroupsListBox.Items.Clear();

        foreach (var group in _groups)
        {
            if (!group.IgnoreDuringExportAndImport &&
                @group.ParentSettings is not { EffectiveIgnoreDuringExportAndImport: true })
            {
                var index = fileGroupsListBox.Items.Add(
                    new MyTuple<string, FileGroup>(
                        group.GetNameIntelligent(_project),
                        group));

                fileGroupsListBox.SetItemChecked(index, true);
            }
        }

        if (_groups.Count == 1)
        {
            // Select one, if only one present.
            selectAllFileGroupsButton_Click(null, null);
        }

        // --

        foreach (var languageCode in languageCodes)
        {
            referenceLanguageGroupBox.Properties.Items.Add(
                new MyTuple<string, string>(
                    $@"{LanguageCodeDetection.MakeValidCulture(languageCode).DisplayName} ({languageCode})",
                    languageCode));
        }

        if (languageCodes.Length == 1)
        {
            // Select one, if only one present.
            selectAllLanguagesToExportButton_Click(null, null);
        }

        // --
        // Select defaults.

        if (referenceLanguageGroupBox.SelectedIndex < 0 &&
            referenceLanguageGroupBox.Properties.Items.Count > 0)
        {
            referenceLanguageGroupBox.SelectedIndex = 0;
        }
    }

    protected override void FillItemToControls()
    {
        base.FillItemToControls();

        restoreState(_project.DynamicSettingsGlobalHierarchical);
    }

    private void restoreState(
        IPersistentPairStorage storage)
    {
        _ignoreReferenceLanguageChanges = true;

        destinationFileTextEdit.Text =
            ConvertHelper.ToString(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.destinationFilePathTextEdit.Text"));

        DevExpressExtensionMethods.RestoreSettingsByName(
            fileGroupsListBox,
            storage,
            @"sendFileToTranslator.fileGroupsListBox");

        DevExpressExtensionMethods.RestoreSettingsByName(
            languagesToExportCheckListBox,
            storage,
            @"sendFileToTranslator.languagesToExportCheckListBox");

        referenceLanguageGroupBox.SelectedIndex =
            Math.Min(
                ConvertHelper.ToInt32(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"sendFileToTranslator.referenceLanguageComboBoxEdit.SelectedIndex",
                        referenceLanguageGroupBox.SelectedIndex)),
                referenceLanguageGroupBox.Properties.Items.Count - 1);

        openFileAfterGeneratingCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.openFileAfterGeneratingCheckEdit.Checked",
                    openFileAfterGeneratingCheckEdit.Checked));
        openFolderAfterGeneratingCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.openAfterGeneratingCheckEdit.Checked",
                    openFolderAfterGeneratingCheckEdit.Checked));

        eliminateDuplicateRowsCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.eliminateDuplicateRowsCheckEdit.Checked",
                    eliminateDuplicateRowsCheckEdit.Checked));

        exportWithoutDestinationTranslationOnlyCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportWithoutDestinationTranslationOnlyCheckEdit.Checked",
                    exportWithoutDestinationTranslationOnlyCheckEdit.Checked));

        exportCompletelyEmptyRowsCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportCompletelyEmptyRowsCheckEdit.Checked",
                    exportCompletelyEmptyRowsCheckEdit.Checked));

        exportGroupsAsOneWorkSheetCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportGroupsAsOneWorkSheetCheckEdit.Checked",
                    exportGroupsAsOneWorkSheetCheckEdit.Checked));
        exportGroupsAsWorkSheetsCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportGroupsAsWorkSheetsCheckEdit.Checked",
                    exportGroupsAsWorkSheetsCheckEdit.Checked));
        exportGroupsAsExcelFilesCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportGroupsAsExcelFilesCheckEdit.Checked",
                    exportGroupsAsExcelFilesCheckEdit.Checked));
        exportNameColumnCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportNameColumnCheckEdit.Checked",
                    exportNameColumnCheckEdit.Checked));
        exportCommentColumnCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportCommentColumnCheckEdit.Checked",
                    exportCommentColumnCheckEdit.Checked));
        exportReferenceLanguageColumnCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportReferenceLanguageColumnCheckEdit.Checked",
                    exportReferenceLanguageColumnCheckEdit.Checked));
        exportFileGroupColumnCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportFileGroupColumnCheckEdit.Checked",
                    exportFileGroupColumnCheckEdit.Checked));
        exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked",
                    exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked));
        useCrypticExcelExportSheetNamesCheckEdit.Checked =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    storage,
                    @"sendFileToTranslator.useCrypticExcelExportSheetNamesCheckEdit.Checked",
                    useCrypticExcelExportSheetNamesCheckEdit.Checked));

        _ignoreReferenceLanguageChanges = false;

        // --

        referenceLanguageGroupBox_SelectedIndexChanged(null, null);
    }

    private void saveState(
        IPersistentPairStorage storage)
    {
        using (new SilentProjectStoreGuard(_project))
        {
            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.destinationFilePathTextEdit.Text",
                destinationFileTextEdit.Text);

            DevExpressExtensionMethods.PersistSettingsByName(
                fileGroupsListBox,
                storage,
                @"sendFileToTranslator.fileGroupsListBox");

            DevExpressExtensionMethods.PersistSettingsByName(
                languagesToExportCheckListBox,
                storage,
                @"sendFileToTranslator.languagesToExportCheckListBox");

            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.referenceLanguageComboBoxEdit.SelectedIndex",
                referenceLanguageGroupBox.SelectedIndex);

            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.openFileAfterGeneratingCheckEdit.Checked",
                openFileAfterGeneratingCheckEdit.Checked);
            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.openAfterGeneratingCheckEdit.Checked",
                openFolderAfterGeneratingCheckEdit.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.eliminateDuplicateRowsCheckEdit.Checked",
                eliminateDuplicateRowsCheckEdit.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportWithoutDestinationTranslationOnlyCheckEdit.Checked",
                exportWithoutDestinationTranslationOnlyCheckEdit.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportCompletelyEmptyRowsCheckEdit.Checked",
                exportCompletelyEmptyRowsCheckEdit.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportGroupsAsOneWorkSheetCheckEdit.Checked",
                exportGroupsAsOneWorkSheetCheckEdit.Checked);
            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportNameColumnCheckEdit.Checked",
                exportNameColumnCheckEdit.Checked);
            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportCommentColumnCheckEdit.Checked",
                exportCommentColumnCheckEdit.Checked);
            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportReferenceLanguageColumnCheckEdit.Checked",
                exportReferenceLanguageColumnCheckEdit.Checked);
            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportFileGroupColumnCheckEdit.Checked",
                exportFileGroupColumnCheckEdit.Checked);
            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportGroupsAsWorkSheetsCheckEdit.Checked",
                exportGroupsAsWorkSheetsCheckEdit.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportGroupsAsExcelFilesCheckEdit.Checked",
                exportGroupsAsExcelFilesCheckEdit.Checked);
            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked",
                exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked);
            PersistanceHelper.SaveValue(
                storage,
                @"sendFileToTranslator.useCrypticExcelExportSheetNamesCheckEdit.Checked",
                useCrypticExcelExportSheetNamesCheckEdit.Checked);
        }
    }

    private void referenceLanguageGroupBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_ignoreReferenceLanguageChanges)
        {
            refillLanguagesToTranslate();
            UpdateUI();
        }
    }

    private void refillLanguagesToTranslate()
    {
        languagesToExportCheckListBox.Items.Clear();

        var forbidden =
            referenceLanguageGroupBox.SelectedIndex >= 0 &&
            referenceLanguageGroupBox.SelectedIndex <
            referenceLanguageGroupBox.Properties.Items.Count
                ? ((MyTuple<string, string>)referenceLanguageGroupBox.SelectedItem).Item2
                : string.Empty;

        foreach (var languageCode in languageCodes)
        {
            if (!string.IsNullOrEmpty(languageCode) &&
                !string.Equals(languageCode, forbidden, StringComparison.InvariantCultureIgnoreCase))
            {
                var index = languagesToExportCheckListBox.Items.Add(
                    new MyTuple<string, string>(
                        $@"{LanguageCodeDetection.MakeValidCulture(languageCode).DisplayName} ({languageCode})",
                        languageCode));

                languagesToExportCheckListBox.SetItemChecked(index, true);
            }
        }
    }

    public override void UpdateUI()
    {
        base.UpdateUI();

        doUpdateUI(wizardControl.SelectedPage);
    }

    private void doUpdateUI(BaseWizardPage selectedPage)
    {
        if (selectedPage == fileGroupSelectionWizardPage)
        {
            invertFileGroupsButton.Enabled =
                fileGroupsListBox.Items.Count > 0;
            selectNoFileGroupsButton.Enabled =
                fileGroupsListBox.CheckedItems.Count > 0;
            selectAllFileGroupsButton.Enabled =
                fileGroupsListBox.Items.Count > 0 &&
                fileGroupsListBox.CheckedItems.Count <
                fileGroupsListBox.Items.Count;

            selectedPage.AllowNext =
                fileGroupsListBox.CheckedItems.Count > 0;
        }
        else if (selectedPage == languagesWizardPage)
        {
            invertLanguagesToExportButton.Enabled =
                languagesToExportCheckListBox.Items.Count > 0;
            selectNoLanguagesToExportButton.Enabled =
                languagesToExportCheckListBox.CheckedItems.Count > 0;
            selectAllLanguagesToExportButton.Enabled =
                languagesToExportCheckListBox.Items.Count > 0 &&
                languagesToExportCheckListBox.CheckedItems.Count <
                languagesToExportCheckListBox.Items.Count;

            selectedPage.AllowNext =
                referenceLanguageGroupBox.SelectedIndex >= 0 &&
                languagesToExportCheckListBox.CheckedItems.Count > 0;
        }
        else if (selectedPage == optionsWizardPage)
        {
            buttonResetOptions.Enabled = _canResetOptions;

            multipleFilesGroupControl.Visible =
                exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked ||
                exportGroupsAsExcelFilesCheckEdit.Checked;

            buttonDecorateSimpleAutomatically.Visible =
                !(exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked ||
                  exportGroupsAsExcelFilesCheckEdit.Checked);

            selectedPage.AllowNext = true;
        }
        else if (selectedPage == advancedOptionsWizardPage)
        {
            buttonResetOptions.Enabled = _canResetAdvancedOptions;

            // Must at least have one of those two.
            selectedPage.AllowNext =
                exportNameColumnCheckEdit.Checked ||
                exportReferenceLanguageColumnCheckEdit.Checked;
        }
        else if (selectedPage == destinationFileWizardPage)
        {
            selectedPage.AllowNext =
                destinationFileTextEdit.Text.Trim().Length > 0 &&
                ZspPathHelper.GetExtension(destinationFileTextEdit.Text.Trim().ToLowerInvariant()) == @".xlsx";
        }
        else if (selectedPage == progressWizardPage)
        {
        }
        else if (selectedPage == errorOccurredWizardPage)
        {
        }
        else if (selectedPage == successWizardPage)
        {
        }
        else
        {
            throw new Exception();
        }
    }

    private void exportWizard_Load(
        object sender,
        EventArgs e)
    {
        //WinFormsPersistanceHelper.RestoreState(this);
        CenterToParent();

        advancedOptionsPanel.Visible =
            ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    _project.DynamicSettingsGlobalHierarchical,
                    @"advancedOptionsPanel.Visible",
                    advancedOptionsPanel.Visible));
        updateExpandState();

        if (!_project.EnableExcelExportSnapshots)
        {
            exportOnlyRowsWithChangedTextsCheckEdit.Checked = false;
            exportOnlyRowsWithChangedTextsCheckEdit.Visible = false;
        }

        // Clear.
        warningTextLabel.Text = string.Empty;

        InitiallyFillLists();
        FillItemToControls();

        UpdateUI();
    }

    private void exportWizard_FormClosing(
        object sender,
        FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            if (progressBackgroundWorker.IsBusy)
            {
                e.Cancel = true;
                return;
            }
        }

        checkStopBackgroundWorker();

        WinFormsPersistanceHelper.SaveState(this);
        saveState(_project.DynamicSettingsGlobalHierarchical);
    }

    private void checkStopBackgroundWorker()
    {
        if (progressBackgroundWorker.IsBusy)
        {
            progressBackgroundWorker.CancelAsync();

            while (progressBackgroundWorker.IsBusy)
            {
                Thread.Sleep(200);
                Application.DoEvents();
            }
        }
    }

    private void selectAllFileGroupsButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < fileGroupsListBox.Items.Count; ++index)
        {
            fileGroupsListBox.SetItemChecked(index, true);
        }
    }

    private void selectNoFileGroupsButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < fileGroupsListBox.Items.Count; ++index)
        {
            fileGroupsListBox.SetItemChecked(index, false);
        }
    }

    private void invertFileGroupsButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < fileGroupsListBox.Items.Count; ++index)
        {
            fileGroupsListBox.SetItemChecked(
                index,
                !fileGroupsListBox.GetItemChecked(index));
        }
    }

    private void fileGroupsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateUI();
    }

    private void fileGroupsListBox_ItemCheck(
        object sender,
        DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
    {
        UpdateUI();
    }

    private void languagesToExportCheckListBox_SelectedIndexChanged(
        object sender,
        EventArgs e)
    {
        UpdateUI();
    }

    private void languagesToExportCheckListBox_ItemCheck(
        object sender,
        DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
    {
        UpdateUI();
    }

    private void selectAllLanguagesToExportButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < languagesToExportCheckListBox.Items.Count; ++index)
        {
            languagesToExportCheckListBox.SetItemChecked(index, true);
        }
    }

    private void selectNoLanguagesToExportButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < languagesToExportCheckListBox.Items.Count; ++index)
        {
            languagesToExportCheckListBox.SetItemChecked(index, false);
        }
    }

    private void invertLanguagesToExportButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < languagesToExportCheckListBox.Items.Count; ++index)
        {
            languagesToExportCheckListBox.SetItemChecked(
                index,
                !languagesToExportCheckListBox.GetItemChecked(index));
        }
    }

    private void destinationFileTextEdit_EditValueChanged(object sender, EventArgs e)
    {
        UpdateUI();
    }

    private void buttonBrowse_Click(object sender, EventArgs e)
    {
        using var form = new OpenFileDialog
        {
            InitialDirectory = (string)
                PersistanceHelper.RestoreValue(
                    _project.DynamicSettingsGlobalHierarchical,
                    @"sendFileToTranslator.destinationFilePathTextEdit.InitialDirectory",
                    _project.ProjectConfigurationFilePath.DirectoryName),
            Multiselect = false,
            CheckFileExists = false,
            CheckPathExists = true,
            Filter = Resources.SR_ExportWizard_buttonBrowseClick_ExcelFilesXlsxls
        };

        if (form.ShowDialog(this) == DialogResult.OK)
        {
            using (new SilentProjectStoreGuard(_project))
            {
                PersistanceHelper.SaveValue(
                    _project.DynamicSettingsGlobalHierarchical,
                    @"sendFileToTranslator.destinationFilePathTextEdit.InitialDirectory",
                    ZspPathHelper.GetDirectoryPathNameFromFilePath(form.FileName));
            }

            destinationFileTextEdit.Text = form.FileName;

            UpdateUI();
        }
    }

    private void progressBackgroundWorker_DoWork(
        object sender,
        DoWorkEventArgs e)
    {
        Host.ApplyLanguageSettingsToCurrentThread();

        var ei = (ExcelExportInformation)e.Argument;
        _latestExportInformation = ei;
        var cp = new ExcelExportController();

        cp.Prepare(ei);
        cp.Process((BackgroundWorker)sender);
    }

    private void progressBackgroundWorker_ProgressChanged(
        object sender,
        ProgressChangedEventArgs e)
    {
        if (e.UserState is not ExcelProgressInformation s)
        {
            if (e.UserState is not string t)
            {
                progressLabel.Visible = false;
                progressLabel.Text = string.Empty;
            }
            else
            {
                progressLabel.Visible = !StringExtensionMethods.IsNullOrWhiteSpace(t);
                progressLabel.Text = t;
            }
        }
        else
        {
            if (string.IsNullOrEmpty(s.TemporaryProgressMessage))
            {
                progressLabel.Visible = false;
                progressLabel.Text = string.Empty;
            }
            else
            {
                progressLabel.Visible = true;
                progressLabel.Text = s.TemporaryProgressMessage;
            }

            // --

            if (!string.IsNullOrEmpty(s.WarningMessage))
            {
                warningTextLabel.Text += s.WarningMessage;
                warningTextLabel.Text += Environment.NewLine;
            }
        }
    }

    private void progressBackgroundWorker_RunWorkerCompleted(
        object sender,
        RunWorkerCompletedEventArgs e)
    {
        if (e.Cancelled || e.Error is OperationCanceledException)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        else if (e.Error != null)
        {
            _exception = e.Error;
            errorTextMemoEdit.Text = e.Error.Message;
            wizardControl.SelectedPage = errorOccurredWizardPage;
            UpdateUI();
        }
        else
        {
            if (openFolderAfterGeneratingCheckEdit.Checked ||
                openFileAfterGeneratingCheckEdit.Checked)
            {
                wizardControl.SelectedPage = successWizardPage;
                pleaseWaitFinishLabel.Visible = true;

                if (hasWarnings)
                {
                    pleaseWaitFinishLabel.Text =
                        Resources.ExcelExportWizardForm_progressBackgroundWorker_RunWorkerCompleted_Warnings_occurred_;
                }
                else
                {
                    wizardControl.FinishText = string.Empty;
                }

                UpdateUI();
                Application.DoEvents();

                try
                {
                    if (openFileAfterGeneratingCheckEdit.Checked ||
                        openFolderAfterGeneratingCheckEdit.Checked)
                    {
                        // --

                        if (openFileAfterGeneratingCheckEdit.Checked)
                        {
                            var paths =
                                ExcelExportController.GetFilePaths(
                                    _latestExportInformation);

                            foreach (var path in paths)
                            {
                                if (File.Exists(path))
                                {
                                    ProcessStartHelper.OpenFile(path);
                                }
                            }
                        }
                        if (openFolderAfterGeneratingCheckEdit.Checked)
                        {
                            var paths =
                                ExcelExportController.GetDirectoryPaths(
                                    _latestExportInformation);

                            foreach (var path in paths)
                            {
                                if (Directory.Exists(path))
                                {
                                    ProcessStartHelper.OpenFolder(path);
                                }
                            }
                        }
                    }
                }
                finally
                {
                    // Only close if no warnings at all.
                    if (!hasWarnings)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
            else
            {
                wizardControl.SelectedPage = successWizardPage;
                pleaseWaitFinishLabel.Visible = false;

                UpdateUI();
            }
        }
    }

    private bool hasWarnings => !string.IsNullOrEmpty(warningTextLabel.Text.Trim());

    private void wizardControl_NextClick(
        object sender,
        WizardCommandButtonClickEventArgs e)
    {
        if (e.Page == destinationFileWizardPage)
        {
            e.Handled = true;
            wizardControl.SelectedPage = progressWizardPage;

            doExport();
        }
    }

    private void wizardControl_PrevClick(
        object sender,
        WizardCommandButtonClickEventArgs e)
    {
        if (e.Page == errorOccurredWizardPage)
        {
            wizardControl.SelectedPage = destinationFileWizardPage;
            e.Handled = true;
        }
    }

    private void wizardControl_CancelClick(
        object sender,
        CancelEventArgs e)
    {
        if (wizardControl.SelectedPage == progressWizardPage)
        {
            if (XtraMessageBox.Show(
                    this,
                    Resources.SR_ConfirmCancelExport,
                    @"Zeta Resource Editor",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                checkStopBackgroundWorker();
            }
            else
            {
                DialogResult = DialogResult.None;
                e.Cancel = true;
            }
        }
        else
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    private void wizardControl_FinishClick(object sender, CancelEventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    private void doExport()
    {
        var ei =
            new ExcelExportInformation
            {
                Project = _project,
                ReferenceLanguageCode = ((MyTuple<string, string>)referenceLanguageGroupBox.SelectedItem).Item2,
                DestinationFilePath = destinationFileTextEdit.Text.Trim(),
                EliminateDuplicateRows = eliminateDuplicateRowsCheckEdit.Checked,
                OnlyExportRowsWithNoTranslation = exportWithoutDestinationTranslationOnlyCheckEdit.Checked,
                ExportCompletelyEmptyRows = exportCompletelyEmptyRowsCheckEdit.Checked,
                OnlyExportRowsWithChangedTexts = exportOnlyRowsWithChangedTextsCheckEdit.Checked,
                ExportAllGroupsMode =
                    exportGroupsAsOneWorkSheetCheckEdit.Checked
                        ? ExcelExportInformation.ExportFileGroupMode.AllGroupsIntoOneWorksheet
                        : exportGroupsAsWorkSheetsCheckEdit.Checked
                            ? ExcelExportInformation.ExportFileGroupMode.EachGroupIntoSeparateWorksheet
                            : ExcelExportInformation.ExportFileGroupMode.OneExcelFilePerGroup,
                ExportFileGroupColumn = exportFileGroupColumnCheckEdit.Checked,
                ExportNameColumn = exportNameColumnCheckEdit.Checked,
                ExportCommentColumn = exportCommentColumnCheckEdit.Checked,
                ExportReferenceLanguageColumn = exportReferenceLanguageColumnCheckEdit.Checked,
                ExportEachLanguageIntoSeparateExcelFile = exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked,
                UseCrypticExcelExportSheetNames = useCrypticExcelExportSheetNamesCheckEdit.Checked,
                FileGroups = (from CheckedListBoxItem item in fileGroupsListBox.CheckedItems
                    select (MyTuple<string, FileGroup>)item.Value
                    into p
                    select p.Item2).ToArray(),
                DestinationLanguageCodes = (from CheckedListBoxItem item in languagesToExportCheckListBox.CheckedItems
                    select (MyTuple<string, string>)item.Value
                    into p
                    select p.Item2).ToArray()
            };

        // --

        progressBackgroundWorker.RunWorkerAsync(ei);
        UpdateUI();
    }

    private void detailedErrorsButton_ItemClick(object sender, ItemClickEventArgs e)
    {
        using var form = new TextBoxForm();
        var message = Logger.MakeTraceMessage(_exception);
        form.Initialize(message);

        form.ShowDialog(this);
    }

    private void optionsPopupMenu_BeforePopup(object sender, CancelEventArgs e)
    {
        UpdateUI();
    }

    private void exportGroupsAsOneWorkSheetCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        _canResetOptions = true;
        UpdateUI();
    }

    private void exportGroupsAsWorkSheetsCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        _canResetOptions = true;
        UpdateUI();
    }

    private void wizardControl_SelectedPageChanged(object sender, WizardPageChangedEventArgs e)
    {
        UpdateUI();
    }

    private void btnConnectionStringExpander_Click(object sender, EventArgs e)
    {
        advancedOptionsPanel.Visible = !advancedOptionsPanel.Visible;
        using (new SilentProjectStoreGuard(_project))
        {
            PersistanceHelper.SaveValue(
                _project.DynamicSettingsGlobalHierarchical,
                @"advancedOptionsPanel.Visible",
                advancedOptionsPanel.Visible);
        }

        updateExpandState();
    }

    private void updateExpandState()
    {
        btnConnectionStringExpander.Text =
            advancedOptionsPanel.Visible
                ? @"-"
                : @"+";
    }

    private void buttonResetOptions_Click(object sender, EventArgs e)
    {
        using (new WaitCursor(this, WaitCursorOption.ShortSleep))
        {
            exportGroupsAsOneWorkSheetCheckEdit.Checked = true;
            exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked = false;

            _canResetOptions = false;
            UpdateUI();
        }
    }

    private void buttonResetAdvancedOptions_Click(object sender, EventArgs e)
    {
        using (new WaitCursor(this, WaitCursorOption.ShortSleep))
        {
            eliminateDuplicateRowsCheckEdit.Checked = true;
            exportWithoutDestinationTranslationOnlyCheckEdit.Checked = true;
            exportCompletelyEmptyRowsCheckEdit.Checked = false;
            exportFileGroupColumnCheckEdit.Checked = false;
            exportNameColumnCheckEdit.Checked = false;
            exportCommentColumnCheckEdit.Checked = false;
            exportReferenceLanguageColumnCheckEdit.Checked = true;
            useCrypticExcelExportSheetNamesCheckEdit.Checked = false;
            exportOnlyRowsWithChangedTextsCheckEdit.Checked = true;

            advancedOptionsPanel.Visible = false;
            updateExpandState();

            _canResetAdvancedOptions = false;
            UpdateUI();
        }
    }

    private void eliminateDuplicateRowsCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        _canResetOptions = true;
        UpdateUI();
    }

    private void exportWithoutDestinationTranslationOnlyCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        _canResetAdvancedOptions = true;
        UpdateUI();
    }

    private void exportGroupsAsExcelFilesCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        _canResetOptions = true;
        UpdateUI();
    }

    private void exportEachLanguageIntoSeparateExcelFileCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        _canResetOptions = true;
        UpdateUI();
    }

    private void wizardControl_SelectedPageChanging(object sender, WizardPageChangingEventArgs e)
    {
        doUpdateUI(e.Page);
        UpdateUI();
    }

    private void buttonDecorateAutomatically_Click(object sender, EventArgs e)
    {
        /*var existingFilePath = destinationFileTextEdit.Text.Trim();*/

        var baseFolderPath = _project.ProjectConfigurationFilePath.DirectoryName;
        var baseFileName = ZspPathHelper.GetFileNameWithoutExtension(_project.ProjectConfigurationFilePath.Name);
        const string baseExtension = @".xlsx";

        // --

        switch (exportGroupsAsExcelFilesCheckEdit.Checked)
        {
            case true when exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked:
                destinationFileTextEdit.Text =
                    ZspPathHelper.Combine(
                        baseFolderPath,
                        $@"{baseFileName}-{{LanguageName}}-{{FileGroupName}}{baseExtension}");
                break;
            case true:
                destinationFileTextEdit.Text =
                    ZspPathHelper.Combine(
                        baseFolderPath,
                        $@"{baseFileName}-{{FileGroupName}}{baseExtension}");
                break;
            default:
            {
                if (exportEachLanguageIntoSeparateExcelFileCheckEdit.Checked)
                {
                    destinationFileTextEdit.Text =
                        ZspPathHelper.Combine(
                            baseFolderPath,
                            $@"{baseFileName}-{{LanguageName}}{baseExtension}");
                }
                else
                {
                    throw new Exception(
                        Resources.SR_ExportWizardForm_buttonDecorateAutomatically_Click_Unexpected_condition);
                }

                break;
            }
        }
    }

    private void buttonDecorateSimpleAutomatically_Click(object sender, EventArgs e)
    {
        var baseFolderPath = _project.ProjectConfigurationFilePath.DirectoryName;
        var baseFileName = ZspPathHelper.GetFileNameWithoutExtension(_project.ProjectConfigurationFilePath.Name);
        const string baseExtension = @".xlsx";

        destinationFileTextEdit.Text =
            ZspPathHelper.Combine(
                baseFolderPath,
                $@"{baseFileName}{baseExtension}");
    }

    private void exportFileGroupColumnCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        UpdateUI();
        _canResetAdvancedOptions = true;
    }

    private void exportNameColumnCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        UpdateUI();
        _canResetAdvancedOptions = true;
    }

    private void exportCommentColumnCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        UpdateUI();
        _canResetAdvancedOptions = true;

    }

    private void exportReferenceLanguageColumnCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        UpdateUI();
        _canResetAdvancedOptions = true;
    }

    private void useCrypticExcelExportSheetNamesCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        UpdateUI();
        _canResetAdvancedOptions = true;
    }

    private void exportOnlyRowsWithChangedTextsCheckEdit_CheckedChanged(object sender, EventArgs e)
    {
        UpdateUI();
        _canResetAdvancedOptions = true;
    }
}