using System;
using System.Drawing;

namespace Qview.Naoya.Imaging
{
    class NBitmap :IDisposable
    {
        private Bitmap _Bitmap;

        public Bitmap Bitmap
        {
            get
            {
                return _Bitmap;
            }
            set
            {
                _Bitmap = value;
            }
        }

        public NBitmap (Bitmap bmp)
        {
            _Bitmap = new Bitmap(bmp);
        }

        public Bitmap Effect (Func<Bitmap, Bitmap> Func)
        {
            var tmp = Func(_Bitmap);
            _Bitmap.Dispose();
            _Bitmap = tmp;

            return _Bitmap;
        }

        public Bitmap Effect (IIMGProcessor imgProcessor)
        {
            return Effect(imgProcessor.GetFunction());
        }

        public Bitmap Effect (Func<Bitmap, Bitmap>[] functions, bool fromEnd = false)
        {
            if ( fromEnd ) {
                for ( int i = functions.Length - 1; i >= 0; i-- ) {
                    Effect(functions[i]);
                }
            } else {
                for ( int i = 0; i < functions.Length; i++ ) {
                    Effect(functions[i]);
                }
            }

            return _Bitmap;
        }

        public void Dispose ()
        {
            _Bitmap.Dispose();
        }
    }
}
