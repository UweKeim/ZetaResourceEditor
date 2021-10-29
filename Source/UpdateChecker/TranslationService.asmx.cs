namespace UpdateChecker;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using Code;
using Zeta.VoyagerLibrary.Logging;

/////////////////////////////////////////////////////////////////////////////

[WebService(Namespace = @"http://www.zeta-resource-editor.com/")] // ACHTUNG! HIER _NICHT_ HTTPS machen.
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
    {
        //new TranslationMode3(@"auto"),
        new(@"af"),
        new(@"sq"),
        new(@"am"),
        new(@"ar"),
        new(@"hy"),
        new(@"az"),
        new(@"eu"),
        new(@"be"),
        new(@"bn"),
        new(@"bh"),
        new(@"bg"),
        new(@"my"),
        new(@"ca"),
        new(@"chr"),
        new(@"zh"),
        new(@"zh-CN"),
        new(@"zh-TW"),
        new(@"hr"),
        new(@"cs"),
        new(@"da"),
        new(@"dv"),
        new(@"nl"),
        new(@"en"),
        new(@"eo"),
        new(@"et"),
        new(@"tl"),
        new(@"fi"),
        new(@"fr"),
        new(@"gl"),
        new(@"ka"),
        new(@"de"),
        new(@"el"),
        new(@"gn"),
        new(@"gu"),
        new(@"iw"),
        new(@"hi"),
        new(@"hu"),
        new(@"is"),
        new(@"id"),
        new(@"iu"),
        new(@"ga"),
        new(@"it"),
        new(@"ja"),
        new(@"kn"),
        new(@"kk"),
        new(@"km"),
        new(@"ko"),
        new(@"ku"),
        new(@"ky"),
        new(@"lo"),
        new(@"lv"),
        new(@"lt"),
        new(@"mk"),
        new(@"ms"),
        new(@"ml"),
        new(@"mt"),
        new(@"mr"),
        new(@"mn"),
        new(@"ne"),
        new(@"no"),
        new(@"or"),
        new(@"ps"),
        new(@"fa"),
        new(@"pl"),
        new(@"pt-PT"),
        new(@"pa"),
        new(@"ro"),
        new(@"ru"),
        new(@"sa"),
        new(@"sr"),
        new(@"sd"),
        new(@"si"),
        new(@"sk"),
        new(@"sl"),
        new(@"es"),
        new(@"sw"),
        new(@"sv"),
        new(@"tg"),
        new(@"ta"),
        new(@"tl"),
        new(@"te"),
        new(@"th"),
        new(@"bo"),
        new(@"tr"),
        new(@"uk"),
        new(@"ur"),
        new(@"uz"),
        new(@"ug"),
        new(@"vi"),
        new(@"cy"),
        new(@"yi")
    };

    /// <summary>
    /// See http://code.google.com/intl/en-US/apis/ajaxlanguage/documentation/reference.html#LangNameArray
    /// </summary>
    private readonly TranslationMode3[] _validDestinationTranslationModes =
    {
        new(@"af"),
        new(@"sq"),
        new(@"am"),
        new(@"ar"),
        new(@"hy"),
        new(@"az"),
        new(@"eu"),
        new(@"be"),
        new(@"bn"),
        new(@"bh"),
        new(@"bg"),
        new(@"my"),
        new(@"ca"),
        new(@"chr"),
        new(@"zh"),
        new(@"zh-CN"),
        new(@"zh-TW"),
        new(@"hr"),
        new(@"cs"),
        new(@"da"),
        new(@"dv"),
        new(@"nl"),
        new(@"en"),
        new(@"eo"),
        new(@"et"),
        new(@"tl"),
        new(@"fi"),
        new(@"fr"),
        new(@"gl"),
        new(@"ka"),
        new(@"de"),
        new(@"el"),
        new(@"gn"),
        new(@"gu"),
        new(@"iw"),
        new(@"hi"),
        new(@"hu"),
        new(@"is"),
        new(@"id"),
        new(@"iu"),
        new(@"ga"),
        new(@"it"),
        new(@"ja"),
        new(@"kn"),
        new(@"kk"),
        new(@"km"),
        new(@"ko"),
        new(@"ku"),
        new(@"ky"),
        new(@"lo"),
        new(@"lv"),
        new(@"lt"),
        new(@"mk"),
        new(@"ms"),
        new(@"ml"),
        new(@"mt"),
        new(@"mr"),
        new(@"mn"),
        new(@"ne"),
        new(@"no"),
        new(@"or"),
        new(@"ps"),
        new(@"fa"),
        new(@"pl"),
        new(@"pt-PT"),
        new(@"pa"),
        new(@"ro"),
        new(@"ru"),
        new(@"sa"),
        new(@"sr"),
        new(@"sd"),
        new(@"si"),
        new(@"sk"),
        new(@"sl"),
        new(@"es"),
        new(@"sw"),
        new(@"sv"),
        new(@"tg"),
        new(@"ta"),
        new(@"tl"),
        new(@"te"),
        new(@"th"),
        new(@"bo"),
        new(@"tr"),
        new(@"uk"),
        new(@"ur"),
        new(@"uz"),
        new(@"ug"),
        new(@"vi"),
        new(@"cy"),
        new(@"yi")
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