namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation;

using Language;
using System.Diagnostics;

[DebuggerDisplay(@"{LanguageCode} ({UserReadableName})")]
public class TranslationLanguageInfo
{
    public override string ToString()
    {
        return $@"{UserReadableName} [{CultureHelper.CreateCultureErrorTolerant(LanguageCode).Name}]";
    }

    public string UserReadableName { get; set; }
    public string LanguageCode { get; set; }
}