namespace PingTesterAluminium
{
    partial class Form_Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Error));
            this.button_ok = new PingTesterAluminium.AluminiumButton();
            this.label_error = new PingTesterAluminium.AluminiumLabel();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label_error);
            this.panel_main.Controls.Add(this.button_ok);
            this.panel_main.Size = new System.Drawing.Size(408, 172);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.BackColor = System.Drawing.Color.Silver;
            this.button_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ok.BackgroundImage")));
            this.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_ok.Location = new System.Drawing.Point(295, 127);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 32);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error.AutoEllipsis = true;
            this.label_error.BackColor = System.Drawing.Color.Transparent;
            this.label_error.Location = new System.Drawing.Point(8, 42);
            this.label_error.Margin = new System.Windows.Forms.Padding(0);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(390, 74);
            this.label_error.TabIndex = 1;
            this.label_error.Text = "Error";
            this.label_error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Error
            // 
            this.AboutButtonVisible = true;
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_ok;
            this.ClientSize = new System.Drawing.Size(408, 172);
            this.MinimizeButtonVisible = true;
            this.Name = "Form_Error";
            this.SettingsButtonVisible = true;
            this.ShowInTaskbar = false;
            this.Text = "Error";
            this.Title = "Error";
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AluminiumButton button_ok;
        private AluminiumLabel label_error;
    }
}