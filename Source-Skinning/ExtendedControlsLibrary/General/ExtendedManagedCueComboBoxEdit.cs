namespace ExtendedControlsLibrary.General
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using Skinning;

    public class ExtendedManagedCueComboBoxEdit :
        ComboBoxEdit
    {
        private ExtendedManagedCueTextEdit.MyTransparentLabelControlSpecialized _cueLabel;
        private string _cueText;

        public ExtendedManagedCueComboBoxEdit()
        {
            Properties.Appearance.Changed +=
                delegate
                {
                    showHideLabel();
                    changeLabelColor();
                };
        }

        [DefaultValue(@"")]
        [Localizable(true)]
        public string CueText
        {
            get { return _cueText; }
            set
            {
                _cueText = value;
                changeLabelText();
            }
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                showHideLabel();
            }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                changeLabelColor();
            }
        }

        protected int buttonsWidths
        {
            get
            {
                var w = 0;

                foreach (EditorButton button in Properties.Buttons)
                {
                    if (button.Visible)
                    {
                        if (button.Width > 0)
                        {
                            w += button.Width;
                        }
                        else
                        {
                            w += SystemInformation.VerticalScrollBarWidth;
                        }
                    }
                }

                return w;
            }
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            changeLabelColor();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            changeLabelColor();
        }

        protected override void OnEditValueChanged()
        {
            base.OnEditValueChanged();

            showHideLabel();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            showHideLabel();
        }

        protected override void OnProperties_PropertiesChanged(object sender, EventArgs e)
        {
            base.OnProperties_PropertiesChanged(sender, e);

            changeLabelColor();
            showHideLabel();
        }

        protected override void OnPropertiesChanged()
        {
            base.OnPropertiesChanged();

            changeLabelColor();
            showHideLabel();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            repositionLabel();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            showHideLabel();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);

            repositionLabel();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Put from standard into my own.
            if (!string.IsNullOrEmpty(Properties.NullValuePrompt) && string.IsNullOrEmpty(CueText))
            {
                CueText = Properties.NullValuePrompt;
            }
            Properties.NullValuePrompt = null;
            Properties.NullValuePromptShowForEmptyValue = false;

            createLabel();
        }

        private void createLabel()
        {
            if (_cueLabel == null)
            {
                _cueLabel = new ExtendedManagedCueTextEdit.MyTransparentLabelControlSpecialized();
                _cueLabel.Init(this);
                Parent.Controls.Add(_cueLabel);

                changeLabelColor();
                changeLabelText();
                repositionLabel();

                _cueLabel.BringToFront();
            }

            showHideLabel();
        }

        private void repositionLabel()
        {
            if (_cueLabel != null)
            {
                using (new ExtendedManagedCueTextEdit.FocusPreserver(this))
                {
                    var dx = Math.Max(3, Controls[0].Top);
                    var dy = Math.Max(3, Controls[0].Left) * 2;

                    _cueLabel.Top = Top + dx;
                    _cueLabel.Left = Left + dy;

                    _cueLabel.Width = Width - 4 * dx - buttonsWidths;
                    _cueLabel.Height = Height - 2 * dy;
                }
            }
        }

        private void showHideLabel()
        {
            if (_cueLabel != null)
            {
                using (new ExtendedManagedCueTextEdit.FocusPreserver(this))
                {
                    _cueLabel.Visible = Visible && string.IsNullOrEmpty(Text);
                }
            }
        }

        private void changeLabelColor()
        {
            if (_cueLabel != null)
            {
                using (new ExtendedManagedCueTextEdit.FocusPreserver(this))
                {
                    _cueLabel.Appearance.ForeColor = SkinHelper.CueTextColor;
                    _cueLabel.Appearance.BackColor = BackColor;
                    _cueLabel.Appearance.Options.UseForeColor = true;
                    _cueLabel.Appearance.Options.UseBackColor = true;
                }
            }
        }

        private void changeLabelText()
        {
            if (_cueLabel != null)
            {
                using (new ExtendedManagedCueTextEdit.FocusPreserver(this))
                {
                    _cueLabel.Text = CueText == null ? string.Empty : CueText.Trim();
                }
            }
        }
    }
}