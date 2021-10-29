namespace ExtendedControlsLibrary.Skinning.CustomGrid;

using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

public class MyGridView :
    GridView
{
    public MyGridView(GridControl grid) :
        base(grid)
    {
        init();
    }

    public MyGridView()
    {
        init();
    }

    protected override string ViewName => typeof (MyGridView).Name;

    // https://www.devexpress.com/Support/Center/Question/Details/KA18858
    protected override bool IsAllowPixelScrollingAutoRowHeight => true;

    //// https://www.devexpress.com/Support/Center/Question/Details/KA18858
    //protected override bool IsAllowPixelScrollingByDefault => true;

    // https://www.devexpress.com/Support/Center/Question/Details/KA18858
    //protected override bool IsAllowPixelScrollingPreview => true;

    private void init()
    {
        // GridView.Appearance.FocusedCell.Font

        Appearance.Row.Font = SkinHelper.StandardFont;
        Appearance.FocusedCell.Font = SkinHelper.StandardFont;
        Appearance.Empty.Font = SkinHelper.StandardFont;
        Appearance.EvenRow.Font = SkinHelper.StandardFont;
        Appearance.FocusedRow.Font = SkinHelper.StandardFont;
        Appearance.GroupPanel.Font = SkinHelper.StandardFont;
        Appearance.GroupRow.Font = SkinHelper.StandardFont;
        Appearance.OddRow.Font = SkinHelper.StandardFont;
        Appearance.SelectedRow.Font = SkinHelper.StandardFont;
        Appearance.HeaderPanel.Font = SkinHelper.StandardFont;

        OptionsBehavior.AllowPixelScrolling = DefaultBoolean.True;
        OptionsBehavior.AllowFixedGroups = DefaultBoolean.True;

        // --

        EmptyText = SkinningResources.EmptyGridNoItems;
    }

    [Localizable(true)]
    public string EmptyText { get; set; }

    protected override void RaiseCustomDrawEmptyForeground(CustomDrawEventArgs e)
    {
        base.RaiseCustomDrawEmptyForeground(e);

        // https://www.devexpress.com/Support/Center/Question/Details/A557
        if (!string.IsNullOrEmpty(EmptyText))
        {
            if (RowCount != 0) return;

            var drawFormat = new StringFormat();

            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(EmptyText, e.Appearance.Font, SystemBrushes.ControlDark,
                new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
        }
    }
}