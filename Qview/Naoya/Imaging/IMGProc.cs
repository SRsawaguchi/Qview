using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Qview.Naoya.Imaging
{
    class IMGProc
    {
        public static Func<Bitmap, Bitmap> MakeConverter (float[][] colorMtx)
        {
            return (Bitmap bmp) => {
                var canvas = new Bitmap(bmp.Width, bmp.Height);

                using ( Graphics g  = Graphics.FromImage(canvas) )
                using ( ImageAttributes ia = new ImageAttributes() ) {
                    ia.SetColorMatrix(new ColorMatrix(colorMtx));
                    g.DrawImage(bmp, new Rectangle(0, 0, canvas.Width, canvas.Height)
                     , 0f, 0f, canvas.Width, canvas.Height, GraphicsUnit.Pixel, ia);
                }

                return canvas;
            };
        }

        public static Func<Bitmap, Bitmap> MakeConverter (ImageAttributes ia)
        {
            return (Bitmap bmp) => {
                Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);

                using ( Graphics g = Graphics.FromImage(newBmp) ) {
                    g.DrawImage(bmp, new Rectangle(0, 0, newBmp.Width, newBmp.Height)
                        , 0f, 0f, newBmp.Width, newBmp.Height, GraphicsUnit.Pixel, ia);
                }
                return newBmp;
            };
        }

        public static Func<Bitmap, Bitmap> ToMono
        {
            get
            {
                return MakeConverter(
                    new float[][] {
                    new float[] {.298912f,.298912f,.298912f,0,0},
                    new float[] {.586611f,.586611f,.586611f,0,0},
                    new float[] {.114478f,.114478f,.114478f,0,0},
                    new float[] {0,0,0,1,0},
                    new float[] {0,0,0,0,1}
                });
                }
        }

        public static Func<Bitmap, Bitmap> ToNega
        {
            get
            {
                return MakeConverter(
                    new float[][] {
                    new float[] {-1,0,0,0,0},
                    new float[] {0,-1,0,0,0},
                    new float[] {0,0,-1,0,0},
                    new float[] {0,0,0,1,0},
                    new float[] {1,1,1,1,1}
                });
            }
        }

        public static Func<Bitmap, Bitmap> ToSepia
        {
            get
            {
                return MakeConverter(
                    new float[][] {
                    new float[] {0.393F, 0.349F, 0.272F, 0, 0},
                    new float[] {0.769F, 0.686F, 0.534F, 0, 0},
                    new float[] {0.189F, 0.168F, 0.131F, 0, 0},
                    new float[] {0,0,0,1,0},
                    new float[] {0,0,0,0,1}
                });
            }
        }

        public static Func<Bitmap, Bitmap> ToRedOnly
        {
            get
            {
                return MakeConverter(
                    new float[][] {
                    new float[] {1,0,0,0,0},
                    new float[] {0,0,0,0,0},
                    new float[] {0,0,0,0,0},
                    new float[] {0,0,0,1,0},
                    new float[] {0,0,0,0,1}
                });
            }
        }

        public static Func<Bitmap, Bitmap> ToGreenOnly
        {
            get
            {
                return MakeConverter(
                    new float[][] {
                    new float[] {0,0,0,0,0},
                    new float[] {0,1,0,0,0},
                    new float[] {0,0,0,0,0},
                    new float[] {0,0,0,1,0},
                    new float[] {0,0,0,0,1}
                });
            }
        }

        public static Func<Bitmap, Bitmap> ToBlueOnly
        {
            get
            {
                return MakeConverter(
                    new float[][] {
                    new float[] {0,0,0,0,0},
                    new float[] {0,0,0,0,0},
                    new float[] {0,0,1,0,0},
                    new float[] {0,0,0,1,0},
                    new float[] {0,0,0,0,1}
                });
            }
        }

        public static Func<Bitmap, Bitmap> ToBin (float threshold)
        {
            var ia = new ImageAttributes();
            ia.SetColorMatrix(
                new ColorMatrix(
                        new float[][] {
                        new float[] {.298912f,.298912f,.298912f,0,0},
                        new float[] {.586611f,.586611f,.586611f,0,0},
                        new float[] {.114478f,.114478f,.114478f,0,0},
                        new float[] {0,0,0,1,0},
                        new float[] {0,0,0,0,1}
                }));

            ia.SetThreshold(threshold);

            return MakeConverter(ia);
        }


    }
}
