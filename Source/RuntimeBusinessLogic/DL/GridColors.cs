namespace ZetaResourceEditor.RuntimeBusinessLogic.DL;

using System.Drawing;

/// <summary>
/// All the (special) grid colors.
/// </summary>
public static class GridColors
{
    public static readonly Color CommentForeColor = Color.DarkGray;
    public static readonly Color CompleteRowEmptyForeColor = SystemColors.ButtonShadow;
    public static readonly Color TagNameForeColor = Color.DarkBlue;
    public static readonly Color NullCellBackColor = Color.Lavender;
    public static readonly Color EmptyCellBackColor = Color.FromArgb(255, 233, 127);
    public static readonly Color PlaceHolderMismatchForeColor = Color.Red;
    public static readonly Color TranslationErrorForeColor = Color.Red;
    public static readonly Color TranslationSuccessForeColor = Color.Green;
}