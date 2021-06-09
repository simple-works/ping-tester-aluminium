using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using PingTesterAluminium.Properties;

namespace PingTesterAluminium
{
    public static class Constants
    {
        public static FontFamily VisitorFontFamily { get; private set; }

        static Constants()
        {
            Constants.VisitorFontFamily = Resources.visitor.ToFontFamily();
        }
    }
}
