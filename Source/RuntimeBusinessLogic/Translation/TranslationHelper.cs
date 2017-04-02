namespace ZetaResourceEditor.RuntimeBusinessLogic.Translation
{
	using System;
	using System.Collections.Generic;
	using Language;
	using Projects;
	using Runtime;

	public static class TranslationHelper
	{
		public static bool IsSupportedLanguage(
			string languageCode,
			TranslationLanguageInfo[] languageInfos)
		{
			var ci = CultureHelper.CreateCultureErrorTolerant(languageCode);

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var translationLanguageInfo in languageInfos)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				if (string.Compare(translationLanguageInfo.LanguageCode, ci.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase) == 0 ||
					string.Compare(CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode).Name, ci.Name, StringComparison.OrdinalIgnoreCase) == 0 ||
					string.Compare(CultureHelper.CreateCultureErrorTolerant(translationLanguageInfo.LanguageCode).Name.Substring(0, 2), ci.Name.Substring(0, 2), StringComparison.OrdinalIgnoreCase) == 0)
				{
					return true;
				}
			}

			return false;
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
				var r = new List<string>();

				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var text in texts)
				// ReSharper restore LoopCanBeConvertedToQuery
				{
					r.Add(RemoveWords(text, wordsToRemove));
				}

				return r.ToArray();
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
				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var word in wordsToRemove)
				// ReSharper restore LoopCanBeConvertedToQuery
				{
					text = text.Replace(word, string.Empty);
				}

				return text;
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
				var r = new List<string>();

				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var text in texts)
				// ReSharper restore LoopCanBeConvertedToQuery
				{
					r.Add(ProtectWords(text, wordsToProtect));
				}

				return r.ToArray();
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
				return text/*.Replace(@"  ", @" ").Replace(@"  ", @" ")*/;
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
							if (string.Compare(uid, engine.UniqueInternalName, StringComparison.OrdinalIgnoreCase) == 0)
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
				string r;
				if ( dic.TryGetValue(key, out r))
				{
					return r;
				}
				else
				{
					return null;
				}
			}
		}

		public static readonly ITranslationEngine[] Engines =
			new ITranslationEngine[]
				{
					new BingSoapTranslationEngine(),
					new GoogleRestfulTranslationEngine()
				};
	}
}