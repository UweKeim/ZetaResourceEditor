namespace ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit;

using System.Drawing;

public class MyBoldHyperLinkEdit :
    AutoWidthHyperLinkEdit
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        ViewInfo.Appearance.Font = SkinHelper.StandardFontBold;
        //ForeColor = SkinHelper.LinkColor;

        Properties.Appearance.Font = new(Properties.Appearance.Font, Properties.Appearance.Font.Style & ~FontStyle.Underline);
        Properties.Appearance.Options.UseFont = true;
    }
}