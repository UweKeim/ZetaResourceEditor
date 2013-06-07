namespace ZetaResourceEditor.UI.ExportImport
{
    #region Using directives.
    // ----------------------------------------------------------------------

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;
    using Code.CommandLine;
    using Code.DL;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraWizard;
    using Helper;
    using Helper.Base;
    using Properties;
    using Zeta.EnterpriseLibrary.Common;
    using Zeta.EnterpriseLibrary.Common.Collections;
    using Zeta.EnterpriseLibrary.Common.IO;
    using Zeta.EnterpriseLibrary.Logging;
    using Zeta.EnterpriseLibrary.Tools.Storage;
    using Zeta.EnterpriseLibrary.Windows.Common;

    // ----------------------------------------------------------------------
    #endregion

    /////////////////////////////////////////////////////////////////////////

    public partial class ExportWizardForm :
        FormBase
    {
        private FileGroupCollection _groups;
        private Project _project;
        private Exception _exception;
        private bool _canResetOptions = true;

        public ExportWizardForm()
        {
            InitializeComponent();
        }

        public void Initialize(
            FileGroupCollection groups,
            Project project)
        {
            _groups = groups;
            _project = project;
        }

        private IEnumerable<string> languageCodes
        {
            get
            {
                var codes =
                    new Set<string>
						{
							_project.NeutralLanguageCode
						};

                foreach (var group in _groups)
                {
                    foreach (var lc in group.GetLanguageCodes(_project))
                    {
                        if (!string.IsNullOrEmpty(lc))
                        {
                            codes.Add(lc);
                        }
                    }
                }

                codes.Sort();

                return codes.ToArray();
            }
        }

        public override void InitiallyFillLists()
        {
            base.InitiallyFillLists();

            // --

            fileGroupsListBox.Items.Clear();

            foreach (var group in _groups)
            {
                var index = fileGroupsListBox.Items.Add(
                    new Pair<string, FileGroup>(
                        group.GetNameIntelligent(_project),
                        group));

                fileGroupsListBox.SetItemChecked(index, true);
            }

            // --

            foreach (var languageCode in languageCodes)
            {
                referenceLanguageGroupBox.Properties.Items.Add(
                    new Pair<string, string>(
                        string.Format(
                            @"{0} ({1})",
                            CultureInfo.GetCultureInfo(languageCode).DisplayName,
                            languageCode),
                        languageCode));
            }

            // --
            // Select defaults.

            if (referenceLanguageGroupBox.SelectedIndex < 0 &&
                 referenceLanguageGroupBox.Properties.Items.Count > 0)
            {
                referenceLanguageGroupBox.SelectedIndex = 0;
            }
        }

        public override void FillItemToControls()
        {
            base.FillItemToControls();

            restoreState(_project.DynamicSettingsGlobalHierarchical);
        }

        private void restoreState(
            IPersistentPairStorage storage)
        {
            destinationFileTextEdit.Text =
                ConvertHelper.ToString(
                    FormHelper.RestoreValue(
                        storage,
                        @"sendFileToTranslator.destinationFilePathTextEdit.Text"));

            DevExpressExtensionMethods.RestoreSettings(
                fileGroupsListBox,
                storage,
                @"sendFileToTranslator.fileGroupsListBox");

            DevExpressExtensionMethods.RestoreSettings(
                languagesToExportCheckListBox,
                storage,
                @"sendFileToTranslator.languagesToExportCheckListBox");

            referenceLanguageGroupBox.SelectedIndex =
                Math.Min(
                    ConvertHelper.ToInt32(
                        FormHelper.RestoreValue(
                            storage,
                            @"sendFileToTranslator.referenceLanguageComboBoxEdit.SelectedIndex",
                            referenceLanguageGroupBox.SelectedIndex)),
                    referenceLanguageGroupBox.Properties.Items.Count - 1);

            openFileAfterGeneratingCheckEdit.Checked =
                ConvertHelper.ToBoolean(
                    FormHelper.RestoreValue(
                        storage,
                        @"sendFileToTranslator.openFileAfterGeneratingCheckEdit.Checked",
                        openFileAfterGeneratingCheckEdit.Checked));
            openAfterGeneratingCheckEdit.Checked =
                ConvertHelper.ToBoolean(
                    FormHelper.RestoreValue(
                        storage,
                        @"sendFileToTranslator.openAfterGeneratingCheckEdit.Checked",
                        openAfterGeneratingCheckEdit.Checked));

            eliminateDuplicateRowsCheckEdit.Checked =
                ConvertHelper.ToBoolean(
                    FormHelper.RestoreValue(
                        storage,
                        @"sendFileToTranslator.eliminateDuplicateRowsCheckEdit.Checked",
                        eliminateDuplicateRowsCheckEdit.Checked));

            exportWithoutDestinationTranslationOnlyCheckEdit.Checked =
                ConvertHelper.ToBoolean(
                    FormHelper.RestoreValue(
                        storage,
                        @"sendFileToTranslator.exportWithoutDestinationTranslationOnlyCheckEdit.Checked",
                        exportWithoutDestinationTranslationOnlyCheckEdit.Checked));

            exportGroupsAsOneWorkSheetCheckEdit.Checked =
                ConvertHelper.ToBoolean(
                    FormHelper.RestoreValue(
                        storage,
                        @"sendFileToTranslator.exportGroupsAsOneWorkSheetCheckEdit.Checked",
                        exportGroupsAsOneWorkSheetCheckEdit.Checked));
            exportLanguageColumnsOnlyCheckEdit.Checked =
                ConvertHelper.ToBoolean(
                    FormHelper.RestoreValue(
                        storage,
                        @"sendFileToTranslator.exportLanguageColumnsOnlyCheckEdit.Checked",
                        exportLanguageColumnsOnlyCheckEdit.Checked));
            exportGroupsAsWorkSheetsCheckEdit.Checked =
                ConvertHelper.ToBoolean(
                    FormHelper.RestoreValue(
                        storage,
                        @"sendFileToTranslator.exportGroupsAsWorkSheetsCheckEdit.Checked",
                        exportGroupsAsWorkSheetsCheckEdit.Checked));
        }

        private void saveState(
            IPersistentPairStorage storage)
        {
            using (new SilentProjectStoreGuard(_project))
            {
                FormHelper.SaveValue(
                    storage,
                    @"sendFileToTranslator.destinationFilePathTextEdit.Text",
                    destinationFileTextEdit.Text);

                DevExpressExtensionMethods.PersistSettings(
                    fileGroupsListBox,
                    storage,
                    @"sendFileToTranslator.fileGroupsListBox");

                DevExpressExtensionMethods.PersistSettings(
                    languagesToExportCheckListBox,
                    storage,
                    @"sendFileToTranslator.languagesToExportCheckListBox");

                FormHelper.SaveValue(
                    storage,
                    @"sendFileToTranslator.referenceLanguageComboBoxEdit.SelectedIndex",
                    referenceLanguageGroupBox.SelectedIndex);

                FormHelper.SaveValue(
                    storage,
                    @"sendFileToTranslator.openFileAfterGeneratingCheckEdit.Checked",
                    openFileAfterGeneratingCheckEdit.Checked);
                FormHelper.SaveValue(
                    storage,
                    @"sendFileToTranslator.openAfterGeneratingCheckEdit.Checked",
                    openAfterGeneratingCheckEdit.Checked);

                FormHelper.SaveValue(
                    storage,
                    @"sendFileToTranslator.eliminateDuplicateRowsCheckEdit.Checked",
                    eliminateDuplicateRowsCheckEdit.Checked);

                FormHelper.SaveValue(
                    storage,
                    @"sendFileToTranslator.exportWithoutDestinationTranslationOnlyCheckEdit.Checked",
                    exportWithoutDestinationTranslationOnlyCheckEdit.Checked);

                FormHelper.SaveValue(
                    storage,
                    @"sendFileToTranslator.exportGroupsAsOneWorkSheetCheckEdit.Checked",
                    exportGroupsAsOneWorkSheetCheckEdit.Checked);
                FormHelper.SaveValue(
                    storage,
                    @"sendFileToTranslator.exportLanguageColumnsOnlyCheckEdit.Checked",
                    exportLanguageColumnsOnlyCheckEdit.Checked);
                FormHelper.SaveValue(
                    storage,
                    @"sendFileToTranslator.exportGroupsAsWorkSheetsCheckEdit.Checked",
                    exportGroupsAsWorkSheetsCheckEdit.Checked);
            }
        }

        private void referenceLanguageGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refillLanguagesToTranslate();
            UpdateUI();
        }

        private void refillLanguagesToTranslate()
        {
            languagesToExportCheckListBox.Items.Clear();

            var forbidden =
                referenceLanguageGroupBox.SelectedIndex >= 0 &&
                referenceLanguageGroupBox.SelectedIndex <
                referenceLanguageGroupBox.Properties.Items.Count
                    ? ((Pair<string, string>)referenceLanguageGroupBox.SelectedItem).Second
                    : string.Empty;

            foreach (var languageCode in languageCodes)
            {
                if (!string.IsNullOrEmpty(languageCode) &&
                     languageCode.ToLowerInvariant() != forbidden.ToLowerInvariant())
                {
                    var index = languagesToExportCheckListBox.Items.Add(
                        new Pair<string, string>(
                            string.Format(
                                @"{0} ({1})",
                                CultureInfo.GetCultureInfo(languageCode).DisplayName,
                                languageCode),
                            languageCode));

                    languagesToExportCheckListBox.SetItemChecked(index, true);
                }
            }
        }

        public override void UpdateUI()
        {
            base.UpdateUI();

            if (wizardControl.SelectedPage == fileGroupSelectionWizardPage)
            {
                invertFileGroupsButton.Enabled =
                    fileGroupsListBox.Items.Count > 0;
                selectNoFileGroupsButton.Enabled =
                    fileGroupsListBox.CheckedItems.Count > 0;
                selectAllFileGroupsButton.Enabled =
                    fileGroupsListBox.Items.Count > 0 &&
                    fileGroupsListBox.CheckedItems.Count <
                    fileGroupsListBox.Items.Count;

                wizardControl.SelectedPage.AllowNext =
                    fileGroupsListBox.CheckedItems.Count > 0;
            }
            else if (wizardControl.SelectedPage == languagesWizardPage)
            {
                invertLanguagesToExportButton.Enabled =
                    languagesToExportCheckListBox.Items.Count > 0;
                selectNoLanguagesToExportButton.Enabled =
                    languagesToExportCheckListBox.CheckedItems.Count > 0;
                selectAllLanguagesToExportButton.Enabled =
                    languagesToExportCheckListBox.Items.Count > 0 &&
                    languagesToExportCheckListBox.CheckedItems.Count <
                    languagesToExportCheckListBox.Items.Count;

                wizardControl.SelectedPage.AllowNext =
                    referenceLanguageGroupBox.SelectedIndex >= 0 &&
                    languagesToExportCheckListBox.CheckedItems.Count > 0;
            }
            else if (wizardControl.SelectedPage == destinationFileWizardPage)
            {
                wizardControl.SelectedPage.AllowNext =
                    destinationFileTextEdit.Text.Trim().Length > 0 &&
                    Path.GetExtension(destinationFileTextEdit.Text.Trim().ToLowerInvariant()) == @".xls";
            }
            else if (wizardControl.SelectedPage == optionsWizardPage)
            {
                buttonResetOptions.Enabled = _canResetOptions;
            }
            else if (wizardControl.SelectedPage == progressWizardPage)
            {
            }
            else if (wizardControl.SelectedPage == errorOccurredWizardPage)
            {
            }
            else if (wizardControl.SelectedPage == successWizardPage)
            {
            }
            else
            {
                throw new Exception();
            }
        }

        private void ExportWizard_Load(
            object sender,
            EventArgs e)
        {
            FormHelper.RestoreState(this);
            CenterToParent();

            advancedOptionsPanel.Visible =
                ConvertHelper.ToBoolean(
                    FormHelper.RestoreValue(
                        @"advancedOptionsPanel.Visible",
                        advancedOptionsPanel.Visible));
            updateExpandState();

            InitiallyFillLists();
            FillItemToControls();

            UpdateUI();
        }

        private void ExportWizard_FormClosing(
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

            FormHelper.SaveState(this);
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
            using (var form = new OpenFileDialog())
            {
                form.InitialDirectory =
                    (string)
                    FormHelper.RestoreValue(
                        _project.DynamicSettingsGlobalHierarchical,
                        @"sendFileToTranslator.destinationFilePathTextEdit.InitialDirectory",
                        _project.ProjectConfigurationFilePath.DirectoryName);

                form.Multiselect = false;
                form.CheckFileExists = false;
                form.CheckPathExists = true;
                form.Filter = Resources.SR_ExportWizard_buttonBrowseClick_ExcelFilesXlsxls;

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    using (new SilentProjectStoreGuard(_project))
                    {
                        FormHelper.SaveValue(
                            _project.DynamicSettingsGlobalHierarchical,
                            @"sendFileToTranslator.destinationFilePathTextEdit.InitialDirectory",
                            Path.GetDirectoryName(form.FileName));
                    }

                    destinationFileTextEdit.Text = form.FileName;

                    UpdateUI();
                }
            }
        }

        private void progressBackgroundWorker_DoWork(
            object sender,
            DoWorkEventArgs e)
        {
            var ei = (CommandProcessorSendInformation)e.Argument;
            var cp = new CommandProcessorSend();

            cp.Prepare(ei);
            cp.Process((BackgroundWorker)sender);
        }

        private void progressBackgroundWorker_ProgressChanged(
            object sender,
            ProgressChangedEventArgs e)
        {
            var s = e.UserState as string;

            if (string.IsNullOrEmpty(s))
            {
                progressLabel.Visible = false;
                progressLabel.Text = string.Empty;
            }
            else
            {
                progressLabel.Visible = true;
                progressLabel.Text = s;
            }
        }

        private void progressBackgroundWorker_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error is CancelOperationException)
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
                if (openAfterGeneratingCheckEdit.Checked ||
                     openFileAfterGeneratingCheckEdit.Checked)
                {
                    wizardControl.SelectedPage = successWizardPage;
                    pleaseWaitFinishLabel.Visible = true;
                    wizardControl.FinishText = string.Empty;

                    UpdateUI();
                    Application.DoEvents();

                    try
                    {
                        if (openFileAfterGeneratingCheckEdit.Checked)
                        {
                            var path = destinationFileTextEdit.Text.Trim();

                            if (File.Exists(path))
                            {
                                Process.Start(path);
                            }
                        }
                        if (openAfterGeneratingCheckEdit.Checked)
                        {
                            var path =
                                Path.GetDirectoryName(
                                    destinationFileTextEdit.Text.Trim());
                            if (Directory.Exists(path))
                            {
                                Process.Start(path);
                            }
                        }
                    }
                    finally
                    {
                        DialogResult = DialogResult.OK;
                        Close();
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

        private void wizardControl_NextClick(
            object sender,
            WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == optionsWizardPage)
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
                wizardControl.SelectedPage = optionsWizardPage;
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
                        MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    checkStopBackgroundWorker();
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
                new CommandProcessorSendInformation
                    {
                        Project = _project,
                        ReferenceLanguageCode = ((Pair<string, string>)referenceLanguageGroupBox.SelectedItem).Second,
                        DestinationFilePath = destinationFileTextEdit.Text.Trim(),
                        EliminateDuplicateRows = eliminateDuplicateRowsCheckEdit.Checked,
                        OnlyExportRowsWithNoTranslation = exportWithoutDestinationTranslationOnlyCheckEdit.Checked,
                        ExportAllGroupsIntoOneWorksheet = exportGroupsAsOneWorkSheetCheckEdit.Checked,
                        ExportLanguageColumnsOnly = exportLanguageColumnsOnlyCheckEdit.Checked
                    };

            var groups = new List<FileGroup>();

            foreach (CheckedListBoxItem item in fileGroupsListBox.CheckedItems)
            {
                var p = (Pair<string, FileGroup>)item.Value;

                groups.Add(p.Second);
            }

            ei.FileGroups = groups.ToArray();

            var languages = new List<string>();

            foreach (CheckedListBoxItem item in languagesToExportCheckListBox.CheckedItems)
            {
                var p = (Pair<string, string>)item.Value;

                languages.Add(p.Second);
            }

            ei.DestinationLanguageCodes = languages.ToArray();

            // --

            progressBackgroundWorker.RunWorkerAsync(ei);
            UpdateUI();
        }

        private void underylingExceptionButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var form = new ObjectInspectorForm())
            {
                form.Initialize(_exception);
                form.ShowDialog(this);
            }
        }

        private void detailedErrorsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var form = new TextBoxForm())
            {
                var message = Logger.MakeTraceMessage(_exception);
                form.Initialize(message);

                form.ShowDialog(this);
            }
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
                FormHelper.SaveValue(
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
                eliminateDuplicateRowsCheckEdit.Checked = true;
                exportWithoutDestinationTranslationOnlyCheckEdit.Checked = true;
                exportGroupsAsOneWorkSheetCheckEdit.Checked = true;
                exportLanguageColumnsOnlyCheckEdit.Checked = true;

                advancedOptionsPanel.Visible = false;
                updateExpandState();

                _canResetOptions = false;
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
            _canResetOptions = true;
            UpdateUI();
        }

        private void exportLanguageColumnsOnlyCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            _canResetOptions = true;
            UpdateUI();
        }
    }

    /////////////////////////////////////////////////////////////////////////
}