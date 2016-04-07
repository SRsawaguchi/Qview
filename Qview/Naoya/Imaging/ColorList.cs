using System;
using System.Collections.Generic;
using System.Drawing;

namespace Qview.Naoya.Imaging
{
    class ColorList :IEnumerable<Color>
    {
        private List<Color> _Colors;

        public int Count
        {
            get
            {
               return _Colors.Count;
            }
        }

        public int[] Alphas
        {
            get
            {
                int[] arr = new int[_Colors.Count];
                for ( int i = 0; i < arr.Length; i++ ) {
                    arr[i] = _Colors[i].A;
                }

                return arr;
            }
        }

        public int[] Reds
        {
            get
            {
                int[] arr = new int[_Colors.Count];
                for ( int i = 0; i < arr.Length; i++ ) {
                    arr[i] = _Colors[i].R;
                }

                return arr;
            }
        }

        public int[] Greens
        {
            get
            {
                int[] arr = new int[_Colors.Count];
                for ( int i = 0; i < arr.Length; i++ ) {
                    arr[i] = _Colors[i].G;
                }

                return arr;
            }
        }

        public int[] Blues
        {
            get
            {
                int[] arr = new int[_Colors.Count];
                for ( int i = 0; i < arr.Length; i++ ) {
                    arr[i] = _Colors[i].B;
                }

                return arr;
            }
        }

        public ColorList (int capacity)
        {
            _Colors = new List<Color>(capacity);
        }

        public ColorList ()
        {
            _Colors = new List<Color>();
        }

        public void Add (Color c)
        {
            _Colors.Add(c);
        }

        public void Clear ()
        {
            _Colors.Clear();
        }

        public NColor Accumulate (Func<int, int> Func)
        {
            var result = new NColor();

            foreach ( var c in _Colors ) {
                result.A += Func(c.A);
                result.R += Func(c.R);
                result.G += Func(c.G);
                result.B += Func(c.B);
            }

            return result;
        }

        public IEnumerator<Color> GetEnumerator ()
        {
            return _Colors.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
        {
            return _Colors.GetEnumerator();
        }
    }
}
