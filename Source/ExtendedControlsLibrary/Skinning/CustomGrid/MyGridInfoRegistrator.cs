namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomGrid;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

public class MyGridInfoRegistrator :
    GridInfoRegistrator
{
    public override string ViewName => nameof(MyGridView);

    public override BaseView CreateView(GridControl grid)
    {
        return new MyGridView(grid);
    }

    public override BaseViewInfo CreateViewInfo(BaseView view)
    {
        return new MyGridViewInfo((GridView) view);
    }

    public override BaseViewHandler CreateHandler(BaseView view)
    {
        return new MyGridHandler((GridView) view);
    }
}