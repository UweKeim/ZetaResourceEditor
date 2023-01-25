namespace ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit;

using System.Drawing;

public class MyHyperLinkEdit :
    AutoWidthHyperLinkEdit
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        ViewInfo.Appearance.Font = SkinHelper.StandardFont;
        //ForeColor = SkinHelper.LinkColor;

        Properties.Appearance.Font = new(Properties.Appearance.Font, Properties.Appearance.Font.Style & ~FontStyle.Underline);
        Properties.Appearance.Options.UseFont = true;
    }
}