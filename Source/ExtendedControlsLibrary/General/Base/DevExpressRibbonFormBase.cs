namespace ZetaResourceEditor.ExtendedControlsLibrary.General.Base;

using Skinning.CustomRibbonForm;
using UIUpdating;

public class DevExpressRibbonFormBase :
	MyRibbonForm,
	IUpdateUI
{
	private UpdateUIController? _uuiController;

	protected DevExpressRibbonFormBase()
	{
		// Allow for capturing the F1 key.
		KeyPreview = true;
	}

	protected UpdateUIController UuiController => _uuiController ??= new();

	public virtual void DoUpdateUI(
		UpdateUIInformation information)
	{
		// Does nothing.
	}

	public void PerformUpdateUI(object? userState = null)
	{
		if (!DesignMode)
		{
			UuiController.PerformUpdateUI(this, userState);
		}
	}

	protected override void OnShown(
		EventArgs e)
	{
		base.OnShown(e);

		PerformUpdateUI();
	}
}