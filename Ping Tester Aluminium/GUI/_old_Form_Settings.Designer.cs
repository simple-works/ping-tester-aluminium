namespace PingTesterAluminium
{
    partial class FormSettings
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(411, 185);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 33);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.BackColor = System.Drawing.Color.Transparent;
            this.labelHost.Font = new System.Drawing.Font("Visitor TT1 BRK", 25F);
            this.labelHost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHost.Location = new System.Drawing.Point(120, 14);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(334, 31);
            this.labelHost.TabIndex = 4;
            this.labelHost.Text = "Host (Name or IP)";
            // 
            // textBoxHost
            // 
            this.textBoxHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHost.Location = new System.Drawing.Point(13, 48);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(547, 44);
            this.textBoxHost.TabIndex = 0;
            this.textBoxHost.Text = "google.com";
            this.textBoxHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInterval.Location = new System.Drawing.Point(12, 129);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(548, 44);
            this.textBoxInterval.TabIndex = 1;
            this.textBoxInterval.Text = "1000";
            this.textBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInterval.TextChanged += new System.EventHandler(this.textBoxInterval_TextChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.BackColor = System.Drawing.Color.Transparent;
            this.labelInterval.Font = new System.Drawing.Font("Visitor TT1 BRK", 25F);
            this.labelInterval.Location = new System.Drawing.Point(160, 95);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(254, 31);
            this.labelInterval.TabIndex = 5;
            this.labelInterval.Text = "Interval (ms)";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Visitor TT1 BRK", 15F);
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(13, 185);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 33);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PingTesterAluminium.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(574, 232);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Visitor TT1 BRK", 30F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Button buttonCancel;

    }
}

