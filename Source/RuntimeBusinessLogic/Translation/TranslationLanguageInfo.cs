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
			    $@"{UserReadableName} [{CultureHelper.CreateCultureErrorTolerant(LanguageCode).Name}]";
		}

		public string UserReadableName { get; set; }
		public string LanguageCode { get; set; }
	}
}