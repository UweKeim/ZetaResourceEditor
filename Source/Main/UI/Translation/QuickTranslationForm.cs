namespace ZetaResourceEditor.UI.Translation
{
    using Code;
    using Helper.Base;
    using Main;
    using RuntimeBusinessLogic.Projects;
    using RuntimeBusinessLogic.Translation;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Tools.Storage;
    using Zeta.VoyagerLibrary.WinForms.Common;
    using Zeta.VoyagerLibrary.WinForms.Persistance;

    public partial class QuickTranslationForm : FormBase
    {
        private bool _isException;

        public static void CheckRestoreShowForm()
        {
            if (closedByFormOwner)
            {
                ShowTheForm();
            }
        }

        public static void ShowTheForm()
        {
            doShowTheForm(null, false);
        }

        private static void doShowTheForm(
            string textToTranslate,
            bool applyTextToTranslate)
        {
            var isOpen = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is QuickTranslationForm cf)
                {
                    isOpen = true;

                    form.BringToFront();
                    form.Select();

                    if (applyTextToTranslate)
                    {
                        cf.sourceTextTextBox.Text = textToTranslate;
                    }

                    break;
                }
            }

            if (!isOpen)
            {
                var form = new QuickTranslationForm();
                form.Show(MainForm.Current);
            }
        }

        public override void UpdateUI()
        {
            base.UpdateUI();

            buttonTranslate.Enabled =
                sourceLanguageComboBox.SelectedIndex >= 0 &&
                destinationLanguageComboBox.SelectedIndex >= 0 &&
                !string.IsNullOrEmpty(sourceTextTextBox.Text.Trim());
            buttonCopyToClipboard.Enabled =
                !string.IsNullOrEmpty(destinationTextTextBox.Text.Trim());
        }

        protected override void InitiallyFillLists()
        {
            base.InitiallyFillLists();

            var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;
            var engine = TranslationHelper.GetTranslationEngine(project);


            TranslationHelper.GetTranslationAppID(
                project ?? Project.Empty,
                out var appID);

            var sls =
                engine.AreAppIDsSyntacticallyValid(appID)
                    ? new List<TranslationLanguageInfo>(engine.GetSourceLanguages(appID))
                    : new List<TranslationLanguageInfo>();
            var dls =
                engine.AreAppIDsSyntacticallyValid(appID)
                    ? new List<TranslationLanguageInfo>(engine.GetDestinationLanguages(appID))
                    : new List<TranslationLanguageInfo>();

            sls.Sort((x, y) => string.CompareOrdinal(x.UserReadableName, y.UserReadableName));
            dls.Sort((x, y) => string.CompareOrdinal(x.UserReadableName, y.UserReadableName));

            sourceLanguageComboBox.Properties.Items.Clear();
            destinationLanguageComboBox.Properties.Items.Clear();

            foreach (var sourceLanguage in sls)
            {
                sourceLanguageComboBox.Properties.Items.Add(sourceLanguage);
            }

            foreach (var destinationLanguage in dls)
            {
                destinationLanguageComboBox.Properties.Items.Add(destinationLanguage);
            }
        }

        public QuickTranslationForm()
        {
            InitializeComponent();
        }

        protected override void FillItemToControls()
        {
            base.FillItemToControls();

            sourceLanguageComboBox.SelectedIndex =
                Math.Min(
                    ConvertHelper.ToInt32(
                        PersistanceHelper.RestoreValue(
                            @"QuickTranslationForm.sourceLanguageComboBox.SelectedIndex",
                            sourceLanguageComboBox.SelectedIndex)),
                    sourceLanguageComboBox.Properties.Items.Count - 1);
            destinationLanguageComboBox.SelectedIndex =
                Math.Min(
                    ConvertHelper.ToInt32(
                        PersistanceHelper.RestoreValue(
                            @"QuickTranslationForm.destinationLanguageComboBox.SelectedIndex",
                            destinationLanguageComboBox.SelectedIndex)),
                    destinationLanguageComboBox.Properties.Items.Count - 1);

            sourceTextTextBox.Text =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        @"QuickTranslationForm.sourceTextTextBox.Text",
                        sourceTextTextBox.Text));

            copyDestinationTextToClipboardCheckBox.Checked =
                ConvertHelper.ToBoolean(
                    PersistanceHelper.RestoreValue(
                        @"QuickTranslationForm.copyDestinationTextToClipboardCheckBox.Checked",
                        copyDestinationTextToClipboardCheckBox.Checked));

            // --
            // Select defaults.

            if (sourceLanguageComboBox.SelectedIndex < 0 &&
                 sourceLanguageComboBox.Properties.Items.Count > 0)
            {
                sourceLanguageComboBox.SelectedIndex = 0;
            }

            if (destinationLanguageComboBox.SelectedIndex < 0 &&
                 destinationLanguageComboBox.Properties.Items.Count > 0)
            {
                foreach (TranslationLanguageInfo pair in destinationLanguageComboBox.Properties.Items)
                {
                    if (pair.LanguageCode.ToLowerInvariant() == @"en")
                    {
                        destinationLanguageComboBox.SelectedItem = pair;
                        break;
                    }
                }

                if (destinationLanguageComboBox.SelectedIndex < 0)
                {
                    destinationLanguageComboBox.SelectedIndex = 0;
                }
            }

            var ti = TranslationHelper.GetTranslationEngine(
                MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);
            labelControl4.Text = ti.UserReadableName;
        }

        protected override void FillControlsToItem()
        {
            base.FillControlsToItem();

            PersistanceHelper.SaveValue(
                @"QuickTranslationForm.sourceLanguageComboBox.SelectedIndex",
                sourceLanguageComboBox.SelectedIndex);
            PersistanceHelper.SaveValue(
                @"QuickTranslationForm.destinationLanguageComboBox.SelectedIndex",
                destinationLanguageComboBox.SelectedIndex);

            PersistanceHelper.SaveValue(
                @"QuickTranslationForm.sourceTextTextBox.Text",
                sourceTextTextBox.Text);

            PersistanceHelper.SaveValue(
                @"QuickTranslationForm.copyDestinationTextToClipboardCheckBox.Checked",
                copyDestinationTextToClipboardCheckBox.Checked);
        }

        private void QuickTranslationForm_Load(object sender, EventArgs e)
        {
            try
            {
                WinFormsPersistanceHelper.RestoreState(this);

                DoInitiallyFillListsAndFillItemToControls();

                UpdateUI();
            }
            catch (Exception)
            {
                _isException = true;
                Close();
                throw;
            }
        }

        private void DoInitiallyFillListsAndFillItemToControls()
        {
            try
            {
                InitiallyFillLists();
                FillItemToControls();
            }
            catch (Exception x)
            {
                Host.NotifyAboutException(x);
            }
        }

        private void QuickTranslationForm_Shown(object sender, EventArgs e)
        {
            try
            {
                sourceTextTextBox.Focus();
                AutoTranslateForm.CheckShowNewTranslationInfos();

                if (AutoTranslateForm.CheckShowAppIDsMissing())
                {
                    DoInitiallyFillListsAndFillItemToControls();
                }
            }
            catch (Exception)
            {
                _isException = true;
                Close();
                throw;
            }
        }

        private void QuickTranslationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closedByFormOwner = e.CloseReason == CloseReason.FormOwnerClosing;

            if (!_isException)
            {
                WinFormsPersistanceHelper.SaveState(this);
                FillControlsToItem();
            }
        }

        private static bool closedByFormOwner
        {
            get => ConvertHelper.ToBoolean(
                PersistanceHelper.RestoreValue(
                    @"QuickTranslationForm.closedByFormOwner"));
            set => PersistanceHelper.SaveValue(
                @"QuickTranslationForm.closedByFormOwner",
                value);
        }

        private void sourceLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void destinationLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void sourceTextTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void copyDestinationTextToClipboardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(destinationTextTextBox.Text.Trim());
        }

        private void destinationTextTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                using (new WaitCursor(this, WaitCursorOption.ShortSleep))
                {
                    var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

                    TranslationHelper.GetTranslationAppID(
                        project,
                        out var appID);

                    destinationTextTextBox.Text =
                        TranslationHelper.GetTranslationEngine(project).Translate(
                            appID,
                            sourceTextTextBox.Text.Trim(),
                            ((TranslationLanguageInfo)sourceLanguageComboBox.SelectedItem).LanguageCode,
                            ((TranslationLanguageInfo)destinationLanguageComboBox.SelectedItem).LanguageCode,
                            project == null ? new string[] { } : project.TranslationWordsToProtect,
                            project == null ? new string[] { } : project.TranslationWordsToRemove);

                    if (copyDestinationTextToClipboardCheckBox.Checked)
                    {
                        Clipboard.SetText(destinationTextTextBox.Text.Trim());
                    }
                }
            }
            catch (Exception x)
            {
                Host.NotifyAboutException(x);
            }
        }

        private void sourceTextTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                sourceTextTextBox.SelectAll();
            }
        }

        private void destinationTextTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                destinationTextTextBox.SelectAll();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            using (var form = new TranslateOptionsForm())
            {
                form.Initialize(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (form.TranslationProviderChanged)
                    {
                        using (new WaitCursor(this))
                        {
                            DoInitiallyFillListsAndFillItemToControls();
                        }
                    }

                    UpdateUI();
                }
            }
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            var i1 = sourceLanguageComboBox.SelectedIndex;
            var i2 = destinationLanguageComboBox.SelectedIndex;

            sourceLanguageComboBox.SelectedIndex = i2;
            destinationLanguageComboBox.SelectedIndex = i1;
        }
    }
}