namespace ExtendedControlsLibrary;

using System;
using System.Drawing;
using System.Threading;

public static class DesignModeHelper
{
    public static bool IsDesignMode => GetDesignMode();

    /// <summary>
    /// Call this in your Main function.
    /// </summary>
    public static void TurnOffDesignMode()
    {
        Thread.SetData(Thread.GetNamedDataSlot(@"isDesignMode"), false);
    }

    private static bool GetDesignMode()
    {
        var d = Thread.GetData(Thread.GetNamedDataSlot(@"isDesignMode"));
        if (d == null)
        {
            return true;
        }
        else
        {
            return d.ToString().ToLowerInvariant() != @"false";
        }
    }

    public static bool IsFontInstalled(string fontName)
    {
        // http://stackoverflow.com/questions/113989/test-if-a-font-is-installed

        using var testFont = new Font(fontName, 8);
        return 0 == string.Compare(
            fontName,
            testFont.Name,
            StringComparison.InvariantCultureIgnoreCase);
    }
}