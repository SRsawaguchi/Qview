using Qview.Naoya.Util;
using System;
using System.Drawing;
using System.Linq;

namespace Qview.Naoya.Imaging
{
    class IMGFilter
    {
        public static Func<Bitmap, Bitmap> MakeFilter3x3 (Func<Color[,], Color> Func)
        {
            return (Bitmap bmp) => {
                var area = new Rectangle(1, 1, bmp.Width - 2, bmp.Height - 2);

                return IMGUtil.PixelMapping(bmp, area,
                    (PixelData pd) => {
                        var area3x3 = new Rectangle(pd.X - 1, pd.Y -1, 3, 3);
                        var colMtx = new Color[3, 3];

                        IMGUtil.TrvPixel(bmp, area3x3,
                            (PixelData pd3x3) => {
                                colMtx[pd3x3.RelativeY, pd3x3.RelativeX] = pd3x3.Color;
                            });

                        return Func(colMtx);
                    });
            };
        }

        public static Func<Bitmap, Bitmap> MakeFilter3x3 (Func<ColorList, Color> Func)
        {
            return MakeFilter3x3(
                (Color[,] colors) => {
                    var cList = new ColorList(colors.Length);
                    foreach ( var c in colors ) {
                        cList.Add(c);
                    }
                    return Func(cList);
                });
        }

        public static Func<Bitmap, Bitmap> MakeFilter3x3 (float[,] mtx, Func<int, int> Func)
        {
            var trimFunc = IMGUtil.MakeTrimValueFunc(0, 255);

            return MakeFilter3x3(
                (Color[,] colors) => {
                    var nc = new NColor();

                    for ( int y = 0; y < 3; y++ ) {
                        for ( int x = 0; x < 3; x++ ) {
                            nc.R += (int)Math.Round(colors[y, x].R * mtx[y, x]);
                            nc.G += (int)Math.Round(colors[y, x].G * mtx[y, x]);
                            nc.B += (int)Math.Round(colors[y, x].B * mtx[y, x]);
                        }
                    }

                    nc.MapRGB(Func);
                    nc.TrimValue(0, 255);

                    return nc.ToColor();
                });
        }

        public static Func<Bitmap, Bitmap> MakeFilter3x3 (float[,] mtx)
        {
            return MakeFilter3x3(mtx, UtilFn.Identity<int>());
        }

        public static Func<Bitmap, Bitmap> SobelTT
        {
            get
            {
                return MakeFilter3x3(
                    new float[,]{
                    {-1,-2,-1},
                    {0,0,0},
                    {1,2,1}
                });
            }
        }

        public static Func<Bitmap, Bitmap> SobelTB
        {
            get
            {
                return MakeFilter3x3(
                    new float[,]{
                    {1,2,1},
                    {0,0,0},
                    {-1,-2,-1}
                });
            }
        }

        public static Func<Bitmap, Bitmap> SobelTL
        {
            get
            {
                return MakeFilter3x3(
                    new float[,] {
                    {-1,0,1},
                    {-2,0,2},
                    {-1,0,1},
                });
            }
        }

        public static Func<Bitmap, Bitmap> SobelTR
        {
            get
            {
                return MakeFilter3x3(
                    new float[,] {
                    {1,0,-1},
                    {2,0,-2},
                    {1,0,-1},
                });
            }
        }

        public static Func<Bitmap, Bitmap> SobelTRB
        {
            get
            {
                return MakeFilter3x3(
                    new float[,] {
                    {2,1,0},
                    {1,0,-1},
                    {0,-1,-2},
                });
            }
        }

        public static Func<Bitmap, Bitmap> SobelTLT
        {
            get
            {
                return MakeFilter3x3(
                    new float[,] {
                    {-2,-1,0},
                    {-1,0,1},
                    {0,1,2},
                });
            }
        }

        public static Func<Bitmap, Bitmap> SobelTLB
        {
            get
            {
                return MakeFilter3x3(
                    new float[,] {
                    {0,1,2},
                    {-1,0,1},
                    {-2,-1,0},
                });
            }
        }

        public static Func<Bitmap, Bitmap> SobelTRT
        {
            get
            {
                return MakeFilter3x3(
                    new float[,] {
                    {0,-1,-2},
                    {1,0,-1},
                    {2,1,0},
                });
            }
        }

        public static Func<Bitmap, Bitmap> Lap4
        {
            get
            {
                return MakeFilter3x3(
                    new float[,]{
                    {0,-1,0},
                    {-1,4,-1},
                    {0,-1,0},
                    });
            }
        }

        public static Func<Bitmap, Bitmap> Lap8
        {
            get
            {
                return MakeFilter3x3(
                    new float[,]{
                    {-1,-1,-1},
                    {-1,8,-1},
                    {-1,-1,-1}
                });
            }
        }

        public static Func<Bitmap, Bitmap> Gaussian
        {
            get
            {
                return MakeFilter3x3(
                    new float[,]{
                        {1,2,1},
                        {2,4,2},
                        {1,2,1}
                    },
                    (int n) => {
                        return n / 16;
                    });
            }
        }

        public static Func<Bitmap, Bitmap> Median
        {
            get
            {
                return MakeFilter3x3(
                    (ColorList cList) => {
                        var reds = cList.Reds;
                        var blues = cList.Blues;
                        var greens = cList.Greens;

                        Array.Sort(reds);
                        Array.Sort(blues);
                        Array.Sort(greens);

                        var r = reds[reds.Length / 2];
                        var g = greens[greens.Length / 2];
                        var b = blues[blues.Length / 2];

                        return Color.FromArgb(r, g, b);
                    });
            }
        }

        public static Func<Bitmap, Bitmap> Average
        {
            get
            {
                return MakeFilter3x3(
                    (ColorList cList) => {
                        var identity = UtilFn.Identity<int>();

                        var r = cList.Reds.Sum<int>(identity) / cList.Count;
                        var g = cList.Greens.Sum<int>(identity) /cList.Count;
                        var b = cList.Blues.Sum<int>(identity) / cList.Count;
                        
                        return Color.FromArgb(r,g,b);
                    });
            }
        }

        public static Func<Bitmap, Bitmap> Smooth (int weight = 1)
        {
            return MakeFilter3x3(
                new float[,]{
                    {1,1,1},
                    {1,weight,1},
                    {1,1,1},
                },
                (int a) => {
                    return a / (weight + 8);
                });
        }



    }
}
