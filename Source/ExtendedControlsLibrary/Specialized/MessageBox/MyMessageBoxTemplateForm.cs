namespace ZetaResourceEditor.ExtendedControlsLibrary.Specialized.MessageBox;

using System.Globalization;
using System.Text;
using DevExpress.XtraEditors;
using General.Base;
using global::ExtendedControlsLibrary.Skinning;
using Skinning;
using Zeta.VoyagerLibrary.Core.WinForms.Common;

public partial class MyMessageBoxTemplateForm :
    DevExpressXtraFormBase
{
    //private readonly int _minButtonWidth;
    private readonly int _buttonBorderDistance;
    private readonly int _buttonSpacing;
    private readonly int _initialHeight;
    private readonly Dictionary<Keys, DialogResult> _keyMap = new();
    private MyMessageBoxInformation? _info;
    private string? _acceptButtonDefaultText;
    private DateTime _countdownStartedAt;

    public MyMessageBoxTemplateForm()
    {
        InitializeComponent();

        if (!DesignMode)
        {
            _initialHeight = Height;
            //_minButtonWidth = button1.Width;
            _buttonSpacing = button2.Left - (button1.Left + button1.Width);
            _buttonBorderDistance = ClientRectangle.Width - button3.Right;
        }
    }

    protected override bool UseSharedIcon => false;

    public static int MaximumFormWidth => (int)Math.Min(SystemInformation.WorkingArea.Width * 0.75f, 600);

    public static int MaximumFormHeight => (int)(SystemInformation.WorkingArea.Height * 0.85f);

    internal void Initialize(
        MyMessageBoxInformation info)
    {
        _info = info;
    }

    protected override bool ProcessDialogKey(Keys keyData)
    {
        // http://stackoverflow.com/questions/3300977/arrow-key-events-not-arriving

        if (_keyMap.TryGetValue(keyData, out var dr))
        {
            DialogResult = dr;
            Close();

            return true;
        }

        if (keyData == (Keys.Control | Keys.C))
        {
            copyToClipboard();
            return true;
        }

        return base.ProcessDialogKey(keyData);
    }

    private void copyToClipboard()
    {
        var sb = new StringBuilder();

        sb.AppendLine(@"[Window Title]");
        sb.AppendLine(Text);
        sb.AppendLine();

        sb.AppendLine(@"[Content]");
        sb.AppendLine(textControl.Text?.Trim());
        sb.AppendLine();

        if (button1.Visible) sb.AppendFormat(@"[{0}] ", button1.Text);
        if (button2.Visible) sb.AppendFormat(@"[{0}] ", button2.Text);
        if (button3.Visible) sb.AppendFormat(@"[{0}] ", button3.Text);

        using (new WaitCursor(this, WaitCursorOption.ShortSleep))
        {
            Clipboard.SetText(sb.ToString().Trim());
        }
    }

    private void MyMessageBoxTemplateForm_Load(object sender, EventArgs e)
    {
        buildContent();

        if (_info?.EffectiveOwner == null)
        {
            CenterToScreen();
        }
        else
        {
            CenterToParent();
        }

        if (_info.CloseCountDown > TimeSpan.Zero && AcceptButton != null)
        {
            // 1 Sekunde weniger, damit "0" nicht mehr angezeigt wird.
            const int subs = 1000;

            closeCountDownTimer.Interval = (int)_info.CloseCountDown.TotalMilliseconds - subs;

            _countdownStartedAt = DateTime.Now;

            closeCountDownTimer.Start();

            if (_info.VisualCloseCountDown)
            {
                updateVisualCountDownTimer.Start();
            }
        }
    }

    private void buildContent()
    {
        //_minWidth = Width;
        //_minHeight = Height;

        buildCaption();
        buildIcon();
        buildButtons();
        buildText();

        adjustSize();
    }

    private void buildCaption()
    {
        Text = _info.Caption;
    }

    private void buildIcon()
    {
        switch (_info.Icon)
        {
            case MessageBoxIcon.None:
                var delta = textControl.Left - iconPictureBox.Left;
                iconPictureBox.Visible = false;
                textControl.Left = iconPictureBox.Left;
                textControl.Width += delta;
                break;

            case MessageBoxIcon.Hand:
                iconPictureBox.Image = SkinningResources.cross_circle;
                break;
            case MessageBoxIcon.Question:
                iconPictureBox.Image = SkinningResources.question;
                break;
            case MessageBoxIcon.Exclamation:
                iconPictureBox.Image = SkinningResources.exclamation;
                break;
            case MessageBoxIcon.Asterisk:
                iconPictureBox.Image = SkinningResources.information;
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void buildButtons()
    {
        var buttonDelta = button2.Left - button1.Left;
        int buttonCount;

        switch (_info.Buttons)
        {
            case MessageBoxButtons.OK:
                {
                    button1.Visible = false;
                    button2.Visible = false;

                    button3.Text = _info.ButtonTexts[DialogResult.OK];
                    button3.DialogResult = DialogResult.OK;
                    addKeyMap(findButtonKey(DialogResult.OK, DialogResult.OK), DialogResult.OK);
                    AcceptButton = button3;
                    CancelButton = button3;

                    buttonCount = 1;
                }
                break;
            case MessageBoxButtons.OKCancel:
                {
                    button1.Visible = false;

                    button2.Text = _info.ButtonTexts[DialogResult.OK];
                    button2.DialogResult = DialogResult.OK;
                    addKeyMap(findButtonKey(DialogResult.OK, DialogResult.OK, DialogResult.Cancel), DialogResult.OK);
                    AcceptButton = button2;

                    button3.Text = _info.ButtonTexts[DialogResult.Cancel];
                    button3.DialogResult = DialogResult.Cancel;
                    addKeyMap(findButtonKey(DialogResult.Cancel, DialogResult.OK, DialogResult.Cancel), DialogResult.Cancel);
                    CancelButton = button3;

                    switch (_info.DefaultButton)
                    {
                        case MessageBoxDefaultButton.Button1:
                            AcceptButton = button2;
                            break;
                        case MessageBoxDefaultButton.Button2:
                        case MessageBoxDefaultButton.Button3:
                            AcceptButton = button3;
                            button2.TabIndex = 1;
                            button3.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button4:
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    buttonCount = 2;
                }
                break;
            case MessageBoxButtons.AbortRetryIgnore:
                {
                    button1.Text = _info.ButtonTexts[DialogResult.Abort];
                    button1.DialogResult = DialogResult.Abort;
                    addKeyMap(findButtonKey(DialogResult.Abort, DialogResult.Abort, DialogResult.Retry, DialogResult.Ignore), DialogResult.Abort);
                    CancelButton = button1;

                    button2.Text = _info.ButtonTexts[DialogResult.Retry];
                    button2.DialogResult = DialogResult.Retry;
                    addKeyMap(findButtonKey(DialogResult.Retry, DialogResult.Abort, DialogResult.Retry, DialogResult.Ignore), DialogResult.Retry);
                    AcceptButton = button2;

                    button3.Text = _info.ButtonTexts[DialogResult.Ignore];
                    button3.DialogResult = DialogResult.Ignore;
                    addKeyMap(findButtonKey(DialogResult.Ignore, DialogResult.Abort, DialogResult.Retry, DialogResult.Ignore),
                        DialogResult.Ignore);
                    CancelButton = button3;

                    switch (_info.DefaultButton)
                    {
                        case MessageBoxDefaultButton.Button1:
                            AcceptButton = button1;
                            break;
                        case MessageBoxDefaultButton.Button2:
                            AcceptButton = button2;
                            button1.TabIndex = 2;
                            button2.TabIndex = 0;
                            button3.TabIndex = 1;
                            break;
                        case MessageBoxDefaultButton.Button3:
                            AcceptButton = button3;
                            button1.TabIndex = 1;
                            button2.TabIndex = 2;
                            button3.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button4:
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    buttonCount = 3;
                }
                break;
            case MessageBoxButtons.YesNoCancel:
                {
                    button1.Text = _info.ButtonTexts[DialogResult.Yes];
                    button1.DialogResult = DialogResult.Yes;
                    addKeyMap(findButtonKey(DialogResult.Yes, DialogResult.Yes, DialogResult.No, DialogResult.Cancel), DialogResult.Yes);
                    AcceptButton = button1;

                    button2.Text = _info.ButtonTexts[DialogResult.No];
                    button2.DialogResult = DialogResult.No;
                    addKeyMap(findButtonKey(DialogResult.No, DialogResult.Yes, DialogResult.No, DialogResult.Cancel), DialogResult.No);

                    button3.Text = _info.ButtonTexts[DialogResult.Cancel];
                    button3.DialogResult = DialogResult.Cancel;
                    addKeyMap(findButtonKey(DialogResult.Cancel, DialogResult.Yes, DialogResult.No, DialogResult.Cancel), DialogResult.Cancel);
                    CancelButton = button3;

                    switch (_info.DefaultButton)
                    {
                        case MessageBoxDefaultButton.Button1:
                            AcceptButton = button1;
                            break;
                        case MessageBoxDefaultButton.Button2:
                            AcceptButton = button2;
                            button1.TabIndex = 2;
                            button2.TabIndex = 0;
                            button3.TabIndex = 1;
                            break;
                        case MessageBoxDefaultButton.Button3:
                            AcceptButton = button3;
                            button1.TabIndex = 1;
                            button2.TabIndex = 2;
                            button3.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button4:
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    buttonCount = 3;
                }
                break;
            case MessageBoxButtons.YesNo:
                {
                    button1.Visible = false;

                    button2.Text = _info.ButtonTexts[DialogResult.Yes];
                    button2.DialogResult = DialogResult.Yes;
                    addKeyMap(findButtonKey(DialogResult.Yes, DialogResult.Yes, DialogResult.No), DialogResult.Yes);
                    AcceptButton = button2;

                    button3.Text = _info.ButtonTexts[DialogResult.No];
                    addKeyMap(findButtonKey(DialogResult.No, DialogResult.Yes, DialogResult.No), DialogResult.No);
                    button3.DialogResult = DialogResult.No;

                    CancelButton = null;
                    ControlBox = false;

                    switch (_info.DefaultButton)
                    {
                        case MessageBoxDefaultButton.Button1:
                            AcceptButton = button2;
                            break;
                        case MessageBoxDefaultButton.Button2:
                        case MessageBoxDefaultButton.Button3:
                            AcceptButton = button3;
                            button2.TabIndex = 1;
                            button3.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button4:
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    buttonCount = 2;
                }
                break;
            case MessageBoxButtons.RetryCancel:
                {
                    button1.Visible = false;

                    button2.Text = _info.ButtonTexts[DialogResult.Retry];
                    button2.DialogResult = DialogResult.Retry;
                    addKeyMap(findButtonKey(DialogResult.Retry, DialogResult.Retry, DialogResult.Cancel), DialogResult.Retry);
                    AcceptButton = button2;

                    button3.Text = _info.ButtonTexts[DialogResult.Cancel];
                    button3.DialogResult = DialogResult.Cancel;
                    addKeyMap(findButtonKey(DialogResult.Cancel, DialogResult.Retry, DialogResult.Cancel), DialogResult.Cancel);
                    CancelButton = button3;

                    switch (_info.DefaultButton)
                    {
                        case MessageBoxDefaultButton.Button1:
                            AcceptButton = button2;
                            break;
                        case MessageBoxDefaultButton.Button2:
                        case MessageBoxDefaultButton.Button3:
                            AcceptButton = button3;
                            button2.TabIndex = 1;
                            button3.TabIndex = 0;
                            break;
                        case MessageBoxDefaultButton.Button4:
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    buttonCount = 2;
                }
                break;

            case MessageBoxButtons.CancelTryContinue:
            default:
                throw new ArgumentOutOfRangeException();
        }

        switch (buttonCount)
        {
            case 2:
                Width -= buttonDelta;
                //_minWidth -= buttonDelta;
                break;
            case 1:
                Width -= buttonDelta * 2;
                //_minWidth -= buttonDelta * 2;
                break;
        }

        // Merken um Timer schön zu formatieren.
        if (AcceptButton != null && _info.VisualCloseCountDown && _info.CloseCountDown > TimeSpan.Zero)
        {
            var button = (SimpleButton)AcceptButton;

            // Unveränderten Wert merken.
            _acceptButtonDefaultText = button.Text;

            // Jetzt gleich die größte Breite setzen.
            button.Text = formatDefaultButtonCountDownText((int)_info.CloseCountDown.TotalSeconds);
        }

        resizeButtons();
        repositionButtons();
    }

    private string formatDefaultButtonCountDownText(int seconds)
    {
        return $@"{_acceptButtonDefaultText} ({seconds})";
        //return string.Format(@"{0} - {1}", _acceptButtonDefaultText, seconds);
        //return string.Format(@"{0} ({1} s)", _acceptButtonDefaultText, seconds);
    }

    private void repositionButtons()
    {
        button3.Left = ClientRectangle.Width - _buttonBorderDistance - button3.Width;
        button2.Left = button3.Left - _buttonSpacing - button2.Width;
        button1.Left = button2.Left - _buttonSpacing - button1.Width;
    }

    private void resizeButtons()
    {
        resizeButton(button1);
        resizeButton(button2);
        resizeButton(button3);
    }

    private void resizeButton(Control button)
    {
        if (button.Visible)
        {
            using var g = CreateGraphics();
            var size = g.MeasureString(button.Text, SkinHelper.StandardFont);

            var borderDistance = button.Height * 0.5; // One height as distance.
            if (button.Width - 2 * borderDistance - size.Width < 0)
            {
                button.Width = (int)(size.Width + 2 * borderDistance);
            }
        }
    }

    private string findButtonKey(
        DialogResult button,
        params DialogResult[] allButtons)
    {
        var myKey = _info.ButtonTexts[button][0].ToString(CultureInfo.InvariantCulture).ToUpperInvariant()[0];
        if (allButtons.Length <= 1)
        {
            return myKey.ToString(CultureInfo.InvariantCulture);
        }
        else
        {
            var used = new List<char>();
            var assigned = new List<char>();

            foreach (var b in allButtons)
            {
                var wantCont = false;

                for (var i = 0; i < _info.ButtonTexts[b].Length; i++)
                {
                    myKey = _info.ButtonTexts[b][i].ToString(CultureInfo.InvariantCulture).ToUpperInvariant()[0];

                    if (!used.Contains(myKey))
                    {
                        assigned.Add(myKey);
                        used.Add(myKey);

                        wantCont = true;
                        break;
                    }
                }

                if (!wantCont)
                {
                    assigned.Add(' '); // Not assignable.
                }
            }

            // --

            for (var i = 0; i < allButtons.Length; i++)
            {
                var b = allButtons[i];
                if (b == button)
                {
                    return assigned[i] == ' ' ? null : assigned[i].ToString(CultureInfo.InvariantCulture);
                }
            }


            return null;
        }
    }

    private void addKeyMap(string rawKey, DialogResult dr)
    {
        var key = (Keys)Enum.Parse(typeof(Keys), rawKey, true);

        _keyMap[key] = dr;
        _keyMap[key | Keys.Alt] = dr;
    }

    private void buildText()
    {
        textControl.Text = _info.Text == null ? string.Empty : _info.Text.Trim();
    }

    private void adjustSize()
    {
        if (_info.Text != null)
        {
            for (var i = 0; i < 2; ++i)
            {
                var maxFormWidth = MaximumFormWidth;
                var maxTextBoxWidth = maxFormWidth - (Width - textControl.Width);

                var maxFormHeight = MaximumFormHeight;
                var maxTextBoxHeight = maxFormHeight - (Height - textControl.Height);

                // --

                //SizeF s;
                //using (var graphics = CreateGraphics())
                //{
                //    s = graphics.MeasureString(
                //        _info.Text,
                //        SkinHelper.StandardFont,
                //        new SizeF(maxTextBoxWidth, maxTextBoxHeight));
                //}

                // 2013-09-23, Uwe Keim: Geändert von Graphics.MeasureString zu TextRenderer.MeasureText,
                // weil lange Texte irgendwie abgeschnitten wurden.
                var s = TextRenderer.MeasureText(
                    _info.Text,
                    SkinHelper.StandardFont,
                    new(maxTextBoxWidth, maxTextBoxHeight),
                    TextFormatFlags.WordBreak | TextFormatFlags.PreserveGraphicsClipping);

                var deltaWidth = s.Width - textControl.Width;
                if (deltaWidth > 0) Width += deltaWidth;

                var deltaHeight = s.Height - textControl.Height;
                if (deltaHeight > 0) Height += deltaHeight;

                // --
                // Buttons must be visible.

                var anotherPass = false;

                if (button1.Visible)
                {
                    if (button1.Left < _buttonBorderDistance)
                    {
                        Width += _buttonBorderDistance - button1.Left;
                        anotherPass = true;
                    }
                }
                else if (button2.Visible)
                {
                    if (button2.Left < _buttonBorderDistance)
                    {
                        Width += _buttonBorderDistance - button2.Left;
                        anotherPass = true;
                    }
                }
                else
                {
                    if (button3.Left < _buttonBorderDistance)
                    {
                        Width += _buttonBorderDistance - button3.Left;
                        anotherPass = true;
                    }
                }

                // --

                if (anotherPass)
                {
                    Height = _initialHeight;
                }
                else
                {
                    break;
                }
            }
        }
    }

    private void closeCountDownTimer_Tick(object sender, EventArgs e)
    {
        updateVisualCountDownTimer.Stop();
        closeCountDownTimer.Stop();

        AcceptButton?.PerformClick();
    }

    private void updateVisualCountDownTimer_Tick(object sender, EventArgs e)
    {
        updateVisualCountDownTimer.Stop();

        if (AcceptButton != null)
        {
            var deltaSinceStart = (DateTime.Now - _countdownStartedAt).TotalSeconds;
            var max = _info.CloseCountDown.TotalSeconds;
            var deltaToMax = (int)(max - deltaSinceStart);

            var button = (SimpleButton)AcceptButton;
            button.Text = formatDefaultButtonCountDownText(deltaToMax);

            updateVisualCountDownTimer.Start();
        }
    }

    private void MyMessageBoxTemplateForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        updateVisualCountDownTimer.Stop();
        closeCountDownTimer.Stop();
    }
}