using System;
using System.Drawing;

namespace Qview.Naoya.Imaging
{
    class IMGUtil
    {
        public static bool isSameColor (Color c1, Color c2)
        {
            return c1.R == c2.R && c1.G == c2.G && c1.B == c2.B;
        }

        public static bool isSameSize (Bitmap bmp1, Bitmap bmp2)
        {
            return bmp1.Width == bmp2.Width && bmp1.Height == bmp2.Height;
        }

        public static bool isSameSize (Size a, Size b)
        {
            return a.Width == b.Width && a.Height == b.Height;
        }

        public static Bitmap Trimming (Bitmap bmp, Rectangle rect)
        {
            var canvas = new Bitmap(rect.Width, rect.Height);

            using ( Graphics g = Graphics.FromImage(canvas) ) {
                g.DrawImage(bmp, 0, 0, rect, GraphicsUnit.Pixel);
            }

            return canvas;
        }

        public static Func<Bitmap,Bitmap> TrimFunc (Rectangle rect)
        {
            return (Bitmap bmp) => {
                return Trimming(bmp, rect);
            };
        }

        public static Func<Bitmap, Bitmap> TrimFunc (Bitmap bmp)
        {
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            return TrimFunc(rect);
        }

        public static int CountPixel (Bitmap bmp, Func<Color, bool> isTarget)
        {
            int cnt = 0;

            for ( int x = 0; x < bmp.Width; x++ ) {
                for ( int y = 0; y < bmp.Height; y++ ) {
                    if ( isTarget(bmp.GetPixel(x, y)) ) {
                        cnt++;
                    }
                }
            }

            return cnt;
        }

        //Action<int x,int y,Color col>()
        public static void TrvPixel (Bitmap bmp, Action<PixelData> Proc)
        {
            for ( int y = 0; y < bmp.Height; y++ ) {
                for ( int x = 0; x < bmp.Width; x++ ) {
                    Proc(new PixelData(x, y, bmp.GetPixel(x, y)));
                }
            }
        }

        public static void TrvPixel (Bitmap bmp, Rectangle area, Action<PixelData> Proc)
        {

            for ( int y = 0; y < area.Height; y++ ) {
                var gy = y + area.Y;

                for ( int x = 0; x < area.Width; x++ ) {
                    var gx  = x + area.X;
                    var arg = new PixelData(gx, gy, x, y, bmp.GetPixel(gx, gy));
                    Proc(arg);
                }
            }
        }

        public static Bitmap PixelMapping (Bitmap bmp, Func<PixelData, Color> Func)
        {
            var newBmp = new Bitmap(bmp.Width, bmp.Height);

            TrvPixel(bmp,
                (PixelData pd) => {
                    var col = Func(pd);
                    newBmp.SetPixel(pd.X, pd.Y, col);
                });

            return newBmp;
        }

        public static Bitmap PixelMapping (Bitmap bmp, Rectangle area, Func<PixelData, Color> Func)
        {
            var newBmp = new Bitmap(area.Width, area.Height);

            TrvPixel(bmp, area,
                (PixelData pd) => {
                    var col = Func(pd);
                    newBmp.SetPixel(pd.RelativeX, pd.RelativeY, col);
                });

            return newBmp;
        }

        public static Bitmap PixelMapping (Bitmap bmp, Rectangle area, bool mappingOriginalBmp, Func<PixelData, Color> Func)
        {
            if ( mappingOriginalBmp == false ) {
                return PixelMapping(bmp, area, Func);
            }

            var newBmp = new Bitmap(bmp);

            TrvPixel(bmp, area,
                (PixelData pd) => {
                    var col = Func(pd);
                    newBmp.SetPixel(pd.X, pd.Y, col);
                });

            return newBmp;
            
        }

        public static RectMatrix CutRect (Size size, Size unitSize)
        {
            var rowCount = size.Height / unitSize.Height;
            var colCount = size.Width / unitSize.Width;
            var mtx = new RectMatrix(rowCount, colCount, unitSize);

            for ( int r = 0; r < rowCount; r++ ) {
                var y = r * unitSize.Height;

                for ( int c = 0; c < colCount; c++ ) {
                    var x = c * unitSize.Width;
                    var rect = new Rectangle(x, y, unitSize.Width, unitSize.Height);

                    mtx[r, c] = rect;
                }
            }
            return mtx;
        }

        public static RectMatrix CutRect (Bitmap bmp, Size unitSize)
        {
            return CutRect(bmp.Size, unitSize);
        }

        public static RectMatrix CutRect (Rectangle rect, Size unitSize)
        {
            return CutRect(rect.Size, unitSize);
        }

        public static void TrvRect (Rectangle rect, Size analyzeSize, Action<RectData> Proc)
        {
            var mtx = CutRect(rect, analyzeSize);

            for ( int r = 0; r < mtx.RowLength; r++ ) {
                for ( int c = 0; c <mtx.ColLength; c++ ) {
                    var data = new RectData(mtx, r, c);
                    Proc(data);
                }
            }

        }

        public static void TrvRect (Bitmap bmp, Size analyzeSize, Action<RectData> Proc)
        {
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            TrvRect(rect, analyzeSize, Proc);
        }

        public static void TrvArea (Bitmap bmp, Size analyzeSize, bool autoDispose, Action<AreaData> Proc)
        {
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            TrvRect(rect, analyzeSize,
                (RectData rd) => {
                    var data = new AreaData(rd, Trimming(bmp, rd.Rect));
                    Proc(data);
                    if(autoDispose){
                        data.Dispose();
                    }
                });
        }

        public static Bitmap PatternMapping (Bitmap bmp,Size patternSize, Size analyzeSize,Func<AreaData, Bitmap> Func)
        {
            var canvas = new Bitmap(( bmp.Width / analyzeSize.Width ) * patternSize.Width,
                                    ( bmp.Height / analyzeSize.Height ) * patternSize.Height);
            var mappingArea = CutRect(canvas,patternSize);

            using ( Graphics g = Graphics.FromImage(canvas) ) {
                IMGUtil.TrvArea(bmp, analyzeSize, true,
                    (AreaData ad) => {
                        var img = Func(ad);
                        var rect = mappingArea[ad.Row, ad.Col];

                        g.DrawImage(img, rect.X, rect.Y, rect.Width, rect.Height);
                    });
            }
            return canvas;
        }

        public static Color TrvRGB (Color c, Func<byte,byte> Proc)
        {
            var nr = Proc(c.R);
            var ng = Proc(c.G);
            var nb = Proc(c.B);

            return Color.FromArgb(nr, ng, nb);
        }

        public static Func<int, int> MakeTrimValueFunc (int min, int max)
        {
            return (int n) => {
                if ( n < min )
                    return min;
                if ( n > max )
                    return max;
                return n;
            };
        }

        public static int Range (int n, int min, int max)
        {
            var fn = MakeTrimValueFunc(min, max);
            return fn(n);
        }


    }
}
