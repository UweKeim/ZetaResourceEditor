namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.FourZeroFour
{
	using System.Data;
	using System.Text.RegularExpressions;
	using Zeta.EnterpriseLibrary.Data;
	using Zeta.EnterpriseLibrary.Logging;

	public class FourZeroFourRedirect
	{
		private string _pattern;
		private string _redirectTo;
		private bool _isPermanent;

		public bool IsPermanent
		{
			get { return _isPermanent; }
		}

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

				if (string.Compare(original, replaced, true) == 0)
				{
					LogCentral.Current.LogInfo(
						string.Format(
							@"[404 redirect] NOT matching: original URL = '{0}', replaced URL = '{1}', pattern = '{2}', redirect to = '{3}'.",
							original,
							replaced,
							_pattern,
							_redirectTo));

					return null;
				}
				else
				{
					LogCentral.Current.LogInfo(
						string.Format(
							@"[404 redirect] IS matching: original URL = '{0}', replaced URL = '{1}', pattern = '{2}', redirect to = '{3}'.",
							original,
							replaced,
							_pattern,
							_redirectTo));

					return replaced;
				}
			}
			else
			{
				LogCentral.Current.LogInfo(
					string.Format(
						@"[404 redirect] IS NO MATCH: original URL = '{0}', pattern = '{1}', redirect to = '{2}'.",
						original,
						_pattern,
						_redirectTo));

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
					text = text.Replace(string.Format(@"${0}", index), c.Value);
				}

				return text;
			}
		}
	}
}