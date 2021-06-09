namespace PingTesterAluminium
{
    partial class AluminiumForm
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
            this.button_settings = new System.Windows.Forms.Button();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_about = new System.Windows.Forms.Button();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.panel_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_title.Controls.Add(this.button_about);
            this.panel_title.Controls.Add(this.button_settings);
            this.panel_title.Controls.Add(this.pictureBox_icon);
            this.panel_title.Controls.Add(this.button_minimize);
            this.panel_title.Controls.Add(this.button_close);
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(394, 33);
            this.panel_title.TabIndex = 0;
            // 
            // button_settings
            // 
            this.button_settings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_settings.BackColor = System.Drawing.Color.Transparent;
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_settings.Image = global::PingTesterAluminium.Properties.Resources.settings;
            this.button_settings.Location = new System.Drawing.Point(294, 4);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(27, 22);
            this.button_settings.TabIndex = 1;
            this.button_settings.UseVisualStyleBackColor = false;
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_icon.Image = global::PingTesterAluminium.Properties.Resources.rectangle;
            this.pictureBox_icon.Location = new System.Drawing.Point(8, 4);
            this.pictureBox_icon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(27, 22);
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
            this.button_minimize.Location = new System.Drawing.Point(326, 4);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(27, 22);
            this.button_minimize.TabIndex = 2;
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
            this.button_close.Location = new System.Drawing.Point(358, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(27, 22);
            this.button_close.TabIndex = 3;
            this.button_close.UseVisualStyleBackColor = false;
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoEllipsis = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.label_title.Location = new System.Drawing.Point(39, 3);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(218, 24);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Window";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_main
            // 
            this.panel_main.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(394, 272);
            this.panel_main.TabIndex = 1;
            // 
            // button_about
            // 
            this.button_about.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_about.BackColor = System.Drawing.Color.Transparent;
            this.button_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_about.Image = global::PingTesterAluminium.Properties.Resources.about;
            this.button_about.Location = new System.Drawing.Point(262, 4);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(27, 22);
            this.button_about.TabIndex = 15;
            this.button_about.UseVisualStyleBackColor = false;
            // 
            // AluminiumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 272);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Visitor TT1 BRK", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AluminiumForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window";
            this.panel_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_minimize;
        protected System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_about;

    }
}

