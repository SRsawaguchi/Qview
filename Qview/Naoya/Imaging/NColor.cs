using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Qview.Naoya.Imaging
{
    class NColor
    {
        private int _A;
        private int _R;
        private int _G;
        private int _B;

        /* Properties */
        public int A
        {
            get
            {
                return _A;
            }

            set
            {
                _A = value;
            }
        }

        public int R
        {
            get
            {
                return _R;
            }

            set
            {
                _R = value;
            }
        }

        public int G
        {
            get
            {
                return _G;
            }

            set
            {
                _G = value;
            }
        }

        public int B
        {
            get
            {
                return _B;
            }

            set
            {
                _B = value;
            }
        }

        /* Constructor */
        public NColor ()
        {
            _A = 255;
            _R = 0;
            _G = 0;
            _B = 0;
        }

        public NColor (Color c)
        {
            _A = c.A;
            _R = c.R;
            _G = c.G;
            _B = c.B;
        }

        public NColor (int a,int r,int g,int b)
        {
            _A = a;
            _R = r;
            _G = g;
            _B = b;
        }

        public NColor (int r, int g, int b)
        {
            _A = 255;
            _R = r;
            _G = g;
            _B = b;
        }

        public void TrimValue (int min,int max)
        {
            _A = IMGUtil.Range(_A, min, max);
            _R = IMGUtil.Range(_R, min, max);
            _G = IMGUtil.Range(_G, min, max);
            _B = IMGUtil.Range(_B, min, max);
        }

        public void MapRGB (Func<int,int> Func)
        {
            _R = Func(_R);
            _G = Func(_G);
            _B = Func(_B);
        }

        public void MapARGB (Func<int, int> Func)
        {
            _A = Func(_A);
            MapRGB(Func);
        }

        /* Methods */
        public Color ToColor ()
        {
            return Color.FromArgb(_A, _R, _G, _B);
        }

        public override string ToString ()
        {
            return Color.FromArgb(_A, _R, _G, _B).ToString();
        }
    }
}
