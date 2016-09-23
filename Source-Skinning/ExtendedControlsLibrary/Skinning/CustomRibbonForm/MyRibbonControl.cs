namespace ExtendedControlsLibrary.Skinning.CustomRibbonForm
{
    using DevExpress.XtraBars.Ribbon;
    using DevExpress.XtraBars.Ribbon.ViewInfo;
    using DevExpress.XtraBars.Styles;

    public class MyRibbonControl :
		RibbonControl
	{
		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			Font = SkinHelper.StandardFont;
		}

		protected override RibbonBarManager CreateBarManager()
		{
			return new MyRibbonBarManager(this);
		}

		protected override RibbonViewInfo CreateViewInfo()
		{
			if (DesignModeHelper.IsDesignMode)
			{
				return base.CreateViewInfo();
			}
			else
			{
				return new MyRibbonViewInfo(this);
			}
		}
	}

	public class MyRibbonBarManager : RibbonBarManager
	{
		public MyRibbonBarManager(RibbonControl ribbon) :
			base(ribbon)
		{
		}

		protected override BarManagerPaintStyle PaintStyle
		{
			get
			{
				var ps = base.PaintStyle;
				return ps;
			}
		}
	}
}