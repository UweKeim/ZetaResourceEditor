namespace ExtendedControlsLibrary.Skinning.CustomTreeList;

using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using JetBrains.Annotations;
using System.Collections.Generic;
using System.Linq;

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