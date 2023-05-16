namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit;

public class MyHyperLinkEdit :
	AutoWidthHyperLinkEdit
{
	protected override void OnCreateControl()
	{
		base.OnCreateControl();

		ViewInfo.Appearance.Font = SkinHelper.StandardFont;

		Properties.Appearance.Font =
			new(Properties.Appearance.Font, Properties.Appearance.Font.Style & ~FontStyle.Underline);
		Properties.Appearance.Options.UseFont = true;
	}
}