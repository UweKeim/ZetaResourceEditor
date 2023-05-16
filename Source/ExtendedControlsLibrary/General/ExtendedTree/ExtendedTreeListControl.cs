namespace ZetaResourceEditor.ExtendedControlsLibrary.General.ExtendedTree;

using System.ComponentModel;
using DevExpress.XtraTreeList;
using Skinning;

public class ExtendedTreeListControl :
    TreeList
{
    public ExtendedTreeListControl()
    {
        EmptyText = SkinningResources.EmptyGridNoItems;
    }

    [Localizable(true)]
    public string EmptyText { get; set; }

    protected override void RaiseCustomDrawEmptyArea(CustomDrawEmptyAreaEventArgs e)
    {
        base.RaiseCustomDrawEmptyArea(e);

        if (!string.IsNullOrEmpty(EmptyText))
        {
            if (VisibleNodesCount > 0) return;

            // http://www.devexpress.com/Support/Center/Question/Details/Q496805

            e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
            e.Graphics.DrawString(EmptyText, Font, SystemBrushes.ControlDark,
                new PointF(e.Bounds.Width/2 - 40, e.Bounds.Height/2.0f));

            e.Handled = true;
        }
    }
}