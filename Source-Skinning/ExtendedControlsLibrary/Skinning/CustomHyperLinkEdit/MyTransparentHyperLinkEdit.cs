namespace ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit;

using System.Drawing;
using System.Windows.Forms;

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