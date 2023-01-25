namespace ExtendedControlsLibrary.Skinning.CustomWizard;

using System.Reflection;
using DevExpress.XtraWizard;

internal class NoHeaderWizardViewInfo :
    WizardViewInfo
{
    public NoHeaderWizardViewInfo(WizardControl w)
        : base(w)
    {
    }

    public void DoUpdateButtons()
    {
        UpdateButtons();
    }

    protected override void UpdateButtonsState()
    {
        base.UpdateButtonsState();

        var fi = typeof(WizardViewInfo).GetField(@"prevButtonInfo", BindingFlags.Instance | BindingFlags.NonPublic);
        if (fi != null)
        {
            var prevButtonInfo = (ButtonInfo)fi.GetValue(this);
            if (prevButtonInfo != null)
            {
                prevButtonInfo.Visible = true;

                fi = typeof(ButtonInfo).GetField(@"button", BindingFlags.Instance | BindingFlags.NonPublic);
                if (fi != null)
                {
                    var button = (WizardButton)fi.GetValue(prevButtonInfo);
                    if (button != null) button.Enabled = WizardControl.SelectedPageIndex > 0 && SelectedPage.AllowBack;
                }
            }
        }
    }

    internal WizardControl GetOwnerInternal()
    {
        return WizardControl;
    }

    protected override WizardModelBase CreateWizardModelCore(WizardStyle style)
    {
        return style switch
        {
            WizardStyle.WizardAero => new NoHeaderWizardAeroModel(this),
            _ => base.CreateWizardModelCore(style)
        };
    }
}