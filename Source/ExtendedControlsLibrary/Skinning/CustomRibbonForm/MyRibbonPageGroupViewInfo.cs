namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomRibbonForm;

using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

public class MyRibbonPageGroupViewInfo : RibbonPageGroupViewInfo
{
    public MyRibbonPageGroupViewInfo(RibbonViewInfo viewInfo, RibbonPageGroup group) : 
        base(viewInfo, group)
    {
    }

    protected override GroupObjectInfoArgs SetupDrawArgs()
    {
        if (DesignModeHelper.IsDesignMode)
        {
            return base.SetupDrawArgs();
        }
        else
        {
            var args = base.SetupDrawArgs();

            // http://www.devexpress.com/Support/Center/p/Q279976.aspx
            args.ShowCaption = false;
				
            return args;
        }
    }
}