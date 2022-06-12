namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.Base;

using System;
using System.Collections.Generic;

public abstract class DBObjectCollectionBase<T> :
    List<T>
    where T : DBObjectBase
{
    protected DBObjectCollectionBase()
    {
    }

    protected DBObjectCollectionBase(
        IEnumerable<T> collection )
    {
        if ( collection != null )
        {
            AddRange( collection );

            if ( Count > 1 &&
                 (this[0] is IComparable || this[0] is IComparable<T>) )
            {
                Sort();
            }
        }
    }

    public int[] ToIDArray()
    {
        return this.Select(t => t.ID).ToArray();
    }
}