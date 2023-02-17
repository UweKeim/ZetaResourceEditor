namespace ZetaResourceEditor.RuntimeBusinessLogic.DynamicSettings;

public interface IInheritedSettings
{
    IInheritedSettings ParentSettings { get; }

    int EffectiveBaseNameDotCount { get; }

    bool EffectiveIgnoreDuringExportAndImport { get; }

    string? EffectiveNeutralLanguageFileNamePattern { get; }

    string? EffectiveNonNeutralLanguageFileNamePattern { get; }

    string[] EffectiveDefaultFileTypesToIgnoreArray { get; }

    string? EffectiveDefaultFileTypesToIgnore { get; }

    string? EffectiveNeutralLanguageCode { get; }
}