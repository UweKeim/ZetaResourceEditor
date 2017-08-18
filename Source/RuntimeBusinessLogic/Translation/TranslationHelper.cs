namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation
{
    using Azure;
    using Google;
    using Language;
    using Projects;
    using Properties;
    using Runtime;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Zeta.VoyagerLibrary.Tools;
    using ZetaLongPaths;

    public static class TranslationHelper
    {
        public static readonly ITranslationEngine[] Engines =
        {
            new AzureTranslationEngine(),
            new GoogleRestfulTranslationEngine()
            //new BingSoapTranslationEngine()
        };

        public static bool IsSupportedLanguage(
            string languageCode,
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
            if (texts == null || texts.Length <= 0 || wordsToRemove == null || wordsToRemove.Length <= 0)
            {
                return texts;
            }
            else
            {
                return texts.Select(text => RemoveWords(text, wordsToRemove)).ToArray();
            }
        }

        public static string RemoveWords(
            string text,
            string[] wordsToRemove)
        {
            if (StringExtensionMethods.IsNullOrWhiteSpace(text) || wordsToRemove == null || wordsToRemove.Length <= 0)
            {
                return text;
            }
            else
            {
                return wordsToRemove.Aggregate(text, (current, word) => current.Replace(word, string.Empty));
            }
        }

        public static string[] ProtectWords(
            string[] texts,
            string[] wordsToProtect)
        {
            if (texts == null || texts.Length <= 0 || wordsToProtect == null || wordsToProtect.Length <= 0)
            {
                return texts;
            }
            else
            {
                return texts.Select(text => ProtectWords(text, wordsToProtect)).ToArray();
            }
        }

        public static string ProtectWords(
            string text,
            string[] wordsToProtect)
        {
            if (StringExtensionMethods.IsNullOrWhiteSpace(text) || wordsToProtect == null || wordsToProtect.Length <= 0)
            {
                return text;
            }
            else
            {
                var index = 0;
                foreach (var word in wordsToProtect)
                {
                    text = text.Replace(word, $@"3213213{index}4234234");
                    index++;
                }

                return text;
            }
        }

        public static string UnprotectWords(
            string text,
            string[] wordsToProtect)
        {
            if (StringExtensionMethods.IsNullOrWhiteSpace(text) || wordsToProtect == null || wordsToProtect.Length <= 0)
            {
                return text;
            }
            else
            {
                var index = 0;
                foreach (var word in wordsToProtect)
                {
                    text = text.Replace($@"3213213{index}4234234", word);
                    index++;
                }

                // Remove multiple white-spaces.
                return text /*.Replace(@"  ", @" ").Replace(@"  ", @" ")*/;
            }
        }

        public static void ResetSelectedEngine()
        {
            _translationEngine = null;
            _translationAppIDSet = false;
            _translationAppID = null;
            _translationAppID2 = null;
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

                throw new Exception();
            }

            return _translationEngine;
        }

        private static bool _translationAppIDSet;
        private static string _translationAppID;
        private static string _translationAppID2;

        public static void GetTranslationAppID(
            Project project,
            out string appID,
            out string appID2)
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
                                    _translationAppID2 = safeGetValue(project.TranslationAppIDs, key + @"-2");

                                    appID = _translationAppID;
                                    appID2 = _translationAppID2;
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            appID = _translationAppID;
            appID2 = _translationAppID2;
        }

        private static string safeGetValue(Dictionary<string, string> dic, string key)
        {
            if (dic == null || string.IsNullOrEmpty(key))
            {
                return null;
            }
            else
            {
                return dic.TryGetValue(key, out string r) ? r : null;
            }
        }

        internal static string DoMapCultureToLanguageCode(
            IEnumerable<TranslationLanguageInfo> availableLanguageInfos,
            CultureInfo cultureInfo)
        {
            foreach (var translationLanguageInfo in availableLanguageInfos)
            {
                if (
                    translationLanguageInfo.LanguageCode.EqualsNoCase(cultureInfo.TwoLetterISOLanguageName) ||

                    CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode).Name.EqualsNoCase(
                        cultureInfo.Name) ||

                    CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode).Name
                        .SubstringIntelligent(0, 2).EqualsNoCase(cultureInfo.Name.SubstringIntelligent(0, 2)))
                {
                    return translationLanguageInfo.LanguageCode;
                }
            }

            throw new Exception(string.Format(Resources.NoLangForBing, PrettyPrint(cultureInfo)));
        }

        private static string PrettyPrint(CultureInfo cultureInfo)
        {
            return $@"{cultureInfo.DisplayName} ({cultureInfo})";
        }
    }
}