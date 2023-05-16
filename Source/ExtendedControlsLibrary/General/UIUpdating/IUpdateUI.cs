namespace ZetaResourceEditor.ExtendedControlsLibrary.General.UIUpdating;

/// <summary>
/// Implemented by visual controls that support the updating of the
/// UI (i.e. enabling/disabling certain states).
/// </summary>
public interface IUpdateUI
{
    void DoUpdateUI(
        UpdateUIInformation information);
}