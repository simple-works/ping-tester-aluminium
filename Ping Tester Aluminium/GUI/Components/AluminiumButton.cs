using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingTesterAluminium
{
    public partial class AluminiumButton : Button
    {
        public AluminiumButton()
        {
            InitializeComponent();
            this.BackColor = Color.Silver;
            this.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.Size = new System.Drawing.Size(100, 32);
            this.UseVisualStyleBackColor = false;
            this.EnableHoverEffects();
        }
    }
}
