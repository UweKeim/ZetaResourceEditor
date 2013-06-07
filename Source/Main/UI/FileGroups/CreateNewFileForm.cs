namespace ZetaResourceEditor.UI.FileGroups
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.IO;

	using System.Windows.Forms;
	using DevExpress.XtraEditors;
	using Helper.Base;
	using Main;
	using Properties;
	using RuntimeBusinessLogic.FileGroups;
	using RuntimeBusinessLogic.Language;
	using RuntimeBusinessLogic.Projects;
	using RuntimeBusinessLogic.Translation;
	using Translation;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Common.Collections;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using Zeta.EnterpriseLibrary.Windows.Common;
	using Zeta.EnterpriseLibrary.Windows.Persistance;

	public partial class CreateNewFileForm :
		FormBase
	{
		private FileGroup _fileGroup;

		public CreateNewFileForm()
		{
			InitializeComponent();
		}

		public void Initialize(
			FileGroup fileGroup)
		{
			_fileGroup = fileGroup;
		}

		private IEnumerable<Pair<string, string>> languageCodes
		{
			get
			{
				return _fileGroup.GetLanguageCodesExtended(
					MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);
			}
		}

		public override void InitiallyFillLists()
		{
			foreach (var languageCode in languageCodes)
			{
				if (!string.IsNullOrEmpty(languageCode.First))
				{
					referenceLanguageComboBox.Properties.Items.Add(
						new Pair<string, Pair<string, string>>(
							string.Format(
								@"{0} ({1})",
								LanguageCodeDetection.MakeValidCulture(languageCode.First).DisplayName,
								languageCode),
							languageCode));
				}
			}

			var items = new List<Pair<string, CultureInfo>>();

			foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
			{
				items.Add(new Pair<string, CultureInfo>(culture.DisplayName, culture));
			}

			items.Sort((x, y) => string.CompareOrdinal(x.First, y.First));

			foreach (var item in items)
			{
				newLanguageComboBox.Properties.Items.Add(item);
			}

			// --

			fillTranslationEngine();
		}

		private void fillTranslationEngine()
		{
			var ti = TranslationHelper.GetTranslationEngine(
				MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);
			labelControl3.Text = ti.UserReadableName;
		}

		public override void UpdateUI()
		{
			base.UpdateUI();

			buttonOK.Enabled =
				referenceLanguageComboBox.SelectedItem != null &&
				newLanguageComboBox.SelectedItem != null &&
				string.Compare(
					((Pair<string, Pair<string, string>>) referenceLanguageComboBox.SelectedItem).Second.First,
					((Pair<string, CultureInfo>) newLanguageComboBox.SelectedItem).Second.Name,
					StringComparison.OrdinalIgnoreCase) != 0 &&
				newFileNameTextBox.Text.Trim().Length > 0 &&
				newFileNameTextBox.Text.Trim().IndexOfAny(Path.GetInvalidFileNameChars()) < 0 &&
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

			fileGroupTextBox.Text =
				_fileGroup.GetNameIntelligent(
					MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);

			prefixTextBox.Text = FileGroup.DefaultTranslatedPrefix;

			// --

			var storage =
				(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).DynamicSettingsGlobalHierarchical;

			referenceLanguageComboBox.SelectedIndex =
				Math.Min(
					ConvertHelper.ToInt32(
						PersistanceHelper.RestoreValue(
						storage,
							@"CreateNewFileForm.referenceLanguageComboBox.SelectedIndex",
							referenceLanguageComboBox.SelectedIndex)),
					referenceLanguageComboBox.Properties.Items.Count - 1);

			newLanguageComboBox.SelectedIndex =
				Math.Min(
					ConvertHelper.ToInt32(
						PersistanceHelper.RestoreValue(
						storage,
							@"CreateNewFileForm.newLanguageComboBox.SelectedIndex",
							newLanguageComboBox.SelectedIndex)),
					newLanguageComboBox.Properties.Items.Count - 1);

			copyTextsCheckBox.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"CreateNewFileForm.copyTextsCheckBox.Checked",
						copyTextsCheckBox.Checked));

			automaticallyTranslateCheckBox.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"CreateNewFileForm.automaticallyTranslateCheckBox.Checked",
						automaticallyTranslateCheckBox.Checked));

			prefixTextBox.Text =
				ConvertHelper.ToString(
					PersistanceHelper.RestoreValue(
						storage,
						@"CreateNewFileForm.prefixTextBox.Text",
						prefixTextBox.Text));

			prefixCheckBox.Checked =
				ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(
						storage,
						@"CreateNewFileForm.prefixCheckBox.Checked",
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
				@"CreateNewFileForm.prefixTextBox.Text",
				prefixTextBox.Text);

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFileForm.prefixCheckBox.Checked",
				prefixCheckBox.Checked);

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFileForm.referenceLanguageComboBox.SelectedIndex",
				referenceLanguageComboBox.SelectedIndex);

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFileForm.newLanguageComboBox.SelectedIndex",
				newLanguageComboBox.SelectedIndex);

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFileForm.copyTextsCheckBox.Checked",
				copyTextsCheckBox.Checked);

			PersistanceHelper.SaveValue(
				storage,
				@"CreateNewFileForm.automaticallyTranslateCheckBox.Checked",
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

		private void newLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateUI();
			updateNewFileNameFromLanguage();
		}

		private void updateNewFileNameFromLanguage()
		{
			var culture =
				((Pair<string, CultureInfo>)newLanguageComboBox.SelectedItem).Second;

			var pattern =
				new LanguageCodeDetection(MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).IsNeutralCulture(
				_fileGroup.ParentSettings,
					culture)
					? (MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).NeutralLanguageFileNamePattern
					: (MainForm.Current.ProjectFilesControl.Project ?? Project.Empty).NonNeutralLanguageFileNamePattern;

			pattern = pattern.Replace(@"[basename]", _fileGroup.BaseName);
			pattern = pattern.Replace(@"[languagecode]", ((Pair<string, CultureInfo>)newLanguageComboBox.SelectedItem).Second.Name);
			pattern = pattern.Replace(@"[extension]", _fileGroup.BaseExtension);
			// AJ CHANGE 
			pattern = pattern.Replace(@"[optionaldefaulttypes]", _fileGroup.BaseOptionalDefaultType);

			newFileNameTextBox.Text = pattern;
		}

		private void newLanguageComboBox_TextChanged(object sender, EventArgs e)
		{
			// Redirect.
			newLanguageComboBox_SelectedIndexChanged(null, null);
		}

		private void newFileNameTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			using (new WaitCursor(this, WaitCursorOption.ShortSleep))
			{
				var prefix =
					prefixCheckBox.Checked
						? prefixTextBox.Text.Trim() + @" "
						: string.Empty;

				var didCopy =
					_fileGroup.CreateAndAddNewFile(
						((Pair<string, Pair<string, string>>) referenceLanguageComboBox.SelectedItem).Second.Second,
						newFileNameTextBox.Text.Trim(),
						((Pair<string, Pair<string, string>>) referenceLanguageComboBox.SelectedItem).Second.First,
						((Pair<string, CultureInfo>) newLanguageComboBox.SelectedItem).Second.Name,
						copyTextsCheckBox.Checked,
						automaticallyTranslateCheckBox.Checked,
						prefix);

				if( !didCopy)
				{
					XtraMessageBox.Show(
						this,
						Resources.CreateNewFileForm_buttonOK_Click_The_resource_file_for_the_language_you_selected_was_already_present_and_simply_was_added__but_not_created_,
						@"Zeta Resource Editor",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}
			}
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

		private void buttonSettings_Click(object sender, EventArgs e)
		{
			using (var form = new TranslateOptionsForm())
			{
				form.Initialize(
					MainForm.Current.ProjectFilesControl.Project ?? Project.Empty);

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