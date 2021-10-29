namespace ExtendedControlsLibrary.Specialized.MessageBox;

using System.Windows.Forms;

internal class MyMessageBoxImplementation
{
    public static DialogResult Show(MyMessageBoxInformation info)
    {
        using var form = new MyMessageBoxTemplateForm();
        var owner = info.EffectiveOwner;

        form.Initialize(info);
        return owner == null ? form.ShowDialog() : form.ShowDialog(owner);
    }
}