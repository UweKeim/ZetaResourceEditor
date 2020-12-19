namespace ZetaResourceEditor.UI.Main.RightContent
{
    using DevExpress.XtraEditors.Controls;
    using Helper.Base;
    using RuntimeBusinessLogic.Language;
    using RuntimeBusinessLogic.Projects;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using Zeta.VoyagerLibrary.Common.Collections;
    using Zeta.VoyagerLibrary.WinForms.Persistance;

    public partial class ConfigureLanguageColumnsForm :
        FormBase
    {
        private Project _project;

        public ConfigureLanguageColumnsForm()
        {
            InitializeComponent();
        }

        public void Initialize(Project project)
        {
            _project = project;
        }

        private IEnumerable<string> languageCodes
        {
            get
            {
                var codes =
                    new HashSet<string>
                        {
                            _project.NeutralLanguageCode
                        };

                foreach (var group in _project.FileGroups)
                {
                    foreach (var lc in group.GetLanguageCodes(_project))
                    {
                        if (!string.IsNullOrEmpty(lc))
                        {
                            codes.Add(lc);
                        }
                    }
                }

                var l = codes.ToList();
                l.Sort();

                return l.ToArray();
            }
        }

        protected override void InitiallyFillLists()
        {
            base.InitiallyFillLists();

            refillLanguagesToTranslate();
        }

        protected override void FillItemToControls()
        {
            base.FillItemToControls();

            var ls = _project.LanguagesToDisplay;
            if (ls.Length <= 0)
            {
                displayAllLanguagesCheckEdit.Checked = true;
            }
            else
            {
                displayCertainLanguagesCheckEdit.Checked = true;

                foreach (var l in ls)
                {
                    checkCulture(l);
                }
            }
        }

        private void checkCulture(CultureInfo cultureInfo)
        {
            foreach (CheckedListBoxItem item in languagesToDisplayCheckListBox.Items)
            {
                var p = (MyTuple<string, string>)item.Value;

                if (string.Compare(p.Item2, cultureInfo.Name, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    item.CheckState = CheckState.Checked;
                    break;
                }
            }
        }

        protected override void FillControlsToItem()
        {
            base.FillControlsToItem();

            if (displayAllLanguagesCheckEdit.Checked)
            {
                _project.LanguagesToDisplay = null;
            }
            else
            {
                var cs = new List<CultureInfo>();

                foreach (CheckedListBoxItem item in languagesToDisplayCheckListBox.CheckedItems)
                {
                    var p = (MyTuple<string, string>)item.Value;

                    cs.Add(CultureHelper.CreateCultureErrorTolerant(p.Item2));
                }

                _project.LanguagesToDisplay = cs.ToArray();
            }
        }

        public override void UpdateUI()
        {
            base.UpdateUI();

            languagesToDisplayCheckListBox.Enabled =
                selectAllLanguagesToExportButton.Enabled =
                selectNoLanguagesToExportButton.Enabled =
                invertLanguagesToExportButton.Enabled =
                displayCertainLanguagesCheckEdit.Checked;

            buttonOK.Enabled =
                displayAllLanguagesCheckEdit.Checked ||
                displayCertainLanguagesCheckEdit.Checked &&
                languagesToDisplayCheckListBox.CheckedIndices.Count > 0;
        }

        private void refillLanguagesToTranslate()
        {
            languagesToDisplayCheckListBox.Items.Clear();

            var pairs = new List<MyTuple<string, string>>();

            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (var languageCode in languageCodes)
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                if (!string.IsNullOrEmpty(languageCode))
                {
                    pairs.Add(
                        new MyTuple<string, string>(
                            $@"{LanguageCodeDetection.MakeValidCulture(languageCode).DisplayName} ({languageCode})",
                            languageCode));
                }
            }

            pairs.Sort((x, y) => string.Compare(x.Item1, y.Item1, StringComparison.Ordinal));

            foreach (var pair in pairs)
            {
                var index = languagesToDisplayCheckListBox.Items.Add(pair);

                languagesToDisplayCheckListBox.SetItemChecked(index, false);
            }
        }

        private void configureLanguageColumnsForm_Load(object sender, EventArgs e)
        {
            WinFormsPersistanceHelper.RestoreState(this);
            CenterToParent();

            InitiallyFillLists();
            FillItemToControls();

            UpdateUI();
        }

        private void configureLanguageColumnsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WinFormsPersistanceHelper.SaveState(this);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FillControlsToItem();
        }

        private void displayAllLanguagesCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void displayCertainLanguagesCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void selectAllLanguagesToExportButton_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < languagesToDisplayCheckListBox.Items.Count; ++index)
            {
                languagesToDisplayCheckListBox.SetItemChecked(index, true);
            }

            UpdateUI();
        }

        private void selectNoLanguagesToExportButton_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < languagesToDisplayCheckListBox.Items.Count; ++index)
            {
                languagesToDisplayCheckListBox.SetItemChecked(index, false);
            }

            UpdateUI();
        }

        private void invertLanguagesToExportButton_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < languagesToDisplayCheckListBox.Items.Count; ++index)
            {
                languagesToDisplayCheckListBox.SetItemChecked(
                    index,
                    !languagesToDisplayCheckListBox.GetItemChecked(index));
            }

            UpdateUI();
        }

        private void languagesToDisplayCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void languagesToDisplayCheckListBox_ItemCheck(
            object sender,
            DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            UpdateUI();
        }
    }
}