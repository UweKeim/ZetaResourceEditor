namespace ZetaResourceEditor.RuntimeBusinessLogic.VirtualViews
{
	using System;
	using System.Xml;
	using DL;
	using FileGroups;
	using ProjectFolders;
	using Projects;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Common.Collections;
	using Zeta.EnterpriseLibrary.Tools.Asynchronous;

	public class VirtualView :
		ITranslationStateInformation,
		IComparable,
		IComparable<VirtualView>,
		IUniqueID,
		IOrderPosition
	{
		public VirtualView(Project project)
		{
			_project = project;
		}

		private readonly Project _project;

		private string _name;
		private Guid _projectFolderUniqueID;
		private int _orderPosition;
		private Guid _uniqueID;

		public Guid UniqueID
		{
			get
			{
				return _uniqueID;
			}
		}

		public Project Project
		{
			get
			{
				return _project;
			}
		}

		public ProjectFolder ProjectFolder
		{
			get
			{
				return _project.GetProjectFolderByUniqueID(_projectFolderUniqueID);
			}
			set {
				_projectFolderUniqueID = value == null ? Guid.Empty : value.UniqueID;
			}
		}

		internal void StoreToXml(
			Project project,
			XmlElement parentNode)
		{
			if (parentNode.OwnerDocument != null)
			{
				var a = parentNode.OwnerDocument.CreateAttribute(@"name");
				a.Value = Name;
				parentNode.Attributes.Append(a);

				a = parentNode.OwnerDocument.CreateAttribute(@"projectFolderUniqueID");
				a.Value = _projectFolderUniqueID.ToString();
				parentNode.Attributes.Append(a);

				a = parentNode.OwnerDocument.CreateAttribute(@"orderPosition");
				a.Value = OrderPosition.ToString();
				parentNode.Attributes.Append(a);

				a = parentNode.OwnerDocument.CreateAttribute(@"viewMode");
				a.Value = Mode.ToString();
				parentNode.Attributes.Append(a);

				var remarksNode =
					parentNode.OwnerDocument.CreateElement(@"remarks");
				parentNode.AppendChild(remarksNode);
				remarksNode.InnerText = Remarks;

				if (parentNode.OwnerDocument != null)
				{
					a = parentNode.OwnerDocument.CreateAttribute(@"uniqueID");
					a.Value = _uniqueID.ToString();
					parentNode.Attributes.Append(a);
				}
			}
		}

		internal void LoadFromXml(
			Project project,
			XmlNode parentNode)
		{
			if (parentNode.Attributes != null)
			{XmlHelper.ReadAttribute(
					out _uniqueID,
					parentNode.Attributes[@"uniqueID"]);}

			if (_uniqueID == Guid.Empty)
			{
				_uniqueID = Guid.NewGuid();
			}

			// --

			if (parentNode.Attributes != null)
			{XmlHelper.ReadAttribute(
					out _projectFolderUniqueID,
					parentNode.Attributes[@"projectFolderUniqueID"]);}

			string viewMode=null;
			if (parentNode.Attributes != null)
			{XmlHelper.ReadAttribute(
					out viewMode,
					parentNode.Attributes[@"viewMode"]);}
			if (string.IsNullOrEmpty(viewMode))
			{
				Mode = ViewMode.Unknown;
			}
			else
			{
				Mode = (ViewMode) Enum.Parse(typeof (ViewMode), viewMode, true);
			}

			if (parentNode.Attributes != null)
			{
				XmlHelper.ReadAttribute(
					out _name,
					parentNode.Attributes[@"name"]);

				XmlHelper.ReadAttribute(
					out _orderPosition,
					parentNode.Attributes[@"orderPosition"]);
			}

			var remarksNode = parentNode.SelectSingleNode(@"remarks");
			Remarks = remarksNode != null ? remarksNode.InnerText : null;
		}

		public Guid ProjectFolderUniqueID
		{
			get
			{
				return _projectFolderUniqueID;
			}
		}

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

		public string Remarks { get; set; }

		public ViewMode Mode { get; set; }

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public Pair<string, string>[] GetLanguageCodesExtended(Project project)
		{
			var result = new Set<Pair<string, string>>();

			var fileGroups =
				ProjectFolder == null
					? Project.GetRootFileGroups()
					: ProjectFolder.ChildFileGroups;

			foreach (var fg in fileGroups)
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

		public int CompareTo(VirtualView other)
		{
			var a = _orderPosition.CompareTo(other._orderPosition);

			if (a == 0)
			{
				return Name.CompareTo(other.Name);
			}
			else
			{
				return a;
			}
		}

		public int CompareTo(object obj)
		{
			return CompareTo((VirtualView)obj);
		}

		public FileGroupStateColor TranslationStateColor
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}