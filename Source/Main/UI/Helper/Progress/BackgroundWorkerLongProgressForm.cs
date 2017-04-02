namespace ZetaResourceEditor.UI.Helper.Progress
{
	using System;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Windows.Forms;
	using Base;
	using Zeta.VoyagerLibrary.Logging;

	public partial class BackgroundWorkerLongProgressForm : 
		FormBase
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Initializes a new instance of the 
		/// <see cref="BackgroundWorkerLongProgressForm"/> class.
		/// </summary>
		public BackgroundWorkerLongProgressForm()
		{
			InitializeComponent();

			if ( !DesignMode )
			{
				_initialProgressBarRight = ProgressBarControl.Right;
				BackgroundWorker.OwningForm = this;
			}
		}

		/// <summary>
		/// Shows the form as a modal dialog box with the currently active window set as its owner.
		/// </summary>
		/// <returns>
		/// One of the <see cref="T:System.Windows.Forms.DialogResult"/> values.
		/// </returns>
		public new DialogResult ShowDialog()
		{
			return base.ShowDialog();
		}

		/// <summary>
		/// Shows the form as a modal dialog box with the specified owner.
		/// </summary>
		/// <param name="owner">Any object that implements <see cref="T:System.Windows.Forms.IWin32Window"/> that represents the top-level window that will own the modal dialog box.</param>
		/// <returns>
		/// One of the <see cref="T:System.Windows.Forms.DialogResult"/> values.
		/// </returns>
		public new DialogResult ShowDialog(
			IWin32Window owner )
		{
			return base.ShowDialog( owner );
		}

		/// <summary>
		/// Closes the form.
		/// </summary>
		/// <exception cref="T:System.InvalidOperationException">The form was closed while a handle was being created. </exception>
		/// <exception cref="T:System.ObjectDisposedException">You cannot call this method from the <see cref="E:System.Windows.Forms.Form.Activated"/> event when <see cref="P:System.Windows.Forms.Form.WindowState"/> is set to <see cref="F:System.Windows.Forms.FormWindowState.Maximized"/>.</exception>
		/// <PermissionSet>
		/// 	<IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
		/// 	<IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
		/// 	<IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/>
		/// 	<IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
		/// </PermissionSet>
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

			if ( BackgroundWorker.WorkerSupportsCancellation )
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

		// ------------------------------------------------------------------
		#endregion

		#region Public properties.
		// ------------------------------------------------------------------

		/// <summary>
		/// Subscribable event.
		/// </summary>
		public event DoWorkEventHandler DoWork
		{
			add
			{
				_addedCount++;
				BackgroundWorker.DoWork += value;
			}
			remove
			{
				_addedCount--;
				BackgroundWorker.DoWork -= value;
			}
		}

		/// <summary>
		/// Subscribable event.
		/// </summary>
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

		/// <summary>
		/// Subscribable event.
		/// </summary>
		public event RunWorkerCompletedEventHandler RunWorkerCompleted
		{
			add => BackgroundWorker.RunWorkerCompleted += value;
		    remove => BackgroundWorker.RunWorkerCompleted -= value;
		}

		/// <summary>
		/// Get access to the underlying background worker component.
		/// </summary>
		protected BackgroundWorkerLongProgress BackgroundWorker
		{
			get
			{
				Debug.Assert( true, @"No auto property." );
				return backgroundWorker;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public object AsyncArgument
		{
			get;
			set;
		}

		/// <summary>
		/// Set the text to display in the main area of the form.
		/// </summary>
		public string ProgressText
		{
			set
			{
				if ( InvokeRequired )
				{
					Invoke(
						new MethodInvoker(
							() => ProgressTextControl.Text = value ) );
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
			get
			{
				return BackgroundWorker.WorkerSupportsCancellation;
			}
			set
			{
				if ( BackgroundWorker.WorkerSupportsCancellation != value )
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
		public RunWorkerCompletedEventArgs WorkCompletedArgs { get; private set; }

	    // ------------------------------------------------------------------
		#endregion

		#region Private variables.
		// ------------------------------------------------------------------

		private readonly int _initialProgressBarRight;
		private int _addedCount;

	    // ------------------------------------------------------------------
		#endregion

		#region Busy bar handling.
		// ------------------------------------------------------------------

		/// <summary>
		/// Starts the busy bar.
		/// </summary>
		private void StartBusyBar()
		{
			ProgressBarControl.Enabled = true;
			ProgressBarControl.Refresh();
		}

		/// <summary>
		/// Stops the busy bar.
		/// </summary>
		private void StopBusyBar()
		{
			ProgressBarControl.Enabled = false;
			ProgressBarControl.Refresh();
		}

		// ------------------------------------------------------------------
		#endregion

		#region Private event handler.
		// ------------------------------------------------------------------

		/// <summary>
		/// Handles the Load event of the ProgressForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void BackgroundWorkerLongProgressForm_Load( object sender, EventArgs e )
		{
			CenterToParent();
			UpdateUI();

			StartBusyBar();
		}

		/// <summary>
		/// Handles the Click event of the CmdCancel control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void CmdCancel_Click(
			object sender,
			EventArgs e )
		{
			if ( BackgroundWorker.WorkerSupportsCancellation )
			{
				BackgroundWorker.CancelAsync();
			}

			if ( cancelGuardTimer != null && !cancelGuardTimer.Enabled )
			{
				cancelGuardTimer.Start();
			}
		}

		/// <summary>
		/// Handles the FormClosing event of the ProgressForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
		private void ProgressForm_FormClosing(
			object sender,
			FormClosingEventArgs e )
		{
			if ( BackgroundWorker.IsBusy && !IsCancelable )
			{
				e.Cancel = true;
				DialogResult = DialogResult.None;
			}
			else
			{
				if ( BackgroundWorker.IsBusy &&
					BackgroundWorker.WorkerSupportsCancellation )
				{
					StopBusyBar();

					BackgroundWorker.CancelAsync();

					// Wait until finished.
					e.Cancel = false;
					DialogResult = DialogResult.Cancel;
				}
				else if ( BackgroundWorker.IsBusy )
				{
					// Already successlessly tried to cancel.
					if ( cancelGuardTimer == null )
					{
						// Yes, really close.
						e.Cancel = false;
						DialogResult = DialogResult.Cancel;
					}
					else
					{
						e.Cancel = true;
						DialogResult = DialogResult.None;
					}
				}
				else
				{
					e.Cancel = false;
					DialogResult = DialogResult.Cancel;
				}
			}
		}

		/// <summary>
		/// Handles the Shown event of the BackgroundWorkerProgressForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void BackgroundWorkerLongProgressForm_Shown( object sender, EventArgs e )
		{
			Debug.Assert( _addedCount == 1 );

			BackgroundWorker.RunWorkerAsync( AsyncArgument );
		}

		/// <summary>
		/// Handles the RunWorkerCompleted event of the backgroundWorker control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
		private void backgroundWorker_RunWorkerCompleted(
			object sender,
			RunWorkerCompletedEventArgs e )
		{
			// Remember for accessing from outside.
			WorkCompletedArgs = e;

			if ( e.Error == null )
			{
				// Just close the form.
				DialogResult = DialogResult.Cancel;
				Close();
			}
			else
			{
				LogCentral.Current.LogError(
					string.Format(
						@"Received exception from async worker function. Forwarding." ),
					e.Error );

				DialogResult = DialogResult.Cancel;
				Close();

				throw new Exception(
					"Error received from background worker. See inner exception for details.",
					e.Error );
			}
		}

		/// <summary>
		/// Handles the Tick event of the cancelGuardTimer control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void cancelGuardTimer_Tick(
			object sender,
			EventArgs e )
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
				"Background processing method does not respond within the given time frame." );
		}

		// ------------------------------------------------------------------
		#endregion
	}
}