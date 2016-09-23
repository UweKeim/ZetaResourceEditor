namespace UpdateChecker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Services;
    using Code;
    using Zeta.VoyagerLibrary.Logging;

/////////////////////////////////////////////////////////////////////////////

    [WebService(Namespace = @"http://www.zeta-resource-editor.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class TranslationService :
        ApiKeyProtectedWebServiceBase
    {
        #region Private configuration settings.
        // ----------------------------------------------------------------------

        private const string GoogleUrl = @"http://translate.google.com/translate_t";
        private const string GoogleRefererUrl = @"http://translate.google.com/";
        private const string ParseRegexPattern = @"<input type=hidden name=gtrans value=\""(.*?)\"">"; // AJ CHANGE @"<span.*?id=.{0,1}result_box.{0,1}[^>]*?>(.*?)</span>";
        private const string HttpPostData =
            @"?action=Translate&client=t&hl=en&ie=UTF-8&source={TextToTranslate}&text={TextToTranslate}&langpair={SourceLanguageCode}/{DestinationLanguageCode}&sl={SourceLanguageCode}&tl={DestinationLanguageCode}&old_sl={SourceLanguageCode}&old_tl={DestinationLanguageCode}&old_submit=Translate";

        /// <summary>
        /// See http://code.google.com/intl/en-US/apis/ajaxlanguage/documentation/reference.html#LangNameArray
        /// </summary>
        private readonly TranslationMode3[] _validSourceTranslationModes =
            new[]
            {
                //new TranslationMode3(@"auto"),
                new TranslationMode3(@"af"),
                new TranslationMode3(@"sq"),
                new TranslationMode3(@"am"),
                new TranslationMode3(@"ar"),
                new TranslationMode3(@"hy"),
                new TranslationMode3(@"az"),
                new TranslationMode3(@"eu"),
                new TranslationMode3(@"be"),
                new TranslationMode3(@"bn"),
                new TranslationMode3(@"bh"),
                new TranslationMode3(@"bg"),
                new TranslationMode3(@"my"),
                new TranslationMode3(@"ca"),
                new TranslationMode3(@"chr"),
                new TranslationMode3(@"zh"),
                new TranslationMode3(@"zh-CN"),
                new TranslationMode3(@"zh-TW"),
                new TranslationMode3(@"hr"),
                new TranslationMode3(@"cs"),
                new TranslationMode3(@"da"),
                new TranslationMode3(@"dv"),
                new TranslationMode3(@"nl"),
                new TranslationMode3(@"en"),
                new TranslationMode3(@"eo"),
                new TranslationMode3(@"et"),
                new TranslationMode3(@"tl"),
                new TranslationMode3(@"fi"),
                new TranslationMode3(@"fr"),
                new TranslationMode3(@"gl"),
                new TranslationMode3(@"ka"),
                new TranslationMode3(@"de"),
                new TranslationMode3(@"el"),
                new TranslationMode3(@"gn"),
                new TranslationMode3(@"gu"),
                new TranslationMode3(@"iw"),
                new TranslationMode3(@"hi"),
                new TranslationMode3(@"hu"),
                new TranslationMode3(@"is"),
                new TranslationMode3(@"id"),
                new TranslationMode3(@"iu"),
                new TranslationMode3(@"ga"),
                new TranslationMode3(@"it"),
                new TranslationMode3(@"ja"),
                new TranslationMode3(@"kn"),
                new TranslationMode3(@"kk"),
                new TranslationMode3(@"km"),
                new TranslationMode3(@"ko"),
                new TranslationMode3(@"ku"),
                new TranslationMode3(@"ky"),
                new TranslationMode3(@"lo"),
                new TranslationMode3(@"lv"),
                new TranslationMode3(@"lt"),
                new TranslationMode3(@"mk"),
                new TranslationMode3(@"ms"),
                new TranslationMode3(@"ml"),
                new TranslationMode3(@"mt"),
                new TranslationMode3(@"mr"),
                new TranslationMode3(@"mn"),
                new TranslationMode3(@"ne"),
                new TranslationMode3(@"no"),
                new TranslationMode3(@"or"),
                new TranslationMode3(@"ps"),
                new TranslationMode3(@"fa"),
                new TranslationMode3(@"pl"),
                new TranslationMode3(@"pt-PT"),
                new TranslationMode3(@"pa"),
                new TranslationMode3(@"ro"),
                new TranslationMode3(@"ru"),
                new TranslationMode3(@"sa"),
                new TranslationMode3(@"sr"),
                new TranslationMode3(@"sd"),
                new TranslationMode3(@"si"),
                new TranslationMode3(@"sk"),
                new TranslationMode3(@"sl"),
                new TranslationMode3(@"es"),
                new TranslationMode3(@"sw"),
                new TranslationMode3(@"sv"),
                new TranslationMode3(@"tg"),
                new TranslationMode3(@"ta"),
                new TranslationMode3(@"tl"),
                new TranslationMode3(@"te"),
                new TranslationMode3(@"th"),
                new TranslationMode3(@"bo"),
                new TranslationMode3(@"tr"),
                new TranslationMode3(@"uk"),
                new TranslationMode3(@"ur"),
                new TranslationMode3(@"uz"),
                new TranslationMode3(@"ug"),
                new TranslationMode3(@"vi"),
                new TranslationMode3(@"cy"),
                new TranslationMode3(@"yi")
            };

        /// <summary>
        /// See http://code.google.com/intl/en-US/apis/ajaxlanguage/documentation/reference.html#LangNameArray
        /// </summary>
        private readonly TranslationMode3[] _validDestinationTranslationModes =
            new[]
            {
                new TranslationMode3(@"af"),
                new TranslationMode3(@"sq"),
                new TranslationMode3(@"am"),
                new TranslationMode3(@"ar"),
                new TranslationMode3(@"hy"),
                new TranslationMode3(@"az"),
                new TranslationMode3(@"eu"),
                new TranslationMode3(@"be"),
                new TranslationMode3(@"bn"),
                new TranslationMode3(@"bh"),
                new TranslationMode3(@"bg"),
                new TranslationMode3(@"my"),
                new TranslationMode3(@"ca"),
                new TranslationMode3(@"chr"),
                new TranslationMode3(@"zh"),
                new TranslationMode3(@"zh-CN"),
                new TranslationMode3(@"zh-TW"),
                new TranslationMode3(@"hr"),
                new TranslationMode3(@"cs"),
                new TranslationMode3(@"da"),
                new TranslationMode3(@"dv"),
                new TranslationMode3(@"nl"),
                new TranslationMode3(@"en"),
                new TranslationMode3(@"eo"),
                new TranslationMode3(@"et"),
                new TranslationMode3(@"tl"),
                new TranslationMode3(@"fi"),
                new TranslationMode3(@"fr"),
                new TranslationMode3(@"gl"),
                new TranslationMode3(@"ka"),
                new TranslationMode3(@"de"),
                new TranslationMode3(@"el"),
                new TranslationMode3(@"gn"),
                new TranslationMode3(@"gu"),
                new TranslationMode3(@"iw"),
                new TranslationMode3(@"hi"),
                new TranslationMode3(@"hu"),
                new TranslationMode3(@"is"),
                new TranslationMode3(@"id"),
                new TranslationMode3(@"iu"),
                new TranslationMode3(@"ga"),
                new TranslationMode3(@"it"),
                new TranslationMode3(@"ja"),
                new TranslationMode3(@"kn"),
                new TranslationMode3(@"kk"),
                new TranslationMode3(@"km"),
                new TranslationMode3(@"ko"),
                new TranslationMode3(@"ku"),
                new TranslationMode3(@"ky"),
                new TranslationMode3(@"lo"),
                new TranslationMode3(@"lv"),
                new TranslationMode3(@"lt"),
                new TranslationMode3(@"mk"),
                new TranslationMode3(@"ms"),
                new TranslationMode3(@"ml"),
                new TranslationMode3(@"mt"),
                new TranslationMode3(@"mr"),
                new TranslationMode3(@"mn"),
                new TranslationMode3(@"ne"),
                new TranslationMode3(@"no"),
                new TranslationMode3(@"or"),
                new TranslationMode3(@"ps"),
                new TranslationMode3(@"fa"),
                new TranslationMode3(@"pl"),
                new TranslationMode3(@"pt-PT"),
                new TranslationMode3(@"pa"),
                new TranslationMode3(@"ro"),
                new TranslationMode3(@"ru"),
                new TranslationMode3(@"sa"),
                new TranslationMode3(@"sr"),
                new TranslationMode3(@"sd"),
                new TranslationMode3(@"si"),
                new TranslationMode3(@"sk"),
                new TranslationMode3(@"sl"),
                new TranslationMode3(@"es"),
                new TranslationMode3(@"sw"),
                new TranslationMode3(@"sv"),
                new TranslationMode3(@"tg"),
                new TranslationMode3(@"ta"),
                new TranslationMode3(@"tl"),
                new TranslationMode3(@"te"),
                new TranslationMode3(@"th"),
                new TranslationMode3(@"bo"),
                new TranslationMode3(@"tr"),
                new TranslationMode3(@"uk"),
                new TranslationMode3(@"ur"),
                new TranslationMode3(@"uz"),
                new TranslationMode3(@"ug"),
                new TranslationMode3(@"vi"),
                new TranslationMode3(@"cy"),
                new TranslationMode3(@"yi")
            };

        // ----------------------------------------------------------------------
        #endregion

        #region Public web methods.
        // ----------------------------------------------------------------------

        /// <summary>
        /// Get a list of all valid source translation modes.
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public TranslationMode3[] GetAllSourceTranslationModes()
        {
            try
            {
                return removeInvalidModes(_validSourceTranslationModes);
            }
            catch (Exception x)
            {
                LogCentral.Current.LogError(
                    @"Error getting source translation modes.",
                    x);
                throw;
            }
        }

        private static TranslationMode3[] removeInvalidModes(IEnumerable<TranslationMode3> modes)
        {
            var result = new List<TranslationMode3>(modes);

            result.RemoveAll(
                x => isOf(x,
                    @"am",
                    @"bn",
                    @"bh",
                    @"my",
                    @"chr",
                    @"zh",
                    @"eo",
                    @"tl",
                    @"gn",
                    @"iw",
                    @"iu",
                    @"ga",
                    @"km",
                    @"ku",
                    @"lo",
                    @"ml",
                    @"mt",
                    @"ne",
                    @"or",
                    @"ps",
                    @"sd",
                    @"si",
                    @"tg",
                    @"tl",
                    @"bo",
                    @"ug",
                    @"cy",
                    @"yi"));

            return result.ToArray();
        }

        private static bool isOf(
            TranslationMode3 mode,
            params string[] of)
        {
            return of.Any(o => mode.LanguageCode.Equals(o, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Get a list of all valid destination translation modes.
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public TranslationMode3[] GetAllDestinationTranslationModes()
        {
            try
            {
                return removeInvalidModes(_validDestinationTranslationModes);
            }
            catch (Exception x)
            {
                LogCentral.Current.LogError(
                    @"Error getting destination translation modes.",
                    x);
                throw;
            }
        }

        [WebMethod]
        public SelfTranslationInformation GetSelfTranslationInformation()
        {
            try
            {
                var info =
                    new SelfTranslationInformation
                    {
                        GoogleUrl = GoogleUrl,
                        GoogleRefererUrl = GoogleRefererUrl,
                        ParseRegexPattern = ParseRegexPattern,
                        HttpPostData = HttpPostData
                    };

                return info;
            }
            catch (Exception x)
            {
                LogCentral.Current.LogError(
                    @"Error getting destination self translation information.",
                    x);
                throw;
            }
        }

        // ----------------------------------------------------------------------
        #endregion
    }

/////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// Helper class for details about a translation mode.
    /// </summary>
    public struct TranslationMode3
    {
        #region Public methods.
        // ----------------------------------------------------------------------

        public TranslationMode3(
            string languageCode)
        {
            LanguageCode = languageCode;
        }

        // ----------------------------------------------------------------------
        #endregion

        #region Public variables.
        // ----------------------------------------------------------------------

        public string LanguageCode;

        // ----------------------------------------------------------------------
        #endregion
    }

/////////////////////////////////////////////////////////////////////////////

    public struct SelfTranslationInformation
    {
        public string GoogleUrl;
        public string GoogleRefererUrl;
        public string ParseRegexPattern;
        public string HttpPostData;
    }

/////////////////////////////////////////////////////////////////////////////
}