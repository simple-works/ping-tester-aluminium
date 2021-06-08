using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Text;

namespace PingTesterAluminium
{
    public static class ByteExtension
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public static FontFamily ToFontFamily(this byte[] resource)
        {
            int length = resource.Length;
            IntPtr data = Marshal.AllocCoTaskMem(length);
            Marshal.Copy(resource, 0, data, length);
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddMemoryFont(data, length);
            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)length, IntPtr.Zero, ref cFonts);
            Marshal.FreeCoTaskMem(data);
            return privateFonts.Families[privateFonts.Families.Length - 1];
        }
    }
}