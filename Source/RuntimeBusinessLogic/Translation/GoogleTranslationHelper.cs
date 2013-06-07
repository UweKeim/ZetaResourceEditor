namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation
{
	internal class GoogleTranslationHelper
	{
//        private TranslationLanguageInfo[] _sourceLanguages;
//        private TranslationLanguageInfo[] _destinationLanguages;

//        public TranslationLanguageInfo[] GetSourceLanguages()
//        {
//            if (_sourceLanguages == null)
//            {
//                var modes = WebServiceManager.Current.TranslationWS.GetAllSourceTranslationModes();

//                var s = new List<TranslationLanguageInfo>();

//// ReSharper disable LoopCanBeConvertedToQuery
//                foreach (var mode in modes)
//// ReSharper restore LoopCanBeConvertedToQuery
//                {
//                    s.Add(new TranslationLanguageInfo
//                            {
//                                UserReadableName = CultureInfo.GetCultureInfo(mode.LanguageCode).DisplayName,
//                                LanguageCode = mode.LanguageCode
//                            });
//                }

//                _sourceLanguages = s.ToArray();
//            }

//            return _sourceLanguages;
//        }

//        public TranslationLanguageInfo[] GetDestinationLanguages()
//        {
//            if (_destinationLanguages == null)
//            {
//                var modes = WebServiceManager.Current.TranslationWS.GetAllDestinationTranslationModes();

//                var s = new List<TranslationLanguageInfo>();

//// ReSharper disable LoopCanBeConvertedToQuery
//                foreach (var mode in modes)
//// ReSharper restore LoopCanBeConvertedToQuery
//                {
//                    s.Add(new TranslationLanguageInfo
//                            {
//                                UserReadableName = CultureInfo.GetCultureInfo(mode.LanguageCode).DisplayName,
//                                LanguageCode = mode.LanguageCode
//                            });
//                }

//                _destinationLanguages = s.ToArray();
//            }

//            return _destinationLanguages;
//        }

		//public string MapCultureToSourceLanguageCode(
		//    CultureInfo cultureInfo)
		//{
		//    return doMapCultureToLanguageCode(GetSourceLanguages(), cultureInfo);
		//}

		//public string MapCultureToDestinationLanguageCode(
		//    CultureInfo cultureInfo)
		//{
		//    return doMapCultureToLanguageCode(GetDestinationLanguages(), cultureInfo);
		//}

		//private static string doMapCultureToLanguageCode(
		//    TranslationLanguageInfo[] availableLanguageInfos,
		//    CultureInfo cultureInfo)
		//{
		//    foreach (var translationLanguageInfo in availableLanguageInfos)
		//    {
		//        if (string.Compare(
		//            translationLanguageInfo.LanguageCode,
		//            cultureInfo.Name,
		//            StringComparison.OrdinalIgnoreCase) == 0)
		//        {
		//            return translationLanguageInfo.LanguageCode;
		//        }
		//    }

		//    // --
		//    // Not found, second pass with short name.

		//    foreach (var translationLanguageInfo in availableLanguageInfos)
		//    {
		//        // Fixes http://www.codeproject.com/Messages/3537391/Excelent-tool-Having-issues-from-english-to-Chines.aspx
		//        if (translationLanguageInfo.LanguageCode.StartsWith(
		//            cultureInfo.Name,
		//            StringComparison.InvariantCultureIgnoreCase) ||
		//            cultureInfo.Name.StartsWith(
		//                translationLanguageInfo.LanguageCode,
		//                StringComparison.InvariantCultureIgnoreCase))
		//        {
		//            return translationLanguageInfo.LanguageCode;
		//        }
		//    }

		//    // --

		//    throw new Exception(
		//        string.Format(
		//            Resources.GoogleTranslationHelper_doMapCultureToLanguageCode_Google_does_not_provide_a_language_code_for_the_culture___0___to_translate_,
		//            BingSoapTranslationEngine.PrettyPrint(cultureInfo)));
		//}
	}
}