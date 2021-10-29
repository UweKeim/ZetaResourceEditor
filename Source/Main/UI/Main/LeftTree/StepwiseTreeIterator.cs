namespace ZetaResourceEditor.UI.Main.LeftTree;

using System;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

public sealed class StepwiseTreeIterator
{
    private readonly TreeList _treeList;
    private readonly TimeSpan _updateInterval;
    private TreeListNode _nextUpdateNodeToProcess;
    private TreeListNode _lastUpdateRootNode;
    private DateTime _lastNodeUpdateDate;
    private readonly NodeProcessingHandler _handler;
    private readonly int _levelsToProcess;

    public delegate void NodeProcessingHandler( TreeListNode node );

    public StepwiseTreeIterator(
        TreeList treeList,
        TimeSpan updateInterval,
        NodeProcessingHandler handler,
        int levelsToProcess )
    {
        _treeList = treeList;
        _updateInterval = updateInterval;
        _handler = handler;
        _levelsToProcess = levelsToProcess;
    }

    public void Step()
    {
        if ( _lastNodeUpdateDate.Add( _updateInterval ) < DateTime.Now )
        {
            _lastNodeUpdateDate = DateTime.Now;

            // Reset a possibly removed node.
            if ( _nextUpdateNodeToProcess is { TreeList: null } )
            {
                _nextUpdateNodeToProcess = null;
            }
            // Reset a possibly removed node.
            if ( _lastUpdateRootNode is { TreeList: null } )
            {
                _lastUpdateRootNode = null;
            }

            if ( _nextUpdateNodeToProcess == null )
            {
                _nextUpdateNodeToProcess = _lastUpdateRootNode == null ? _treeList.Nodes.FirstNode : _lastUpdateRootNode.NextNode;

                _lastUpdateRootNode = _nextUpdateNodeToProcess;
            }

            if ( _nextUpdateNodeToProcess != null )
            {
                _handler( _nextUpdateNodeToProcess );

                if ( _nextUpdateNodeToProcess.HasChildren &&
                     (_levelsToProcess < 0 || _nextUpdateNodeToProcess.Level < _levelsToProcess) )
                {
                    _nextUpdateNodeToProcess = _nextUpdateNodeToProcess.Nodes.FirstNode;
                }
                else
                {
                    _nextUpdateNodeToProcess = _nextUpdateNodeToProcess.NextNode;
                }
            }
        }
    }
}