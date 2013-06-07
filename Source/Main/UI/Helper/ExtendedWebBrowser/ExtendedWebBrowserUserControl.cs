namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	using System.ComponentModel;
	using System.Diagnostics;
	using Base;

	public partial class ExtendedWebBrowserUserControl : 
		UserControlBase
	{
		public ExtendedWebBrowserUserControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Gets the web browser.
		/// </summary>
		/// <value>The web browser.</value>
		[Browsable( false )]
		[EditorBrowsable( EditorBrowsableState.Never )]
		[DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public ExtendedWebBrowserControl WebBrowser
		{
			get
			{
				Debug.Assert( true, @"No auto property." );
				return webBrowser;
			}
		}
	}
}