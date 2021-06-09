using System;
using System.Windows.Forms;
using PingTesterAluminium.Properties;

namespace PingTesterAluminium
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            this.SetFont(Resources.visitor.ToFontFamily());
            this.EnableHoverEffectsForChildButtons();
            textBoxHost.Text = Settings.Default.Host;
            textBoxInterval.Text = Settings.Default.Interval.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string host = textBoxHost.Text.Trim();
            if (host == string.Empty)
            {
                MessageBox.Show("A host name or ip must be given.");
                return;
            }

            int interval = 0;
            if (!int.TryParse(textBoxInterval.Text, out interval))
            {
                MessageBox.Show("Interval must be a number.");
                return;
            }

            if (interval <= 100)
            {
                interval = 100;
            }

            Settings.Default.Host = host;
            Settings.Default.Interval = interval;
            Settings.Default.Save();
            ((FormMain)this.ParentForm).timerPing.Interval = interval;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxInterval_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
