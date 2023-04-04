namespace ZetaResourceEditor.RuntimeBusinessLogic.Projects;

using Language;
using ProjectFolders;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// Import files from a .SLN or .CSPROJ file.
/// </summary>
public class VisualStudioImporter
{
    public VisualStudioImporter(Project? project)
    {
        Project = project;
    }

    private Project? Project { get; }

    public void DoAutomaticallyAddResourceFilesFromVsProject(
        BackgroundWorker backgroundWorker,
        ProjectFolder parentProjectFolder,
        ref int fileGroupCount,
        ref int fileCount,
        FileInfo vsProjectPath)
    {
        if (backgroundWorker.CancellationPending)
        {
            throw new OperationCanceledException();
        }
        else if (vsProjectPath is { Exists: true })
        {
            if (@".sln" == vsProjectPath.Extension.ToLowerInvariant())
            {
                //file is solution, so add all projects from solution
                doAutomaticallyAddResourceFilesFromVSSolution(
                    backgroundWorker,
                    parentProjectFolder,
                    ref fileGroupCount,
                    ref fileCount,
                    vsProjectPath);
            }
            else
            {
                //load fom solution
                var pdoc = new XmlDocument();
                //using (var fs = vsProjectPath.OpenRead())
                {
                    pdoc.LoadXml(File.ReadAllText(vsProjectPath.FullName));
                }

                var nameMgr = new XmlNamespaceManager(pdoc.NameTable);
                nameMgr.AddNamespace(@"mb", @"http://schemas.microsoft.com/developer/msbuild/2003");

                //Update 16.16.2016 Christian Abele: Resourcen können unter EmbeddedResource und Content vorkommen! => Content ergänzt
                var xpaths = new[]
                {
                    @"/mb:Project/mb:ItemGroup/mb:EmbeddedResource/@Include",
                    @"/mb:Project/mb:ItemGroup/mb:Content/@Include",
                    @"/mb:Project/mb:ItemGroup/mb:EmbeddedResource/@Update",
                    @"/Project/ItemGroup/EmbeddedResource/@Update"
                };

                var resNodes = new List<XmlNode>();

                foreach (var xpath in xpaths)
                {
                    var r = pdoc.SelectNodes(xpath, nameMgr);
                    if (r != null) resNodes.AddRange(r.Cast<XmlNode>().ToArray());
                }

                var filePaths = new List<FileInfo>(); //get all files
                foreach (var node in resNodes)
                {
                    var include = node.Value;

                    if (!string.IsNullOrEmpty(include) &&
                        (include.ToLowerInvariant().EndsWith(@".resx") ||
                         include.ToLowerInvariant().EndsWith(@".resw")))
                    {
                        var fullPath = ZspPathHelper.Combine(vsProjectPath.DirectoryName, include);
                        filePaths.Add(new(fullPath));
                    }
                }

                //add all files from list
                DoAutomaticallyAddResourceFilesFromList(
                    backgroundWorker,
                    parentProjectFolder,
                    ref fileGroupCount,
                    ref fileCount,
                    filePaths);
            }
        }
    }

    // ADDED: adds resources from file Info lists.
    // I have changed a method doAutomaticallyAddResourceFiles to fill file groups.
    // You can use same method if you call this method from there.
    // ATTENTION: LanguageCodeDetection was modified a bit to support variable amount
    // of point in base name. New method GetBaseName(IInheritedSettings settings, string fileName)
    // was added to get same base name FileGroup gets.
    public void DoAutomaticallyAddResourceFilesFromList(
        BackgroundWorker backgroundWorker,
        ProjectFolder parentProjectFolder,
        ref int fileGroupCount,
        ref int fileCount,
        ICollection<FileInfo> fileList)
    {
        if (backgroundWorker.CancellationPending)
        {
            throw new OperationCanceledException();
        }
        else if (fileList is { Count: > 0 })
        {
            var fileGroups = Project.FileGroups;
            //if (parentProjectFolder != null)
            //{
            //    fileGroups = parentProjectFolder.ChildFileGroups;
            //}
            foreach (var filePath in fileList)
            {
                if (backgroundWorker.CancellationPending)
                {
                    throw new OperationCanceledException();
                }
                //other algorithm to determine base name to allow multiple points inside name
                var baseFileName = LanguageCodeDetection.GetBaseName(Project, filePath.Name);

                var wantAddResourceFile =
                    checkWantAddResourceFile(filePath);

                if (wantAddResourceFile)
                {
                    //find right file group

                    var path = filePath;
                    var fileGroup = fileGroups.Find(
                        g =>
                            string.Compare(g.BaseName, baseFileName, StringComparison.OrdinalIgnoreCase) == 0 &&
                            string.Compare(g.FolderPath.FullName, path.Directory.FullName,
                                StringComparison.OrdinalIgnoreCase) == 0);

                    if (fileGroup == null)
                    {
                        fileGroup =
                            new(Project)
                            {
                                ProjectFolder = parentProjectFolder
                            };

                        // Look for same entries.
                        if (!Project.FileGroups.HasFileGroupWithChecksum(
                                fileGroup.GetChecksum(Project)))
                        {
                            fileGroups.Add(fileGroup);

                            fileGroupCount++;
                        }
                    }

                    fileGroup.Add(
                        new(fileGroup)
                        {
                            File = filePath
                        });

                    fileCount++;
                }
            }
        }
    }

    private bool checkWantAddResourceFile(
        FileInfo filePath)
    {
        if (filePath == null)
        {
            return false;
        }
        else
        {
            if (filePath.Directory.Name.EqualsNoCase(@"Properties"))
            {
                return true;
            }
            else
            {
                // If a "*.Designer.*" companion file exists, assume it
                // is a Windows Forms resource file and do NOT add the file
                // since it can be translated directly from within VS.NET.

                if (Project.IgnoreWindowsFormsResourcesWithDesignerFiles)
                {
                    var baseFileName = LanguageCodeDetection.GetBaseName(Project, filePath.Name);

                    var files = filePath.Directory.GetFiles($@"{baseFileName}.Designer.*");

                    return files.Length <= 0;
                }
                else
                {
                    return true;
                }
            }
        }
    }

    private void doAutomaticallyAddResourceFilesFromVSSolution(
        BackgroundWorker backgroundWorker,
        ProjectFolder parentProjectFolder,
        ref int fileGroupCount,
        ref int fileCount,
        FileInfo vsSolutionPath)
    {
        if (vsSolutionPath is { Exists: true })
        {
            string solutionText;
            //using (var sr = vsSolutionPath.OpenText())
            {
                //we can read it line by line to reduce memory usage, but solution files are not very big
                solutionText = File.ReadAllText(vsSolutionPath.FullName); // sr.ReadToEnd();
            }
            //solution files looks like:
            //Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ZetaResourceEditor", "Main\ZetaResourceEditor.csproj", "{367758E7-0435-440A-AC76-1F30ABBA3ED8}"
            //EndProject
            //known projectTypes:
            //c#: FAE04EC0-301F-11D3-BF4B-00C04F79EFBC, VB: F184B08F-C81C-45F6-A57F-5ABD9991F28F
            //@see http://msdn.microsoft.com/en-us/library/hb23x61k%28VS.80%29.aspx
            //TODO: support virtual folders
            var supportedProjectTypes =
                new[]
                {
                    @"FAE04EC0-301F-11D3-BF4B-00C04F79EFBC",
                    @"F184B08F-C81C-45F6-A57F-5ABD9991F28F"
                };

            //we need some regular expression to find required info:
            const string pattern =
                @"Project\(""{(?<projectType>[^}]*)}""\)\s*=\s*""(?<projectName>[^""]*)"",\s*""(?<projectRelPath>[^""]*)"",\s*""{(?<projectID>[^}]*)}""";

            foreach (Match m in Regex.Matches(solutionText, pattern))
            {
                if (!m.Success)
                {
                    continue;
                }

                var g = m.Groups[@"projectType"];
                if (g is not { Success: true })
                {
                    continue;
                }
                var projectType = g.Value;

                //compare with known project types.
                // Currently only CS Projects are supported.
                // But other types like VB can be simply added.
                if (!Array.Exists(supportedProjectTypes, a => a == projectType))
                {
                    continue;
                }

                var projectRelPath = m.Groups[@"projectRelPath"].Value;
                var projectFile =
                    new FileInfo(ZspPathHelper.Combine(vsSolutionPath.Directory.FullName, projectRelPath));

                //add all files from project
                //we can add each using separate sub folder
                var projectName = m.Groups[@"projectName"].Value;
                //look in subfolders only
                var subFolders = Project.ProjectFolders;
                if (parentProjectFolder != null)
                {
                    subFolders = parentProjectFolder.ChildProjectFolders;
                }
                var pf = subFolders.Find(f => f.Name == projectName);
                if (pf == null)
                {
                    pf =
                        new(Project)
                        {
                            Name = projectName,
                            Parent = parentProjectFolder
                        };
                    Project.ProjectFolders.Add(pf);
                }

                Project.MarkAsModified();

                DoAutomaticallyAddResourceFilesFromVsProject(
                    backgroundWorker,
                    pf,
                    ref fileGroupCount,
                    ref fileCount,
                    projectFile);
            }
        }
    }
}