namespace ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit
{
	public class MyLargeColoredHyperLinkEdit :
		AutoWidthHyperLinkEdit
	{
		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			ViewInfo.Appearance.Font = SkinHelper.LargeFont;
		}
	}
}