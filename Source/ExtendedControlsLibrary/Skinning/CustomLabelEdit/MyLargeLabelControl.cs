namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomLabelEdit;

using DevExpress.XtraEditors;

public class MyLargeLabelControl :
    LabelControl
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Appearance.Font = SkinHelper.LargeFont;
    }
}