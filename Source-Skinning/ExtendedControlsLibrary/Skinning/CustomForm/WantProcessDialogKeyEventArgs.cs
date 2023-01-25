namespace ExtendedControlsLibrary.Skinning.CustomForm;

public class WantProcessDialogKeyEventArgs :
    EventArgs
{
    public WantProcessDialogKeyEventArgs(Keys keyData)
    {
        KeyData = keyData;
    }

    public Keys KeyData { get; }

    public bool? Result { get; set; }
}