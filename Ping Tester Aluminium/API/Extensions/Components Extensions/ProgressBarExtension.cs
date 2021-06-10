using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PingTesterAluminium
{
    public static class ProgressBarExtension
    {
        public enum State
        {
            Normal = 1,
            Error = 2,
            Warning = 3
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        public static void SetState(this ProgressBar progressBar, State state)
        {
            SendMessage(progressBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }

        public static void SetValue(this ProgressBar progressBar, int value)
        {
            if (value < progressBar.Minimum) value = progressBar.Minimum;
            if (value > progressBar.Maximum) value = progressBar.Maximum;
            progressBar.Value = value;
        }
    }
}
