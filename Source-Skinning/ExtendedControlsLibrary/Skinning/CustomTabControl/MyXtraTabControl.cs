namespace ExtendedControlsLibrary.Skinning.CustomTabControl
{
    using DevExpress.XtraTab;

    /// <summary>
	/// A tab control that is not "visible" during runtime and only
	/// serves as a way to allow for programmatical switching between 
	/// multiple layered pages.
	/// </summary>
	public class MyXtraTabControl :
		XtraTabControl
	{
		public static void MakeTabControlInvisible(
			XtraTabControl tabControl)
		{
		}

		protected override XtraTabPageCollection CreateTabCollection()
		{
			// http://www.devexpress.com/Support/Center/p/S130636.aspx
			// http://www.devexpress.com/Support/Center/p/CQ23743.aspx

			return new MyXtraTabPageCollection(this);
		}

		//#region Hide several properties from designer.

		//[Browsable(false)]
		//[EditorBrowsable(EditorBrowsableState.Never)]
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		//public override DefaultBoolean ShowTabHeader { get { return base.ShowTabHeader; } set { base.ShowTabHeader = value; } }

		//[Browsable(false)]
		//[EditorBrowsable(EditorBrowsableState.Never)]
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		//public override BorderStyles BorderStyle { get { return base.BorderStyle; } set { base.BorderStyle = value; } }

		//[Browsable(false)]
		//[EditorBrowsable(EditorBrowsableState.Never)]
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		//public override BorderStyles BorderStylePage { get { return base.BorderStylePage; } set { base.BorderStylePage = value; } }

		//[Browsable(false)]
		//[EditorBrowsable(EditorBrowsableState.Never)]
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		//public override UserLookAndFeel LookAndFeel { get { return base.LookAndFeel; } }

		//[Browsable(false)]
		//[EditorBrowsable(EditorBrowsableState.Never)]
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		//public new Padding Padding { get { return base.Padding; } set { base.Padding = value; } }

		//[Browsable(false)]
		//[EditorBrowsable(EditorBrowsableState.Never)]
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		//public new Padding Margin { get { return base.Margin; } set { base.Margin = value; } }

		//#endregion

		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			MakeTabControlInvisible(this);

			Font = SkinHelper.StandardFont;
			AppearancePage.Header.Font = SkinHelper.StandardFont;
		}
	}
}