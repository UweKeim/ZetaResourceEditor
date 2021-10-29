namespace ZetaResourceEditor.UI.Helper.Progress;

using System.ComponentModel;

/// <summary>
/// Extended BackgroundWorker component for use in conjunction with
/// the long progress GUI form.
/// </summary>
public class BackgroundWorkerLongProgress :
    BackgroundWorker
{
    #region Public properties.
    // ------------------------------------------------------------------

    /// <summary>
    /// Get access to the owning form.
    /// </summary>
    [Browsable( false )]
    [EditorBrowsable( EditorBrowsableState.Never )]
    [DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
    public BackgroundWorkerLongProgressForm OwningForm
    {
        get;
        set;
    }

    // ------------------------------------------------------------------
    #endregion
}