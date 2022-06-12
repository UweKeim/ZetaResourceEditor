namespace ZetaResourceEditor.UI.Helper.Progress;

/// <summary>
/// Use this class for performing longer operations
/// to let it fully automatically update a progress.
/// </summary>
public class BackgroundWorkerLongProgressGui :
    IDisposable
{
    #region Public enums.
    // ------------------------------------------------------------------

    /// <summary>
    /// Whether the user can cancel or not.
    /// </summary>
    public enum CancellationMode
    {
        #region Enum members.

        /// <summary>
        /// Yes, is cancelable.
        /// </summary>
        Cancelable,

        /// <summary>
        /// No, the user cannot cancel.
        /// </summary>
        NotCancelable

        #endregion
    }

    // ------------------------------------------------------------------
    #endregion

    #region Public constructors.
    // ------------------------------------------------------------------

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker )
    {
        Start( worker, null, null, null, true, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        string text )
    {
        Start( worker, null, null, text, true, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        bool use )
    {
        Start( worker, null, null, null, use, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        string text,
        bool use )
    {
        Start( worker, null, null, text, use, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        CancellationMode cancellationMode )
    {
        Start( worker, null, null, null, true, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        string text,
        CancellationMode cancellationMode )
    {
        Start( worker, null, null, text, true, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        bool use,
        CancellationMode cancellationMode )
    {
        Start( worker, null, null, null, use, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        string text,
        bool use,
        CancellationMode cancellationMode )
    {
        Start( worker, null, null, text, use, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged )
    {
        Start( worker, progressChanged, null, null, true, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        string text )
    {
        Start( worker, progressChanged, null, text, true, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        bool use )
    {
        Start( worker, progressChanged, null, null, use, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        string text,
        bool use )
    {
        Start( worker, progressChanged, null, text, use, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        CancellationMode cancellationMode )
    {
        Start( worker, progressChanged, null, null, true, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        string text,
        CancellationMode cancellationMode )
    {
        Start( worker, progressChanged, null, text, true, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        bool use,
        CancellationMode cancellationMode )
    {
        Start( worker, progressChanged, null, null, use, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        string text,
        bool use,
        CancellationMode cancellationMode )
    {
        Start( worker, progressChanged, null, text, use, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted )
    {
        Start( worker, null, runWorkerCompleted, null, true, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text )
    {
        Start( worker, null, runWorkerCompleted, text, true, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        bool use )
    {
        Start( worker, null, runWorkerCompleted, null, use, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        bool use )
    {
        Start( worker, null, runWorkerCompleted, text, use, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        CancellationMode cancellationMode )
    {
        Start( worker, null, runWorkerCompleted, null, true, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        CancellationMode cancellationMode )
    {
        Start( worker, null, runWorkerCompleted, text, true, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        bool use,
        CancellationMode cancellationMode )
    {
        Start( worker, null, runWorkerCompleted, null, use, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        bool use,
        CancellationMode cancellationMode )
    {
        Start( worker, null, runWorkerCompleted, text, use, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted )
    {
        Start( worker, progressChanged, runWorkerCompleted, null, true, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text )
    {
        Start( worker, progressChanged, runWorkerCompleted, text, true, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        bool use )
    {
        Start( worker, progressChanged, runWorkerCompleted, null, use, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        bool use )
    {
        Start( worker, progressChanged, runWorkerCompleted, text, use, CancellationMode.Cancelable, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        CancellationMode cancellationMode )
    {
        Start( worker, progressChanged, runWorkerCompleted, null, true, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        CancellationMode cancellationMode )
    {
        Start( worker, progressChanged, runWorkerCompleted, text, true, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        bool use,
        CancellationMode cancellationMode )
    {
        Start( worker, progressChanged, runWorkerCompleted, null, use, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        bool use,
        CancellationMode cancellationMode )
    {
        Start( worker, progressChanged, runWorkerCompleted, text, use, cancellationMode, null );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        IWin32Window owner )
    {
        Start( worker, null, null, null, true, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        string text,
        IWin32Window owner )
    {
        Start( worker, null, null, text, true, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        bool use,
        IWin32Window owner )
    {
        Start( worker, null, null, null, use, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        string text,
        bool use,
        IWin32Window owner )
    {
        Start( worker, null, null, text, use, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, null, null, null, true, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        string text,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, null, null, text, true, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        bool use,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, null, null, null, use, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        string text,
        bool use,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, null, null, text, use, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        IWin32Window owner )
    {
        Start( worker, progressChanged, null, null, true, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        string text,
        IWin32Window owner )
    {
        Start( worker, progressChanged, null, text, true, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        bool use,
        IWin32Window owner )
    {
        Start( worker, progressChanged, null, null, use, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        string text,
        bool use,
        IWin32Window owner )
    {
        Start( worker, progressChanged, null, text, use, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, progressChanged, null, null, true, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        string text,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, progressChanged, null, text, true, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        bool use,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, progressChanged, null, null, use, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        string text,
        bool use,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, progressChanged, null, text, use, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        IWin32Window owner )
    {
        Start( worker, null, runWorkerCompleted, null, true, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        IWin32Window owner )
    {
        Start( worker, null, runWorkerCompleted, text, true, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        bool use,
        IWin32Window owner )
    {
        Start( worker, null, runWorkerCompleted, null, use, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        bool use,
        IWin32Window owner )
    {
        Start( worker, null, runWorkerCompleted, text, use, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, null, runWorkerCompleted, null, true, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, null, runWorkerCompleted, text, true, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        bool use,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, null, runWorkerCompleted, null, use, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        bool use,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, null, runWorkerCompleted, text, use, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        IWin32Window owner )
    {
        Start( worker, progressChanged, runWorkerCompleted, null, true, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        IWin32Window owner )
    {
        Start( worker, progressChanged, runWorkerCompleted, text, true, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        bool use,
        IWin32Window owner )
    {
        Start( worker, progressChanged, runWorkerCompleted, null, use, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        bool use,
        IWin32Window owner )
    {
        Start( worker, progressChanged, runWorkerCompleted, text, use, CancellationMode.Cancelable, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, progressChanged, runWorkerCompleted, null, true, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, progressChanged, runWorkerCompleted, text, true, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the default progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        bool use,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, progressChanged, runWorkerCompleted, null, use, cancellationMode, owner );
    }

    /// <summary>
    /// Construct with the given progress text.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text to display inside the
    /// progress form.</param>
    /// <param name="use">Indicates whether to display the progress
    /// form at all.</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    public BackgroundWorkerLongProgressGui(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        bool use,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        Start( worker, progressChanged, runWorkerCompleted, text, use, cancellationMode, owner );
    }

    // ------------------------------------------------------------------
    #endregion

    #region Public methods.
    // ------------------------------------------------------------------

    /// <summary>
    /// Cleanup.
    /// </summary>
    public void Dispose()
    {
        /*
        if ( parent is Control )
        {
            (parent as Control).Enabled = true;
        }
        */

        // Hide and remove the form.
        if ( _progressWindow != null )
        {
            _progressWindow.Hide();
            _progressWindow.Close();
            _progressWindow.Dispose();
            _progressWindow = null;
        }

        // This object will be cleaned up by the Dispose method.
        // Therefore, you should call GC.SupressFinalize to
        // take this object off the finalization queue 
        // and prevent finalization code for this object
        // from executing a second time.
        GC.SuppressFinalize( this );
    }

    // ------------------------------------------------------------------
    #endregion

    #region Public properties.
    // ------------------------------------------------------------------

    /// <summary>
    /// Gets and sets the text to display in the progress window.
    /// </summary>
    public string ProgressText
    {
        set
        {
            if ( _progressWindow != null )
            {
                _progressWindow.ProgressText = value;
            }
        }
    }

    // ------------------------------------------------------------------
    #endregion

    #region Private methods.
    // ------------------------------------------------------------------

    /// <summary>
    /// Starts the specified worker.
    /// </summary>
    /// <param name="worker">The worker.</param>
    /// <param name="progressChanged">The progress changed.</param>
    /// <param name="runWorkerCompleted">The run worker completed.</param>
    /// <param name="text">The text.</param>
    /// <param name="use">if set to <c>true</c> [use].</param>
    /// <param name="cancellationMode">The cancel mode.</param>
    /// <param name="owner">The owner.</param>
    private void Start(
        DoWorkEventHandler worker,
        ProgressChangedEventHandler progressChanged,
        RunWorkerCompletedEventHandler runWorkerCompleted,
        string text,
        bool use,
        CancellationMode cancellationMode,
        IWin32Window owner )
    {
        // --

        if ( use )
        {
            _progressWindow = new BackgroundWorkerLongProgressForm();
            _progressWindow.DoWork += worker;

            if ( progressChanged != null )
            {
                _progressWindow.ProgressChanged += progressChanged;
            }

            if ( runWorkerCompleted == null )
            {
                _progressWindow.RunWorkerCompleted += Default_RunWorkerCompleted;
            }
            else
            {
                _progressWindow.RunWorkerCompleted += runWorkerCompleted;
            }


            _progressWindow.IsCancelable =
                cancellationMode == CancellationMode.Cancelable;
            if ( text != null )
            {
                _progressWindow.ProgressText = text;
            }

            /*
            if ( parent is Control )
            {
                (parent as Control).Enabled = false;
                progressWindow.Owner = parent as Form;
            }
            */

            if ( owner == null )
            {
                _progressWindow.ShowDialog();
            }
            else
            {
                _progressWindow.ShowDialog( owner );
            }
        }
    }

    /// <summary>
    /// Default handler of the RunWorkerCompleted event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> 
    /// instance containing the event data.</param>
    private static void Default_RunWorkerCompleted(
        object sender,
        RunWorkerCompletedEventArgs e )
    {
        if ( e.Error != null )
        {
            throw new Exception(
                "Error during processing.", 
                e.Error );
        }
    }

    // ------------------------------------------------------------------
    #endregion

    #region Private variables.
    // ------------------------------------------------------------------

    /// <summary>
    /// The windows that handles the GUI part.
    /// </summary>
    private BackgroundWorkerLongProgressForm _progressWindow;

    // ------------------------------------------------------------------
    #endregion
}