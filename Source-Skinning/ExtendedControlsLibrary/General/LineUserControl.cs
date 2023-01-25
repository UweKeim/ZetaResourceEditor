namespace ExtendedControlsLibrary.General;

using System.ComponentModel;
using System.Drawing;
using Skinning;

public class LineUserControl :
    Control
{
    public LineUserControl()
    {
        // http://stackoverflow.com/questions/818415/how-do-i-double-buffer-a-panel-in-c
        // http://stackoverflow.com/questions/2612487/how-to-fix-the-flickering-in-user-controls
        // http://stackoverflow.com/questions/9751373/drawing-an-image-onto-a-panel-control-gives-artefacts-when-resizing

        if (!DesignModeHelper.IsDesignMode)
        {
            base.DoubleBuffered = true;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            Enabled = true;
            Visible = true;
            TabStop = false;
        }
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Color BackColor
    {
        get => SkinHelper.LineColorBottom;
        // ReSharper disable ValueParameterNotUsed
        set => base.BackColor = SkinHelper.LineColorBottom;
        // ReSharper restore ValueParameterNotUsed
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Size MinimumSize
    {
        get => new(2, 2);
        set => base.MinimumSize = value;
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public override Size MaximumSize
    {
        get => new(16384, 2);
        set => base.MaximumSize = value;
    }

    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new bool TabStop
    {
        get => false;
        // ReSharper disable ValueParameterNotUsed
        set => base.TabStop = false;
        // ReSharper restore ValueParameterNotUsed
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        //if (DesignModeHelper.IsDesignMode)
        {
            base.OnPaintBackground(e);
        }

        clear(e.Graphics);
    }

    private void clear(Graphics g)
    {
        if (DesignModeHelper.IsDesignMode)
        {
            using var brush = new SolidBrush(BackColor);
            g.FillRectangle(
                brush,
                ClientRectangle);
        }
        else
        {
            g.FillRectangle(
                SkinHelper.GetCurrentSkin().GetUntranslatedBrush(BackColor),
                ClientRectangle);
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        clear(e.Graphics);

        if (DesignModeHelper.IsDesignMode)
        {
            using var pen = new Pen(SystemColors.ControlDark);
            e.Graphics.DrawLine(
                pen,
                ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Width, ClientRectangle.Top);
        }
        else
        {
            e.Graphics.DrawLine(
                //SkinHelper.GetCurrentSkin().GetUntranslatedPen(Color.Green),
                SkinHelper.GetCurrentSkin().GetUntranslatedPen(SkinHelper.LineColorTop),
                ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Right, ClientRectangle.Top);
        }
    }
}