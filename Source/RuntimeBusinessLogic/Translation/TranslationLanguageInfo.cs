namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation
{
	using System.Diagnostics;
	using Language;

	[DebuggerDisplay(@"{LanguageCode} ({UserReadableName})")]
	public class TranslationLanguageInfo
	{
		public override string ToString()
		{
			return
				string.Format(
					@"{0} [{1}]",
					UserReadableName,
					CultureHelper.CreateCultureErrorTolerant(LanguageCode).Name);
		}

		public string UserReadableName { get; set; }
		public string LanguageCode { get; set; }
	}
}