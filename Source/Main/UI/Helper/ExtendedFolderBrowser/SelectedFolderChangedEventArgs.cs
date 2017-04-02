namespace ZetaResourceEditor.UI.Helper.ExtendedFolderBrowser
{
    using System;
    using System.ComponentModel;

    public class SelectedFolderChangedEventArgs :
		EventArgs
	{
	    public SelectedFolderChangedEventArgs(
			IntPtr itemIdentifierList,
			string folderPath )
		{
			EnableOK = true;
			ItemIdentifierList = itemIdentifierList;
			FolderPath = folderPath;
		}

		/// <summary>
		/// Gets the item identifier list.
		/// </summary>
		/// <value>The item identifier list.</value>
		public IntPtr ItemIdentifierList { get; }

	    /// <summary>
		/// Gets the folder path.
		/// </summary>
		/// <value>The folder path.</value>
		public string FolderPath { get; }

	    /// <summary>
		/// Gets or sets a value indicating whether [enable OK].
		/// </summary>
		/// <value><c>true</c> if [enable OK]; otherwise, <c>false</c>.</value>
		[DefaultValue( true )]
		public bool EnableOK { get; set; }
	}
}