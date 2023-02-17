namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation;

using Azure;
using Google;
using Language;
using Projects;
using Properties;
using Runtime;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Zeta.VoyagerLibrary.Core.Tools.Text;

public static class TranslationHelper
{
    public static readonly ITranslationEngine[] Engines =
    {
        new AzureTranslationEngine(),
        new GoogleRestfulTranslationEngine()
    };

    public static Dictionary<string, string> JoinUnprotectedToProtectedMapping(
        IEnumerable<ProtectionResult> results)
    {
        var dic = new Dictionary<string, string>();

        foreach (var protectionResult in results)
        {
            foreach (var pair in protectionResult.UnprotectedToProtectedMapping)
            {
                dic[pair.Key] = pair.Value;
            }
        }

        return dic;
    }

    public static bool IsSupportedLanguage(
        string? languageCode,
        IEnumerable<TranslationLanguageInfo> languageInfos)
    {
        var ci = CultureHelper.CreateCultureErrorTolerant(languageCode);

        return languageInfos.Any(
            translationLanguageInfo =>
                translationLanguageInfo.LanguageCode.EqualsNoCase(ci.TwoLetterISOLanguageName) ||

                CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode).Name
                    .EqualsNoCase(ci.Name) ||

                CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode).Name
                    .SubstringIntelligent(0, 2).EqualsNoCase(ci.Name.SubstringIntelligent(0, 2)));
    }

    private static ITranslationEngine _translationEngine;

    public static string[] RemoveWords(
        string[] texts,
        string[] wordsToRemove)
    {
        if (texts is not { Length: > 0 } || wordsToRemove is not { Length: > 0 })
        {
            return texts;
        }
        else
        {
            return texts.Select(text => RemoveWords(text, wordsToRemove)).ToArray();
        }
    }

    public static string? RemoveWords(
        string? text,
        string[] wordsToRemove)
    {
        if (StringExtensionMethods.IsNullOrWhiteSpace(text) || wordsToRemove is not { Length: > 0 })
        {
            return text;
        }
        else
        {
            const string regexPrefix = @"[RX]";
            const string wildcardPrefix = @"[WC]";

            var result = text;

            foreach (var word in wordsToRemove)
            {
                var isRegex = word.StartsWithNoCase(regexPrefix);
                var isWildcard = word.StartsWithNoCase(wildcardPrefix);

                if (isRegex || isWildcard)
                {
                    string pattern;
                    if (isRegex)
                    {
                        pattern = word.Substring(regexPrefix.Length);
                    }
                    else
                    {
                        pattern = word.Substring(wildcardPrefix.Length);
                        pattern = convertWildcardToRegex(pattern);
                    }

                    var matches = Regex.Matches(result, pattern);

                    foreach (Match match in matches)
                    {
                        var actualWord = match.Value;
                        result = result.Replace(actualWord, string.Empty);
                    }
                }
                else
                {
                    result = result.Replace(word, string.Empty);
                }
            }

            return result;
        }
    }

    private static string convertWildcardToRegex(string pattern)
    {
        // http://stackoverflow.com/a/6907849/107625
        // http://www.codeproject.com/Articles/11556/Converting-Wildcards-to-Regexes

        return @"^" + Regex.Escape(pattern).
            Replace(@"\*", @".*").
            Replace(@"\?", @".") + @"$";
    }

    // TODO.

    public sealed class ProtectionInfo
    {
        public string? UnprotectedText { get; set; }
        public string[] WordsToProtect { get; set; }
    }

    public sealed class ProtectionResult
    {
        public string? ProtectedText { get; set; }
        public string[] WordsToProtect { get; set; }
        public Dictionary<string, string> UnprotectedToProtectedMapping { get; set; }
    }

    public sealed class UnprotectionInfo
    {
        public string? UnprotectedText { get; set; }
    }

    public static ProtectionResult[] ProtectWords(
        IEnumerable<ProtectionInfo> inputs)
    {
        return inputs.Select(ProtectWords).ToArray();
    }

    //public static string[] ProtectWords(
    //    string[] texts,
    //    string[] wordsToProtect)
    //{
    //    if (texts == null || texts.Length <= 0 || wordsToProtect == null || wordsToProtect.Length <= 0)
    //    {
    //        return texts;
    //    }
    //    else
    //    {
    //        return texts.Select(text => ProtectWords(text, wordsToProtect)).ToArray();
    //    }
    //}

    public static ProtectionResult ProtectWords(
        ProtectionInfo input)
    {
        if (StringExtensionMethods.IsNullOrWhiteSpace(input?.UnprotectedText) || input?.WordsToProtect == null || input.WordsToProtect.Length <= 0)
        {
            return new()
            {
                ProtectedText = input?.UnprotectedText,
                WordsToProtect = input?.WordsToProtect,
                UnprotectedToProtectedMapping = new()
            };
        }
        else
        {
            var result = new ProtectionResult
            {
                WordsToProtect = input.WordsToProtect,
                ProtectedText = input.UnprotectedText,
                UnprotectedToProtectedMapping = new()
            };

            const string regexPrefix = @"[RX]";
            const string wildcardPrefix = @"[WC]";

            var index = 0;
            foreach (var word in input.WordsToProtect)
            {
                var isRegex = word.StartsWithNoCase(regexPrefix);
                var isWildcard = word.StartsWithNoCase(wildcardPrefix);

                if (isRegex || isWildcard)
                {
                    string pattern;
                    if (isRegex)
                    {
                        pattern = word.Substring(regexPrefix.Length);
                    }
                    else
                    {
                        pattern = word.Substring(wildcardPrefix.Length);
                        pattern = convertWildcardToRegex(pattern);
                    }

                    var matches = Regex.Matches(result.ProtectedText, pattern);

                    foreach (Match match in matches)
                    {
                        var replacement = $@"3213213{index}4234234";
                        index++;

                        var actualWord = match.Value;
                        result.ProtectedText = result.ProtectedText.Replace(actualWord, replacement);

                        result.UnprotectedToProtectedMapping[actualWord] = replacement;
                    }
                }
                else
                {
                    var replacement = $@"3213213{index}4234234";
                    index++;

                    result.ProtectedText = result.ProtectedText.Replace(word, replacement);

                    result.UnprotectedToProtectedMapping[word] = replacement;
                }
            }

            return result;
        }
    }

    //public static string ProtectWords(
    //    string text,
    //    string[] wordsToProtect)
    //{
    //    if (StringExtensionMethods.IsNullOrWhiteSpace(text) || wordsToProtect == null || wordsToProtect.Length <= 0)
    //    {
    //        return text;
    //    }
    //    else
    //    {
    //        var index = 0;
    //        foreach (var word in wordsToProtect)
    //        {
    //            text = text.Replace(word, $@"3213213{index}4234234");
    //            index++;
    //        }

    //        return text;
    //    }
    //}

    public static UnprotectionInfo UnprotectWords(
        ProtectionResult input)
    {
        if (string.IsNullOrWhiteSpace(input?.ProtectedText) || input.UnprotectedToProtectedMapping is not
            {
                Count: > 0
            })
        {
            return new()
            {
                UnprotectedText = input?.ProtectedText
            };
        }
        else
        {
            var result = new UnprotectionInfo { UnprotectedText = input.ProtectedText };

            foreach (var pair in input.UnprotectedToProtectedMapping)
            {
                result.UnprotectedText = result.UnprotectedText.Replace(pair.Value, pair.Key);
            }

            return result;
        }
    }

    //public static string UnprotectWords(
    //    string text,
    //    string[] wordsToProtect)
    //{
    //    if (StringExtensionMethods.IsNullOrWhiteSpace(text) || wordsToProtect == null || wordsToProtect.Length <= 0)
    //    {
    //        return text;
    //    }
    //    else
    //    {
    //        var index = 0;
    //        foreach (var word in wordsToProtect)
    //        {
    //            text = text.Replace($@"3213213{index}4234234", word);
    //            index++;
    //        }

    //        // Remove multiple white-spaces.
    //        return text /*.Replace(@"  ", @" ").Replace(@"  ", @" ")*/;
    //    }
    //}

    //public static string UnprotectWords(
    //    string text,
    //    string[] wordsToProtect)
    //{
    //    if (StringExtensionMethods.IsNullOrWhiteSpace(text) || wordsToProtect == null || wordsToProtect.Length <= 0)
    //    {
    //        return text;
    //    }
    //    else
    //    {
    //        const string regexPrefix = @"[RX]";
    //        const string wildcardPrefix = @"[WC]";

    //        var index = 0;
    //        foreach (var word in wordsToProtect)
    //        {
    //            if (word.StartsWithNoCase(regexPrefix))
    //            {
    //                var pattern = word.Substring(regexPrefix.Length);

    //                text = Regex.Replace(text, pattern, )
    //            }
    //            else if (word.StartsWithNoCase(wildcardPrefix))
    //            {
    //                var pattern = word.Substring(regexPrefix.Length);
    //                pattern = convertWildcardToRegex(pattern);


    //            }
    //            else
    //            {
    //                text = text.Replace($@"3213213{index}4234234", word);
    //            }

    //            index++;
    //        }

    //        // Remove multiple white-spaces.
    //        return text /*.Replace(@"  ", @" ").Replace(@"  ", @" ")*/;
    //    }
    //}

    public static void ResetSelectedEngine()
    {
        _translationEngine = null;
        _translationAppIDSet = false;
        _translationAppID = null;
    }

    public static ITranslationEngine GetTranslationEngine(
        Project project)
    {
        if (_translationEngine == null)
        {
            if (project != null)
            {
                var uid = project.TranslationEngineUniqueInternalName;
                if (!StringExtensionMethods.IsNullOrWhiteSpace(uid))
                {
                    foreach (var engine in Engines)
                    {
                        if (uid.EqualsNoCase(engine.UniqueInternalName))
                        {
                            _translationEngine = engine;
                            return engine;
                        }
                    }
                }
            }

            foreach (var engine in Engines)
            {
                if (engine.IsDefault)
                {
                    _translationEngine = engine;
                    return engine;
                }
            }

            throw new();
        }

        return _translationEngine;
    }

    private static bool _translationAppIDSet;
    private static string _translationAppID;

    public static void GetTranslationAppID(
        Project project,
        out string appID)
    {
        if (!_translationAppIDSet)
        {
            if (project != null)
            {
                var uid = project.TranslationEngineUniqueInternalName;
                if (!StringExtensionMethods.IsNullOrWhiteSpace(uid))
                {
                    var ids = project.TranslationAppIDs;
                    if (ids != null)
                    {
                        foreach (var key in project.TranslationAppIDs.Keys)
                        {
                            if (key != null && key == uid)
                            {
                                _translationAppIDSet = true;
                                _translationAppID = safeGetValue(project.TranslationAppIDs, key);

                                appID = _translationAppID;
                                return;
                            }
                        }
                    }
                }
            }
        }

        appID = _translationAppID;
    }

    private static string safeGetValue(IReadOnlyDictionary<string?, string> dic, string? key)
    {
        if (dic == null || string.IsNullOrEmpty(key))
        {
            return null;
        }
        else
        {
            return dic.TryGetValue(key, out var r) ? r : null;
        }
    }

    internal static string? DoMapCultureToLanguageCode(
        IEnumerable<TranslationLanguageInfo> availableLanguageInfos,
        CultureInfo cultureInfo)
    {
        var all = availableLanguageInfos.ToList();

        // 2021-08-23, Uwe Keim: Multiple passes.

        foreach (var translationLanguageInfo in all)
        {
            var ci = CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode);

            if (
                translationLanguageInfo.LanguageCode.EqualsNoCase(cultureInfo.TwoLetterISOLanguageName) ||
                ci.Name.EqualsNoCase(cultureInfo.Name) )
            {
                return translationLanguageInfo.LanguageCode;
            }
        }

        foreach (var translationLanguageInfo in all)
        {
            var ci = CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode);

            if (
                ci.Name.SubstringIntelligent(0, 2).EqualsNoCase(cultureInfo.Name.SubstringIntelligent(0, 2)))
            {
                return translationLanguageInfo.LanguageCode;
            }
        }

        throw new(string.Format(Resources.NoLangForBing, PrettyPrint(cultureInfo)));
    }

    private static string PrettyPrint(CultureInfo cultureInfo)
    {
        return $@"{cultureInfo.DisplayName} ({cultureInfo})";
    }
}