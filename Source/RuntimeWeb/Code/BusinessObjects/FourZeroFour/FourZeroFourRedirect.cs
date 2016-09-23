namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.FourZeroFour
{
    using System;
    using System.Data;
    using System.Text.RegularExpressions;
    using Zeta.VoyagerLibrary.Data;
    using Zeta.VoyagerLibrary.Logging;

    public class FourZeroFourRedirect
    {
        private string _pattern;
        private string _redirectTo;
        private bool _isPermanent;

        public bool IsPermanent => _isPermanent;

        public FourZeroFourRedirect Load(
            DataRow row)
        {
            DBHelper.ReadField(out _pattern, row[@"Pattern"]);
            DBHelper.ReadField(out _redirectTo, row[@"RedirectTo"]);
            DBHelper.ReadField(out _isPermanent, row[@"IsPermanent"]);

            return this;
        }

        public string MatchUrl(string url)
        {
            var original = url;

            var match = Regex.Match(url, _pattern, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                var replaced = replaceMatch(match, _redirectTo);

                if (string.Compare(original, replaced, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    LogCentral.Current.LogInfo(
                        $@"[404 redirect] NOT matching: original URL = '{original}', replaced URL = '{replaced}', pattern = '{_pattern}', redirect to = '{_redirectTo}'.");

                    return null;
                }
                else
                {
                    LogCentral.Current.LogInfo(
                        $@"[404 redirect] IS matching: original URL = '{original}', replaced URL = '{replaced}', pattern = '{_pattern}', redirect to = '{_redirectTo}'.");

                    return replaced;
                }
            }
            else
            {
                LogCentral.Current.LogInfo(
                    $@"[404 redirect] IS NO MATCH: original URL = '{original}', pattern = '{_pattern}', redirect to = '{_redirectTo}'.");

                return null;
            }
        }

        private static string replaceMatch(
            Group match,
            string text)
        {
            if (string.IsNullOrEmpty(text) || !text.Contains(@"$"))
            {
                return text;
            }
            else
            {
                // Count down, not up.
                for (var index = match.Captures.Count - 1; index >= 0; index--)
                {
                    var c = match.Captures[index];
                    text = text.Replace($@"${index}", c.Value);
                }

                return text;
            }
        }
    }
}