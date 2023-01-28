namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomLabelEdit;

using DevExpress.XtraEditors;

public class MyLabelBoldControl :
    LabelControl
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Appearance.Font = SkinHelper.StandardFontBold;
    }
}