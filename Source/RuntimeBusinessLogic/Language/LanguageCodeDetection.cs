namespace ZetaResourceEditor.RuntimeBusinessLogic.Language;

#region Using directives.
using DL;
using DynamicSettings;
using FileGroups;
using Projects;
using Properties;
// ----------------------------------------------------------------------
using System.Globalization;
using System.Text.RegularExpressions;

// ----------------------------------------------------------------------
#endregion

/////////////////////////////////////////////////////////////////////////

/// <summary>
/// Methods for dealing with file names.
/// </summary>
public sealed class LanguageCodeDetection
{
    #region Private variables.
    // ------------------------------------------------------------------

    private const string PhBasename = @"[basename]";
    private const string PhLanguagecode = @"[languagecode]";
    private const string PhExtension = @"[extension]";
    private const string PhOptionaltypes = @"[optionaldefaulttypes]";

    // ------------------------------------------------------------------
    #endregion

    #region Public methods and properties.
    // ------------------------------------------------------------------

    public LanguageCodeDetection(
        Project? project)
    {
        Project = project;
    }

    public Project? Project { get; }

    /// <summary>
    /// Gets the base name.
    /// </summary>
    /// <remarks>
    /// E.g. for:
    ///  - Main.master.resx
    ///  - Main.master.de.resx
    ///  - Main.master.en-us.resx
    /// it would be "Main.master"
    /// 
    /// E.g. for:
    ///  - Properties.resx
    ///  - Properties.de.resx
    /// it would be "Properties".
    /// </remarks>
    /// <value>The base name.</value>
    public string? GetBaseName(
        FileGroup fileGroup)
    {
        doGetBaseName(
            fileGroup,
            out var baseName,
            out _,
            out _);
        return baseName;
    }

    public string? GetBaseExtension(
        FileGroup fileGroup)
    {
        doGetBaseName(
            fileGroup,
            out _,
            out var extension,
            out _);
        return extension;
    }

    public string? GetBaseOptionalDefaultType(
        FileGroup fileGroup)
    {
        doGetBaseName(
            fileGroup,
            out _,
            out _,
            out var optionalDefaultType);
        return optionalDefaultType;
    }

    //public string DetectLanguageCodeFromFileName(
    //    string filePath)
    //{
    //    var fileName = Path.GetFileNameWithoutExtension(filePath);

    //    if (fileName.Contains(@"."))
    //    {
    //        var type =
    //            Path.GetExtension(fileName).Trim('.').ToLowerInvariant();

    //        if (IsValidCultureName(type))
    //        {
    //            return type;
    //        }
    //        else
    //        {
    //            return _project == null ? string.Empty : settings.EffectiveNeutralLanguageCode;
    //        }
    //    }
    //    else
    //    {
    //        return _project == null ? string.Empty : settings.EffectiveNeutralLanguageCode;
    //    }
    //}

    public static bool IsValidCultureName(
        string? cultureName)
    {
        if (string.IsNullOrEmpty(cultureName))
        {
            return false;
        }
        else
        {
            if (CultureCache.Contains(cultureName))
            {
                return true;
            }
            else
            {
                // http://www.codeproject.com/Messages/3453976/IsValidCultureName-validation-error.aspx
                if (cultureName.Length > 10 ||
                    string.Compare(cultureName, Resources.SR_CommandProcessorSend_Process_Group, StringComparison.OrdinalIgnoreCase) == 0 ||
                    string.Compare(cultureName, Resources.SR_CommandProcessorSend_Process_Name, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return false;
                }
                else
                {
                    if (isValueCultureName(cultureName, out var longCultureName))
                    {
                        try
                        {
                            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                            if (longCultureName != null)
                            {
	                            CultureInfo.GetCultureInfo(longCultureName);
	                            CultureCache.Add(longCultureName);
                            }

                            return true;
                        }
                        catch (ArgumentException)
                        {
                            // Found no CultureInfo.TryParse, therefore use the catch.
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }

    private static readonly HashSet<string?> CultureCache = new();

    private static bool isValueCultureName(string? cultureName, out string? longCultureName)
    {
        // First, try direct match.
        foreach (var cultureInfo in CultureInfo.GetCultures(CultureTypes.AllCultures))
        {
            if (isCultureMatch(cultureName, cultureInfo, false, out longCultureName))
            {
                return true;
            }
        }

        // Next, try start match.
        foreach (var cultureInfo in CultureInfo.GetCultures(CultureTypes.AllCultures))
        {
            if (isCultureMatch(cultureName, cultureInfo, true, out longCultureName))
            {
                return true;
            }
        }

        // 2022-06-23, Uwe Keim.
        // Fix: "zh-CN" in .NET Core wohl nicht in Liste aber irgendwie trotzdem aufrufbar.
        try
        {
	        if (cultureName != null)
	        {
		        var cultureInfo = CultureInfo.GetCultureInfo(cultureName);
		        if (isCultureMatch(cultureName, cultureInfo, true, out longCultureName))
		        {
			        return true;
		        }
	        }
        }
        catch (Exception x)
        {
            LogCentral.Current.Warn(x, $@"Error creating culture '{cultureName}'.");
        }

        longCultureName = null;
        return false;
    }

    private static bool isCultureMatch(
        string? cultureName,
        CultureInfo cultureInfo,
        bool fuzzy,
        out string? longCultureName)
    {
        if (fuzzy)
        {
            // Same start.
            if (cultureName != null && cultureInfo.Name.StartsWith(cultureName, StringComparison.InvariantCultureIgnoreCase))
            {
                longCultureName = cultureInfo.Name;
                return true;
            }
            else
            {
                longCultureName = null;
                return false;
            }
        }
        else
        {
            if (string.Compare(cultureName, cultureInfo.Name, StringComparison.OrdinalIgnoreCase) == 0)
            {
                longCultureName = cultureInfo.Name;
                return true;
            }
            else
            {
                longCultureName = null;
                return false;
            }
        }
    }

    public CultureInfo DetectCultureFromFileName(
        IInheritedSettings? settings,
        string fileName)
    {
        var culture =
            DetectLanguageCodeFromFileName(
                settings,
                fileName);

        return MakeValidCulture(culture);
    }

    private static readonly Dictionary<string, CultureInfo> CacheForMakeValidCulture =
        new();

    public static CultureInfo MakeValidCulture(
        string? cultureName)
    {
        if (string.IsNullOrEmpty(cultureName))
        {
            throw new ArgumentNullException(nameof(cultureName));
        }

        // --

        if (CacheForMakeValidCulture.TryGetValue(cultureName, out var r))
        {
            return r;
        }
        else
        {
            if (isValueCultureName(cultureName, out var longCultureName))
            {
                var c = CultureHelper.CreateCultureErrorTolerant(longCultureName);

                if (CacheForMakeValidCulture.ContainsKey(cultureName))
                {
                    CacheForMakeValidCulture[cultureName] = c;
                }
                else
                {
                    CacheForMakeValidCulture.Add(cultureName, c);
                }
                return c;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    string.Format(
                        Resources.LanguageCodeDetection_MakeValidCulture_No_culture_for_culture_name___0___available_,
                        cultureName));
            }
        }
    }

    public string? DetectLanguageCodeFromFileName(
        IInheritedSettings? settings,
        string? fileName)
    {
        // Bug_ when no project loaded, therefore create.
        settings ??= Project.Empty;

        // --

        if (string.IsNullOrEmpty(fileName))
        {
            return settings.EffectiveNeutralLanguageCode;
        }
        else
        {
            fileName = ZspPathHelper.GetFileNameFromFilePath(fileName);
            fileName = removeOptionalDefaultTypes(settings, fileName, null);

            // Check for non-neutral, first.
            return IsNonNeutralLanguageFileName(settings, fileName)
                ? extractBlock(settings, fileName, PhLanguagecode)
                : settings.EffectiveNeutralLanguageCode;
        }
    }

    //CHANGED extract language string inside next to last point delimited part
    //returns culture string like de-DE or null or empty if neutral file guessed
    public static string? GetLanguageCodeFromFileNameSuffix(
        IInheritedSettings? settings,
        string? fileName
    )
    {
        var cultureString = string.Empty;
        if (string.IsNullOrEmpty(fileName))
        {
            return null; //no suffix found
        }
        else
        {
            fileName = ZspPathHelper.GetFileNameFromFilePath(fileName);
            fileName = ZspPathHelper.GetFileNameWithoutExtension(fileName);
            fileName = removeOptionalDefaultTypes(settings, fileName, null);

            var baseName = fileName?.ToLowerInvariant();

            if (!string.IsNullOrEmpty(baseName) && fileName != null)
            {
	            var pPos = fileName.LastIndexOf('.');
	            if (pPos > -1 && pPos < fileName.Length - 1)
	            {
		            var possibleCulture = fileName.Substring(pPos + 1);
		            if (!string.IsNullOrEmpty(possibleCulture))
		            {
			            if (IsValidCultureName(possibleCulture))
			            {
				            cultureString = fileName.Substring(pPos + 1);
			            }
		            }
	            }
            }
        }
        return cultureString;
    }

    //CHANGED extract language string inside next to last point delimited part
    //returns culture string like de-DE or null or empty if neutral file guessed
    public static string? GetBaseName(
        IInheritedSettings? settings,
        string fileName
    )
    {
        return extractBlock(settings, fileName, PhBasename);
    }

    public static string? GetExtension(
        IInheritedSettings? settings,
        string fileName)
    {
        return extractBlock(settings, fileName, PhExtension);
    }

    public static bool IsNeutralLanguageFileName(
        IInheritedSettings? settings,
        string? filePath)
    {
        //CHANGED just invert decision
        return !IsNonNeutralLanguageFileName(settings, filePath);
    }

    public static bool IsNonNeutralLanguageFileName(
        IInheritedSettings? settings,
        string? filePath)
    {
        var fn = ZspPathHelper.GetFileNameFromFilePath(filePath);
        var baseDotCount = settings?.EffectiveBaseNameDotCount ?? 0;

        //CHANGED: special case if settings.EffectiveBaseNameDotCount < 0, guess culture from name:
        if (settings == null || baseDotCount <= 0)
        {
            var cultureString = GetLanguageCodeFromFileNameSuffix(settings, filePath);
            return !string.IsNullOrEmpty(cultureString);
        }
        else
        {
            var nonNeutralDotCount =
                getDotCount(settings.EffectiveNonNeutralLanguageFileNamePattern);

            var dc = getDotCount(fn);

            return dc == nonNeutralDotCount + baseDotCount;
        }
    }

    // ------------------------------------------------------------------
    #endregion

    #region Private implementation.
    // ------------------------------------------------------------------

    private static void doGetBaseName(
        IGridEditableData? fileGroup,
        out string? baseName,
        out string?extension,
        out string? removedType)
    {
        if (fileGroup == null || fileGroup.FilePaths.Length <= 0)
        {
            baseName = null;
            extension = null;
            removedType = null;
        }
        else
        {
            var fileName = ZspPathHelper.GetFileNameFromFilePath(fileGroup.FilePaths[0]);

            var removedTypes = new List<string>();

            fileName = removeOptionalDefaultTypes(fileGroup.ParentSettings, fileName, removedTypes);
            //CHANGED: using new common method. Extract all names by reverse pattern resolve
            if (fileName == null)
            {
	            baseName = null;
	            extension = null;
            }
            else
            {
	            baseName = GetBaseName(fileGroup.ParentSettings, fileName);
	            extension = extractBlock(fileGroup.ParentSettings, fileName, PhExtension);
            }

            removedType = (removedTypes.Count > 0 ? removedTypes[0] : null) ?? string.Empty;
        }
    }

    private static string?removeOptionalDefaultTypes(
        IInheritedSettings? settings,
        string? fileName,
        ICollection<string>? removedTypes)
    {
        if (settings == null || string.IsNullOrEmpty(fileName))
        {
            return fileName;
        }
        else
        {
            var odfts = settings.EffectiveDefaultFileTypesToIgnoreArray;
            if (odfts.Length > 0)
            {
                foreach (var odft in odfts)
                {
                    var p =
                        $@"\b({Regex.Escape(odft)})\b";

                    var before = fileName;
                    fileName = Regex.Replace(fileName, p, string.Empty, RegexOptions.IgnoreCase);

                    if (fileName != before)
                    {
                        removedTypes?.Add(odft);
                    }
                }

                return fileName;
            }
            else
            {
                return fileName;
            }
        }
    }

    private static string? extractBlock(
        IInheritedSettings? settings,
        string? text,
        string? after)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text; //no suffix found
        }
        else
        {
            // Bug_ when no project loaded, therefore create.
            settings ??= Project.Empty;

            var patternOrigin =
                IsNonNeutralLanguageFileName(settings, text)
                    ? settings.EffectiveNonNeutralLanguageFileNamePattern
                    : settings.EffectiveNeutralLanguageFileNamePattern;

            var optionalTypes = new List<string>();
            text = removeOptionalDefaultTypes(settings, text, optionalTypes);
            if (after == PhOptionaltypes)
            {
                return (optionalTypes.Count > 0 ? optionalTypes[0] : null) ?? string.Empty;
            }
            //remove pattern:
            patternOrigin = patternOrigin?.Replace(PhOptionaltypes, string.Empty);

            if (patternOrigin != null && after != null && !patternOrigin.Contains(after))
            {
                if (after == PhLanguagecode)
                {
                    //special case neutral cuture
                    return settings.EffectiveNeutralLanguageCode;
                }
            }

            var pattern = patternOrigin;
            var block = text;
            string? leftBlock;
            string? rightBlock;
            string? leftPattern;
            string? rightPattern;

            //trim right
            while (after != null && !string.IsNullOrEmpty(block) && !string.IsNullOrEmpty(pattern) && pattern.Contains(after))
            {
                splitBlockRight(pattern, @".", out leftPattern, out rightPattern);
                splitBlockRight(block, @".", out leftBlock, out rightBlock);
                if (rightPattern == PhBasename)
                {
                    //we must trim from left now because basename may expand multiple blocks
                    break;
                }
                if (rightPattern == after)
                {
                    //we are done
                    return rightBlock;
                }
                pattern = leftPattern;
                block = leftBlock;
            }

            //trim left
            while (after != null && !string.IsNullOrEmpty(block) && !string.IsNullOrEmpty(pattern) && pattern.Contains(after))
            {
                splitBlockLeft(pattern, @".", out leftPattern, out rightPattern);
                splitBlockLeft(block, @".", out leftBlock, out rightBlock);

                if (leftPattern == after)
                {
                    if (leftPattern == PhBasename && string.IsNullOrEmpty(rightPattern))
                    {
                        //return remaining block
                        return block;
                    }
                    //we are done
                    return leftBlock;
                }
                pattern = rightPattern;
                block = rightBlock;
            }

            //if we gets here, we have problems with pattern.
            throw new ArgumentException(
                string.Format(
                    Resources.SR_LanguageCodeDetection_extractBlock_PatternDoesNotMatch,
                    after,
                    patternOrigin,
                    text));
        }
    }

    private static void splitBlockRight(
        string? text,
        string separator,
        out string? left,
        out string? right)
    {
        if (string.IsNullOrEmpty(text))
        {
            left = text;
            right = text;
        }
        else
        {
            var separatorPos = text.LastIndexOf(separator, StringComparison.Ordinal);
            if (separatorPos < 0)
            {
                left = string.Empty;
                right = text;
            }
            else
            {
                right = text.Substring(separatorPos + 1);
                left = text.Substring(0, separatorPos);
            }
        }
    }

    private static void splitBlockLeft(
        string? text,
        string separator,
        out string? left,
        out string? right)
    {
        if (string.IsNullOrEmpty(text))
        {
            left = text;
            right = text;
        }
        else
        {
            var separatorPos = text.IndexOf(separator, StringComparison.Ordinal);
            if (separatorPos < 0)
            {
                left = text;
                right = string.Empty;
            }
            else
            {
                left = text.Substring(0, separatorPos);
                right = text.Substring(separatorPos + 1);
            }
        }
    }

    private static int getDotCount(
        string? text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }
        else
        {
            var count = 0;

            // ReSharper disable LoopCanBeConvertedToQuery
            foreach (var c in text)
                // ReSharper restore LoopCanBeConvertedToQuery
            {
                if (c == '.')
                {
                    count++;
                }
            }

            return count;
        }
    }

    public bool IsNeutralCulture(
        IInheritedSettings? settings,
        CultureInfo culture)
    {
        return Equals(culture, MakeValidCulture(settings?.EffectiveNeutralLanguageCode));
    }

    // ------------------------------------------------------------------
    #endregion
}

/////////////////////////////////////////////////////////////////////////