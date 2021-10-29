namespace ExtendedControlsLibrary.Skinning.CustomDropDownButton;

using System;
using System.ComponentModel;
using CustomForm;
using DevExpress.XtraEditors;

[Designer(@"System.Windows.Forms.Design.ButtonBaseDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class MyDropDownButton :
    DropDownButton
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Appearance.Font = SkinHelper.StandardFont;
    }

    protected override void OnParentChanged(EventArgs e)
    {
        base.OnParentChanged(e);

        if (!DesignModeHelper.IsDesignMode)
        {
            MenuManager = MyXtraForm.CheckGetMenuBarManager(this);
        }
    }

    //protected override BaseStyleControlViewInfo CreateViewInfo()
    //{
    //    if (DesignMode || IsDesignMode)
    //    {
    //        return base.CreateViewInfo();
    //    }
    //    else
    //    {
    //        return new MyDropDownButtonViewInfo(this);
    //    }
    //}
}