namespace ZetaResourceEditor.RuntimeBusinessLogic.DL
{
	using FileGroups;

	public interface ITranslationStateInformation
	{
		FileGroupStateColor TranslationStateColor
		{
			get;
		}
	}
}