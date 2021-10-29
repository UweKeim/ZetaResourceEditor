namespace ExtendedControlsLibrary.Skinning.CustomForm;

using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

public class MyXtraForm :
    XtraForm
{
    private BarManager _menuBarManager;
    public new bool DesignMode => base.DesignMode || DesignModeHelper.IsDesignMode;

    // Skin für Kontext-Menüs.
    // Wird in der Hauptanwendung zentral vom Main-Form gesetzt.
    // https://www.devexpress.com/Support/Center/Question/Details/B220846
    //public static IDXMenuManager GlobalSharedMenuManager { get; set; }

    public IDXMenuManager GetMenuBarManager()
    {
        return _menuBarManager ??= findManager();
    }

    private BarManager findManager()
    {
        var t = GetType();

        // http://stackoverflow.com/a/520413/107625
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (var pi in t.GetFields(BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic))
        {
            if (typeof(BarManager).IsAssignableFrom(pi.FieldType))
            {
                return (BarManager)pi.GetValue(this);
            }
        }

        return null;
    }

    public static IDXMenuManager CheckGetMenuBarManager(Control c)
    {
        if (c == null || c.IsDisposed) return null;

        return !(c.FindForm() is MyXtraForm form) || form.IsDisposed ? null : form.GetMenuBarManager();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public new AutoScaleMode AutoScaleMode
    {
        get => AutoScaleMode.None;
        // ReSharper disable ValueParameterNotUsed
        set => base.AutoScaleMode = AutoScaleMode.None;
        // ReSharper restore ValueParameterNotUsed
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        // Do this even in design mode to have valid UI.
        AutoScaleMode = AutoScaleMode.None;
        Appearance.Font = SkinHelper.StandardFont;
    }

    public event EventHandler<WantProcessDialogKeyEventArgs> WantProcessDialogKey;

    protected override bool ProcessDialogKey(Keys keyData)
    {
        var h = WantProcessDialogKey;
        if (h != null)
        {
            var args = new WantProcessDialogKeyEventArgs(keyData);
            h(this, args);

            if (args.Result.HasValue)
            {
                return args.Result.Value;
            }
        }

        return base.ProcessDialogKey(keyData);
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

    protected static int FindListControlIndex(
        ComboBoxEdit listControl,
        Predicate<object> finder)
    {
        var index = 0;
        foreach (var o in listControl.Properties.Items)
        {
            if (finder(o))
            {
                return index;
            }

            index++;
        }

        return -1;
    }
}