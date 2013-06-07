namespace ZetaResourceEditor.RuntimeBusinessLogic.VirtualViews
{
	#region Using directives.
	// ----------------------------------------------------------------------
	using System.Collections.Generic;
	using System.Xml;
	using Projects;
	using Zeta.EnterpriseLibrary.Common.Collections;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// 
	/// </summary>
	public class VirtualViewCollection :
		List<VirtualView>
	{
		private readonly Project _project;

		/// <summary>
		/// Initializes a new instance of the <see cref="VirtualViewCollection"/> class.
		/// </summary>
		/// <param name="project">The project.</param>
		public VirtualViewCollection(
			Project project)
		{
			_project = project;
		}

		/// <summary>
		/// Gets the project.
		/// </summary>
		/// <value>The project.</value>
		public Project Project
		{
			get
			{
				return _project;
			}
		}

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

						virtualView.StoreToXml(_project, virtualViewNode);
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
					var virtualView = new VirtualView(_project);
					virtualView.LoadFromXml(_project, virtualViewNode);
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

		public Pair<string, string>[] GetLanguageCodesExtended(
			Project project)
		{
			var result = new Set<Pair<string, string>>();

			foreach (var fg in this)
			{
				foreach (var f in fg.GetLanguageCodesExtended(project))
				{
					var g = f;
					Pair<string, string> p;
					if (!result.Find(out p, x => string.Compare(x.First, g.First, true) == 0))
					{
						result.Add(f);
					}
				}
			}

			return result.ToArray();
		}
	}

	/////////////////////////////////////////////////////////////////////////
}