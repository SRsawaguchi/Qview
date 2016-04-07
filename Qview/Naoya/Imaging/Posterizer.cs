using System;
using System.Drawing;

namespace Qview.Naoya.Imaging
{
    class Posterizer : IIMGProcessor
    {
        private int _ColorCount;
        private int _Level;
        private int _Step;
        private int[] _Values;
        private double _numerator;

        public int ColorCount
        {
            get
            {
                return _ColorCount;
            }
        }

        public int Level
        {
            get
            {
                return _Level;
            }
        }

        public int Step
        {
            get
            {
                return _Step;
            }
        }

        public int[] Values
        {
            get
            {
                return _Values;
            }
        }

        public static int[] MakePostalValue(int step,int level){
            var vals = new int[level];

            for(int i = 0;i < vals.Length;i++){
                vals[i] = i * step;
            }

            return vals;
        }

        public static int GetStep (int level, int colCnt)
        {
            return ( colCnt - 1 ) / ( level - 1 );
        }

        public Posterizer (int level)
        {
            _ColorCount = 256;
            _Level = level;
            _Step = GetStep(level, _ColorCount);
            _Values = MakePostalValue(_Step,level);
            _numerator = (double)_ColorCount / _Level;
        }

        public Posterizer (int level, int colCount)
        {
            _ColorCount = colCount;
            _Level = level;
            _Step = GetStep(level, colCount);
            _Values = MakePostalValue(_Step, level);
            _numerator = (double)_ColorCount / _Level;
        }

        public int GetPValue (int color)
        {
            var idx = (int)Math.Floor(color / _numerator);

            return _Values[idx];
        }

        public Func<System.Drawing.Bitmap, System.Drawing.Bitmap> GetFunction ()
        {
            return (Bitmap bmp) => {
                return IMGUtil.PixelMapping(bmp,
                    (PixelData pd) => {
                        var r = GetPValue(pd.Color.R);
                        var g = GetPValue(pd.Color.G);
                        var b = GetPValue(pd.Color.B);

                        return Color.FromArgb(r, g, b);
                    });
            };
        }
    }
}
