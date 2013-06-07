namespace ZetaResourceEditor.UI.Tools
{
	using System;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.IO;
	using System.Windows.Forms;
	using Code.DL;
	using Code.Helper;
	using DevExpress.XtraEditors;
	using Helper.Base;
	using DevComponents.DotNetBar;
	using Helper.Progress;
	using Main;
	using Properties;
	using Zeta.EnterpriseLibrary.Common.IO;
	using Zeta.EnterpriseLibrary.Windows.Common;

	internal partial class ImportExportWizard : FormBase
	{
		private readonly FileGroupCollection _groups;

		public ImportExportWizard( FileGroupCollection groups )
		{
			_groups = groups;

			InitializeComponent();
		}

		#region Event Handler
		// ------------------------------------------------------------------

		private void treeViewFileGroups_ItemChecked( object sender, ItemCheckedEventArgs e )
		{
			UpdateUI();
		}

		private void listBoxActions_SelectedIndexChanged( object sender, EventArgs e )
		{
			printDescriptionText();
			UpdateUI();
		}

		private void printDescriptionText()
		{
			var index = listBoxActions.SelectedIndex;
			switch ( index )
			{
				case 0:
					{
						labelDescription.Text =
							Resources.SR_ImportExportWizard_printDescriptionText_Translation;
						break;
					}
				case -1:
					{
						labelDescription.Text = string.Empty;
						break;
					}
				default:
					{
						throw new ArgumentOutOfRangeException();
					}
			}
		}

		private void wizard_CancelButtonClick( object sender, CancelEventArgs e )
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void wizard_FinishButtonClick(
			object sender,
			CancelEventArgs e )
		{
			var selected = new FileGroupCollection( null );
			foreach ( ListViewItem item in listViewFileGroups.Items )
			{
				if ( item.Checked && item.Tag != null && item.Tag is FileGroup )
				{
					selected.Add( item.Tag as FileGroup );
				}
			}

			var destinationFilePath = textBoxSourceDestination.Text.Trim();

			using ( var gui =
				new BackgroundWorkerLongProgressGui(
				// DoWork event handler.
					delegate
					{
						ImportExportHelper.ExportFileGroups(
							_groups.Project,
							destinationFilePath,
							selected,
							ImportExportType.Excel );
					},
						BackgroundWorkerLongProgressGui.CancellationMode.Cancelable
					) )
			{
				Debug.Assert( gui != null );
			}

			var dr = XtraMessageBox.Show(
				this,
				Resources.SR_ImportExportWizard_wizardFinishButtonClick_ExcelDocumentNow,
				@"Zeta Resource Editor",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button1 );

			if ( dr == DialogResult.Yes )
			{
				Process.Start( destinationFilePath );
			}

			// Finially close
			DialogResult = DialogResult.OK;
			Close();
		}

		/// <summary>
		/// Gets or sets the initial import export folder path.
		/// </summary>
		/// <value>The initial import export folder path.</value>
		private static DirectoryInfo initialImportExportFolderPath
		{
			get
			{
				return new DirectoryInfo(
					(string)FormHelper.RestoreValue(
					MainFormNew.UserStorageIntelligent,
					@"ImportExportFolderPath",
					Environment.GetFolderPath(
						Environment.SpecialFolder.MyDocuments ) ) );
			}
			set
			{
				FormHelper.SaveValue(
					MainFormNew.UserStorageIntelligent,
					@"ImportExportFolderPath",
					value );
			}
		}

		private void buttonBrowseFile_Click( object sender, EventArgs e )
		{
			using ( var dialog = new OpenFileDialog() )
			{
				var initial = initialImportExportFolderPath.FullName;
				dialog.InitialDirectory = initial;

				dialog.Multiselect = false;
				dialog.CheckFileExists = false;
				dialog.CheckPathExists = true;

				dialog.Filter =
					Resources.SR_ImportExportWizard_buttonBrowseFileClick_ExcelFilesXls +
					@"|*.xls";
				dialog.FilterIndex = 0;

				if ( dialog.ShowDialog( this ) == DialogResult.OK )
				{
					textBoxSourceDestination.Text = dialog.FileName;
					UpdateUI();

					initialImportExportFolderPath = new DirectoryInfo(
						Path.GetDirectoryName( dialog.FileName ) );
				}
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Procedures
		// ------------------------------------------------------------------

		private void initialize()
		{
			initiallyFillList();

			textBoxSourceDestination.Text =
				PathHelper.Combine(
					initialImportExportFolderPath.FullName,
					string.Format( @"{0:yyyy}-{0:MM}-{0:dd}_{0:HH}-{0:mm}-{0:ss}.xls",
						DateTime.Now ) );
		}

		private void initiallyFillList()
		{
			if ( _groups != null && _groups.Count > 0 )
			{
				foreach ( var group in _groups )
				{
					var fileGroupItem =
						new ListViewItem
						{
							Text = group.GetNameIntelli( _groups.Project ),
							ImageKey = @"group",
							Tag = group,
							ToolTipText = group.GetFullNameIntelli( _groups.Project ),
							Checked = true
						};

					listViewFileGroups.Items.Add( fileGroupItem );
				}

				FormHelper.ResizeListViewColumns(
					listViewFileGroups,
					0.99 );
			}
		}

		// ------------------------------------------------------------------
		#endregion

		#region Override
		// ------------------------------------------------------------------

		/// <summary>
		/// Update UI states, based on the state of the current selection, etc.
		/// </summary>
		public override void UpdateUI()
		{
			base.UpdateUI();

			wizardPage1.NextButtonEnabled =
				listBoxActions.SelectedItem == null
					? eWizardButtonState.False
					: eWizardButtonState.True;

			wizardPage2.NextButtonEnabled =
				listViewFileGroups.CheckedItems.Count == 0
					? eWizardButtonState.False
					: eWizardButtonState.True;

			wizardPage3.FinishButtonEnabled =
				string.IsNullOrEmpty( textBoxSourceDestination.Text.Trim() )
					? eWizardButtonState.False
					: eWizardButtonState.True;

			buttonCheckAll.Enabled = listViewFileGroups.Items.Count > 0 &&
				listViewFileGroups.Items.Count !=
					listViewFileGroups.CheckedItems.Count;
			buttonCheckNone.Enabled = listViewFileGroups.Items.Count > 0 &&
				listViewFileGroups.CheckedItems.Count > 0;
		}

		private void importExportWizard_Load( object sender, EventArgs e )
		{
			FormHelper.RestoreState( this );
			CenterToParent();

			initialize();

			listBoxActions.SelectedIndex = 0;
			listBoxActions_SelectedIndexChanged( null, null );
			listViewFileGroups_SizeChanged( null, null );
			UpdateUI();
		}

		private void importExportWizard_FormClosing(
			object sender,
			FormClosingEventArgs e )
		{
			FormHelper.SaveState( this );
		}

		private void listViewFileGroups_SizeChanged( object sender, EventArgs e )
		{
			FormHelper.ResizeListViewColumns( listViewFileGroups, 0.99 );
		}

		private void buttonCheckAll_Click( object sender, EventArgs e )
		{
			foreach ( ListViewItem item in listViewFileGroups.Items )
			{
				item.Checked = true;
			}

			UpdateUI();
		}

		private void buttonCheckNone_Click( object sender, EventArgs e )
		{
			foreach ( ListViewItem item in listViewFileGroups.Items )
			{
				item.Checked = false;
			}

			UpdateUI();
		}

		private void textBoxSourceDestination_TextChanged(
			object sender,
			EventArgs e )
		{
			UpdateUI();
		}

		// ------------------------------------------------------------------
		#endregion
	}
}
