namespace ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit
{
    using System.Drawing;

    public class MyColoredHyperLinkEdit :
		AutoWidthHyperLinkEdit
	{
		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			ViewInfo.Appearance.Font = SkinHelper.StandardFont;
			ViewInfo.Appearance.Options.UseFont = true;

			Properties.Appearance.Font = new Font(Properties.Appearance.Font, Properties.Appearance.Font.Style & ~FontStyle.Underline);
			Properties.Appearance.Options.UseFont = true;
		}
	}
}