namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation.Google
{
    using Newtonsoft.Json;
    using Properties;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Xml;
    using WebServices;
    using Zeta.VoyagerLibrary.Common.Collections;

    public class GoogleRestfulTranslationEngine :
        ITranslationEngine
    {
        bool ITranslationEngine.Has2AppIDs => false;

        string ITranslationEngine.AppID1Name => Resources.GoogleRestfulTranslationEngine_AppID1Name_App_ID;

        string ITranslationEngine.AppID2Name => Resources.GoogleRestfulTranslationEngine_AppID1Name_App_ID;

        bool ITranslationEngine.IsUserSelectable => true;

        bool ITranslationEngine.IsDefault => true;

        string ITranslationEngine.UniqueInternalName => @"9efb237c-ce92-450f-9ef1-850091762d63";

        string ITranslationEngine.UserReadableName =>
            Resources.GoogleRestfulTranslationEngine_UserReadableName_Google_Translate;

        bool ITranslationEngine.AreAppIDsSyntacticallyValid(string appID, string appID2)
        {
            return !string.IsNullOrEmpty(appID);
        }

        private static XmlDocument makeRestCallPost(
            string appID,
            string url,
            ICollection<MyTuple<string, string>> parameters)
        {
            if (!url.EndsWith(@"?")) url += @"?";

            parameters.Add(new MyTuple<string, string>(@"key", appID));

            var ps = string.Empty;

            foreach (var pair in parameters)
            {
                if (!string.IsNullOrEmpty(pair.Item2))
                {
                    var p = $@"{pair.Item1}={HttpUtility.UrlEncode(pair.Item2)}&";
                    ps += p;
                }
            }

            ps = ps.TrimEnd('?', '&');

            // --

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Referer = $@"https://www.zeta-resource-editor.com/rest?{Guid.NewGuid():N}";

            WebServiceManager.Current.ApplyProxy(request);

            // Encode all the source data.
            var postSourceData = ps;
            request.Method = @"POST";
            request.ContentType = @"application/x-www-form-urlencoded";
            request.ContentLength = postSourceData.Length;
            request.UserAgent = @"Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";

            // http://code.google.com/intl/de/apis/language/translate/v2/using_rest.html
            request.Headers.Add(@"X-HTTP-Method-Override", @"GET");

            var writeStream = request.GetRequestStream();
            var bytes = Encoding.UTF8.GetBytes(postSourceData);
            writeStream.Write(bytes, 0, bytes.Length);
            writeStream.Close();

            // --

            string rawResult;

            // If the following fails, you must add this to web.config:
            // <configuration> 
            //		<system.net> 
            //			<settings> 
            //				<httpWebRequest useUnsafeHeaderParsing="true" /> 
            //			</settings> 
            //		</system.net> 
            // </configuration>
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var responseStream = response.GetResponseStream())
            {
                if (responseStream == null)
                {
                    return new XmlDocument();
                }
                else
                {
                    using (var readStream = new StreamReader(responseStream, Encoding.UTF8))
                    {
                        rawResult = readStream.ReadToEnd();
                    }
                }
            }

            return JsonConvert.DeserializeXmlNode(rawResult, @"root");
        }

        private TranslationLanguageInfo[] _sourceLanguages;

        TranslationLanguageInfo[] ITranslationEngine.GetSourceLanguages(string appID, string appID2)
        {
            if (_sourceLanguages == null)
            {
                var result = new List<TranslationLanguageInfo>();

                var json = makeRestCallPost(
                    appID,
                    @"https://www.googleapis.com/language/translate/v2/languages",
                    new List<MyTuple<string, string>>());

                // --

                var nodes = json.SelectNodes(@"/root/data/languages/language");

                if (nodes != null)
                {
                    // ReSharper disable LoopCanBeConvertedToQuery
                    foreach (XmlNode xmlNode in nodes)
                    // ReSharper restore LoopCanBeConvertedToQuery
                    {
                        var languageCode = xmlNode.InnerText;
                        var ci = IntelligentGetCultureInfo(languageCode);

                        if (ci != null)
                        {
                            result.Add(
                                new TranslationLanguageInfo
                                {
                                    LanguageCode = languageCode,
                                    UserReadableName = ci.DisplayName,
                                });
                        }
                    }
                }

                _sourceLanguages = result.ToArray();
            }

            return _sourceLanguages;
        }

        private static CultureInfo IntelligentGetCultureInfo(string iso6391Code)
        {
            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (var cultureInfo in CultureInfo.GetCultures(CultureTypes.AllCultures))
            // ReSharper restore LoopCanBeConvertedToQuery
            {
                if (string.Compare(iso6391Code, cultureInfo.TwoLetterISOLanguageName,
                        StringComparison.OrdinalIgnoreCase) == 0 ||
                    string.Compare(iso6391Code, cultureInfo.Name, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return cultureInfo;
                }
            }

            return null;
        }

        TranslationLanguageInfo[] ITranslationEngine.GetDestinationLanguages(string appID, string appID2)
        {
            return ((ITranslationEngine)this).GetSourceLanguages(appID, appID2);
        }

        int ITranslationEngine.MaxArraySize => 25;

        string ITranslationEngine.AppIDLink => @"https://zeta.li/zre-translation-appid-google";

        string[] ITranslationEngine.TranslateArray(
            string appID,
            string appID2,
            string[] texts,
            string sourceLanguageCode,
            string destinationLanguageCode,
            string[] wordsToProtect,
            string[] wordsToRemove)
        {
            var dic =
                new List<MyTuple<string, string>>
                {
                    new MyTuple<string, string>(@"source", sourceLanguageCode),
                    new MyTuple<string, string>(@"target", destinationLanguageCode),
                };

            var protectionResults = new List<TranslationHelper.ProtectionResult>();

            foreach (var text in texts)
            {
                var removed = TranslationHelper.RemoveWords(
                    text,
                    wordsToRemove);

                var preparedText = TranslationHelper.ProtectWords(new TranslationHelper.ProtectionInfo
                {
                    UnprotectedText = removed,
                    WordsToProtect = wordsToProtect
                });

                protectionResults.Add(preparedText);

                dic.Add(new MyTuple<string, string>(@"q", preparedText.ProtectedText));
            }

            var json = makeRestCallPost(appID, @"https://www.googleapis.com/language/translate/v2", dic);

            // --

            var result = new List<string>();

            var nodes = json.SelectNodes(@"/root/data/translations/translatedText");

            if (nodes != null)
            {
                // Sum up all mappings.
                var dicDic = TranslationHelper.JoinUnprotectedToProtectedMapping(protectionResults);

                foreach (XmlNode xmlNode in nodes)
                {
                    var translatedText = xmlNode.InnerText;

                    result.Add(
                        TranslationHelper.UnprotectWords(
                            new TranslationHelper.ProtectionResult
                            {
                                ProtectedText = translatedText,
                                WordsToProtect = wordsToProtect,
                                UnprotectedToProtectedMapping = dicDic
                            }
                        ).UnprotectedText);
                }
            }

            return result.ToArray();
        }

        bool ITranslationEngine.IsSourceLanguageSupported(string appID, string appID2, string languageCode)
        {
            return TranslationHelper.IsSupportedLanguage(languageCode,
                ((ITranslationEngine)this).GetSourceLanguages(appID, appID2));
        }

        bool ITranslationEngine.IsDestinationLanguageSupported(string appID, string appID2, string languageCode)
        {
            return TranslationHelper.IsSupportedLanguage(languageCode,
                ((ITranslationEngine)this).GetDestinationLanguages(appID, appID2));
        }

        string ITranslationEngine.MapCultureToSourceLanguageCode(string appID, string appID2, CultureInfo cultureInfo)
        {
            return TranslationHelper.DoMapCultureToLanguageCode(
                ((ITranslationEngine)this).GetSourceLanguages(appID, appID2), cultureInfo);
        }

        string ITranslationEngine.MapCultureToDestinationLanguageCode(string appID, string appID2,
            CultureInfo cultureInfo)
        {
            return TranslationHelper.DoMapCultureToLanguageCode(
                ((ITranslationEngine)this).GetDestinationLanguages(appID, appID2), cultureInfo);
        }

        string ITranslationEngine.Translate(
            string appID,
            string appID2,
            string text,
            string sourceLanguageCode,
            string destinationLanguageCode,
            string[] wordsToProtect,
            string[] wordsToRemove)
        {
            var removed = TranslationHelper.RemoveWords(
                text,
                wordsToRemove);

            var prot = TranslationHelper.ProtectWords(
                new TranslationHelper.ProtectionInfo
                {
                    UnprotectedText = removed,
                    WordsToProtect = wordsToProtect
                });

            var json =
                makeRestCallPost(
                    appID,
                    @"https://www.googleapis.com/language/translate/v2",
                    new List<MyTuple<string, string>>
                    {
                        new MyTuple<string, string>(@"source", sourceLanguageCode),
                        new MyTuple<string, string>(@"target", destinationLanguageCode),
                        new MyTuple<string, string>(@"q", prot.ProtectedText)
                    });

            var translatedTextNode = json.SelectSingleNode(@"/root/data/translations/translatedText");

            var translation = translatedTextNode?.InnerText ?? string.Empty;

            var protres = new TranslationHelper.ProtectionResult
            {
                ProtectedText = translation,
                UnprotectedToProtectedMapping = prot.UnprotectedToProtectedMapping,
                WordsToProtect = prot.WordsToProtect
            };

            var unprot = TranslationHelper.UnprotectWords(protres);
            return unprot.UnprotectedText;
        }

        public bool SupportsArrayTranslation => true;
    }
}