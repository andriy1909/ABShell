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
                button.Image = value;
            }
        }

        public string SetText
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                label1.Text = value;
            }
        }

        public UserButton()
        {
            InitializeComponent();
            id = -1;
            path = "";
            image = null;
            isVisible = false;
        }
        
        public void revers()
        {
            isVisible = !isVisible;
        }
    }
}
