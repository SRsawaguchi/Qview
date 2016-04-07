using Qview.Naoya.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Qview.Naoya.Imaging
{
    class IMGOp
    {
        public static Func<Bitmap,Bitmap> ToFunc(Func<Bitmap,Bitmap,Bitmap> op,Bitmap bmp,bool isSecond = false){
            if ( isSecond ) {
                return (Bitmap operand1) => { return op(operand1, bmp); };
            } else {
                return (Bitmap operand2) => { return op(bmp, operand2); };
            }
        }

        public static Func<Bitmap, Bitmap, Bitmap> Diff (int threshold, Color underColor, Color overColor)
        {
            return (Bitmap forground, Bitmap background) => {
                if ( IMGUtil.isSameSize(forground, background) == false ) {
                    throw new BitmapSizeNotEqualException();
                }

                var newBmp = new Bitmap(forground.Width, forground.Height);

                IMGUtil.TrvPixel(forground,
                    (PixelData pd) => {
                        var bgCol = background.GetPixel(pd.X, pd.Y);
                        var diff = NMath.SquareInt(pd.Color.R - bgCol.R) +
                                   NMath.SquareInt(pd.Color.G - bgCol.G) +
                                   NMath.SquareInt(pd.Color.B - bgCol.B);
                        var newCol = ( diff > threshold ) ? overColor : underColor;

                        newBmp.SetPixel(pd.X, pd.Y, newCol);
                    });

                return newBmp;
            };
        }

        public static Func<Bitmap, Bitmap, Bitmap> Diff (int threshold)
        {
            return Diff(threshold, Color.White, Color.Black);
        }

        public class BitmapSizeNotEqualException : Exception
        {
            public BitmapSizeNotEqualException()
                : base()
            {

            }

            public BitmapSizeNotEqualException (string msg)
                :base(msg)
            {

            }
        }
    }
}
