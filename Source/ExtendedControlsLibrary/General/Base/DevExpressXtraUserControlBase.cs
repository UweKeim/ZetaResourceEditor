namespace ZetaResourceEditor.ExtendedControlsLibrary.General.Base;

using Skinning.CustomUserControl;
using UIUpdating;

/// <summary>
/// Base class for controls.
/// </summary>
public class DevExpressXtraUserControlBase :
    MyUserControl,
    IUpdateUI
{
    private UpdateUIController _uuiController;

    public IGuiEnvironment GuiHost => DevExpressXtraFormBase.InternalHost;

    protected UpdateUIController UuiController => _uuiController ??= new(this);

    public virtual void DoUpdateUI(
        UpdateUIInformation information)
    {
        // Does nothing.
    }

    public void PerformUpdateUI(object userState = null)
    {
        if (!DesignMode)
        {
            UuiController.PerformUpdateUI(this, userState);
        }
    }
}