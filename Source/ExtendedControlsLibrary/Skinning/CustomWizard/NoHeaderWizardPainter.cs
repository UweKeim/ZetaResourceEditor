namespace ZetaResourceEditor.ExtendedControlsLibrary.Skinning.CustomWizard;

using DevExpress.XtraWizard;

internal class NoHeaderWizardPainter : WizardPainter
{
    protected override WizardClientPainterBase CreateClientPainter(WizardViewInfo viewInfo)
    {
        return new NoHeaderWizardAeroClientPainter(viewInfo as NoHeaderWizardViewInfo);
    }
}