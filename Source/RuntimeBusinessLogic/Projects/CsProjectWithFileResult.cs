namespace ZetaResourceEditor.RuntimeBusinessLogic.Projects;

public sealed class CsProjectWithFileResult
{
    public Microsoft.Build.Evaluation.Project? Project { get; set; }
    public string? DependantUponRootFileName { get; set; }
}