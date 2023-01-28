namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomGrid;

using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Handler;

public class MyGridHandler :
    GridHandler
{
    public MyGridHandler(GridView gridView) : 
        base(gridView)
    {
    }
}