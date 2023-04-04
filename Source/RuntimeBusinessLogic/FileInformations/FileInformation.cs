namespace ZetaResourceEditor.RuntimeBusinessLogic.FileInformations;

using DL;
using FileGroups;
using Projects;
using System.IO;
using Zeta.VoyagerLibrary.Core.Common;

[DebuggerDisplay(@"File = {File.Name}")]
public class FileInformation :
    ITranslationStateInformation,
    IComparable,
    IComparable<FileInformation>,
    IUniqueID
{
    private Guid _uniqueID;

    public FileInformation(
        FileGroup fileGroup)
    {
        FileGroup = fileGroup;
    }

    public FileGroup FileGroup { get; }

    public FileGroupStateColor TranslationStateColor => FileGroup.TranslationStateColor;

    public FileInfo File { get; set; }

    public int CompareTo(object obj)
    {
        return CompareTo((FileInformation)obj);
    }

    public int CompareTo(FileInformation other)
    {
        var x = ZspPathHelper.GetFileNameWithoutExtension(File.FullName);
        var y = ZspPathHelper.GetFileNameWithoutExtension(other.File.FullName);

        if (x.Contains(@".") && y.Contains(@".") ||
            !x.Contains(@".") && !y.Contains(@"."))
        {
            return string.CompareOrdinal(x, y);
        }
        else
        {
            return x.Contains(@".")
                ? x.StartsWithNoCase(y) ? +1 : string.CompareOrdinal(x, y)
                : y.StartsWithNoCase(x) ? -1 : string.CompareOrdinal(x, y);
        }
    }

    public void StoreToXml(Project? project, XmlElement parentNode)
    {
        if (parentNode.OwnerDocument != null)
        {
            var a = parentNode.OwnerDocument.CreateAttribute(@"filePath");
            a.Value = project.MakeRelativeFilePath(File.FullName);
            parentNode.Attributes.Append(a);

            a = parentNode.OwnerDocument.CreateAttribute(@"absoluteFilePath");
            a.Value = File.FullName;
            parentNode.Attributes.Append(a);

            a = parentNode.OwnerDocument.CreateAttribute(@"uniqueID");
            a.Value = _uniqueID.ToString();
            parentNode.Attributes.Append(a);
        }
    }

    public bool LoadFromXml(Project? project, XmlNode parentNode)
    {
        if (parentNode.Attributes != null)
        {
            XmlHelper.ReadAttribute(
                out _uniqueID,
                parentNode.Attributes[@"uniqueID"]);
        }

        if (_uniqueID == Guid.Empty)
        {
            _uniqueID = Guid.NewGuid();
        }

        // --

        string filePath = null;
        if (parentNode.Attributes != null)
        {
            XmlHelper.ReadAttribute(
                out filePath,
                parentNode.Attributes[@"filePath"]);
        }

        filePath = project.MakeAbsoluteFilePath(filePath);

        if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
        {
            File = new(filePath);
            return true;
        }
        else
        {
            // Try absolute file path if relative one fails.
            filePath = null;
            if (parentNode.Attributes != null)
            {
                XmlHelper.ReadAttribute(
                    out filePath,
                    parentNode.Attributes[@"absoluteFilePath"]);
            }

            if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
            {
                File = new(filePath);
                return true;
            }
            else
            {
                // Try in same folder as project file, if both above failed.

                filePath = null;
                if (parentNode.Attributes != null)
                {
                    XmlHelper.ReadAttribute(
                        out filePath,
                        parentNode.Attributes[@"filePath"]);
                }
                if (string.IsNullOrEmpty(filePath) && parentNode.Attributes != null)
                {
                    XmlHelper.ReadAttribute(
                        out filePath,
                        parentNode.Attributes[@"absoluteFilePath"]);
                }

                if (string.IsNullOrEmpty(filePath))
                {
                    File = null;
                    return false;
                }
                else
                {
                    filePath = ZspPathHelper.GetFileNameFromFilePath(filePath);
                    filePath = project.MakeAbsoluteFilePath(filePath);

                    if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
                    {
                        File = new(filePath);
                        return true;
                    }
                    else
                    {
                        File = null;
                        return false;
                    }
                }
            }
        }
    }

    public Guid UniqueID => _uniqueID;
}