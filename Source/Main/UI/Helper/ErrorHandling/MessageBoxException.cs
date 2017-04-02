namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
	#region Using directives.
	// ----------------------------------------------------------------------
	using System;
	using System.Windows.Forms;

	// ----------------------------------------------------------------------
	#endregion
	
	/// <summary>
	/// 
	/// </summary>
	public class MessageBoxException :
		Exception
	{
		#region Private variables.
		// ------------------------------------------------------------------

	    // ------------------------------------------------------------------
		#endregion
	
		public MessageBoxException(
			IWin32Window parent,
			string message,
			MessageBoxIcon icon )
		{
			Parent = parent;
			Message = message;
			Icon = icon;
		}

		/// <summary>
		/// Gets the parent.
		/// </summary>
		/// <value>The parent.</value>
		public IWin32Window Parent { get; }

	    /// <summary>
		/// Gets a message that describes the current exception.
		/// </summary>
		/// <value></value>
		/// <returns>The error message that explains the reason for the 
		/// exception, or an empty string("").</returns>
		public override string Message { get; }

	    /// <summary>
		/// Gets the icon.
		/// </summary>
		/// <value>The icon.</value>
		public MessageBoxIcon Icon { get; }

	    /// <summary>
		/// Gets the buttons.
		/// </summary>
		/// <value>The buttons.</value>
		public MessageBoxButtons Buttons => MessageBoxButtons.OK;
	}
}