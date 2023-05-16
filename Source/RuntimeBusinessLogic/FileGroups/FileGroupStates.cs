namespace ZetaResourceEditor.RuntimeBusinessLogic.FileGroups;

using System.ComponentModel;

[Flags]
public enum FileGroupStates
{
	[Description("Completely translated")] CompletelyTranslated = 0x0000,

	[Description("No strings")] Empty = 0x0001,

	[Description("Translations are missing")]
	TranslationsMissing = 0x0100,

	[Description("Different number of format parameters")]
	FormatParameterMismatches = 0x0200,

	[Description("(Some) completely empty rows")]
	EmptyRows = 0x0400,

	[Description("Automatic translation exists")]
	AutomaticTranslationsExist = 0x0800
}