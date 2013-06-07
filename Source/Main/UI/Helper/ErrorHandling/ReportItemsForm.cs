namespace ZetaResourceEditor.UI.Helper.ErrorHandling
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.IO;
	using System.Windows.Forms;
	using RuntimeBusinessLogic.WebServices;
	using Base;
	using DevExpress.XtraEditors;
	using DevExpress.XtraEditors.Controls;
	using Properties;
	using RuntimeBusinessLogic.ZetaUploader;
	using Zeta.EnterpriseLibrary.Common.IO.Compression;
	using Zeta.EnterpriseLibrary.Tools;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using Zeta.EnterpriseLibrary.Windows.Common;
	using Zeta.EnterpriseLibrary.Windows.Persistance;
	using Zeta.EnterpriseLibrary.Common.Collections;
	using ZetaLongPaths;

	public partial class ReportItemsForm :
		FormBase
	{
		public ReportItemsForm(
			ZetaUploaderCommunicationClientTransferInformation sendInfo )
		{
			InitializeComponent();

			_sendInfo = sendInfo;
		}

		private readonly ZetaUploaderCommunicationClientTransferInformation _sendInfo;

		private void ReportIssueForm_Load(
			object sender,
			EventArgs e )
		{
			WinFormsPersistanceHelper.RestoreState( this );
			CenterToParent();

			emailAddressTextBox.Text =
				PersistanceHelper.RestoreValue(
				@"ReportIssueForm.emailAddressTextBox.Text" ) as string;
			additionalRemarksTextBox.Text =
				PersistanceHelper.RestoreValue(
				@"ReportIssueForm.additionalRemarksTextBox.Text" ) as string;

			FillList();

			UpdateUI();
			//itemsListView_SizeChanged( null, null );
		}

		private void FillList()
		{
			var infos =
				DecompressionHelper.DecompressItems( _sendInfo.FileContent );

			itemsListView.Items.Clear();

			if ( infos != null )
			{
				foreach ( var info in infos )
				{
					var item =
						new ImageListBoxItem(
							new Pair<string, DecompressedItemInfo>(
								info.FileName,
								info), 0);

					itemsListView.Items.Add( item );
				}
			}

			UpdateUI();
		}

		private void ReportIssueForm_FormClosing(
			object sender,
			FormClosingEventArgs e )
		{
			PersistanceHelper.SaveValue(
				@"ReportIssueForm.emailAddressTextBox.Text",
				emailAddressTextBox.Text );
			PersistanceHelper.SaveValue(
				@"ReportIssueForm.additionalRemarksTextBox.Text",
				additionalRemarksTextBox.Text );

			WinFormsPersistanceHelper.SaveState( this );

			foreach ( var tempFilePath in _temporaryFilePathsToDelete )
			{
				if ( ZlpIOHelper.FileExists( tempFilePath ) )
				{
					ZlpIOHelper.DeleteFile(tempFilePath);
				}
			}
		}

		private void itemsListView_SelectedIndexChanged(
			object sender,
			EventArgs e )
		{
			UpdateUI();
		}

		public override void UpdateUI()
		{
			base.UpdateUI();

			buttonShow.Enabled = itemsListView.SelectedItems.Count > 0;
		}

		private void buttonShow_Click(
			object sender,
			EventArgs e )
		{
			var item = (ImageListBoxItem) itemsListView.SelectedItems[0];
			var info = ((Pair<string, DecompressedItemInfo>) item.Value).Second;

			var tempFilePath = ZlpPathHelper.Combine(
				Path.GetTempPath(),
				info.FileName );

			if (ZlpIOHelper.FileExists(tempFilePath))
			{
				ZlpIOHelper.DeleteFile(tempFilePath);
			}

			using ( var sw = new StreamWriter( tempFilePath ) )
			{
				sw.Write( info.DecompressedString );
			}

			_temporaryFilePathsToDelete.Add( tempFilePath );

			var processInfo =
				new ProcessStartInfo
				{
					UseShellExecute = true,
					FileName = tempFilePath
				};
			Process.Start( processInfo );
		}

		private readonly List<string> _temporaryFilePathsToDelete =new List<string>();

		private void itemsListView_DoubleClick(
			object sender,
			EventArgs e )
		{
			UpdateUI();

			if ( buttonShow.Enabled )
			{
				buttonShow_Click( null, null );
			}
		}

		private void buttonOK_Click(
			object sender,
			EventArgs e )
		{
			using ( new WaitCursor( this ) )
			{
				string emailAddress = emailAddressTextBox.Text.Trim();
				string additionalRemarks = additionalRemarksTextBox.Text.Trim();

				if ( emailAddress.Length > 0 ||
					additionalRemarks.Length > 0 )
				{
					if ( _sendInfo.AdditionalRemarks != null &&
						_sendInfo.AdditionalRemarks.Trim().Length > 0 )
					{
						_sendInfo.AdditionalRemarks =
							_sendInfo.AdditionalRemarks.Trim() + Environment.NewLine + Environment.NewLine;
					}

					if ( StringHelper.IsValidEMailAddress( emailAddress ) )
					{
						_sendInfo.AdditionalRemarks +=
							string.Format(
							"E-mail address: mailto:{0}.",
							emailAddress );
					}

					if ( _sendInfo.AdditionalRemarks != null &&
						_sendInfo.AdditionalRemarks.Trim().Length > 0 )
					{
						_sendInfo.AdditionalRemarks =
							_sendInfo.AdditionalRemarks.Trim() + "\r\n\r\n";
					}

					if ( additionalRemarks.Length > 0 )
					{
						_sendInfo.AdditionalRemarks +=
							string.Format(
							"Additional remarks:\r\n{0}.",
							additionalRemarks.TrimEnd( '.' ) );
					}
				}

				// --

				var ws = WebServiceManager.Current.ZetaUploaderWS;
				ws.SendFile( _sendInfo );

				// --

				XtraMessageBox.Show(
					this,
					Resources.SR_ReportItemsForm_buttonOKClick_ThankYou,
					@"Zeta Resource Editor",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information );

				Close();
			}
		}
	}
}