namespace ZetaResourceEditor.RuntimeBusinessLogic.Projects
{
	#region Using directives.
	// ----------------------------------------------------------------------
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Globalization;
	using System.IO;
	using System.Text;
	using System.Xml;
	using DL;
	using DynamicSettings;
	using FileGroups;
	using FileInformations;
	using Language;
	using ProjectFolders;
	using VirtualViews;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Common.Collections;
	using Zeta.EnterpriseLibrary.Tools.Storage;
	using ZetaLongPaths;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// 
	/// </summary>
	public class Project :
		ITranslationStateInformation,
		IUniqueID,
		IInheritedSettings,
		IGridEditableData,
		ILanguageColumnFilter
	{
		private readonly FileGroupCollection _fileGroups;
		private readonly ProjectFolderCollection _projectFolders;
		private readonly VirtualViewCollection _virtualViews;

		private bool _createBackupFiles;
		private bool _hideEmptyRows;
		private bool _hideTranslatedRows;
		private bool _useSpellChecker = true;
		private string _neutralLanguageCode = @"en-US";
		private ZlpFileInfo _projectConfigurationFilePath;
		private bool _isModified;
		private string _description;

		private readonly List<string> _languagesToDisplay = new List<string>();

		bool ILanguageColumnFilter.HasLanguageToDisplayFilter
		{
			get
			{
				return _languagesToDisplay.Count > 0;
			}
		}

		bool ILanguageColumnFilter.WantDisplayLanguageColumnInGrid(
			CultureInfo ci)
		{
			return ((ILanguageColumnFilter)this).WantDisplayLanguageColumnInGrid(ci.Name);
		}

		bool ILanguageColumnFilter.WantDisplayLanguageColumnInGrid(
			string language)
		{
			if (_languagesToDisplay.Count <= 0)
			{
				return true;
			}
			else
			{
				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var l in _languagesToDisplay)
				// ReSharper restore LoopCanBeConvertedToQuery
				{
					if (string.Compare(l, language, StringComparison.OrdinalIgnoreCase) == 0)
					{
						return true;
					}
				}

				return false;
			}
		}

		public CultureInfo[] LanguagesToDisplay
		{
			get
			{
				var result = new List<CultureInfo>();

				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var l in _languagesToDisplay)
				// ReSharper restore LoopCanBeConvertedToQuery
				{
					if (!string.IsNullOrEmpty(l))
					{
						result.Add(CultureHelper.CreateCultureErrorTolerant(l));
					}
				}

				return result.ToArray();
			}
			set
			{
				_languagesToDisplay.Clear();

				if (value != null)
				{
					foreach (var cultureInfo in value)
					{
						_languagesToDisplay.Add(cultureInfo.Name);
					}
				}

				MarkAsModified();
			}
		}

		public bool HideEmptyRows
		{
			get
			{
				return _hideEmptyRows;
			}
			set
			{
				_hideEmptyRows = value;
				MarkAsModified();
			}
		}

		public bool HideTranslatedRows
		{
			get
			{
				return _hideTranslatedRows;
			}
			set
			{
				_hideTranslatedRows = value;
				MarkAsModified();
			}
		}

		public FileGroupStateColor TranslationStateColor
		{
			get
			{
				var result = FileGroupStateColor.None;

				foreach (var fileGroup in GetRootFileGroups())
				{
					// Shortcut evaluation.
					if (result == FileGroupStateColor.Red /*||
						result == FileGroupStateColor.Yellow*/
															  )
					{
						return result;
					}

					result =
						FileGroup.CombineColorKeys(
							result,
							fileGroup.TranslationStateColor);
				}

				foreach (var projectFolder in GetRootProjectFolders())
				{
					// Shortcut evaluation.
					if (result == FileGroupStateColor.Red /*||
						result == FileGroupStateColor.Yellow*/
															  )
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

		public const string ProjectFileExtension = @".zreproj";

		private readonly DynamicSettings _dynamicSettingsUser =
			new DynamicSettings(
				string.Format(
					@"{0}@{1}",
					Environment.UserName,
					Environment.UserDomainName));

		private readonly DynamicSettings _dynamicSettingsGlobal =
			new DynamicSettings(string.Empty);

		private IPersistentPairStorage _dynamicSettingsGlobalHierarchical;
		private IPersistentPairStorage _dynamicSettingsUserHierarchical;

		public static readonly string[] DefaultWordsToProtect =
			new[]
				{
					@"{0}",
					@"{1}",
					@"{2}",
					@"{3}",
					@"{4}",
					@"{5}",
					@"{6}",
					@"{7}",
					@"{8}",
					@"{9}",
					@"{10}",

					@"""{0}""",
					@"""{1}""",
					@"""{2}""",
					@"""{3}""",
					@"""{4}""",
					@"""{5}""",
					@"""{6}""",
					@"""{7}""",
					@"""{8}""",
					@"""{9}""",
					@"""{10}""",

					@"'{0}'",
					@"'{1}'",
					@"'{2}'",
					@"'{3}'",
					@"'{4}'",
					@"'{5}'",
					@"'{6}'",
					@"'{7}'",
					@"'{8}'",
					@"'{9}'",
					@"'{10}'"
				};

		private static Project _emptyProject;

		public event EventHandler ModifyStateChanged;

		public void MarkAsModified()
		{
			_isModified = true;
			notifyModifyStateChanged();
		}

		private void MarkAsUnmodified()
		{
			_isModified = false;
			_dynamicSettingsGlobal.MarkAsUnmodified();

			// Do not mark the user settings.

			notifyModifyStateChanged();
		}

		private void notifyModifyStateChanged()
		{
			if (ModifyStateChanged != null)
			{
				ModifyStateChanged(this, EventArgs.Empty);
			}
		}

		public Project()
		{
			_fileGroups = new FileGroupCollection(this);
			_projectFolders = new ProjectFolderCollection(this);
			_virtualViews = new VirtualViewCollection(this);

			/*
			PortableExecutableKinds peKind;
			ImageFileMachine machine;
			typeof(System.Data.SQLite.SQLiteCommand).Module.GetPEKind(out peKind, out machine );

			Trace.Write(peKind);
			Trace.Write(machine);*/
		}

		public FileGroupCollection FileGroups
		{
			get
			{
				return _fileGroups;
			}
		}

		public ProjectFolderCollection ProjectFolders
		{
			get
			{
				return _projectFolders;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [create backup files].
		/// </summary>
		/// <value><c>true</c> if [create backup files]; otherwise, <c>false</c>.</value>
		[DefaultValue(false)]
		public bool CreateBackupFiles
		{
			get
			{
				return _createBackupFiles;
				//return ConvertHelper.ToBoolean(
				//    DynamicSettingsGlobal.RetrieveValue( @"CreateBackupFiles" ),
				//    false );
			}
			set
			{
				_createBackupFiles = value;
				//DynamicSettingsGlobal.PersistValue( @"CreateBackupFiles", value );
			}
		}

		/// <summary>
		/// Gets the project configuration file path.
		/// </summary>
		/// <value>The project configuration file path.</value>
		public ZlpFileInfo ProjectConfigurationFilePath
		{
			get
			{
				return _projectConfigurationFilePath;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this instance is modified.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance is modified; otherwise, <c>false</c>.
		/// </value>
		public bool IsModified
		{
			get
			{
				return
					!IsInMemoryOnly &&
					(_isModified || _dynamicSettingsGlobal.IsModified);

				// Do not count the user settings, as they only contain
				// automatically storable items.
			}
		}

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get
			{
				return ZlpPathHelper.GetFileNameWithoutExtension(
					_projectConfigurationFilePath.Name);
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

		public bool UseSpellChecker
		{
			get
			{
				return _useSpellChecker;
			}
			set
			{
				_useSpellChecker = value;
			}
		}

		/// <summary>
		/// Gets the modified char.
		/// </summary>
		/// <value>The modified char.</value>
		public static string ModifiedChar
		{
			get
			{
				return @"*";
				//return @"°";
				//return @"•";
			}
		}

		public DynamicSettings DynamicSettingsGlobal
		{
			get
			{
				return _dynamicSettingsGlobal;
			}
		}

		public DynamicSettings DynamicSettingsUser
		{
			get
			{
				return _dynamicSettingsUser;
			}
		}

		public IPersistentPairStorage DynamicSettingsGlobalHierarchical
		{
			get
			{
				// ReSharper disable ConvertIfStatementToNullCoalescingExpression
				if (_dynamicSettingsGlobalHierarchical == null)
				// ReSharper restore ConvertIfStatementToNullCoalescingExpression
				{
					_dynamicSettingsGlobalHierarchical =
						new DynamicSettingsHierarchical(
							_dynamicSettingsGlobal,
							PersistanceHelper.Storage);
				}

				return _dynamicSettingsGlobalHierarchical;
			}
		}

		public IPersistentPairStorage DynamicSettingsUserHierarchical
		{
			get
			{
				// ReSharper disable ConvertIfStatementToNullCoalescingExpression
				if (_dynamicSettingsUserHierarchical == null)
				// ReSharper restore ConvertIfStatementToNullCoalescingExpression
				{
					_dynamicSettingsUserHierarchical =
						new DynamicSettingsHierarchical(
							_dynamicSettingsUser,
							PersistanceHelper.Storage);
				}

				return _dynamicSettingsUserHierarchical;
			}
		}

		public bool OmitEmptyItems
		{
			get
			{
				return ConvertHelper.ToBoolean(
					DynamicSettingsGlobal.RetrieveValue(@"OmitEmptyItems"),
					true);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(@"OmitEmptyItems", value);
			}
		}

		public int BaseNameDotCount
		{
			get
			{
				return ConvertHelper.ToInt32(
					DynamicSettingsGlobal.RetrieveValue(@"BaseNameDotCount"),
					0);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(@"BaseNameDotCount", value);
			}
		}

		public string NeutralLanguageFileNamePattern
		{
			get
			{
				var result = ConvertHelper.ToString(
					DynamicSettingsGlobal.RetrieveValue(@"NeutralLanguageFileNamePattern"));

				if (string.IsNullOrEmpty(result))
				{
					return @"[basename][optionaldefaulttypes].[extension]";
				}
				else
				{
					return result;
				}
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(@"NeutralLanguageFileNamePattern", value);
			}
		}

		public string NonNeutralLanguageFileNamePattern
		{
			get
			{
				var result = ConvertHelper.ToString(
					DynamicSettingsGlobal.RetrieveValue(@"NonNeutralLanguageFileNamePattern"));

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
				DynamicSettingsGlobal.PersistValue(@"NonNeutralLanguageFileNamePattern", value);
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
					var result = new Set<string>();

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
					DynamicSettingsGlobal.RetrieveValue(@"DefaultFileTypesToIgnore"));

				if (result == null)
				{
					return @".aspx;.ascx;.asmx;.master;.sitemap";
				}
				else
				{
					return result;
				}
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(@"DefaultFileTypesToIgnore", value);
			}
		}

		public bool IgnoreWindowsFormsResourcesWithDesignerFiles
		{
			get
			{
				return ConvertHelper.ToBoolean(
					DynamicSettingsGlobal.RetrieveValue(
						@"IgnoreWindowsFormsResourcesWithDesignerFiles"),
					true);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(
					@"IgnoreWindowsFormsResourcesWithDesignerFiles",
					value);
			}
		}

		public bool UseShallowGridDataCumulation
		{
			get
			{
				return ConvertHelper.ToBoolean(
					DynamicSettingsGlobal.RetrieveValue(
						@"UseShallowGridDataCumulation"),
					true);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(
					@"UseShallowGridDataCumulation",
					value);
			}
		}

		public bool HideFileGroupFilesInTree
		{
			get
			{
				return ConvertHelper.ToBoolean(
					DynamicSettingsGlobal.RetrieveValue(
						@"HideFileGroupFilesInTree"),
					true);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(
					@"HideFileGroupFilesInTree",
					value);
			}
		}

		public ReadOnlyFileOverwriteBehaviour ReadOnlyFileOverwriteBehaviour
		{
			get
			{
				return (ReadOnlyFileOverwriteBehaviour)ConvertHelper.ToInt32(
					DynamicSettingsGlobal.RetrieveValue(
						@"ReadOnlyFileOverwriteBehaviour"),
					(int)ReadOnlyFileOverwriteBehaviour.Overwrite);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(
					@"ReadOnlyFileOverwriteBehaviour",
					(int)value);
			}
		}

		public bool ShowCommentsColumnInGrid
		{
			get
			{
				return ConvertHelper.ToBoolean(
					DynamicSettingsGlobal.RetrieveValue(
						@"ShowCommentsColumnInGrid"),
					false);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(
					@"ShowCommentsColumnInGrid",
					value);
			}
		}

		public bool ColorifyNullCells
		{
			get
			{
				return ConvertHelper.ToBoolean(
					DynamicSettingsGlobal.RetrieveValue(
						@"ColorifyNullCells"),
					true);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(
					@"ColorifyNullCells",
					value);
			}
		}

		public bool EnableExcelExportSnapshots
		{
			get
			{
				return ConvertHelper.ToBoolean(
					DynamicSettingsGlobal.RetrieveValue(
						@"EnableExcelExportSnapshots"),
					true);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(
					@"EnableExcelExportSnapshots",
					value);
			}
		}

		public bool HideInternalDesignerRows
		{
			get
			{
				return ConvertHelper.ToBoolean(
					DynamicSettingsGlobal.RetrieveValue(
						@"HideInternalDesignerRows"),
					true);
			}
			set
			{
				DynamicSettingsGlobal.PersistValue(
					@"HideInternalDesignerRows",
					value);
			}
		}

		/// <summary>
		/// Creates a new project for the given path.
		/// Does not store.
		/// </summary>
		/// <param name="projectConfigurationFilePath">The project configuration file path.</param>
		/// <returns></returns>
		public static Project CreateNew(
			ZlpFileInfo projectConfigurationFilePath)
		{
			var project =
				new Project
					{
						_projectConfigurationFilePath = projectConfigurationFilePath
					};

			return project;
		}

		//public static Project CreateHelperProjectInMemoryOnly()
		//{
		//    var project =
		//        new Project
		//            {
		//                IsInMemoryOnly = true,
		//                _projectConfigurationFilePath =
		//                    new ZlpFileInfo(
		//                    ZlpPathHelper.Combine(
		//                        Path.GetTempPath(),
		//                        string.Format(@"Dummy{0}", ProjectFileExtension)))
		//            };

		//    return project;
		//}

		public bool IsInMemoryOnly { get; private set; }

		/// <summary>
		/// Makes a given absolute file path relative to the project location.
		/// </summary>
		/// <param name="absoluteFilePath">The absolute file path.</param>
		/// <returns></returns>
		internal string MakeRelativeFilePath(
			string absoluteFilePath)
		{
			if (_projectConfigurationFilePath == null)
			{
				return absoluteFilePath;
			}
			else
			{
				return ZlpPathHelper.GetRelativePath(
					_projectConfigurationFilePath.DirectoryName,
					absoluteFilePath);
			}
		}

		/// <summary>
		/// Makes a given absolute file path relative to the project location.
		/// </summary>
		/// <param name="relativeFilePath">The relative file path.</param>
		/// <returns></returns>
		internal string MakeAbsoluteFilePath(
			string relativeFilePath)
		{
			if (_projectConfigurationFilePath == null)
			{
				return relativeFilePath;
			}
			else
			{
				return ZlpPathHelper.GetAbsolutePath(
					relativeFilePath,
					_projectConfigurationFilePath.DirectoryName);
			}
		}

		/// <summary>
		/// Loads the specified project configuration file path.
		/// </summary>
		/// <param name="projectConfigurationFilePath">The project configuration 
		/// file path.</param>
		public void Load(
			ZlpFileInfo projectConfigurationFilePath)
		{
			_projectConfigurationFilePath = projectConfigurationFilePath;

			var doc = XmlHelper.CreateDocument();
			doc.Load(projectConfigurationFilePath.FullName);

			var rootNode = doc.SelectSingleNode(@"project");

			loadFromXml(rootNode);
			_fileGroups.LoadFromXml(rootNode);
			_projectFolders.LoadFromXml(rootNode);
			_virtualViews.LoadFromXml(rootNode);

			MarkAsUnmodified();
		}

		public void SilentStore()
		{
			if (_projectConfigurationFilePath != null)
			{
				Store();
			}
		}

		/// <summary>
		/// Stores this instance.
		/// </summary>
		public void Store()
		{
			// ReSharper disable InvocationIsSkipped
			Debug.Assert(_projectConfigurationFilePath != null/* &&
				_projectConfigurationFilePath.Exists*/
													   );
			// ReSharper restore InvocationIsSkipped

			StoreAs(_projectConfigurationFilePath);
			MarkAsUnmodified();
		}

		/// <summary>
		/// Stores at the specified location.
		/// </summary>
		/// <param name="projectConfigurationFilePath">The project configuration
		/// file path.</param>
		public void StoreAs(
			ZlpFileInfo projectConfigurationFilePath)
		{
			_projectConfigurationFilePath = projectConfigurationFilePath;

			var doc = XmlHelper.CreateDocument(Encoding.UTF8);

			var rootNode = doc.CreateElement(@"project");
			doc.AppendChild(rootNode);

			storeToXml(rootNode);
			_fileGroups.StoreToXml(rootNode);
			_projectFolders.StoreToXml(rootNode);

			projectConfigurationFilePath.Refresh();
			if (projectConfigurationFilePath.Exists)
			{
				projectConfigurationFilePath.Delete();
			}

			doc.Save(projectConfigurationFilePath.FullName);
			MarkAsUnmodified();
		}

		/// <summary>
		/// Stores to XML.
		/// </summary>
		/// <param name="parentNode">The parent node.</param>
		private void storeToXml(
			XmlNode parentNode)
		{
			// ReSharper disable InvocationIsSkipped
			Debug.Assert(this != null);
			// ReSharper restore InvocationIsSkipped

			if (parentNode.OwnerDocument != null)
			{
				var configurationNode =
					parentNode.OwnerDocument.CreateElement(@"configuration");
				parentNode.AppendChild(configurationNode);

				// --

				foreach (var key in _dynamicSettingsGlobal.DirectValues.Keys)
				{
					var value = _dynamicSettingsGlobal.DirectValues[key];

					if (parentNode.OwnerDocument != null)
					{
						var settingsNode = parentNode.OwnerDocument.CreateElement(@"globalSetting");
						configurationNode.AppendChild(settingsNode);

						var ma =
							parentNode.OwnerDocument.CreateAttribute(@"name");
						ma.Value = key;
						settingsNode.Attributes.Append(ma);
						settingsNode.InnerText = value;
					}
				}

				// --

				foreach (var key in _dynamicSettingsUser.DirectValues.Keys)
				{
					var value = _dynamicSettingsUser.DirectValues[key];

					if (parentNode.OwnerDocument != null)
					{
						var settingsNode = parentNode.OwnerDocument.CreateElement(@"userSetting");
						configurationNode.AppendChild(settingsNode);

						var ma =
							parentNode.OwnerDocument.CreateAttribute(@"name");
						ma.Value = key;
						settingsNode.Attributes.Append(ma);
						settingsNode.InnerText = value;
					}
				}

				// --

				if (parentNode.OwnerDocument != null)
				{
					var a = parentNode.OwnerDocument.CreateAttribute(@"createBackupFiles");
					a.Value = _createBackupFiles.ToString(CultureInfo.InvariantCulture);
					configurationNode.Attributes.Append(a);

					a = parentNode.OwnerDocument.CreateAttribute(@"hideEmptyRows");
					a.Value = _hideEmptyRows.ToString(CultureInfo.InvariantCulture);
					configurationNode.Attributes.Append(a);

					a = parentNode.OwnerDocument.CreateAttribute(@"hideTranslatedRows");
					a.Value = _hideTranslatedRows.ToString(CultureInfo.InvariantCulture);
					configurationNode.Attributes.Append(a);

					a = parentNode.OwnerDocument.CreateAttribute(@"useSpellChecker");
					a.Value = _useSpellChecker.ToString(CultureInfo.InvariantCulture);
					configurationNode.Attributes.Append(a);

					a = parentNode.OwnerDocument.CreateAttribute(@"neutralLanguageCode");
					a.Value = _neutralLanguageCode;
					configurationNode.Attributes.Append(a);

					var descriptionNode =
						parentNode.OwnerDocument.CreateElement(@"description");
					configurationNode.AppendChild(descriptionNode);
					descriptionNode.InnerText = _description;

					a = parentNode.OwnerDocument.CreateAttribute(@"languagesToDisplay");
					a.Value = string.Join(@";", _languagesToDisplay.ToArray());
					configurationNode.Attributes.Append(a);
				}
			}
		}

		public string NeutralLanguageCode
		{
			get
			{
				return string.IsNullOrEmpty(_neutralLanguageCode) ? @"en-us" : _neutralLanguageCode.ToLowerInvariant();
			}
			set
			{
				_neutralLanguageCode = value == null ? null : value.ToLowerInvariant();
			}
		}

		/// <summary>
		/// Loads from XML.
		/// </summary>
		/// <param name="parentNode">The parent node.</param>
		private void loadFromXml(
			XmlNode parentNode)
		{
			// ReSharper disable InvocationIsSkipped
			Debug.Assert(this != null);
			// ReSharper restore InvocationIsSkipped

			var configurationNode =
				parentNode.SelectSingleNode(@"configuration");

			if (configurationNode != null)
			{
				if (configurationNode.Attributes != null)
				{
					XmlHelper.ReadAttribute(
						out _createBackupFiles,
						configurationNode.Attributes[@"createBackupFiles"]);

					XmlHelper.ReadAttribute(
						out _hideEmptyRows,
						configurationNode.Attributes[@"hideEmptyRows"]);

					XmlHelper.ReadAttribute(
						out _hideTranslatedRows,
						configurationNode.Attributes[@"hideTranslatedRows"]);

					XmlHelper.ReadAttribute(
						out _useSpellChecker,
						configurationNode.Attributes[@"useSpellChecker"],
						true);

					XmlHelper.ReadAttribute(
						out _neutralLanguageCode,
						configurationNode.Attributes[@"neutralLanguageCode"],
						@"en-US");
				}
			}

			// --

			string lsRaw = null;
			if (configurationNode != null)
			{
				if (configurationNode.Attributes != null)
				{
					XmlHelper.ReadAttribute(
						out lsRaw,
						configurationNode.Attributes[@"languagesToDisplay"],
						null);
				}
			}

			_languagesToDisplay.Clear();
			if (lsRaw != null)
			{
				_languagesToDisplay.AddRange(
					lsRaw.Split(
						new[] { @";" },
						StringSplitOptions.RemoveEmptyEntries));
			}

			// --

			_dynamicSettingsGlobal.DirectValues.Clear();

			if (configurationNode != null)
			{
				var globalSettingsNodes = configurationNode.SelectNodes(@"globalSetting");
				if (globalSettingsNodes != null)
				{
					foreach (XmlNode globalSettingsNode in globalSettingsNodes)
					{
						if (globalSettingsNode.Attributes != null)
						{
							string name;
							XmlHelper.ReadAttribute(
								   out name,
								   globalSettingsNode.Attributes[@"name"]);

							var value = globalSettingsNode.InnerText;

							if (!string.IsNullOrEmpty(name))
							{
								_dynamicSettingsGlobal.DirectValues[name] = value;
							}
						}
					}
				}
			}

			_dynamicSettingsGlobal.MarkAsUnmodified();

			// --

			_dynamicSettingsUser.DirectValues.Clear();

			if (configurationNode != null)
			{
				var userSettingsNodes = configurationNode.SelectNodes(@"userSetting");
				if (userSettingsNodes != null)
				{
					foreach (XmlNode userSettingsNode in userSettingsNodes)
					{
						if (userSettingsNode.Attributes != null)
						{
							string name;
							XmlHelper.ReadAttribute(
								   out name,
								   userSettingsNode.Attributes[@"name"]);

							var value = userSettingsNode.InnerText;

							if (!string.IsNullOrEmpty(name))
							{
								_dynamicSettingsUser.DirectValues[name] = value;
							}
						}
					}
				}
			}

			_dynamicSettingsUser.MarkAsUnmodified();

			// --

			if (configurationNode != null)
			{
				var descriptionNode =
					configurationNode.SelectSingleNode(@"description");
				_description = descriptionNode == null ? null : descriptionNode.InnerText;
			}
		}

		public ProjectFolder GetProjectFolderByUniqueID(Guid uniqueID)
		{
			if (uniqueID == Guid.Empty)
			{
				return null;
			}
			else
			{
				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var projectFolder in _projectFolders)
				// ReSharper restore LoopCanBeConvertedToQuery
				{
					if (projectFolder.UniqueID == uniqueID)
					{
						return projectFolder;
					}
				}

				return null;
			}
		}

		public ProjectFolderCollection GetRootProjectFolders()
		{
			return GetProjectFoldersByParentUniqueID(Guid.Empty);
		}

		public ProjectFolderCollection GetProjectFoldersByParentUniqueID(
			Guid uniqueID)
		{
			var result = new ProjectFolderCollection(this);

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var projectFolder in _projectFolders)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				if (projectFolder.ParentUniqueID == uniqueID)
				{
					result.Add(projectFolder);
				}
			}

			result.Sort();
			return result;
		}

		public VirtualViewCollection GetRootVirtualViews()
		{
			return GetVirtualViewsByProjectFolderUniqueID(Guid.Empty);
		}

		public VirtualViewCollection GetVirtualViewsByProjectFolderUniqueID(
			Guid uniqueID)
		{
			var result = new VirtualViewCollection(this);

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var virtualView in _virtualViews)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				if (virtualView.ProjectFolderUniqueID == uniqueID)
				{
					result.Add(virtualView);
				}
			}

			result.Sort();
			return result;
		}

		public FileGroupCollection GetRootFileGroups()
		{
			return GetFileGroupsByProjectFolderUniqueID(Guid.Empty);
		}

		public FileGroupCollection GetFileGroupsByProjectFolderUniqueID(
			Guid uniqueID)
		{
			var result = new FileGroupCollection(this);

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var fileGroup in _fileGroups)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				if (fileGroup.ProjectFolderUniqueID == uniqueID)
				{
					result.Add(fileGroup);
				}
			}

			result.Sort();
			return result;
		}

		public Guid UniqueID
		{
			get
			{
				return new Guid(@"09D52927-1300-48F4-8DF1-1437F30D5BC3");
			}
		}

		public FileGroup GetFileGroupByCheckSum(long checksum)
		{
			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var fileGroup in _fileGroups)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				if (fileGroup.GetChecksum(this) == checksum)
				{
					return fileGroup;
				}
			}

			return null;
		}

		#region IInheritedSettings Members

		public GridSourceType SourceType
		{
			get { return GridSourceType.Project; }
		}

		FileGroup IGridEditableData.FileGroup
		{
			get { return null; }
		}

		Project IGridEditableData.Project
		{
			get
			{
				return this;
			}
			set
			{
				// Do nothings.
			}
		}

		ZlpDirectoryInfo IGridEditableData.FolderPath
		{
			get
			{
				return _projectConfigurationFilePath.Directory;
			}
		}

		FileInformation[] IGridEditableData.GetFileInformationsSorted()
		{
			var result = new List<FileInformation>();

			var sfg = UseShallowGridDataCumulation ? GetRootFileGroups() : _fileGroups;
			sfg.ForEach(x => result.AddRange(x.GetFileInfos()));

			result.Sort();
			return result.ToArray();
		}

		IInheritedSettings IGridEditableData.ParentSettings
		{
			get { return this; }
		}

		FileGroupStates IGridEditableData.InMemoryState
		{
			get
			{
				var sfg = UseShallowGridDataCumulation ? GetRootFileGroups() : _fileGroups;
				if (sfg.Count <= 0)
				{
					return FileGroupStates.Empty;
				}
				else
				{
					return sfg[0].InMemoryState;
				}
			}
			set
			{
				var sfg = UseShallowGridDataCumulation ? GetRootFileGroups() : _fileGroups;
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
				return FileGroup.JoinFilePaths(((IGridEditableData)this).FilePaths);
			}
		}

		string IGridEditableData.GetNameIntelligent(Project project)
		{
			return Name;
		}

		public long GetChecksum(Project project)
		{
			// A project always has a fix checksum.
			return @"d0b4146f-af54-49cf-86f5-9f1b185c0890".GetHashCode();
		}

		string[] IGridEditableData.GetLanguageCodes(Project project)
		{
			var result = new Set<string>();

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
			return _projectConfigurationFilePath.FullName;
		}

		IInheritedSettings IInheritedSettings.ParentSettings
		{
			get
			{
				return null;
			}
		}

		int IInheritedSettings.EffectiveBaseNameDotCount
		{
			get
			{
				return BaseNameDotCount;
			}
		}

		public bool EffectiveIgnoreDuringExportAndImport
		{
			get { return false; }
		}

		string IInheritedSettings.EffectiveNeutralLanguageFileNamePattern
		{
			get
			{
				return NeutralLanguageFileNamePattern;
			}
		}

		string IInheritedSettings.EffectiveNonNeutralLanguageFileNamePattern
		{
			get
			{
				return NonNeutralLanguageFileNamePattern;
			}
		}

		string[] IInheritedSettings.EffectiveDefaultFileTypesToIgnoreArray
		{
			get
			{
				return DefaultFileTypesToIgnoreArray;
			}
		}

		string IInheritedSettings.EffectiveDefaultFileTypesToIgnore
		{
			get
			{
				return DefaultFileTypesToIgnore;
			}
		}

		string IInheritedSettings.EffectiveNeutralLanguageCode
		{
			get
			{
				return NeutralLanguageCode;
			}
		}

		public int TranslationDelayMilliseconds
		{
			get
			{
				return
					ConvertHelper.ToInt32(
						DynamicSettingsGlobalHierarchical.RetrieveValue(
							@"Project-TranslationDelayMilliseconds"),
							2000);
			}
			set
			{
				DynamicSettingsGlobalHierarchical.PersistValue(
					@"Project-TranslationDelayMilliseconds",
					value);
			}
		}

		public bool TranslationContinueOnErrors
		{
			get
			{
				return
					ConvertHelper.ToBoolean(
						DynamicSettingsGlobalHierarchical.RetrieveValue(
							@"Project-TranslationContinueOnErrors"),
							true);
			}
			set
			{
				DynamicSettingsGlobalHierarchical.PersistValue(
					@"Project-TranslationContinueOnErrors",
					value);
			}
		}

		public bool PersistGridSettings
		{
			get
			{
				return
					ConvertHelper.ToBoolean(
						DynamicSettingsGlobalHierarchical.RetrieveValue(
							@"Project-PersistGridSettings"),
							true);
			}
			set
			{
				DynamicSettingsGlobalHierarchical.PersistValue(
					@"Project-PersistGridSettings",
					value);
			}
		}

		#endregion

		private class ProjectMruItem
		{
			public GridSourceType Type { get; set; }
			public long Checksum { get; set; }

			public void ToXml(XmlNode node)
			{
				if (node.OwnerDocument != null)
				{
					var a = node.OwnerDocument.CreateAttribute(@"type");
					a.InnerText = ((int)Type).ToString(CultureInfo.InvariantCulture);
					if (node.Attributes != null)
					{
						node.Attributes.Append(a);

						a = node.OwnerDocument.CreateAttribute(@"checksum");
						a.InnerText = Checksum.ToString(CultureInfo.InvariantCulture);
						node.Attributes.Append(a);
					}
				}
			}

			public ProjectMruItem FromXml(
				XmlNode node)
			{
				if (node.Attributes != null)
				{
					int i;
					XmlHelper.ReadAttribute(out i, node.Attributes[@"type"]);
					Type = (GridSourceType)i;

					long l;
					XmlHelper.ReadAttribute(out l, node.Attributes[@"checksum"]);
					Checksum = l;
				}
				return this;
			}
		}

		private class ProjectMruItemCollection :
			List<ProjectMruItem>
		{
			private readonly Project _project;

			public ProjectMruItemCollection(Project project)
			{
				_project = project;
			}

			public void Add(IGridEditableData gridEditableData)
			{
				ProjectMruItem existingItem = null;

				// ReSharper disable LoopCanBeConvertedToQuery
				foreach (var mruItem in this)
				// ReSharper restore LoopCanBeConvertedToQuery
				{
					if (mruItem.Checksum == gridEditableData.GetChecksum(_project) &&
						mruItem.Type == gridEditableData.SourceType)
					{
						// Found.
						existingItem = mruItem;
						break;
					}
				}

				if (existingItem == null)
				{
					Add(
					new ProjectMruItem
					{
						Checksum = gridEditableData.GetChecksum(_project),
						Type = gridEditableData.SourceType
					});
				}
			}

			public void Remove(IGridEditableData gridEditableData)
			{
				foreach (var mruItem in this)
				{
					if (mruItem.Checksum == gridEditableData.GetChecksum(_project) &&
						mruItem.Type == gridEditableData.SourceType)
					{
						// Found.
						Remove(mruItem);
						return;
					}
				}
			}
		}

		private ProjectMruItemCollection projectMruItems
		{
			get
			{
				var raw =
					ConvertHelper.ToString(
					DynamicSettingsGlobal.RetrieveValue(@"projectMruItems"));

				var result = new ProjectMruItemCollection(this);

				if (!string.IsNullOrEmpty(raw))
				{
					var doc = new XmlDocument();
					doc.LoadXml(raw);

					var nodes = doc.SelectNodes(@"/items/item");

					if (nodes != null)
					{
						// ReSharper disable LoopCanBeConvertedToQuery
						foreach (XmlNode node in nodes)
						// ReSharper restore LoopCanBeConvertedToQuery
						{
							result.Add(new ProjectMruItem().FromXml(node));
						}
					}
				}

				return result;
			}
			set
			{
				var doc = XmlHelper.CreateDocument(Encoding.UTF8);
				var itemsNode = doc.CreateElement(@"items");
				doc.AppendChild(itemsNode);

				foreach (var mruItem in value)
				{
					var itemNode = doc.CreateElement(@"item");
					itemsNode.AppendChild(itemNode);

					mruItem.ToXml(itemNode);
				}

				using (new SilentProjectStoreGuard(this))
				{
					DynamicSettingsGlobal.PersistValue(@"projectMruItems", doc.OuterXml);
				}
			}
		}

		/// <summary>
		/// Sometimes an empty project is needed. Use this here centrally.
		/// </summary>
		public static Project Empty
		{
			get
			{
				return _emptyProject ?? (_emptyProject = new Project
				                                         	{
				                                         		IsInMemoryOnly = true,
				                                         		_projectConfigurationFilePath =
				                                         			new ZlpFileInfo(
				                                         			ZlpPathHelper.Combine(
				                                         				Path.GetTempPath(),
				                                         				string.Format(@"Dummy{0}", ProjectFileExtension)))
				                                         	});
			}
		}

		public Dictionary<string,string> TranslationAppIDs
		{
			get
			{
				var raw = ConvertHelper.ToString(
					DynamicSettingsGlobalHierarchical.RetrieveValue(
						@"Project-TranslationAppIDs"));

				if (string.IsNullOrEmpty(raw))
				{
					return new Dictionary<string, string>();
				}
				else
				{
					var result = new Dictionary<string, string>();

					var pairs = raw.Trim().Split(new[] {@"~~~~"}, StringSplitOptions.RemoveEmptyEntries);

					foreach (var pair in pairs)
					{
						var items = pair.Split(new[] {@"=<>="}, StringSplitOptions.RemoveEmptyEntries);

						if (items.Length == 2)
						{
							result[items[0].Trim()] = items[1].Trim();
						}
					}

					return result;
				}
			}
			set
			{
				var raw = string.Empty;

				if (value != null && value.Count > 0)
				{
					foreach (var key in value.Keys)
					{
						if (raw.Length > 0)
						{
							raw += @"~~~~";
						}

						var pair = string.Format(@"{0}=<>={1}", key.Trim(), value[key].Trim());
						raw += pair;
					}
				}

				DynamicSettingsGlobalHierarchical.PersistValue(
					@"Project-TranslationAppIDs",
					raw);
			}
		}

		public string TranslationEngineUniqueInternalName
		{
			get
			{
				return ConvertHelper.ToString(
					DynamicSettingsGlobalHierarchical.RetrieveValue(
						@"Project-TranslationEngineUniqueInternalName"));
			}
			set
			{
				DynamicSettingsGlobalHierarchical.PersistValue(
					@"Project-TranslationEngineUniqueInternalName",
					value);
			}
		}

		public string[] TranslationWordsToProtect
		{
			get
			{
				var r =
					ConvertHelper.ToString(
					DynamicSettingsGlobalHierarchical.RetrieveValue(
						@"Project-TranslationWordsToProtect"));

				if (r == null)
				{
					return DefaultWordsToProtect;
				}
				else
				{
					return r.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
				}
			}
			set
			{
				DynamicSettingsGlobalHierarchical.PersistValue(
					@"Project-TranslationWordsToProtect",
					value == null ? string.Empty : string.Join(Environment.NewLine, value));
			}
		}

		public string[] TranslationWordsToRemove
		{
			get
			{
				var r =
					ConvertHelper.ToString(
					DynamicSettingsGlobalHierarchical.RetrieveValue(
						@"Project-TranslationWordsToRemove"));

				if (r == null)
				{
					return new string[] { };
				}
				else
				{
					return r.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
				}
			}
			set
			{
				DynamicSettingsGlobalHierarchical.PersistValue(
					@"Project-TranslationWordsToRemove",
					value == null ? string.Empty : string.Join(Environment.NewLine, value));
			}
		}

		public void ClearMruElements()
		{
			var items = projectMruItems;
			items.Clear();

			projectMruItems = items;
		}

		public void AddMruElement(IGridEditableData gridEditableData)
		{
			var items = projectMruItems;
			items.Add(gridEditableData);

			projectMruItems = items;
		}

		public void RemoveMruElement(IGridEditableData gridEditableData)
		{
			var items = projectMruItems;
			items.Remove(gridEditableData);

			projectMruItems = items;
		}

		public IGridEditableData[] GetProjectMruItems()
		{
			var result = new List<IGridEditableData>();

			var mruItems = projectMruItems;

			// ReSharper disable LoopCanBeConvertedToQuery
			foreach (var mruItem in mruItems)
			// ReSharper restore LoopCanBeConvertedToQuery
			{
				var e = getDataItemByMruItem(mruItem);
				if (e != null)
				{
					result.Add(e);
				}
			}

			return result.ToArray();
		}

		private IGridEditableData getDataItemByMruItem(ProjectMruItem mruItem)
		{
			switch (mruItem.Type)
			{
				case GridSourceType.Project:
					return this;

				case GridSourceType.ProjectFolder:
					foreach (var projectFolder in _projectFolders)
					{
						if (projectFolder.GetChecksum(this) == mruItem.Checksum)
						{
							return projectFolder;
						}
					}
					return null;

				case GridSourceType.FileGroup:
					foreach (var fileGroup in _fileGroups)
					{
						if (fileGroup.GetChecksum(this) == mruItem.Checksum)
						{
							return fileGroup;
						}
					}
					return null;

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		public bool IsNeutralLanguage(CultureInfo cultureInfo)
		{
			return string.Compare(cultureInfo.Name, _neutralLanguageCode, StringComparison.OrdinalIgnoreCase) == 0;
		}
	}

	/////////////////////////////////////////////////////////////////////////
}