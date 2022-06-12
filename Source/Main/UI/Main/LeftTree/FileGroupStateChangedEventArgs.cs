namespace ZetaResourceEditor.UI.Main.LeftTree;

using RuntimeBusinessLogic.DL;

public class FileGroupStateChangedEventArgs :
    EventArgs
{
    public FileGroupStateChangedEventArgs(
        IGridEditableData gridEditableData)
    {
        GridEditableData = gridEditableData;
    }

    public IGridEditableData GridEditableData { get; }
}