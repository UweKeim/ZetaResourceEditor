namespace ExtendedControlsLibrary.Skinning.CustomLabelEdit;

using DevExpress.XtraEditors;

public class MyLargeLabelBoldControl :
    LabelControl
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Appearance.Font = SkinHelper.LargeFontBold;
    }
}