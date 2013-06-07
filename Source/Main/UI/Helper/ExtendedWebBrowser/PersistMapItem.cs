namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	#region Using directives.
	// ----------------------------------------------------------------------
	using ZetaLongPaths;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Helper class.
	/// </summary>
	internal class PersistMapItem
	{
		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// Gets or sets the temporary file path.
		/// </summary>
		/// <value>The temporary file path.</value>
		public ZlpFileInfo TemporaryFilePath
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance has persisted.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance has persisted; otherwise, <c>false</c>.
		/// </value>
		public bool HasPersisted
		{
			get;
			set;
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}