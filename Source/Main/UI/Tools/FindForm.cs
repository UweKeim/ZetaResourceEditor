namespace ZetaResourceEditor.UI.Tools
{
    using Helper.Base;
    using System;
    using System.Windows.Forms;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Tools.Storage;
    using Zeta.VoyagerLibrary.WinForms.Persistance;

    public partial class FindForm :
        FormBase
    {
        public FindForm()
        {
            InitializeComponent();
        }

        public string TextToFind
        {
            get => whiteSpaceAwareCheckEdit.Checked ? textToFindComboBox.Text : textToFindComboBox.Text.Trim();
            set => textToFindComboBox.Text = value;
        }

        private void textToFindComboBox_TextUpdate(object sender, EventArgs e)
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

        private void FindForm_Load(
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

            restoreComboBox();

            UpdateUI();
        }

        private void FindForm_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            WinFormsPersistanceHelper.SaveState(this);
            saveComboBox();

            PersistanceHelper.SaveValue(
                whiteSpaceAwareCheckEdit.Name + @"Checked",
                whiteSpaceAwareCheckEdit.Checked);
        }

        private void saveComboBox()
        {
            //WinFormsPersistanceHelper.SaveState(textToFindComboBox);

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

        private void restoreComboBox()
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

        private void buttonOK_Click(
            object sender,
            EventArgs e)
        {
            var has = false;
            foreach (string text in textToFindComboBox.Properties.Items)
            {
                if (whiteSpaceAwareCheckEdit.Checked)
                {
                    if (string.Compare(text, textToFindComboBox.Text, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        has = true;
                        break;
                    }
                }
                else
                {
                    if (string.Compare(text, textToFindComboBox.Text.Trim(), StringComparison.OrdinalIgnoreCase) == 0)
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
    }
}