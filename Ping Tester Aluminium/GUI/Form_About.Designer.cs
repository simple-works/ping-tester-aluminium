namespace PingTesterAluminium
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.button_ok = new PingTesterAluminium.AluminiumButton();
            this.label_about = new PingTesterAluminium.AluminiumLabel();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label_about);
            this.panel_main.Controls.Add(this.button_ok);
            this.panel_main.Size = new System.Drawing.Size(413, 272);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.Silver;
            this.button_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ok.BackgroundImage")));
            this.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_ok.Location = new System.Drawing.Point(295, 224);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 32);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_about
            // 
            this.label_about.AutoEllipsis = true;
            this.label_about.BackColor = System.Drawing.Color.Transparent;
            this.label_about.Location = new System.Drawing.Point(15, 42);
            this.label_about.Margin = new System.Windows.Forms.Padding(0);
            this.label_about.Name = "label_about";
            this.label_about.Size = new System.Drawing.Size(380, 173);
            this.label_about.TabIndex = 1;
            this.label_about.Text = "Ping Tester Aluminium 0.1\r\n© 2019 Elhafid Softwares \r\n@ Ambratolm\r\n\r\nambratolm@gm" +
    "ail.com\r\nambratolm.ml";
            this.label_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_About
            // 
            this.AboutButtonVisible = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 272);
            this.MinimizeButtonVisible = true;
            this.Name = "Form_About";
            this.SettingsButtonVisible = true;
            this.ShowInTaskbar = false;
            this.Text = "Form_About";
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AluminiumButton button_ok;
        private AluminiumLabel label_about;
    }
}