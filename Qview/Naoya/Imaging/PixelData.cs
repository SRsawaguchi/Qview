using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Qview.Naoya.Imaging
{
    class PixelData
    {
        private int _X;
        private int _Y;
        private int _RelativeX;
        private int _RelativeY;
        private Color _Color;

        /* Properties */
        public int X
        {
            get
            {
                return _X;
            }
        }

        public int Y
        {
            get
            {
                return _Y;
            }
        }

        public int RelativeX
        {
            get
            {
                return _RelativeX;
            }
        }

        public int RelativeY
        {
            get
            {
                return _RelativeY;
            }
        }

        public Color Color
        {
            get
            {
                return _Color;
            }
        }

        public byte A
        {
            get
            {
                return _Color.A;
            }
        }

        public byte R
        {
            get
            {
                return _Color.R;
            }
        }

        public byte G
        {
            get
            {
                return _Color.G;
            }
        }

        public byte B
        {
            get
            {
                return _Color.B;
            }
        }

        /* Constructer */
        public PixelData (int x, int y, Color c)
        {
            _X = x;
            _Y = y;
            _RelativeX = x;
            _RelativeY = y;
            _Color = c;
        }

        public PixelData (int x, int y, int rX, int rY, Color c)
        {
            _X = x;
            _Y = y;
            _RelativeX = rX;
            _RelativeY = rY;
            _Color = c;
        }

        public override string ToString ()
        {
            return "{X = " + _X + ", Y = " + _Y + "} " + _Color.ToString();
        }
    }
}
