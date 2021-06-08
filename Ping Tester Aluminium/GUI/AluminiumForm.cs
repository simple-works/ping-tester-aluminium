using System;
using System.Windows.Forms;
using PingTesterAluminium.Properties;

namespace PingTesterAluminium
{
    public partial class Form_Template : Form
    {
        public Form_Template()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.panel_title.EnableMovingByMouseDrag();
            this.label_title.Text = this.Text;
            this.button_close.Click += (s, e) => this.Close();
            this.button_minimize.Click += (s, e) => this.WindowState = FormWindowState.Maximized;
            this.SetFont(Resources.visitor.ToFontFamily());
            this.EnableButtonsHoverEffects();
        }
    }
}
