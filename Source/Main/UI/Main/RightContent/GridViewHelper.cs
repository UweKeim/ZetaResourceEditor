namespace ZetaResourceEditor.UI.Main.RightContent;

using DevExpress.XtraGrid.Views.Grid;

internal class GridViewHelper
{
    public GridViewHelper(
        GridView gridView)
    {
        GridView = gridView;
    }

    private GridView GridView { get; }

    public void SelectCell(
        int rowHandle)
    {
        /*
        _gridView.SelectCell(
            rowHandle,
            _gridView.Columns[columnIndex] );
        */

        // Redirect since I am unable for now to select one cell.
        SelectRow(rowHandle);
    }

    public void FocusCell(
        int rowHandle)
    {
        /*
        _gridView.SelectCell(
            rowHandle,
            _gridView.Columns[columnIndex] );
        */

        // Redirect since I am unable for now to select one cell.
        FocusRow(rowHandle);
    }

    public void SelectRow(
        int rowHandle)
    {
        GridView.SelectRow(rowHandle);
    }

    private void FocusRow(
        int rowHandle)
    {
        GridView.FocusedRowHandle = rowHandle;
    }

    public object GetRowCellValue(
        int rowHandle,
        int columnIndex)
    {
        return GridView.GetRowCellValue(
            rowHandle,
            GridView.Columns[columnIndex]);
    }

    public T GetRowCellValue<T>(
        int rowHandle,
        int columnIndex)
    {
        return (T)GridView.GetRowCellValue(
            rowHandle,
            GridView.Columns[columnIndex]);
    }

    public void SetRowCellValue(
        int rowHandle,
        int columnIndex,
        object value)
    {
        GridView.SetRowCellValue(
            rowHandle,
            GridView.Columns[columnIndex],
            value);
    }
}