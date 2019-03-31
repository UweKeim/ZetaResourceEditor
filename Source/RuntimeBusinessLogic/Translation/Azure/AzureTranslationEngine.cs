namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation.Azure
{
    using AsyncBridge;
    using Language;
    using MoreLinq;
    using Properties;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Web;
    using System.Xml.Linq;
    using ZetaLongPaths;

    // Beispiele siehe:
    //
    // - https://github.com/MicrosoftTranslator
    // - https://github.com/MicrosoftTranslator/HTTP-Code-Samples
    // - https://github.com/MicrosoftTranslator/HTTP-Code-Samples/tree/master/CSharp

    public sealed class AzureTranslationEngine :
        ITranslationEngine
    {
        string ITranslationEngine.AppID1Name => Resources.BingSoapTranslationEngine_AppID2Name_Client_secret;
        bool ITranslationEngine.IsAppIDMultiLine => false;
        bool ITranslationEngine.IsJson => false;
        bool ITranslationEngine.IsDefault => false;
        string ITranslationEngine.UniqueInternalName => @"1e8232f6-d1ee-4b22-8b78-2c8a01a17a0a";
        string ITranslationEngine.UserReadableName => "Microsoft Translator (Azure)";
        bool ITranslationEngine.SupportsArrayTranslation => true;
        int ITranslationEngine.MaxArraySize => 25;
        public string AppIDLink => @"https://zeta.li/zre-translation-appid-bing";

        bool ITranslationEngine.AreAppIDsSyntacticallyValid(string appID) =>
            !string.IsNullOrEmpty(appID);

        TranslationLanguageInfo[] ITranslationEngine.GetSourceLanguages(string appID)
        {
            return ZlpSimpleFileAccessProtector.Protect(
                delegate
                {
                    const string uri = @"https://api.microsofttranslator.com/v2/Http.svc/GetLanguagesForTranslate";

                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
                    httpWebRequest.Headers.Add(@"Authorization", getAuthToken(appID));
                    using (var response = httpWebRequest.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        var dcs = new DataContractSerializer(typeof(List<string>));
                        var languagesForTranslate = ((List<string>)dcs.ReadObject(stream)).ToHashSet();

                        return languagesForTranslate
                            .Select(l =>
                                new TranslationLanguageInfo
                                {
                                    LanguageCode = l,
                                    UserReadableName = tryGetLanguageName(l)
                                }).ToArray();
                    }
                });
        }

        private string tryGetLanguageName(string s)
        {
            return CultureHelper.CreateCultureErrorTolerant(s).DisplayName;
        }

        private string getAuthToken(string appID)
        {
            var authTokenSource = new AzureAuthToken(appID.Trim());
            var authToken = string.Empty;

            // https://github.com/tejacques/AsyncBridge#example-usage
            using (var A = AsyncHelper.Wait)
            {
                A.Run(authTokenSource.GetAccessTokenAsync(), res => authToken = res);
            }

            return authToken;
        }

        TranslationLanguageInfo[] ITranslationEngine.GetDestinationLanguages(string appID)
        {
            return ((ITranslationEngine)this).GetSourceLanguages(appID);
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
            return ZlpSimpleFileAccessProtector.Protect(
                delegate
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

                    var uri =
                        $@"https://api.microsofttranslator.com/v2/Http.svc/Translate?text={HttpUtility.UrlEncode(prot.ProtectedText)}&from={
                                sourceLanguageCode
                            }&to={destinationLanguageCode}";

                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
                    httpWebRequest.Headers.Add(@"Authorization", getAuthToken(appID));
                    using (var response = httpWebRequest.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        var dcs = new DataContractSerializer(typeof(string));
                        var translation = (string)dcs.ReadObject(stream);

                        var protres = new TranslationHelper.ProtectionResult
                        {
                            ProtectedText = translation,
                            UnprotectedToProtectedMapping = prot.UnprotectedToProtectedMapping,
                            WordsToProtect = prot.WordsToProtect
                        };

                        var unprot = TranslationHelper.UnprotectWords(protres);
                        return unprot.UnprotectedText;
                    }
                });
        }

        string[] ITranslationEngine.TranslateArray(
            string appID,
            string[] texts,
            string sourceLanguageCode,
            string destinationLanguageCode,
            string[] wordsToProtect,
            string[] wordsToRemove)
        {
            return ZlpSimpleFileAccessProtector.Protect(
                delegate
                {
                    const string uri = @"https://api.microsofttranslator.com/v2/Http.svc/TranslateArray";

                    var body = @"<TranslateArrayRequest>" +
                               @"<AppId />" +
                               $@"<From>{sourceLanguageCode}</From>" +
                               @"<Options>" +
                               @" <Category xmlns=""http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2"" />" +
                               @"<ContentType xmlns=""http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2"">text/plain</ContentType>" +
                               @"<ReservedFlags xmlns=""http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2"" />" +
                               @"<State xmlns=""http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2"" />" +
                               @"<Uri xmlns=""http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2"" />" +
                               @"<User xmlns=""http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2"" />" +
                               @"</Options>" +
                               @"<Texts>";

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

                        var esc = escapeXml(preparedText.ProtectedText);

                        body +=
                            $@"<string xmlns=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"">{esc}</string>";
                    }

                    body +=
                        @"</Texts>" +
                        $@"<To>{destinationLanguageCode}</To>" +
                        @"</TranslateArrayRequest>";

                    using (var client = new HttpClient())
                    using (var request = new HttpRequestMessage())
                    {
                        request.Method = HttpMethod.Post;
                        request.RequestUri = new Uri(uri);
                        request.Content = new StringContent(body, Encoding.UTF8, @"text/xml");
                        request.Headers.Add(@"Authorization", getAuthToken(appID));

                        HttpResponseMessage response = null;
                        string responseBody = null;

                        // https://github.com/tejacques/AsyncBridge#example-usage
                        using (var A = AsyncHelper.Wait)
                        {
                            A.Run(client.SendAsync(request), res => response = res);
                        }

                        using (var A = AsyncHelper.Wait)
                        {
                            A.Run(response?.Content.ReadAsStringAsync(), res => responseBody = res);
                        }

                        if (response == null) throw new HttpException();

                        switch (response?.StatusCode)
                        {
                            case HttpStatusCode.OK:
                                var doc = XDocument.Parse(responseBody);
                                var ns = XNamespace.Get(
                                    @"http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2");

                                var result = new List<string>();

                                // Sum up all mappings.
                                var dic = TranslationHelper.JoinUnprotectedToProtectedMapping(protectionResults);

                                foreach (var xe in doc.Descendants(ns + @"TranslateArrayResponse"))
                                {
                                    result.AddRange(xe.Elements(ns + @"TranslatedText").Select(node => TranslationHelper
                                        .UnprotectWords(
                                            new TranslationHelper.ProtectionResult
                                            {
                                                ProtectedText = node.Value,
                                                WordsToProtect = wordsToProtect,
                                                UnprotectedToProtectedMapping = dic
                                            }
                                        ).UnprotectedText));
                                }

                                return result.ToArray();

                            default:
                                throw new HttpException((int)response.StatusCode, responseBody);
                        }
                    }
                });
        }

        private static string escapeXml(string text)
        {
            // http://stackoverflow.com/a/1091953/107625

            if (string.IsNullOrEmpty(text)) return text;

            return text
                .Replace(@"""", @"&quot;")
                .Replace(@"'", @"&apos;")
                .Replace(@"<", @"&lt;")
                .Replace(@">", @"&gt;")
                .Replace(@"&", @"&amp;");
        }
    }
}