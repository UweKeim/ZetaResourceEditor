namespace ZetaResourceEditor.Runtime
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public static class StringExtensionMethods
    {
        public static string ReplaceEscapes(string text)
        {
            return text
                .Replace("\r", @"\r")
                .Replace("\n", @"\n")
                .Replace("\t", @"\t");
        }

        public static string UnreplaceEscapes(string text)
        {
            return text
                .Replace(@"\r", "\r")
                .Replace(@"\n", "\n")
                .Replace(@"\t", "\t");
        }

        public static bool IsNullOrWhiteSpace(
            string s)
        {
            return string.IsNullOrEmpty(s) || s.Trim().Length <= 0;
        }

        public static string ToLowerInvariantIntelligent(
            string s)
        {
            return string.IsNullOrEmpty(s) ? s : s.ToLowerInvariant();
        }

        public static string GenerateMatchCode(
            string matchCode,
            string name)
        {
            if (IsValidMatchCode(matchCode))
            {
                return matchCode;
            }
            else
            {
                matchCode = name.ToLowerInvariant();
                matchCode = matchCode.Trim();

                matchCode = RXReplace(matchCode, @"^[^a-z_]", @"_", @"gs");			// first char.
                matchCode = RXReplace(matchCode, @"[^a-z0-9_]", @"_", @"gs");		// second+ chars.

                return matchCode;
            }
        }

        public static string GenerateMatchCode(
            this string matchCode)
        {
            return GenerateMatchCode(matchCode, matchCode);
        }

        public static bool IsValidMatchCode(
            string matchCode)
        {
            return RXTest(matchCode, @"^[a-z_][a-z0-9_]*$", @"si");
        }

        public static string RXReplace(
            string text,
            string pattern,
            string replacement,
            string flags)
        {
            var options =
                ConvertRXOptionsFromString(flags);

            var rx = new Regex(pattern, options);
            return flags.Contains(@"g") ? rx.Replace(text, replacement) : rx.Replace(text, replacement, 1);
        }

        public static bool RXTest(
            string text,
            string pattern,
            string flags)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            else
            {
                var options =
                    ConvertRXOptionsFromString(flags);

                var rx = new Regex(
                    pattern,
                    options);
                return rx.IsMatch(text);
            }
        }

        public static RegexOptions ConvertRXOptionsFromString(
            string flags)
        {
            if (RecentRegexOptions.TryGetValue(flags, out var options))
            {
                return options;
            }
            else
            {
                options = RegexOptions.None;

                if (flags.Contains(@"i"))
                {
                    options |= RegexOptions.IgnoreCase;
                }
                if (flags.Contains(@"x"))
                {
                    options |= RegexOptions.IgnorePatternWhitespace;
                }
                if (flags.Contains(@"m"))
                {
                    options |= RegexOptions.Multiline;
                }
                if (flags.Contains(@"s"))
                {
                    options |= RegexOptions.Singleline;
                }

                RecentRegexOptions[flags] = options;
                return options;
            }
        }

        private static readonly Dictionary<string, RegexOptions> RecentRegexOptions =
                    new Dictionary<string, RegexOptions>();
    }
}