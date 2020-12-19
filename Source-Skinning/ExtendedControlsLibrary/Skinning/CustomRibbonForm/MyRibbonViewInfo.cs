namespace ExtendedControlsLibrary.Skinning.CustomRibbonForm
{
    using DevExpress.XtraBars.Ribbon;
    using DevExpress.XtraBars.Ribbon.ViewInfo;

    public class MyRibbonViewInfo : RibbonViewInfo
	{
		public MyRibbonViewInfo(RibbonControl ribbon)
			: base(ribbon)
		{
		}

        protected new MyRibbonControl Ribbon => base.Ribbon as MyRibbonControl;

        protected override RibbonPanelViewInfo CreatePanelInfo()
        {
            return DesignModeHelper.IsDesignMode ? base.CreatePanelInfo() : new MyRibbonPanelViewInfo(this);
        }
	}
}