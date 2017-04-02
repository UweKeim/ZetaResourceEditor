namespace Web.Code
{
    using System.ComponentModel;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    [
		DefaultProperty( @"Text" ),
		ToolboxData( @"<{0}:PartialHyperLink runat=""server""> </{0}:PartialHyperLink>" )
	]
	public class PartialHyperLink :
		WebControl
	{
		[
			Bindable( true ),
			DefaultValue( @"" ),
			UrlProperty,
			Localizable( true ),
		]
		public string NavigateUrl
		{
			get
			{
				var str = (string)ViewState[@"NavigateUrl"];
				if ( str == null )
				{
					return string.Empty;
				}
				else
				{
					return str;
				}
			}
			set => ViewState[@"NavigateUrl"] = value;
		}

		[
			Bindable( true ),
			DefaultValue( @"" ),
			Localizable( true )
		]
		public string Text
		{
			get
			{
				var str = (string)ViewState[@"Text"];
				if ( str == null )
				{
					return string.Empty;
				}
				else
				{
					return str;
				}
			}
			set => ViewState[@"Text"] = value;
		}

		[
			Bindable( true ),
			DefaultValue( @"" ),
			UrlProperty
		]
		public virtual string ImageUrl
		{
			get
			{
				var str = (string)ViewState[@"ImageUrl"];
				if ( str != null )
				{
					return str;
				}
				else
				{
					return string.Empty;
				}
			}
			set => ViewState[@"ImageUrl"] = value;
		}

		[
			Bindable( true ),
			DefaultValue( @"" ),
		]
		public string Target
		{
			get
			{
				var str = (string)ViewState[@"Target"];
				if ( str != null )
				{
					return str;
				}
				else
				{
					return string.Empty;
				}
			}
			set => ViewState[@"Target"] = value;
		}

		protected override void RenderContents( HtmlTextWriter writer )
		{
			var text = Text;
			if ( !string.IsNullOrEmpty( text ) )
			{
				const string startToken = @"{0}";
				const string endToken = @"{1}";

				string beforeText;
				string hyperlinkText;
				string afterText;

				if ( text.Contains( startToken ) && text.Contains( endToken ) )
				{
					beforeText = text.Substring( 0, text.IndexOf( startToken ) );
					hyperlinkText = text.Substring(
						text.IndexOf( startToken ) + startToken.Length,
						text.IndexOf( endToken ) - (text.IndexOf( startToken ) + startToken.Length) );
					afterText = text.Substring( text.IndexOf( endToken ) + endToken.Length );
				}
				else if ( text.Contains( startToken ) )
				{
					beforeText = text.Substring( 0, text.IndexOf( startToken ) );
					hyperlinkText = text.Substring( text.IndexOf( startToken ) + startToken.Length );
					afterText = null;
				}
				else if ( text.Contains( endToken ) )
				{
					beforeText = null;
					hyperlinkText = text.Substring( 0, text.IndexOf( endToken ) );
					afterText = text.Substring( text.IndexOf( endToken ) + endToken.Length );
				}
				else
				{
					beforeText = text;
					hyperlinkText = null;
					afterText = null;
				}

				// --

				if ( !string.IsNullOrEmpty( beforeText ) )
				{
					writer.WriteEncodedText( beforeText );
				}

				if ( !string.IsNullOrEmpty( hyperlinkText ) )
				{
					var hyperLink =
						new HyperLink
							{
								Text = hyperlinkText,
								NavigateUrl = NavigateUrl,
								Target = Target,
								ToolTip = ToolTip,
								CssClass = CssClass,
								ImageUrl = ImageUrl,
								SkinID = SkinID
							};

					hyperLink.RenderControl( writer );
				}

				if ( !string.IsNullOrEmpty( afterText ) )
				{
					writer.WriteEncodedText( afterText );
				}
			}
		}
	}
}