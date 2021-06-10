using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PingTesterAluminium
{
    public static class ButtonExtension
    {
        public static void EnableHoverEffects(this Button button)
        {
            Image backgroundImage = button.BackgroundImage;
            Color backColor = button.BackColor;

            button.MouseEnter += (s, e) =>
            {
                button.BackgroundImage = null;
                button.BackColor = Color.FromArgb(230, 230, 230);
            };

            button.MouseLeave += (s, e) =>
            {
                button.BackgroundImage = backgroundImage;
                button.BackColor = backColor;
            };
        }
    }
}
