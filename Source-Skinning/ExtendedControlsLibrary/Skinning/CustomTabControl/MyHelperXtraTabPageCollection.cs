namespace ExtendedControlsLibrary.Skinning.CustomTabControl
{
    using DevExpress.XtraTab;

    public class MyHelperXtraTabPageCollection :
		XtraTabPageCollection
	{
		// http://www.devexpress.com/Support/Center/p/S130636.aspx
		// http://www.devexpress.com/Support/Center/p/CQ23743.aspx

		public MyHelperXtraTabPageCollection(XtraTabControl tabControl) : 
			base(tabControl)
		{
		}

		protected override XtraTabPage CreatePage()
		{
			return new MyHelperXtraTabPage();
		}
	}
}