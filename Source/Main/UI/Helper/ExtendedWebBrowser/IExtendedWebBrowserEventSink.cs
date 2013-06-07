namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System.Windows.Forms;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// External interface for receiving notifications.
	/// </summary>
	public interface IExtendedWebBrowserEventSink
	{
		#region Interface members.
		// ------------------------------------------------------------------

		/// <summary>
		/// Called before navigating.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.WebBrowserNavigatingEventArgs"/>
		/// instance containing the event data.</param>
		/// <returns></returns>
		EventHandled OnNavigating(
			ExtendedWebBrowserControl sender,
			WebBrowserNavigatingEventArgs e );

		/// <summary>
		/// Called when some ui elements need to be updated.
		/// </summary>
		/// <param name="source">The source.</param>
		void OnUpdateUI(
			ExtendedWebBrowserControl source );

		/// <summary>
		/// Called when the document is completely loaded,
		/// either from a string or streamed in.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="count">The count.</param>
		void OnDocumentComplete(
			ExtendedWebBrowserControl source,
			int count );

		/// <summary>
		/// Called when the document first is available.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="count">The count.</param>
		void OnNavigateComplete(
			ExtendedWebBrowserControl source,
			int count );

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}