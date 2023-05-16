namespace ZetaResourceEditor.UI.Projects;

using Code;
using Helper.Base;
using Properties;
using Runtime;
using RuntimeBusinessLogic.Projects;
using RuntimeBusinessLogic.Translation;
using RuntimeUserInterface.Shell;
using Translation;

public partial class ProjectSettingsForm : FormBase
{
	private Project? _project;

	public ProjectSettingsForm()
	{
		InitializeComponent();
		createToolTips();
	}

	/// <summary>
	/// Since the strings constantly get lost, create
	/// them in code instead in the designer.
	/// </summary>
	private void createToolTips()
	{
		var superToolTip4 = new SuperToolTip();
		var toolTipTitleItem4 = new ToolTipTitleItem();
		var toolTipItem4 = new ToolTipItem();

		var superToolTip5 = new SuperToolTip();
		var toolTipTitleItem5 = new ToolTipTitleItem();
		var toolTipItem5 = new ToolTipItem();

		var superToolTip6 = new SuperToolTip();
		var toolTipTitleItem6 = new ToolTipTitleItem();
		var toolTipItem6 = new ToolTipItem();

		// --

		toolTipTitleItem6.Text = Resources.SR_toolTipTitleItem6Text;
		toolTipItem6.Text = Resources.SR_toolTipItem6Text;
		superToolTip6.Items.Add(toolTipTitleItem6);
		superToolTip6.Items.Add(toolTipItem6);
		defaultToolTipController1.SetSuperTip(pictureEdit1, superToolTip6);

		toolTipTitleItem5.Text = Resources.SR_toolTipTitleItem5Text;
		toolTipItem5.Text = Resources.SR_toolTipItem5Text;
		superToolTip5.Items.Add(toolTipTitleItem5);
		superToolTip5.Items.Add(toolTipItem5);
		defaultToolTipController1.SetSuperTip(pictureEdit2, superToolTip5);

		toolTipTitleItem4.Text = Resources.SR_toolTipTitleItem4Text;
		toolTipItem4.Text = Resources.SR_toolTipItem4Text;
		superToolTip4.Items.Add(toolTipTitleItem4);
		superToolTip4.Items.Add(toolTipItem4);
		defaultToolTipController1.SetSuperTip(pictureEdit3, superToolTip4);
	}

	internal void Initialize(
		Project? project)
	{
		_project = project;
	}

	private class ReadOnlyHelper
	{
		public ReadOnlyFileOverwriteBehaviour Behaviour { get; }

		public ReadOnlyHelper(ReadOnlyFileOverwriteBehaviour behaviour)
		{
			Behaviour = behaviour;
		}

		public override string ToString()
		{
			return StringHelper.GetEnumDescription(Behaviour) ?? string.Empty;
		}
	}

	private void projectSettingsForm_Load(
		object sender,
		EventArgs e)
	{
		WinFormsPersistanceHelper.RestoreState(this);
		CenterToParent();

		foreach (ReadOnlyFileOverwriteBehaviour rob in
				 Enum.GetValues(typeof(ReadOnlyFileOverwriteBehaviour)))
		{
			readOnlySaveBehaviourComboBox.Properties.Items.Add(
				new ReadOnlyHelper(rob));
		}

		selectReadOnlyBehaviour(
			readOnlySaveBehaviourComboBox,
			_project.ReadOnlyFileOverwriteBehaviour);

		nameTextBox.Text = ZspPathHelper.GetFileNameWithoutExtension(
			_project.ProjectConfigurationFilePath.Name);
		locationTextBox.Text = _project.ProjectConfigurationFilePath.DirectoryName;
		neutralLanguageCodeTextEdit.Text = _project.NeutralLanguageCode;
		useSpellCheckingCheckEdit.Checked = _project.UseSpellChecker;
		ResXIndentCharTextEdit.Text = StringExtensionMethods.ReplaceEscapes(_project.ResXIndentChar);
		createBackupsCheckBox.Checked = _project.CreateBackupFiles;
		omitEmptyItemsCheckBox.Checked = _project.OmitEmptyItems;
		hideEmptyRowsCheck.Checked = _project.HideEmptyRows;
		hideTranslatedRowsCheck.Checked = _project.HideTranslatedRows;
		showCommentsColumnInGridCheckEdit.Checked = _project.ShowCommentsColumnInGrid;
		ignoreWindowsFormsDesignerFiles.Checked =
			_project.IgnoreWindowsFormsResourcesWithDesignerFiles;
		hideInternalDesignerRowsCheckEdit.Checked =
			_project.HideInternalDesignerRows;
		shallowCumulationCheckEdit.Checked =
			_project.UseShallowGridDataCumulation;
		hideFileGroupFilesInTreeCheckEdit.Checked = _project.HideFileGroupFilesInTree;
		displayFileGroupWithoutFolderCheckEdit.Checked = _project.DisplayFileGroupWithoutFolder;

		neutralLanguageFileNamePatternTextEdit.Text = _project.NeutralLanguageFileNamePattern;
		nonNeutralLanguageFileNamePatternTextEdit.Text = _project.NonNeutralLanguageFileNamePattern;
		baseNameDotCountSpinEdit.Value = _project.BaseNameDotCount;
		defaultTypesTextEdit.Text = _project.DefaultFileTypesToIgnore;
		persistGridSettingsCheckEdit.Checked = _project.PersistGridSettings;
		colorifyNullCellsCheckEdit.Checked = _project.ColorifyNullCells;
		enableExcelExportSnapshotsCheckEdit.Checked = _project.EnableExcelExportSnapshots;
		keepFolderStructureOnImportCheckEdit.Checked = _project.KeepFolderStructureOnImport;

		DoInitiallyFillListsAndFillItemToControls();
	}

	private static void selectReadOnlyBehaviour(
		ComboBoxEdit comboBoxEdit,
		ReadOnlyFileOverwriteBehaviour behaviour)
	{
		foreach (ReadOnlyHelper roh in comboBoxEdit.Properties.Items)
		{
			if (roh.Behaviour == behaviour)
			{
				comboBoxEdit.SelectedItem = roh;
				break;
			}
		}
	}

	private void projectSettingsForm_FormClosing(
		object sender,
		FormClosingEventArgs e)
	{
		WinFormsPersistanceHelper.SaveState(this);
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		_project.ReadOnlyFileOverwriteBehaviour =
			((ReadOnlyHelper)readOnlySaveBehaviourComboBox.SelectedItem).Behaviour;

		_project.CreateBackupFiles = createBackupsCheckBox.Checked;
		_project.OmitEmptyItems = omitEmptyItemsCheckBox.Checked;
		_project.NeutralLanguageCode = neutralLanguageCodeTextEdit.Text.Trim();
		_project.UseSpellChecker = useSpellCheckingCheckEdit.Checked;
		_project.ResXIndentChar = StringExtensionMethods.UnreplaceEscapes(ResXIndentCharTextEdit.Text); // KEIN TRIM.
		_project.HideEmptyRows = hideEmptyRowsCheck.Checked;
		_project.HideTranslatedRows = hideTranslatedRowsCheck.Checked;
		_project.ShowCommentsColumnInGrid = showCommentsColumnInGridCheckEdit.Checked;
		_project.IgnoreWindowsFormsResourcesWithDesignerFiles =
			ignoreWindowsFormsDesignerFiles.Checked;
		_project.HideInternalDesignerRows =
			hideInternalDesignerRowsCheckEdit.Checked;
		_project.UseShallowGridDataCumulation = shallowCumulationCheckEdit.Checked;
		_project.HideFileGroupFilesInTree = hideFileGroupFilesInTreeCheckEdit.Checked;
		_project.DisplayFileGroupWithoutFolder = displayFileGroupWithoutFolderCheckEdit.Checked;

		_project.NeutralLanguageFileNamePattern = neutralLanguageFileNamePatternTextEdit.Text.Trim();
		_project.NonNeutralLanguageFileNamePattern = nonNeutralLanguageFileNamePatternTextEdit.Text.Trim();
		_project.BaseNameDotCount = (int)baseNameDotCountSpinEdit.Value;
		_project.DefaultFileTypesToIgnore = defaultTypesTextEdit.Text.Trim();
		_project.PersistGridSettings = persistGridSettingsCheckEdit.Checked;
		_project.ColorifyNullCells = colorifyNullCellsCheckEdit.Checked;
		_project.EnableExcelExportSnapshots = enableExcelExportSnapshotsCheckEdit.Checked;
		_project.KeepFolderStructureOnImport = keepFolderStructureOnImportCheckEdit.Checked;

		_project.MarkAsModified();
	}

	private void openButton_ItemClick(object sender, ItemClickEventArgs e)
	{
		if (!string.IsNullOrEmpty(locationTextBox.Text) &&
			Directory.Exists(locationTextBox.Text))
		{
			var sei =
				new ShellExecuteInformation
				{
					FileName = locationTextBox.Text
				};

			sei.Execute();
		}
	}

	private void hyperLinkEdit1_OpenLink(object sender, OpenLinkEventArgs e)
	{
		ProcessStartHelper.OpenUrl(@"https://extensions.services.openoffice.org/dictionary");
	}

	private void buttonTranslationSettings_Click(object sender, EventArgs e)
	{
		using var form = new TranslateOptionsForm();
		form.Initialize(_project);

		if (form.ShowDialog(this) == DialogResult.OK)
		{
			if (form.TranslationProviderChanged)
			{
				using (new WaitCursor(this))
				{
					DoInitiallyFillListsAndFillItemToControls();
				}
			}

			UpdateUI();
		}
	}

	private void DoInitiallyFillListsAndFillItemToControls()
	{
		var ti = TranslationHelper.GetTranslationEngine(_project);
		myLabelControl2.Text = ti.UserReadableName;
	}
}