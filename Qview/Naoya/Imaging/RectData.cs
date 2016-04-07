using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Qview.Naoya.Imaging
{
    public class RectData
    {
        private int _RowCount;
        private int _ColCount;
        private int _Row;
        private int _Col;
        private Rectangle _Rect;
       

        public int RowCount
        {
            get
            {
                return _RowCount;
            }
        }

        public int ColCount
        {
            get
            {
                return _ColCount;
            }
        }

        public int Row
        {
            get
            {
                return _Row;
            }
        }

        public int Col
        {
            get
            {
                return _Col;
            }
        }

        public int X
        {
            get
            {
                return _Rect.X;
            }
        }

        public int Y
        {
            get
            {
                return _Rect.Y;
            }
        }

        public int Width
        {
            get
            {
                return _Rect.Width;
            }
        }

        public int Height
        {
            get
            {
                return _Rect.Height;
            }
        }

        public Size Size
        {
            get
            {
                return _Rect.Size;
            }
        }

        public Rectangle Rect
        {
            get
            {
                return _Rect;
            }
        }


        public RectData (int cCnt, int rCnt, int col, int row, int x, int y,int width,int height)
        {
            _RowCount = rCnt;
            _ColCount = cCnt;
            _Row = row;
            _Col = col;
            _Rect = new Rectangle(x, y, width, height);
        }

        public RectData (int cCnt, int rCnt, int col, int row, Rectangle rect)
        {
            _RowCount = rCnt;
            _ColCount = cCnt;
            _Row = row;
            _Col = col;
            _Rect = rect;
        }

        public RectData (RectMatrix mtx, int col, int row)
        {
            _RowCount = mtx.RowLength;
            _ColCount = mtx.ColLength;
            _Row = row;
            _Col = col;
            _Rect = mtx[row, col];
        }
    }
}
