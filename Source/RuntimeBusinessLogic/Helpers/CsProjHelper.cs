using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZetaResourceEditor.RuntimeBusinessLogic.Projects;

namespace ZetaResourceEditor.UI.Helper
{
    public static class CsProjHelper
    {
        public static Regex RegexFindMainResourceFile = new Regex(@"(.*?)\.([a-zA-Z-]{2,5}?)\.resx");
        public const string RegexFindMainResourceFileReplacePattern = "$1.resx";

        public static CsProjectWithFileResult GetProjectContainingFile(FileInfo file)
        {
            int maxRecursionLevelForProject = 5;
            int recursionLevelForProject = 1;

            var currentDirectory = file.Directory;
            string fullName = file.FullName;
            var csProjectWithFileResult = new CsProjectWithFileResult();
            
            string mainResourceFilePath = RegexFindMainResourceFile.Replace(file.Name, RegexFindMainResourceFileReplacePattern);

            while (maxRecursionLevelForProject >= recursionLevelForProject)
            {
                var currentCsProjects = currentDirectory.GetFiles("*.csproj").Select(t => AcquireProject(t.FullName)).Where(t => t != null);

                foreach (var currentCsProject in currentCsProjects)
                {
                    string relativeName = fullName.Replace(currentCsProject.DirectoryPath + "\\", String.Empty);
                    string resourceFolder = relativeName.Substring(0, relativeName.LastIndexOf("\\"));
                    var fileInCsProj = currentCsProject.Items.FirstOrDefault(t => t.EvaluatedInclude == relativeName);
                    if (fileInCsProj != null)
                    {
                        csProjectWithFileResult.Project = currentCsProject;
                        string dependentUpon = String.Empty;

                        if (mainResourceFilePath != file.Name)
                        {
                            csProjectWithFileResult.DependantUponRootFileName = mainResourceFilePath;
                        }
                        return csProjectWithFileResult;
                    }
                }

                if (currentDirectory.GetFiles("*.sln").Any())
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
                .LoadedProjects.FirstOrDefault(pr => pr.FullPath == path);

            if (p == null)
            {
                p = new Microsoft.Build.Evaluation.Project(path);
            }

            p.ReevaluateIfNecessary();
            return p;
        }

        public const string EmbeddedResourceLiteral = "EmbeddedResource";
        public const string DependentUponLiteral = "DependentUpon";
    }
}
