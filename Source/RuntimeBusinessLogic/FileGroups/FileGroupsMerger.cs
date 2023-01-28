namespace ZetaResourceEditor.RuntimeBusinessLogic.FileGroups;

using BL;
using DL;
using MoreLinq;
using Projects;

public sealed class FileGroupsMerger
{
    private readonly Project _project;

    public FileGroupsMerger(
        Project project)
    {
        _project = project;
    }

    public void MergeIntoFileGroup(FileGroup fileGroupToMergeInto, FileGroup[] fileGroupsToMerge, ref bool didAnything)
    {
        fileGroupsToMerge.ForEach(fg => ensureSameLanguages(fileGroupToMergeInto, fg));

        var locDidAnything = didAnything;
        fileGroupsToMerge.ForEach(fg =>
        {
            doMergeInfo(fileGroupToMergeInto, fg);
            locDidAnything = true;
        });
        didAnything = locDidAnything;

        fileGroupsToMerge.ForEach(removeFromProject);
    }

    private void removeFromProject(FileGroup fileGroup)
    {
        _project.FileGroups.Remove(fileGroup);
        _project.MarkAsModified();
    }

    private void ensureSameLanguages(IGridEditableData fileGroup1, IGridEditableData fileGroup2)
    {
        var l1s = fileGroup1.GetLanguageCodes(_project).OrderBy(m => m, OrderByDirection.Ascending);
        var l2s = fileGroup2.GetLanguageCodes(_project).OrderBy(m => m, OrderByDirection.Ascending);

        var s1 = string.Join(@", ", l1s);
        var s2 = string.Join(@", ", l2s);

        if (!s1.EqualsNoCase(s2))
        {
            throw new(
                $"File group '{fileGroup1.GetNameIntelligent(_project)}' and file group '{fileGroup2.GetFullNameIntelligent(_project)}' have different languages " +
                $"({s1} and {s2}). " +
                Environment.NewLine +
                Environment.NewLine +
                "Please ensure to only merge files with the same languages.");
        }
    }

    private void doMergeInfo(
        FileGroup fileGroupToMergeInto,
        FileGroup fileGroupToMerge)
    {
        var dataDst = new DataProcessing(fileGroupToMergeInto);
        var tableDst = dataDst.GetDataTableFromResxFiles(_project);

        var dataSrc = new DataProcessing(fileGroupToMerge);
        var tableSrc = dataSrc.GetDataTableFromResxFiles(_project);

        // Jede ID muss eindeutig sein.
        checkUniqueIDs(fileGroupToMergeInto, fileGroupToMerge, tableDst, tableSrc);

        // http://stackoverflow.com/a/16617567/107625
        tableDst.Merge(tableSrc);

        // Checksums übernehmen.
        var dstChecksum = fileGroupToMergeInto.GetChecksum(_project);
        foreach (DataRow row in tableDst.Rows)
        {
            row[0] = dstChecksum;
        }

        // Write back.
        dataDst.SaveDataTableToResxFiles(_project, tableDst, false, false);
    }

    private void checkUniqueIDs(
        IGridEditableData fileGroupDst,
        IGridEditableData fileGroupSrc,
        DataTable tableDst,
        DataTable tableSrc)
    {
        foreach (DataRow rowSrc in tableSrc.Rows)
        {
            var nameSrc = rowSrc[1].ToString();

            foreach (DataRow rowDst in tableDst.Rows)
            {
                var nameDst = rowDst[1].ToString();

                if (nameSrc.EqualsNoCase(nameDst))
                {
                    throw new(
                        $"File group '{fileGroupDst.GetNameIntelligent(_project)}' and file group '{fileGroupSrc.GetFullNameIntelligent(_project)}' contains the same " +
                        $"tag '{nameDst}'. " +
                        Environment.NewLine +
                        Environment.NewLine +
                        "Please ensure that all file groups to merge have unique tags.");
                }
            }
        }
    }
}