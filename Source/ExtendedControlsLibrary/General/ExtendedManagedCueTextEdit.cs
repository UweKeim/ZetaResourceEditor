namespace ZetaResourceEditor.ExtendedControlsLibrary.General;

using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using Skinning;

public class ExtendedManagedCueTextEdit :
    TextEdit
{
    private MyTransparentLabelControlSpecialized _cueLabel;
    private string _cueText;

    public ExtendedManagedCueTextEdit()
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
        get => _cueText;
        set
        {
            _cueText = value;
            changeLabelText();
        }
    }

    public override string? Text
    {
        get => base.Text;
        set
        {
            base.Text = value;
            showHideLabel();
        }
    }

    public override Color BackColor
    {
        get => base.BackColor;
        set
        {
            base.BackColor = value;
            changeLabelColor();
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
            _cueLabel = new();
            _cueLabel.Init(this);
            Parent?.Controls.Add(_cueLabel);

            changeLabelColor();
            changeLabelText();
            repositionLabel();

            _cueLabel.BringToFront();
        }

        showHideLabel();
    }

    private void repositionLabel()
    {
        if (_cueLabel != null && Controls.Cast<Control>().Any())
        {
            using (new FocusPreserver(this))
            {
                var dx = Math.Max(3, Controls[0].Top);
                var dy = Math.Max(3, Controls[0].Left) * 2;

                _cueLabel.Top = Top + dx;
                _cueLabel.Left = Left + dy;

                _cueLabel.Width = Width - 4 * dx;
                _cueLabel.Height = Height - 2 * dy;
            }
        }
    }

    private void showHideLabel()
    {
        if (_cueLabel != null)
        {
            using (new FocusPreserver(this))
            {
                _cueLabel.Visible = Visible && string.IsNullOrEmpty(Text);
            }
        }
    }

    private void changeLabelColor()
    {
        if (_cueLabel != null)
        {
            using (new FocusPreserver(this))
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
            using (new FocusPreserver(this))
            {
                _cueLabel.Text = CueText == null ? string.Empty : CueText.Trim();
            }
        }
    }

    internal class FocusPreserver :
        IDisposable
    {
        private readonly Control _c;
        private readonly bool _focused;
        private readonly Form _form;
        private Control _prevActive;

        public FocusPreserver(Control c)
        {
            return;
            //_c = c;
            //_form = c == null ? null : c.FindForm();
            //_focused = c != null && c.Focused;

            //preserve();
        }

        void IDisposable.Dispose()
        {
            return;
            //restore();
        }

        //private void preserve()
        //{
        //    if (_form != null)
        //    {
        //        _prevActive = _form.ActiveControl;
        //    }
        //}

        //private void restore()
        //{
        //    if (_form != null)
        //    {
        //        _form.ActiveControl = _prevActive;
        //    }

        //    if (_focused)
        //    {
        //        _c.Select();
        //        _c.Focus();
        //    }
        //}
    }

    internal class MyTransparentLabelControlSpecialized :
        LabelControl
    {
        protected override void WndProc(ref Message m)
        {
            // Do not allow this window to become active - it should be "transparent" to mouse clicks
            //  i.e. Mouse clicks pass through this window
            if (m.Msg == Win32Constants.WM_NCHITTEST)
            {
                m.Result = new(Win32Constants.HTTRANSPARENT);
                return;
            }

            base.WndProc(ref m);
        }

        public void Init(Control owner)
        {
            Font = owner.Font;
            TabStop = false;
            TabIndex = owner.TabIndex;
            Cursor = owner.Cursor;

            AutoEllipsis = true;
            AutoSizeMode = owner is MemoEdit ? LabelAutoSizeMode.None : LabelAutoSizeMode.Vertical;

            Appearance.TextOptions.WordWrap = owner is MemoEdit ? WordWrap.Wrap : WordWrap.NoWrap;
            Appearance.TextOptions.Trimming = Trimming.EllipsisCharacter;
            Appearance.TextOptions.VAlignment = VertAlignment.Top;
            Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            Appearance.Options.UseTextOptions = true;
        }
    }

    internal class Win32Constants
    {
        public const int WM_NCHITTEST = 0x84;
        public const int HTTRANSPARENT = -1;
    }
}