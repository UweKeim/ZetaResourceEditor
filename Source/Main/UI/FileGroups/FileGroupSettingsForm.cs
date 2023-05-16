namespace ZetaResourceEditor.UI.FileGroups;

using Code;
using Helper.Base;
using Main;
using RuntimeBusinessLogic.FileGroups;
using RuntimeBusinessLogic.Projects;
using RuntimeUserInterface.Shell;

public partial class FileGroupSettingsForm :
	FormBase
{
	private FileGroup _fileGroup;

	public FileGroupSettingsForm()
	{
		InitializeComponent();

		barManager.Images = ImageCollectionHelper.Ic16;
	}

	public override void UpdateUI()
	{
		base.UpdateUI();

		buttonOK.Enabled = nameTextBox.Text.Trim().Length > 0;
	}

	internal void Initialize(
		FileGroup fileGroup)
	{
		_fileGroup = fileGroup;
	}

	private void FileGroupSettingsForm_Load(object sender, EventArgs e)
	{
		WinFormsPersistanceHelper.RestoreState(this);
		CenterToParent();

		nameTextBox.Text = _fileGroup.Name;
		locationTextBox.Text = _fileGroup.FolderPath?.FullName;
		checkSumTextEdit.Text =
			_fileGroup.GetChecksum(
				MainForm.Current?.ProjectFilesControl?.Project ?? Project.Empty).ToString(CultureInfo.InvariantCulture);

		parentTextEdit.Text =
			_fileGroup.ProjectFolder == null
				? _fileGroup.Project.Name
				: _fileGroup.ProjectFolder.NameIntelli;

		ignoreDuringExportAndImportCheckEdit.Checked = _fileGroup.IgnoreDuringExportAndImport;
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		_fileGroup.Name = nameTextBox.Text;
		_fileGroup.IgnoreDuringExportAndImport = ignoreDuringExportAndImportCheckEdit.Checked;
	}

	private void FileGroupSettingsForm_FormClosing(
		object sender,
		FormClosingEventArgs e)
	{
		WinFormsPersistanceHelper.SaveState(this);
	}

	//private void button1_Click( object sender, EventArgs e )
	//{
	//    ((Button)sender).ContextMenuStrip.Show(
	//        ((Button)sender),
	//        new Point( 0, ((Button)sender).Height ) );
	//}

	private void openButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

	private void nameTextBox_TextChanged(object sender, EventArgs e)
	{
		UpdateUI();
	}
}