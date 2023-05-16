namespace ZetaResourceEditor.RuntimeBusinessLogic.Projects;

using System.ComponentModel;

public enum ReadOnlyFileOverwriteBehaviour
{
	[Description("Overwrite")] Overwrite,
	[Description("Ask")] Ask,
	[Description("Skip")] Skip,
	[Description("Fail")] Fail
}