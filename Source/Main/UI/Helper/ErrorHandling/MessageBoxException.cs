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

		private readonly IWin32Window _parent;
		private readonly string _message;
		private readonly MessageBoxIcon _icon;

		// ------------------------------------------------------------------
		#endregion
	
		public MessageBoxException(
			IWin32Window parent,
			string message,
			MessageBoxIcon icon )
		{
			_parent = parent;
			_message = message;
			_icon = icon;
		}

		/// <summary>
		/// Gets the parent.
		/// </summary>
		/// <value>The parent.</value>
		public IWin32Window Parent
		{
			get
			{
				return _parent;
			}
		}

		/// <summary>
		/// Gets a message that describes the current exception.
		/// </summary>
		/// <value></value>
		/// <returns>The error message that explains the reason for the 
		/// exception, or an empty string("").</returns>
		public override string Message
		{
			get
			{
				return _message;
			}
		}

		/// <summary>
		/// Gets the icon.
		/// </summary>
		/// <value>The icon.</value>
		public MessageBoxIcon Icon
		{
			get
			{
				return _icon;
			}
		}

		/// <summary>
		/// Gets the buttons.
		/// </summary>
		/// <value>The buttons.</value>
		public MessageBoxButtons Buttons
		{
			get
			{
				return MessageBoxButtons.OK;
			}
		}
	}
}