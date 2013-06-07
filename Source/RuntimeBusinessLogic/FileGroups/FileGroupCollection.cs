namespace ZetaResourceEditor.RuntimeBusinessLogic.FileGroups
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

	public class FileGroupCollection :
		List<FileGroup>
	{
		private readonly Project _project;

		public FileGroupCollection(
			Project project)
		{
			_project = project;
		}

		public Project Project
		{
			get
			{
				return _project;
			}
		}

		internal void StoreToXml(
			XmlElement parentNode)
		{
			if (parentNode.OwnerDocument != null)
			{
				var groupsNode =
					parentNode.OwnerDocument.CreateElement(@"fileGroups");
				parentNode.AppendChild(groupsNode);

				foreach (var fileGroup in this)
				{
					if (parentNode.OwnerDocument != null)
					{
						var fileGroupNode =
							parentNode.OwnerDocument.CreateElement(@"fileGroup");
						groupsNode.AppendChild(fileGroupNode);

						fileGroup.StoreToXml(_project, fileGroupNode);
					}
				}
			}
		}

		internal void LoadFromXml(
			XmlNode parentNode)
		{
			Clear();

			var fileGroupNodes =
				parentNode.SelectNodes(@"fileGroups/fileGroup");

			if (fileGroupNodes != null)
			{
				foreach (XmlNode fileGroupNode in fileGroupNodes)
				{
					var fileGroup = new FileGroup(_project);
					fileGroup.LoadFromXml(_project, fileGroupNode);

					// Do not add orphans.
					if (fileGroup.FileInfoCount > 0)
					{
						Add(fileGroup);
					}
				}
			}

			// --

			Sort(
				/*delegate(FileGroup a, FileGroup b)
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

		public bool HasFileGroupWithChecksum(
			long checksum)
		{
// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var fileGroup in this)
// ReSharper restore LoopCanBeConvertedToQuery
			{
				if (fileGroup.GetChecksum(_project) == checksum)
				{
					return true;
				}
			}

			return false;
		}

		public Pair<string, string>[] GetLanguageCodesExtended(
			Project project)
		{
			var result = new Set<Pair<string, string>>();

			foreach (var fg in this)
			{
				foreach (var f in fg.GetLanguageCodesExtended(project))
				{
					var f1 = f;
					
					Pair<string, string> p;
					if (!result.Find(out p, x => string.Compare(x.First, f1.First, true) == 0))
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