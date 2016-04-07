using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Qview.Naoya.Imaging
{
    interface IIMGProcessor
    {
        Func<Bitmap, Bitmap> GetFunction ();
    }
}
