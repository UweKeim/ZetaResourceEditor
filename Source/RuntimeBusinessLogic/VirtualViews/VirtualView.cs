namespace ZetaResourceEditor.RuntimeBusinessLogic.VirtualViews
{
    using DL;
    using FileGroups;
    using ProjectFolders;
    using Projects;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Common.Collections;
    using ZetaAsync;

    public class VirtualView :
        ITranslationStateInformation,
        IComparable,
        IComparable<VirtualView>,
        IUniqueID,
        IOrderPosition
    {
        public VirtualView(Project project)
        {
            Project = project;
        }

        private string _name;
        private Guid _projectFolderUniqueID;
        private int _orderPosition;
        private Guid _uniqueID;

        public Guid UniqueID => _uniqueID;

        public Project Project { get; }

        public ProjectFolder ProjectFolder
        {
            get => Project.GetProjectFolderByUniqueID(_projectFolderUniqueID);
            set => _projectFolderUniqueID = value?.UniqueID ?? Guid.Empty;
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
            {
                XmlHelper.ReadAttribute(
                       out _uniqueID,
                       parentNode.Attributes[@"uniqueID"]);
            }

            if (_uniqueID == Guid.Empty)
            {
                _uniqueID = Guid.NewGuid();
            }

            // --

            if (parentNode.Attributes != null)
            {
                XmlHelper.ReadAttribute(
                       out _projectFolderUniqueID,
                       parentNode.Attributes[@"projectFolderUniqueID"]);
            }

            string viewMode = null;
            if (parentNode.Attributes != null)
            {
                XmlHelper.ReadAttribute(
                       out viewMode,
                       parentNode.Attributes[@"viewMode"]);
            }
            if (string.IsNullOrEmpty(viewMode))
            {
                Mode = ViewMode.Unknown;
            }
            else
            {
                Mode = (ViewMode)Enum.Parse(typeof(ViewMode), viewMode, true);
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
            Remarks = remarksNode?.InnerText;
        }

        public Guid ProjectFolderUniqueID => _projectFolderUniqueID;

        public void StoreOrderPosition(
            object threadPoolManager,
            object postExecuteCallback,
            AsynchronousMode asynchronousMode,
            object userState)
        {
            Project.MarkAsModified();
        }

        public int OrderPosition
        {
            get => _orderPosition;
            set => _orderPosition = value;
        }

        public string Remarks { get; set; }

        public ViewMode Mode { get; set; }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public MyTuple<string, string>[] GetLanguageCodesExtended(Project project)
        {
            var result = new HashSet<MyTuple<string, string>>();

            var fileGroups =
                ProjectFolder == null
                    ? Project.GetRootFileGroups()
                    : ProjectFolder.ChildFileGroups;

            foreach (var fg in fileGroups)
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

        public int CompareTo(VirtualView other)
        {
            var a = _orderPosition.CompareTo(other._orderPosition);

            return a == 0 ? string.Compare(Name, other.Name, StringComparison.Ordinal) : a;
        }

        public int CompareTo(object obj)
        {
            return CompareTo((VirtualView)obj);
        }

        public FileGroupStateColor TranslationStateColor => throw new NotImplementedException();
    }
}