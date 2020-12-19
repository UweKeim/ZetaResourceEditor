namespace ExtendedControlsLibrary.General.TextMeasurement
{
    using System;
    using System.Drawing;
    using DevExpress.Utils.Drawing;

    /// <summary>
    /// Da es unterschiedliche Methoden gibt, Text-Dimensionen zu messen,
    /// die sich auch immer mal ändern, wenn mir wieder was falsches auffällt,
    /// hier die zentrale Stelle zum Messen.
    /// </summary>
    public static class TextMeasuringController
    {
        public static MeasureTextResult MeasureText(MeasureTextInformation information)
        {
            var result = new MeasureTextResult();

#if MEASURETEXT_USE_TEXTRENDERER
            doMeasureText(information, result);
#elif MEASURETEXT_USE_DEVEXPRESS
            doMeasureText(information, result);
#endif

            return result;
        }

#if MEASURETEXT_USE_TEXTRENDERER

                private static void doMeasureText(MeasureTextInformation information, MeasureTextResult result)
        {
            if (string.IsNullOrEmpty(information.Text))
            {
                result.Size = new Size();
            }
            else if (information.Font == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                // Hier alle Overloads bedienen.

                if (information.DC == null && information.ProposedSize == null && information.Flags == null)
                {
                    result.Size = TextRenderer.MeasureText(information.Text, information.Font);
                }
                else if (information.DC != null && information.ProposedSize == null && information.Flags == null)
                {
                    result.Size = TextRenderer.MeasureText(information.DC, information.Text, information.Font);
                }
                else if (information.DC == null && information.ProposedSize != null && information.Flags == null)
                {
                    result.Size = TextRenderer.MeasureText(information.Text, information.Font, information.ProposedSize.Value);
                }
                else if (information.DC != null && information.ProposedSize != null && information.Flags == null)
                {
                    result.Size = TextRenderer.MeasureText(information.DC, information.Text, information.Font, information.ProposedSize.Value);
                }
                else if (information.DC == null && information.ProposedSize != null && information.Flags != null)
                {
                    result.Size = TextRenderer.MeasureText(information.Text, information.Font, information.ProposedSize.Value, information.Flags.Value);
                }
                else if (information.DC != null && information.ProposedSize != null && information.Flags != null)
                {
                    result.Size = TextRenderer.MeasureText(information.DC, information.Text, information.Font, information.ProposedSize.Value, information.Flags.Value);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

#elif MEASURETEXT_USE_DEVEXPRESS

        private static void doMeasureText(MeasureTextInformation information, MeasureTextResult result)
        {
            if (string.IsNullOrEmpty(information.Text))
            {
                result.Size = new Size();
            }
            else if (information.Font == null)
            {
                throw new ArgumentNullException();
            }
            else if (information.MaxWidth == null)
            {
                throw new ArgumentNullException();
            }
            else if (information.Control == null && information.Graphics == null)
            {
                throw new ArgumentNullException();
            }
            else if (information.Control != null && !information.Control.IsHandleCreated)
            {
                throw new Exception("No control handle (yet).");
            }
            else
            {
                var graphics = information.Graphics ?? information.Control.CreateGraphics();
                try
                {
                    var gc = new GraphicsCache(graphics);

                    if (information.MaxHeight == null)
                    {
                        result.Size =
                            Size.Round(gc.CalcTextSize(information.Text, information.Font,
                                information.Format ?? new StringFormat(),
                                information.MaxWidth.Value));
                    }
                    else if (information.MaxHeight != null)
                    {
                        result.Size =
                            Size.Round(gc.CalcTextSize(information.Text, information.Font,
                                information.Format ?? new StringFormat(),
                                information.MaxWidth.Value, information.MaxHeight.Value, out var isCropped));
                        result.IsCropped = isCropped;
                    }
                }
                finally
                {
                    if (information.Graphics == null)
                    {
                        graphics.Dispose();
                    }
                }
            }
        }

#endif
    }
}