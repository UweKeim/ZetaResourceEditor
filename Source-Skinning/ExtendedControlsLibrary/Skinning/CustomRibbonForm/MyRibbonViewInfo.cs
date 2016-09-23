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

        protected new MyRibbonControl Ribbon
		{
			get { return base.Ribbon as MyRibbonControl; }
		}

        protected override RibbonPanelViewInfo CreatePanelInfo()
        {
            if (DesignModeHelper.IsDesignMode)
            {
                return base.CreatePanelInfo();
            }
            else
            {
                return new MyRibbonPanelViewInfo(this);
            }
        }
	}
}