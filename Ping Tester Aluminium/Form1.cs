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
    public partial class Form1 : AluminiumForm
    {
        public int Counter { get; set; }
        public List<ProgressBar> ProgressBars { get; set; }

        public Form1()
        {
            InitializeComponent();
            ProgressBars = new List<ProgressBar>();
            foreach (Control control in panel_time.Controls)
            {
                if (control is ProgressBar)
                {
                    ProgressBars.Add(control as ProgressBar);
                }
            }
            timer_main.Start();
        }

        public void IncrementCounter()
        {
            if (Counter < ProgressBars.Count - 1)
            {
                Counter++;
            }
            else
            {
                Counter = 0;
            }
        }

        public void UpdateProgressBar(ProgressBar progressBar,  PingResult response)
        {
            if (response.Time > progressBar.Maximum)
            {
                progressBar.Value = progressBar.Maximum;
            }
            else if (response.Time < progressBar.Minimum)
            {
                progressBar.Value = progressBar.Minimum;
            }
            else
            {
                progressBar.Value = (int)response.Time;
            }
            progressBar.ForeColor = response.Color;
        }

        public void UpdateProgressBar(PingResult response)
        {
            UpdateProgressBar(ProgressBars[Counter], response);
            IncrementCounter();
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            if (Settings.Default.Interval < 1000)
            {
                timer_main.Interval = 1000;
            }
            else
            {
                timer_main.Interval = Settings.Default.Interval;
            }

            if (timer_main.Interval != Settings.Default.Interval)
            {
                Settings.Default.Interval = timer_main.Interval;
                Settings.Default.Save();
            }

            if (!backgroundWorker_main.IsBusy)
            {
                backgroundWorker_main.RunWorkerAsync(Settings.Default.Host);
            }
        }

        private void backgroundWorker_main_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = PingTest.Ping(e.Argument as string);
        }

        private void backgroundWorker_main_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PingResult response = e.Result as PingResult;

            label_time.Text = response.Time > 0 ? response.Time.ToString() + " ms" : "Timeout";
            label_time.ForeColor = response.Color;

            UpdateProgressBar(response);

            label_rating.Text = response.Rating;
            label_rating.ForeColor = response.Color;

            label_host.Text = response.Host;

            if (response.Host != Settings.Default.Host)
            {
                Settings.Default.Host = response.Host;
                Settings.Default.Save();
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {

        }
    }
}
