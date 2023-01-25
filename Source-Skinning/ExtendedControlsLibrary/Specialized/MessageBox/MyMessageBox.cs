namespace ExtendedControlsLibrary.Specialized.MessageBox;

[PublicAPI]
public static class MyMessageBox
{
    public static DialogResult Show(
        MyMessageBoxInformation information)
    {
        return MyMessageBoxImplementation.Show(information);
    }
}