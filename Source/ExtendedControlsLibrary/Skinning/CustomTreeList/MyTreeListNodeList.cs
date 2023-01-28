namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomTreeList;

using System.Linq;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using JetBrains.Annotations;

[UsedImplicitly]
public sealed class MyTreeListNodeList :
    List<TreeListNode>
{
    [UsedImplicitly]
    public TreeList Tree { get; set; }

    [UsedImplicitly]
    public TreeListNode FirstNode => this.FirstOrDefault();

    public MyTreeListNodeList(IEnumerable<TreeListNode> nodes)
    {
        if (nodes != null) AddRange(nodes);
    }

    public MyTreeListNodeList(TreeList tree = null)
    {
        Tree = tree;
    }
}