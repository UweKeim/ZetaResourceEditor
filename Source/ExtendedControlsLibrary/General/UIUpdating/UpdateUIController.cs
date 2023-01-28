namespace ZetaResourceEditor.ExtendedControlsLibrary.General.UIUpdating;

using System.Diagnostics;
using Base;

/// <summary>
/// Create an instance of this class in each class that implements IUpdateUI.
/// </summary>
public class UpdateUIController
{
    public delegate bool DoShouldProcessDelegate();

    public static DoShouldProcessDelegate WantShouldProcess;
    private readonly DevExpressXtraUserControlBase _controlBase;
    private readonly DevExpressXtraFormBase _formBase;
    private readonly DevExpressRibbonFormBase _ribbonFormBase;
    private readonly List<UpdateUIInformation> _tokens = new();

    public UpdateUIController(
        DevExpressXtraUserControlBase controlBase)
    {
        _controlBase = controlBase;
    }

    public UpdateUIController(
        DevExpressXtraFormBase formBase)
    {
        _formBase = formBase;
    }

    public UpdateUIController(
        DevExpressRibbonFormBase formBase)
    {
        _ribbonFormBase = formBase;
    }

    public bool ShouldProcess(
        UpdateUIInformation information)
    {
        return
            doShouldProcess() &&
            (_controlBase != null || _formBase != null || _ribbonFormBase != null) &&
            (
                _controlBase is { DesignMode: false } ||
                _formBase is { DesignMode: false } ||
                _ribbonFormBase is { DesignMode: false }
            ) &&
            !HasProcessed(information);
    }

    private static bool doShouldProcess()
    {
        var h = WantShouldProcess;
        return h == null || h();
    }

    private bool HasProcessed(
        UpdateUIInformation information)
    {
        if (information == null)
        {
            throw new ArgumentNullException(nameof(information));
        }
        else
        {
            var hasProcessed = _tokens.FindIndex(x => x.Token == information.Token) >= 0;

            if (hasProcessed)
            {
                Trace.TraceInformation(
                    @"Found an already processed token.");
            }

            return hasProcessed;
        }
    }

    public void PerformUpdateUI(IUpdateUI updateUI, object userState = null)
    {
        updateUI.DoUpdateUI(new(userState));
    }
}