﻿namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomUserControl;

using DevExpress.XtraEditors;
using System.Linq;

[PublicAPI]
public class MyUserControl :
    XtraUserControl
{
    public new bool DesignMode => base.DesignMode || DesignModeHelper.IsDesignMode;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        // Do this even in design mode to have valid UI.
        Appearance.Font = SkinHelper.StandardFont;
    }

    /// <summary>
    /// Fill drop-downs and stuff like that.
    /// </summary>
    public virtual void InitiallyFillLists()
    {
        // Does nothing.
    }

    /// <summary>
    /// Read the item and put its values into the controls.
    /// </summary>
    public virtual void FillItemToControls()
    {
        // Does nothing.
    }

    /// <summary>
    /// Read the controls values and put its values into the item.
    /// </summary>
    public virtual void FillControlsToItem()
    {
        // Does nothing.
    }

    /// <summary>
    /// Recursively check whether a control or one of its
    /// childs is focused.
    /// </summary>
    /// <param name="c">The control to check.</param>
    /// <returns>Returns TRUE if focused, FALSE otherwise.</returns>
    public static bool IsFocused(
        Control? c)
    {
        if (c == null)
        {
            return false;
        }
        else if (c.Focused)
        {
            return true;
        }
        else
        {
            // Recurse.
            return c.Controls.Cast<Control>().Any(IsFocused);
        }
    }

    public static Control? GetFocused(
        Control? c)
    {
        if (c == null)
        {
            return null;
        }
        else if (c.Focused)
        {
            return c;
        }
        else
        {
            // Recurse.
            return c.Controls.Cast<Control>().Select(GetFocused).FirstOrDefault(cs => cs != null);
        }
    }

    /// <summary>
    /// Sets the focus either to the given control or, if unsuccessful,
    /// to a focusable child control.
    /// </summary>
    public static bool FocusControlOrDeeper(
        Control? c)
    {
        if (c == null)
        {
            return false;
        }
        else
        {
            if (c.Focused)
            {
                return true;
            }
            else
            {
                if (c.TabStop && c.Focus())
                {
                    return true;
                }
                else
                {
                    return c.Controls.Cast<Control>().Any(FocusControlOrDeeper);
                }
            }
        }
    }
}