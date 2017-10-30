using System.Linq;
using DevExpress.XtraPrinting.Native;
using ZetaResourceEditor.UI.Helper;

namespace ZetaResourceEditor.UI.FileGroups
{
    using DevExpress.XtraEditors;
    using Helper.Base;
    using Main;
    using Properties;
    using RuntimeBusinessLogic.FileGroups;
    using RuntimeBusinessLogic.Language;
    using RuntimeBusinessLogic.Projects;
    using RuntimeBusinessLogic.Translation;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using Translation;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Common.Collections;
    using Zeta.VoyagerLibrary.Tools.Storage;
    using Zeta.VoyagerLibrary.WinForms.Common;
    using Zeta.VoyagerLibrary.WinForms.Persistance;

    public partial class CreateNewFileForm :
        FormBase
    {
        private FileGroup _fileGroup;

        public CreateNewFileForm()
        {
            InitializeComponent();
        }

        public void Initialize(
            FileGroup fileGroup)
        {
            _fileGroup = fileGroup;
        }

        private IEnumerable<MyTuple<string, string>> languageCodes => _fileGroup.GetLanguageCodesExtended(
            MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);

        protected override void InitiallyFillLists()
        {
            foreach (var languageCode in languageCodes)
            {
                if (!string.IsNullOrEmpty(languageCode.Item1))
                {
                    referenceLanguageComboBox.Properties.Items.Add(
                        new MyTuple<string, MyTuple<string, string>>(
                            $@"{LanguageCodeDetection.MakeValidCulture(languageCode.Item1).DisplayName} ({languageCode})",
                            languageCode));
                }
            }

            var items = new List<MyTuple<string, CultureInfo>>();

            foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                items.Add(new MyTuple<string, CultureInfo>(culture.DisplayName, culture));
            }

            items.Sort((x, y) => string.CompareOrdinal(x.Item1, y.Item1));

            foreach (var item in items)
            {
                newLanguageComboBox.Properties.Items.Add(item);
            }

            // --

            fillTranslationEngine();
        }

        private void fillTranslationEngine()
        {
            var ti = TranslationHelper.GetTranslationEngine(
                MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);
            labelControl3.Text = ti.UserReadableName;
        }

        private void updateIncludeFileInCsprojControls()
        {
            CsProjectWithFileResult csProject = _fileGroup.GetConnectedCsProject();

            IncludeFileInCsprojChecBox.Enabled = (csProject?.Project != null);
            AddFileAsDependantUponCheckBox.Enabled = IncludeFileInCsprojChecBox.Checked && !String.IsNullOrEmpty(csProject?.DependantUponRootFileName);
            if (!AddFileAsDependantUponCheckBox.Enabled)
            {
                AddFileAsDependantUponCheckBox.Checked = false;
            }

            labelCsProjectToAdd.Text = $"({new FileInfo(csProject?.Project.FullPath)?.Name})";
        }

        public override void UpdateUI()
        {
            base.UpdateUI();

            buttonOK.Enabled =
                referenceLanguageComboBox.SelectedItem != null &&
                newLanguageComboBox.SelectedItem != null &&
                string.Compare(
                    ((MyTuple<string, MyTuple<string, string>>)referenceLanguageComboBox.SelectedItem).Item2.Item1,
                    ((MyTuple<string, CultureInfo>)newLanguageComboBox.SelectedItem).Item2.Name,
                    StringComparison.OrdinalIgnoreCase) != 0 &&
                newFileNameTextBox.Text.Trim().Length > 0 &&
                newFileNameTextBox.Text.Trim().IndexOfAny(Path.GetInvalidFileNameChars()) < 0 &&
                (!prefixCheckBox.Checked || prefixTextBox.Text.Trim().Length > 0);

            updateIncludeFileInCsprojControls();

            // --

            automaticallyTranslateCheckBox.Enabled =
                copyTextsCheckBox.Checked;

            if (!automaticallyTranslateCheckBox.Enabled)
            {
                automaticallyTranslateCheckBox.Checked = false;
            }

            if (!automaticallyTranslateCheckBox.Checked)
            {
                prefixCheckBox.Checked = false;
            }

            prefixCheckBox.Enabled =
                            automaticallyTranslateCheckBox.Checked;

            prefixTextBox.Enabled =
                buttonDefault.Enabled =
                automaticallyTranslateCheckBox.Checked &&
                prefixCheckBox.Checked;
        }

        protected override void FillItemToControls()
        {
            base.FillItemToControls();

            fileGroupTextBox.Text =
                _fileGroup.GetNameIntelligent(
                    MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);

            prefixTextBox.Text = FileGroup.DefaultTranslatedPrefix;

            // --

            var storage =
                (MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).DynamicSettingsGlobalHierarchical;

            referenceLanguageComboBox.SelectedIndex =
                Math.Min(
                    ConvertHelper.ToInt32(
                        PersistanceHelper.RestoreValue(
                        storage,
                            @"CreateNewFileForm.referenceLanguageComboBox.SelectedIndex",
                            referenceLanguageComboBox.SelectedIndex)),
                    referenceLanguageComboBox.Properties.Items.Count - 1);

            newLanguageComboBox.SelectedIndex =
                Math.Min(
                    ConvertHelper.ToInt32(
                        PersistanceHelper.RestoreValue(
                        storage,
                            @"CreateNewFileForm.newLanguageComboBox.SelectedIndex",
                            newLanguageComboBox.SelectedIndex)),
                    newLanguageComboBox.Properties.Items.Count - 1);

            copyTextsCheckBox.Checked =
                ConvertHelper.ToBoolean(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"CreateNewFileForm.copyTextsCheckBox.Checked",
                        copyTextsCheckBox.Checked));

            automaticallyTranslateCheckBox.Checked =
                ConvertHelper.ToBoolean(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"CreateNewFileForm.automaticallyTranslateCheckBox.Checked",
                        automaticallyTranslateCheckBox.Checked));

            prefixTextBox.Text =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"CreateNewFileForm.prefixTextBox.Text",
                        prefixTextBox.Text));

            prefixCheckBox.Checked =
                ConvertHelper.ToBoolean(
                    PersistanceHelper.RestoreValue(
                        storage,
                        @"CreateNewFileForm.prefixCheckBox.Checked",
                        prefixCheckBox.Checked));

            // --
            // Select defaults.

            if (referenceLanguageComboBox.SelectedIndex < 0 &&
                 referenceLanguageComboBox.Properties.Items.Count > 0)
            {
                referenceLanguageComboBox.SelectedIndex = 0;
            }
        }

        protected override void FillControlsToItem()
        {
            base.FillControlsToItem();

            var storage =
                (MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).DynamicSettingsGlobalHierarchical;

            PersistanceHelper.SaveValue(
                storage,
                @"CreateNewFileForm.prefixTextBox.Text",
                prefixTextBox.Text);

            PersistanceHelper.SaveValue(
                storage,
                @"CreateNewFileForm.prefixCheckBox.Checked",
                prefixCheckBox.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"CreateNewFileForm.referenceLanguageComboBox.SelectedIndex",
                referenceLanguageComboBox.SelectedIndex);

            PersistanceHelper.SaveValue(
                storage,
                @"CreateNewFileForm.newLanguageComboBox.SelectedIndex",
                newLanguageComboBox.SelectedIndex);

            PersistanceHelper.SaveValue(
                storage,
                @"CreateNewFileForm.copyTextsCheckBox.Checked",
                copyTextsCheckBox.Checked);

            PersistanceHelper.SaveValue(
                storage,
                @"CreateNewFileForm.automaticallyTranslateCheckBox.Checked",
                automaticallyTranslateCheckBox.Checked);
        }

        private void CreateNewFileForm_Load(object sender, EventArgs e)
        {
            WinFormsPersistanceHelper.RestoreState(this);
            CenterToParent();

            InitiallyFillLists();
            FillItemToControls();

            UpdateUI();
        }

        private void CreateNewFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WinFormsPersistanceHelper.SaveState(this);
            FillControlsToItem();
        }

        private void referenceLanguageGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void referenceLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void newLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
            updateNewFileNameFromLanguage();
        }

        private void updateNewFileNameFromLanguage()
        {
            var culture =
                ((MyTuple<string, CultureInfo>)newLanguageComboBox.SelectedItem).Item2;

            var pattern =
                new LanguageCodeDetection(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).IsNeutralCulture(
                _fileGroup.ParentSettings,
                    culture)
                    ? (MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).NeutralLanguageFileNamePattern
                    : (MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).NonNeutralLanguageFileNamePattern;

            pattern = pattern.Replace(@"[basename]", _fileGroup.BaseName);
            pattern = pattern.Replace(@"[languagecode]", ((MyTuple<string, CultureInfo>)newLanguageComboBox.SelectedItem).Item2.Name);
            pattern = pattern.Replace(@"[extension]", _fileGroup.BaseExtension);
            // AJ CHANGE 
            pattern = pattern.Replace(@"[optionaldefaulttypes]", _fileGroup.BaseOptionalDefaultType);

            newFileNameTextBox.Text = pattern;
        }

        private void newLanguageComboBox_TextChanged(object sender, EventArgs e)
        {
            // Redirect.
            newLanguageComboBox_SelectedIndexChanged(null, null);
        }

        private void newFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            using (new WaitCursor(this, WaitCursorOption.ShortSleep))
            {
                var prefix =
                    prefixCheckBox.Checked
                        ? prefixTextBox.Text.Trim() + @" "
                        : string.Empty;

                var didCopy =
                    _fileGroup.CreateAndAddNewFile(
                        ((MyTuple<string, MyTuple<string, string>>)referenceLanguageComboBox.SelectedItem).Item2.Item2,
                        newFileNameTextBox.Text.Trim(),
                        ((MyTuple<string, MyTuple<string, string>>)referenceLanguageComboBox.SelectedItem).Item2.Item1,
                        ((MyTuple<string, CultureInfo>)newLanguageComboBox.SelectedItem).Item2.Name,
                        copyTextsCheckBox.Checked,
                        automaticallyTranslateCheckBox.Checked,
                        prefix,
                        IncludeFileInCsprojChecBox.Checked,
                        AddFileAsDependantUponCheckBox.Checked);

                if (!didCopy)
                {
                    XtraMessageBox.Show(
                        this,
                        Resources.CreateNewFileForm_buttonOK_Click_The_resource_file_for_the_language_you_selected_was_already_present_and_simply_was_added__but_not_created_,
                        @"Zeta Resource Editor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void copyTextsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void automaticallyTranslateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void prefixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void prefixTextBox_EditValueChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            prefixTextBox.Text = FileGroup.DefaultTranslatedPrefix;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            using (var form = new TranslateOptionsForm())
            {
                form.Initialize(
                    MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (form.TranslationProviderChanged)
                    {
                        using (new WaitCursor(this))
                        {
                            //InitiallyFillLists();
                            //FillItemToControls();
                            fillTranslationEngine();
                        }
                    }

                    UpdateUI();
                }
            }
        }

        private void IncludeFileInCsprojChecBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}