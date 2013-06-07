namespace ZetaResourceEditor.UI.FileGroups
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Globalization;

	using System.Windows.Forms;
	using DevExpress.XtraEditors;
	using DevExpress.XtraEditors.Controls;
	using Helper;
	using Helper.Base;
	using Helper.Progress;
	using Main;
	using Properties;
	using RuntimeBusinessLogic.FileGroups;
	using RuntimeBusinessLogic.Language;
	using RuntimeBusinessLogic.ProjectFolders;
	using RuntimeBusinessLogic.Projects;
	using RuntimeBusinessLogic.Translation;
	using Translation;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Common.Collections;
	using Zeta.EnterpriseLibrary.Common.IO;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using Zeta.EnterpriseLibrary.Windows.Common;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	public partial class CreateNewFilesForm :
		FormBase
	{
		private Project _project;
		private ProjectFolder _projectFolder;

		public CreateNewFilesForm()
		{
			InitializeComponent();
		}

		public void Initialize(
			Project project,
			ProjectFolder projectFolder)
		{
			_project = project;
			_projectFolder = projectFolder;
		}

		private IEnumerable<Pair<string, string>> languageCodes
		{
			get
			{
				var fgs =
					_projectFolder == null
						? _project.FileGroups
						: _projectFolder.FileGroupsDeep;

				return fgs.GetLanguageCodesExtended(
					MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);
			}
		}

		public override void InitiallyFillLists()
		{
			var plc = projectLanguageCodes;
			var plcl = new List<string>(plc);

			foreach (var languageCode in languageCodes)
			{
				if (!string.IsNullOrEmpty(languageCode.First))
				{
					referenceLanguageComboBox.Properties.Items.Add(
						new Pair<string, Pair<string, string>>(
							string.Format(
								@"{0}{1} ({2})",
								plcl.Contains(languageCode.First) ? @"* " : string.Empty,
								LanguageCodeDetection.MakeValidCulture(languageCode.First).DisplayName,
								languageCode),
							languageCode));
				}
			}

			var items = new List<Pair<string, CultureInfo>>();

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				items.Add(
					new Pair<string, CultureInfo>(
						string.Format(
							@"{0}{1} [{2}]",
							plcl.Contains(culture.Name.ToLowerInvariant()) ? @"* " : string.Empty,
							culture.DisplayName,
							culture.Name
							),
						culture));
			}

			items.Sort((x, y) => string.CompareOrdinal(x.First, y.First));

			foreach (var item in items)
			{
				destinationLanguagesListBox.Items.Add(item);
			}

			// --

			fillTranslationEngine();
		}

		private void fillTranslationEngine()
		{
			var ti = TranslationHelper.GetTranslationEngine(_project);
			labelControl2.Text = ti.UserReadableName;
		}

		public override void UpdateUI()
		{
			base.UpdateUI();

			invertFileGroupsButton.Enabled =
				destinationLanguagesListBox.Items.Count > 0;
			selectNoFileGroupsButton.Enabled =
				destinationLanguagesListBox.CheckedItems.Count > 0;
			selectAllFileGroupsButton.Enabled =
				destinationLanguagesListBox.Items.Count > 0 &&
				destinationLanguagesListBox.CheckedItems.Count <
				destinationLanguagesListBox.Items.Count;

			buttonOK.Enabled =
				referenceLanguageComboBox.SelectedItem != null &&
				destinationLanguagesListBox.CheckedItems.Count > 0 &&
				string.Compare(
					((Pair<string, Pair<string, string>>)referenceLanguageComboBox.SelectedItem).Second.First,
					((Pair<string, CultureInfo>)destinationLanguagesListBox.CheckedItems[0]).Second.Name,
					StringComparison.OrdinalIgnoreCase) != 0 &&
				(!prefixCheckBox.Checked || prefixTextBox.Text.Trim().Length > 0);

			// --

			automaticallyTranslateCheckBox.Enabled =
				copyTextsCheckBox.Checked;

			if (!automaticallyTranslateCheckBox.Enabled)
			{
				automaticallyTranslateCheckBox.Checked = false;
			}

			if (!automaticallyTranslateCheckBox.Checked)
			{
				prefixCheckBox.Checked = false;
			}

			prefixCheckBox.Enabled =
				automaticallyTranslateCheckBox.Checked;

			prefixTextBox.Enabled =
				buttonDefault.Enabled =
				automaticallyTranslateCheckBox.Checked &&
				prefixCheckBox.Checked;
		}

		public override void FillItemToControls()
		{
			base.FillItemToControls();

			parentElementTextBox.Text =
				_projectFolder == null
					? _project.Name
					: _projectFolder.NameIntelli;

			prefixTextBox.Text = FileGroup.DefaultTranslatedPrefix;

			// --

			var storage =
				(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).DynamicSettingsGlobalHierarchical;

			referenceLanguageComboBox.SelectedIndex =
				Math.Min(
					ConvertHelper.ToInt32(
						PersistanceHelper.RestoreValue(
							storage,
							@"CreateNewFilesForm.referenceLanguageComboBox.SelectedIndex",
							referenceLanguageComboBox.SelectedIndex)),
					referenceLanguageComboBox.Properties.Items.Count - 1);

			DevExpressExtensionMethods.RestoreSettings(
				destinationLanguagesListBox,
				storage,
				@"CreateNewFilesForm.destinationLanguagesListBox");

			copyTextsCheckBox.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"CreateNewFilesForm.copyTextsCheckBox.Checked",
						copyTextsCheckBox.Checked));

			automaticallyTranslateCheckBox.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"CreateNewFilesForm.automaticallyTranslateCheckBox.Checked",
						automaticallyTranslateCheckBox.Checked));

			prefixTextBox.Text =
				ConvertHelper.ToString(
					PersistanceHelper.RestoreValue(
						storage,
						@"CreateNewFilesForm.prefixTextBox.Text",
						prefixTextBox.Text));

			prefixCheckBox.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"CreateNewFilesForm.prefixCheckBox.Checked",
						prefixCheckBox.Checked));

			// --
			// Select defaults.

			if (referenceLanguageComboBox.SelectedIndex < 0 &&
				 referenceLanguageComboBox.Properties.Items.Count > 0)
			{
				referenceLanguageComboBox.SelectedIndex = 0;
			}
		}

		public override void FillControlsToItem()
		{
			base.FillControlsToItem();

			var storage =
				(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).DynamicSettingsGlobalHierarchical;

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFilesForm.prefixTextBox.Text",
				prefixTextBox.Text);

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFilesForm.prefixCheckBox.Checked",
				prefixCheckBox.Checked);

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFilesForm.referenceLanguageComboBox.SelectedIndex",
				referenceLanguageComboBox.SelectedIndex);

			DevExpressExtensionMethods.PersistSettings(
				destinationLanguagesListBox,
				storage,
				@"CreateNewFilesForm.destinationLanguagesListBox");

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFilesForm.copyTextsCheckBox.Checked",
				copyTextsCheckBox.Checked);

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFilesForm.automaticallyTranslateCheckBox.Checked",
				automaticallyTranslateCheckBox.Checked);
		}

		private void CreateNewFileForm_Load(object sender, EventArgs e)
		{
			WinFormsPersistanceHelper.RestoreState(this);
			CenterToParent();

			InitiallyFillLists();
			FillItemToControls();

			UpdateUI();
		}

		private void CreateNewFileForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			WinFormsPersistanceHelper.SaveState(this);
			FillControlsToItem();
		}

		private void referenceLanguageGroupBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void referenceLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			using (new WaitCursor(this, WaitCursorOption.ShortSleep))
			{
				var sourceLanguageCode = ((Pair<string, Pair<string, string>>)referenceLanguageComboBox.SelectedItem).Second.First;
				var cultures = getCultures();
				var copyTextsFromSource = copyTextsCheckBox.Checked;
				var automaticallyTranslateTexts = automaticallyTranslateCheckBox.Checked;

				var created = 0;
				var skipped = 0;
				var added = 0;
				var notadded = 0;

				var prefix =
					prefixCheckBox.Checked
						? prefixTextBox.Text.Trim() + @" "
						: string.Empty;

				using (new BackgroundWorkerLongProgressGui(
					delegate(object snd, DoWorkEventArgs args)
					{
						try
						{
							var bw = (BackgroundWorker)snd;

							var fgs =
								_projectFolder == null
									? _project.FileGroups
									: _projectFolder.FileGroupsDeep;

							foreach (var fg in fgs)
							{
								if (bw.CancellationPending)
								{
									throw new OperationCanceledException();
								}

								foreach (var culture in cultures)
								{
									if (fg.HasLanguageCode(culture))
									{
										skipped++;
									}
									else
									{
										var sourceFile =
											fg.GetFileByLanguageCode(_project, sourceLanguageCode);
										//CHANGED BY Member 802361 check for nulls. It is possible there is no reference resource
										//we can either create or just skip. I choose skip because without base resx there is no sense.
										if (sourceFile != null)
										{
											var didCopy =
												fg.CreateAndAddNewFile(
													sourceFile.File.FullName,
													generateFileName(fg, culture),
													sourceLanguageCode,
													culture.Name,
													copyTextsFromSource,
													automaticallyTranslateTexts,
													prefix);

											if (didCopy) added++; else notadded++;

											created++;
										}
										else
										{
											skipped++;
										}
									}
								}
							}
						}
						catch (OperationCanceledException)
						{
							// Ignore.
						}
					},
					Resources.SR_CreateNewFilesForm_Creating,
					BackgroundWorkerLongProgressGui.CancellationMode.Cancelable,
					this))
				{
				}

				// --

				if (created <= 0)
				{
					XtraMessageBox.Show(
						this,
						Resources.SR_CreateNewFilesForm_Finished01,
						@"Zeta Resource Editor",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);

					UpdateUI();
				}
				else if (created > 0 && skipped > 0)
				{
					XtraMessageBox.Show(
						this,
						string.Format(
							Resources.SR_CreateNewFilesForm_Finished02,
							created,
							skipped),
						@"Zeta Resource Editor",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}
				else if ( notadded>0)
				{
					XtraMessageBox.Show(
						this,
						string.Format(
							Resources.SR_CreateNewFilesForm_Finished04,
							created,
							notadded),
						@"Zeta Resource Editor",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}
				else
				{
					XtraMessageBox.Show(
						this,
						string.Format(
							Resources.SR_CreateNewFilesForm_Finished03,
							created),
						@"Zeta Resource Editor",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}
			}
		}

		private CultureInfo[] getCultures()
		{
			var list = new List<CultureInfo>();

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (CheckedListBoxItem item in destinationLanguagesListBox.CheckedItems)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				var p = (Pair<string, CultureInfo>)item.Value;

				list.Add(p.Second);
			}

			return list.ToArray();
		}

		private static string generateFileName(
			FileGroup fileGroup,
			CultureInfo culture)
		{
			var pattern =
				new LanguageCodeDetection(fileGroup.Project).IsNeutralCulture(
					fileGroup.ParentSettings,
					culture)
					? fileGroup.Project.NeutralLanguageFileNamePattern
					: fileGroup.Project.NonNeutralLanguageFileNamePattern;

			pattern = pattern.Replace(@"[basename]", fileGroup.BaseName);
			pattern = pattern.Replace(@"[languagecode]", culture.Name);
			pattern = pattern.Replace(@"[extension]", fileGroup.BaseExtension);
			pattern = pattern.Replace(@"[optionaldefaulttypes]", fileGroup.BaseOptionalDefaultType);

			return pattern;
		}

		private void copyTextsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void automaticallyTranslateCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void prefixCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void prefixTextBox_EditValueChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void buttonDefault_Click(object sender, EventArgs e)
		{
			prefixTextBox.Text = FileGroup.DefaultTranslatedPrefix;
		}

		private void destinationLanguagesListBox_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
		{
			UpdateUI();
		}

		private void selectAllFileGroupsButton_Click(object sender, EventArgs e)
		{
			for (var index = 0; index < destinationLanguagesListBox.Items.Count; ++index)
			{
				destinationLanguagesListBox.SetItemChecked(index, true);
			}
		}

		private void selectNoFileGroupsButton_Click(object sender, EventArgs e)
		{
			for (var index = 0; index < destinationLanguagesListBox.Items.Count; ++index)
			{
				destinationLanguagesListBox.SetItemChecked(index, false);
			}
		}

		private void invertFileGroupsButton_Click(object sender, EventArgs e)
		{
			for (var index = 0; index < destinationLanguagesListBox.Items.Count; ++index)
			{
				destinationLanguagesListBox.SetItemChecked(
					index,
					!destinationLanguagesListBox.GetItemChecked(index));
			}
		}

		private void destinationLanguagesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void selectProjectLanguagesButton_Click(object sender, EventArgs e)
		{
			var plc = projectLanguageCodes;
			var plcl = new List<string>(plc);

			for (var index = 0; index < destinationLanguagesListBox.Items.Count; ++index)
			{
				var p = (Pair<string, CultureInfo>)((CheckedListBoxItem)destinationLanguagesListBox.GetItem(index)).Value;

				destinationLanguagesListBox.SetItemChecked(
					index,
					plcl.Contains(p.Second.Name.ToLowerInvariant()));
			}
		}

		private IEnumerable<string> projectLanguageCodes
		{
			get
			{
				var codes =
					new Set<string>
						{
							_project.NeutralLanguageCode
						};

				foreach (var group in _project.FileGroups)
				{
					foreach (var lc in group.GetLanguageCodes(_project))
					{
						if (!string.IsNullOrEmpty(lc))
						{
							codes.Add(lc);
						}
					}
				}

				codes.Sort();

				return codes.ToArray();
			}
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
							//InitiallyFillLists();
							//FillItemToControls();
							fillTranslationEngine();
						}
					}

					UpdateUI();
				}
			}
		}
	}
}