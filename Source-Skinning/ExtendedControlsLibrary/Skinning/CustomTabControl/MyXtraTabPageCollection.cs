namespace ExtendedControlsLibrary.Skinning.CustomTabControl
{
    using DevExpress.XtraTab;

    public class MyXtraTabPageCollection :
		XtraTabPageCollection
	{
		// http://www.devexpress.com/Support/Center/p/S130636.aspx
		// http://www.devexpress.com/Support/Center/p/CQ23743.aspx

		public MyXtraTabPageCollection(XtraTabControl tabControl) : 
			base(tabControl)
		{
		}

		protected override XtraTabPage CreatePage()
		{
			return new MyXtraTabPage();
		}
	}
}