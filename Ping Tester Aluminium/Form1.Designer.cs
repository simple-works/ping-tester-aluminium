namespace PingTesterAluminium
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_play = new PingTesterAluminium.AluminiumButton();
            this.label_host = new PingTesterAluminium.AluminiumLabel();
            this.label_buffer = new PingTesterAluminium.AluminiumLabel();
            this.label_time = new PingTesterAluminium.AluminiumLabel();
            this.label_status = new PingTesterAluminium.AluminiumLabel();
            this.label_ttl = new PingTesterAluminium.AluminiumLabel();
            this.label_rating = new PingTesterAluminium.AluminiumLabel();
            this.panel_time = new System.Windows.Forms.Panel();
            this.progressBar_time2 = new System.Windows.Forms.ProgressBar();
            this.progressBar_time4 = new System.Windows.Forms.ProgressBar();
            this.progressBar_time3 = new System.Windows.Forms.ProgressBar();
            this.progressBar_time1 = new System.Windows.Forms.ProgressBar();
            this.progressBar_time5 = new System.Windows.Forms.ProgressBar();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_main = new System.ComponentModel.BackgroundWorker();
            this.panel_main.SuspendLayout();
            this.panel_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_time);
            this.panel_main.Controls.Add(this.label_rating);
            this.panel_main.Controls.Add(this.label_ttl);
            this.panel_main.Controls.Add(this.label_status);
            this.panel_main.Controls.Add(this.label_time);
            this.panel_main.Controls.Add(this.label_buffer);
            this.panel_main.Controls.Add(this.label_host);
            this.panel_main.Controls.Add(this.button_play);
            this.panel_main.Size = new System.Drawing.Size(380, 424);
            // 
            // button_play
            // 
            this.button_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_play.BackgroundImage")));
            this.button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_play.Image = global::PingTesterAluminium.Properties.Resources.play;
            this.button_play.Location = new System.Drawing.Point(169, 379);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(40, 32);
            this.button_play.TabIndex = 7;
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // label_host
            // 
            this.label_host.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_host.AutoEllipsis = true;
            this.label_host.BackColor = System.Drawing.Color.Transparent;
            this.label_host.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_host.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_host.Location = new System.Drawing.Point(18, 42);
            this.label_host.Margin = new System.Windows.Forms.Padding(0);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(338, 32);
            this.label_host.TabIndex = 0;
            this.label_host.Text = "127.0.0.1";
            this.label_host.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_buffer
            // 
            this.label_buffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buffer.AutoEllipsis = true;
            this.label_buffer.BackColor = System.Drawing.Color.Transparent;
            this.label_buffer.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_buffer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_buffer.Location = new System.Drawing.Point(18, 185);
            this.label_buffer.Margin = new System.Windows.Forms.Padding(0);
            this.label_buffer.Name = "label_buffer";
            this.label_buffer.Size = new System.Drawing.Size(338, 32);
            this.label_buffer.TabIndex = 4;
            this.label_buffer.Text = "32 bytes";
            this.label_buffer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.AutoEllipsis = true;
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_time.Location = new System.Drawing.Point(18, 153);
            this.label_time.Margin = new System.Windows.Forms.Padding(0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(338, 32);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "0 ms";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status.AutoEllipsis = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_status.Location = new System.Drawing.Point(18, 121);
            this.label_status.Margin = new System.Windows.Forms.Padding(0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(338, 32);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Success";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_ttl
            // 
            this.label_ttl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ttl.AutoEllipsis = true;
            this.label_ttl.BackColor = System.Drawing.Color.Transparent;
            this.label_ttl.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_ttl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_ttl.Location = new System.Drawing.Point(18, 217);
            this.label_ttl.Margin = new System.Windows.Forms.Padding(0);
            this.label_ttl.Name = "label_ttl";
            this.label_ttl.Size = new System.Drawing.Size(338, 32);
            this.label_ttl.TabIndex = 5;
            this.label_ttl.Text = "118 TTL";
            this.label_ttl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_rating
            // 
            this.label_rating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rating.AutoEllipsis = true;
            this.label_rating.BackColor = System.Drawing.Color.Transparent;
            this.label_rating.Font = new System.Drawing.Font("Visitor TT1 BRK", 40F);
            this.label_rating.Location = new System.Drawing.Point(13, 75);
            this.label_rating.Margin = new System.Windows.Forms.Padding(0);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(343, 47);
            this.label_rating.TabIndex = 1;
            this.label_rating.Text = "Good";
            this.label_rating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_time
            // 
            this.panel_time.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.panel_time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_time.Controls.Add(this.progressBar_time2);
            this.panel_time.Controls.Add(this.progressBar_time4);
            this.panel_time.Controls.Add(this.progressBar_time3);
            this.panel_time.Controls.Add(this.progressBar_time1);
            this.panel_time.Controls.Add(this.progressBar_time5);
            this.panel_time.Location = new System.Drawing.Point(13, 263);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(353, 53);
            this.panel_time.TabIndex = 6;
            // 
            // progressBar_time2
            // 
            this.progressBar_time2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar_time2.Location = new System.Drawing.Point(78, 10);
            this.progressBar_time2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_time2.MarqueeAnimationSpeed = 0;
            this.progressBar_time2.Maximum = 300;
            this.progressBar_time2.Name = "progressBar_time2";
            this.progressBar_time2.Size = new System.Drawing.Size(60, 32);
            this.progressBar_time2.Step = 0;
            this.progressBar_time2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_time2.TabIndex = 1;
            this.progressBar_time2.Value = 300;
            // 
            // progressBar_time4
            // 
            this.progressBar_time4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar_time4.Location = new System.Drawing.Point(214, 10);
            this.progressBar_time4.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_time4.MarqueeAnimationSpeed = 0;
            this.progressBar_time4.Maximum = 300;
            this.progressBar_time4.Name = "progressBar_time4";
            this.progressBar_time4.Size = new System.Drawing.Size(60, 32);
            this.progressBar_time4.Step = 0;
            this.progressBar_time4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_time4.TabIndex = 3;
            this.progressBar_time4.Value = 300;
            // 
            // progressBar_time3
            // 
            this.progressBar_time3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar_time3.Location = new System.Drawing.Point(146, 10);
            this.progressBar_time3.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_time3.MarqueeAnimationSpeed = 0;
            this.progressBar_time3.Maximum = 300;
            this.progressBar_time3.Name = "progressBar_time3";
            this.progressBar_time3.Size = new System.Drawing.Size(60, 32);
            this.progressBar_time3.Step = 0;
            this.progressBar_time3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_time3.TabIndex = 2;
            this.progressBar_time3.Value = 300;
            // 
            // progressBar_time1
            // 
            this.progressBar_time1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar_time1.Location = new System.Drawing.Point(10, 10);
            this.progressBar_time1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_time1.MarqueeAnimationSpeed = 0;
            this.progressBar_time1.Maximum = 300;
            this.progressBar_time1.Name = "progressBar_time1";
            this.progressBar_time1.Size = new System.Drawing.Size(60, 32);
            this.progressBar_time1.Step = 0;
            this.progressBar_time1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_time1.TabIndex = 0;
            this.progressBar_time1.Value = 300;
            // 
            // progressBar_time5
            // 
            this.progressBar_time5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar_time5.Location = new System.Drawing.Point(282, 10);
            this.progressBar_time5.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_time5.MarqueeAnimationSpeed = 0;
            this.progressBar_time5.Maximum = 300;
            this.progressBar_time5.Name = "progressBar_time5";
            this.progressBar_time5.Size = new System.Drawing.Size(60, 32);
            this.progressBar_time5.Step = 0;
            this.progressBar_time5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_time5.TabIndex = 4;
            this.progressBar_time5.Value = 300;
            // 
            // timer_main
            // 
            this.timer_main.Interval = 1000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // backgroundWorker_main
            // 
            this.backgroundWorker_main.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_main_DoWork);
            this.backgroundWorker_main.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_main_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AboutButtonVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 424);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeButtonVisible = true;
            this.Name = "Form1";
            this.SettingsButtonVisible = true;
            this.Text = "Ping Tester";
            this.Title = "Ping Tester";
            this.TitleBarImage = global::PingTesterAluminium.Properties.Resources.icon;
            this.panel_main.ResumeLayout(false);
            this.panel_time.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AluminiumButton button_play;
        private AluminiumLabel label_host;
        private AluminiumLabel label_buffer;
        private AluminiumLabel label_ttl;
        private AluminiumLabel label_status;
        private AluminiumLabel label_time;
        private AluminiumLabel label_rating;
        private System.Windows.Forms.Panel panel_time;
        private System.Windows.Forms.ProgressBar progressBar_time2;
        private System.Windows.Forms.ProgressBar progressBar_time4;
        private System.Windows.Forms.ProgressBar progressBar_time3;
        private System.Windows.Forms.ProgressBar progressBar_time1;
        private System.Windows.Forms.ProgressBar progressBar_time5;
        public System.Windows.Forms.Timer timer_main;
        private System.ComponentModel.BackgroundWorker backgroundWorker_main;
    }
}