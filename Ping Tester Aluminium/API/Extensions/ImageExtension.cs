using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PingTesterAluminium
{
    public static class ImageExtension
    {
        public static Icon ToIcon(this Image image)
        {
            return Icon.FromHandle(((Bitmap)image).GetHicon());
        }
    }
}
