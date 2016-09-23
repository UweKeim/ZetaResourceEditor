namespace ExtendedControlsLibrary.Skinning.CustomPanel
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
	/// A control to host other controls that have no border themself.
	/// </summary>
	public class MyThinBorderPanel :
        Panel,
        ISupportInitialize
    {
        protected override Padding DefaultMargin => new Padding(0, 0, 0, 0);

        protected override Padding DefaultPadding => new Padding(16, 16, 16, 16);

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackColor { get { return base.BackColor; } set { base.BackColor = value; } }

        //[Browsable(false)]
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public new Padding Padding { get { return base.Padding; } set { base.Padding = value; } }

        public void BeginInit()
        {
        }

        public void EndInit()
        {
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            Font = SkinHelper.StandardFont;
            BackColor = SkinHelper.ControlBorderColor;
            Padding = new Padding(1);
        }
    }
}