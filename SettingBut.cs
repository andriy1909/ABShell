using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ABShell
{
    public partial class SettingBut : Form
    {
        ButtonApp button = new ButtonApp();

        public SettingBut()
        {
            InitializeComponent();
        }
        public void setImage(Image image)
        {
            imgButtom.Image = image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images|*.png;*.jpg;*.bmp;*.jpeg|All Files|*.*";
            if(fileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    imgButtom.Image = Image.FromFile(fileDialog.FileName);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        public void setButton(ButtonApp button)
        {
            this.button = button;
            if (button.image != null)
                imgButtom.Image = button.image;
            if (button.login != null)
                tbLogin.Text = button.login.ToString();
            if (button.password != null)
                tbPassword.Text = button.password.ToString();
            if (button.server != null)
                tbServer.Text = button.server.ToString();
            if (button.path != null)
                tbPath.Text = button.path.ToString();
        }

        public void setButton(int id)
        {
            button.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            button.image = imgButtom.Image;
            button.path = tbPath.Text;
            button.isVisible = false;
            button.login = tbLogin.Text;
            button.password = tbPassword.Text;
            button.server = tbServer.Text;
            button.path = tbPath.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Programs|*.exe|All Files|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fileDialog.FileName;
                try
                {
                    Icon ico = Icon.ExtractAssociatedIcon(fileDialog.FileName);
                    setImage((Image)(new IconConverter().ConvertTo(ico, typeof(Image))));
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        public ButtonApp getButtonSetting()
        {
            return button;
        }
    }
}
