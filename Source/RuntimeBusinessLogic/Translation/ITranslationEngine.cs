namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation
{
    using System.Globalization;

    public interface ITranslationEngine
    {
        bool Has2AppIDs { get; }

        string AppID1Name { get; }
        string AppID2Name { get; }

        bool IsUserSelectable { get; }
        bool IsDefault { get; }
        string UniqueInternalName { get; }

        string UserReadableName { get; }

        TranslationLanguageInfo[] GetSourceLanguages(
            string appID,
            string appID2);
        TranslationLanguageInfo[] GetDestinationLanguages(
            string appID,
            string appID2);

        string Translate(
            string appID,
            string appID2,
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
            string appID2,
            string[] texts,
            string sourceLanguageCode,
            string destinationLanguageCode,
            string[] wordsToProtect,
            string[] wordsToRemove);

        bool IsSourceLanguageSupported(
            string appID,
            string appID2,
            string languageCode);
        bool IsDestinationLanguageSupported(
            string appID,
            string appID2,
            string languageCode);

        string MapCultureToSourceLanguageCode(
            string appID,
            string appID2,
            CultureInfo cultureInfo);
        string MapCultureToDestinationLanguageCode(
            string appID,
            string appID2,
            CultureInfo cultureInfo);

        bool AreAppIDsSyntacticallyValid(
            string appID,
            string appID2);
    }
}