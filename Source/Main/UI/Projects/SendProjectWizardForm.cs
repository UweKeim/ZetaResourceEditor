namespace ZetaResourceEditor.UI.Projects
{
	using System;
	using System.ComponentModel;
	using System.Threading;
	using System.Windows.Forms;
	using Code;
	using DevExpress.XtraBars;
	using DevExpress.XtraEditors;
	using DevExpress.XtraEditors.Controls;
	using DevExpress.XtraWizard;
	using Helper.Base;
	using Helper.ErrorHandling;
	using Main;
	using Properties;
	using Runtime;
	using RuntimeBusinessLogic.ExportImportExcel;
	using RuntimeBusinessLogic.Projects;
	using RuntimeUserInterface.Shell;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Common.IO;
	using Zeta.EnterpriseLibrary.Logging;
	using Zeta.EnterpriseLibrary.Tools;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using Zeta.EnterpriseLibrary.Windows.Persistance;
	using ZetaLongPaths;

	public partial class SendProjectWizardForm :
		FormBase
	{
		private Project _project;
		private readonly string _initialZulSubject;
		private readonly string _initialZulBody;
		private SendProjectResult _result;
		private Exception _exception;

		public SendProjectWizardForm()
		{
			InitializeComponent();

			if (!DesignMode)
			{
				wizardControl.Text = string.Empty;

				_initialZulSubject = zulSubjectTextEdit.Text.Trim();
				_initialZulBody = zulBodyTextEdit.Text.Trim();
			}
		}

		public void Initialize(Project project)
		{
			_project = project;
		}

		public override void InitiallyFillLists()
		{
			base.InitiallyFillLists();

			// --

			zulReceiversTextEdit.Properties.Items.Add(SendProjectController.VendorReceiverGuiName);
		}

		public override void FillItemToControls()
		{
			base.FillItemToControls();

			restoreState(_project.DynamicSettingsGlobalHierarchical);
		}

		private void restoreState(
			IPersistentPairStorage storage)
		{
			exportProjectFileCheckEdit.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"sendProjectWizardForm.exportProjectFileCheckEdit.Checked",
						exportProjectFileCheckEdit.Checked));
			exportResourceFilesCheckEdit.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"sendProjectWizardForm.exportResourceFilesCheckEdit.Checked",
						exportResourceFilesCheckEdit.Checked));
			exportLocalSettingsCheckEdit.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"exportLocalSettingsCheckEdit.exportResourceFilesCheckEdit.Checked",
						exportLocalSettingsCheckEdit.Checked));

			zulReceiversTextEdit.Text =
				ConvertHelper.ToString(
					PersistanceHelper.RestoreValue(
						storage,
						@"sendProjectWizardForm.zulReceiversTextEdit.Text",
						SendProjectController.VendorReceiverGuiName));
			zulSubjectTextEdit.Text =
				ConvertHelper.ToString(
					PersistanceHelper.RestoreValue(
						storage,
						@"sendProjectWizardForm.zulSubjectTextEdit.Text",
						zulSubjectTextEdit.Text));
			zulBodyTextEdit.Text =
				ConvertHelper.ToString(
					PersistanceHelper.RestoreValue(
						storage,
						@"sendProjectWizardForm.zulBodyTextEdit.Text",
						zulBodyTextEdit.Text));
		}

		private void saveState(
			IPersistentPairStorage storage)
		{
			using (new SilentProjectStoreGuard(_project))
			{
				PersistanceHelper.SaveValue(
					storage,
					@"sendProjectWizardForm.exportProjectFileCheckEdit.Checked",
					exportProjectFileCheckEdit.Checked);
				PersistanceHelper.SaveValue(
					storage,
					@"sendProjectWizardForm.exportResourceFilesCheckEdit.Checked",
					exportResourceFilesCheckEdit.Checked);
				PersistanceHelper.SaveValue(
					storage,
					@"sendProjectWizardForm.exportLocalSettingsCheckEdit.Checked",
					exportLocalSettingsCheckEdit.Checked);

				PersistanceHelper.SaveValue(
					storage,
					@"sendProjectWizardForm.zulReceiversTextEdit.Text",
					zulReceiversTextEdit.Text);
				PersistanceHelper.SaveValue(
					storage,
					@"sendProjectWizardForm.zulSubjectTextEdit.Text",
					zulSubjectTextEdit.Text);
				PersistanceHelper.SaveValue(
					storage,
					@"sendProjectWizardForm.zulBodyTextEdit.Text",
					zulBodyTextEdit.Text);
			}
		}

		public override void UpdateUI()
		{
			base.UpdateUI();

			doUpdateUI(wizardControl.SelectedPage);
		}

		private void doUpdateUI(BaseWizardPage selectedPage)
		{
			if (selectedPage == optionsWizardPage)
			{
				selectedPage.AllowNext =
					exportLocalSettingsCheckEdit.Checked ||
					exportProjectFileCheckEdit.Checked ||
					exportResourceFilesCheckEdit.Checked;
			}
			else if (selectedPage == receiversWizardPage)
			{
				selectedPage.AllowNext =
					string.Compare(zulReceiversTextEdit.Text.Trim(), SendProjectController.VendorReceiverGuiName,
								   StringComparison.OrdinalIgnoreCase) == 0 ||
					StringHelper.IsValidEMailAddress(zulReceiversTextEdit.Text.Trim());
			}
			else if (selectedPage == progressWizardPage)
			{
				selectedPage.AllowBack = false;
				selectedPage.AllowNext = false;
			}
			else if (selectedPage == errorOccurredWizardPage)
			{
			}
			else if (selectedPage == successWizardPage)
			{

			}
			else
			{
				throw new Exception();
			}
		}

		private void wizardControl_CustomizeCommandButtons(object sender, CustomizeCommandButtonsEventArgs e)
		{
			var selectedPage = e.Page;

			if (selectedPage == optionsWizardPage)
			{
				e.NextButton.Text = "Next >";
			}
			else if (selectedPage == receiversWizardPage)
			{
				e.NextButton.Text = "Send";
			}
			else if (selectedPage == progressWizardPage)
			{
				e.NextButton.Visible = false;
				e.PrevButton.Visible = false;
			}
			else if (selectedPage == errorOccurredWizardPage)
			{
				e.NextButton.Visible = false;
				e.PrevButton.Visible = false;
			}
			else if (selectedPage == successWizardPage)
			{
				e.FinishButton.Visible = false;
				e.NextButton.Visible = false;
				e.PrevButton.Visible = false;

				e.CancelButton.Text = "Close";
			}
			else
			{
				throw new Exception();
			}
		}

		private void SendProjectWizardForm_Load(object sender, EventArgs e)
		{
			WinFormsPersistanceHelper.RestoreState(this);
			CenterToParent();

			InitiallyFillLists();
			FillItemToControls();

			UpdateUI();
		}

		private void SendProjectWizardForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				if (progressBackgroundWorker.IsBusy)
				{
					e.Cancel = true;
					return;
				}
			}

			checkStopBackgroundWorker();

			WinFormsPersistanceHelper.SaveState(this);
			saveState(_project.DynamicSettingsGlobalHierarchical);
		}

		private void checkStopBackgroundWorker()
		{
			if (progressBackgroundWorker.IsBusy)
			{
				progressBackgroundWorker.CancelAsync();

				while (progressBackgroundWorker.IsBusy)
				{
					Thread.Sleep(200);
					Application.DoEvents();
				}
			}
		}

		private void hyperLinkEdit1_OpenLink(object sender, OpenLinkEventArgs e)
		{
			var sei =
				new ShellExecuteInformation
				{
					FileName = @"https://www.zeta-uploader.com"
				};
			sei.Execute();
		}

		private void exportProjectFileCheckEdit_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void exportResourceFilesCheckEdit_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void exportLocalSettingsCheckEdit_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void zulReceiversTextEdit_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void zulReceiversTextEdit_EditValueChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void zulSubjectTextEdit_EditValueChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void zulBodyTextEdit_EditValueChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void buttonZulReset_Click(object sender, EventArgs e)
		{
			zulSubjectTextEdit.Text = _initialZulSubject;
			zulBodyTextEdit.Text = _initialZulBody;
		}

		private void progressBackgroundWorker_DoWork(
			object sender,
			DoWorkEventArgs e)
		{
			Host.ApplyLanguageSettingsToCurrentThread();

			var ei = (SendProjectInformation)e.Argument;
			var cp = new SendProjectController();

			_result = cp.SendProject((BackgroundWorker)sender, ei);
		}

		private void progressBackgroundWorker_ProgressChanged(
			object sender,
			ProgressChangedEventArgs e)
		{
			var s = e.UserState as ExcelProgressInformation;

			if (s == null)
			{
				var t = e.UserState as string;

				if (t == null)
				{
					progressLabel.Visible = false;
					progressLabel.Text = string.Empty;
				}
				else
				{
					progressLabel.Visible = !StringExtensionMethods.IsNullOrWhiteSpace(t);
					progressLabel.Text = t;
				}
			}
			else
			{
				if (string.IsNullOrEmpty(s.TemporaryProgressMessage))
				{
					progressLabel.Visible = false;
					progressLabel.Text = string.Empty;
				}
				else
				{
					progressLabel.Visible = true;
					progressLabel.Text = s.TemporaryProgressMessage;
				}
			}
		}

		private void progressBackgroundWorker_RunWorkerCompleted(
			object sender,
			RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled || e.Error is OperationCanceledException)
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
			else if (e.Error != null)
			{
				_exception = e.Error;
				errorTextMemoEdit.Text = e.Error.Message;
				wizardControl.SelectedPage = errorOccurredWizardPage;
				UpdateUI();
			}
			else
			{
				wizardControl.SelectedPage = successWizardPage;
				UpdateUI();
			}
		}

		private void wizardControl_NextClick(
			object sender,
			WizardCommandButtonClickEventArgs e)
		{
			if (e.Page == receiversWizardPage)
			{
				if (!saveProject())
				{
					// Stay on same page.
					e.Handled = true;
				}
				else
				{
					e.Handled = true;
					wizardControl.SelectedPage = progressWizardPage;

					doExport();
				}
			}
		}

		private static bool saveProject()
		{
			// Must persist everything to file before exporting,
			// since the export relies on files, not in-memory.
			return MainForm.Current.SaveAllWithDialog();
		}

		private void wizardControl_PrevClick(
			object sender,
			WizardCommandButtonClickEventArgs e)
		{
			if (e.Page == errorOccurredWizardPage)
			{
				wizardControl.SelectedPage = receiversWizardPage;
				e.Handled = true;
			}
		}

		private void wizardControl_CancelClick(
			object sender,
			CancelEventArgs e)
		{
			if (wizardControl.SelectedPage == progressWizardPage)
			{
				if (XtraMessageBox.Show(
						this,
						Resources.SR_ConfirmCancelExport,
						@"Zeta Resource Editor",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					checkStopBackgroundWorker();
				}
				else
				{
					DialogResult = DialogResult.None;
					e.Cancel = true;
				}
			}
			else
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private void wizardControl_FinishClick(object sender, CancelEventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void doExport()
		{
			var ei =
				new SendProjectInformation
					{
						Project = _project,
						SendLocalSettings = exportLocalSettingsCheckEdit.Checked,
						SendProjectFile = exportProjectFileCheckEdit.Checked,
						SendResourceFiles = exportResourceFilesCheckEdit.Checked,
						SettingsFilePath = ZlpPathHelper.Combine(
							Host.CurrentUserStorageBaseFolderPath.FullName,
							@"zeta-resource-editor-settings.xml"),
						SendFilesEMailReceivers = zulReceiversTextEdit.Text.Trim(),
						SendFilesEMailSubject = zulSubjectTextEdit.Text.Trim(),
						SendFilesEMailBody = zulBodyTextEdit.Text.Trim()
					};

			// --

			progressBackgroundWorker.RunWorkerAsync(ei);
			UpdateUI();
		}

		private void detailedErrorsButton_ItemClick(object sender, ItemClickEventArgs e)
		{
			using (var form = new TextBoxForm())
			{
				var message = Logger.MakeTraceMessage(_exception);
				form.Initialize(message);

				form.ShowDialog(this);
			}
		}

		private void optionsPopupMenu_BeforePopup(object sender, CancelEventArgs e)
		{
			UpdateUI();
		}

		private void downloadProjectUrlLinkEdit_OpenLink(object sender, OpenLinkEventArgs e)
		{
			var sei =
				new ShellExecuteInformation
					{
						FileName = _result.DownloadUrl
					};
			sei.Execute();
		}

		private void wizardControl_SelectedPageChanged(object sender, WizardPageChangedEventArgs e)
		{
			UpdateUI();
		}
	}
}