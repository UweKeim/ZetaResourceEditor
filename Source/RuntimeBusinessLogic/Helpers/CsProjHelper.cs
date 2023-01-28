namespace ZetaResourceEditor.RuntimeBusinessLogic.Helpers;

using Microsoft.Build.Evaluation;
using Projects;
using System.IO;
using Exception = Exception;

public static class CsProjHelper
{
    public static readonly Regex RegexFindMainResourceFile = new(@"(.*?)\.([a-zA-Z-]{2,5}?)\.resx");
    public const string RegexFindMainResourceFileReplacePattern = @"$1.resx";

    public static CsProjectWithFileResult GetProjectContainingFile(FileInfo file)
    {
        const int maxRecursionLevelForProject = 5;
        var recursionLevelForProject = 1;

        var currentDirectory = file.Directory;
        var fullName = file.FullName;
        var csProjectWithFileResult = new CsProjectWithFileResult();

        var mainResourceFilePath =
            RegexFindMainResourceFile.Replace(file.Name, RegexFindMainResourceFileReplacePattern);

        while (maxRecursionLevelForProject >= recursionLevelForProject)
        {
            var currentCsProjects = currentDirectory?.GetFiles(@"*.csproj").Select(t =>
                {
                    try
                    {
                        var r = AcquireProject(t.FullName);
                        return r;
                    }
                    catch (Exception x)
                    {
                        LogCentral.Current.Warn(x, $"Ignoring exception while processing project file '{t.FullName}'.");

                        // Ignorieren.
                        return null;
                    }
                })
                .Where(t => t != null)
                .ToList();

            if (currentCsProjects != null)
            {
                foreach (var currentCsProject in currentCsProjects)
                {
                    var relativeName = fullName.Replace(currentCsProject.DirectoryPath + @"\", string.Empty);

                    var fileInCsProj = currentCsProject.Items.FirstOrDefault(t => t.EvaluatedInclude == relativeName);
                    if (fileInCsProj != null)
                    {
                        csProjectWithFileResult.Project = currentCsProject;

                        if (mainResourceFilePath != file.Name)
                        {
                            csProjectWithFileResult.DependantUponRootFileName = mainResourceFilePath;
                        }

                        return csProjectWithFileResult;
                    }
                    else
                    {
                        // 2022-07-15, Uwe Keim:
                        // Bei neuen .NET Core-Projekten sind Dateien implizit referenziert,
                        // deshalb auch schauen, ob im selben Ordner liegt.

                        var baseFolderPath = new FileInfo(currentCsProject.FullPath).DirectoryName;
                        var myFolderPath = file.DirectoryName;
                        if (!string.IsNullOrEmpty(baseFolderPath) && !string.IsNullOrEmpty(myFolderPath))
                        {
                            baseFolderPath = baseFolderPath.TrimEnd('\\');
                            myFolderPath = myFolderPath.TrimEnd('\\');

                            if (myFolderPath.StartsWithNoCase(baseFolderPath))
                            {
                                csProjectWithFileResult.Project = currentCsProject;

                                if (mainResourceFilePath != file.Name)
                                {
                                    csProjectWithFileResult.DependantUponRootFileName = mainResourceFilePath;
                                }

                                return csProjectWithFileResult;
                            }
                        }
                    }
                }
            }

            if (currentDirectory == null || currentDirectory.GetFiles(@"*.sln").Any())
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
        var gpc = ProjectCollection.GlobalProjectCollection;
        var lpl = gpc.LoadedProjects;

        var p = lpl.FirstOrDefault(pr => pr.FullPath == path);
        if (p == null)
        {
            using var reader = XmlReader.Create(path);

            p = new(
                reader,
                null,
                null,
                gpc,
                ProjectLoadSettings.IgnoreInvalidImports | ProjectLoadSettings.IgnoreMissingImports)
            {
                FullPath = path
            };
        }

        p.ReevaluateIfNecessary();
        return p;
    }

    public const string EmbeddedResourceLiteral = @"EmbeddedResource";
    public const string DependentUponLiteral = @"DependentUpon";
}