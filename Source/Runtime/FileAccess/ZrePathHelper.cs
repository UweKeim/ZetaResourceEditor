namespace ZetaResourceEditor.Runtime.FileAccess;

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public sealed class ZrePathHelper
{
    private const string InvalidObjectIDPattern = @"[^\{\}\-\w\$]+";

    public static string MakeValidObjectID(
        string name )
    {
        if (string.IsNullOrEmpty(name))
        {
            return name;
        }
        else
        {
            // Translate german umlaute.
            var s = name;
            s = s.Replace(@"Ä", @"Ae");
            s = s.Replace(@"Ö", @"Oe");
            s = s.Replace(@"Ü", @"Ue");
            s = s.Replace(@"ß", @"ss");
            s = s.Replace(@"ä", @"ae");
            s = s.Replace(@"ö", @"oe");
            s = s.Replace(@"ü", @"ue");

            // French characters.
            /*
            s = s.Replace(@"é", @"e");
            s = s.Replace(@"è", @"e");
            s = s.Replace(@"É", @"E");
            s = s.Replace(@"È", @"E");
            ...
            */

            // TODO: Generically translate several other special characters.
            // (I.e. french special chars, etc.)
            // E.g. by comparing the numeric ANSI-value and stripping away 
            // the unwanted ranges.

            // --

            var rx = new Regex(
                InvalidObjectIDPattern,
                RegexOptions.Singleline | RegexOptions.IgnoreCase);

            var result = new StringBuilder(rx.Replace(s, @"-"));

            for (var i = 0; i < result.Length; ++i)
            {
                if (!isValidFileNameChar(result[i]))
                {
                    result[i] = '-';
                }
            }

            // --
            // 2010-09-12, Uwe Keim:
            // Make more beautiful and meaningful.

            result.Replace(@"--", @"-");
            result.Replace(@"--", @"-");

            var ret = result.ToString().Trim('-').ToLowerInvariant();
            return ret;
        }
    }

    private static bool isValidFileNameChar(
        char ch,
        ICollection<char> additionalValidChars = null)
    {
        if (ch is not (>= 'a' and <= 'z' or >= 'A' and <= 'Z' or >= '0' and <= '9' or '$' or '-' or '_' or '.' or '+' or '!' or '\'' or '(' or ')' or '{' or '}' or ','))
        {
            return additionalValidChars is { Count: > 0 } && additionalValidChars.Contains(ch);
        }
        else
        {
            return true;
        }
    }

    /// <summary>
    /// Shortens a pathname for display purposes.
    /// </summary>
    /// <param name="pathName">Name of the path.</param>
    /// <param name="maximumPathLength">Maximum length of the path.</param>
    /// <returns></returns>
    /// <remarks>Shortens a pathname by either removing consecutive
    /// components of a path and/or by removing characters from the end of
    /// the fileName and replacing then with three ellipses (...)
    /// <para>In all cases, the root of the passed path will be preserved
    /// in it's entirety.</para>
    /// 	<para>If a UNC path is used or the pathname and maxLength are
    /// particularly short,
    /// the resulting path may be longer than maxLength.</para>
    /// 	<para>This method expects fully resolved pathnames to be passed
    /// to it. (Use Path.GetFullPath() to obtain this.)</para>
    /// </remarks>
    public static string ShortenPathName(
        string pathName,
        int maximumPathLength )
    {
        if ( string.IsNullOrEmpty( pathName ) )
        {
            return pathName;
        }
        else
        {
            pathName = pathName.Trim();

            if ( pathName.Length <= maximumPathLength )
            {
                return pathName;
            }
            else
            {
                var root = ZspPathHelper.GetPathRoot( pathName );
                if ( root.Length > 3 )
                {
                    root += Path.DirectorySeparatorChar;
                }

                var elements = pathName.Substring( root.Length ).Split(
                    Path.DirectorySeparatorChar,
                    Path.AltDirectorySeparatorChar );

                var filenameIndex = elements.GetLength( 0 ) - 1;

                // pathname is just a root and fileName
                if ( elements.GetLength( 0 ) == 1 )
                {
                    if ( elements[0].Length > 5 ) // long enough to shorten
                    {
                        // if path is a UNC path, root may be rather long
                        if ( root.Length + 6 >= maximumPathLength )
                        {
                            return root + elements[0].Substring( 0, 3 ) + @"...";
                        }
                        else
                        {
                            return pathName.Substring( 0, maximumPathLength - 3 ) + @"...";
                        }
                    }
                    else
                    {
                        return pathName;
                    }
                }
                // pathname is just a root and fileName
                else if ( root.Length + 4 + elements[filenameIndex].Length >
                          maximumPathLength )
                {
                    root += @"...\";

                    var len = elements[filenameIndex].Length;
                    if ( len < 6 )
                    {
                        return root + elements[filenameIndex];
                    }
                    else
                    {
                        if ( root.Length + 6 >= maximumPathLength )
                        {
                            len = 3;
                        }
                        else
                        {
                            len = maximumPathLength - root.Length - 3;
                        }

                        return root + elements[filenameIndex].Substring( 0, len ) +
                               @"...";
                    }
                }
                else if ( elements.GetLength( 0 ) == 2 )
                {
                    return root + @"...\" + elements[1];
                }
                // More elements.
                else
                {
                    var len = 0;
                    var begin = 0;

                    for ( var i = 0; i < filenameIndex; i++ )
                    {
                        if ( elements[i].Length > len )
                        {
                            begin = i;
                            len = elements[i].Length;
                        }
                    }

                    var totalLength = pathName.Length - len + 3;
                    var end = begin + 1;

                    while ( totalLength > maximumPathLength )
                    {
                        if ( begin > 0 )
                        {
                            totalLength -= elements[--begin].Length - 1;
                        }

                        if ( totalLength <= maximumPathLength )
                        {
                            break;
                        }

                        if ( end < filenameIndex )
                        {
                            totalLength -= elements[++end].Length - 1;
                        }

                        if ( begin == 0 && end == filenameIndex )
                        {
                            break;
                        }
                    }

                    // assemble final string

                    for ( var i = 0; i < begin; i++ )
                    {
                        root += elements[i] + '\\';
                    }

                    root += @"...\";

                    for ( var i = end; i < filenameIndex; i++ )
                    {
                        root += elements[i] + '\\';
                    }

                    return root + elements[filenameIndex];
                }
            }
        }
    }
}