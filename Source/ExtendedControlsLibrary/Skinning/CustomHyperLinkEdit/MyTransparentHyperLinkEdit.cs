namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit;

public class MyTransparentHyperLinkEdit :
    LinkLabel
{
    public MyTransparentHyperLinkEdit()
    {
        base.Font = SkinHelper.StandardFont;
        base.BackColor = Color.Transparent;
        //base.ForeColor = SkinHelper.LinkColor;
			
        //LinkColor = SkinHelper.LinkColor;
        //DisabledLinkColor = SkinHelper.LinkColor;
        //ActiveLinkColor = SkinHelper.LinkColor;
        //VisitedLinkColor = SkinHelper.LinkColor;
    }
}