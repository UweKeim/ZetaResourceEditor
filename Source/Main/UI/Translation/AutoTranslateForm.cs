namespace ZetaResourceEditor.UI.Translation
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Diagnostics;
	using System.Reflection;
	using System.Threading;
	using System.Windows.Forms;
	using DevExpress.XtraEditors;
	using DevExpress.XtraEditors.Controls;
	using Helper;
	using Helper.Base;
	using Helper.Progress;
	using Main;
	using Main.RightContent;
	using Properties;
	using RuntimeBusinessLogic.ExportImportExcel.Export;
	using RuntimeBusinessLogic.FileGroups;
	using RuntimeBusinessLogic.Language;
	using RuntimeBusinessLogic.Projects;
	using RuntimeBusinessLogic.Translation;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Common.IO;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using Zeta.EnterpriseLibrary.Windows.Common;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	// ----------------------------------------------------------------------
	#endregion

	public partial class AutoTranslateForm :
		FormBase
	{
		public static bool CheckShowAppIDsMissing()
		{
			var project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

			var ti = TranslationHelper.GetTranslationEngine(project);

			string appID;
			string appID2;

			TranslationHelper.GetTranslationAppID(
				project,
				out appID,
				out appID2);

			if (ti.AreAppIDsSyntacticallyValid(appID, appID2))
			{
				return false;
			}
			else
			{
				if (XtraMessageBox.Show(
					ActiveForm,
					Resources.AutoTranslateForm_CheckShowAppIDsMissing,
					@"Zeta Resource Editor",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					using (var form = new TranslateOptionsForm())
					{
						form.Initialize(project);

						return form.ShowDialog(ActiveForm) == DialogResult.OK;
					}
				}
				else
				{
					return false;
				}
			}
		}

		public static void CheckShowNewTranslationInfos()
		{
			var version = PersistanceHelper.RestoreValue(@"TranslationInfos.LastShownVersion");
			var show =
				version == null ||
				(
				new Version(version.ToString()) < new Version(2, 2, 0, 10) &&
				new Version(version.ToString()) < Assembly.GetExecutingAssembly().GetName().Version
				);

			if (show)
			{
				PersistanceHelper.SaveValue(
					@"TranslationInfos.LastShownVersion",
					Assembly.GetExecutingAssembly().GetName().Version);

				if (XtraMessageBox.Show(
						ActiveForm,
						Resources.AutoTranslateForm_CheckShowNewTranslationInfos_Google_changed_their_translation_settings__Do_you_want_to_read_how_you_can_continue_using_Google_Translate_,
						@"Zeta Resource Editor",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					Process.Start(new GoogleRestfulTranslationEngine().AppIDLink);
				}
			}
		}

		private ResourceEditorUserControl _fileGroupControl;
		private bool _initialAllowUpdatingDetails;
		private Project _project;
		private bool _ignore;

		public AutoTranslateForm()
		{
			InitializeComponent();
		}

		public void Initialize(
			ResourceEditorUserControl fileGroupControl)
		{
			_fileGroupControl = fileGroupControl;
			_project = MainForm.Current.ProjectFilesControl.Project ?? Project.Empty;

			// --

			if (_fileGroupControl.GridEditableData.Project == null)
			{
				_fileGroupControl.GridEditableData.Project = _project;
			}
		}

		private IEnumerable<string> languageCodes
		{
			get
			{
				return _fileGroupControl.GridEditableData.GetLanguageCodes(_project);
			}
		}

		public override void UpdateUI()
		{
			base.UpdateUI();

			buttonTranslate.Enabled =
				referenceLanguageGroupBox.SelectedIndex >= 0 &&
				languagesToTranslateCheckListBox.CheckedItems.Count > 0 &&
				(!prefixCheckBox.Checked || prefixTextBox.Text.Trim().Length > 0);

			buttonInvert.Enabled =
				languagesToTranslateCheckListBox.Items.Count > 0;
			buttonNone.Enabled =
				languagesToTranslateCheckListBox.CheckedItems.Count > 0;
			buttonAll.Enabled =
				languagesToTranslateCheckListBox.Items.Count > 0 &&
				languagesToTranslateCheckListBox.CheckedItems.Count <
				languagesToTranslateCheckListBox.Items.Count;

			prefixTextBox.Enabled =
				buttonDefault.Enabled =
				prefixCheckBox.Checked;

			buttonSettings.Enabled = _project != null;
		}

		public override void InitiallyFillLists()
		{
			base.InitiallyFillLists();

			var infos = new List<TranslationLanguageInfo>();

			string appID;
			string appID2;

			TranslationHelper.GetTranslationAppID(
				MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
				out appID,
				out appID2);

			var ti = TranslationHelper.GetTranslationEngine(_project);

			var lcs =
				ti.AreAppIDsSyntacticallyValid(appID, appID2)
					? ti.GetSourceLanguages(appID, appID2)
					: new TranslationLanguageInfo[] { };

			foreach (var languageCode in languageCodes)
			{
				// Only translate those that are supported.
				if (TranslationHelper.IsSupportedLanguage(languageCode, lcs))
				{
					if (string.IsNullOrEmpty(languageCode))
					{
						infos.Add(
							new TranslationLanguageInfo
								{
									UserReadableName = Resources.SR_TranslationHelper_GetSourceLanguages_AutoDetect,
									LanguageCode = string.Empty
								});
					}
					else
					{
						infos.Add(
							new TranslationLanguageInfo
								{
									UserReadableName = string.Format(
										@"{0} ({1})",
										LanguageCodeDetection.MakeValidCulture(languageCode).DisplayName,
										languageCode),
									LanguageCode = languageCode
								});
					}
				}
			}

			infos.Sort((x, y) => string.CompareOrdinal(x.UserReadableName, y.UserReadableName));

			referenceLanguageGroupBox.Properties.Items.Clear();
			foreach (var info in infos)
			{
				referenceLanguageGroupBox.Properties.Items.Add(info);
			}

			// --
			// Select defaults.

			_ignore = true;
			if (referenceLanguageGroupBox.SelectedIndex < 0 &&
				 referenceLanguageGroupBox.Properties.Items.Count > 0)
			{
				referenceLanguageGroupBox.SelectedIndex = 0;
			}
			_ignore = false;
		}

		private void restoreState(
			IPersistentPairStorage storage)
		{
			prefixTextBox.Text =
				ConvertHelper.ToString(
					PersistanceHelper.RestoreValue(
						storage,
						@"autoTranslateForm.prefixTextBox.Text",
						prefixTextBox.Text));

			prefixCheckBox.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"autoTranslateForm.prefixCheckBox.Checked",
						prefixCheckBox.Checked));

			_ignore = true;
			referenceLanguageGroupBox.SelectedIndex =
				Math.Min(
					ConvertHelper.ToInt32(
						PersistanceHelper.RestoreValue(
							storage,
							@"autoTranslateForm.referenceLanguageComboBoxEdit.SelectedIndex",
							referenceLanguageGroupBox.SelectedIndex)),
					referenceLanguageGroupBox.Properties.Items.Count - 1);
			_ignore = false;

			refillLanguagesToTranslate();

			DevExpressExtensionMethods.RestoreSettings(
				languagesToTranslateCheckListBox,
				storage,
				@"autoTranslateForm.languagesToTranslateCheckListBox");
		}

		private void saveState(
			IPersistentPairStorage storage)
		{
			PersistanceHelper.SaveValue(
				storage,
				@"autoTranslateForm.prefixTextBox.Text",
				prefixTextBox.Text);

			PersistanceHelper.SaveValue(
				storage,
				@"autoTranslateForm.prefixCheckBox.Checked",
				prefixCheckBox.Checked);

			PersistanceHelper.SaveValue(
				storage,
				@"autoTranslateForm.referenceLanguageComboBoxEdit.SelectedIndex",
				referenceLanguageGroupBox.SelectedIndex);

			DevExpressExtensionMethods.PersistSettings(
				languagesToTranslateCheckListBox,
				storage,
				@"autoTranslateForm.languagesToTranslateCheckListBox");
		}

		public override void FillItemToControls()
		{
			base.FillItemToControls();

			fileGroupTextBox.Text =
				_fileGroupControl.GridEditableData.GetNameIntelligent(_project);

			prefixTextBox.Text = FileGroup.DefaultTranslatedPrefix;

			// --

			if (_project != null)
			{
				restoreState(
					_project.DynamicSettingsGlobalHierarchical);
			}

			var ti = TranslationHelper.GetTranslationEngine(_project);
			labelControl1.Text = ti.UserReadableName;
		}

		private void refillLanguagesToTranslate()
		{
			var ti = TranslationHelper.GetTranslationEngine(_project);

			languagesToTranslateCheckListBox.Items.Clear();

			string appID;
			string appID2;

			TranslationHelper.GetTranslationAppID(
				MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
				out appID,
				out appID2);

			var forbidden =
				referenceLanguageGroupBox.SelectedIndex >= 0 &&
				referenceLanguageGroupBox.SelectedIndex <
				referenceLanguageGroupBox.Properties.Items.Count
					? ((TranslationLanguageInfo)referenceLanguageGroupBox.SelectedItem).LanguageCode
					: string.Empty;

			var lcs =
				ti.AreAppIDsSyntacticallyValid(appID, appID2)
					? ti.GetDestinationLanguages(appID, appID2)
					: new TranslationLanguageInfo[] { };

			foreach (var languageCode in languageCodes)
			{
				if (!string.IsNullOrEmpty(languageCode) &&
					 languageCode != forbidden)
				{
					// Only add those that are supported.
					if (TranslationHelper.IsSupportedLanguage(
						languageCode, lcs))
					{
						var index = languagesToTranslateCheckListBox.Items.Add(
							new TranslationLanguageInfo
								{
									UserReadableName = string.Format(
										@"{0} ({1})",
										LanguageCodeDetection.MakeValidCulture(languageCode).DisplayName,
										languageCode),
									LanguageCode = languageCode
								});

						languagesToTranslateCheckListBox.SetItemChecked(index, true);
					}
				}
			}
		}

		private void autoTranslateForm_Load(object sender, EventArgs e)
		{
			WinFormsPersistanceHelper.RestoreState(this);
			CenterToParent();

			InitiallyFillLists();
			FillItemToControls();

			_initialAllowUpdatingDetails = _fileGroupControl.AllowUpdatingDetails;
			_fileGroupControl.AllowUpdatingDetails = false;

			UpdateUI();
		}

		private void autoTranslateForm_FormClosing(
			object sender,
			FormClosingEventArgs e)
		{
			_fileGroupControl.AllowUpdatingDetails = _initialAllowUpdatingDetails;

			WinFormsPersistanceHelper.SaveState(this);

			if (_project != null)
			{
				using (new SilentProjectStoreGuard(_project))
				{
					saveState(_project.DynamicSettingsGlobalHierarchical);
				}
			}
		}

		private void fileGroupTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void referenceLanguageGroupBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_ignore)
			{
				refillLanguagesToTranslate();
				UpdateUI();
			}
		}

		private void languagesToTranslateCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void updateUITimer_Tick(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void buttonAll_Click(object sender, EventArgs e)
		{
			for (var index = 0; index < languagesToTranslateCheckListBox.Items.Count; ++index)
			{
				languagesToTranslateCheckListBox.SetItemChecked(index, true);
			}
		}

		private void buttonNone_Click(object sender, EventArgs e)
		{
			for (var index = 0; index < languagesToTranslateCheckListBox.Items.Count; ++index)
			{
				languagesToTranslateCheckListBox.SetItemChecked(index, false);
			}
		}

		private void buttonInvert_Click(object sender, EventArgs e)
		{
			for (var index = 0; index < languagesToTranslateCheckListBox.Items.Count; ++index)
			{
				languagesToTranslateCheckListBox.SetItemChecked(
					index,
					!languagesToTranslateCheckListBox.GetItemChecked(index));
			}
		}

		private void autoTranslateForm_Shown(object sender, EventArgs e)
		{
			updateUITimer.Start();
			CheckShowNewTranslationInfos();

			if (CheckShowAppIDsMissing())
			{
				InitiallyFillLists();
				FillItemToControls();
			}
		}

		private void buttonTranslate_Click(object sender, EventArgs e)
		{
			var success = false;
			var cancelled = false;
			var table = _fileGroupControl.GetDataSource();
			var translationCount = 0;
			var translationSuccessCount = 0;
			var translationErrorCount = 0;

			var continueOnErrors = _project == null || _project.TranslationContinueOnErrors;
			var delayMilliseconds = _project == null ? 500 : _project.TranslationDelayMilliseconds;

			var gridEditableData = _fileGroupControl.GridEditableData;

			var prefixSuccess =
				prefixCheckBox.Checked
					? prefixTextBox.Text.Trim() + @" "
					: string.Empty;

			var prefixError =
				FileGroup.DefaultTranslationErrorPrefix.Trim() + @" ";

			var refLanguageCode =
				((TranslationLanguageInfo)referenceLanguageGroupBox.SelectedItem).LanguageCode;
			var toTranslateLanguageCodes = new List<string>();

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (CheckedListBoxItem item in languagesToTranslateCheckListBox.CheckedItems)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				var pair = (TranslationLanguageInfo)item.Value;

				toTranslateLanguageCodes.Add(pair.LanguageCode.ToLowerInvariant());
			}

			_fileGroupControl.IsTranslating = true;
			try
			{
				using (
					new BackgroundWorkerLongProgressGui(
						delegate(
							object s,
							DoWorkEventArgs a)
						{
							var bw = (BackgroundWorker)s;

							// Column 0=FileGroup checksum, column 1=Tag name.
							var refValueIndex = 2;

#pragma warning disable 618,612
							var prev = DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection;
							DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
#pragma warning restore 618,612

							try
							{
								foreach (DataColumn column in table.Columns)
								{
									// Column 0=FileGroup checksum, column 1=Tag name.
									if (column.Ordinal > 1)
									{
										var raw =
											ExcelExportController.IsFileName(column.ColumnName)
												? new LanguageCodeDetection(_project)
													.DetectLanguageCodeFromFileName(
														gridEditableData.ParentSettings,
														column.ColumnName)
												: column.ColumnName;

										if (refLanguageCode == raw)
										{
											refValueIndex = column.Ordinal;
											break;
										}
									}
								}

								// --

								var ti =
									TranslationHelper.GetTranslationEngine(_project);

								string appID;
								string appID2;

								TranslationHelper.GetTranslationAppID(
									MainForm.Current.ProjectFilesControl.Project ?? Project.Empty,
									out appID,
									out appID2);

								foreach (DataColumn column in table.Columns)
								{
									// Column 0=FileGroup checksum, column 1=Tag name.
									if (column.Ordinal > 1 && column.Ordinal != refValueIndex)
									{
										var raw =
											ExcelExportController.IsFileName(column.ColumnName)
												? new LanguageCodeDetection(_project)
													.DetectLanguageCodeFromFileName(
														gridEditableData.ParentSettings,
														column.ColumnName)
												: column.ColumnName;

										if (toTranslateLanguageCodes.Contains(raw.ToLowerInvariant()))
										{
											if (ti.SupportsArrayTranslation)
											{
												translationSuccessCount =
													translateArray(
														appID,
														appID2,
														ti,
														table,
														refLanguageCode,
														column,
														refValueIndex,
														raw,
														bw,
														delayMilliseconds,
														prefixSuccess,
														translationSuccessCount,
														ref translationErrorCount,
														continueOnErrors,
														prefixError,
														ref translationCount);
											}
											else
											{
												translationSuccessCount =
													translateSingle(
														appID,
														appID2,
														ti,
														table,
														refLanguageCode,
														column,
														refValueIndex,
														raw,
														bw,
														delayMilliseconds,
														prefixSuccess,
														translationSuccessCount,
														ref translationErrorCount,
														continueOnErrors,
														prefixError,
														ref translationCount);
											}
										}
									}
								}
							}
							catch (OperationCanceledException)
							{
								// Do nothing.
							}
							finally
							{
#pragma warning disable 618,612
								DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = prev;
#pragma warning restore 618,612
							}
						},
						delegate(
							object s,
							RunWorkerCompletedEventArgs a)
						{
							success = !a.Cancelled && a.Error == null;
							cancelled = a.Cancelled;
						},
						BackgroundWorkerLongProgressGui.CancellationMode.Cancelable
						))
				{
				}
			}
			finally
			{
				_fileGroupControl.IsTranslating = false;
			}

			if (translationCount > 0)
			{
				_fileGroupControl.MarkGridContentAsModified();
				_fileGroupControl.MarkAsModified();
				_fileGroupControl.UpdateUI();
			}

			XtraMessageBox.Show(
				this,
				string.Format(
					Resources.SR_AutoTranslateForm_buttonTranslateClick_TranslatingTranslatedTexts,
					translationCount,
					translationSuccessCount,
					translationErrorCount),
				@"Zeta Resource Editor",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information,
				MessageBoxDefaultButton.Button1);

			if (success || cancelled)
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private int translateSingle(
			string appID,
			string appID2,
			ITranslationEngine ti,
			DataTable table,
			string refLanguageCode,
			DataColumn column,
			int refValueIndex,
			string raw,
			BackgroundWorker bw,
			int delayMilliseconds,
			string prefixSuccess,
			int translationSuccessCount,
			ref int translationErrorCount,
			bool continueOnErrors,
			string prefixError,
			ref int translationCount)
		{
			if (column != null)
			{
				foreach (DataRow row in table.Rows)
				{
					if (row != null)
					{
						if (bw.CancellationPending)
						{
							throw new OperationCanceledException();
						}

						var text = row[column] as string;
						if (!string.IsNullOrEmpty(text) && text.Trim().Length > 0)
						{
							continue;
						}

						// http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx?msg=3367544#xx3367544xx
						if (FileGroup.IsInternalRow(row))
						{
							continue;
						}

						var sourceText =
							row[refValueIndex] as string;

						if (string.IsNullOrEmpty(sourceText))
						{
							continue;
						}

						if (delayMilliseconds > 0)
						{
							Thread.Sleep(delayMilliseconds);
						}

						try
						{
							var destinationText =
								prefixSuccess +
								ti.Translate(
									appID, appID2,
									sourceText,
									ti.MapCultureToSourceLanguageCode(
										appID, appID2,
										CultureHelper.CreateCultureErrorTolerant(refLanguageCode)),
									ti.MapCultureToDestinationLanguageCode(
										appID, appID2,
										CultureHelper.CreateCultureErrorTolerant(raw)),
									_project.TranslationWordsToProtect,
									_project.TranslationWordsToRemove);

							row[column] = destinationText;

							translationSuccessCount++;
						}
						catch (Exception x)
						{
							translationErrorCount++;

							if (continueOnErrors)
							{
								var destinationText = prefixError + x.Message;

								if (row[column] != null)
								{
									row[column] = destinationText;
								}
							}
							else
							{
								throw;
							}
						}

						translationCount++;
					}
				}
			}
			return translationSuccessCount;
		}

		private class TranslateItemInfo
		{
			public DataRow Row { get; set; }
			public string SourceText { get; set; }
		}

		private int translateArray(
			string appID,
			string appID2,
			ITranslationEngine ti,
			DataTable table,
			string refLanguageCode,
			DataColumn column,
			int refValueIndex,
			string raw,
			BackgroundWorker bw,
			int delayMilliseconds,
			string prefixSuccess,
			int translationSuccessCount,
			ref int translationErrorCount,
			bool continueOnErrors,
			string prefixError,
			ref int translationCount)
		{
			var items = new List<TranslateItemInfo>();

			// --
			// From GUI to in-memory-list.

			if (column != null)
			{
				foreach (DataRow row in table.Rows)
				{
					if (row != null)
					{
						if (bw.CancellationPending)
						{
							throw new OperationCanceledException();
						}

						var text = row[column] as string;
						if (!string.IsNullOrEmpty(text) && text.Trim().Length > 0)
						{
							continue;
						}

						// http://www.codeproject.com/KB/aspnet/ZetaResourceEditor.aspx?msg=3367544#xx3367544xx
						if (FileGroup.IsInternalRow(row))
						{
							continue;
						}

						var sourceText =
							row[refValueIndex] as string;

						if (string.IsNullOrEmpty(sourceText))
						{
							continue;
						}

						items.Add(new TranslateItemInfo { Row = row, SourceText = sourceText });
					}

					// --
					// Pack into blocks.

					var blocks = new List<List<TranslateItemInfo>>();

					for (var index = 0; index < items.Count; index++)
					{
						if (index % ti.MaxArraySize == 0)
						{
							blocks.Add(new List<TranslateItemInfo>());
						}

						blocks[blocks.Count - 1].Add(items[index]);
					}

					// --
					// Translate each block in batch.

					foreach (var block in blocks)
					{
						if (block != null)
						{
							if (bw.CancellationPending)
							{
								throw new OperationCanceledException();
							}
							if (delayMilliseconds > 0)
							{
								Thread.Sleep(delayMilliseconds);
							}

							var sourceTexts = new List<string>();
							foreach (var itemInfo in block)
							{
								sourceTexts.Add(itemInfo.SourceText);
							}

							try
							{
								var destinationTexts =
									ti.TranslateArray(
										appID,
										appID2,
										sourceTexts.ToArray(),
										ti.MapCultureToSourceLanguageCode(
											appID, appID2,
											CultureHelper.CreateCultureErrorTolerant(refLanguageCode)),
										ti.MapCultureToDestinationLanguageCode(
											appID, appID2,
											CultureHelper.CreateCultureErrorTolerant(raw)),
										_project.TranslationWordsToProtect,
										_project.TranslationWordsToRemove);

								for (var index = 0; index < block.Count; ++index)
								{
									block[index].Row[column] = prefixSuccess + destinationTexts[index];

									translationSuccessCount++;
								}
							}
							catch (Exception x)
							{
								translationErrorCount++;

								if (continueOnErrors)
								{
									var destinationText =
										prefixError +
										x.Message;

									foreach (var t in block)
									{
										if (t != null && t.Row != null && t.Row[column] != null)
										{
											t.Row[column] = destinationText;
										}
									}
								}
								else
								{
									throw;
								}
							}

							translationCount++;
						}
					}
				}
			}

			return translationSuccessCount;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void prefixTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void languagesToTranslateCheckListBox_ItemCheck(
			object sender,
			DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
		{
			UpdateUI();
		}

		private void buttonDefault_Click(object sender, EventArgs e)
		{
			prefixTextBox.Text = FileGroup.DefaultTranslatedPrefix;
		}

		private void buttonSettings_Click(object sender, EventArgs e)
		{
			using (var form = new TranslateOptionsForm())
			{
				form.Initialize(_project);

				if (form.ShowDialog(this) == DialogResult.OK)
				{
					if (form.TranslationProviderChanged)
					{
						using (new WaitCursor(this))
						{
							InitiallyFillLists();
							FillItemToControls();
						}
					}

					UpdateUI();
				}
			}
		}
	}
}