namespace ZetaResourceEditor.Runtime
{
	public static class StringExtensionMethods
	{
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
	}
}