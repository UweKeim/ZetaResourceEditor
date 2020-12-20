namespace ZetaResourceEditor.RuntimeBusinessLogic.Language
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Threading;
    using System.Windows.Forms;
    using DevExpress.XtraSpellChecker;
    using Zeta.VoyagerLibrary.Logging;
    using ZetaLongPaths;

    public static class CultureHelper
    {
        private static ZlpDirectoryInfo dictionaryBaseFolderPath
        {
            get
            {
                var directory =
                    new ZlpDirectoryInfo(
                        ZlpPathHelper.Combine(
                            ZlpPathHelper.GetDirectoryPathNameFromFilePath(
                                Assembly.GetEntryAssembly()?.Location),
                            @"Dictionaries"));

                return directory;
            }
        }

        private class CacheItem
        {
            public bool Available { get; set; }

            public string DictionaryFilePath { get; set; }
            public string GrammarFilePath { get; set; }
        }

        private static readonly Dictionary<CultureInfo, CacheItem> Cache =
            new();

        public static bool HasDictionariesForCulture(
            CultureInfo culture,
            out string dictionaryFilePath,
            out string grammarFilePath)
        {
            if (!Cache.TryGetValue(culture, out var cacheItem))
            {
                cacheItem = doHasDictionariesForCulture(culture);
                Cache[culture] = cacheItem;
            }

            dictionaryFilePath = cacheItem.DictionaryFilePath;
            grammarFilePath = cacheItem.GrammarFilePath;
            return cacheItem.Available;
        }

        private static CacheItem doHasDictionariesForCulture(
            CultureInfo culture)
        {
            var fileNames = getAllCompleteCultureFileNames();
            var cultureName = culture.Name;
            var cultureNameShort = culture.Name.Substring(0, 2);

            // --
            // First pass: direct match.

            foreach (var fileName in fileNames)
            {
                var normalizedFileName = fileName.Replace(@"_", @"-");

                if (string.Equals(
                    cultureName,
                    normalizedFileName,
                    StringComparison.InvariantCultureIgnoreCase))
                {
                    return
                        new CacheItem
                        {
                            Available = true,
                            DictionaryFilePath =
                                ZlpPathHelper.Combine(dictionaryBaseFolderPath.FullName, fileName + @".dic"),
                            GrammarFilePath =
                                ZlpPathHelper.Combine(dictionaryBaseFolderPath.FullName, fileName + @".aff")
                        };
                }
            }

            // --
            // Second pass: base match.

            foreach (var fileName in fileNames)
            {
                if (fileName.Length >= 2)
                {
                    var normalizedFileName = fileName.Substring(0, 2);

                    if (string.Equals(
                        cultureNameShort,
                        normalizedFileName,
                        StringComparison.InvariantCultureIgnoreCase))
                    {
                        return
                            new CacheItem
                            {
                                Available = true,
                                DictionaryFilePath = ZlpPathHelper.Combine(dictionaryBaseFolderPath.FullName,
                                    fileName + @".dic"),
                                GrammarFilePath = ZlpPathHelper.Combine(dictionaryBaseFolderPath.FullName,
                                    fileName + @".aff")
                            };
                    }
                }
            }

            // --
            // Not found.

            return
                new CacheItem
                {
                    Available = false
                };
        }

        private static string[] getAllCompleteCultureFileNames()
        {
            var result = new List<string>();

            if (dictionaryBaseFolderPath.Exists)
            {
                var files =
                    new List<ZlpFileInfo>(dictionaryBaseFolderPath.GetFiles());

                // ReSharper disable LoopCanBeConvertedToQuery
                foreach (var file in files)
                    // ReSharper restore LoopCanBeConvertedToQuery
                {
                    if (file.Extension.Equals(
                            @".dic",
                            StringComparison.InvariantCultureIgnoreCase) &&
                        files.Find(
                            x => x.Extension.Equals(
                                @".aff",
                                StringComparison.InvariantCultureIgnoreCase)) != null)
                    {
                        result.Add(ZlpPathHelper.GetFileNameWithoutExtension(file.Name));
                    }
                }

                result.Sort();
            }

            return result.ToArray();
        }

        /*
                public static SpellCheckerOpenOfficeDictionary[] GetAllDictionaries()
                {
                    var result = new List<SpellCheckerOpenOfficeDictionary>();

                    var fileNames = getAllCompleteCultureFileNames();

                    foreach ( var fileName in fileNames )
                    {
                        var normalizedFileName = fileName.Replace( @"_", @"-" );

                        var dictionary =
                            new SpellCheckerOpenOfficeDictionary
                                {
                                    Culture = CultureInfo.GetCultureInfo( normalizedFileName ),
                                    DictionaryPath = ZlpPathHelper.Combine( dictionaryBaseFolderPath.FullName, fileName + @".dic" ),
                                    GrammarPath = ZlpPathHelper.Combine( dictionaryBaseFolderPath.FullName, fileName + @".aff" )
                                };

                        result.Add( dictionary );
                    }

                    return result.ToArray();
                }
        */

        public static SpellChecker CreateSpellChecker(
            CultureInfo culture)
        {
            if (HasDictionariesForCulture(
                culture,
                out var dictionaryFilePath,
                out var grammarFilePath))
            {
                Trace.WriteLine(
                    $@"Using spell checker with culture '{culture}'.");

                // http://www.devexpress.com/Help/?document=XtraSpellChecker/CustomDocument3158.htm&levelup=true.
                var spellChecker =
                    new SpellChecker
                    {
                        Culture = culture,
                        SpellCheckMode = SpellCheckMode.AsYouType,
                    };
                spellChecker.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;

                var dictionary =
                    new SpellCheckerOpenOfficeDictionary
                    {
                        Culture = culture,
                        DictionaryPath = dictionaryFilePath,
                        GrammarPath = grammarFilePath
                    };
                spellChecker.Dictionaries.Add(dictionary);

                return spellChecker;
            }
            else
            {
                Trace.WriteLine(
                    $@"No spell checker with culture '{culture}' because no dictionaries available.");

                return null;
            }
        }

        #region Public methods.

        // ------------------------------------------------------------------

        /// <summary>
        /// Gets the name of the supported UI culture from two letter windows 
        /// language.
        /// </summary>
        /// <param name="twoLetterWindowsLanguageName">Name of the two letter 
        /// windows language.</param>
        /// <returns></returns>
        public static CultureInfo
            GetSupportedUICultureFromTwoLetterWindowsLanguageName(
                string twoLetterWindowsLanguageName)
        {
            return doGetCultureFromTwoLetterWindowsLanguageName(
                SupportedUICultures,
                twoLetterWindowsLanguageName);
        }

        /// <summary>
        /// Gets the name of the supported UI culture from three letter windows 
        /// language.
        /// </summary>
        /// <param name="threeLetterWindowsLanguageName">Name of the three letter 
        /// windows language.</param>
        /// <returns></returns>
        public static CultureInfo
            GetSupportedUICultureFromThreeLetterWindowsLanguageName(
                string threeLetterWindowsLanguageName)
        {
            return doGetCultureFromThreeLetterWindowsLanguageName(
                SupportedUICultures,
                threeLetterWindowsLanguageName);
        }

        /// <summary>
        /// Put the culture info to all threads and Windows Forms.
        /// </summary>
        /// <param name="cultureInfo">The culture info.</param>
        public static void ApplyCultureToAllUIElements(
            CultureInfo cultureInfo)
        {
            LogCentral.Current.LogInfo(
                $@"Applying culture '{cultureInfo.Name}' to all UI elements.");

            Thread.CurrentThread.CurrentCulture =
                Thread.CurrentThread.CurrentUICulture =
                    Application.CurrentCulture =
                        cultureInfo;
        }

        /// <summary>
        /// Lookup a matching (if any).
        /// </summary>
        public static CultureInfo GetMatchingCulture(
            CultureInfo[] cultureInfos,
            CultureInfo cultureInfoToMatch)
        {
            if (cultureInfos == null || cultureInfos.Length <= 0)
            {
                return null;
            }
            else
            {
                foreach (var ci in cultureInfos)
                {
                    // 2007-11-26, only compare the first TWO, to allow
                    // e.g. Austria (DEA) to still load German.
                    if (string.Compare(ci.TwoLetterISOLanguageName, cultureInfoToMatch.TwoLetterISOLanguageName,
                        StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        return ci;
                    }
                }

                // Fallback.
                return cultureInfos[0];
            }
        }

        public static string GetSupportedLanguage3(CultureInfo cultureInfo)
        {
            var twoLetterWindowsLanguageName =
                cultureInfo.Name.Substring(0, 2);

            foreach (var ci in SupportedUICultures)
            {
                var l2 = ci.Name.Substring(0, 2);

                // 2007-11-26, only compare the first TWO, to allow
                // e.g. Austria (DEA) to still load German.
                if (string.Compare(l2, twoLetterWindowsLanguageName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return ci.ThreeLetterWindowsLanguageName;
                }
            }

            // Fallback.
            return SupportedUICultures[0].ThreeLetterWindowsLanguageName;
        }

        // ------------------------------------------------------------------

        #endregion

        #region Private methods.

        // ------------------------------------------------------------------

        private static CultureInfo
            doGetCultureFromTwoLetterWindowsLanguageName(
                IList<CultureInfo> cultureToSearchIn,
                string twoLetterWindowsLanguageName)
        {
            if (twoLetterWindowsLanguageName.Length != 2)
            {
                throw new ArgumentException();
            }
            else
            {
                foreach (var ci in cultureToSearchIn)
                {
                    if (string.Compare(ci.TwoLetterISOLanguageName, twoLetterWindowsLanguageName,
                        StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        return ci;
                    }
                }

                // Fallback.
                return cultureToSearchIn[0];
            }
        }

        private static CultureInfo
            doGetCultureFromThreeLetterWindowsLanguageName(
                IList<CultureInfo> cultureToSearchIn,
                string threeLetterWindowsLanguageName)
        {
            if (threeLetterWindowsLanguageName.Length != 3)
            {
                throw new ArgumentException();
            }
            else
            {
                var twoLetterWindowsLanguageName =
                    threeLetterWindowsLanguageName.Substring(0, 2);

                foreach (var ci in cultureToSearchIn)
                {
                    // 2007-11-26, only compare the first TWO, to allow
                    // e.g. Austria (DEA) to still load German.
                    if (string.Compare(ci.TwoLetterISOLanguageName, twoLetterWindowsLanguageName,
                        StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        return ci;
                    }
                }

                // Fallback.
                return cultureToSearchIn[0];
            }
        }

        // ------------------------------------------------------------------

        #endregion

        #region Public properties.

        // ------------------------------------------------------------------

        /// <summary>
        /// Returns the UI cultures that are supported by Zeta Resource Editor.
        /// (I.e. dialogs, menus, messages, etc).
        /// </summary>
        public static CultureInfo[] SupportedUICultures
        {
            get
            {
                var result =
                    new List<CultureInfo>
                    {
                        new(@"en-US"),
                        new(@"de-DE")
                        // Add more as they become available.
                    };

                return result.ToArray();
            }
        }

        // ------------------------------------------------------------------

        #endregion

        public static CultureInfo CreateCultureErrorTolerant(string languageCode)
        {
            var cultureInfos = CultureInfo.GetCultures(CultureTypes.AllCultures);

            // First-pass, normal check.
            foreach (var culture in cultureInfos)
            {
                if (string.Compare(languageCode, culture.Name, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return culture;
                }
            }

            // Second-pass, chinese special.
            foreach (var culture in cultureInfos)
            {
                if (languageCode.StartsWith(@"zh-") && culture.Name.StartsWith(@"zh-"))
                {
                    return culture;
                }
            }

            // Third-pass, first two.
            var l2 = languageCode.Substring(0, 2).ToLowerInvariant();
            foreach (var culture in cultureInfos)
            {
                if (culture.Name.StartsWith(l2, StringComparison.InvariantCultureIgnoreCase))
                {
                    return culture;
                }
            }

            // Fourth-pass, first last two.
            foreach (var culture in cultureInfos)
            {
                if (culture.Name.EndsWith(l2, StringComparison.InvariantCultureIgnoreCase))
                {
                    return culture;
                }
            }

            // Fallback.
            return CultureInfo.CreateSpecificCulture(languageCode);
        }
    }
}