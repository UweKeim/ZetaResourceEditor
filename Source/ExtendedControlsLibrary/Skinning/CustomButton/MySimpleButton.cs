namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomButton;

using DevExpress.XtraEditors;
using System.ComponentModel;

[Designer(@"System.Windows.Forms.Design.ButtonBaseDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class MySimpleButton :
    SimpleButton
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Appearance.Font = SkinHelper.StandardFont;
    }
}
