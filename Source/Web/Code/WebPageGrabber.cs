using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using Zeta.VoyagerLibrary.Common;
using Zeta.VoyagerLibrary.Logging;

namespace Web.Code
{
    using Zeta.VoyagerLibrary.Tools;

    /// <summary>
    /// Grabs a web page, makes all links absolute to the base URI and splits
    /// the grabbed HTML at the placeholder.
    /// </summary>
    public class WebPageGrabber :
        IDisposable
    {
        #region Public routines.
        // ------------------------------------------------------------------

        /// <summary>
        /// The main function for fetching.
        /// If successful, the properties <see cref="HtmlBefore"/> and <see cref="HtmlAfter"/>
        /// are filled with values.
        /// </summary>
        /// <param name="placeholder">The placeholder to search for. E.g. "##guestbook##".</param>
        /// <param name="fetchFromUrl">The fetch URL to download from.</param>
        /// <param name="baseUrl">The base URL to prefix all relative links with.</param>
        /// <param name="header">Optional. An additional header to add.</param>
        /// <param name="cacheDuration">How long a grabbed page is valid.</param>
        public void FetchContent(
            string placeholder,
            string fetchFromUrl,
            string baseUrl,
            string header,
            TimeSpan cacheDuration )
        {
            _internalHtmlBefore = null;
            _internalHtmlAfter = null;

            // --

            var cache = new Cache(
                fetchFromUrl,
                cacheDuration );

            string html;
            if ( cache.IsUpToDateCachedVersionAvailable )
            {
                html = cache.CachedContent;
            }
            else
            {
                try
                {
                    html = readRemoteHtmlDocument( fetchFromUrl );
                }
                catch ( Exception x )
                {
                    if ( cache.IsCachedVersionAvailable )
                    {
                        // Report error but continue anyway.
                        LogCentral.Current.LogError( string.Format(
                            @"Error during document retrieval from URL '{0}'.",
                            fetchFromUrl ),
                            x );

                        html = cache.CachedContent;
                    }
                    else
                    {
                        throw;
                    }
                }

                cache.CachedContent = html;
            }
            XmlReader xml = getDocReader( html, baseUrl );

            IEnumerable<string> links = findAllLinks( xml, baseUrl );
            string newHtml = replaceAllLinks( html, links, baseUrl );
            newHtml = insertHeader( newHtml, header );

            splitHtml( newHtml, placeholder );

            // --

            _fetchContentCalled = true;
        }

        // ------------------------------------------------------------------
        #endregion

        #region Public properties.
        // ------------------------------------------------------------------

        /// <summary>
        /// The placeholder parameters (if any) from the last call.
        /// Returns NULL if no parameters.
        /// </summary>
        public string PlaceholderParameters
        {
            get
            {
                return _internalPlaceholderParameters;
            }
        }

        /// <summary>
        /// Read the HTML string that appears before the placeholder.
        /// </summary>
        public string HtmlBefore
        {
            get
            {
                if ( !_fetchContentCalled )
                {
                    throw new ApplicationException(
                        @"Please call the FetchContent() function before accessing the HtmlBefore property." );
                }
                else
                {
                    return _internalHtmlBefore;
                }
            }
        }

        /// <summary>
        /// Read the HTML string that appears after the placeholder.
        /// </summary>
        public string HtmlAfter
        {
            get
            {
                if ( !_fetchContentCalled )
                {
                    throw new ApplicationException(
                        @"Please call the FetchContent() function before accessing the HtmlBefore property." );
                }
                else
                {
                    return _internalHtmlAfter;
                }
            }
        }

        /// <summary>
        /// Access AFTER you called <see cref="FetchContent"/>.
        /// </summary>
        public string SourcePageEncodingName
        {
            get
            {
                if ( !_fetchContentCalled )
                {
                    throw new ApplicationException(
                        @"Please call the FetchContent() function before accessing the SourcePageEncodingName property." );
                }
                else
                {
                    return _sourcePageEncodingName;
                }
            }
        }

        /// <summary>
        /// Access AFTER you called <see cref="FetchContent"/>.
        /// </summary>
        public Encoding SourcePageEncoding
        {
            get
            {
                if ( !_fetchContentCalled )
                {
                    throw new ApplicationException(
                        @"Please call the FetchContent() function before accessing the SourcePageEncoding property." );
                }
                else
                {
                    return _sourcePageEncoding;
                }
            }
        }

        // ------------------------------------------------------------------
        #endregion

        #region IDisposable member.
        // ------------------------------------------------------------------

        public void Dispose()
        {
            _internalHtmlBefore = null;
            _internalHtmlAfter = null;
        }

        // ------------------------------------------------------------------
        #endregion

        #region Private routines.
        // ------------------------------------------------------------------

        /// <summary>
        /// &lt;meta http-equiv="Content-Type" content="text/html; charset=utf-8"&gt;.
        /// </summary>
        private const string Htmlcontentencodingpattern =
            @"<meta\s+http-equiv\s*=\s*[""'\s]?Content-Type\b.*?charset\s*=\s*([^""'\s>]*)";

        private static string detectEncodingName(
            byte[] content )
        {
            if ( content == null || content.Length <= 0 )
            {
                return null;
            }
            else
            {
                // Decode with default encoding to detect the .
                string html = Encoding.Default.GetString( content );

                // Find.
                Match match = Regex.Match(
                    html,
                    Htmlcontentencodingpattern,
                    RegexOptions.Singleline |
                    RegexOptions.IgnoreCase );

                return !match.Success || match.Groups.Count < 2 ? null : match.Groups[1].Value;
            }
        }

        /// <summary>
        /// Load the content from the given HTML.
        /// </summary>
        private string readRemoteHtmlDocument(
            string url )
        {
            LogCentral.Current.LogDebug(
                string.Format(
                    @"Reading remote HTML document from URL '{0}'.",
                    url ) );

            var req = (HttpWebRequest)WebRequest.Create( url );

            using ( var resp = (HttpWebResponse)req.GetResponse() )
            using ( var stream = resp.GetResponseStream() )
            {
                byte[] content;
                using ( var mem = new MemoryStream() )
                {
                    const int blockSize = 16384;
                    var blockBuffer = new byte[blockSize];
                    int read;

                    while ( stream != null && (read = stream.Read( blockBuffer, 0, blockSize )) > 0 )
                    {
                        mem.Write( blockBuffer, 0, read );
                    }

                    // --

                    mem.Seek( 0, SeekOrigin.Begin );

                    var temporaryContent = mem.GetBuffer();

                    content = resp.ContentLength > 0 ? new byte[Math.Min( temporaryContent.Length, resp.ContentLength )] : new byte[temporaryContent.Length];

                    Array.Copy( temporaryContent, content, content.Length );
                }

                _sourcePageEncodingName = detectEncodingName( content );

                LogCentral.Current.LogDebug(
                    string.Format(
                        @"Detected encoding '{0}' for remote HTML document from URL '{1}'.",
                        _sourcePageEncodingName,
                        url ) );

                _sourcePageEncoding = getEncodingByName( _sourcePageEncodingName );
                string html = _sourcePageEncoding.GetString( content );

                return html;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private static XmlReader getDocReader(
            string html,
            string baseUrl )
        {
            var r = new Sgml.SgmlReader();

            if ( baseUrl.Length > 0 )
            {
                r.SetBaseUri( baseUrl );
            }
            r.DocType = @"HTML";
            r.InputStream = new StringReader( html );

            return r;
        }

        /// <summary>
        /// Find all links.
        /// </summary>
        private IEnumerable<string> findAllLinks(
            XmlReader xml,
            string baseUrl )
        {
            var links = new List<string>();

            while ( xml.Read() )
            {
                switch ( xml.NodeType )
                {
                    // Added 2006-03-27: Inside comments, too.
                    case XmlNodeType.Comment:
                        XmlReader childXml = getDocReader( xml.Value, baseUrl );

                        IEnumerable<string> childLinks = findAllLinks( childXml, baseUrl );
                        links.AddRange( childLinks );
                        break;

                    // A node element.
                    case XmlNodeType.Element:
                        string[] linkAttributeNames;
                        // If this is a link element, store the URLs to modify.
                        if ( isLinkElement( xml.Name, out linkAttributeNames ) )
                        {
                            while ( xml.MoveToNextAttribute() )
                            {
                                checkAddStyleAttributeLinks(
                                    xml.Name,
                                    xml.Value,
                                    links );

// ReSharper disable LoopCanBeConvertedToQuery
                                foreach ( string a in linkAttributeNames )
// ReSharper restore LoopCanBeConvertedToQuery
                                {
                                    if ( a.ToLower() == xml.Name.ToLower() )
                                    {
                                        string linkUrl = xml.Value;

                                        if ( !isAbsoluteUrl( linkUrl ) )
                                        {
                                            links.Add( linkUrl );
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Also, look for style attributes.
                            while ( xml.MoveToNextAttribute() )
                            {
                                checkAddStyleAttributeLinks(
                                    xml.Name,
                                    xml.Value,
                                    links );
                            }
                        }
                        break;
                }
            }

            return links.ToArray();
        }

        private static void checkAddStyleAttributeLinks(
            string attributeName,
            string attributeValue,
            IList links )
        {
            if ( attributeName.ToLower() == @"style" )
            {
                string[] linkUrls = extractStyleUrls( attributeValue );

                if ( linkUrls != null && linkUrls.Length > 0 )
                {
                    foreach ( string linkUrl in linkUrls )
                    {
                        if ( !isAbsoluteUrl( linkUrl ) )
                        {
                            links.Add( linkUrl );
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Detects URLs in styles.
        /// </summary>
        /// <param name="styleValue">The style value.</param>
        /// <returns></returns>
        private static string[] extractStyleUrls(
            string styleValue )
        {
            if ( styleValue == null || styleValue.Trim().Length <= 0 )
            {
                return null;
            }
            else
            {
                MatchCollection matchs = Regex.Matches(
                    styleValue,
                    @"url\s*\(\s*([^\)\s]+)\s*\)",
                    RegexOptions.Singleline | RegexOptions.IgnoreCase );

                if ( matchs.Count > 0 )
                {
                    var result = new List<string>();

// ReSharper disable LoopCanBeConvertedToQuery
                    foreach ( Match match in matchs )
// ReSharper restore LoopCanBeConvertedToQuery
                    {
                        if ( match != null && match.Success )
                        {
                            result.Add( match.Groups[1].Value );
                        }
                    }

                    if ( result.Count <= 0 )
                    {
                        return null;
                    }
                    else
                    {
                        return result.ToArray();
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Checks whether a given URL is absolute or relative.
        /// </summary>
        private static bool isAbsoluteUrl(
            string url )
        {
            int dotPos = url.IndexOf( @":" );
            if ( dotPos <= 0 )
            {
                return false;
            }
            else
            {
                return Uri.CheckSchemeName( url.Substring( 0, dotPos ) );
            }
        }

        /// <summary>
        /// Replace relative links with absolute links.
        /// </summary>
        /// <returns>Returns the replaces string.</returns>
        private static string replaceAllLinks(
            string html,
            IEnumerable<string> links,
            string baseUrl )
        {
            var baseWS = baseUrl.TrimEnd( '/' ) + '/';
            var baseOS = baseUrl.TrimEnd( '/' );

            foreach ( string link in links )
            {
                if ( link.Length > 0 )
                {
                    if ( link[0] == '/' )
                    {
                        // Base without slash.
                        html = Regex.Replace(
                            html,
                            @"""" + StringHelper.EscapeRXPattern( link ) + @"""",
                            @"""" + baseOS + link + @"""",
                            RegexOptions.IgnoreCase | RegexOptions.Multiline );
                        html = Regex.Replace(
                            html,
                            @"'" + StringHelper.EscapeRXPattern(link) + @"'",
                            @"'" + baseOS + link + @"'",
                            RegexOptions.IgnoreCase | RegexOptions.Multiline );

                        // For style-"url(...)"-links.
                        html = Regex.Replace(
                            html,
                            @"\(\s*" + StringHelper.EscapeRXPattern(link) + @"\s*\)",
                            @"(" + baseOS + link + @")",
                            RegexOptions.IgnoreCase | RegexOptions.Multiline );
                    }
                    else
                    {
                        //link = StringHelper.EscapeRXCharacters( link );

                        // Base with slash.
                        html = Regex.Replace(
                            html,
                            @"""" + StringHelper.EscapeRXPattern(link) + @"""",
                            @"""" + baseWS + link + @"""",
                            RegexOptions.IgnoreCase | RegexOptions.Multiline );
                        html = Regex.Replace(
                            html,
                            @"'" + StringHelper.EscapeRXPattern(link) + @"'",
                            @"'" + baseWS + link + @"'",
                            RegexOptions.IgnoreCase | RegexOptions.Multiline );

                        // For style-"url(...)"-links.
                        html = Regex.Replace(
                            html,
                            @"\(\s*" + StringHelper.EscapeRXPattern(link) + @"\s*\)",
                            @"(" + baseWS + link + @")",
                            RegexOptions.IgnoreCase | RegexOptions.Multiline );
                    }
                }
            }

            return html;
        }

        /// <summary>
        /// Breaks the HTML at the placeholder, stores in the member variables.
        /// </summary>
        private void splitHtml(
            string html,
            string placeholder )
        {
            placeholder = placeholder.Trim().Trim( '#' ).Trim();

            var pattern = string.Format(
                @"##{0}(\([^\)]*\))?##",
                placeholder );

            var match = Regex.Match(
                html,
                pattern,
                RegexOptions.None );

            var pos = -1;
            var length = 0;

            if ( match.Success )
            {
                pos = match.Index;
                length = match.Length;

                if ( match.Groups.Count > 1 )
                {
                    _internalPlaceholderParameters =
                        match.Groups[1].Value.Trim().Trim( '(', ')' ).Trim();

                    if ( _internalPlaceholderParameters.Length <= 0 )
                    {
                        _internalPlaceholderParameters = null;
                    }
                }
                else
                {
                    _internalPlaceholderParameters = null;
                }
            }

            // --

            if ( pos == -1 )
            {
                _internalHtmlBefore = html;
                _internalHtmlAfter = string.Empty;
            }
            else
            {
                _internalHtmlBefore = html.Substring( 0, pos );
                _internalHtmlAfter = html.Substring( pos + length );
            }
        }

        /// <summary>
        /// Insert an additional string into the HTML header.
        /// </summary>
        /// <returns></returns>
        private static string insertHeader(
            string html,
            string header )
        {
            if ( string.IsNullOrEmpty( header ) )
            {
                return html;
            }
            else
            {
                html = Regex.Replace( html, @"(<head[^>]*>)", string.Format( "$1\n{0}\n", header ),
                    RegexOptions.IgnoreCase | RegexOptions.Multiline );

                return html;
            }
        }

        /// <summary>
        /// Checks whether the given name is a HTML element (=tag) with
        /// a contained link. If true, <paramref name="linkAttributeNames"/> contains a list
        /// of all attributes that are links.
        /// </summary>
        /// <returns>Returns true, if it is a link element, false otherwise.</returns>
        private bool isLinkElement(
            string name,
            out string[] linkAttributeNames )
        {
            name = name.ToLower();
            foreach ( LinkElement e in _linkElements )
            {
                if ( name == e.Name )
                {
                    linkAttributeNames = e.Attributes;
                    return true;
                }
            }

            linkAttributeNames = null;
            return false;
        }

        /// <summary>
        /// Helper function for safely converting a response stream encoding
        /// to a supported Encoding class.
        /// </summary>
        private static Encoding getEncodingByName(
            string encodingName )
        {
            Encoding encoding = Encoding.Default;

            if ( !string.IsNullOrEmpty( encodingName ) )
            {
                try
                {
                    encoding = Encoding.GetEncoding( encodingName );
                }
                catch ( NotSupportedException x )
                {
                    encoding = Encoding.Default;

                    LogCentral.Current.LogError(
                        string.Format(
                            @"Unsupported encoding: '{0}'. Returning default encoding '{1}'.",
                            encodingName,
                            encoding ),
                        x );

                    encoding = Encoding.Default;
                }
            }

            return encoding;
        }

        // ------------------------------------------------------------------
        #endregion

        #region Private member.
        // ------------------------------------------------------------------

        /// <summary>
        /// Remembers whether the <see cref="FetchContent"/> function was called.
        /// </summary>
        private bool _fetchContentCalled;

        /// <summary>
        /// The HTML string that appears before the placeholder.
        /// </summary>
        private string _internalHtmlBefore;

        /// <summary>
        /// The HTML string that appears after the placeholder.
        /// </summary>
        private string _internalHtmlAfter;

        /// <summary>
        /// Stores placeholder parameters (if any) from the last call.
        /// </summary>
        private string _internalPlaceholderParameters;

        /// <summary>
        /// Encoding.
        /// </summary>
        private string _sourcePageEncodingName;
        private Encoding _sourcePageEncoding = Encoding.Default;

        // ------------------------------------------------------------------
        #endregion

        #region LinkElement class.
        // ------------------------------------------------------------------

        /// <summary>
        /// Used by <see cref="WebPageGrabber.isLinkElement"/>.
        /// </summary>
        private class LinkElement
        {
            public LinkElement(
                string name,
                params string[] attributes )
            {
                Name = name;
                Attributes = attributes;
            }

            public readonly string Name;
            public readonly string[] Attributes;
        }

        /// <summary>
        /// This list was taken from the Perl module 'HTML-Tagset-3.03\blib\lib\HTML\Tagset.pm',
        /// '%linkElements' hash.
        /// </summary>
        private readonly LinkElement[] _linkElements = new[] 
        { 
            new LinkElement( @"a", @"href" ),
            new LinkElement( @"applet", @"archive", @"codebase", @"code" ),
            new LinkElement( @"area", @"href" ),
            new LinkElement( @"base", @"href" ),
            new LinkElement( @"bgsound", @"src" ),
            new LinkElement( @"blockquote", @"cite" ),
            new LinkElement( @"body", @"background" ),
            new LinkElement( @"del", @"cite" ),
            new LinkElement( @"embed", @"pluginspage", @"src" ),
            new LinkElement( @"form", @"action" ),
            new LinkElement( @"frame", @"src", @"longdesc" ),
            new LinkElement( @"iframe", @"src", @"longdesc" ),
            new LinkElement( @"ilayer", @"background" ),
            new LinkElement( @"img", @"src", @"lowsrc", @"longdesc", @"usemap" ),
            new LinkElement( @"input", @"src", @"usemap" ),
            new LinkElement( @"ins", @"cite" ),
            new LinkElement( @"isindex", @"action" ),
            new LinkElement( @"head", @"profile" ),
            new LinkElement( @"layer", @"background", @"src" ),
            new LinkElement( @"link", @"href" ),
            new LinkElement( @"object", @"classid", @"codebase", @"data", @"archive", @"usemap" ),
            new LinkElement( @"q", @"cite" ),
            new LinkElement( @"script", @"src", @"for" ),
            new LinkElement( @"table", @"background" ),
            new LinkElement( @"td", @"background" ),
            new LinkElement( @"th", @"background" ),
            new LinkElement( @"tr", @"background" ),
            new LinkElement( @"xmp", @"href" ) 
        };

        // ------------------------------------------------------------------
        #endregion.

        #region Cache management class.
        // ------------------------------------------------------------------

        /// <summary>
        /// Caches the fetched URL.
        /// </summary>
        private class Cache
        {
            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="key">This is usually the URL to fetch from.</param>
            /// <param name="cacheDuration">How long an entry in the cache is valid.</param>
            public Cache(
                string key,
                TimeSpan cacheDuration )
            {
                _key = key;
                _cacheDuration = cacheDuration;
            }

            /// <summary>
            /// If a cached version is available, check, whether the version
            /// is up to date.
            /// </summary>
            public bool IsUpToDateCachedVersionAvailable
            {
                get
                {
                    lock ( this )
                    {
                        if ( IsCachedVersionAvailable )
                        {
                            TimeSpan span = DateTime.Now - cachedDate;
                            return span < _cacheDuration;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            /// <summary>
            /// Check whether a cached version is available.
            /// Does ignore the date of the version.
            /// </summary>
            public bool IsCachedVersionAvailable
            {
                get
                {
                    lock ( this )
                    {
                        return CachedContent != null;
                    }
                }
            }

            /// <summary>
            /// Read and write the cache.
            /// </summary>
            public string CachedContent
            {
                get
                {
                    lock ( this )
                    {
                        var o = HttpContext.Current.Session[cacheContentKeyName];
                        return ConvertHelper.ToString( o );
                    }
                }
                set
                {
                    lock ( this )
                    {
                        HttpContext.Current.Session[cacheContentKeyName] = value;
                        cachedDate = DateTime.Now;
                    }
                }
            }

            /// <summary>
            /// Read and write the cache date.
            /// </summary>
            private DateTime cachedDate
            {
                get
                {
                    var o = HttpContext.Current.Session[cacheDateKeyName];
                    return ConvertHelper.ToDateTime( o );
                }
                set
                {
                    HttpContext.Current.Session[cacheDateKeyName] = value;
                }
            }

            /// <summary>
            /// The key for the cache item.
            /// </summary>
            private readonly string _key;

            /// <summary>
            /// How long an entry is valid.
            /// </summary>
            private readonly TimeSpan _cacheDuration;

            /// <summary>
            /// Calculate the unique key name.
            /// </summary>
            private string cacheContentKeyName
            {
                get
                {
                    return string.Format(
                        @"{0}.{1}.Content",
                        GetType().FullName,
                        _key );
                }
            }

            /// <summary>
            /// Calculate the unique key name.
            /// </summary>
            private string cacheDateKeyName
            {
                get
                {
                    return string.Format(
                        @"{0}.{1}.FetchDate",
                        GetType().FullName,
                        _key );
                }
            }
        }

        // ------------------------------------------------------------------
        #endregion
    }
}