using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using Microsoft.Win32;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace ABShell
{
    public partial class MainForm : Form
    {
        private bool isSetting = false;
        private List<ProgramSetting> programsList;
        int min = 320;
        int max = 530;

        public MainForm()
        {
            InitializeComponent();
            programsList = new List<ProgramSetting>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            Width = Properties.Settings.Default.Width;
            cbUseShell.Checked = getShell() == "explorer.exe" || getShell().ToLower() == "explorer";
            cbUseDisp.Checked = getDispVisible() == "-1";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            MaximumSize = new Size(2000, min);
            MinimumSize = new Size(505, min);
            buttonApp1.path = Application.StartupPath + "\\TeamViewer.exe";

            if (File.Exists(Application.StartupPath + "\\ABShellSetting.bat"))
            loadSetting();
            Height = min;
        }
        
        public void saveSetting()
        {
            //Сохраняем в двоичном формате
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = new FileStream("./ABShellSetting.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fStream, programsList);
            }
        }
        public void loadSetting2()
        {
            /* StreamReader srdr = new StreamReader(Application.StartupPath + "\\ABShellSetting.conf");
            try
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(MainData));
                mainData = (MainData)xmlser.Deserialize(srdr);
                usersList = mainData.usersList;
                programsList = mainData.programsList;
            }
            finally
            {
                srdr.Close();
            }*/
            programsList.Clear();
            programsList.Add(new ProgramSetting() { id = 40, isVisible = true });
            programsList.Add(new ProgramSetting() { id = 41, isVisible = false });
            programsList.Add(new ProgramSetting() { id = 42, isVisible = true });
            programsList.Add(new ProgramSetting() { id = 43, isVisible = false });
            programsList.Add(new ProgramSetting() { id = 44, isVisible = false });
            programsList.Add(new ProgramSetting() { id = 45, isVisible = true });
            programsList.Add(new ProgramSetting() { id = 46, isVisible = false });
            programsList.Add(new ProgramSetting() { id = 47, isVisible = true });
        }
        public void loadSetting()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = File.OpenRead("./ABShellSetting.dat"))
            {
                programsList = (List<ProgramSetting>)formatter.Deserialize(fStream);
            }
        }
        public void setShell(string name)
        {
            RegistryKey hklm = Registry.CurrentUser;
            RegistryKey hkSoftware = hklm.OpenSubKey("Software");
            RegistryKey hkMicrosoft = hkSoftware.OpenSubKey("Microsoft");
            RegistryKey hkWindowsNT = hkMicrosoft.OpenSubKey("Windows NT");
            RegistryKey hkCurrentVersion = hkWindowsNT.OpenSubKey("CurrentVersion");
            RegistryKey hkWinlogon = hkCurrentVersion.OpenSubKey("Winlogon", true);
            hkWinlogon.SetValue("Shell", name);
        }
        public string getShell()
        {
            RegistryKey hklm = Registry.CurrentUser;
            RegistryKey hkSoftware = hklm.OpenSubKey("Software");
            RegistryKey hkMicrosoft = hkSoftware.OpenSubKey("Microsoft");
            RegistryKey hkWindowsNT = hkMicrosoft.OpenSubKey("Windows NT");
            RegistryKey hkCurrentVersion = hkWindowsNT.OpenSubKey("CurrentVersion");
            RegistryKey hkWinlogon = hkCurrentVersion.OpenSubKey("Winlogon", true);
            return (string)hkWinlogon.GetValue("Shell", "");
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            Reboot power = new Reboot();
            power.halt(false, false);
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Reboot power = new Reboot();
            power.halt(true, false);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Reboot power = new Reboot();
            power.Lock();
        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            isSetting = !isSetting;
            
            if (isSetting)
            {
                Autorization form = new Autorization();
                if (form.ShowDialog() != DialogResult.OK)
                {
                    isSetting = false;
                    return;
                }
                MaximumSize = new Size(2000, max);
                MinimumSize = new Size(505, max);
                richTextBox1.BackColor = Color.White;
                richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MaximumSize = new Size(2000, min);
                MinimumSize = new Size(505, min);
                richTextBox1.BackColor = Color.FromArgb(146, 188, 235);
                richTextBox1.BorderStyle = BorderStyle.None;
                Properties.Settings.Default.Heigth = Height;
                Properties.Settings.Default.Save();
            }
            addBut.Visible = isSetting;
            btnFont.Visible = isSetting;
            richTextBox1.ReadOnly = !isSetting;
        }
        
        //отключить Диспетчер задач
        public void setDispVisible(bool value)
        {
            RegistryKey regkey;
            string keyValueInt = "-1";
            if (!value)
                keyValueInt = "1";
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";

            try
            {
                regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
                regkey.SetValue("DisableTaskMgr", keyValueInt);
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string getDispVisible()
        {
            RegistryKey regkey;
            string keyValueInt = "1";
            string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";

            try
            {
                regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
                keyValueInt = (string)regkey.GetValue("DisableTaskMgr");
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return keyValueInt;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        
        public void update(bool userVis=false)
        {
            pnContents.Controls.Clear();
            int i = 0;
            foreach (ProgramSetting item in programsList)
            {
                UserButton tmp = new UserButton();
                tmp = item.getButton();
                //tmp.Click += buttonApp_Click;
                //tmp.MouseDown += buttonApp_MouseDown;
                //tmp.MouseMove += buttonApp_MouseMove;
                //tmp.MouseUp += buttonApp_MouseUp;
                tmp.Top = 0;
                if (userVis || item.isVisible)
                {
                    tmp.Left = i * 75;
                    pnContents.Controls.Add(tmp);
                    i++;
                }
            }
            Button add = new Button();
            add.Name = "addBut";
            add.Width = 51;
            add.Height = 51;
            add.Top = 7;
            add.Left = i * 75 + 7;
            add.Image = btnCopy.Image;
            add.FlatStyle = FlatStyle.Flat;
            add.FlatAppearance.BorderSize = 0;
            add.BackgroundImageLayout = ImageLayout.Stretch;
            add.TabIndex = 1;
            pnContents.Controls.Add(add);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (isSetting)
            {
                SettingBut form = new SettingBut();
                form.setButton(sender as UserButton);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UserButton tmp = form.getButtonSetting();
                    (sender as UserButton).image = tmp.image;
                    (sender as UserButton).path = tmp.path;
                    (sender as UserButton).isVisible = tmp.isVisible;
                    (sender as UserButton).path = tmp.path;
                    update(true);
                }
            }
            else
            {
                Process.Start((sender as UserButton).path);
            }
        }

        private void pnContents_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            programsList.Clear();
            foreach (ButtonApp item in pnContents.Controls)
            {
                ProgramSetting tmp = new ProgramSetting();
                tmp.setSetting(item);
                programsList.Add(tmp);
            }
            foreach (ButtonApp item in pnHead.Controls)
            {
                ProgramSetting tmp = new ProgramSetting();
                tmp.setSetting(item);
                programsList.Add(tmp);
            }
        }

        private void buttonApp4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ProgramSetting tmp = programsList.Find(x => x.id == (sender as ButtonApp).id);
                if (tmp != null)
                {
                    tmp.revers();
                }
            }
            Update();
        }
        bool b = false;
        int w, h;
        Control ob;
        private void buttonApp_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonApp button = sender as ButtonApp;
            b = true;
            ob = button.Parent;
            w = button.Left;
            h = button.Top;
            button.Parent = this;
            button.BringToFront();
            button.Left = MousePosition.X - Left - 55;
            button.Top = MousePosition.Y - Top - 55;
        }

        private void buttonApp_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonApp button = sender as ButtonApp;
            b = false;
            ProgramSetting tmp = programsList.Find(x => x.id == button.id);
            if (button.Left + 50 < pnHead.Width && button.Top + 50 < pnHead.Height)
            {
                tmp.isVisible = true;
                Controls.Remove(button);
            }
            else
                if (button.Left + 50 < pnContents.Width && button.Top + 50 < pnContents.Height)
            {
                tmp.isVisible = false;
                Controls.Remove(button);
            }
            else
            {
                button.Parent = ob;
                button.Left = w;
                button.Top = h;
            }
            update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void cbUseShell_Click(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void cbUseDisp_Click(object sender, EventArgs e)
        {
            if (cbUseShell.Checked)
                setDispVisible(true);
            else
                setDispVisible(false);
        }

        private void addBut_Click_1(object sender, EventArgs e)
        {
            Button button = new Button();
            if (programsList.Find(x => x.id == button.TabIndex) != null)
            {
                button.TabIndex = button.TabIndex + 1;
            }
            SettingBut form = new SettingBut();
            form.setButton(button.TabIndex);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UserButton tmp = form.getButtonSetting();
                (sender as UserButton).image = tmp.image;
                (sender as UserButton).path = tmp.path;
                (sender as UserButton).isVisible = tmp.isVisible;
                (sender as UserButton).path = tmp.path;
                update();
                button.Parent = pnContents;
            }
            else
                Controls.Remove(button);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonApp2_Click(object sender, EventArgs e)
        {
            if (!isSetting)
            {
                Process.Start((sender as ButtonApp).path);
            }
        }

        private void buttonApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (b)
            {
                ButtonApp button = sender as ButtonApp;
                button.Left = MousePosition.X - Left-55;
                button.Top = MousePosition.Y - Top-55;
            }
        }
    }
}
