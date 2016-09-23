namespace ZetaResourceEditor.UI.Helper
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Windows.Forms;
	using Zeta.VoyagerLibrary.WinForms.Common;

    // ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Calls BeginUpdate/EndUpdate.
	/// </summary>
	public sealed class TemporaryRedrawPauser :
		IDisposable
	{
		#region Public constructor.
		// ------------------------------------------------------------------

		/// <summary>
		/// Initializes a new instance of the <see cref="TemporaryRedrawPauser"/> class.
		/// </summary>
		/// <param name="o">The o.</param>
		public TemporaryRedrawPauser(
			TreeView o )
			:
			this( o, true )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TemporaryRedrawPauser"/> class.
		/// </summary>
		/// <param name="o">The o.</param>
		public TemporaryRedrawPauser(
			ListView o )
			:
			this( o, true )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TemporaryRedrawPauser"/> class.
		/// </summary>
		/// <param name="o">The o.</param>
		public TemporaryRedrawPauser(
			ListBox o )
			:
			this( o, true )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TemporaryRedrawPauser"/> class.
		/// </summary>
		/// <param name="o">The o.</param>
		public TemporaryRedrawPauser(
			ComboBox o )
			:
			this( o, true )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TemporaryRedrawPauser"/> class.
		/// </summary>
		/// <param name="o">The o.</param>
		/// <param name="useWaitCursor">if set to <c>true</c> [use wait cursor].</param>
		public TemporaryRedrawPauser(
			TreeView o,
			bool useWaitCursor )
		{
			_o1 = o;
			o.BeginUpdate();

			enableWaitCursor( useWaitCursor, o );
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TemporaryRedrawPauser"/> class.
		/// </summary>
		/// <param name="o">The o.</param>
		/// <param name="useWaitCursor">if set to <c>true</c> [use wait cursor].</param>
		public TemporaryRedrawPauser(
			ListView o,
			bool useWaitCursor )
		{
			_o2 = o;
			o.BeginUpdate();

			enableWaitCursor( useWaitCursor, o );
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TemporaryRedrawPauser"/> class.
		/// </summary>
		/// <param name="o">The o.</param>
		/// <param name="useWaitCursor">if set to <c>true</c> [use wait cursor].</param>
		public TemporaryRedrawPauser(
			ListBox o,
			bool useWaitCursor )
		{
			_o3 = o;
			o.BeginUpdate();

			enableWaitCursor( useWaitCursor, o );
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TemporaryRedrawPauser"/> class.
		/// </summary>
		/// <param name="o">The o.</param>
		/// <param name="useWaitCursor">if set to <c>true</c> [use wait cursor].</param>
		public TemporaryRedrawPauser(
			ComboBox o,
			bool useWaitCursor )
		{
			_o4 = o;
			o.BeginUpdate();

			enableWaitCursor( useWaitCursor, o );
		}

		// ------------------------------------------------------------------
		#endregion

		#region IDisposable members.
		// ------------------------------------------------------------------

		/// <summary>
		/// Performs application-defined tasks associated with freeing, 
		/// releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			if ( _o1 != null )
			{
				_o1.EndUpdate();
				_o1 = null;
			}
			if ( _o2 != null )
			{
				_o2.EndUpdate();
				_o2 = null;
			}
			if ( _o3 != null )
			{
				_o3.EndUpdate();
				_o3 = null;
			}
			if ( _o4 != null )
			{
				_o4.EndUpdate();
				_o4 = null;
			}

			// --

			if ( _wait != null )
			{
				_wait.Dispose();
				_wait = null;
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Enables the wait cursor.
		/// </summary>
		/// <param name="useWaitCursor">if set to <c>true</c> [use wait cursor].</param>
		/// <param name="owner">The owner.</param>
		private void enableWaitCursor(
			bool useWaitCursor,
			Control owner )
		{
			if ( useWaitCursor )
			{
				_wait = new WaitCursor( owner );
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private variables.
		// ------------------------------------------------------------------

		private TreeView _o1;
		private ListView _o2;
		private ListBox _o3;
		private ComboBox _o4;

		private WaitCursor _wait;

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}