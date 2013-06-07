namespace ZetaResourceEditor.UI.Helper.ExtendedWebBrowser
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Web;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Event arguments, used in conjunction with the HTML control.
	/// </summary>
	public class AppCommandEventArgs :
		EventArgs
	{
		#region Public methods.
		// ------------------------------------------------------------------

		public static AppCommandEventArgs Create( 
			string command,
			params string[] parameters )
		{
			return new AppCommandEventArgs(
				new Uri(
					string.Format(
						@"app:{0}?{1}",
						command,
						string.Join( @"&", parameters ) ) ) );
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AppCommandEventArgs"/> 
		/// class.
		/// </summary>
		/// <param name="url">The URL.</param>
		public AppCommandEventArgs(
			Uri url )
		{
			Url = url;

			CommandName = url.LocalPath;
			CommandParameters = new Dictionary<string,string>();

			var query = url.Query.Trim( '?', '&' );
			var pairs = query.Split( '&' );

			foreach ( var pair in pairs )
			{
				if ( !string.IsNullOrEmpty( pair ) )
				{
					if ( pair.Contains( @"=" ) )
					{
						var ab = pair.Split(
							new[] { '=' },
							StringSplitOptions.RemoveEmptyEntries );

						if ( ab.Length == 2 )
						{
							CommandParameters[ab[0]] =
								HttpUtility.UrlDecode( ab[1] );
						}
						else
						{
							Debug.Assert(
								ab.Length >= 1,
								string.Format(
								@"Unexpected length of '{0}' for splitted parameter.",
								ab.Length ) );
							CommandParameters[ab[0]] =
								HttpUtility.UrlDecode( ab[0] );
						}
					}
					else
					{
						CommandParameters[pair] =
							HttpUtility.UrlDecode( pair );
					}
				}
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// The command that was called.
		/// </summary>
		public string CommandName
		{
			get;
			private set;
		}

		/// <summary>
		/// The (optional) parameters to the command
		/// that was called.
		/// </summary>
		public Dictionary<string, string> CommandParameters
		{
			get;
			private set;
		}

		/// <summary>
		/// The raw URL that was called.
		/// </summary>
		public Uri Url
		{
			get;
			private set;
		}

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}