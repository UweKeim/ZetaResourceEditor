namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation;

using System.Globalization;

public interface ITranslationEngine
{
    string AppID1Name { get; }
    bool IsAppIDMultiLine { get; }
    bool IsJson { get; }

    bool IsDefault { get; }
    string UniqueInternalName { get; }

    string UserReadableName { get; }

    TranslationLanguageInfo[] GetSourceLanguages(
        string appID);
    TranslationLanguageInfo[] GetDestinationLanguages(
        string appID);

    string Translate(
        string appID,
        string text,
        string sourceLanguageCode,
        string destinationLanguageCode,
        string[] wordsToProtect,
        string[] wordsToRemove);

    bool SupportsArrayTranslation { get; }
    int MaxArraySize { get; }

    string AppIDLink { get; }

    string[] TranslateArray(
        string appID,
        string[] texts,
        string sourceLanguageCode,
        string destinationLanguageCode,
        string[] wordsToProtect,
        string[] wordsToRemove);

    bool IsSourceLanguageSupported(
        string appID,
        string languageCode);
    bool IsDestinationLanguageSupported(
        string appID,
        string languageCode);

    string MapCultureToSourceLanguageCode(
        string appID,
        CultureInfo cultureInfo);
    string MapCultureToDestinationLanguageCode(
        string appID,
        CultureInfo cultureInfo);

    bool AreAppIDsSyntacticallyValid(
        string appID);
}