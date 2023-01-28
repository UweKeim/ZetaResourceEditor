namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomTabControl;

using System.ComponentModel;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;

/// <summary>
/// A tab control that is not "visible" during runtime and only
/// serves as a way to allow for programmatical switching between 
/// multiple layered pages.
/// </summary>
public class MyHelperXtraTabControl :
    XtraTabControl
{
    public MyHelperXtraTabControl()
    {
        DisallowKeyboardTabChange = true;
    }

    [DefaultValue(true)]
    public bool DisallowKeyboardTabChange { get; set; }

    private static void makeTabControlInvisible(
        XtraTabControl tabControl)
    {
        tabControl.SelectedTabPageIndex = 0;
        tabControl.ShowTabHeader = DefaultBoolean.False;

        // 2011-04-12, Uwe Keim: No border around the group boxes.
        tabControl.BorderStyle = BorderStyles.NoBorder;
        tabControl.BorderStylePage = BorderStyles.NoBorder;
        tabControl.LookAndFeel.Style = LookAndFeelStyle.Flat;
        tabControl.LookAndFeel.UseDefaultLookAndFeel = false;

        tabControl.Padding = new(9);
        tabControl.Margin = new(9);

        foreach (XtraTabPage page in tabControl.TabPages)
        {
            page.Padding = new(0);
            page.Margin = new(0);
        }
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        if (DisallowKeyboardTabChange && e is { Control: true, KeyCode: Keys.Tab })
        {
            e.SuppressKeyPress = true;
        }

        base.OnKeyDown(e);

        if (DisallowKeyboardTabChange && e is { Control: true, KeyCode: Keys.Tab })
        {
            e.SuppressKeyPress = true;
        }
    }

    protected override XtraTabPageCollection CreateTabCollection()
    {
        // http://www.devexpress.com/Support/Center/p/S130636.aspx
        // http://www.devexpress.com/Support/Center/p/CQ23743.aspx

        return new MyHelperXtraTabPageCollection(this);
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        makeTabControlInvisible(this);
    }

    #region Hide several properties from designer.

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override DefaultBoolean ShowTabHeader { get => base.ShowTabHeader;
        set => base.ShowTabHeader = value;
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override BorderStyles BorderStyle { get => base.BorderStyle;
        set => base.BorderStyle = value;
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override BorderStyles BorderStylePage { get => base.BorderStylePage;
        set => base.BorderStylePage = value;
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override UserLookAndFeel LookAndFeel => base.LookAndFeel;

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Padding Padding { get => base.Padding;
        set => base.Padding = value;
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Padding Margin { get => base.Margin;
        set => base.Margin = value;
    }

    #endregion
}