namespace ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit;

using System;
using System.Drawing;
using CustomForm;
using DevExpress.XtraEditors;

public class MyFullHyperLinkEdit :
    HyperLinkEdit
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        ViewInfo.Appearance.Font = SkinHelper.StandardFont;
        //ForeColor = SkinHelper.LinkColor;

        Properties.Appearance.Font = new Font(Properties.Appearance.Font, Properties.Appearance.Font.Style & ~FontStyle.Underline);
        Properties.Appearance.Options.UseFont = true;
    }

    protected override void OnLoaded()
    {
        base.OnLoaded();

        if (!DesignModeHelper.IsDesignMode)
        {
            MenuManager = MyXtraForm.CheckGetMenuBarManager(this);
        }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);

        // http://www.devexpress.com/Support/Center/p/Q255025.aspx
        Font = new Font(Font, Font.Style | FontStyle.Underline);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);

        // http://www.devexpress.com/Support/Center/p/Q255025.aspx
        Properties.Appearance.Font = new Font(Properties.Appearance.Font, Properties.Appearance.Font.Style & ~FontStyle.Underline);
        Properties.Appearance.Options.UseFont = true;
    }
}