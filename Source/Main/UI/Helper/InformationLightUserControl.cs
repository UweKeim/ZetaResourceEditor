namespace ZetaResourceEditor.UI.Helper;

/// <summary>
/// Control to display information to the user.
/// </summary>
public partial class InformationLightUserControl :
	UserControl
{
	public InformationLightUserControl()
	{
		InitializeComponent();
	}

	[DefaultValue(false)]
	public bool UseMouseHoverEffect { get; set; }


	public string DescriptionText
	{
		get => descriptionLabel.Text;
		set => descriptionLabel.Text = value;
	}

	private void InvertColors()
	{
		backgroundPanel.BackColor = SystemColors.Highlight;
		descriptionLabel.ForeColor = SystemColors.HighlightText;

		Cursor = Cursors.Hand;
	}

	private void RestoreColors()
	{
		backgroundPanel.BackColor = SystemColors.Info;
		descriptionLabel.ForeColor = SystemColors.InfoText;

		Cursor = Cursors.Default;
	}

	private void InformationLightUserControl_MouseEnter(
		object sender,
		EventArgs e)
	{
		if (UseMouseHoverEffect)
		{
			InvertColors();
		}
	}

	private void InformationLightUserControl_MouseLeave(
		object sender,
		EventArgs e)
	{
		RestoreColors();
	}

	private void InformationLightUserControl_Load(
		object sender,
		EventArgs e)
	{
		RestoreColors();
	}
}