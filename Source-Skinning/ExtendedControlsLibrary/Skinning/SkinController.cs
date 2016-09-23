namespace ExtendedControlsLibrary.Skinning
{
    using System.Collections.Generic;
    using System.Drawing;
    using DevExpress.Skins;

    public sealed class SkinController
    {
        private readonly Dictionary<Color, Brush> _brushs = new Dictionary<Color, Brush>();
        private readonly Dictionary<Color, Pen> _pens = new Dictionary<Color, Pen>();
        private readonly Skin _skin;

        public SkinController(Skin skin)
        {
            _skin = skin;
        }

        public Skin Skin => _skin;

        public Color TranslateColor(Color color)
        {
            return _skin.TranslateColor(color);
        }

        public Brush TranslateBrush(Color color)
        {
            // Cache to limit system resource handle wasting.

            if (_brushs.ContainsKey(color))
            {
                return _brushs[color];
            }
            else
            {
                var brush = new SolidBrush(TranslateColor(color));
                _brushs[color] = brush;

                return brush;
            }
        }

        public Pen TranslatePen(Color color)
        {
            // Cache to limit system resource handle wasting.

            if (_pens.ContainsKey(color))
            {
                return _pens[color];
            }
            else
            {
                var pen = new Pen(TranslateColor(color));
                _pens[color] = pen;

                return pen;
            }
        }

        public Brush GetUntranslatedBrush(Color color)
        {
            // Cache to limit system resource handle wasting.

            if (_brushs.ContainsKey(color))
            {
                return _brushs[color];
            }
            else
            {
                var brush = new SolidBrush(color);
                _brushs[color] = brush;

                return brush;
            }
        }

        public Pen GetUntranslatedPen(Color color)
        {
            // Cache to limit system resource handle wasting.

            if (_pens.ContainsKey(color))
            {
                return _pens[color];
            }
            else
            {
                var pen = new Pen(color);
                _pens[color] = pen;

                return pen;
            }
        }
    }
}