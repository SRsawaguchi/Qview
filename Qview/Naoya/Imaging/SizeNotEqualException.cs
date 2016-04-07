using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qview.Naoya.Imaging
{
    class SizeNotEqualException :Exception
    {

        public SizeNotEqualException (string msg)
            :base(msg)
        {

        }

        public SizeNotEqualException ()
            :base()
        {

        }
    }
}
