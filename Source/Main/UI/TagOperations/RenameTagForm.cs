namespace ZetaResourceEditor.UI.TagOperations;

using Helper.Base;

public partial class RenameTagForm :
	FormBase
{
	private string? initialName;
	private readonly List<string> _distinctTagNames;

	public RenameTagForm(
		List<string> distinctTagNames)
	{
		_distinctTagNames = distinctTagNames;

		InitializeComponent();
	}

	public string? TagName
	{
		get => textBox1.Text.Trim();
		set
		{
			initialName = value;
			textBox1.Text = value;
		}
	}

	public override void UpdateUI()
	{
		base.UpdateUI();

		button1.Enabled =
			textBox1.Text.Trim() != initialName &&
			textBox1.Text.Trim().Length > 0 &&
			!_distinctTagNames.Contains(textBox1.Text.Trim());
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
		UpdateUI();
	}

	private void TagChange_Load(object sender, EventArgs e)
	{
		WinFormsPersistanceHelper.RestoreState(this);
		CenterToParent();

		UpdateUI();
	}

	private void RenameTagForm_FormClosing(
		object sender,
		FormClosingEventArgs e)
	{
		WinFormsPersistanceHelper.RestoreState(this);
	}
}