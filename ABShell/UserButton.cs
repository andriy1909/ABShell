using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABShell
{
    public partial class UserButton : UserControl
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        private Image images;
        public bool isVisible { get; set; }

        public Image image
        {
            get
            {
                return this.images;
            }
            set
            {
                this.images = value;
                if (BackgroundImage != value)
                    BackgroundImage = value;
            }
        }

        public UserButton()
        {
            InitializeComponent();
            button.FlatStyle = FlatStyle.Flat;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.UseVisualStyleBackColor = true;
            button.FlatAppearance.BorderSize = 0;
            id = -1;
            path = "";
            image = null;
            isVisible = false;
            button.BackgroundImageChanged += ButtonApp_BackgroundImageChanged;
        }

        private void ButtonApp_BackgroundImageChanged(object sender, EventArgs e)
        {
            image = BackgroundImage;
        }

        public void revers()
        {
            isVisible = !isVisible;
        }
    }
}
