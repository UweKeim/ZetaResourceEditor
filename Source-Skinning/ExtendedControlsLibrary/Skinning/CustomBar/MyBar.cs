namespace ExtendedControlsLibrary.Skinning.CustomBar
{
    using DevExpress.XtraBars;

    public class MyBar :
		Bar
	{
		public MyBar()
		{
			base.Appearance.Font = SkinHelper.StandardFont;

			if (ViewInfo != null)
			{
				if (ViewInfo.Appearance != null) ViewInfo.Appearance.SetFont(SkinHelper.StandardFont);
				if (ViewInfo.Bar != null && ViewInfo.Bar.Appearance != null) ViewInfo.Bar.Appearance.Font = SkinHelper.StandardFont;
				if (ViewInfo.BarControl != null) ViewInfo.BarControl.Font = SkinHelper.StandardFont;
			}
		}

		//public void f()
		//{
		//    //var t = GetType();
		//    //var p = t.GetField(@"barControl", BindingFlags.Instance | BindingFlags.NonPublic);

		//    //var barControl = (CustomBarControl)p.GetValue(this);
		//    //var c = barControl;
		//}
	}
}