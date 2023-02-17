namespace ZetaResourceEditor.RuntimeBusinessLogic.DL;

using System.Globalization;

public interface ILanguageColumnFilter
{
    bool HasLanguageToDisplayFilter { get; }

    bool WantDisplayLanguageColumnInGrid(CultureInfo ci);
    bool WantDisplayLanguageColumnInGrid(string? language);
}