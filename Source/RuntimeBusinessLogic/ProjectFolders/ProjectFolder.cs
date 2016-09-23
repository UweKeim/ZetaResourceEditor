namespace ZetaResourceEditor.RuntimeBusinessLogic.ProjectFolders
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Xml;
	using DL;
	using DynamicSettings;
	using FileGroups;
	using FileInformations;
	using Language;
	using Projects;
	using VirtualViews;
	using Zeta.VoyagerLibrary.Common;
	using ZetaAsync;
	using ZetaLongPaths;

	public class ProjectFolder :
		ITranslationStateInformation,
		IComparable,
		IComparable<ProjectFolder>,
		IUniqueID,
		IOrderPosition,
		IInheritedSettings,
		IGridEditableData
	{
		public ProjectFolder(Project project)
		{
			_project = project;
		}

		private Project _project;
		private Guid _uniqueID = Guid.NewGuid();
		private Guid _parentUniqueID;
		private string _name;
		private int _orderPosition;

		private readonly DynSettings _dynSettings = new DynSettings();

		public bool UseParentFilePatternSettings
		{
			get
			{
				return ConvertHelper.ToBoolean(
					_dynSettings.RetrieveValue(@"UseParentFilePatternSettings"),
					true);
			}
			set
			{
				_dynSettings.PersistValue(@"UseParentFilePatternSettings", value.ToString());
			}
		}

		public int BaseNameDotCount
		{
			get
			{
				return ConvertHelper.ToInt32(
					_dynSettings.RetrieveValue(@"BaseNameDotCount"),
					0);
			}
			set
			{
				_dynSettings.PersistValue(@"BaseNameDotCount", value.ToString());
			}
		}

		public string NeutralLanguageFileNamePattern
		{
			get
			{
				var result = ConvertHelper.ToString(
					_dynSettings.RetrieveValue(@"NeutralLanguageFileNamePattern"));

				return string.IsNullOrEmpty(result) ? @"[basename][optionaldefaulttypes].[extension]" : result;
			}
			set
			{
				_dynSettings.PersistValue(@"NeutralLanguageFileNamePattern", value);
			}
		}

		public string NonNeutralLanguageFileNamePattern
		{
			get
			{
				var result = ConvertHelper.ToString(
					_dynSettings.RetrieveValue(@"NonNeutralLanguageFileNamePattern"));

				if (string.IsNullOrEmpty(result))
				{
					return @"[basename][optionaldefaulttypes].[languagecode].[extension]";
				}
				else
				{
					return result;
				}
			}
			set
			{
				_dynSettings.PersistValue(@"NonNeutralLanguageFileNamePattern", value);
			}
		}

		public string[] DefaultFileTypesToIgnoreArray
		{
			get
			{
				var types = DefaultFileTypesToIgnore;
				if (string.IsNullOrEmpty(types))
				{
					return new string[] { };
				}
				else
				{
					var result = new HashSet<string>();

					foreach (var s in types.Split(
						new[] { @",", @";" },
						StringSplitOptions.RemoveEmptyEntries))
					{
						var t = s.Trim('*', ' ');
						if (!string.IsNullOrEmpty(t))
						{
							if (!t.StartsWith(@"."))
							{
								t = @"." + t;
							}

							result.Add(t);
						}
					}

					return result.ToArray();
				}
			}
		}

		public string DefaultFileTypesToIgnore
		{
			get
			{
				var result = ConvertHelper.ToString(
					_dynSettings.RetrieveValue(@"DefaultFileTypesToIgnore"));

				return result ?? @".aspx;.ascx;.asmx;.master;.sitemap";
			}
			set
			{
				_dynSettings.PersistValue(@"DefaultFileTypesToIgnore", value);
			}
		}

		public bool IgnoreDuringExportAndImport
		{
			get
			{
				return ConvertHelper.ToBoolean(
					_dynSettings.RetrieveValue(@"IgnoreDuringExportAndImport"), false);
			}
			set
			{
				_dynSettings.PersistValue(@"IgnoreDuringExportAndImport", value.ToString());
			}
		}

		FileInformation[] IGridEditableData.GetFileInformationsSorted()
		{
			// Only returns the direct ones, not nested.

			var result = new List<FileInformation>();

			var cfg = _project.UseShallowGridDataCumulation ? ChildFileGroups : ChildFileGroupsDeep;
			cfg.ForEach(x => result.AddRange(x.GetFileInfos()));

			result.Sort();
			return result.ToArray();
		}

		public IInheritedSettings ParentSettings
		{
			get
			{
				return Parent ?? (IInheritedSettings)_project;
			}
		}

		FileGroupStates IGridEditableData.InMemoryState
		{
			get
			{
				var sfg = _project.UseShallowGridDataCumulation ? ChildFileGroups : ChildFileGroupsDeep;
				return sfg.Count <= 0 ? FileGroupStates.Empty : sfg[0].InMemoryState;
			}
			set
			{
				var sfg = _project.UseShallowGridDataCumulation ? ChildFileGroups : ChildFileGroupsDeep;
				if (sfg.Count > 0)
				{
					sfg[0].InMemoryState = value;
				}
			}
		}

		string[] IGridEditableData.FilePaths
		{
			get
			{
				var ss = new List<string>();

				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var filePath in ((IGridEditableData)this).GetFileInformationsSorted())
				// ReSharper restore LoopCanBeConvertedToQuery
				{
					ss.Add(filePath.File.FullName);
				}

				return ss.ToArray();
			}
		}

		string IGridEditableData.JoinedFilePaths
		{
			get
			{
				return FileGroup.JoinFilePaths(
					((IGridEditableData)this).FilePaths);
			}
		}

		string[] IGridEditableData.GetLanguageCodes(Project project)
		{
			var result = new HashSet<string>();

			foreach (var filePath in ((IGridEditableData)this).FilePaths)
			{
				var lc =
					new LanguageCodeDetection(
						((IGridEditableData)this).Project).DetectLanguageCodeFromFileName(
						((IGridEditableData)this).ParentSettings,
						filePath);

				if (!string.IsNullOrEmpty(lc))
				{
					result.Add(lc.ToLowerInvariant());
				}
			}

			return result.ToArray();
		}

		public string GetFullNameIntelligent(Project project)
		{
			return null;
		}

		string IGridEditableData.GetNameIntelligent(Project project)
		{
			return _name;
		}

		public long GetChecksum(Project project)
		{
			return _uniqueID.GetHashCode();
		}

		public bool EffectiveIgnoreDuringExportAndImport
		{
			get
			{
				if (IgnoreDuringExportAndImport)
				{
					return true;
				}
				else
				{
					var parent = ParentSettings;
					return parent != null && parent.EffectiveIgnoreDuringExportAndImport;
				}
			}
		}

		public int EffectiveBaseNameDotCount
		{
			get
			{
				return UseParentFilePatternSettings ? ParentSettings.EffectiveBaseNameDotCount : BaseNameDotCount;
			}
		}

		public string EffectiveNeutralLanguageFileNamePattern
		{
			get
			{
				return UseParentFilePatternSettings ? ParentSettings.EffectiveNeutralLanguageFileNamePattern : NeutralLanguageFileNamePattern;
			}
		}

		public string EffectiveNonNeutralLanguageFileNamePattern
		{
			get
			{
				return UseParentFilePatternSettings ? ParentSettings.EffectiveNonNeutralLanguageFileNamePattern : NonNeutralLanguageFileNamePattern;
			}
		}

		public string[] EffectiveDefaultFileTypesToIgnoreArray
		{
			get
			{
				return UseParentFilePatternSettings ? ParentSettings.EffectiveDefaultFileTypesToIgnoreArray : DefaultFileTypesToIgnoreArray;
			}
		}

		public string EffectiveDefaultFileTypesToIgnore
		{
			get
			{
				return UseParentFilePatternSettings ? ParentSettings.EffectiveDefaultFileTypesToIgnore : DefaultFileTypesToIgnore;
			}
		}

		public string EffectiveNeutralLanguageCode
		{
			get
			{
				// For now, always goes to the project directly.
				return _project.NeutralLanguageCode;
			}
		}

		public FileGroupStateColor TranslationStateColor
		{
			get
			{
				var result = FileGroupStateColor.None;

				foreach (var fileGroup in ChildFileGroups)
				{
					// Shortcut evaluation.
					if (result == FileGroupStateColor.Red ||
						result == FileGroupStateColor.Yellow)
					{
						return result;
					}

					result =
						FileGroup.CombineColorKeys(
							result,
							fileGroup.TranslationStateColor);
				}

				foreach (var projectFolder in ChildProjectFolders)
				{
					// Shortcut evaluation.
					if (result == FileGroupStateColor.Red ||
						result == FileGroupStateColor.Yellow)
					{
						return result;
					}

					result =
						FileGroup.CombineColorKeys(
							result,
							projectFolder.TranslationStateColor);
				}

				// --

				if (result == FileGroupStateColor.None)
				{
					return FileGroupStateColor.Grey;
				}
				else
				{
					return result;
				}
			}
		}

		public ProjectFolder Parent
		{
			get
			{
				return _project.GetProjectFolderByUniqueID(_parentUniqueID);
			}
			set
			{
				_parentUniqueID = value == null ? Guid.Empty : value._uniqueID;
			}
		}

		public ProjectFolderCollection ChildProjectFolders
		{
			get
			{
				return _project.GetProjectFoldersByParentUniqueID(_uniqueID);
			}
		}

		public FileGroupCollection ChildFileGroups
		{
			get
			{
				return _project.GetFileGroupsByProjectFolderUniqueID(_uniqueID);
			}
		}

		public FileGroupCollection ChildFileGroupsDeep
		{
			get
			{
				var result = new FileGroupCollection(_project);

				result.AddRange(ChildFileGroups);

				foreach (var childProjectFolder in ChildProjectFolders)
				{
					result.AddRange(childProjectFolder.ChildFileGroupsDeep);
				}

				return result;
			}
		}

		public VirtualViewCollection ChildVirtualViews
		{
			get
			{
				return _project.GetVirtualViewsByProjectFolderUniqueID(_uniqueID);
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public string Remarks { get; set; }

		public void StoreOrderPosition(
			object threadPoolManager,
			object postExecuteCallback,
			AsynchronousMode asynchronousMode,
			object userState)
		{
			_project.MarkAsModified();
		}

		public int OrderPosition
		{
			get
			{
				return _orderPosition;
			}
			set
			{
				_orderPosition = value;
			}
		}

		public Guid UniqueID
		{
			get
			{
				return _uniqueID;
			}
		}

		public Guid ParentUniqueID
		{
			get
			{
				return _parentUniqueID;
			}
		}

		public string NameIntelli
		{
			get
			{
				var p = Parent;

				if (p == null)
				{
					return _project.Name + @" » " + Name;
				}
				else
				{
					return p.NameIntelli + @" » " + Name;
				}
			}
		}

		public GridSourceType SourceType
		{
			get { return GridSourceType.ProjectFolder; }
		}

		FileGroup IGridEditableData.FileGroup
		{
			get { return null; }
		}

		public Project Project
		{
			get
			{
				return _project;
			}
			set
			{
				_project = value;
			}
		}

		ZlpDirectoryInfo IGridEditableData.FolderPath
		{
			get
			{
				var r = ((IGridEditableData)this).GetFileInformationsSorted();
				return r.Length <= 0 ? null : r[0].File.Directory;
			}
		}

		public FileGroupCollection FileGroupsDeep
		{
			get
			{
				var result = new FileGroupCollection(Project);

// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var fg in Project.FileGroups)
// ReSharper restore LoopCanBeConvertedToQuery
				{
					if (fg.IsDeepChildOf(this))
					{
						result.Add(fg);
					}
				}

				return result;
			}
		}

		internal void LoadFromXml(
			XmlNode node)
		{
			var attributes = node.Attributes;
			if (attributes == null)
			{
				throw new NullReferenceException();
			}

			XmlHelper.ReadAttribute(out _uniqueID, attributes[@"uniqueID"]);
			XmlHelper.ReadAttribute(out _parentUniqueID, attributes[@"parentUniqueID"]);
			XmlHelper.ReadAttribute(out _name, attributes[@"name"]);
			XmlHelper.ReadAttribute(out _orderPosition, attributes[@"orderPosition"]);

			var remarksNode = node.SelectSingleNode(@"remarks");
			Remarks = remarksNode != null ? remarksNode.InnerText : null;

			var dynSettingsNode = node.SelectSingleNode(@"dynSettings");
			if (dynSettingsNode != null)
			{
				_dynSettings.LoadFromXml(dynSettingsNode);
			}
		}

		internal void StoreToXml(
			XmlElement node)
		{
			var ownerDocument = node.OwnerDocument;
			if (ownerDocument == null)
			{
				throw new NullReferenceException();
			}

			var a = ownerDocument.CreateAttribute(@"uniqueID");
			a.Value = _uniqueID.ToString();
			node.Attributes.Append(a);

			a = ownerDocument.CreateAttribute(@"parentUniqueID");
			a.Value = _parentUniqueID.ToString();
			node.Attributes.Append(a);

			a = ownerDocument.CreateAttribute(@"name");
			a.Value = _name;
			node.Attributes.Append(a);

			a = ownerDocument.CreateAttribute(@"orderPosition");
			a.Value = _orderPosition.ToString();
			node.Attributes.Append(a);

			var remarksNode =
				ownerDocument.CreateElement(@"remarks");
			node.AppendChild(remarksNode);
			remarksNode.InnerText = Remarks;

			var dynSettingsNode =
				ownerDocument.CreateElement(@"dynSettings");
			node.AppendChild(dynSettingsNode);

			_dynSettings.StoreToXml(dynSettingsNode);
		}

		public int CompareTo(object obj)
		{
			return CompareTo((ProjectFolder)obj);
		}

		public int CompareTo(ProjectFolder other)
		{
			var a = _orderPosition.CompareTo(other._orderPosition);
			return a == 0 ? Name.CompareTo(other.Name) : a;
		}
	}
}