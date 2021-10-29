namespace ZetaResourceEditor.RuntimeBusinessLogic.ProjectFolders;

#region Using directives.
// ----------------------------------------------------------------------
using System.Collections.Generic;
using System.Xml;
using Projects;

// ----------------------------------------------------------------------
#endregion

/////////////////////////////////////////////////////////////////////////

/// <summary>
/// 
/// </summary>
public class ProjectFolderCollection :
    List<ProjectFolder>
{
    public ProjectFolderCollection(
        Project project )
    {
        Project = project;
    }

    public Project Project { get; }

    internal void StoreToXml(
        XmlElement parentNode )
    {
        if (parentNode.OwnerDocument != null)
        {
            var groupsNode =
                parentNode.OwnerDocument.CreateElement( @"projectFolders" );
            parentNode.AppendChild( groupsNode );

            foreach ( var projectFolder in this )
            {
                if (parentNode.OwnerDocument != null)
                {
                    var projectFolderNode =
                        parentNode.OwnerDocument.CreateElement( @"projectFolder" );
                    groupsNode.AppendChild( projectFolderNode );

                    projectFolder.StoreToXml( projectFolderNode );
                }
            }
        }
    }

    internal void LoadFromXml(
        XmlNode parentNode )
    {
        Clear();

        var projectFolderNodes =
            parentNode.SelectNodes( @"projectFolders/projectFolder" );

        if ( projectFolderNodes != null )
        {
            foreach ( XmlNode projectFolderNode in projectFolderNodes )
            {
                var projectFolder = new ProjectFolder( Project );
                projectFolder.LoadFromXml( projectFolderNode );

                Add(projectFolder);
            }
        }

        // --

        Sort();
    }
}

/////////////////////////////////////////////////////////////////////////