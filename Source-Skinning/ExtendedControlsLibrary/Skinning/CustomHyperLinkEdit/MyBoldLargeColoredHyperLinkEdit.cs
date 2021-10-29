namespace ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit;

public class MyBoldLargeColoredHyperLinkEdit :
    AutoWidthHyperLinkEdit
{
    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        ViewInfo.Appearance.Font = SkinHelper.LargeFontBold;
    }
}