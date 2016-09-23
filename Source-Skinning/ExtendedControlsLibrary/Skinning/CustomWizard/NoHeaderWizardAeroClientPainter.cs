namespace ExtendedControlsLibrary.Skinning.CustomWizard
{
    using DevExpress.Utils.Drawing;
    using DevExpress.XtraWizard;

    internal class NoHeaderWizardAeroClientPainter : WizardAeroClientPainter
	{
		public NoHeaderWizardAeroClientPainter(WizardViewInfo viewInfo) : base(viewInfo) { }

		protected override void DrawDividers(GraphicsInfoArgs e)
		{
			// base.DrawDividers(e);
		}

        protected override void DrawTitleBarIcon(GraphicsInfoArgs e)
        {
            // base.DrawTitleBarIcon(e);
        }
	}
}