namespace ZetaResourceEditor.RuntimeBusinessLogic.VirtualViews;

using System.ComponentModel;

public enum ViewMode
{
    Unknown,

    [Description("All file groups of the parent project folder (or root) cumulated")]
    AllFileGroupsInParentProjectFolder
}