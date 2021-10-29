namespace ExtendedControlsLibrary.General.TextMeasurement;

using System.Drawing;

public sealed class MeasureTextResult
{
    public Size Size { get; internal set; }
    public bool? IsCropped { get; internal set; }
}