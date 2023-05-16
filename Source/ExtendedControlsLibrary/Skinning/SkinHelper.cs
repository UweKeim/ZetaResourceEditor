namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning;

using CustomRibbonForm;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using System.Configuration;
using Zeta.VoyagerLibrary.Core.Common;
using Zeta.VoyagerLibrary.Core.Logging;

public static class SkinHelper
{
	// ---------------------------------------------------------------------------------
	// DevExpress sagt:
	// 
	// "Do not use the Microsoft Windows graphics device interface (GDI)﻿ before the
	//  application is set as DPI-aware. This may lead to unexpected behavior.
	//  That is, do not use any graphic objects such as Bitmaps, Brushes, or Fonts.
	//  Also, do not invoke any subsystems that might use them (for example, do not
	//  apply a skin to the application)."
	//
	// Quelle:
	// https://docs.devexpress.com/WindowsForms/116666/common-features/high-dpi-support
	// ---------------------------------------------------------------------------------

	public static Font StandardFont => new(@"Segoe UI", 10, GraphicsUnit.Point);
	public static Font StandardFontBold => new(@"Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point);

	private static MyDefaultBarAndDockingController? _badc;

	public static Color DialogTextColor { get; private set; }
	public static Color DialogBackgroundColor { get; private set; }

	public static Color LineColorTop { get; private set; }
	public static Color LineColorBottom { get; private set; }
	public static Color ControlBorderColor { get; private set; }

	public static Color AlternatingGridRowColors { get; private set; }

	internal static Color CueTextColor { get; private set; }

	public static void InitializeAll()
	{
		DesignModeHelper.TurnOffDesignMode();
		
		WindowsFormsSettings.ForceDirectXPaint();
		WindowsFormsSettings.EnableFormSkins();
		
		if (!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
			WindowsFormsSettings.SetPerMonitorDpiAware();
		else
			WindowsFormsSettings.SetDPIAware();

		Application.EnableVisualStyles();
		WindowsFormsSettings.ForcePaintApiDiagnostics(DevExpress.Utils.Diagnostics.PaintApiDiagnosticsLevel.Throw);
		Application.SetCompatibleTextRenderingDefault(false);

		WindowsFormsSettings.OptimizeRemoteConnectionPerformance =
			SystemInformation.TerminalServerSession ? DefaultBoolean.True : DefaultBoolean.False;

		// Erst _nach_ dem Setzen der DPI-Awareness.
		initColors();

		BarAndDockingController.Default.PropertiesBar.ScaleEditors = true;
		BarAndDockingController.Default.PropertiesRibbon.ScaleEditors = true;

		UserLookAndFeel.Default.SetSkinStyle(
			UseWindowsDarkModeSkin()
				? SkinStyle.DevExpressDark
				: SkinStyle.DevExpress);

		AppearanceObject.DefaultFont = StandardFont;

		_badc = new();
		_badc.Apply();
	}

	private static void initColors()
	{
		DialogTextColor = Color.FromArgb(59, 59, 59);
		DialogBackgroundColor = Color.FromArgb(255, 255, 255);

		LineColorTop = Color.FromArgb(207, 207, 207);
		LineColorBottom = Color.FromArgb(245, 245, 245);
		ControlBorderColor = Color.FromArgb(200, 200, 200);

		AlternatingGridRowColors = Color.FromArgb(249, 249, 249);

		CueTextColor = Color.Silver;
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
			const int fallBack = -1;

			var val = ConvertHelper.ToInt32(Registry.GetValue(
					@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize",
					@"AppsUseLightTheme",
					fallBack) ?? string.Empty,
				fallBack);

			return val == 0;
		}
		catch (Exception x)
		{
			LogCentral.Current.Warn(x,
				@"Fehler beim Ermitteln von Light-/Dark-Windows-Einstellung. Ignoriere, nehme Light.");
			return false;
		}
	}
}