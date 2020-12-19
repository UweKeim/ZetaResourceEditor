namespace ExtendedControlsLibrary.General.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;
    using System.Xml;
    using DevExpress.LookAndFeel;
    using DevExpress.Utils;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraTab;
    using DevExpress.XtraTreeList;
    using Skinning.CustomForm;
    using Skinning.CustomTabControl;
    using UIUpdating;
    using Zeta.VoyagerLibrary.Common;
    using Zeta.VoyagerLibrary.Tools.Storage;

    /// <summary>
	/// Base class for devexpress forms.
	/// </summary>
	public class DevExpressXtraFormBase :
        MyXtraForm,
        IUpdateUI
    {
        ///// <summary>
        ///// Helper function for replacing regular tabs with a list box, like in
        ///// the new Microsoft Office option dialogs.
        ///// </summary>
        //protected void PutTabNavigationToListView(
        //    XtraTabControl tabControl,
        //    BaseImageListBoxControl listControl)
        //{
        //    tabControl.SelectedTabPageIndex = 0;
        //    tabControl.ShowTabHeader = DefaultBoolean.False;

        //    // 2011-04-12, Uwe Keim: No border around the group boxes.
        //    tabControl.BorderStyle = BorderStyles.NoBorder;
        //    tabControl.BorderStylePage = BorderStyles.NoBorder;
        //    tabControl.LookAndFeel.Style = LookAndFeelStyle.Flat;
        //    tabControl.LookAndFeel.UseDefaultLookAndFeel = false;

        //    listControl.Items.Clear();

        //    foreach (XtraTabPage tabPage in tabControl.TabPages)
        //    {
        //        var args = new WantPutTabPageToNavigationListViewEventArgs(tabPage);
        //        OnWantPutTabPageToNavigationListView(args);

        //        if (!args.Cancel)
        //        {
        //            listControl.Items.Add(new TabListItemInfo { TabPage = tabPage });
        //        }
        //    }

        //    listControl.SelectedIndexChanged +=
        //        delegate
        //        {
        //            RefreshTabNavigationFromSelection(tabControl, listControl);
        //        };

        //    ConnectTabControlInitializingEvents(tabControl);

        //    // --

        //    tabControl.TabStop = false;

        //    tabControl.KeyDown +=
        //        delegate(object sender, KeyEventArgs e)
        //        {
        //            // Forbid tabbing through.
        //            if (e.KeyCode == Keys.Tab && e.Control)
        //            {
        //                e.Handled = true;
        //            }
        //        };
        //}

        /// <summary>
        /// Persist only during runtime, not longer.
        /// </summary>
        protected static readonly PersistentInMemoryPairStorage InMemoryStorage =
            new PersistentInMemoryPairStorage();

        private readonly List<XtraTabPage> _shownTabPages = new List<XtraTabPage>();
        private UpdateUIController _uuiController;

        protected DevExpressXtraFormBase()
        {
            // Allow for capturing the F1 key.
            KeyPreview = true;
        }

        protected IGuiEnvironment GuiHost => InternalHost;

        public static IGuiEnvironment InternalHost { get; protected set; }

        protected virtual bool UseSharedIcon => true;

        protected UpdateUIController UuiController => _uuiController ?? (_uuiController = new UpdateUIController(this));

        public virtual void DoUpdateUI(
            UpdateUIInformation information)
        {
            // Does nothing.
        }

        public void PerformUpdateUI(object userState = null)
        {
            if (!DesignMode)
            {
                UuiController.PerformUpdateUI(this, userState);
            }
        }

        protected override void OnLoad(
            EventArgs e)
        {
            if (GuiHost != null)
            {
                //GuiHost.HideSplash();

                if (UseSharedIcon)
                {
                    // Share an icon to make the file size smaller.
                    Icon = GuiHost.GetIconForDialogs();
                    /*ShowIcon = true;*/
                }
            }

            // 2010-11-25, Uwe Keim. Experimentally.
            AutoScaleMode = AutoScaleMode.None;

            base.OnLoad(e);
        }

        protected override void OnKeyDown(
            KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (!e.Handled && e.KeyCode == Keys.F1 && !e.Alt && !e.Control && !e.Shift)
            {
                ExecuteHelp();
                e.Handled = true;
            }
        }

        protected override void OnShown(
            EventArgs e)
        {
            GuiHost?.HideSplash();

            base.OnShown(e);

            PerformUpdateUI();
        }

        public bool AllowF1Help { get; set; } = true;

        protected void ExecuteHelp()
        {
            if (AllowF1Help) GuiHost?.ExecuteHelp();
        }

        protected void ConnectTabControlInitializingEvents(
            XtraTabControl tabControl)
        {
            tabControl.SelectedPageChanging +=
                delegate (object sender, TabPageChangingEventArgs e)
                {
                    if (!_shownTabPages.Contains(e.Page))
                    {
                        _shownTabPages.Add(e.Page);

                        OnInitializeTabPage(
                            new InitializeTabPageEventArgs(e.Page));
                    }
                };
        }

        //private class TabListItemInfo
        //{
        //    public XtraTabPage TabPage { get; set; }
        //    public override string ToString()
        //    {
        //        return TabPage.Text.Replace(@"&&", @"&");
        //    }
        //}

        /// <summary>
        /// Fired before a tab page is shown for the very first time.
        /// </summary>
        [Description(@"Fired before a tab page is shown for the very first time.")]
        public event EventHandler<InitializeTabPageEventArgs> InitializeTabPage;

        protected void ConnectTabControlInitializingEvents(
            MyXtraTabControl tabControl)
        {
            tabControl.SelectedPageChanging +=
                delegate (object sender, TabPageChangingEventArgs e)
                {
                    if (!_shownTabPages.Contains(e.Page))
                    {
                        _shownTabPages.Add(e.Page);

                        OnInitializeTabPage(
                            new InitializeTabPageEventArgs(e.Page));
                    }
                };
        }

        /// <summary>
        /// Helper function for replacing regular tabs with a list box, like in
        /// the new Microsoft Office option dialogs.
        /// </summary>
        protected void PutTabNavigationToListView(
            MyXtraTabControl tabControl,
            ListBoxControl listControl)
        {
            tabControl.SelectedTabPageIndex = 0;
            tabControl.ShowTabHeader = DefaultBoolean.False;

            // 2011-04-12, Uwe Keim: No border around the group boxes.
            tabControl.BorderStyle = BorderStyles.NoBorder;
            tabControl.BorderStylePage = BorderStyles.NoBorder;
            tabControl.LookAndFeel.Style = LookAndFeelStyle.Flat;
            tabControl.LookAndFeel.UseDefaultLookAndFeel = false;

            listControl.Items.Clear();

            foreach (MyXtraTabPage tabPage in tabControl.TabPages)
            {
                var args = new WantPutTabPageToNavigationListViewEventArgs(tabPage);
                OnWantPutTabPageToNavigationListView(args);

                if (!args.Cancel)
                {
                    listControl.Items.Add(new TabListItemInfo { TabPage = tabPage });
                }
            }

            listControl.SelectedIndexChanged +=
                delegate
                {
                    RefreshTabNavigationFromSelection(tabControl, listControl);
                };

            ConnectTabControlInitializingEvents(tabControl);

            // --

            tabControl.TabStop = false;

            tabControl.KeyDown +=
                delegate (object sender, KeyEventArgs e)
                {
                    // Forbid tabbing through.
                    if (e.KeyCode == Keys.Tab && e.Control)
                    {
                        e.Handled = true;
                    }
                };
        }

        protected void RefreshTabNavigationFromSelection(
            MyXtraTabControl tabControl,
            ListBoxControl listControl)
        {
            if (listControl.SelectedItem == null)
            {
                tabControl.SelectedTabPageIndex = 0;
            }
            else
            {
                var info = (TabListItemInfo)listControl.SelectedItem;
                tabControl.SelectedTabPage = info.TabPage;
            }
        }

        private void OnWantPutTabPageToNavigationListView(
            WantPutTabPageToNavigationListViewEventArgs args)
        {
            var h = WantPutTabPageToNavigationListView;
            h?.Invoke(this, args);
        }

        /// <summary>
        /// Fired before a tab page is added to the list view. Use this event to omit
        /// certain pages from being visible in the list.
        /// </summary>
        [Description(@"Fired before a tab page is added to the list view. Use this event to omit certain pages from being visible in the list.")]
        public event EventHandler<WantPutTabPageToNavigationListViewEventArgs> WantPutTabPageToNavigationListView;

        private void OnInitializeTabPage(
            InitializeTabPageEventArgs args)
        {
            var h = InitializeTabPage;
            h?.Invoke(this, args);
        }

        //private void OnWantPutTabPageToNavigationListView(
        //    WantPutTabPageToNavigationListViewEventArgs args)
        //{
        //    var h = WantPutTabPageToNavigationListView;
        //    if (h != null)
        //    {
        //        h(this, args);
        //    }
        //}

        protected void MarkTabAsInitialized(XtraTabPage tabPage)
        {
            if (!WasTabInitialized(tabPage))
            {
                _shownTabPages.Add(tabPage);
            }
        }

        protected bool WasTabInitialized(XtraTabPage tabPage)
        {
            return _shownTabPages.Contains(tabPage);
        }

        protected void SaveTabPageSelector()
        {
            /*saveState(InMemoryStorage, listControl);*/
        }

        protected void RestoreTabPageSelector()
        {
            /*restoreState(InMemoryStorage, listControl);*/
        }

        public static void SaveState(
            SplitContainerControl c)
        {
            saveState(PersistanceHelper.Storage, c);
        }

        public static void RestoreState(
            SplitContainerControl c)
        {
            restoreState(PersistanceHelper.Storage, c);
        }

        private static void restoreState(
            IPersistentPairStorage storage,
            SplitContainerControl c)
        {
            var prefix = c.Name;

            var o1 = PersistanceHelper.RestoreValue(storage, prefix + @".SplitterPosition");
            var o2 = PersistanceHelper.RestoreValue(storage, prefix + @".RealSplitterPosition");
            //var o3 = PersistanceHelper.RestoreValue(storage, prefix + @".PercentageSplitterPosition");
            var o4 = PersistanceHelper.RestoreValue(storage, prefix + @".PanelVisibility");

            if (o4 != null)
            {
                var s4 =
                    ConvertHelper.ToString(
                        o4,
                        SplitPanelVisibility.Both.ToString());

                c.PanelVisibility =
                    (SplitPanelVisibility)
                    Enum.Parse(typeof(SplitPanelVisibility), s4, true);
            }

            /*if (o3 != null)
			{
				// New method, saving and restoring the percentage.
				// See http://bytes.com/forum/thread616388.html.

				var percentageDistance = ConvertHelper.ToDouble(o3, CultureInfo.InvariantCulture);

				if (c.Horizontal)
				{
					var realDistance = (int) (c.Width*(percentageDistance/100.0));
					if (realDistance > 0)
					{
						c.SplitterPosition = realDistance;
					}
				}
				else
				{
					var realDistance = (int) (c.Height*(percentageDistance/100.0));
					if (realDistance > 0)
					{
						c.SplitterPosition = realDistance;
					}
				}
			}
			else*/
            if (o1 != null && o2 != null)
            {
                var realDistance = Convert.ToInt32(o2);

                if (c.Horizontal)
                {
                    if (c.FixedPanel == SplitFixedPanel.Panel1 ||
                        c.FixedPanel == SplitFixedPanel.None)
                    {
                        if (realDistance > 0)
                        {
                            c.SplitterPosition = realDistance;
                        }
                    }
                    else
                    {
                        if (c.FixedPanel != SplitFixedPanel.Panel2)
                        {
                            throw new Exception(@"FixedPanel must be Panel2.");
                        }

                        if (c.Width - realDistance > 0)
                        {
                            c.SplitterPosition = c.Width - realDistance;
                        }
                    }
                }
                else
                {
                    if (c.FixedPanel == SplitFixedPanel.Panel1 ||
                        c.FixedPanel == SplitFixedPanel.None)
                    {
                        if (realDistance > 0)
                        {
                            c.SplitterPosition = realDistance;
                        }
                    }
                    else
                    {
                        if (c.FixedPanel != SplitFixedPanel.Panel2)
                        {
                            throw new Exception(@"You must set one panel inside a splitter to be fixed.");
                        }

                        if (c.Height - realDistance > 0)
                        {
                            c.SplitterPosition = c.Height - realDistance;
                        }
                    }
                }
            }
        }

        private static void saveState(
            IPersistentPairStorage storage,
            SplitContainerControl c)
        {
            int realDistance;
            double percentageDistance;

            if (c.Horizontal)
            {
                if (c.FixedPanel == SplitFixedPanel.Panel1 ||
                    c.FixedPanel == SplitFixedPanel.None)
                {
                    realDistance = c.SplitterPosition;
                }
                else
                {
                    if (c.FixedPanel != SplitFixedPanel.Panel2)
                    {
                        throw new Exception(@"FixedPanel must be Panel2.");
                    }

                    realDistance = c.Width - c.SplitterPosition;
                }

                percentageDistance = (double)c.SplitterPosition / c.Width * 100.0;
            }
            else
            {
                if (c.FixedPanel == SplitFixedPanel.Panel1 ||
                    c.FixedPanel == SplitFixedPanel.None)
                {
                    realDistance = c.SplitterPosition;
                }
                else
                {
                    if (c.FixedPanel != SplitFixedPanel.Panel2)
                    {
                        throw new Exception(@"FixedPanel must be Panel2.");
                    }

                    realDistance = c.Height - c.SplitterPosition;
                }

                percentageDistance = (double)c.SplitterPosition / c.Height * 100.0;
            }

            // --

            var prefix = c.Name;

            if (c.SplitterPosition > 0)
            {
                PersistanceHelper.SaveValue(storage, prefix + @".SplitterPosition", c.SplitterPosition);
            }
            if (realDistance > 0)
            {
                PersistanceHelper.SaveValue(storage, prefix + @".RealSplitterPosition", realDistance);
            }
            if (percentageDistance > 0)
            {
                PersistanceHelper.SaveValue(storage, prefix + @".PercentageSplitterPosition",
                                     percentageDistance.ToString(CultureInfo.InvariantCulture));
            }

            PersistanceHelper.SaveValue(
                storage,
                prefix + @".PanelVisibility",
                c.PanelVisibility.ToString());
        }

        protected static void SaveState(TreeList treeList)
        {
            saveState(PersistanceHelper.Storage, treeList);
        }

        public static void SaveState(GridView gridView)
        {
            saveState(PersistanceHelper.Storage, gridView);
        }

        protected static void RestoreState(TreeList treeList)
        {
            restoreState(PersistanceHelper.Storage, treeList);
        }

        public static void RestoreState(GridView gridView)
        {
            restoreState(PersistanceHelper.Storage, gridView);
        }

        protected static void SaveState(ComboBoxEdit c)
        {
            saveState(PersistanceHelper.Storage, c);
        }

        protected static void SaveState(CheckEdit c)
        {
            saveState(PersistanceHelper.Storage, c);
        }

        protected static void SaveState(TextEdit c)
        {
            saveState(PersistanceHelper.Storage, c);
        }

        protected static void RestoreState(ComboBoxEdit c)
        {
            restoreState(PersistanceHelper.Storage, c);
        }

        private static void restoreState(
            IPersistentPairStorage storage,
            ComboBoxEdit c)
        {
            var prefix = c.Name;

            var o = PersistanceHelper.RestoreValue(storage, prefix + @".SelectedIndex");
            if (o != null)
            {
                var index = ConvertHelper.ToInt32(o);

                if (index <= c.Properties.Items.Count - 1)
                {
                    c.SelectedIndex = index;
                }
            }

            if (c.Properties.TextEditStyle == TextEditStyles.Standard)
            {
                c.Text = PersistanceHelper.RestoreValue(storage, prefix + @".Text") as string;
            }
        }

        protected static void RestoreState(TextEdit c)
        {
            restoreState(PersistanceHelper.Storage, c);
        }

        private static void restoreState(
            IPersistentPairStorage storage,
            TextEdit c)
        {
            var prefix = c.Name;
            c.Text = PersistanceHelper.RestoreValue(storage, prefix + @".Text") as string;
        }

        protected static void RestoreState(CheckEdit c)
        {
            restoreState(PersistanceHelper.Storage, c);
        }

        private static void restoreState(
            IPersistentPairStorage storage,
            CheckEdit c)
        {
            var prefix = c.Name;

            var o = PersistanceHelper.RestoreValue(storage, prefix + @".Checked");
            if (o != null)
            {
                var index = ConvertHelper.ToBoolean(o);
                c.Checked = index;
            }
        }

        private static void saveState(
            IPersistentPairStorage storage,
            ComboBoxEdit c)
        {
            var prefix = c.Name;

            PersistanceHelper.SaveValue(
                storage,
                prefix + @".SelectedIndex",
                c.SelectedIndex);

            if (c.Properties.TextEditStyle == TextEditStyles.Standard)
            {
                PersistanceHelper.SaveValue(
                    storage,
                    prefix + @".Text",
                    c.Text);
            }
        }

        private static void saveState(
            IPersistentPairStorage storage,
            CheckEdit c)
        {
            var prefix = c.Name;

            PersistanceHelper.SaveValue(
                storage,
                prefix + @".Checked",
                c.Checked);
        }

        private static void saveState(
            IPersistentPairStorage storage,
            TextEdit c)
        {
            var prefix = c.Name;

            PersistanceHelper.SaveValue(
                storage,
                prefix + @".Text",
                c.Text);
        }

        private static void saveState(
            IPersistentPairStorage storage,
            TreeList c)
        {
            var prefix = c.Name;

            using var tfc = new ZetaTemporaryFileCreator();
            c.SaveLayoutToXml(
                tfc.FilePath,
                new OptionsLayoutTreeList
                {
                    AddNewColumns = false,
                    RemoveOldColumns = true,
                    StoreAppearance = false
                });

            PersistanceHelper.SaveValue(
                storage,
                prefix + @".TreeList",
                tfc.FileContentString);
        }

        private static void restoreState(
            IPersistentPairStorage storage,
            TreeList c)
        {
            var prefix = c.Name;

            var xml =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(storage, prefix + @".TreeList"));

            if (!string.IsNullOrEmpty(xml))
            {
                // Remove unwanted serialized elements.
                xml = removeNodes(
                    xml,
                    new[]
                        {
                            @"//property[@name='OptionsBehavior']",
                            @"//property[@name='OptionsMenu']",
                            @"//property[@name='OptionsSelection']",
                            @"//property[@name='OptionsView']"
                        });

                using var tfc = new ZetaTemporaryFileCreator(xml);
                c.RestoreLayoutFromXml(
                    tfc.FilePath,
                    new OptionsLayoutTreeList
                    {
                        AddNewColumns = false,
                        RemoveOldColumns = true,
                        StoreAppearance = false
                    });
            }
        }

        private static void saveState(
            IPersistentPairStorage storage,
            GridView c)
        {
            var prefix = c.Name;

            using var tfc = new ZetaTemporaryFileCreator();
            c.SaveLayoutToXml(
                tfc.FilePath,
                new OptionsLayoutGrid
                {
                    StoreAllOptions = false,
                    StoreDataSettings = true,
                    StoreVisualOptions = false,
                    StoreAppearance = false
                });

            PersistanceHelper.SaveValue(
                storage,
                prefix + @".GridView",
                tfc.FileContentString);
        }

        private static void restoreState(
            IPersistentPairStorage storage,
            GridView c)
        {
            var prefix = c.Name;

            var xml =
                ConvertHelper.ToString(
                    PersistanceHelper.RestoreValue(storage, prefix + @".GridView"));

            if (!string.IsNullOrEmpty(xml))
            {
                // Remove unwanted serialized elements.
                //xml = removeNodes(
                //    xml,
                //    new[]
                //        {
                //            @"//property[@name='OptionsBehavior']",
                //            @"//property[@name='OptionsCustomization']",
                //            @"//property[@name='OptionsDetail']",
                //            @"//property[@name='OptionsFilter']",
                //            @"//property[@name='OptionsHint']",
                //            @"//property[@name='OptionsLayout']",
                //            @"//property[@name='OptionsMenu']",
                //            @"//property[@name='OptionsNavigation']",
                //            @"//property[@name='OptionsPrint']",
                //            @"//property[@name='OptionsSelection']",
                //            @"//property[@name='OptionsView']",
                //        });

                using var tfc = new ZetaTemporaryFileCreator(xml);
                c.RestoreLayoutFromXml(
                    tfc.FilePath,
                    new OptionsLayoutGrid
                    {
                        StoreAllOptions = false,
                        StoreDataSettings = true,
                        StoreVisualOptions = false,
                        StoreAppearance = false
                    });
            }
        }

        private static string removeNodes(
            string xml,
            IEnumerable<string> xpaths)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            foreach (var xpath in xpaths)
            {
                if (!string.IsNullOrEmpty(xpath))
                {
                    var nodes = doc.SelectNodes(xpath);
                    if (nodes != null)
                    {
                        foreach (XmlNode xmlNode in nodes)
                        {
                            xmlNode.ParentNode?.RemoveChild(xmlNode);
                        }
                    }
                }
            }

            return doc.OuterXml;
        }

        protected void MakeBoldFont(Control control)
        {
            var font = control.Font;
            if (!font.Bold)
            {
                // TODO: does this waste system resource handles? Mabye store centrally and re-use.
                control.Font = new Font(font, FontStyle.Bold);
            }
        }

        public class InitializeTabPageEventArgs :
            EventArgs
        {
            public InitializeTabPageEventArgs(
                XtraTabPage page)
            {
                TabPage = page;
            }

            public XtraTabPage TabPage { get; private set; }
        }

        private class TabListItemInfo
        {
            public MyXtraTabPage TabPage { get; set; }
            public override string ToString()
            {
                return TabPage.Text;
            }
        }

        public class WantPutTabPageToNavigationListViewEventArgs :
            CancelEventArgs
        {
            public WantPutTabPageToNavigationListViewEventArgs(
                XtraTabPage page)
            {
                TabPage = page;
            }

            public XtraTabPage TabPage { get; private set; }
        }
    }
}