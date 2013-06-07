namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	using System;
	using ZetaLongPaths;

	/// <summary>
	/// Argument class when persisting temporary files from the image
	/// editor. Usually this are image files that are passed via the
	/// clipboard into the HTML editor.
	/// </summary>
	public class HtmlEditControlNotifySinkPersistTemporaryFileArgs :
		EventArgs
	{
		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// [IN]. The current temporary file path.
		/// </summary>
		/// <value>The temporary file path.</value>
		public ZlpFileInfo TemporaryFilePath
		{
			get;
			set;
		}

		/// <summary>
		/// [OUT]. Tells the caller the file path where the file is stored.
		/// </summary>
		/// <value>The persistent file path.</value>
		public ZlpFileInfo PersistentFilePath
		{
			get;
			set;
		}

		// ------------------------------------------------------------------
		#endregion
	}
}