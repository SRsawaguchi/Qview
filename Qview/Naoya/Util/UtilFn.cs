using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qview.Naoya.Util
{
    class UtilFn
    {
        public static Func<T,T> Identity<T> ()
        {
            return (T value) => {
                return value;
            };
        }

        public static T Accumulate<T> (Func<T, T, T> Op, T initialValue, IEnumerable<T> items)
        {
            T acc = initialValue;

            foreach ( var val in items ) {
                acc = Op(acc, val);
            }

            return acc;
        }

        public static List<T> Filter<T> (Func<T, bool> Predicate, IEnumerable<T> items)
        {
            var result = new List<T>();

            foreach ( var val in items ) {
                if ( Predicate(val) ) {
                    result.Add(val);
                }
            }

            return result;
        }

        public Func<int, int, int> SumInt
        {
            get
            {
                return (int a, int b) => {
                    return a + b;
                };
            }
        }

        public Func<float, float, float> SumFloat
        {
            get
            {
                return (float a, float b) => {
                    return a + b;
                };
            }
        }

    }
}
