using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Qview.Naoya.Imaging
{
    class AreaData :RectData , IDisposable
    {
        private Bitmap _Bitmap;

        public Bitmap Bitmap
        {
            get
            {
                return _Bitmap;
            }
        }

        public AreaData (int cCnt, int rCnt, int col, int row, int x, int y, Bitmap bmp)
            :base(cCnt,rCnt,col,row,x,y,bmp.Width,bmp.Height)
        {
            _Bitmap = bmp;
        }

        public AreaData (RectData rd, Bitmap bmp)
            :base(rd.ColCount,rd.RowCount,rd.Col,rd.Row,rd.X,rd.Y,bmp.Width,bmp.Height)
        {
            _Bitmap = bmp;
        }

        public void Dispose ()
        {
            _Bitmap.Dispose();
        }
    }
}
