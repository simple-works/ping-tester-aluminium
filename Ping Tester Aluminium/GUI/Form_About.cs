using System;
using System.Windows.Forms;
using PingTesterAluminium.Properties;

namespace PingTesterAluminium
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            // Set Custom Font for Form
            this.SetFont(Resources.visitor.ToFontFamily());

            // Enable Hover Animation on Buttons
            this.EnableButtonsHoverEffects();

            // Set Copyright Infromations
            labelCopyright1.Text = Application.ProductName + " " + Application.ProductVersion;
            labelCopyright1.CenterHorizontally();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
