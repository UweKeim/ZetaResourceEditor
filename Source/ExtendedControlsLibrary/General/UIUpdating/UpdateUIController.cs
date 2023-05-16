namespace ZetaResourceEditor.ExtendedControlsLibrary.General.UIUpdating;

using Base;

/// <summary>
/// Create an instance of this class in each class that implements IUpdateUI.
/// </summary>
public class UpdateUIController
{
    public void PerformUpdateUI(IUpdateUI updateUI, object? userState = null)
    {
        updateUI.DoUpdateUI(new(userState));
    }
}