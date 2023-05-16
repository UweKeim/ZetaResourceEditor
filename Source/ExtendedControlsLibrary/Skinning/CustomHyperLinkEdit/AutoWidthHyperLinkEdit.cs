namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomHyperLinkEdit;

using CustomForm;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

public class AutoWidthHyperLinkEdit :
    HyperLinkEdit
{
    private bool _allowAutoWidth = true;

    // http://community.devexpress.com/forums/p/79100/270662.aspx

    public AutoWidthHyperLinkEdit()
    {
        base.BackColor = Color.Transparent;
        base.BorderStyle = BorderStyles.NoBorder;
        CausesValidation = false;

        Properties.BorderStyle = BorderStyles.NoBorder;
        Properties.ReadOnly = true;
        Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        Properties.AllowFocused = false;
    }

    protected override void OnLoaded()
    {
        base.OnLoaded();

        if (!DesignModeHelper.IsDesignMode)
        {
            MenuManager = MyXtraForm.CheckGetMenuBarManager(this);
        }
    }

    public bool AllowAutoWidth
    {
        get => _allowAutoWidth;
        set { _allowAutoWidth = value; if (value) { Width = GetWidth(); } }
    }

    protected override void OnEditValueChanged()
    {
        base.OnEditValueChanged();

        if (AllowAutoWidth)
        {
            Width = GetWidth();
        }
    }

    private int GetWidth()
    {
	    using var gr = Graphics.FromImage(new Bitmap(10, 10));
	    using var gc = new GraphicsCache(gr);

		var s = ViewInfo.PaintAppearance.CalcTextSize(
            gc,
            ViewInfo.DisplayText,
            1000);

        return s.ToSize().Width + 8;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);

        // http://www.devexpress.com/Support/Center/p/Q255025.aspx
        Font = new(Font, Font.Style | FontStyle.Underline);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);

        // http://www.devexpress.com/Support/Center/p/Q255025.aspx
        Properties.Appearance.Font = new(Properties.Appearance.Font, Properties.Appearance.Font.Style & ~FontStyle.Underline);
        Properties.Appearance.Options.UseFont = true;
    }
}