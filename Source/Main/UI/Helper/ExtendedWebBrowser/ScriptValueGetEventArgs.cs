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
	public class ScriptValueGetEventArgs :
		EventArgs
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		///
		/// </summary>
		public ScriptValueGetEventArgs(
			string key )
		{
			Key = key;
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// 
		/// </summary>
		public string Key
		{
			get;
			private set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string Value
		{
			get;
			set;
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}