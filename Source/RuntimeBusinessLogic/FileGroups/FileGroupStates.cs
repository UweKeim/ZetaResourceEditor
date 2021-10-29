namespace ZetaResourceEditor.RuntimeBusinessLogic.FileGroups;

using System;
using Properties;
using Runtime.Localization;

[Flags]
public enum FileGroupStates
{
    [LocalizableDescription( @"FileGroupStates_CompletelyTranslated", typeof( Resources ) )]
    CompletelyTranslated = 0x0000,

    [LocalizableDescription( @"FileGroupStates_Empty", typeof( Resources ) )]
    Empty = 0x0001,

    // --

    [LocalizableDescription( @"FileGroupStates_TranslationsMissing", typeof( Resources ) )]
    TranslationsMissing = 0x0100,

    [LocalizableDescription( @"FileGroupStates_FormatParameterMismatches", typeof( Resources ) )]
    FormatParameterMismatches = 0x0200,

    [LocalizableDescription( @"FileGroupStates_EmptyRows", typeof( Resources ) )]
    EmptyRows = 0x0400,

    // AJ CHANGE
    [LocalizableDescription( @"FileGroupStates_AutomaticTranslationsExist", typeof( Resources ) )]
    AutomaticTranslationsExist = 0x0800
}