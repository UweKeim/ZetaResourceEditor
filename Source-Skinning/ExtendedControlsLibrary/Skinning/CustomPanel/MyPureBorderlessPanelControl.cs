namespace ExtendedControlsLibrary.Skinning.CustomPanel;

using System.ComponentModel;

public class MyPureBorderlessPanelControl :
    Panel,
    ISupportInitialize
{
    public MyPureBorderlessPanelControl()
    {
        // Default-Wert.
        base.BackColor = SkinHelper.DialogBackgroundColor;
    }

    protected override Padding DefaultMargin => new(0, 0, 0, 0);

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