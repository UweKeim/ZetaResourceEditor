namespace ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit;

public class MyBoldColoredHyperLinkEdit :
    AutoWidthHyperLinkEdit
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        ViewInfo.Appearance.Font = SkinHelper.StandardFontBold;
    }
}