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
        ProgramSetting setting = new ProgramSetting();

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

        public void setButton(ProgramSetting setting)
        {
            if (setting.image != null)
                imgButtom.Image = setting.image;
            this.setting.id = setting.id;
            if (setting.login != null)
                tbLogin.Text = setting.login.ToString();
            if (setting.password != null)
                tbPassword.Text = setting.password.ToString();
            if (setting.server != null)
                tbServer.Text = setting.server.ToString();
            if (setting.path != null)
                tbPath.Text = setting.path.ToString();
        }

        public void setButton(int id)
        {
            setting.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setting.image = imgButtom.Image;
            setting.path = tbPath.Text;
            setting.isVisible = false;
            setting.login = tbLogin.Text;
            setting.password = tbPassword.Text;
            setting.server = tbServer.Text;
            setting.path = tbPath.Text;
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

        public ProgramSetting getButtonSetting()
        {
            return setting;
        }
    }
}
