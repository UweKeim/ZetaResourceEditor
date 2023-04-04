namespace ZetaResourceEditor.RuntimeBusinessLogic.Snapshots;

using BL;
using DL;
using ExportImportExcel.Export;
using Language;
using Projects;
using System.ComponentModel;
using System.Linq;

/// <summary>
/// 2017-04-02, Uwe Keim:
/// Damit wir "Use existing translations" nutzen können, hier einen einmaligen Snapshot
/// vor dem Übersetzen machen.
/// </summary>
public sealed class InMemoryTranslationSnapshotController
{
    public InMemoryTranslationSnapshot CreateSnapshot(
        Project? project,
        string[] languageCodes,
        BackgroundWorker bw)
    {
        var imss = new InMemoryTranslationSnapshot();

        project.FileGroups.ForEach(fg => doTakeSnapshot(imss, project, fg, languageCodes, bw));

        return imss;
    }

    private static void doTakeSnapshot(
        InMemoryTranslationSnapshot imss,
        Project? project,
        IGridEditableData fileGroup,
        IEnumerable<string> languageCodes,
        BackgroundWorker bw)
    {
        //var fgi = fileGroup.GetFileByLanguageCode(Project, languageCode);

        var table = new DataProcessing(fileGroup).GetDataTableFromResxFiles(project, true);

        var lcs = new List<string?>(languageCodes);
        for (var i = 0; i < lcs.Count; i++)
        {
            lcs[i] = lcs[i].ToLowerInvariant();
        }

        var rowIndex = 0;
        foreach (DataRow row in table.Rows)
        {
            if (rowIndex % 25 == 0 && (bw?.CancellationPending ?? false)) throw new OperationCanceledException();

            var dic = new Dictionary<string?, string>();

            for (var sourceColumnIndex = 2;
                 sourceColumnIndex <
                 table.Columns.Count - 1; // Subtract 1, because last column is ALWAYS the comment.
                 ++sourceColumnIndex)
            {
                var languageValue = row[sourceColumnIndex] as string;
                var languageCode =
                    ExcelExportController.IsFileName(table.Columns[sourceColumnIndex].ColumnName)
                        ? new LanguageCodeDetection(project)
                            .DetectLanguageCodeFromFileName(
                                fileGroup.ParentSettings,
                                table.Columns[sourceColumnIndex].ColumnName)
                        : table.Columns[sourceColumnIndex].ColumnName;
                languageCode = languageCode.ToLowerInvariant();

                if (lcs.Contains(languageCode))
                {
                    dic[languageCode] = languageValue;
                }
            }

            imss.AddBatchTranslation(dic);

            rowIndex++;
        }
    }
}

public sealed class InMemoryTranslationSnapshot
{
    private readonly List<InMemoryTranslationSnapshotItem> _items = new();

    /// <summary>
    /// Liefert NULL zurück, falls nicht gefunden.
    /// </summary>
    public string GetTranslation(
        string? sourceLanguageCode,
        string? destinationLanguageCode,
        string sourceText)
    {
        var items = _items.Where(
            i => i.LanguageAndTextPairs.Any(j => j.Key.EqualsNoCase(sourceLanguageCode) &&
                                                 j.Value.EqualsNoCase(sourceText)));

        foreach (var item in items)
        {
            var one = item.LanguageAndTextPairs.FirstOrDefault(i => i.Key.EqualsNoCase(destinationLanguageCode));
            if (one.Value != null)
            {
                return one.Value;
            }
        }

        return null;
    }

    public void AddBatchTranslation(
        Dictionary<string?, string> languageAndTextPairs)
    {
        var item = new InMemoryTranslationSnapshotItem();
        _items.Add(item);

        foreach (var pair in languageAndTextPairs)
        {
            item.LanguageAndTextPairs[pair.Key] = pair.Value;
        }
    }

    public void AddTranslation(
        string? sourceLanguageCode,
        string? destinationLanguageCode,
        string sourceText,
        string? destinationText)
    {
        var item = _items.FirstOrDefault(
            i => i.LanguageAndTextPairs.Any(j => j.Key.EqualsNoCase(sourceLanguageCode) &&
                                                 j.Value.EqualsNoCase(sourceText)));

        if (item == null)
        {
            item = new();
            _items.Add(item);
        }

        item.LanguageAndTextPairs[destinationLanguageCode] = destinationText;
    }
}

public sealed class InMemoryTranslationSnapshotItem
{
    public Dictionary<string?, string> LanguageAndTextPairs { get; } = new();

}