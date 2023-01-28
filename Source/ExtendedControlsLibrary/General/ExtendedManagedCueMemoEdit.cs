namespace ZetaResourceEditor.ExtendedControlsLibrary.General;

using System.ComponentModel;
using DevExpress.XtraEditors;
using Skinning;

public class ExtendedManagedCueMemoEdit :
    MemoEdit
{
    private ExtendedManagedCueTextEdit.MyTransparentLabelControlSpecialized _cueLabel;
    private string _cueText;

    public ExtendedManagedCueMemoEdit()
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

    public override string Text
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
            using (new ExtendedManagedCueTextEdit.FocusPreserver(this))
            {
                var dx = Controls[0].Top + 3;
                var dy = (Controls[0].Left + 4) * 2;

                _cueLabel.Top = Top + dx;
                _cueLabel.Left = Left + dy;

                _cueLabel.Width = Width - 5 * dx - scrollHelper.VScroll.GetWidth();
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