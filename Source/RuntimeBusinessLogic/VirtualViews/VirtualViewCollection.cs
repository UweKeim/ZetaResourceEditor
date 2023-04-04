namespace ZetaResourceEditor.RuntimeBusinessLogic.VirtualViews;

#region Using directives.
// ----------------------------------------------------------------------
using System.Linq;
using Projects;
using Zeta.VoyagerLibrary.Core.Common.Collections;

// ----------------------------------------------------------------------
#endregion

/////////////////////////////////////////////////////////////////////////

/// <summary>
/// 
/// </summary>
public class VirtualViewCollection :
    List<VirtualView>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VirtualViewCollection"/> class.
    /// </summary>
    /// <param name="project">The project.</param>
    public VirtualViewCollection(
        Project project)
    {
        Project = project;
    }

    /// <summary>
    /// Gets the project.
    /// </summary>
    /// <value>The project.</value>
    public Project Project { get; }

    /// <summary>
    /// Stores to XML.
    /// </summary>
    /// <param name="parentNode">The parent node.</param>
    internal void StoreToXml(
        XmlElement parentNode)
    {
        if (parentNode.OwnerDocument != null)
        {
            var groupsNode =
                parentNode.OwnerDocument.CreateElement(@"virtualViews");
            parentNode.AppendChild(groupsNode);

            foreach (var virtualView in this)
            {
                if (parentNode.OwnerDocument != null)
                {
                    var virtualViewNode =
                        parentNode.OwnerDocument.CreateElement(@"virtualView");
                    groupsNode.AppendChild(virtualViewNode);

                    virtualView.StoreToXml(Project, virtualViewNode);
                }
            }
        }
    }

    /// <summary>
    /// Loads from XML.
    /// </summary>
    /// <param name="parentNode">The parent node.</param>
    internal void LoadFromXml(
        XmlNode parentNode)
    {
        Clear();

        var virtualViewNodes =
            parentNode.SelectNodes(@"virtualViews/virtualView");

        if (virtualViewNodes != null)
        {
            foreach (XmlNode virtualViewNode in virtualViewNodes)
            {
                var virtualView = new VirtualView(Project);
                virtualView.LoadFromXml(Project, virtualViewNode);
                Add(virtualView);
            }
        }

        // --

        Sort(
            /*delegate(VirtualView a, VirtualView b)
                {
                    if (a.Count <= 0)
                    {
                        return +1;
                    }
                    else if (b.Count <= 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return string.Compare(
                            a.GetNameIntelligent(_project),
                            b.GetNameIntelligent(_project),
                            true);
                    }
                }*/
        );
    }

    public MyTuple<string, string>[] GetLanguageCodesExtended(
        Project? project)
    {
        var result = new HashSet<MyTuple<string, string>>();

        foreach (var fg in this)
        {
            foreach (var f in fg.GetLanguageCodesExtended(project))
            {
                var g = f;
                if (result.All(x => string.Compare(x.Item1, g.Item1, StringComparison.OrdinalIgnoreCase) != 0))
                {
                    result.Add(f);
                }
            }
        }

        return result.ToArray();
    }
}

/////////////////////////////////////////////////////////////////////////