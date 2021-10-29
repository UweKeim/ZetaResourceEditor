namespace ZetaResourceEditor.RuntimeBusinessLogic.BL;

using System.Diagnostics;
using System.Xml;
using FileInformations;
using ZetaLongPaths;

/// <summary>
/// Helper class for one .RESX file.
/// </summary>
[DebuggerDisplay(@"{FilePath.Name}")]
internal class ResxFile
{
    public XmlDocument Document { get; set; }
    public ZlpFileInfo FilePath { get; set; }

    public FileInformation FileInformation { get; set; }
}