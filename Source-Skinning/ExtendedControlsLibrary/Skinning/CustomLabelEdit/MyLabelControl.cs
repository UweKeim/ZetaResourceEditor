namespace ExtendedControlsLibrary.Skinning.CustomLabelEdit;

using DevExpress.XtraEditors;

public class MyLabelControl :
    LabelControl
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Appearance.Font = SkinHelper.StandardFont;
    }
}