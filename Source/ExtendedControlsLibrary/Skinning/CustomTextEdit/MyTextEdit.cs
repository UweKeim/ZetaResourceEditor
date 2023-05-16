﻿namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomTextEdit;

using System.ComponentModel;
using CustomForm;
using General;

[Designer(@"System.Windows.Forms.Design.ButtonBaseDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class MyTextEdit :
    ExtendedManagedCueTextEdit
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        ViewInfo.Appearance.Font = SkinHelper.StandardFont;
    }

    protected override void OnLoaded()
    {
        base.OnLoaded();

        if (!DesignModeHelper.IsDesignMode)
        {
            MenuManager = MyXtraForm.CheckGetMenuBarManager(this);
        }
    }
}