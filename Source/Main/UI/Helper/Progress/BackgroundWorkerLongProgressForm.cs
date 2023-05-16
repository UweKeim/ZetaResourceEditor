namespace ZetaResourceEditor.UI.Helper.Progress;

using Base;

public partial class BackgroundWorkerLongProgressForm :
	FormBase
{
	public BackgroundWorkerLongProgressForm()
	{
		InitializeComponent();

		if (!DesignMode)
		{
			_initialProgressBarRight = ProgressBarControl.Right;
			BackgroundWorker.OwningForm = this;
		}
	}

	public new DialogResult ShowDialog()
	{
		return base.ShowDialog();
	}

	public new DialogResult ShowDialog(
		IWin32Window owner)
	{
		return base.ShowDialog(owner);
	}

	public new void Close()
	{
		base.Close();
	}

	/// <summary>
	/// Updates GUI, enables and disables controls.
	/// </summary>
	public override void UpdateUI()
	{
		base.UpdateUI();

		if (BackgroundWorker.WorkerSupportsCancellation)
		{
			ControlBox = true;
			CmdCancel.Visible = true;
			CmdCancel.DialogResult = DialogResult.Cancel;

			ProgressBarControl.Width =
				_initialProgressBarRight - ProgressBarControl.Left;
		}
		else
		{
			ControlBox = false;
			CmdCancel.Visible = false;
			CmdCancel.DialogResult = DialogResult.None;

			ProgressBarControl.Width =
				CmdCancel.Right - ProgressBarControl.Left;
		}
	}

	public event DoWorkEventHandler DoWork
	{
		add => BackgroundWorker.DoWork += value;
		remove => BackgroundWorker.DoWork -= value;
	}

	public event ProgressChangedEventHandler ProgressChanged
	{
		add
		{
			BackgroundWorker.ProgressChanged += value;
			BackgroundWorker.WorkerReportsProgress = true;
		}
		remove
		{
			BackgroundWorker.WorkerReportsProgress = false;
			BackgroundWorker.ProgressChanged -= value;
		}
	}

	public event RunWorkerCompletedEventHandler RunWorkerCompleted
	{
		add => BackgroundWorker.RunWorkerCompleted += value;
		remove => BackgroundWorker.RunWorkerCompleted -= value;
	}

	/// <summary>
	/// Get access to the underlying background worker component.
	/// </summary>
	// ReSharper disable once ConvertToAutoProperty
	protected BackgroundWorkerLongProgress BackgroundWorker => backgroundWorker;

	public object? AsyncArgument { get; set; }

	public string ProgressText
	{
		set
		{
			if (InvokeRequired)
			{
				Invoke(
					new MethodInvoker(
						() => ProgressTextControl.Text = value));
			}
			else
			{
				ProgressTextControl.Text = value;
			}
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public bool IsCancelable
	{
		get => BackgroundWorker.WorkerSupportsCancellation;
		set
		{
			if (BackgroundWorker.WorkerSupportsCancellation != value)
			{
				BackgroundWorker.WorkerSupportsCancellation = value;
				UpdateUI();
			}
		}
	}

	/// <summary>
	/// When the worker has finished, you can use this property
	/// to inspect the result and/or whether there were exceptions.
	/// </summary>
	public RunWorkerCompletedEventArgs? WorkCompletedArgs { get; private set; }

	private readonly int _initialProgressBarRight;

	private void StartBusyBar()
	{
		ProgressBarControl.Enabled = true;
		ProgressBarControl.Refresh();
	}

	private void StopBusyBar()
	{
		ProgressBarControl.Enabled = false;
		ProgressBarControl.Refresh();
	}

	private void BackgroundWorkerLongProgressForm_Load(object sender, EventArgs e)
	{
		CenterToParent();
		UpdateUI();

		StartBusyBar();
	}

	private void CmdCancel_Click(
		object sender,
		EventArgs e)
	{
		if (BackgroundWorker.WorkerSupportsCancellation)
		{
			BackgroundWorker.CancelAsync();
		}

		if (cancelGuardTimer is { Enabled: false })
		{
			cancelGuardTimer.Start();
		}
	}

	private void ProgressForm_FormClosing(
		object sender,
		FormClosingEventArgs e)
	{
		switch (BackgroundWorker.IsBusy)
		{
			case true when !IsCancelable:
				e.Cancel = true;
				DialogResult = DialogResult.None;
				break;
			case true when BackgroundWorker.WorkerSupportsCancellation:
				StopBusyBar();

				BackgroundWorker.CancelAsync();

				// Wait until finished.
				e.Cancel = false;
				DialogResult = DialogResult.Cancel;
				break;
			// Already successlessly tried to cancel.
			case true when cancelGuardTimer == null:
				// Yes, really close.
				e.Cancel = false;
				DialogResult = DialogResult.Cancel;
				break;
			case true:
				e.Cancel = true;
				DialogResult = DialogResult.None;
				break;
			default:
				e.Cancel = false;
				DialogResult = DialogResult.Cancel;
				break;
		}
	}

	private void BackgroundWorkerLongProgressForm_Shown(object sender, EventArgs e)
	{
		BackgroundWorker.RunWorkerAsync(AsyncArgument);
	}

	private void backgroundWorker_RunWorkerCompleted(
		object sender,
		RunWorkerCompletedEventArgs e)
	{
		// Remember for accessing from outside.
		WorkCompletedArgs = e;

		if (e.Error == null)
		{
			// Just close the form.
			DialogResult = DialogResult.Cancel;
			Close();
		}
		else
		{
			LogCentral.Current.LogError(
				@"Received exception from async worker function. Forwarding.",
				e.Error);

			DialogResult = DialogResult.Cancel;
			Close();

			throw new(
				"Error received from background worker. See inner exception for details.",
				e.Error);
		}
	}

	private void cancelGuardTimer_Tick(
		object sender,
		EventArgs e)
	{
		// Only once.
		cancelGuardTimer.Stop();
		cancelGuardTimer.Dispose();
		cancelGuardTimer = null;

		// --
		// Force termination.

		BackgroundWorker.CancelAsync();

		DialogResult = DialogResult.Cancel;
		Close();

		throw new ApplicationException(
			"Background processing method does not respond within the given time frame.");
	}
}