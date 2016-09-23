namespace ZetaResourceEditor.UI.Helper.ExtendedFolderBrowser
{
    using System;
    using System.ComponentModel;

    public class SelectedFolderChangedEventArgs :
		EventArgs
	{
		private readonly IntPtr _itemIdentifierList;
		private readonly string _folderPath;

		public SelectedFolderChangedEventArgs(
			IntPtr itemIdentifierList,
			string folderPath )
		{
			EnableOK = true;
			_itemIdentifierList = itemIdentifierList;
			_folderPath = folderPath;
		}

		/// <summary>
		/// Gets the item identifier list.
		/// </summary>
		/// <value>The item identifier list.</value>
		public IntPtr ItemIdentifierList
		{
			get
			{
				return _itemIdentifierList;
			}
		}

		/// <summary>
		/// Gets the folder path.
		/// </summary>
		/// <value>The folder path.</value>
		public string FolderPath
		{
			get
			{
				return _folderPath;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [enable OK].
		/// </summary>
		/// <value><c>true</c> if [enable OK]; otherwise, <c>false</c>.</value>
		[DefaultValue( true )]
		public bool EnableOK { get; set; }
	}
}