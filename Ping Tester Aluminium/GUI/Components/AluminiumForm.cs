using System;
using System.Windows.Forms;
using PingTesterAluminium.Properties;
using System.ComponentModel;
using System.Drawing;

namespace PingTesterAluminium
{
    public partial class AluminiumForm : Form
    {
        [Browsable(true)]
        [Category("Title Bar")]
        public string Title
        {
            get
            {
                return this.label_title.Text;
            }
            set
            {
                this.label_title.Text = value;
                this.Text = value;
            }
        }

        [Browsable(true)]
        [Category("Title Bar")]
        public bool AboutButtonVisible
        {
            get
            {
                return this.button_settings.Visible;
            }
            set
            {
                this.button_settings.Visible = value;
            }
        }

        [Browsable(true)]
        [Category("Title Bar")]
        public bool SettingsButtonVisible
        {
            get
            {
                return this.button_settings.Visible;
            }
            set
            {
                this.button_settings.Visible = value;
            }
        }

        [Browsable(true)]
        [Category("Title Bar")]
        public bool MinimizeButtonVisible
        {
            get
            {
                return this.button_minimize.Visible;
            }
            set
            {
                this.button_minimize.Visible = value;
            }
        }

        [Browsable(true)]
        [Category("Title Bar")]
        public Image TitleBarImage
        {
            get
            {
                return this.pictureBox_icon.Image;
            }
            set
            {
                this.pictureBox_icon.Image = value;
            }
        }

        [Browsable(true)]
        [Category("Title Bar")]
        public event EventHandler AboutButtonClick;

        [Browsable(true)]
        [Category("Title Bar")]
        public event EventHandler SettingsButtonClick;

        public AluminiumForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.label_title.Text = this.Text;
            this.button_close.Click += (s, e) => this.Close();
            this.button_minimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            this.button_about.Click += (s, e) =>
            {
                if (this.AboutButtonClick != null) this.AboutButtonClick(s, e);
            };
            this.button_settings.Click += (s, e) =>
            {
                if (this.SettingsButtonClick != null) this.SettingsButtonClick(s, e);
            };

            this.EnableHoverEffectsForChildButtons();
            this.panel_title.EnableMovingByMouseDrag();
            this.pictureBox_icon.EnableMovingByMouseDrag();
            this.label_title.EnableMovingByMouseDrag();
            this.SetFont(Constants.VisitorFontFamily);
        }
    }
}
