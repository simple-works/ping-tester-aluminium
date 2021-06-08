using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace PingTesterAluminium
{
    public static class ControlExtension
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public static void EnableMovingByMouseDrag(this Control control)
        {
            control.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    control.Cursor = Cursors.SizeAll;
                    ReleaseCapture();
                    SendMessage(GetForegroundWindow(), WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    control.Cursor = Cursors.Default;
                }
            };
        }

        public static void SetFont(this Control control, FontFamily fontFamily)
        {
            control.Font = new Font(fontFamily, control.Font.Size);
        }

        public static void SetFont(this Control control, Font font)
        {
            control.Font = new Font(font.FontFamily, control.Font.Size);
        }

        public static void CenterHorizontally(this Control control)
        {
            if (control.Parent != null)
            {
                control.Location = new Point((int)(0.5 * control.Parent.Width - 0.5 * control.Width), control.Location.Y);
            }
        }
    }
}
