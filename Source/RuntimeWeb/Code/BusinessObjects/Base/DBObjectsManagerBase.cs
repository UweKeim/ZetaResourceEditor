namespace ZetaResourceEditorWebsite.RuntimeWeb.Code.BusinessObjects.Base;

using System;
using System.Collections.Generic;
using System.Data;

public abstract class DBObjectsManagerBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DBObjectsManagerBase"/>
    /// class.
    /// </summary>
    /// <param name="elementManager">The element manager.</param>
    protected DBObjectsManagerBase(
        ElementManager elementManager )
    {
        ElementManager = elementManager;
    }

    public ElementManager ElementManager
    {
        get; protected set;
    }

    #region Public Methods.
    // ------------------------------------------------------------------

    /// <summary>
    /// Generic function to load an array of Base objects from a given
    /// table object.
    /// </summary>
    /// <returns>Returns the array or NULL if no elements.</returns>
    public T[] LoadArrayFromTable<T>(
        DataTable table ) where T : DBObjectBase, new()
    {
        if ( table == null || table.Rows.Count <= 0 )
        {
            return null;
        }
        else
        {
            var result = new List<T>();

            foreach ( DataRow row in table.Rows )
            {
                var o = new T
                {
                    OwningManager = this
                };

                o.Load( row );

                if ( !o.IsEmpty )
                {
                    result.Add( o );
                }
            }

            return result.Count <= 0 ? null : result.ToArray();
        }
    }

    /// <summary>
    /// Generic function to load one Base object from a given
    /// row object.
    /// </summary>
    /// <returns>Returns the array or NULL if no elements.</returns>
    public T LoadObjectFromRow<T>(
        DataRow row ) where T : DBObjectBase, new()
    {
        if ( row == null )
        {
            return null;
        }
        else
        {
            var o = new T
            {
                OwningManager = this
            };

            o.Load( row );

            return o.IsEmpty ? null : o;
        }
    }

    /// <summary>
    /// Generic function to load an array of Base objects from a given
    /// table object.
    /// </summary>
    /// <returns>Returns the array or NULL if no elements.</returns>
    public T[] LoadSimpleArrayFromTable<T>(
        DataTable table )
    {
        if ( table == null || table.Rows.Count <= 0 )
        {
            return new T[] { };
        }
        else
        {
            var result = new List<T>();

            foreach ( DataRow row in table.Rows )
            {
                if ( row[0] != DBNull.Value )
                {
                    var o = (T)row[0];

                    result.Add( o );
                }
            }

            return result.Count <= 0 ? new T[] { } : result.ToArray();
        }
    }

    // ------------------------------------------------------------------
    #endregion
}