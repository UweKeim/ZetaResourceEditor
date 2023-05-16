namespace ZetaResourceEditor.UI.Helper.Base;

using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;
using Main;
using System.IO;
using ExtendedControlsLibrary.General.Base;

public partial class FormBase :
    DevExpressXtraFormBase
{
    public FormBase()
    {
        InitializeComponent();
    }

    protected virtual bool WantSetGlobalIcon => true;

    protected override void OnLoad(EventArgs e)
    {
        if (!DesignMode || !Zeta.VoyagerLibrary.Core.WinForms.Base.UserControlBase.IsDesignMode(this))
        {
            if (MainForm.Current != null && WantSetGlobalIcon)
            {
                // Share an icon to make the file size smaller.
                Icon = MainForm.Current.Icon;
                /*ShowIcon = true;*/
            }
        }

        base.OnLoad(e);
    }

    public FormBase( IContainer container )
    {
        container.Add( this );

        InitializeComponent();
    }

    public virtual void UpdateUI()
    {
    }

    public void PersistState()
    {
        WinFormsPersistanceHelper.SaveState( this );
    }

    /// <summary>
    /// Restores the state.
    /// </summary>
    /// <returns>Returns TRUE if changed, FALSE otherwise.</returns>
    public bool RestoreState()
    {
        var bounds = Bounds;
        var state = WindowState;

        WinFormsPersistanceHelper.RestoreState( this );

        return bounds != Bounds || state != WindowState;
    }

    /// <summary>
    /// Restores the state.
    /// </summary>
    /// <returns>Returns TRUE if changed, FALSE otherwise.</returns>
    public bool RestoreState( int zoom )
    {
        var bounds = Bounds;
        var state = WindowState;

        WinFormsPersistanceHelper.RestoreState(
            this,
            new()
            {
                SuggestZoomPercent = zoom,
                //RespectWindowRatio = false
            } );

        return bounds != Bounds || state != WindowState;
    }

    public static void SaveState(
        XtraTabControl tabControl )
    {
        PersistanceHelper.SaveValue( tabControl + @".Index", tabControl.SelectedTabPageIndex );
    }

    public static void RestoreState(
        XtraTabControl tabControl )
    {
        var index =
            ConvertHelper.ToInt32(
                PersistanceHelper.RestoreValue( tabControl + @".Index", tabControl.SelectedTabPageIndex ),
                tabControl.SelectedTabPageIndex );

        if ( index < tabControl.TabPages.Count )
        {
            tabControl.SelectedTabPageIndex = index;
        }
    }

    public static void RestoreState(RibbonControl ribbon)
    {
        var s = ConvertHelper.ToString(PersistanceHelper.RestoreValue(ribbon.Name+@".Toolbar"));

        if (!string.IsNullOrEmpty(s))
        {
            using var ms =
                new MemoryStream(Encoding.UTF8.GetBytes(s));
            ribbon.Toolbar.RestoreLayoutFromStream(ms);
        }
    }

    public static void SaveState(RibbonControl ribbon)
    {
        using var ms = new MemoryStream();
        ribbon.Toolbar.SaveLayoutToStream(ms);
        ms.Seek(0, SeekOrigin.Begin);

        string s;
        using (var sr = new StreamReader(ms, Encoding.UTF8))
        {
            s = sr.ReadToEnd();
        }

        PersistanceHelper.SaveValue(ribbon.Name + @".Toolbar", s);
    }
}