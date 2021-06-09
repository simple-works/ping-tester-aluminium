namespace PingTesterAluminium
{
    partial class FormAbout
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
            this.button_ok = new System.Windows.Forms.Button();
            this.labelCopyright1 = new System.Windows.Forms.Label();
            this.labelCopyright2 = new System.Windows.Forms.Label();
            this.labelCopyright3 = new System.Windows.Forms.Label();
            this.labelCopyright4 = new System.Windows.Forms.Label();
            this.aluminiumButton1 = new PingTesterAluminium.AluminiumButton();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ok.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.button_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.button_ok.Location = new System.Drawing.Point(198, 293);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(143, 33);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelCopyright1
            // 
            this.labelCopyright1.AutoSize = true;
            this.labelCopyright1.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright1.Location = new System.Drawing.Point(96, 91);
            this.labelCopyright1.Name = "labelCopyright1";
            this.labelCopyright1.Size = new System.Drawing.Size(347, 36);
            this.labelCopyright1.TabIndex = 1;
            this.labelCopyright1.Text = "AmbraPing 1.0.0.0";
            // 
            // labelCopyright2
            // 
            this.labelCopyright2.AutoSize = true;
            this.labelCopyright2.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright2.Location = new System.Drawing.Point(130, 149);
            this.labelCopyright2.Name = "labelCopyright2";
            this.labelCopyright2.Size = new System.Drawing.Size(279, 36);
            this.labelCopyright2.TabIndex = 2;
            this.labelCopyright2.Text = "© Ambratolm";
            // 
            // labelCopyright3
            // 
            this.labelCopyright3.AutoSize = true;
            this.labelCopyright3.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright3.Location = new System.Drawing.Point(42, 185);
            this.labelCopyright3.Name = "labelCopyright3";
            this.labelCopyright3.Size = new System.Drawing.Size(455, 36);
            this.labelCopyright3.TabIndex = 3;
            this.labelCopyright3.Text = "© Elhafid Softwares";
            // 
            // labelCopyright4
            // 
            this.labelCopyright4.AutoSize = true;
            this.labelCopyright4.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright4.Location = new System.Drawing.Point(220, 221);
            this.labelCopyright4.Name = "labelCopyright4";
            this.labelCopyright4.Size = new System.Drawing.Size(99, 36);
            this.labelCopyright4.TabIndex = 4;
            this.labelCopyright4.Text = "2019";
            // 
            // aluminiumButton1
            // 
            this.aluminiumButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aluminiumButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aluminiumButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aluminiumButton1.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.aluminiumButton1.Location = new System.Drawing.Point(136, 33);
            this.aluminiumButton1.Name = "aluminiumButton1";
            this.aluminiumButton1.Size = new System.Drawing.Size(296, 32);
            this.aluminiumButton1.TabIndex = 5;
            this.aluminiumButton1.Text = "aluminiumButton1";
            this.aluminiumButton1.UseVisualStyleBackColor = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 340);
            this.Controls.Add(this.aluminiumButton1);
            this.Controls.Add(this.labelCopyright4);
            this.Controls.Add(this.labelCopyright3);
            this.Controls.Add(this.labelCopyright2);
            this.Controls.Add(this.labelCopyright1);
            this.Controls.Add(this.button_ok);
            this.Font = new System.Drawing.Font("Visitor TT1 BRK", 30F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label labelCopyright1;
        private System.Windows.Forms.Label labelCopyright2;
        private System.Windows.Forms.Label labelCopyright3;
        private System.Windows.Forms.Label labelCopyright4;
        private AluminiumButton aluminiumButton1;

    }
}

