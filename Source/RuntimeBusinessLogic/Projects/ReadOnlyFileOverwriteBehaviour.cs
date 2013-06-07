namespace ZetaResourceEditor.RuntimeBusinessLogic.Projects
{
	using Properties;
	using Runtime.Localization;

	public enum ReadOnlyFileOverwriteBehaviour
	{
		[LocalizableDescription(@"SR_ReadOnlyFileOverwriteBehaviour_Overwrite", typeof(Resources))]
		Overwrite,

		[LocalizableDescription(@"SR_ReadOnlyFileOverwriteBehaviour_Ask", typeof(Resources))]
		Ask,

		[LocalizableDescription(@"SR_ReadOnlyFileOverwriteBehaviour_Skip", typeof(Resources))]
		Skip,

		[LocalizableDescription(@"SR_ReadOnlyFileOverwriteBehaviour_Fail", typeof(Resources))]
		Fail
	}
}