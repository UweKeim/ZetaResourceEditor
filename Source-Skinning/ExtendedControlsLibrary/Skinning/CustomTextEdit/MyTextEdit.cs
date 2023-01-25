namespace ExtendedControlsLibrary.Skinning.CustomTextEdit;

using System.ComponentModel;
using System.Drawing;
using CustomForm;
using General;

[Designer(@"System.Windows.Forms.Design.ButtonBaseDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class MyTextEdit :
    ExtendedManagedCueTextEdit
{
    public bool Bold { get; set; }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        ViewInfo.Appearance.Font = SkinHelper.StandardFont;
        //ViewInfo.Appearance.Font = Bold ? SkinHelper.StandardFontBold : SkinHelper.StandardFont;
    }

    protected override void OnLoaded()
    {
        base.OnLoaded();

        if (!DesignModeHelper.IsDesignMode)
        {
            MenuManager = MyXtraForm.CheckGetMenuBarManager(this);
        }
    }

    public override Size MinimumSize
    {
        get => new(base.MinimumSize.Width, 24);
        set => base.MinimumSize = value with { Height = 24 };
    }

    public override Size MaximumSize
    {
        get => new(base.MaximumSize.Width, 24);
        set => base.MaximumSize = value with { Height = 24 };
    }
}