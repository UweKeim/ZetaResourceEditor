namespace ExtendedControlsLibrary.Skinning.CustomRibbonForm
{
    using DevExpress.XtraBars.Ribbon;
    using DevExpress.XtraBars.Ribbon.ViewInfo;

    public class MyRibbonPanelViewInfo : RibbonPanelViewInfo
	{
		public MyRibbonPanelViewInfo(RibbonViewInfo viewInfo) : base(viewInfo) { }

		protected override RibbonPageGroupViewInfo CreateGroupViewInfo(RibbonPageGroup group)
		{
			return new MyRibbonPageGroupViewInfo(ViewInfo, group);
		}
	}
}