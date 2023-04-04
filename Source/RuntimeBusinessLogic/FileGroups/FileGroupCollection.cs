namespace ZetaResourceEditor.RuntimeBusinessLogic.FileGroups;

#region Using directives.
// ----------------------------------------------------------------------
using System.Linq;
using Projects;
using Zeta.VoyagerLibrary.Core.Common.Collections;

// ----------------------------------------------------------------------
#endregion

/////////////////////////////////////////////////////////////////////////

public class FileGroupCollection :
    List<FileGroup>
{
    public FileGroupCollection(
        Project? project)
    {
        Project = project;
    }

    public Project? Project { get; }

    internal void StoreToXml(
        XmlElement parentNode)
    {
        if (parentNode.OwnerDocument != null)
        {
            var groupsNode =
                parentNode.OwnerDocument.CreateElement(@"fileGroups");
            parentNode.AppendChild(groupsNode);

            foreach (var fileGroup in this)
            {
                if (parentNode.OwnerDocument != null)
                {
                    var fileGroupNode =
                        parentNode.OwnerDocument.CreateElement(@"fileGroup");
                    groupsNode.AppendChild(fileGroupNode);

                    fileGroup.StoreToXml(Project, fileGroupNode);
                }
            }
        }
    }

    internal void LoadFromXml(
        XmlNode parentNode)
    {
        Clear();

        var fileGroupNodes =
            parentNode.SelectNodes(@"fileGroups/fileGroup");

        if (fileGroupNodes != null)
        {
            foreach (XmlNode fileGroupNode in fileGroupNodes)
            {
                var fileGroup = new FileGroup(Project);
                fileGroup.LoadFromXml(Project, fileGroupNode);

                // Do not add orphans.
                if (fileGroup.FileInfoCount > 0)
                {
                    Add(fileGroup);
                }
            }
        }

        // --

        Sort(
            /*delegate(FileGroup a, FileGroup b)
                {
                    if (a.Count <= 0)
                    {
                        return +1;
                    }
                    else if (b.Count <= 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return string.Compare(
                            a.GetNameIntelligent(_project),
                            b.GetNameIntelligent(_project),
                            true);
                    }
                }*/
        );
    }

    public bool HasFileGroupWithChecksum(
        long checksum)
    {
// ReSharper disable LoopCanBeConvertedToQuery
        foreach (var fileGroup in this)
// ReSharper restore LoopCanBeConvertedToQuery
        {
            if (fileGroup.GetChecksum(Project) == checksum)
            {
                return true;
            }
        }

        return false;
    }

    public MyTuple<string, string>[] GetLanguageCodesExtended(
        Project? project)
    {
        var result = new HashSet<MyTuple<string, string>>();

        foreach (var fg in this)
        {
            foreach (var f in fg.GetLanguageCodesExtended(project))
            {
                var f1 = f;

                if (result.All(x => string.Compare(x.Item1, f1.Item1, StringComparison.OrdinalIgnoreCase) != 0))
                {
                    result.Add(f);
                }
            }
        }

        return result.ToArray();
    }
}

/////////////////////////////////////////////////////////////////////////