namespace ZetaResourceEditor.ExtendedControlsLibrary.Specialized;

using Skinning;
using static ColorTranslator;

/// <summary>
/// All the (special) grid colors.
/// </summary>
public static class GridColors
{
	public static Color CommentForeColor => choose(Color.DarkGray, FromHtml(@"#b2aa9e"));
	public static Color CompleteRowEmptyForeColor => choose(Color.FromArgb(160, 160, 160), FromHtml(@"#ada597"));
	public static Color TagNameForeColor => choose(Color.DarkBlue, FromHtml(@"#84a9e9"));
	public static Color NullCellBackColor => choose(Color.Lavender, FromHtml(@"#c5d0e3"));
	public static Color EmptyCellBackColor => choose(Color.FromArgb(255, 233, 127), FromHtml(@"#f7e07c"));
	public static Color PlaceHolderMismatchForeColor => choose(Color.Red, FromHtml(@"#e72c2a"));
	public static Color TranslationErrorForeColor => choose(Color.Red, FromHtml(@"#e72c2a"));
	public static Color TranslationSuccessForeColor => choose(Color.Green, FromHtml(@"#81f179"));

	private static Color choose(Color colorLight, Color? colorDark = null)
	{
		if (colorDark == null) return colorLight;
		else return SkinHelper.UseWindowsDarkModeSkin() ? colorDark.GetValueOrDefault() : colorLight;
	}
}