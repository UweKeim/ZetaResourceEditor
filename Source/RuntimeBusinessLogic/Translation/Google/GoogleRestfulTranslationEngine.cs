namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation.Google;

using global::Google.Apis.Auth.OAuth2;
using global::Google.Cloud.Translation.V2;
using System.Globalization;
using System.Linq;

/*
 * https://cloud.google.com/translate/docs/reference/libraries
 */

public class GoogleRestfulTranslationEngine :
    ITranslationEngine
{
    string ITranslationEngine.AppID1Name => "JSON key credentials";

    bool ITranslationEngine.IsAppIDMultiLine => true;
    bool ITranslationEngine.IsJson => true;

    bool ITranslationEngine.IsDefault => true;

    string ITranslationEngine.UniqueInternalName => @"9efb237c-ce92-450f-9ef1-850091762d63";

    string ITranslationEngine.UserReadableName => "Google Translate";

    bool ITranslationEngine.AreAppIDsSyntacticallyValid(string appID)
    {
        return !string.IsNullOrEmpty(appID);
    }

    private TranslationLanguageInfo[] _sourceLanguages;

    TranslationLanguageInfo[] ITranslationEngine.GetSourceLanguages(string appID)
    {
        if (_sourceLanguages == null)
        {
            ZspSimpleFileAccessProtector.Protect(
                delegate
                {
                    var result = new List<TranslationLanguageInfo>();

                    var client = TranslationClient.Create(GoogleCredential.FromJson(appID));
                    var nodes = client.ListLanguages(@"en");

                    foreach (var language in nodes)
                    {
                        result.Add(
                            new()
                            {
                                LanguageCode = language.Code,
                                UserReadableName = language.Name,
                            });
                    }

                    _sourceLanguages = result.ToArray();
                });
        }

        return _sourceLanguages;
    }

    TranslationLanguageInfo[] ITranslationEngine.GetDestinationLanguages(string appID)
    {
        return ((ITranslationEngine)this).GetSourceLanguages(appID);
    }

    int ITranslationEngine.MaxArraySize => 25;

    string ITranslationEngine.AppIDLink => @"https://zeta.li/zre-translation-appid-google";

    string[] ITranslationEngine.TranslateArray(
        string appID,
        string[] texts,
        string sourceLanguageCode,
        string destinationLanguageCode,
        string[] wordsToProtect,
        string[] wordsToRemove)
    {
        var protectionResults = new List<TranslationHelper.ProtectionResult>();

        foreach (var text in texts)
        {
            var removed = TranslationHelper.RemoveWords(text, wordsToRemove);

            var preparedText = TranslationHelper.ProtectWords(new TranslationHelper.ProtectionInfo
            {
                UnprotectedText = removed,
                WordsToProtect = wordsToProtect
            });

            protectionResults.Add(preparedText);
        }

        var tr = new List<TranslationResult>();

        ZspSimpleFileAccessProtector.Protect(
            delegate
            {
                // Das eigentliche Übersetzen.
                var client = TranslationClient.Create(GoogleCredential.FromJson(appID));
                tr = client.TranslateText(
                    protectionResults.Select(x => x.ProtectedText),
                    destinationLanguageCode,
                    sourceLanguageCode).ToList();
            });

        var dicDic = TranslationHelper.JoinUnprotectedToProtectedMapping(protectionResults);

        var result = new List<string>();

        foreach (var translatedText in tr)
        {
            result.Add(
                TranslationHelper.UnprotectWords(
                    new()
                    {
                        ProtectedText = translatedText.TranslatedText,
                        WordsToProtect = wordsToProtect,
                        UnprotectedToProtectedMapping = dicDic
                    }
                ).UnprotectedText);
        }

        return result.ToArray();
    }

    bool ITranslationEngine.IsSourceLanguageSupported(string appID, string languageCode)
    {
        return TranslationHelper.IsSupportedLanguage(languageCode,
            ((ITranslationEngine)this).GetSourceLanguages(appID));
    }

    bool ITranslationEngine.IsDestinationLanguageSupported(string appID, string languageCode)
    {
        return TranslationHelper.IsSupportedLanguage(languageCode,
            ((ITranslationEngine)this).GetDestinationLanguages(appID));
    }

    string ITranslationEngine.MapCultureToSourceLanguageCode(string appID, CultureInfo cultureInfo)
    {
        return TranslationHelper.DoMapCultureToLanguageCode(
            ((ITranslationEngine)this).GetSourceLanguages(appID), cultureInfo);
    }

    string ITranslationEngine.MapCultureToDestinationLanguageCode(string appID,
        CultureInfo cultureInfo)
    {
        return TranslationHelper.DoMapCultureToLanguageCode(
            ((ITranslationEngine)this).GetDestinationLanguages(appID), cultureInfo);
    }

    string ITranslationEngine.Translate(
        string appID,
        string text,
        string sourceLanguageCode,
        string destinationLanguageCode,
        string[] wordsToProtect,
        string[] wordsToRemove)
    {
        return ((ITranslationEngine)this).TranslateArray(
            appID,
            new[] { text },
            sourceLanguageCode,
            destinationLanguageCode,
            wordsToProtect,
            wordsToRemove).FirstOrDefault();
    }

    public bool SupportsArrayTranslation => true;
}