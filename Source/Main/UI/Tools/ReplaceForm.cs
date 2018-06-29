namespace ZetaResourceEditor.UI.Tools
{
    using Helper.Base;
    using System;
    using System.Windows.Forms;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Tools.Storage;
    using Zeta.VoyagerLibrary.WinForms.Persistance;

    public partial class ReplaceForm :
        FormBase
    {
        public ReplaceForm()
        {
            InitializeComponent();
        }

        public string TextToFind
        {
            get => whiteSpaceAwareCheckEdit.Checked ? textToFindComboBox.Text : textToFindComboBox.Text.Trim();
            private set => textToFindComboBox.Text = value;
        }

        public string TextToReplaceWith
        {
            get => whiteSpaceAwareCheckEdit.Checked ? textToReplaceComboBox.Text : textToReplaceComboBox.Text.Trim();
            private set => textToReplaceComboBox.Text = value;
        }

        private void textToFindComboBox_TextUpdate(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void textToReplaceComboBox_TextUpdate(object sender, EventArgs e)
        {
            UpdateUI();
        }

        public override void UpdateUI()
        {
            base.UpdateUI();

            simpleButton1.Enabled =
                whiteSpaceAwareCheckEdit.Checked
                    ? textToFindComboBox.Text.Length > 0
                    : textToFindComboBox.Text.Trim().Length > 0;
        }

        private void ReplaceForm_Load(
            object sender,
            EventArgs e)
        {
            WinFormsPersistanceHelper.RestoreState(this);
            CenterToParent();

            // Restore before the combo box.
            whiteSpaceAwareCheckEdit.Checked =
                ConvertHelper.ToBoolean(
                    PersistanceHelper.RestoreValue(
                        whiteSpaceAwareCheckEdit.Name + @"Checked",
                        whiteSpaceAwareCheckEdit.Checked));

            restoreFindComboBox();
            restoreReplaceComboBox();

            UpdateUI();
        }

        private void ReplaceForm_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            WinFormsPersistanceHelper.SaveState(this);
            saveFindComboBox();
            saveReplaceComboBox();

            PersistanceHelper.SaveValue(
                whiteSpaceAwareCheckEdit.Name + @"Checked",
                whiteSpaceAwareCheckEdit.Checked);
        }

        private void saveFindComboBox()
        {
            WinFormsPersistanceHelper.SaveState(textToFindComboBox);

            PersistanceHelper.SaveValue(
                textToFindComboBox.Name + @".Text",
                whiteSpaceAwareCheckEdit.Checked
                    ? textToFindComboBox.Text
                    : textToFindComboBox.Text.Trim());

            PersistanceHelper.SaveValue(
                textToFindComboBox.Name + @".Count",
                textToFindComboBox.Properties.Items.Count);

            var index = 0;
            foreach (string item in textToFindComboBox.Properties.Items)
            {
                PersistanceHelper.SaveValue(
                    textToFindComboBox.Name + @".Item." + index,
                    item);

                index++;
            }
        }

        private void saveReplaceComboBox()
        {
            //WinFormsPersistanceHelper.SaveState(textToReplaceComboBox);

            PersistanceHelper.SaveValue(
                textToReplaceComboBox.Name + @".Text",
                whiteSpaceAwareCheckEdit.Checked
                    ? textToReplaceComboBox.Text
                    : textToReplaceComboBox.Text.Trim());

            PersistanceHelper.SaveValue(
                textToReplaceComboBox.Name + @".Count",
                textToReplaceComboBox.Properties.Items.Count);

            var index = 0;
            foreach (string item in textToReplaceComboBox.Properties.Items)
            {
                PersistanceHelper.SaveValue(
                    textToReplaceComboBox.Name + @".Item." + index,
                    item);

                index++;
            }
        }

        private void restoreFindComboBox()
        {
            var temp = TextToFind;
            //WinFormsPersistanceHelper.RestoreState(textToFindComboBox);

            var count =
                ConvertHelper.ToInt32(
                    PersistanceHelper.RestoreValue(
                        textToFindComboBox.Name + @".Count"));

            for (var index = 0; index < count; ++index)
            {
                var s =
                    ConvertHelper.ToString(
                        PersistanceHelper.RestoreValue(
                            textToFindComboBox.Name + @".Item." + index));

                if (!string.IsNullOrEmpty(s))
                {
                    textToFindComboBox.Properties.Items.Add(s);
                }
            }

            textToFindComboBox.Text =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        textToFindComboBox.Name + @".Text",
                        textToFindComboBox.Text));

            TextToFind = temp;
        }

        private void restoreReplaceComboBox()
        {
            var temp = TextToReplaceWith;
            //WinFormsPersistanceHelper.RestoreState(textToReplaceComboBox);

            var count =
                ConvertHelper.ToInt32(
                    PersistanceHelper.RestoreValue(
                        textToReplaceComboBox.Name + @".Count"));

            for (var index = 0; index < count; ++index)
            {
                var s =
                    ConvertHelper.ToString(
                        PersistanceHelper.RestoreValue(
                            textToReplaceComboBox.Name + @".Item." + index));

                if (!string.IsNullOrEmpty(s))
                {
                    textToReplaceComboBox.Properties.Items.Add(s);
                }
            }

            textToReplaceComboBox.Text =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(
                        textToReplaceComboBox.Name + @".Text",
                        textToReplaceComboBox.Text));

            TextToReplaceWith = temp;
        }

        private void buttonOK_Click(
            object sender,
            EventArgs e)
        {
            storeFindComboValue();
            storeReplaceComboValue();
        }

        private void storeFindComboValue()
        {
            var has = false;
            foreach (string text in textToFindComboBox.Properties.Items)
            {
                if (whiteSpaceAwareCheckEdit.Checked)
                {
                    if (string.Compare(text,
                            textToFindComboBox.Text, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        has = true;
                        break;
                    }
                }
                else
                {
                    if (string.Compare(text,
                            textToFindComboBox.Text.Trim(), StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        has = true;
                        break;
                    }
                }
            }

            if (!has)
            {
                textToFindComboBox.Properties.Items.Insert(
                    0,
                    whiteSpaceAwareCheckEdit.Checked
                        ? textToFindComboBox.Text
                        : textToFindComboBox.Text.Trim());
            }
        }

        private void storeReplaceComboValue()
        {
            var has = false;
            foreach (string text in textToReplaceComboBox.Properties.Items)
            {
                if (whiteSpaceAwareCheckEdit.Checked)
                {
                    if (string.Compare(text,
                            textToReplaceComboBox.Text, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        has = true;
                        break;
                    }
                }
                else
                {
                    if (string.Compare(text,
                            textToReplaceComboBox.Text.Trim(), StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        has = true;
                        break;
                    }
                }
            }

            if (!has)
            {
                textToReplaceComboBox.Properties.Items.Insert(
                    0,
                    whiteSpaceAwareCheckEdit.Checked
                        ? textToReplaceComboBox.Text
                        : textToReplaceComboBox.Text.Trim());
            }
        }
    }
}