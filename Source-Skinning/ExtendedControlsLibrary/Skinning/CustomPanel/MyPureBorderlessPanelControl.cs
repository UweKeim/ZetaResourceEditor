namespace ExtendedControlsLibrary.Skinning.CustomPanel;

using System.ComponentModel;
using System.Windows.Forms;

public class MyPureBorderlessPanelControl :
    Panel,
    ISupportInitialize
{
    public MyPureBorderlessPanelControl()
    {
        // Default-Wert.
        base.BackColor = SkinHelper.DialogBackgroundColor;
    }

    protected override Padding DefaultMargin => new Padding(0, 0, 0, 0);

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        BorderStyle = BorderStyle.None;
        Font = SkinHelper.StandardFont;
    }

    public void BeginInit()
    {
    }

    public void EndInit()
    {
    }
}