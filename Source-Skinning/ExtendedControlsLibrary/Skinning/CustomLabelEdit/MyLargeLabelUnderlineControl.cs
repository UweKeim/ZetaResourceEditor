namespace ExtendedControlsLibrary.Skinning.CustomLabelEdit
{
    using DevExpress.XtraEditors;

    public class MyLargeLabelUnderlineControl :
		LabelControl
	{
		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			Appearance.Font = SkinHelper.LargeFontUnderline;
		}
	}
}