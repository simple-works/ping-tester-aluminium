using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace PingTesterAluminium
{
    public static class FormExtension
    {
        public static void EnableButtonsHoverEffects(this Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    Image backgroundImage = button.BackgroundImage;
                    
                    button.MouseEnter += (s, args) =>
                    {
                        button.BackgroundImage = null;
                    };
                    
                    button.MouseLeave += (s, args) =>
                    {
                        button.BackgroundImage = backgroundImage;
                    };
                }
            }
        }
    }
}
