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
    public partial class AluminiumTextBox : TextBox
    {
        public AluminiumTextBox()
        {
            InitializeComponent();
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.Size = new System.Drawing.Size(400, 32);
        }
    }
}
