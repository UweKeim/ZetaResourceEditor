namespace ZetaResourceEditor.ExtendedControlsLibrary.General;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using Skinning.CustomListBox;

// http://www.devexpress.com/Support/Center/e/E1079.aspx

public class ListBoxWithoutFocusRectangle :
    MyListBoxControl
{
    protected override BaseStyleControlViewInfo CreateViewInfo() { return new ListBoxWithoutFocusRectangleViewInfo(this); }

    public void ClearSelection()
    {
        // http://www.devexpress.com/Support/Center/p/CQ65915.aspx

        var oldSelectionMode = SelectionMode;
        SelectionMode = SelectionMode.None;
        SelectionMode = oldSelectionMode;
        Refresh();
    }
}

public class ListBoxWithoutFocusRectangleItemPainter :
    ListBoxItemPainter
{
    protected override void DrawItemBar(ListBoxItemObjectInfoArgs e)
    {
        e.PaintAppearance.FillRectangle(e.Cache, e.Bounds);
    }
}

public class ListBoxWithoutFocusRectangleViewInfo :
    BaseListBoxViewInfo
{
    public ListBoxWithoutFocusRectangleViewInfo(BaseListBoxControl owner) : base(owner) { }

    protected override BaseListBoxItemPainter CreateItemPainter()
    {
        if (IsSkinnedHighlightingEnabled) return new ListBoxWithoutFocusRectangleSkinItemPainter();
        return new ListBoxWithoutFocusRectangleItemPainter();
    }
}

public class ListBoxWithoutFocusRectangleSkinItemPainter :
    ListBoxSkinItemPainter
{
    protected override void DrawItemBar(ListBoxItemObjectInfoArgs e) { DrawItemBarCore(e); }
}