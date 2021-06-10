namespace PingTesterAluminium
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.button_play = new PingTesterAluminium.AluminiumButton();
            this.label_host = new PingTesterAluminium.AluminiumLabel();
            this.label_outBuffer = new PingTesterAluminium.AluminiumLabel();
            this.label_time = new PingTesterAluminium.AluminiumLabel();
            this.label_status = new PingTesterAluminium.AluminiumLabel();
            this.label_outTtl = new PingTesterAluminium.AluminiumLabel();
            this.label_rating = new PingTesterAluminium.AluminiumLabel();
            this.panel_graph = new System.Windows.Forms.Panel();
            this.progressBar_time = new System.Windows.Forms.ProgressBar();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_main = new System.ComponentModel.BackgroundWorker();
            this.label_notFragmented = new PingTesterAluminium.AluminiumLabel();
            this.label_inBuffer = new PingTesterAluminium.AluminiumLabel();
            this.label_inTtl = new PingTesterAluminium.AluminiumLabel();
            this.label_address = new PingTesterAluminium.AluminiumLabel();
            this.panel_outbound = new System.Windows.Forms.Panel();
            this.panel_inbound = new System.Windows.Forms.Panel();
            this.label_outbound = new PingTesterAluminium.AluminiumLabel();
            this.label_inbound = new PingTesterAluminium.AluminiumLabel();
            this.panel_main.SuspendLayout();
            this.panel_outbound.SuspendLayout();
            this.panel_inbound.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label_inbound);
            this.panel_main.Controls.Add(this.label_outbound);
            this.panel_main.Controls.Add(this.panel_inbound);
            this.panel_main.Controls.Add(this.panel_outbound);
            this.panel_main.Controls.Add(this.panel_graph);
            this.panel_main.Controls.Add(this.label_rating);
            this.panel_main.Controls.Add(this.progressBar_time);
            this.panel_main.Controls.Add(this.label_status);
            this.panel_main.Controls.Add(this.label_time);
            this.panel_main.Controls.Add(this.button_play);
            this.panel_main.Size = new System.Drawing.Size(735, 506);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_play.BackgroundImage")));
            this.button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_play.Image = global::PingTesterAluminium.Properties.Resources.play;
            this.button_play.Location = new System.Drawing.Point(668, 49);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(40, 32);
            this.button_play.TabIndex = 7;
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // label_host
            // 
            this.label_host.AutoEllipsis = true;
            this.label_host.BackColor = System.Drawing.Color.Transparent;
            this.label_host.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_host.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_host.Location = new System.Drawing.Point(27, 19);
            this.label_host.Margin = new System.Windows.Forms.Padding(0);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(285, 32);
            this.label_host.TabIndex = 0;
            this.label_host.Text = "localhost";
            this.label_host.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_outBuffer
            // 
            this.label_outBuffer.AutoEllipsis = true;
            this.label_outBuffer.BackColor = System.Drawing.Color.Transparent;
            this.label_outBuffer.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_outBuffer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_outBuffer.Location = new System.Drawing.Point(27, 61);
            this.label_outBuffer.Margin = new System.Windows.Forms.Padding(0);
            this.label_outBuffer.Name = "label_outBuffer";
            this.label_outBuffer.Size = new System.Drawing.Size(285, 32);
            this.label_outBuffer.TabIndex = 4;
            this.label_outBuffer.Text = "32 bytes";
            this.label_outBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_time
            // 
            this.label_time.AutoEllipsis = true;
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_time.Location = new System.Drawing.Point(19, 121);
            this.label_time.Margin = new System.Windows.Forms.Padding(0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(689, 32);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "10 ms";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_status
            // 
            this.label_status.AutoEllipsis = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_status.Location = new System.Drawing.Point(19, 89);
            this.label_status.Margin = new System.Windows.Forms.Padding(0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(689, 32);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Success";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_outTtl
            // 
            this.label_outTtl.AutoEllipsis = true;
            this.label_outTtl.BackColor = System.Drawing.Color.Transparent;
            this.label_outTtl.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_outTtl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_outTtl.Location = new System.Drawing.Point(27, 103);
            this.label_outTtl.Margin = new System.Windows.Forms.Padding(0);
            this.label_outTtl.Name = "label_outTtl";
            this.label_outTtl.Size = new System.Drawing.Size(285, 32);
            this.label_outTtl.TabIndex = 5;
            this.label_outTtl.Text = "128 TTL";
            this.label_outTtl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_rating
            // 
            this.label_rating.AutoEllipsis = true;
            this.label_rating.BackColor = System.Drawing.Color.Transparent;
            this.label_rating.Font = new System.Drawing.Font("Visitor TT1 BRK", 40F);
            this.label_rating.Location = new System.Drawing.Point(14, 42);
            this.label_rating.Margin = new System.Windows.Forms.Padding(0);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(641, 47);
            this.label_rating.TabIndex = 1;
            this.label_rating.Text = "Good";
            this.label_rating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_graph
            // 
            this.panel_graph.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.panel_graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_graph.Location = new System.Drawing.Point(21, 182);
            this.panel_graph.Name = "panel_graph";
            this.panel_graph.Size = new System.Drawing.Size(687, 65);
            this.panel_graph.TabIndex = 6;
            // 
            // progressBar_time
            // 
            this.progressBar_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar_time.ForeColor = System.Drawing.Color.Silver;
            this.progressBar_time.Location = new System.Drawing.Point(23, 157);
            this.progressBar_time.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_time.MarqueeAnimationSpeed = 0;
            this.progressBar_time.Maximum = 300;
            this.progressBar_time.Name = "progressBar_time";
            this.progressBar_time.Size = new System.Drawing.Size(685, 18);
            this.progressBar_time.Step = 0;
            this.progressBar_time.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_time.TabIndex = 0;
            this.progressBar_time.Value = 300;
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
            // label_notFragmented
            // 
            this.label_notFragmented.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_notFragmented.AutoEllipsis = true;
            this.label_notFragmented.BackColor = System.Drawing.Color.Transparent;
            this.label_notFragmented.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_notFragmented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_notFragmented.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_notFragmented.Location = new System.Drawing.Point(27, 142);
            this.label_notFragmented.Margin = new System.Windows.Forms.Padding(0);
            this.label_notFragmented.Name = "label_notFragmented";
            this.label_notFragmented.Size = new System.Drawing.Size(285, 32);
            this.label_notFragmented.TabIndex = 8;
            this.label_notFragmented.Text = "Not Fragmented";
            this.label_notFragmented.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_inBuffer
            // 
            this.label_inBuffer.AutoEllipsis = true;
            this.label_inBuffer.BackColor = System.Drawing.Color.Transparent;
            this.label_inBuffer.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_inBuffer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_inBuffer.Location = new System.Drawing.Point(27, 61);
            this.label_inBuffer.Margin = new System.Windows.Forms.Padding(0);
            this.label_inBuffer.Name = "label_inBuffer";
            this.label_inBuffer.Size = new System.Drawing.Size(285, 32);
            this.label_inBuffer.TabIndex = 9;
            this.label_inBuffer.Text = "32 bytes";
            this.label_inBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_inTtl
            // 
            this.label_inTtl.AutoEllipsis = true;
            this.label_inTtl.BackColor = System.Drawing.Color.Transparent;
            this.label_inTtl.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_inTtl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_inTtl.Location = new System.Drawing.Point(27, 103);
            this.label_inTtl.Margin = new System.Windows.Forms.Padding(0);
            this.label_inTtl.Name = "label_inTtl";
            this.label_inTtl.Size = new System.Drawing.Size(285, 32);
            this.label_inTtl.TabIndex = 10;
            this.label_inTtl.Text = "118 TTL";
            this.label_inTtl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_address
            // 
            this.label_address.AutoEllipsis = true;
            this.label_address.BackColor = System.Drawing.Color.Transparent;
            this.label_address.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_address.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_address.Location = new System.Drawing.Point(27, 19);
            this.label_address.Margin = new System.Windows.Forms.Padding(0);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(285, 32);
            this.label_address.TabIndex = 11;
            this.label_address.Text = "127.0.0.1";
            this.label_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_outbound
            // 
            this.panel_outbound.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.panel_outbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_outbound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_outbound.Controls.Add(this.label_outTtl);
            this.panel_outbound.Controls.Add(this.label_outBuffer);
            this.panel_outbound.Controls.Add(this.label_notFragmented);
            this.panel_outbound.Controls.Add(this.label_host);
            this.panel_outbound.Location = new System.Drawing.Point(21, 297);
            this.panel_outbound.Name = "panel_outbound";
            this.panel_outbound.Size = new System.Drawing.Size(340, 191);
            this.panel_outbound.TabIndex = 15;
            // 
            // panel_inbound
            // 
            this.panel_inbound.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.panel_inbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_inbound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_inbound.Controls.Add(this.label_address);
            this.panel_inbound.Controls.Add(this.label_inBuffer);
            this.panel_inbound.Controls.Add(this.label_inTtl);
            this.panel_inbound.Location = new System.Drawing.Point(368, 297);
            this.panel_inbound.Name = "panel_inbound";
            this.panel_inbound.Size = new System.Drawing.Size(340, 191);
            this.panel_inbound.TabIndex = 16;
            // 
            // label_outbound
            // 
            this.label_outbound.AutoEllipsis = true;
            this.label_outbound.BackColor = System.Drawing.Color.Transparent;
            this.label_outbound.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F, System.Drawing.FontStyle.Underline);
            this.label_outbound.Location = new System.Drawing.Point(19, 262);
            this.label_outbound.Margin = new System.Windows.Forms.Padding(0);
            this.label_outbound.Name = "label_outbound";
            this.label_outbound.Size = new System.Drawing.Size(342, 32);
            this.label_outbound.TabIndex = 17;
            this.label_outbound.Text = "Outbound";
            this.label_outbound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_inbound
            // 
            this.label_inbound.AutoEllipsis = true;
            this.label_inbound.BackColor = System.Drawing.Color.Transparent;
            this.label_inbound.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F, System.Drawing.FontStyle.Underline);
            this.label_inbound.Location = new System.Drawing.Point(368, 262);
            this.label_inbound.Margin = new System.Windows.Forms.Padding(0);
            this.label_inbound.Name = "label_inbound";
            this.label_inbound.Size = new System.Drawing.Size(340, 32);
            this.label_inbound.TabIndex = 18;
            this.label_inbound.Text = "Inbound";
            this.label_inbound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Main
            // 
            this.AboutButtonVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 506);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeButtonVisible = true;
            this.Name = "Form_Main";
            this.SettingsButtonVisible = true;
            this.Text = "Ping Tester";
            this.Title = "Ping Tester";
            this.TitleBarImage = global::PingTesterAluminium.Properties.Resources.icon;
            this.AboutButtonClick += new System.EventHandler(this.Form_Main_AboutButtonClick);
            this.SettingsButtonClick += new System.EventHandler(this.Form_Main_SettingsButtonClick);
            this.panel_main.ResumeLayout(false);
            this.panel_outbound.ResumeLayout(false);
            this.panel_inbound.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AluminiumButton button_play;
        private AluminiumLabel label_host;
        private AluminiumLabel label_outBuffer;
        private AluminiumLabel label_outTtl;
        private AluminiumLabel label_status;
        private AluminiumLabel label_time;
        private AluminiumLabel label_rating;
        private System.Windows.Forms.Panel panel_graph;
        private System.Windows.Forms.ProgressBar progressBar_time;
        public System.Windows.Forms.Timer timer_main;
        private System.ComponentModel.BackgroundWorker backgroundWorker_main;
        private AluminiumLabel label_notFragmented;
        private AluminiumLabel label_address;
        private AluminiumLabel label_inTtl;
        private AluminiumLabel label_inBuffer;
        private System.Windows.Forms.Panel panel_inbound;
        private System.Windows.Forms.Panel panel_outbound;
        private AluminiumLabel label_inbound;
        private AluminiumLabel label_outbound;
    }
}