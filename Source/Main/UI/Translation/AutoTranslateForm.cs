namespace ZetaResourceEditor.UI.Translation
{
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using Helper;
    using Helper.Base;
    using Helper.Progress;
    using Main;
    using Main.RightContent;
    using Properties;
    using RuntimeBusinessLogic.ExportImportExcel.Export;
    using RuntimeBusinessLogic.FileGroups;
    using RuntimeBusinessLogic.Language;
    using RuntimeBusinessLogic.Projects;
    using RuntimeBusinessLogic.Snapshots;
    using RuntimeBusinessLogic.Translation;
    using RuntimeBusinessLogic.Translation.Google;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Windows.Forms;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Tools.Storage;
    using Zeta.VoyagerLibrary.WinForms.Common;
    using Zeta.VoyagerLibrary.WinForms.Persistance;

    public partial class AutoTranslateForm :
        FormBase
    {
        private bool _isException;

        public static bool CheckShowAppIDsMissing()
        {
            var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

            var ti = TranslationHelper.GetTranslationEngine(project);

            TranslationHelper.GetTranslationAppID(
                project,
                out var appID);

            if (ti.AreAppIDsSyntacticallyValid(appID))
            {
                return false;
            }
            else
            {
                if (XtraMessageBox.Show(
                        ActiveForm,
                        Resources.AutoTranslateForm_CheckShowAppIDsMissing,
                        @"Zeta Resource Editor",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    using var form = new TranslateOptionsForm();
                    form.Initialize(project);

                    return form.ShowDialog(ActiveForm) == DialogResult.OK;
                }
                else
                {
                    return false;
                }
            }
        }

        public static void CheckShowNewTranslationInfos()
        {
            var version = PersistanceHelper.RestoreValue(@"TranslationInfos.LastShownVersion");
            var show =
                version == null ||
                new Version(version.ToString()) < new Version(2, 2, 0, 10) &&
                new Version(version.ToString()) < Assembly.GetExecutingAssembly().GetName().Version;

            if (show)
            {
                PersistanceHelper.SaveValue(
                    @"TranslationInfos.LastShownVersion",
                    Assembly.GetExecutingAssembly().GetName().Version);

                if (XtraMessageBox.Show(
                        ActiveForm,
                        Resources.HowToGoogleTranslate,
                        @"Zeta Resource Editor",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Process.Start(((ITranslationEngine)new GoogleRestfulTranslationEngine()).AppIDLink);
                }
            }
        }

        private ResourceEditorUserControl _fileGroupControl;
        private bool _initialAllowUpdatingDetails;
        private Project _project;
        private bool _ignore;
        private bool _insideUpdateUI;

        public AutoTranslateForm()
        {
            InitializeComponent();
        }

        public void Initialize(
            ResourceEditorUserControl fileGroupControl)
        {
            _fileGroupControl = fileGroupControl;
            _project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

            // --

            _fileGroupControl.GridEditableData.Project ??= _project;
        }

        private IEnumerable<string> languageCodes => _fileGroupControl.GridEditableData.GetLanguageCodes(_project);

        public override void UpdateUI()
        {
            base.UpdateUI();

            if (_insideUpdateUI) return;
            _insideUpdateUI = true;

            buttonTranslate.Enabled =
                referenceLanguageGroupBox.SelectedIndex >= 0 &&
                languagesToTranslateCheckListBox.CheckedItems.Count > 0 &&
                (!prefixCheckBox.Checked || prefixTextBox.Text.Trim().Length > 0);

            buttonInvert.Enabled =
                languagesToTranslateCheckListBox.Items.Count > 0;
            buttonNone.Enabled =
                languagesToTranslateCheckListBox.CheckedItems.Count > 0;
            buttonAll.Enabled =
                languagesToTranslateCheckListBox.Items.Count > 0 &&
                languagesToTranslateCheckListBox.CheckedItems.Count <
                languagesToTranslateCheckListBox.Items.Count;

            prefixTextBox.Enabled =
                buttonDefault.Enabled =
                    prefixCheckBox.Checked;

            buttonSettings.Enabled = _project != null;

            _insideUpdateUI = false;
        }

        protected override void InitiallyFillLists()
        {
            base.InitiallyFillLists();

            var infos = new List<TranslationLanguageInfo>();

            TranslationHelper.GetTranslationAppID(
                MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                out var appID);

            var ti = TranslationHelper.GetTranslationEngine(_project);

            //try
            //{
            var lcs = ti.AreAppIDsSyntacticallyValid(appID)
                ? ti.GetSourceLanguages(appID)
                : new TranslationLanguageInfo[] { };
            //}
            //catch (Exception e) when (e is WebException || e is HttpException)
            //{
            //    // Hier Exception nicht durchlassen,
            //    // Damit der Dialog nicht undefiniert gefüllt ist.

            //    LogCentral.Current.Warn(e);

            //    lcs = new TranslationLanguageInfo[] { };

            //    Host.NotifyAboutException(e);
            //}

            foreach (var languageCode in languageCodes)
            {
                // Only translate those that are supported.
                if (TranslationHelper.IsSupportedLanguage(languageCode, lcs))
                {
                    if (string.IsNullOrEmpty(languageCode))
                    {
                        infos.Add(
                            new TranslationLanguageInfo
                            {
                                UserReadableName = Resources.SR_TranslationHelper_GetSourceLanguages_AutoDetect,
                                LanguageCode = string.Empty
                            });
                    }
                    else
                    {
                        infos.Add(
                            new TranslationLanguageInfo
                            {
                                UserReadableName =
                                    $@"{
                                            LanguageCodeDetection.MakeValidCulture(languageCode).DisplayName
                                        } ({languageCode})",
                                LanguageCode = languageCode
                            });
                    }
                }
            }

            infos.Sort((x, y) => string.CompareOrdinal(x.UserReadableName, y.UserReadableName));

            referenceLanguageGroupBox.Properties.Items.Clear();
            foreach (var info in infos)
            {
                referenceLanguageGroupBox.Properties.Items.Add(info);
            }

            // --
            // Select defaults.

            _ignore = true;
            if (referenceLanguageGroupBox.SelectedIndex < 0 &&
                referenceLanguageGroupBox.Properties.Items.Count > 0)
            {
                referenceLanguageGroupBox.SelectedIndex = 0;
            }

            _ignore = false;
        }

        private void restoreState(
            IPersistentPairStorage storage)
        {
            prefixTextBox.Text =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"autoTranslateForm.prefixTextBox.Text",
                        prefixTextBox.Text));

            prefixCheckBox.Checked =
                ConvertHelper.ToBoolean(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"autoTranslateForm.prefixCheckBox.Checked",
                        prefixCheckBox.Checked));

            useExistingTranslationsCheckBox.Checked =
                ConvertHelper.ToBoolean(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"autoTranslateForm.useExistingTranslationsCheckBox.Checked",
                        useExistingTranslationsCheckBox.Checked));

            useOnlyExistingTranslationsCheckEdit.Checked =
                ConvertHelper.ToBoolean(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"autoTranslateForm.useOnlyExistingTranslationsCheckEdit.Checked",
                        useOnlyExistingTranslationsCheckEdit.Checked));

            _ignore = true;
            referenceLanguageGroupBox.SelectedIndex =
                Math.Min(
                    ConvertHelper.ToInt32(
                        PersistanceHelper.RestoreValue(
                            storage,
                            @"autoTranslateForm.referenceLanguageComboBoxEdit.SelectedIndex",
                            referenceLanguageGroupBox.SelectedIndex)),
                    referenceLanguageGroupBox.Properties.Items.Count - 1);
            _ignore = false;

            refillLanguagesToTranslate();

            DevExpressExtensionMethods.RestoreSettings(
                languagesToTranslateCheckListBox,
                storage,
                @"autoTranslateForm.languagesToTranslateCheckListBox");
        }

        private void saveState(
            IPersistentPairStorage storage)
        {
            PersistanceHelper.SaveValue(
                storage,
                @"autoTranslateForm.prefixTextBox.Text",
                prefixTextBox.Text);

            PersistanceHelper.SaveValue(
                storage,
                @"autoTranslateForm.prefixCheckBox.Checked",
                prefixCheckBox.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"autoTranslateForm.useExistingTranslationsCheckBox.Checked",
                useExistingTranslationsCheckBox.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"autoTranslateForm.useOnlyExistingTranslationsCheckEdit.Checked",
                useOnlyExistingTranslationsCheckEdit.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"autoTranslateForm.referenceLanguageComboBoxEdit.SelectedIndex",
                referenceLanguageGroupBox.SelectedIndex);

            DevExpressExtensionMethods.PersistSettings(
                languagesToTranslateCheckListBox,
                storage,
                @"autoTranslateForm.languagesToTranslateCheckListBox");
        }

        protected override void FillItemToControls()
        {
            base.FillItemToControls();

            fileGroupTextBox.Text =
                _fileGroupControl.GridEditableData.GetNameIntelligent(_project);

            prefixTextBox.Text = FileGroup.DefaultTranslatedPrefix;

            // --

            if (_project != null)
            {
                restoreState(
                    _project.DynamicSettingsGlobalHierarchical);
            }

            var ti = TranslationHelper.GetTranslationEngine(_project);
            labelControl1.Text = ti.UserReadableName;
        }

        private void refillLanguagesToTranslate()
        {
            var ti = TranslationHelper.GetTranslationEngine(_project);

            languagesToTranslateCheckListBox.Items.Clear();

            TranslationHelper.GetTranslationAppID(
                MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                out var appID);

            var forbidden =
                referenceLanguageGroupBox.SelectedIndex >= 0 &&
                referenceLanguageGroupBox.SelectedIndex <
                referenceLanguageGroupBox.Properties.Items.Count
                    ? ((TranslationLanguageInfo)referenceLanguageGroupBox.SelectedItem).LanguageCode
                    : string.Empty;

            var lcs =
                ti.AreAppIDsSyntacticallyValid(appID)
                    ? ti.GetDestinationLanguages(appID)
                    : new TranslationLanguageInfo[] { };

            foreach (var languageCode in languageCodes)
            {
                if (!string.IsNullOrEmpty(languageCode) &&
                    languageCode != forbidden)
                {
                    // Only add those that are supported.
                    if (TranslationHelper.IsSupportedLanguage(
                        languageCode, lcs))
                    {
                        var index = languagesToTranslateCheckListBox.Items.Add(
                            new TranslationLanguageInfo
                            {
                                UserReadableName =
                                    $@"{
                                            LanguageCodeDetection.MakeValidCulture(languageCode).DisplayName
                                        } ({languageCode})",
                                LanguageCode = languageCode
                            });

                        languagesToTranslateCheckListBox.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void autoTranslateForm_Load(object sender, EventArgs e)
        {
            try
            {
                WinFormsPersistanceHelper.RestoreState(this);
                CenterToParent();

                InitiallyFillLists();
                FillItemToControls();

                _initialAllowUpdatingDetails = _fileGroupControl.AllowUpdatingDetails;
                _fileGroupControl.AllowUpdatingDetails = false;

                UpdateUI();
            }
            catch (Exception)
            {
                _isException = true;
                Close();
                throw;
            }
        }

        private void autoTranslateForm_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (!_isException)
            {
                _fileGroupControl.AllowUpdatingDetails = _initialAllowUpdatingDetails;

                WinFormsPersistanceHelper.SaveState(this);

                if (_project != null)
                {
                    using (new SilentProjectStoreGuard(_project))
                    {
                        saveState(_project.DynamicSettingsGlobalHierarchical);
                    }
                }
            }
        }

        private void fileGroupTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void referenceLanguageGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_ignore)
            {
                refillLanguagesToTranslate();
                UpdateUI();
            }
        }

        private void languagesToTranslateCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void updateUITimer_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < languagesToTranslateCheckListBox.Items.Count; ++index)
            {
                languagesToTranslateCheckListBox.SetItemChecked(index, true);
            }
        }

        private void buttonNone_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < languagesToTranslateCheckListBox.Items.Count; ++index)
            {
                languagesToTranslateCheckListBox.SetItemChecked(index, false);
            }
        }

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < languagesToTranslateCheckListBox.Items.Count; ++index)
            {
                languagesToTranslateCheckListBox.SetItemChecked(
                    index,
                    !languagesToTranslateCheckListBox.GetItemChecked(index));
            }
        }

        private void autoTranslateForm_Shown(object sender, EventArgs e)
        {
            try
            {
                updateUITimer.Start();
                CheckShowNewTranslationInfos();

                if (CheckShowAppIDsMissing())
                {
                    InitiallyFillLists();
                    FillItemToControls();
                }
            }
            catch (Exception)
            {
                _isException = true;
                Close();
                throw;
            }
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            var success = false;
            var cancelled = false;
            var table = _fileGroupControl.GetDataSource();
            var translationCount = 0;
            var translationSuccessCount = 0;
            var translationErrorCount = 0;
            var internallyExistingTranslationTranslatedSuccessCount = 0;

            var continueOnErrors = _project == null || _project.TranslationContinueOnErrors;
            var delayMilliseconds = _project?.TranslationDelayMilliseconds ?? 500;

            var gridEditableData = _fileGroupControl.GridEditableData;

            var prefixSuccess =
                prefixCheckBox.Checked
                    ? prefixTextBox.Text.Trim() + @" "
                    : string.Empty;
            var useExistingTranslations = useExistingTranslationsCheckBox.Checked;
            var useExistingTranslationsOnly = useOnlyExistingTranslationsCheckEdit.Checked;

            var prefixError = FileGroup.DefaultTranslationErrorPrefix.Trim() + @" ";

            var refLanguageCode =
                ((TranslationLanguageInfo)referenceLanguageGroupBox.SelectedItem).LanguageCode;
            var toTranslateLanguageCodes = new List<string>();

            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (CheckedListBoxItem item in languagesToTranslateCheckListBox.CheckedItems)
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                var pair = (TranslationLanguageInfo)item.Value;

                toTranslateLanguageCodes.Add(pair.LanguageCode.ToLowerInvariant());
            }

            // --
            // 2017-04-15.

            var prevPause = MainForm.Current.ProjectFilesControl.WantPauseNodeStateUpdate;
            MainForm.Current.ProjectFilesControl.WantPauseNodeStateUpdate = true;

            _fileGroupControl.IsTranslating = true;
            try
            {

                using (
                    new BackgroundWorkerLongProgressGui(
                        delegate (
                            object s,
                            DoWorkEventArgs _)
                        {
                            var bw = (BackgroundWorker)s;

                            var imtc = new InMemoryTranslationSnapshotController();
                            var imss = useExistingTranslations
                                ? imtc.CreateSnapshot(_project,
                                    toTranslateLanguageCodes.Concat(new[] { refLanguageCode }).ToArray(),
                                    bw)
                                : null;

                            // Column 0=FileGroup checksum, column 1=Tag name.
                            var refValueIndex = 2;

#pragma warning disable 618, 612
                            var prev = DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection;
                            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
#pragma warning restore 618, 612

                            try
                            {
                                foreach (DataColumn column in table.Columns)
                                {
                                    // Column 0=FileGroup checksum, column 1=Tag name.
                                    if (column.Ordinal > 1)
                                    {
                                        var raw =
                                            ExcelExportController.IsFileName(column.ColumnName)
                                                ? new LanguageCodeDetection(_project)
                                                    .DetectLanguageCodeFromFileName(
                                                        gridEditableData.ParentSettings,
                                                        column.ColumnName)
                                                : column.ColumnName;

                                        if (refLanguageCode == raw)
                                        {
                                            refValueIndex = column.Ordinal;
                                            break;
                                        }
                                    }
                                }

                                // --

                                var ti = TranslationHelper.GetTranslationEngine(_project);

                                TranslationHelper.GetTranslationAppID(
                                    MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
                                    out var appID);

                                foreach (DataColumn column in table.Columns)
                                {
                                    // Column 0=FileGroup checksum, column 1=Tag name.
                                    if (column.Ordinal > 1 && column.Ordinal != refValueIndex)
                                    {
                                        var raw =
                                            ExcelExportController.IsFileName(column.ColumnName)
                                                ? new LanguageCodeDetection(_project)
                                                    .DetectLanguageCodeFromFileName(
                                                        gridEditableData.ParentSettings,
                                                        column.ColumnName)
                                                : column.ColumnName;

                                        if (toTranslateLanguageCodes.Contains(raw.ToLowerInvariant()))
                                        {
                                            if (ti.SupportsArrayTranslation)
                                            {
                                                translationSuccessCount =
                                                    translateArray(
                                                        appID,
                                                        ti,
                                                        table,
                                                        refLanguageCode,
                                                        column,
                                                        refValueIndex,
                                                        raw,
                                                        bw,
                                                        delayMilliseconds,
                                                        prefixSuccess,
                                                        useExistingTranslations,
                                                        useExistingTranslationsOnly,
                                                        imss,
                                                        translationSuccessCount,
                                                        ref translationErrorCount,
                                                        continueOnErrors,
                                                        prefixError,
                                                        ref translationCount,
                                                        ref internallyExistingTranslationTranslatedSuccessCount);
                                            }
                                            else
                                            {
                                                translationSuccessCount =
                                                    translateSingle(
                                                        appID,
                                                        ti,
                                                        table,
                                                        refLanguageCode,
                                                        column,
                                                        refValueIndex,
                                                        raw,
                                                        bw,
                                                        delayMilliseconds,
                                                        prefixSuccess,
                                                        useExistingTranslations,
                                                        useExistingTranslationsOnly,
                                                        imss,
                                                        translationSuccessCount,
                                                        ref translationErrorCount,
                                                        continueOnErrors,
                                                        prefixError,
                                                        ref translationCount,
                                                        ref internallyExistingTranslationTranslatedSuccessCount);
                                            }
                                        }
                                    }
                                }
                            }
                            catch (OperationCanceledException)
                            {
                                // Do nothing.
                            }
                            finally
                            {
#pragma warning disable 618, 612
                                DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = prev;
#pragma warning restore 618, 612

                                MainForm.Current.ProjectFilesControl.WantPauseNodeStateUpdate = prevPause;
                            }
                        },
                        delegate (object _, RunWorkerCompletedEventArgs a)
                        {
                            success = !a.Cancelled && a.Error == null;
                            cancelled = a.Cancelled;
                        },
                        BackgroundWorkerLongProgressGui.CancellationMode.Cancelable
                    ))
                {
                }
            }
            finally
            {
                _fileGroupControl.IsTranslating = false;
            }

            if (translationCount > 0)
            {
                _fileGroupControl.MarkGridContentAsModified();
                _fileGroupControl.MarkAsModified();
                _fileGroupControl.UpdateUI();
            }

            var message = string.Format(
                Resources.SR_AutoTranslateForm_buttonTranslateClick_TranslatingTranslatedTexts,
                translationCount,
                translationSuccessCount,
                translationErrorCount);

            if (useExistingTranslations)
            {
                message += @" " + string.Format(
                               Resources.SR_AutoTranslateForm_buttonTranslateClick_TranslatingTranslatedTextsExisting,
                               internallyExistingTranslationTranslatedSuccessCount);
            }

            XtraMessageBox.Show(
                this,
                message,
                @"Zeta Resource Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (success || cancelled)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private int translateSingle(
            string appID,
            ITranslationEngine ti,
            DataTable table,
            string refLanguageCode,
            DataColumn column,
            int refValueIndex,
            string raw,
            BackgroundWorker bw,
            int delayMilliseconds,
            string prefixSuccess,
            bool useExistingTranslations,
            bool useExistingTranslationsOnly,
            InMemoryTranslationSnapshot imss,
            int translationSuccessCount,
            ref int translationErrorCount,
            bool continueOnErrors,
            string prefixError,
            ref int translationCount,
            ref int internallyExistingTranslationTranslatedSuccessCount)
        {
            if (column != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row != null)
                    {
                        if (bw.CancellationPending) throw new OperationCanceledException();

                        var text = row[column] as string;
                        if (!string.IsNullOrEmpty(text) && text.Trim().Length > 0) continue;

                        // http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx?msg=3367544#xx3367544xx
                        if (FileGroup.IsInternalRow(row)) continue;

                        var sourceText = row[refValueIndex] as string;

                        if (string.IsNullOrEmpty(sourceText)) continue;

                        if (delayMilliseconds > 0) Thread.Sleep(delayMilliseconds);

                        try
                        {
                            var sourceLanguageCode = ti.MapCultureToSourceLanguageCode(
                                appID,
                                CultureHelper.CreateCultureErrorTolerant(refLanguageCode));
                            var destinationLanguageCode = ti.MapCultureToDestinationLanguageCode(
                                appID,
                                CultureHelper.CreateCultureErrorTolerant(raw));

                            var doIt = true;

                            // Ggf. aus Cache holen.
                            if (useExistingTranslations)
                            {
                                var dstText = imss?.GetTranslation(refLanguageCode, raw, sourceText);
                                if (dstText != null)
                                {
                                    row[column] = dstText;

                                    translationSuccessCount++;
                                    internallyExistingTranslationTranslatedSuccessCount++;

                                    doIt = false;
                                }
                            }

                            if (!useExistingTranslationsOnly && doIt)
                            {
                                var destinationText =
                                    prefixSuccess +
                                    ti.Translate(
                                        appID,
                                        sourceText,
                                        sourceLanguageCode,
                                        destinationLanguageCode,
                                        _project.TranslationWordsToProtect,
                                        _project.TranslationWordsToRemove);

                                row[column] = destinationText;

                                // Merken für ggf. nächsten Durchlauf.
                                if (useExistingTranslations)
                                {
                                    imss?.AddTranslation(refLanguageCode, raw, sourceText, destinationText);
                                }

                                translationSuccessCount++;
                            }
                        }
                        catch (Exception x)
                        {
                            translationErrorCount++;

                            if (continueOnErrors)
                            {
                                var destinationText = prefixError + x.Message;

                                if (row[column] != null) row[column] = destinationText;
                            }
                            else
                            {
                                throw;
                            }
                        }

                        translationCount++;
                    }
                }
            }

            return translationSuccessCount;
        }

        private class TranslateItemInfo
        {
            public DataRow Row { get; set; }
            public string SourceText { get; set; }
        }

        private int translateArray(
            string appID,
            ITranslationEngine ti,
            DataTable table,
            string refLanguageCode,
            DataColumn column,
            int refValueIndex,
            string raw,
            BackgroundWorker bw,
            int delayMilliseconds,
            string prefixSuccess,
            bool useExistingTranslations,
            bool useExistingTranslationsOnly,
            InMemoryTranslationSnapshot imss,
            int translationSuccessCount,
            ref int translationErrorCount,
            bool continueOnErrors,
            string prefixError,
            ref int translationCount,
            ref int internallyExistingTranslationTranslatedSuccessCount)
        {
            var items = new List<TranslateItemInfo>();

            // --
            // From GUI to in-memory-list.

            if (column != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    items.Clear();
                    if (row != null)
                    {
                        if (bw.CancellationPending)
                        {
                            throw new OperationCanceledException();
                        }

                        var text = row[column] as string;
                        if (!string.IsNullOrEmpty(text) && text.Trim().Length > 0)
                        {
                            continue;
                        }

                        // http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx?msg=3367544#xx3367544xx
                        if (FileGroup.IsInternalRow(row))
                        {
                            continue;
                        }

                        var sourceText = row[refValueIndex] as string;

                        if (string.IsNullOrEmpty(sourceText))
                        {
                            continue;
                        }

                        items.Add(new TranslateItemInfo { Row = row, SourceText = sourceText });
                    }

                    // --
                    // Pack into blocks.

                    var blocks = new List<List<TranslateItemInfo>>();

                    for (var index = 0; index < items.Count; index++)
                    {
                        if (index % ti.MaxArraySize == 0)
                        {
                            blocks.Add(new List<TranslateItemInfo>());
                        }

                        blocks[blocks.Count - 1].Add(items[index]);
                    }

                    // --
                    // Translate each block in batch.

                    foreach (var block in blocks)
                    {
                        if (block != null)
                        {
                            if (bw.CancellationPending)
                            {
                                throw new OperationCanceledException();
                            }

                            if (delayMilliseconds > 0)
                            {
                                Thread.Sleep(delayMilliseconds);
                            }

                            var sourceTexts = block.Select(itemInfo => itemInfo.SourceText).ToList();

                            try
                            {
                                var sourceLanguageCode = ti.MapCultureToSourceLanguageCode(
                                    appID,
                                    CultureHelper.CreateCultureErrorTolerant(refLanguageCode));
                                var destinationLanguageCode = ti.MapCultureToDestinationLanguageCode(
                                    appID,
                                    CultureHelper.CreateCultureErrorTolerant(raw));

                                if (useExistingTranslations)
                                {
                                    // Alle die nehmen, die schon übersetzt sind. Also quasi "aus Cache".
                                    for (var index = 0; index < sourceTexts.Count; ++index)
                                    {
                                        var dstText = imss?.GetTranslation(refLanguageCode, raw, sourceTexts[index]);
                                        if (dstText != null)
                                        {
                                            block[index].Row[column] = prefixSuccess + dstText;

                                            translationSuccessCount++;
                                            internallyExistingTranslationTranslatedSuccessCount++;

                                            sourceTexts[index] = string.Empty; // Markieren als "erledigt".
                                        }
                                    }
                                }

                                if (!useExistingTranslationsOnly && sourceTexts.Any(s => !string.IsNullOrEmpty(s)))
                                {
                                    var destinationTexts =
                                        ti.TranslateArray(
                                            appID,
                                            sourceTexts.ToArray(),
                                            sourceLanguageCode,
                                            destinationLanguageCode,
                                            _project.TranslationWordsToProtect,
                                            _project.TranslationWordsToRemove);

                                    for (var index = 0; index < block.Count; ++index)
                                    {
                                        if (destinationTexts[index] != null)
                                        {
                                            block[index].Row[column] = prefixSuccess + destinationTexts[index];

                                            // Merken für ggf. nächsten Durchlauf.
                                            if (useExistingTranslations)
                                            {
                                                imss?.AddTranslation(
                                                    refLanguageCode,
                                                    raw,
                                                    sourceTexts[index],
                                                    destinationTexts[index]);
                                            }

                                            translationSuccessCount++;
                                        }
                                    }
                                }
                            }
                            catch (Exception x)
                            {
                                translationErrorCount++;

                                if (continueOnErrors)
                                {
                                    var destinationText = prefixError + x.Message;

                                    foreach (var t in block)
                                    {
                                        if (t?.Row?[column] != null) t.Row[column] = destinationText;
                                    }
                                }
                                else
                                {
                                    throw;
                                }
                            }

                            translationCount++;
                        }
                    }
                }
            }

            return translationSuccessCount;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void prefixTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void languagesToTranslateCheckListBox_ItemCheck(
            object sender,
            DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            UpdateUI();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            prefixTextBox.Text = FileGroup.DefaultTranslatedPrefix;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            using var form = new TranslateOptionsForm();
            form.Initialize(_project);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (form.TranslationProviderChanged)
                {
                    using (new WaitCursor(this))
                    {
                        InitiallyFillLists();
                        FillItemToControls();
                    }
                }

                UpdateUI();
            }
        }

        private void useExistingTranslationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();

            // Must uncheck also.
            if (!useExistingTranslationsCheckBox.Checked) useOnlyExistingTranslationsCheckEdit.Checked = false;
        }

        private void useOnlyExistingTranslationsCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();

            // Must check also.
            if (useOnlyExistingTranslationsCheckEdit.Checked) useExistingTranslationsCheckBox.Checked = true;
        }
    }
}