using System;
using System.Windows.Forms;
using PingTesterAluminium.Properties;

namespace PingTesterAluminium
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.EnableMovingByMouseDrag();

            // Set Custom Font for Form
            this.SetFont(Resources.visitor.ToFontFamily());

            // Enable Hover Animation on Buttons
            this.EnableButtonsHoverEffects();

            // Set Custom Font for Buttons
            button_settings.SetFont(this.Font);
            button_about.SetFont(this.Font);
            button_pause.SetFont(this.Font);

            // Start Pinging Timer
            timerPing.Start();
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {
            // Set Timer Interval from Settings
            if (Settings.Default.Interval < 100) timerPing.Interval = 100;
            else timerPing.Interval = Settings.Default.Interval;

            // Save Timer Interval
            if (timerPing.Interval != Settings.Default.Interval)
            {
                Settings.Default.Interval = timerPing.Interval;
                Settings.Default.Save();
            }

            // Get Ping Response using Host from Settings
            if (!backgroundWorkerPing.IsBusy) backgroundWorkerPing.RunWorkerAsync();
        }

        private void backgroundWorkerPing_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            e.Result = PingTest.Ping(Settings.Default.Host);
        }

        private void backgroundWorkerPing_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            PingResult response = (PingResult)e.Result;

            // Display Time
            label_time.Text = response.Time > 0 ? response.Time.ToString() + " ms" : "Timeout";
            label_time.ForeColor = response.Color;
            label_time.CenterHorizontally();

            // Display Progression
            if (response.Time > progressBarTime.Maximum) progressBarTime.Value = progressBarTime.Maximum;
            else if (response.Time < progressBarTime.Minimum) progressBarTime.Value = progressBarTime.Minimum;
            else progressBarTime.Value = (int)response.Time;
            progressBarTime.ForeColor = response.Color;

            // Display Rating
            label_rating.Text = response.Rating;
            label_rating.ForeColor = response.Color;
            label_rating.CenterHorizontally();

            // Display Host
            label_host.Text = response.Host;
            label_host.CenterHorizontally();

            // Save Host
            if (response.Host != Settings.Default.Host)
            {
                Settings.Default.Host = response.Host;
                Settings.Default.Save();
            }
        }


        private void buttonSettings_Click(object sender, EventArgs e)
        {
            // Stop Timer
            bool timerStatus = timerPing.Enabled;
            TimerSwitch(false);

            // Create & Open Settings Form
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();

            // Restore Timer Status
            TimerSwitch(timerStatus);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // Stop Timer
            bool timerStatus = timerPing.Enabled;
            TimerSwitch(false);

            // Create & Open About Form
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();

            // Restore Timer Status
            TimerSwitch(timerStatus);
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            TimerSwitch();
        }

        public void TimerSwitch()
        {
            timerPing.Enabled = !timerPing.Enabled;
            button_pause.Image = timerPing.Enabled ? Resources.pause : Resources.play;
        }
        public void TimerSwitch(bool status)
        {
            timerPing.Enabled = status;
            button_pause.Image = timerPing.Enabled ? Resources.pause : Resources.play;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
