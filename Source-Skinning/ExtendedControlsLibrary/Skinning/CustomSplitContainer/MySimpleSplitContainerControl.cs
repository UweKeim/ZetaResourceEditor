namespace ExtendedControlsLibrary.Skinning.CustomSplitContainer
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class MySimpleSplitContainerControl :
        SplitContainer,
        ISupportInitialize
    {
        private bool _painting;
        public override bool Focused
        {
            get { return !_painting && base.Focused; }
        }

        void ISupportInitialize.BeginInit()
        {
            // Just implement the interface to satisfy designer.
        }

        void ISupportInitialize.EndInit()
        {
            // Just implement the interface to satisfy designer.
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            Font = SkinHelper.StandardFont;
            BackColor = SkinHelper.GetCurrentSkin().TranslateColor(SystemColors.Control);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // http://stackoverflow.com/a/9708247/107625
            _painting = true;
            try
            {
                base.OnPaint(e);
            }
            finally
            {
                _painting = false;
            }
        }
    }

    //public class MySimpleSplitContainerControl :
    //    SplitContainerControl,
    //    ISupportInitialize
    //{
    //    protected override void OnCreateControl()
    //    {
    //        base.OnCreateControl();

    //        Font = SkinHelper.StandardFont;
    //    }

    //    protected override SplitGroupPanel CreatePanel()
    //    {
    //        return new MySplitGroupPanel(this);
    //    }

    //    void ISupportInitialize.BeginInit()
    //    {
    //        // Just implement the interface to satisfy designer.
    //    }

    //    void ISupportInitialize.EndInit()
    //    {
    //        // Just implement the interface to satisfy designer.
    //    }

    //    //private bool _painting;
    //    //public override bool Focused
    //    //{
    //    //    get { return !_painting && base.Focused; }
    //    //}

    //    //protected override void OnPaint(PaintEventArgs e)
    //    //{
    //    //    // http://stackoverflow.com/a/9708247/107625
    //    //    _painting = true;
    //    //    try
    //    //    {
    //    //        base.OnPaint(e);
    //    //    }
    //    //    finally
    //    //    {
    //    //        _painting = false;
    //    //    }
    //    //}
    //}
}