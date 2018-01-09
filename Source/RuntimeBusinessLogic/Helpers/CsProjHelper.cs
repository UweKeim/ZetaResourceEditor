namespace ZetaResourceEditor.RuntimeBusinessLogic.Helpers
{
    using Projects;
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using ZetaLongPaths;

    public static class CsProjHelper
    {
        public static readonly Regex RegexFindMainResourceFile = new Regex(@"(.*?)\.([a-zA-Z-]{2,5}?)\.resx");
        public const string RegexFindMainResourceFileReplacePattern = @"$1.resx";

        public static CsProjectWithFileResult GetProjectContainingFile(ZlpFileInfo file)
        {
            var maxRecursionLevelForProject = 5;
            var recursionLevelForProject = 1;

            var currentDirectory = file.Directory;
            var fullName = file.FullName;
            var csProjectWithFileResult = new CsProjectWithFileResult();

            var mainResourceFilePath =
                RegexFindMainResourceFile.Replace(file.Name, RegexFindMainResourceFileReplacePattern);

            while (maxRecursionLevelForProject >= recursionLevelForProject)
            {
                var currentCsProjects = currentDirectory.GetFiles(@"*.csproj").Select(t => AcquireProject(t.FullName))
                    .Where(t => t != null);

                foreach (var currentCsProject in currentCsProjects)
                {
                    var relativeName = fullName.Replace(currentCsProject.DirectoryPath + @"\", string.Empty);
                    
                    var fileInCsProj = currentCsProject.Items.FirstOrDefault(t => t.EvaluatedInclude == relativeName);
                    if (fileInCsProj != null)
                    {
                        csProjectWithFileResult.Project = currentCsProject;
                        var dependentUpon = string.Empty;

                        if (mainResourceFilePath != file.Name)
                        {
                            csProjectWithFileResult.DependantUponRootFileName = mainResourceFilePath;
                        }
                        return csProjectWithFileResult;
                    }
                }

                if (currentDirectory.GetFiles(@"*.sln").Any())
                {
                    break;
                }
                currentDirectory = currentDirectory.Parent;
                recursionLevelForProject++;
            }
            return null;
        }

        private static Microsoft.Build.Evaluation.Project AcquireProject(string path)
        {
            var p = Microsoft.Build.Evaluation
                        .ProjectCollection.GlobalProjectCollection
                        .LoadedProjects.FirstOrDefault(pr => pr.FullPath == path) ??
                    new Microsoft.Build.Evaluation.Project(path);

            p.ReevaluateIfNecessary();
            return p;
        }

        public const string EmbeddedResourceLiteral = @"EmbeddedResource";
        public const string DependentUponLiteral = @"DependentUpon";
    }
}
