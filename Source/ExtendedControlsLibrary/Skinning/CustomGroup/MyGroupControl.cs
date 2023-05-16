namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomGroup;

using DevExpress.XtraEditors;

public class MyGroupControl :
    GroupControl
{
    public MyGroupControl()
    {
        base.AppearanceCaption.Font = SkinHelper.StandardFont;
        base.AppearanceCaption.Options.UseFont = true;
    }
}