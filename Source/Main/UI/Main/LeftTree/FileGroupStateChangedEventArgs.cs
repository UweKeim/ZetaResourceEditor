namespace ZetaResourceEditor.UI.Main.LeftTree
{
	using System;
	using RuntimeBusinessLogic.DL;

	public class FileGroupStateChangedEventArgs :
		EventArgs
	{
		private readonly IGridEditableData _gridEditableData;

		public FileGroupStateChangedEventArgs(
			IGridEditableData gridEditableData)
		{
			_gridEditableData = gridEditableData;
		}

		public IGridEditableData GridEditableData
		{
			get
			{
				return _gridEditableData;
			}
		}
	}
}