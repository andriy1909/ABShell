using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABShell
{
    public partial class SettingBut : Form
    {
        public SettingBut()
        {
            InitializeComponent();
        }
        public void setImage(Image image)
        {
            imgButtom.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Icon ico = Icon.ExtractAssociatedIcon(textBox1.Text);
            setImage((Image)(new IconConverter().ConvertTo(ico, typeof(Image))));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imgButtom.Image.Save(textBox1.Text);
        }
    }
}
