namespace PingTesterAluminium
{
    partial class Form_Template
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
            this.panel_title = new System.Windows.Forms.Panel();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_ok = new System.Windows.Forms.Button();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.panel_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_title.Controls.Add(this.pictureBox_icon);
            this.panel_title.Controls.Add(this.button_minimize);
            this.panel_title.Controls.Add(this.button_close);
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(394, 48);
            this.panel_title.TabIndex = 12;
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_icon.Image = global::PingTesterAluminium.Properties.Resources.rectangle;
            this.pictureBox_icon.Location = new System.Drawing.Point(11, 7);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(40, 33);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_icon.TabIndex = 14;
            this.pictureBox_icon.TabStop = false;
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_minimize.Image = global::PingTesterAluminium.Properties.Resources.minimize;
            this.button_minimize.Location = new System.Drawing.Point(293, 7);
            this.button_minimize.Margin = new System.Windows.Forms.Padding(4);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(40, 33);
            this.button_minimize.TabIndex = 13;
            this.button_minimize.UseVisualStyleBackColor = false;
            // 
            // button_close
            // 
            this.button_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_close.Image = global::PingTesterAluminium.Properties.Resources.close;
            this.button_close.Location = new System.Drawing.Point(341, 7);
            this.button_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(40, 33);
            this.button_close.TabIndex = 1;
            this.button_close.UseVisualStyleBackColor = false;
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoEllipsis = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.label_title.Location = new System.Drawing.Point(57, 5);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(228, 36);
            this.label_title.TabIndex = 12;
            this.label_title.Text = "Window";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_main
            // 
            this.panel_main.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.button_ok);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(394, 272);
            this.panel_main.TabIndex = 11;
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_ok.Location = new System.Drawing.Point(237, 225);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(143, 33);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            // 
            // Form_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 272);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Visitor TT1 BRK", 30F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Template";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.panel_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.PictureBox pictureBox_icon;

    }
}

