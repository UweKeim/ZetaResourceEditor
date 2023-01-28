namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning;

using System.Configuration;
using CustomRibbonForm;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using Microsoft.Win32;
using Zeta.VoyagerLibrary.Core.Common;
using Zeta.VoyagerLibrary.Core.Logging;

public static class SkinHelper
{
    public const int ButtonHeight = 28;
    public const string SkinNameMainForm = @"ZetaTestSkin";
    public const string SkinNameDialogForms = @"ZetaTestSkin";

    public const string FontHeightMeasureString = @"yWÀ|";
    public static readonly bool IsRealFontInstalled;

    public static readonly Font SmallFont;

    public static readonly Font StandardFont;
    public static readonly Font StandardFontBold;

    public static readonly Font LargeFont;
    public static readonly Font LargeFontBold;
    public static readonly Font LargeFontUnderline;

    private static SkinController? _currentSkin;
    private static MyDefaultBarAndDockingController? _badc;

    public static readonly Color DialogTextColor = Color.FromArgb(59, 59, 59);
    public static readonly Color DialogBackgroundColor = Color.FromArgb(255, 255, 255);

    public static readonly Color LineColorTop = Color.FromArgb(207, 207, 207);
    public static readonly Color LineColorBottom = Color.FromArgb(245, 245, 245);
    public static readonly Color ControlBorderColor = Color.FromArgb(200, 200, 200);

    public static readonly Color AlternatingGridRowColors = Color.FromArgb(249, 249, 249);

    internal static readonly Color CueTextColor = Color.Silver;

    static SkinHelper()
    {
        var hasMainFont = DesignModeHelper.IsFontInstalled(@"Segoe UI");
        IsRealFontInstalled = hasMainFont;

        const int standardFontSizePixel = 13;
        var largeFontSizePixel = hasMainFont ? 17 : 16;
        const int smallFontSizePixel = 11;

        SmallFont =
            hasMainFont
                ? new(@"Segoe UI", smallFontSizePixel, GraphicsUnit.Pixel)
                : new Font(@"Tahoma", smallFontSizePixel, GraphicsUnit.Pixel);

        StandardFont =
            hasMainFont
                ? new(@"Segoe UI", standardFontSizePixel, GraphicsUnit.Pixel)
                : new Font(@"Tahoma", standardFontSizePixel, GraphicsUnit.Pixel);

        StandardFontBold =
            hasMainFont
                ? new(@"Segoe UI", standardFontSizePixel, FontStyle.Bold, GraphicsUnit.Pixel)
                : new Font(@"Tahoma", standardFontSizePixel, FontStyle.Bold, GraphicsUnit.Pixel);

        LargeFont =
            hasMainFont
                ? new(@"Segoe UI", largeFontSizePixel, GraphicsUnit.Pixel)
                : new Font(@"Tahoma", largeFontSizePixel, GraphicsUnit.Pixel);

        LargeFontBold =
            hasMainFont
                ? new(@"Segoe UI", largeFontSizePixel, FontStyle.Bold, GraphicsUnit.Pixel)
                : new Font(@"Tahoma", largeFontSizePixel, FontStyle.Bold, GraphicsUnit.Pixel);

        LargeFontUnderline =
            hasMainFont
                ? new(@"Segoe UI", largeFontSizePixel, FontStyle.Underline, GraphicsUnit.Pixel)
                : new Font(@"Tahoma", largeFontSizePixel, FontStyle.Underline, GraphicsUnit.Pixel);
    }

    public static SkinController GetCurrentSkin()
    {
        // http://www.devexpress.com/Support/Center/KB/p/A2753.aspx

        var skin = CommonSkins.GetSkin(UserLookAndFeel.Default);

        if (_currentSkin == null || _currentSkin.Skin.Name != skin.Name)
        {
            _currentSkin = new(skin);
        }

        return _currentSkin;
    }

    public static void InitializeAll(bool doNotSetSkin = false)
    {
        DesignModeHelper.TurnOffDesignMode();

		//if(!doNotSetSkin) SkinManager.Default.RegisterAssembly(typeof(ZetaTestSkin).Assembly);

		UserLookAndFeel.Default.SetSkinStyle(
			UseWindowsDarkModeSkin()
				? SkinStyle.DevExpressDark
				: SkinStyle.DevExpress);

		Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Below Windows Vista, use form skins.
        SkinManager.EnableFormSkinsIfNotVista();

        //UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinNameDialogForms);
        if(!doNotSetSkin) UserLookAndFeel.Default.SetSkinStyle(SkinNameDialogForms);
        AppearanceObject.DefaultFont = StandardFont;

        _badc = new();
        _badc.Apply();
    }

    public static bool UseWindowsDarkModeSkin()
    {
	    var mode = (ConfigurationManager.AppSettings[@"lightDarkMode"] ?? string.Empty).Trim().ToLowerInvariant();

	    if (string.IsNullOrEmpty(mode) || mode is @"auto" or @"automatic") return IsWindowsDarkModeActive();
	    else
		    return mode switch
		    {
			    @"dark" => true,
			    @"light" => false,
			    _ => IsWindowsDarkModeActive()
		    };
    }

    public static bool IsWindowsDarkModeActive()
    {
	    // Erkennen, welcher Skin.
	    // https://stackoverflow.com/a/58494769/107625
	    try
	    {
		    // Wenn -1, dann ist es nicht 0, also ist es default
		    // die Light-Version.
		    const int fb = -1;

		    var val = ConvertHelper.ToInt32(Registry.GetValue(
				    @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize",
				    @"AppsUseLightTheme",
				    fb),
			    fb);

		    return val == 0;
	    }
	    catch (Exception x)
	    {
		    LogCentral.Current.Warn(x, @"Fehler beim Ermitteln von Light-/Dark-Windows-Einstellung. Ignoriere, nehme Light.");
		    return false;
	    }
    }
}