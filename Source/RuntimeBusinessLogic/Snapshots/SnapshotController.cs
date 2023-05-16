namespace ZetaResourceEditor.RuntimeBusinessLogic.Snapshots;

using BL;
using DL;
using ExportImportExcel.Export;
using FileGroups;
using Language;
using Projects;
using Properties;
using System.ComponentModel;

public class SnapshotController :
    SnapshotControllerBase
{
    private readonly string _prefix;

    public SnapshotController(
        Project? project,
        string prefix) :
        base(project)
    {
        _prefix = prefix;
    }

    public void TakeFullSnapshot(
        FileGroup[] fileGroups,
        string?[] languageCodes, // Source _and_ destination.
        BackgroundWorker bw)
    {
        languageCodes = make2(languageCodes);

        bw?.ReportProgress(0, Resources.TakingSnapshots);

        var fgIndex = 0;
        foreach (var fileGroup in fileGroups)
        {
            bw?.ReportProgress(
                0,
                string.Format(
                    Resources.TakeFullSnapshot,
                    fgIndex + 1,
                    fileGroups.Length,
                    fileGroup.GetNameIntelligent(Project)));

            if (bw?.CancellationPending ?? false) throw new OperationCanceledException();

            doTakeSnapshot(fileGroup, languageCodes, bw);
            fgIndex++;
        }
    }

    private static string?[] make2(IEnumerable<string?> languageCodes)
    {
        var r = new List<string?>();
        foreach (var languageCode in languageCodes)
        {
            r.Add(languageCode);
        }
        return r.ToArray();
    }

    public string MakeBaseKey(
        object fileGroupCheckSum,
        object tagName)
    {
        // Column 0=FileGroup checksum, column 1=Tag name.
        return $@"PV.{_prefix}.{fileGroupCheckSum}.{tagName}.".ToLowerInvariant();
    }

    public static string? MakeFullKey(
        string baseKey,
        string? languageCode)
    {
        return (baseKey + languageCode).ToLowerInvariant();
    }

    private void doTakeSnapshot(
        IGridEditableData fileGroup,
        IEnumerable<string?> languageCodes,
        BackgroundWorker bw)
    {
        //var fgi = fileGroup.GetFileByLanguageCode(Project, languageCode);

        var table = new DataProcessing(fileGroup).GetDataTableFromResxFiles(Project, true);

        var lcs = new List<string?>(languageCodes);
        for (var i = 0; i < lcs.Count; i++)
        {
            lcs[i] = lcs[i].ToLowerInvariant();
        }

        var rowIndex = 0;
        foreach (DataRow row in table.Rows)
        {
            if (rowIndex % 25 == 0 && (bw?.CancellationPending ?? false)) throw new OperationCanceledException();

            // Column 0=FileGroup checksum, column 1=Tag name.
            var baseKey = MakeBaseKey(row[0], row[1]);

            for (var sourceColumnIndex = 2;
                 sourceColumnIndex < table.Columns.Count - 1; // Subtract 1, because last column is ALWAYS the comment.
                 ++sourceColumnIndex)
            {
                var languageValue = row[sourceColumnIndex] as string;
                var languageCode =
                    ExcelExportController.IsFileName(table.Columns[sourceColumnIndex].ColumnName)
                        ? new LanguageCodeDetection(Project)
                            .DetectLanguageCodeFromFileName(
                                fileGroup.ParentSettings,
                                table.Columns[sourceColumnIndex].ColumnName)
                        : table.Columns[sourceColumnIndex].ColumnName;
                languageCode = languageCode.ToLowerInvariant();

                if (/*lcs.Contains(languageCode.Substring(0, 2))||*/
                    lcs.Contains(languageCode))
                {
                    var key = MakeFullKey(baseKey, languageCode);
                    PutSettingValue(key, languageValue);
                }
            }

            rowIndex++;
        }
    }
}