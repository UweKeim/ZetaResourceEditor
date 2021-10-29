using System;

namespace Web.Code;

using Base;
using Zeta.VoyagerLibrary.WebForms;

public class PageLoadTaskPerformer
{
    public PageLoadTaskPerformer(
        PageBase page )
    {
        Page = page;
    }

    public event EventHandler<NeedPerformTaskEventArgs> NeedPerformTask;

    /// <summary>
    /// Tries to perform tasks, returns TRUE if succeeded, FALSE if not.
    /// </summary>
    /// <returns></returns>
    public bool PerformTasks()
    {
        var hasPerformed = false;

        // --

        if ( NeedPerformTask != null )
        {
            var args = new NeedPerformTaskEventArgs( this );

            NeedPerformTask( this, args );

            hasPerformed = args.HasPerformed;
        }

        // --
        // Another task.

        /*
    parameterName = @"AdminMode";
    if ( _qs.HasParameter( parameterName ) )
    {
        bool o = ConvertHelper.ToBoolean( _qs[parameterName] );

        _page.IsAdministrationModeActive = o;

        // Remove.
        _qs.RemoveParameter( parameterName );

        // Mark as performed.
        hasPerformed = true;
    }
    */

        // --

        return hasPerformed;
    }

    /// <summary>
    /// If <see cref="PerformTasks"/> returns TRUE, this function returns the
    /// new URL to redirect to.
    /// </summary>
    /// <value>The redirect URL.</value>
    public string RedirectUrl => QueryString.AllUrl;

    public PageBase Page { get; }

    public QueryString QueryString { get; } = new();

    public void Redirect()
    {
        QueryString.Redirect();
    }
}