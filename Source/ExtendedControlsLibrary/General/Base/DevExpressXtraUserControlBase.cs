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
    public virtual void DoUpdateUI(
        UpdateUIInformation information)
    {
        // Does nothing.
    }
}