namespace ZetaResourceEditor.UI.Helper;

public class ExpandDynamicChildrenEventArgs :
    EventArgs
{
    public ExpandDynamicChildrenEventArgs(
        TreeListNode node )
    {
        Node = node;
    }

    public TreeListNode Node { get; }
}