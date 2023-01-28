namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomGrid;

using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

public class MyGridViewInfo :
    GridViewInfo
{
    public MyGridViewInfo(GridView gridView) : base(gridView)
    {
    }

    //public override int CalcRowHeight(
    //    Graphics graphics, int rowHandle, int min, int level, bool useCache, GridColumnsInfo columns)
    //{
    //    var h = base.CalcRowHeight(graphics, rowHandle, min, level, useCache, columns);
    //    return Math.Max(1, Math.Min(h, View.RowHeight));
    //}

    //protected override int CalcMinColumnRowHeight(int headerHeight)
    //{
    //    var h= base.CalcMinColumnRowHeight(headerHeight);
    //    return Math.Max(1, Math.Min(h, headerHeight));
    //}
}