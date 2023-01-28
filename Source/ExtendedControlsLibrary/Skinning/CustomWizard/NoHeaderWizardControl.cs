namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomWizard;

using System.Linq;
using System.Reflection;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraWizard;
using WizardButton = DevExpress.XtraWizard.WizardButton;

public class NoHeaderWizardControl : WizardControl
{
    // http://www.devexpress.com/Support/Center/p/Q330941.aspx
    // http://www.devexpress.com/Support/Center/p/Q234633.aspx
    // http://www.devexpress.com/Support/Center/p/Q337960.aspx

    private bool _firstTime;
    private Point _lowerRight;

    public NoHeaderWizardControl()
    {
        WizardStyle = WizardStyle.WizardAero;
        AllowTransitionAnimation = false;
        AllowAutoScaling = DefaultBoolean.False;
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        WizardStyle = WizardStyle.WizardAero;
        AllowTransitionAnimation = false;
        AllowAutoScaling = DefaultBoolean.False;

        _firstTime = true;
        ((NoHeaderWizardViewInfo)ViewInfo).DoUpdateButtons();
    }

    protected override WizardViewInfo CreateViewInfo()
    {
        return new NoHeaderWizardViewInfo(this);
    }

    protected override WizardPainter CreatePainter() { return new NoHeaderWizardPainter(); }

    protected override void OnParentChanged(EventArgs e)
    {
        base.OnParentChanged(e);

        if (!DesignModeHelper.IsDesignMode)
        {
            checkEnsureInsidePanel();
        }
    }

    private void checkEnsureInsidePanel()
    {
        if (WizardStyle == WizardStyle.WizardAero)
        {
            if (Parent is not PanelControl || Parent.BackColor != Color.Transparent ||
                ((PanelControl)Parent).BorderStyle != BorderStyles.NoBorder)
            {
                throw new(@"Please place the wizard inside a panel that is set to a transparent background color, and no border.");
            }
        }
    }

    private static WizardButton getButton(ButtonInfo info)
    {
        var fi = typeof(ButtonInfo).GetField(@"button", BindingFlags.Instance | BindingFlags.NonPublic);
        return (WizardButton)fi?.GetValue(info);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        _firstTime = true;
        base.OnSizeChanged(e);
    }

    protected override void RaiseCustomizeCommandButtons(CustomizeCommandButtonsEventArgs e)
    {
        // Einmalig den rechten unteren Punkt merken und zukünftig dann von
        // dort aus alle Buttons ausrichten.
        if (_firstTime)
        {
            _firstTime = false;

            var button = getRightmostButton(e);
            _lowerRight = new(button.Location.X + button.Size.Width, button.Location.Y + button.Size.Height);
        }

        // --

        base.RaiseCustomizeCommandButtons(e);

        // --

        // Apply the back button visibility to our custom back button.
        if (WizardStyle == WizardStyle.WizardAero)
        {
            var buttonSize = NoHeaderWizardAeroModel.IsGerman ? new(85, 28) : new Size(75, 28);
            const int buttonDistanceX = 5;

            var orderedButtons =
                new List<ButtonInfo>
                {
                    e.PrevButton,
                    e.NextButton,
                    e.CancelButton,
                    e.FinishButton,
                    e.HelpButton
                };

            var orderedVisibleButtons =
                orderedButtons.Where(b => b.Visible).ToArray();

            // Lückenlos platzieren.

            var startX =
                _lowerRight.X -
                (orderedVisibleButtons.Length * buttonSize.Width +
                 (orderedVisibleButtons.Length - 1) * buttonDistanceX);
            var startY = _lowerRight.Y - buttonSize.Height;

            foreach (var button in orderedVisibleButtons)
            {
                button.Location = new(startX, startY);

                var b = getButton(button);
                b.Size = buttonSize;

                startX += buttonSize.Width + buttonDistanceX;
            }

            /*
            var buttonSize = NoHeaderWizardAeroModel.IsGerman ? new Size(85, 28) : new Size(75, 28);

            var prevButton = getButton(e.PrevButton);
            var nextButton = getButton(e.NextButton);
            var cancelButton = getButton(e.CancelButton);
            var finishButton = getButton(e.FinishButton);
            var helpButton = getButton(e.HelpButton);

            var delta = new Size(buttonSize.Width - nextButton.Width, buttonSize.Height - nextButton.Height);

            if (delta.Width > 0 || delta.Height > 0)
            {
                prevButton.Size = buttonSize;
                nextButton.Size = buttonSize;
                cancelButton.Size = buttonSize;
                finishButton.Size = buttonSize;
                helpButton.Size = buttonSize;

                // --

                changeLocation(e.CancelButton, -0 * delta.Width, -delta.Height / 2);
                changeLocation(e.FinishButton, -1 * delta.Width, -delta.Height / 2);
                changeLocation(e.NextButton, -1 * delta.Width, -delta.Height / 2);
            }

            // --

            if (e.PrevButton.Visible)
            {
                var leftmostLoc = getLeftmostLocation(e);

                e.PrevButton.Location = new Point(
                    leftmostLoc - e.NextButton.Size.Width - WizardAeroConsts.CommandButtonSpacing,
                    e.NextButton.Location.Y);
            }
            */
        }
    }

    private static ButtonInfo getRightmostButton(CustomizeCommandButtonsEventArgs e)
    {
        var buttons = new List<ButtonInfo>
        {
            e.CancelButton,
            e.FinishButton,
            e.HelpButton,
            e.NextButton,
            e.PrevButton
        };

        buttons.Sort((x, y) => (x.Location.X + x.Size.Width).CompareTo(y.Location.X + y.Size.Width));
        buttons.Reverse();

        return buttons[0];
    }

    private static void changeLocation(ButtonInfo info, int dx, int dy)
    {
        info.Location = new(info.Location.X + dx, info.Location.Y + dy);
    }

    private static int getLeftmostLocation(CustomizeCommandButtonsEventArgs e)
    {
        var left = 10000;
        if (e.CancelButton.Visible)
        {
            left = Math.Min(left, e.CancelButton.Location.X);
        }
        if (e.FinishButton.Visible)
        {
            left = Math.Min(left, e.FinishButton.Location.X);
        }
        if (e.PrevButton.Visible)
        {
            left = Math.Min(left, e.PrevButton.Location.X);
        }
        if (e.NextButton.Visible)
        {
            left = Math.Min(left, e.NextButton.Location.X);
        }
        if (e.HelpButton.Visible)
        {
            left = Math.Min(left, e.HelpButton.Location.X);
        }

        return left == 10000 ? 0 : left;
    }
}