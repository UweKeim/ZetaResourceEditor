namespace ZetaResourceEditor.UI.Main.RightContent
{
	using DevExpress.XtraGrid.Views.Grid;

	internal class GridViewHelper
	{
		private readonly GridView _gridView;

		public GridViewHelper(
			GridView gridView )
		{
			_gridView = gridView;
		}

		public GridView GridView
		{
			get
			{
				return _gridView;
			}
		}

		public void SelectCell(
			int rowHandle,
			int columnIndex )
		{
			/*
			_gridView.SelectCell(
				rowHandle,
				_gridView.Columns[columnIndex] );
			*/

			// Redirect since I am unable for now to select one cell.
			SelectRow( rowHandle );
		}

		public void FocusCell(
			int rowHandle,
			int columnIndex )
		{
			/*
			_gridView.SelectCell(
				rowHandle,
				_gridView.Columns[columnIndex] );
			*/

			// Redirect since I am unable for now to select one cell.
			FocusRow( rowHandle );
		}

		public void SelectRow(
			int rowHandle )
		{
			_gridView.SelectRow( rowHandle );
		}

		public void FocusRow(
			int rowHandle )
		{
			_gridView.FocusedRowHandle = rowHandle;
		}

		public object GetRowCellValue(
			int rowHandle,
			int columnIndex )
		{
			return _gridView.GetRowCellValue(
				rowHandle,
				_gridView.Columns[columnIndex] );
		}

		public T GetRowCellValue<T>(
			int rowHandle,
			int columnIndex )
		{
			return (T)_gridView.GetRowCellValue(
				rowHandle,
				_gridView.Columns[columnIndex] );
		}

		public void SetRowCellValue(
			int rowHandle,
			int columnIndex,
			object value )
		{
			_gridView.SetRowCellValue(
				rowHandle,
				_gridView.Columns[columnIndex],
				value );
		}
	}
}