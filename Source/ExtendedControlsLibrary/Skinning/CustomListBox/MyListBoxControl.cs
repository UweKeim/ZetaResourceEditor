namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomListBox;

using DevExpress.XtraEditors;

public class MyListBoxControl :
    ListBoxControl
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Font = SkinHelper.StandardFont;
    }
}