namespace PingTesterAluminium
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label_time = new System.Windows.Forms.Label();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.label_rating = new System.Windows.Forms.Label();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.button_settings = new System.Windows.Forms.Button();
            this.label_host = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.backgroundWorkerPing = new System.ComponentModel.BackgroundWorker();
            this.button_close = new System.Windows.Forms.Button();
            this.label_applicationTitle = new System.Windows.Forms.Label();
            this.button_minimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.ForeColor = System.Drawing.Color.Gray;
            this.label_time.Location = new System.Drawing.Point(125, 92);
            this.label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(167, 36);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "Timeout";
            // 
            // timerPing
            // 
            this.timerPing.Interval = 1000;
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // label_rating
            // 
            this.label_rating.AutoSize = true;
            this.label_rating.BackColor = System.Drawing.Color.Transparent;
            this.label_rating.ForeColor = System.Drawing.Color.Gray;
            this.label_rating.Location = new System.Drawing.Point(74, 174);
            this.label_rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(287, 36);
            this.label_rating.TabIndex = 5;
            this.label_rating.Text = "Disconnected";
            // 
            // progressBarTime
            // 
            this.progressBarTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarTime.Location = new System.Drawing.Point(135, 136);
            this.progressBarTime.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarTime.MarqueeAnimationSpeed = 0;
            this.progressBarTime.Maximum = 300;
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(150, 34);
            this.progressBarTime.Step = 0;
            this.progressBarTime.TabIndex = 4;
            this.progressBarTime.Value = 300;
            // 
            // button_settings
            // 
            this.button_settings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_settings.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_settings.Location = new System.Drawing.Point(136, 328);
            this.button_settings.Margin = new System.Windows.Forms.Padding(4);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(142, 33);
            this.button_settings.TabIndex = 0;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.BackColor = System.Drawing.Color.Transparent;
            this.label_host.ForeColor = System.Drawing.Color.Gray;
            this.label_host.Location = new System.Drawing.Point(154, 248);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(111, 36);
            this.label_host.TabIndex = 6;
            this.label_host.Text = "Host";
            // 
            // button_about
            // 
            this.button_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_about.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.button_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_about.Image = global::PingTesterAluminium.Properties.Resources.about;
            this.button_about.Location = new System.Drawing.Point(362, 328);
            this.button_about.Margin = new System.Windows.Forms.Padding(4);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(40, 33);
            this.button_about.TabIndex = 2;
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // button_pause
            // 
            this.button_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_pause.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.button_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pause.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_pause.Image = global::PingTesterAluminium.Properties.Resources.pause;
            this.button_pause.Location = new System.Drawing.Point(14, 328);
            this.button_pause.Margin = new System.Windows.Forms.Padding(4);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(40, 33);
            this.button_pause.TabIndex = 1;
            this.button_pause.UseVisualStyleBackColor = false;
            this.button_pause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // backgroundWorkerPing
            // 
            this.backgroundWorkerPing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPing_DoWork);
            this.backgroundWorkerPing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPing_RunWorkerCompleted);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = global::PingTesterAluminium.Properties.Resources.close;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_close.Location = new System.Drawing.Point(369, 14);
            this.button_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(33, 33);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_applicationTitle
            // 
            this.label_applicationTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_applicationTitle.Font = new System.Drawing.Font("Visitor TT1 BRK", 30F);
            this.label_applicationTitle.ForeColor = System.Drawing.Color.Black;
            this.label_applicationTitle.Location = new System.Drawing.Point(13, 14);
            this.label_applicationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_applicationTitle.Name = "label_applicationTitle";
            this.label_applicationTitle.Size = new System.Drawing.Size(307, 33);
            this.label_applicationTitle.TabIndex = 3;
            this.label_applicationTitle.Text = "Ping Tester";
            this.label_applicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.button_minimize.BackgroundImage = global::PingTesterAluminium.Properties.Resources.minimize;
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_minimize.Location = new System.Drawing.Point(328, 14);
            this.button_minimize.Margin = new System.Windows.Forms.Padding(4);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(33, 33);
            this.button_minimize.TabIndex = 2;
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(416, 376);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.label_applicationTitle);
            this.Controls.Add(this.label_time);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Visitor TT1 BRK", 30F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Tester";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_rating;
        private System.Windows.Forms.ProgressBar progressBarTime;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_pause;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPing;
        public System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_applicationTitle;
        private System.Windows.Forms.Button button_minimize;

    }
}

