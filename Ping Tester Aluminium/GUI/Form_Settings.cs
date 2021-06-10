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
    public partial class Form_Settings : AluminiumForm
    {
        public Form_Settings()
        {
            InitializeComponent();
            textBox_host.Text = PingTestManager.Host;
            textBox_interval.Text = PingTestManager.Interval.ToString();
            textBox_timeout.Text = PingTestManager.Timeout.ToString();
            textBox_buffer.Text = PingTestManager.BufferLength.ToString();
            textBox_ttl.Text = PingTestManager.Ttl.ToString();
            textBox_fragmentation.Text = PingTestManager.DontFragment ? "No" : "Yes";
        }

        public static DialogResult Show(IWin32Window owner = null)
        {
            return new Form_Settings().ShowDialog(owner);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                PingTestManager.Host = textBox_host.Text;
                PingTestManager.Interval = int.Parse(textBox_interval.Text);
                PingTestManager.Timeout = int.Parse(textBox_timeout.Text);
                PingTestManager.BufferLength = int.Parse(textBox_buffer.Text);
                PingTestManager.Ttl = int.Parse(textBox_ttl.Text);
                PingTestManager.DontFragment = textBox_fragmentation.Text == "No" ? true : false;
                Close();
            }
            catch (Exception exception)
            {
                Form_Error.Show(exception.Message);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
