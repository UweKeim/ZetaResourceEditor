namespace ZetaResourceEditor.UI.ExportImportExcel
{
    #region Using directives.
    // ----------------------------------------------------------------------

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;
    using Code;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraWizard;
    using Helper;
    using Helper.Base;
    using Helper.ErrorHandling;
    using Properties;
    using RuntimeBusinessLogic.ExportImportExcel.Import;
    using RuntimeBusinessLogic.FileGroups;
    using RuntimeBusinessLogic.Language;
    using RuntimeBusinessLogic.Projects;
    using Zeta.EnterpriseLibrary.Common;
    using Zeta.EnterpriseLibrary.Common.Collections;
    using Zeta.EnterpriseLibrary.Logging;
    using Zeta.EnterpriseLibrary.Tools.Miscellaneous;
    using Zeta.EnterpriseLibrary.Tools.Storage;
    using Zeta.EnterpriseLibrary.Windows.Persistance;
    using ZetaLongPaths;

    // ----------------------------------------------------------------------
    #endregion

    /////////////////////////////////////////////////////////////////////////

    public partial class ExcelImportWizardForm :
        FormBase
    {
        private FileGroupCollection _groups;
        private Project _project;
        private Exception _exception;

        private static readonly bool HasExcel =
            FileExtensionRegistration.IsFileExtensionRegistered(@".xls");

        private ExcelImportResult _bwResult;

        public ExcelImportWizardForm()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                wizardControl.Text = string.Empty;

                DevExpressExtensionMethods.MakeAutoComplete(
                    sourceFileTextEdit,
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

        public override void UpdateUI()
        {
            base.UpdateUI();

            if (wizardControl.SelectedPage == importFileWizardPage)
            {
                wizardControl.SelectedPage.AllowNext =
                    buttonOpen.Enabled =
                    sourceFileTextEdit.Text.Trim().Length > 0 &&
                    Path.GetExtension(sourceFileTextEdit.Text.Trim().ToLowerInvariant()) == @".xls" &&
                    ZlpIOHelper.FileExists(sourceFileTextEdit.Text.Trim());

                buttonOpen.Enabled = buttonOpen.Enabled && HasExcel;
            }
            else if (wizardControl.SelectedPage == fileGroupsWizardPage)
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
                    languagesToImportCheckListBox.Items.Count > 0;
                selectNoLanguagesToExportButton.Enabled =
                    languagesToImportCheckListBox.CheckedItems.Count > 0;
                selectAllLanguagesToExportButton.Enabled =
                    languagesToImportCheckListBox.Items.Count > 0 &&
                    languagesToImportCheckListBox.CheckedItems.Count <
                    languagesToImportCheckListBox.Items.Count;

                wizardControl.SelectedPage.AllowNext =
                    languagesToImportCheckListBox.CheckedItems.Count > 0;
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

        private void ImportWizard_Load(
            object sender,
            EventArgs e)
        {
            WinFormsPersistanceHelper.RestoreState(this);
            CenterToParent();

            InitiallyFillLists();
            FillItemToControls();

            UpdateUI();
        }

        private void ImportWizard_FormClosing(
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

        public override void FillItemToControls()
        {
            base.FillItemToControls();

            // Rest during runtime.
            summaryAfterSuccessfulImportLabel.Text = string.Empty;

            restoreState(_project.DynamicSettingsGlobalHierarchical);
        }

        private void saveState(
            IPersistentPairStorage storage)
        {
            PersistanceHelper.SaveValue(
                storage,
                @"receiveFileFromTranslator.sourceFilePathTextEdit.Text",
                sourceFileTextEdit.Text);

            DevExpressExtensionMethods.PersistSettings(
                fileGroupsListBox,
                storage,
                @"receiveFileFromTranslator.fileGroupsListBox");

            DevExpressExtensionMethods.PersistSettings(
                languagesToImportCheckListBox,
                storage,
                @"receiveFileFromTranslator.languagesToImportCheckListBox");
        }

        private void restoreState(
            IPersistentPairStorage storage)
        {
            sourceFileTextEdit.Text =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"receiveFileFromTranslator.sourceFilePathTextEdit.Text"));
        }

        private void wizardControl_CancelClick(object sender, CancelEventArgs e)
        {
            if (wizardControl.SelectedPage == progressWizardPage)
            {
                if (XtraMessageBox.Show(
                        this,
                        Resources.SR_ConfirmCancelImport,
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

        private void wizardControl_NextClick(object sender, WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == importFileWizardPage)
            {
                // If this is a filegroup-less XLS file, skip the file group
                // page completely.
                if (fileGroupsListBox.Items.Count <= 0)
                {
                    e.Handled = true;
                    wizardControl.SelectedPage = languagesWizardPage;
                }
                else
                {
                    e.Handled = true;
                    wizardControl.SelectedPage = fileGroupsWizardPage;
                }
            }
            else if (e.Page == languagesWizardPage)
            {
                e.Handled = true;
                wizardControl.SelectedPage = progressWizardPage;

                doImport();
            }
        }

        private void doImport()
        {
            var ei =
                new ExcelImportInformation
                {
                    Project = _project,
                    SourceFilePath = sourceFileTextEdit.Text.Trim(),
                };

            var groups = new List<FileGroup>();

            foreach (CheckedListBoxItem item in fileGroupsListBox.CheckedItems)
            {
                var p = (Pair<string, FileGroup>)item.Value;

                groups.Add(p.Second);
            }

            ei.FileGroups = groups.ToArray();

            var languages = new List<string>();

            foreach (CheckedListBoxItem item in languagesToImportCheckListBox.CheckedItems)
            {
                var p = (Pair<string, string>)item.Value;

                languages.Add(p.Second);
            }

            ei.LanguageCodes = languages.ToArray();

            // --

            progressBackgroundWorker.RunWorkerAsync(ei);
            UpdateUI();
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

        private void wizardControl_PrevClick(object sender, WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == languagesWizardPage)
            {
                // If this is a filegroup-less XLS file, skip the file group
                // page completely.
                if (fileGroupsListBox.Items.Count <= 0)
                {
                    e.Handled = true;
                    wizardControl.SelectedPage = importFileWizardPage;
                }
                else
                {
                    e.Handled = true;
                    wizardControl.SelectedPage = fileGroupsWizardPage;
                }
            }
            else if (e.Page == errorOccurredWizardPage)
            {
                wizardControl.SelectedPage = languagesWizardPage;
                e.Handled = true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (var form = new OpenFileDialog())
            {
                form.InitialDirectory =
                    (string)
                    PersistanceHelper.RestoreValue(
                        @"receiveFileFromTranslator.destinationFilePathTextEdit.InitialDirectory",
                        _project.ProjectConfigurationFilePath.DirectoryName);

                form.Multiselect = false;
                form.CheckFileExists = true;
                form.CheckPathExists = true;
                form.Filter = Resources.SR_ExportWizard_buttonBrowseClick_ExcelFilesXlsxls;

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    PersistanceHelper.SaveValue(
                        @"receiveFileFromTranslator.destinationFilePathTextEdit.InitialDirectory",
                        Path.GetDirectoryName(form.FileName));

                    sourceFileTextEdit.Text = form.FileName;

                    parseFileGroups();
                    parseLanguageCode();
                    UpdateUI();
                }
            }
        }

        private void parseFileGroups()
        {
            var fileGroups =
                ExcelImportController.DetectFileGroupsFromExcelFile(
                    _project,
                    sourceFileTextEdit.Text.Trim());

            fileGroupsListBox.Items.Clear();

            if (fileGroups != null)
            {
                foreach (var group in fileGroups)
                {
                    if (isMatchingFileGroup(group))
                    {
                        var index = fileGroupsListBox.Items.Add(
                            new Pair<string, FileGroup>(
                                group.GetNameIntelligent(_project),
                                group));

                        fileGroupsListBox.SetItemChecked(index, true);
                    }
                }

                if (fileGroups.Length == 1)
                {
                    // Select one, if only one present.
                    selectAllFileGroupsButton_Click(null, null);
                }

                // -- 
                // Try to restore.

                DevExpressExtensionMethods.RestoreSettings(
                    fileGroupsListBox,
                    _project.DynamicSettingsGlobalHierarchical,
                    @"receiveFileFromTranslator.fileGroupsListBox");
            }
        }

        private bool isMatchingFileGroup(FileGroup group)
        {
            foreach (var allowedGroup in _groups)
            {
                if (allowedGroup.GetChecksum(_project) == group.GetChecksum(_project))
                {
                    return true;
                }
            }

            return false;
        }

        private void parseLanguageCode()
        {
            var languageCodes =
                ExcelImportController.DetectLanguagesFromExcelFile(
                    sourceFileTextEdit.Text.Trim());

            languagesToImportCheckListBox.Items.Clear();

            if (languageCodes != null)
            {
                foreach (var languageCode in languageCodes)
                {
                    if (!string.IsNullOrEmpty(languageCode) &&
                        LanguageCodeDetection.IsValidCultureName(languageCode))
                    {
                        var index = languagesToImportCheckListBox.Items.Add(
                            new Pair<string, string>(
                                string.Format(
                                    @"{0} ({1})",
                                    LanguageCodeDetection.MakeValidCulture(languageCode).DisplayName,
                                    languageCode),
                                languageCode));

                        languagesToImportCheckListBox.SetItemChecked(index, true);
                    }
                }

                if (languageCodes.Length == 1)
                {
                    // Select one, if only one present.
                    selectAllLanguagesToExportButton_Click(null, null);
                }
            }

            // -- 
            // Try to restore.

            DevExpressExtensionMethods.RestoreSettings(
                languagesToImportCheckListBox,
                _project.DynamicSettingsGlobalHierarchical,
                @"receiveFileFromTranslator.languagesToImportCheckListBox");
        }

        private void sourceFileTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            parseFileGroups();
            parseLanguageCode();
            UpdateUI();
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

        private void languagesToImportCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void languagesToImportCheckListBox_ItemCheck(
            object sender,
            DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
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

        private void progressBackgroundWorker_DoWork(
            object sender,
            DoWorkEventArgs e)
        {
            Host.ApplyLanguageSettingsToCurrentThread();

            var ei = (ExcelImportInformation)e.Argument;
            var cp = new ExcelImportController();

            cp.Prepare(ei);
            _bwResult = cp.Process((BackgroundWorker)sender);
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
                summaryAfterSuccessfulImportLabel.Text =
                    string.Format(
                        Resources.SR_ImportWizardForm_progressBackgroundWorker_RunWorkerCompleted_Result,
                        _bwResult.ImportedRowCount);

                simpleButton1.Visible = _bwResult.ImportedRowCount <= 0;

                if (_bwResult.ImportMessages.Count > 0)
                {
                    summaryAfterSuccessfulImportLabel.Text = summaryAfterSuccessfulImportLabel.Text.Trim();
                    summaryAfterSuccessfulImportLabel.Text += Environment.NewLine;
                    summaryAfterSuccessfulImportLabel.Text += Environment.NewLine;

                    foreach (var importMessage in _bwResult.ImportMessages)
                    {
                        summaryAfterSuccessfulImportLabel.Text += importMessage.Trim();
                        summaryAfterSuccessfulImportLabel.Text += Environment.NewLine;
                        summaryAfterSuccessfulImportLabel.Text += Environment.NewLine;
                    }
                }
                else if (_bwResult.ImportedRowCount <= 0)
                {
                    pictureBox2.Image = Resources.sign_warning;
                }

                wizardControl.SelectedPage = successWizardPage;
                UpdateUI();
            }
        }
        private void optionsPopupMenu_BeforePopup(object sender, CancelEventArgs e)
        {
            UpdateUI();
        }

        private void selectAllLanguagesToExportButton_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < languagesToImportCheckListBox.Items.Count; ++index)
            {
                languagesToImportCheckListBox.SetItemChecked(index, true);
            }
        }

        private void selectNoLanguagesToExportButton_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < languagesToImportCheckListBox.Items.Count; ++index)
            {
                languagesToImportCheckListBox.SetItemChecked(index, false);
            }
        }

        private void invertLanguagesToExportButton_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < languagesToImportCheckListBox.Items.Count; ++index)
            {
                languagesToImportCheckListBox.SetItemChecked(
                    index,
                    !languagesToImportCheckListBox.GetItemChecked(index));
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Process.Start(sourceFileTextEdit.Text.Trim());
        }

        private void wizardControl_SelectedPageChanged(object sender, WizardPageChangedEventArgs e)
        {
            UpdateUI();
        }

        private void cmdImportFormatInfo_Click(object sender, EventArgs e)
        {
            using (var form = new ExcelImportFormatInformationForm())
            {
                form.ShowDialog(this);
            }
        }
    }

    /////////////////////////////////////////////////////////////////////////
}