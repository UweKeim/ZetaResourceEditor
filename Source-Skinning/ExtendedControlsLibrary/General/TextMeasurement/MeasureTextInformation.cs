namespace ExtendedControlsLibrary.General.TextMeasurement;

using System.Drawing;

public sealed class MeasureTextInformation
{
    public string Text { get; set; }
    public Font Font { get; set; }

#if MEASURETEXT_USE_TEXTRENDERER

        public IDeviceContext DC { get; set; }
        public Size? ProposedSize { get; set; }
        public TextFormatFlags? Flags { get; set; }

#elif MEASURETEXT_USE_DEVEXPRESS

    public Control Control { get; set; }
    public Graphics Graphics { get; set; }
    public StringFormat Format { get; set; }
    public int? MaxWidth { get; set; }
    public int? MaxHeight { get; set; }

#endif
}