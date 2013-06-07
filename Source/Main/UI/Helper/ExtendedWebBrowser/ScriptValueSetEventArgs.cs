namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Event argument.
	/// </summary>
	public class ScriptValueSetEventArgs :
		EventArgs
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Initializes a new instance of the <see cref="ScriptValueSetEventArgs"/> class.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		public ScriptValueSetEventArgs(
			string key,
			string value )
		{
			Key = key;
			Value = value;
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// Gets or sets the key.
		/// </summary>
		/// <value>The key.</value>
		public string Key
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		public string Value
		{
			get;
			private set;
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}