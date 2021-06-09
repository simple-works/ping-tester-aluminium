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
    public partial class AluminiumLabel : Label
    {
        public AluminiumLabel()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoSize = false;
            this.AutoEllipsis = true;
            this.Size = new System.Drawing.Size(100, 32);
            this.AutoSizeChanged += (s, e) => this.AutoSize = false;
        }
    }
}
