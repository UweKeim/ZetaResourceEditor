namespace ExtendedControlsLibrary.Skinning.CustomForm
{
    using System;
    using System.ComponentModel;
    using System.Reflection;
    using System.Windows.Forms;
    using DevExpress.Utils.Menu;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;

    public class MyXtraForm :
        XtraForm
    {
        private BarManager _menuBarManager;
        public new bool DesignMode => base.DesignMode || DesignModeHelper.IsDesignMode;

        // Skin für Kontext-Menüs.
        // Wird in der Hauptanwendung zentral vom Main-Form gesetzt.
        // https://www.devexpress.com/Support/Center/Question/Details/B220846
        //public static IDXMenuManager GlobalSharedMenuManager { get; set; }

        public IDXMenuManager GetMenuBarManager()
        {
            if (_menuBarManager == null)
            {
                _menuBarManager = findManager();
                //var components = findComponent();
                //_menuBarManager = components == null ? new BarManager() : new BarManager(components);

                //_menuBarManager.BeginInit();
                //_menuBarManager.EndInit();
            }

            return _menuBarManager;
        }

        private BarManager findManager()
        {
            var t = GetType();

            // http://stackoverflow.com/a/520413/107625
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var pi in t.GetFields(BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                if (typeof(BarManager).IsAssignableFrom(pi.FieldType))
                {
                    return (BarManager)pi.GetValue(this);
                }
            }

            return null;
        }

        //private IContainer findComponent()
        //{
        //    var t = GetType();

        //    // http://stackoverflow.com/a/520413/107625
        //    // ReSharper disable once LoopCanBeConvertedToQuery
        //    foreach (var pi in t.GetFields(BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic))
        //    {
        //        if (typeof(IContainer).IsAssignableFrom(pi.FieldType))
        //        {
        //            return (IContainer)pi.GetValue(this);
        //        }
        //    }

        //    return null;
        //}

        public static IDXMenuManager CheckGetMenuBarManager(Control c)
        {
            if (c == null || c.IsDisposed) return null;

            var form = c.FindForm() as MyXtraForm;
            if (form == null || form.IsDisposed) return null;

            return form.GetMenuBarManager();

            //var t = form.GetType();

            //// http://stackoverflow.com/a/520413/107625
            //foreach (var pi in t.GetFields())
            //{
            //    if (typeof(IDXMenuManager).IsAssignableFrom(pi.FieldType))
            //    {
            //        return (IDXMenuManager)pi.GetValue(form);
            //    }
            //}
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public new AutoScaleMode AutoScaleMode
        {
            get { return AutoScaleMode.None; }
            // ReSharper disable ValueParameterNotUsed
            set { base.AutoScaleMode = AutoScaleMode.None; }
            // ReSharper restore ValueParameterNotUsed
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Do this even in design mode to have valid UI.
            AutoScaleMode = AutoScaleMode.None;
            Appearance.Font = SkinHelper.StandardFont;
        }

        public event EventHandler<WantProcessDialogKeyEventArgs> WantProcessDialogKey;

        protected override bool ProcessDialogKey(Keys keyData)
        {
            var h = WantProcessDialogKey;
            if (h != null)
            {
                var args = new WantProcessDialogKeyEventArgs(keyData);
                h(this, args);

                if (args.Result.HasValue)
                {
                    return args.Result.Value;
                }
            }

            // --

            //if ( keyData == (Keys.Control | Keys.Enter) )
            //{
            //    if (checkDoPressOKButton())
            //    {
            //        return true;
            //    }
            //}

            // --

            return base.ProcessDialogKey(keyData);
        }

        /*
                private bool checkDoPressOKButton()
                {
                    foreach (Control control in Controls)
                    {
                        if (coreCheckDoPressOKButton(control))
                        {
                            return true;
                        }
                    }

                    return false;
                }
        */

        /*
                private static bool coreCheckDoPressOKButton(Control control)
                {
                    var button = control as SimpleButton;
                    if (button != null)
                    {
                        if (button.Enabled &&
                            button.Visible &&
                            button.DialogResult == DialogResult.OK)
                        {
                            button.PerformClick();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        foreach (Control c in control.Controls)
                        {
                            if ( coreCheckDoPressOKButton(c))
                            {
                                return true;
                            }
                        }

                        return false;
                    }
                }
        */

        protected virtual void InitiallyFillLists()
        {
            // Does nothing.
        }

        protected virtual void FillItemToControls()
        {
            // Does nothing.
        }

        protected virtual void FillControlsToItem()
        {
            // Does nothing.
        }

        protected static int FindListControlIndex(
            ComboBoxEdit listControl,
            Predicate<object> finder)
        {
            var index = 0;
            foreach (var o in listControl.Properties.Items)
            {
                if (finder(o))
                {
                    return index;
                }
                index++;
            }

            return -1;
        }
    }
}