namespace PingTesterAluminium
{
    partial class Form_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            this.button_save = new PingTesterAluminium.AluminiumButton();
            this.aluminiumLabel1 = new PingTesterAluminium.AluminiumLabel();
            this.aluminiumTextBox1 = new PingTesterAluminium.AluminiumTextBox();
            this.textBox_host = new PingTesterAluminium.AluminiumTextBox();
            this.textBox_interval = new PingTesterAluminium.AluminiumTextBox();
            this.aluminiumLabel2 = new PingTesterAluminium.AluminiumLabel();
            this.textBox_timeout = new PingTesterAluminium.AluminiumTextBox();
            this.aluminiumLabel3 = new PingTesterAluminium.AluminiumLabel();
            this.textBox_buffer = new PingTesterAluminium.AluminiumTextBox();
            this.aluminiumLabel4 = new PingTesterAluminium.AluminiumLabel();
            this.textBox_ttl = new PingTesterAluminium.AluminiumTextBox();
            this.aluminiumLabel5 = new PingTesterAluminium.AluminiumLabel();
            this.textBox_fragmentation = new PingTesterAluminium.AluminiumTextBox();
            this.aluminiumLabel6 = new PingTesterAluminium.AluminiumLabel();
            this.button_cancel = new PingTesterAluminium.AluminiumButton();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.button_cancel);
            this.panel_main.Controls.Add(this.textBox_fragmentation);
            this.panel_main.Controls.Add(this.aluminiumLabel6);
            this.panel_main.Controls.Add(this.textBox_ttl);
            this.panel_main.Controls.Add(this.aluminiumLabel5);
            this.panel_main.Controls.Add(this.textBox_buffer);
            this.panel_main.Controls.Add(this.aluminiumLabel4);
            this.panel_main.Controls.Add(this.textBox_timeout);
            this.panel_main.Controls.Add(this.aluminiumLabel3);
            this.panel_main.Controls.Add(this.textBox_interval);
            this.panel_main.Controls.Add(this.aluminiumLabel2);
            this.panel_main.Controls.Add(this.textBox_host);
            this.panel_main.Controls.Add(this.aluminiumTextBox1);
            this.panel_main.Controls.Add(this.aluminiumLabel1);
            this.panel_main.Controls.Add(this.button_save);
            this.panel_main.Size = new System.Drawing.Size(782, 341);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Silver;
            this.button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_save.BackgroundImage")));
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_save.Location = new System.Drawing.Point(601, 293);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(166, 32);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // aluminiumLabel1
            // 
            this.aluminiumLabel1.AutoEllipsis = true;
            this.aluminiumLabel1.BackColor = System.Drawing.Color.Transparent;
            this.aluminiumLabel1.Location = new System.Drawing.Point(14, 49);
            this.aluminiumLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.aluminiumLabel1.Name = "aluminiumLabel1";
            this.aluminiumLabel1.Size = new System.Drawing.Size(373, 32);
            this.aluminiumLabel1.TabIndex = 1;
            this.aluminiumLabel1.Text = "Host (Name or IP)";
            this.aluminiumLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aluminiumTextBox1
            // 
            this.aluminiumTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aluminiumTextBox1.Location = new System.Drawing.Point(-16, -16);
            this.aluminiumTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.aluminiumTextBox1.Name = "aluminiumTextBox1";
            this.aluminiumTextBox1.Size = new System.Drawing.Size(400, 32);
            this.aluminiumTextBox1.TabIndex = 2;
            // 
            // textBox_host
            // 
            this.textBox_host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_host.Location = new System.Drawing.Point(18, 83);
            this.textBox_host.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.textBox_host.Name = "textBox_host";
            this.textBox_host.Size = new System.Drawing.Size(369, 32);
            this.textBox_host.TabIndex = 3;
            // 
            // textBox_interval
            // 
            this.textBox_interval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_interval.Location = new System.Drawing.Point(18, 159);
            this.textBox_interval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.textBox_interval.Name = "textBox_interval";
            this.textBox_interval.Size = new System.Drawing.Size(369, 32);
            this.textBox_interval.TabIndex = 5;
            // 
            // aluminiumLabel2
            // 
            this.aluminiumLabel2.AutoEllipsis = true;
            this.aluminiumLabel2.BackColor = System.Drawing.Color.Transparent;
            this.aluminiumLabel2.Location = new System.Drawing.Point(14, 125);
            this.aluminiumLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.aluminiumLabel2.Name = "aluminiumLabel2";
            this.aluminiumLabel2.Size = new System.Drawing.Size(373, 32);
            this.aluminiumLabel2.TabIndex = 4;
            this.aluminiumLabel2.Text = "Pinging Interval (ms)";
            this.aluminiumLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_timeout
            // 
            this.textBox_timeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_timeout.Location = new System.Drawing.Point(18, 235);
            this.textBox_timeout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.textBox_timeout.Name = "textBox_timeout";
            this.textBox_timeout.Size = new System.Drawing.Size(369, 32);
            this.textBox_timeout.TabIndex = 7;
            // 
            // aluminiumLabel3
            // 
            this.aluminiumLabel3.AutoEllipsis = true;
            this.aluminiumLabel3.BackColor = System.Drawing.Color.Transparent;
            this.aluminiumLabel3.Location = new System.Drawing.Point(14, 201);
            this.aluminiumLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.aluminiumLabel3.Name = "aluminiumLabel3";
            this.aluminiumLabel3.Size = new System.Drawing.Size(373, 32);
            this.aluminiumLabel3.TabIndex = 6;
            this.aluminiumLabel3.Text = "Timeout (ms)";
            this.aluminiumLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_buffer
            // 
            this.textBox_buffer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_buffer.Location = new System.Drawing.Point(398, 83);
            this.textBox_buffer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.textBox_buffer.Name = "textBox_buffer";
            this.textBox_buffer.Size = new System.Drawing.Size(369, 32);
            this.textBox_buffer.TabIndex = 9;
            // 
            // aluminiumLabel4
            // 
            this.aluminiumLabel4.AutoEllipsis = true;
            this.aluminiumLabel4.BackColor = System.Drawing.Color.Transparent;
            this.aluminiumLabel4.Location = new System.Drawing.Point(394, 49);
            this.aluminiumLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.aluminiumLabel4.Name = "aluminiumLabel4";
            this.aluminiumLabel4.Size = new System.Drawing.Size(373, 32);
            this.aluminiumLabel4.TabIndex = 8;
            this.aluminiumLabel4.Text = "Buffer (Bytes)";
            this.aluminiumLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_ttl
            // 
            this.textBox_ttl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ttl.Location = new System.Drawing.Point(398, 159);
            this.textBox_ttl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.textBox_ttl.Name = "textBox_ttl";
            this.textBox_ttl.Size = new System.Drawing.Size(369, 32);
            this.textBox_ttl.TabIndex = 11;
            // 
            // aluminiumLabel5
            // 
            this.aluminiumLabel5.AutoEllipsis = true;
            this.aluminiumLabel5.BackColor = System.Drawing.Color.Transparent;
            this.aluminiumLabel5.Location = new System.Drawing.Point(394, 125);
            this.aluminiumLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.aluminiumLabel5.Name = "aluminiumLabel5";
            this.aluminiumLabel5.Size = new System.Drawing.Size(373, 32);
            this.aluminiumLabel5.TabIndex = 10;
            this.aluminiumLabel5.Text = "TLT (Time To Live)";
            this.aluminiumLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_fragmentation
            // 
            this.textBox_fragmentation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_fragmentation.Location = new System.Drawing.Point(398, 235);
            this.textBox_fragmentation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.textBox_fragmentation.Name = "textBox_fragmentation";
            this.textBox_fragmentation.Size = new System.Drawing.Size(369, 32);
            this.textBox_fragmentation.TabIndex = 13;
            // 
            // aluminiumLabel6
            // 
            this.aluminiumLabel6.AutoEllipsis = true;
            this.aluminiumLabel6.BackColor = System.Drawing.Color.Transparent;
            this.aluminiumLabel6.Location = new System.Drawing.Point(394, 201);
            this.aluminiumLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.aluminiumLabel6.Name = "aluminiumLabel6";
            this.aluminiumLabel6.Size = new System.Drawing.Size(373, 32);
            this.aluminiumLabel6.TabIndex = 12;
            this.aluminiumLabel6.Text = "Fragmentation";
            this.aluminiumLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Silver;
            this.button_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cancel.BackgroundImage")));
            this.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_cancel.Location = new System.Drawing.Point(495, 293);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 32);
            this.button_cancel.TabIndex = 14;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Form_Settings
            // 
            this.AboutButtonVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 341);
            this.MinimizeButtonVisible = true;
            this.Name = "Form_Settings";
            this.SettingsButtonVisible = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Title = "Settings";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AluminiumLabel aluminiumLabel1;
        private AluminiumButton button_save;
        private AluminiumButton button_cancel;
        private AluminiumTextBox textBox_fragmentation;
        private AluminiumLabel aluminiumLabel6;
        private AluminiumTextBox textBox_ttl;
        private AluminiumLabel aluminiumLabel5;
        private AluminiumTextBox textBox_buffer;
        private AluminiumLabel aluminiumLabel4;
        private AluminiumTextBox textBox_timeout;
        private AluminiumLabel aluminiumLabel3;
        private AluminiumTextBox textBox_interval;
        private AluminiumLabel aluminiumLabel2;
        private AluminiumTextBox textBox_host;
        private AluminiumTextBox aluminiumTextBox1;
    }
}