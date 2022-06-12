namespace ZetaResourceEditor.RuntimeBusinessLogic.BL;

using System.IO;
using FileInformations;

/// <summary>
/// Helper class for one .RESX file.
/// </summary>
[DebuggerDisplay(@"{FilePath.Name}")]
internal class ResxFile
{
    public XmlDocument Document { get; set; }
    public FileInfo FilePath { get; set; }

    public FileInformation FileInformation { get; set; }
}