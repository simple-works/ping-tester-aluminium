using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PingTesterAluminium
{
    public partial class Form_About : AluminiumForm
    {
        public Form_About()
        {
            InitializeComponent();
        }

        public static DialogResult Show(IWin32Window owner = null)
        {
            return new Form_About().ShowDialog(owner);
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
