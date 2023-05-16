namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomForm;

using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Reflection;

public class MyXtraForm :
    XtraForm
{
    private BarManager? _menuBarManager;
    protected new bool DesignMode => base.DesignMode || DesignModeHelper.IsDesignMode;

    // Skin für Kontext-Menüs.
    // Wird in der Hauptanwendung zentral vom Main-Form gesetzt.
    // https://www.devexpress.com/Support/Center/Question/Details/B220846
    //public static IDXMenuManager GlobalSharedMenuManager { get; set; }

    public IDXMenuManager? GetMenuBarManager()
    {
        return _menuBarManager ??= findManager();
    }

    private BarManager? findManager()
    {
        var t = GetType();

        // http://stackoverflow.com/a/520413/107625
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (var pi in t.GetFields(BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic))
        {
            if (typeof(BarManager).IsAssignableFrom(pi.FieldType))
            {
                return pi.GetValue(this) as BarManager;
            }
        }

        return null;
    }

    public static IDXMenuManager? CheckGetMenuBarManager(Control? c)
    {
        if (c == null || c.IsDisposed) return null;

        return c.FindForm() is not MyXtraForm form || form.IsDisposed ? null : form.GetMenuBarManager();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        // Do this even in design mode to have valid UI.
        Appearance.Font = SkinHelper.StandardFont;
    }

    protected virtual void InitiallyFillLists()
    {
        // Does nothing.
    }

    protected virtual void FillItemToControls()
    {
        // Does nothing.
    }

    protected virtual void FillControlsToItem()
    {
        // Does nothing.
    }
}