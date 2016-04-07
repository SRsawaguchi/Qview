using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Qview.Naoya.Imaging
{
    public class RectMatrix : IEnumerable
    {
        private Rectangle[,] _Matrix;
        private Size _ElementRectSize;
        private int _RowLength;
        private int _ColLength;


        public Rectangle this[int r, int c]
        {
            get
            {
                return _Matrix[r, c];
            }
            set
            {
                if ( _ElementRectSize.Equals(value.Size) == false) {
                    throw new SizeNotEqualException("あらかじめ指定された画像サイズと等しくありません。");
                }
                _Matrix[r, c] = value;
            }
        }

        public Size ElementRectSize
        {
            get
            {
                return _ElementRectSize;
            }
        }

        public int RowLength
        {
            get
            {
                return _RowLength;
            }
        }

        public int ColLength
        {
            get
            {
                return _ColLength;
            }
        }

        public Size ConbineSize
        {
            get
            {
                return new Size(_ElementRectSize.Width * _ColLength,
                                    _ElementRectSize.Height * _RowLength);
            }
        }

        public RectMatrix (int rowLength, int colLength,Size elemBitmapSize)
        {
            _Matrix = new Rectangle[rowLength,colLength];
            _RowLength = rowLength;
            _ColLength = colLength;
            _ElementRectSize = elemBitmapSize;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
        {
            return _Matrix.GetEnumerator();
        }
    }
}
