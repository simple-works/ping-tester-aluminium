using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PingTesterAluminium.Properties;

namespace PingTesterAluminium
{
    public partial class Form_Main : AluminiumForm
    {
        public Form_Main()
        {
            InitializeComponent();
            Initialize();
            button_play.PerformClick();
        }

        public void Initialize()
        {
            label_host.Text = PingTestManager.Host;

            label_address.Text = "?";
            label_address.ForeColor = Color.Gray;

            label_rating.Text = "?";
            label_rating.ForeColor = Color.Gray;

            label_status.Text = "Inactive";
            label_status.ForeColor = Color.Gray;

            label_time.Text = "? ms";
            label_time.ForeColor = Color.Gray;

            progressBar_time.SetValue(progressBar_time.Maximum);
            progressBar_time.ForeColor = Color.Gray;

            label_outBuffer.Text = string.Format("{0} bytes", PingTestManager.BufferLength);

            label_inBuffer.Text = "? bytes";
            label_inBuffer.ForeColor = Color.Gray;

            label_outTtl.Text = string.Format("{0} TTL", PingTestManager.Ttl);

            label_inTtl.Text = "? TTL";
            label_inTtl.ForeColor = Color.Gray;

            label_notFragmented.Text = PingTestManager.DontFragment ? "Not Fragmented" : "Fragmented";
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            timer_main.Interval = PingTestManager.Interval;
            if (!backgroundWorker_main.IsBusy)
            {
                backgroundWorker_main.RunWorkerAsync();
            }
        }

        private void backgroundWorker_main_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = PingTestManager.RunPingTest();
        }

        private void backgroundWorker_main_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PingResult result = e.Result as PingResult;
            if (result.HasError)
            {
                Initialize();
                Form_Error.Show(result.ErrorMessage, this);
            }
            else
            {
                label_address.Text = result.Address.ToString();
                label_address.ForeColor = Color.Blue;

                label_rating.Text = result.Rating.ToString().ToTitleCase();
                label_rating.ForeColor = result.RatingColor;

                label_status.Text = result.Status.ToString().ToTitleCase();
                label_status.ForeColor = result.StatusColor;

                label_time.Text = string.Format("{0} ms", result.Time.ToString());
                label_time.ForeColor = result.RatingColor;

                progressBar_time.SetValue((int)result.Time);
                progressBar_time.ForeColor = result.RatingColor;

                label_inBuffer.Text = string.Format("{0} bytes", result.Buffer.Length);
                label_inBuffer.ForeColor = Color.Blue;

                label_inTtl.Text = string.Format("{0} TTL", result.Ttl);
                label_inTtl.ForeColor = Color.Blue;
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (timer_main.Enabled)
            {
                timer_main.Stop();
                button_play.Image = Resources.play;
            }
            else
            {
                timer_main.Start();
                button_play.Image = Resources.pause;
            }
        }

        private void Form_Main_SettingsButtonClick(object sender, EventArgs e)
        {
            Form_Settings.Show(this);
        }

        private void Form_Main_AboutButtonClick(object sender, EventArgs e)
        {
            Form_About.Show(this);
        }

    }
}
