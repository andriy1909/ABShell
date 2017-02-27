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
using System.Security.AccessControl;

namespace ABShell
{
    public partial class MainForm : Form
    {
        private bool isSetting = false;
        private List<ProgramSetting> programsList;
        bool isShutDown = false;
        int min = 320;
        int max = 390;

        public MainForm()
        {
            InitializeComponent();
            programsList = new List<ProgramSetting>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            Width = Properties.Settings.Default.Width;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.Text = Properties.Settings.Default.Text;
            richTextBox1.Font = Properties.Settings.Default.Font;
            cbUseShell.Checked = !(getShell() == "explorer.exe" || getShell().ToLower() == "explorer");
            cbUseDisp.Checked = getDisp() == "1";
            
            MaximumSize = new Size(2000, min);
            MinimumSize = new Size(505, min);

            if (File.Exists(Application.StartupPath + "\\ABShellSetting.dat"))
                loadSetting();
            else
            {
                programsList.Add(new ProgramSetting()
                {
                    id = 0,
                    image = btnABOffice.image,
                    path = btnABOffice.path,
                    name = btnABOffice.SetText,
                    isVisible = true
            });
                programsList.Add(new ProgramSetting()
                {
                    id = 1,
                    image = btnTeamViewer.image,
                    path = Application.StartupPath + "\\TeamViewer.exe",
                    name = btnTeamViewer.SetText,
                    isVisible = true
                });
                btnTeamViewer.path = Application.StartupPath + "\\TeamViewer.exe";
            }
            update();
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
        public void loadSetting()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = File.OpenRead("./ABShellSetting.dat"))
            {
                programsList = (List<ProgramSetting>)formatter.Deserialize(fStream);
            }
            btnABOffice = loadButton(programsList.Find(x => x.id == 0), btnABOffice);
            btnTeamViewer = loadButton(programsList.Find(x => x.id == 1), btnTeamViewer);
        }

        public UserButton loadButton(ProgramSetting setting, UserButton button)
        {
            button.isVisible = setting.isVisible;
            button.SetText = setting.name;
            button.image = setting.image;
            button.path = setting.path;
            return button;
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

        public void setDisp(bool value)
        {
            RegistryKey hklm = Registry.CurrentUser;
            RegistryKey hkSoftware = hklm.OpenSubKey("Software");
            RegistryKey hkMicrosoft = hkSoftware.OpenSubKey("Microsoft");
            RegistryKey hkWindowsNT = hkMicrosoft.OpenSubKey("Windows");
            RegistryKey hkCurrentVersion = hkWindowsNT.OpenSubKey("CurrentVersion");
            RegistryKey hkSystem = hkCurrentVersion.OpenSubKey("Policies");
            RegistryKey hkWinlogon = hkSystem.OpenSubKey("System", true);
            string keyValueInt = "-1";
            if (!value)
                keyValueInt = "1";
            hkWinlogon.SetValue("DisableTaskMgr", keyValueInt);
        }
        public string getDisp()
        {
            RegistryKey hklm = Registry.CurrentUser;
            RegistryKey hkSoftware = hklm.OpenSubKey("Software");
            RegistryKey hkMicrosoft = hkSoftware.OpenSubKey("Microsoft");
            RegistryKey hkWindowsNT = hkMicrosoft.OpenSubKey("Windows");
            RegistryKey hkCurrentVersion = hkWindowsNT.OpenSubKey("CurrentVersion");
            RegistryKey hkSystem = hkCurrentVersion.OpenSubKey("Policies");
            RegistryKey hkWinlogon = hkSystem.OpenSubKey("System", false);
            return (string)hkWinlogon.GetValue("DisableTaskMgr", "-1");
        }
        //отключить Диспетчер задач
      /*  public void setDispVisible(bool value)
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
                // regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey);
                keyValueInt = (string)regkey.GetValue("DisableTaskMgr");
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return keyValueInt;
        }
        */
        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            Reboot power = new Reboot();
            isShutDown = true;
            power.halt(false, false);
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Reboot power = new Reboot();
            isShutDown = true;
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
                Properties.Settings.Default.Width = Width;
                Properties.Settings.Default.Font = richTextBox1.Font;
                Properties.Settings.Default.Text = richTextBox1.Text;
                Properties.Settings.Default.Save();
                saveSetting();
            }
            addBut.Visible = isSetting;
            btnFont.Visible = isSetting;
            richTextBox1.ReadOnly = !isSetting;
            update();
        }

        //отключить Диспетчер задач
    /*    public void setDispVisible(bool value)
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
               // regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey);
                keyValueInt = (string)regkey.GetValue("DisableTaskMgr");
                regkey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return keyValueInt;
        }*/

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !isShutDown;
        }

        public void update()
        {
            pnContents.Controls.Clear();
            int i = 0;
            foreach (ProgramSetting item in programsList)
            {
                if (item.id == 0 || item.id == 1) 
                    continue;
                UserButton tmp = new UserButton();
                tmp = item.getButton();
                tmp.Click += button_Click;
                tmp.Top = 0;
                if (isSetting || item.isVisible)
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
            add.Top = 20;
            add.Left = i * 75 + 14;
            add.BackgroundImage = Properties.Resources.add1__41512;
            add.BackgroundImageLayout = ImageLayout.Stretch;
            add.FlatStyle = FlatStyle.Flat;
            add.FlatAppearance.BorderSize = 0;
            add.Click += addBut_Click;
            add.Visible = isSetting;
            pnContents.Controls.Add(add);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (isSetting)
            {
                SettingBut form = new SettingBut();
                form.setButton(sender as UserButton);
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.Abort)
                {
                    UserButton tmp = form.getButtonSetting();
                    programsList.RemoveAll(x => x.id == tmp.id);
                    update();
                }
                else
                if (dr == DialogResult.OK)
                {
                    UserButton tmp = form.getButtonSetting();
                    programsList.Find(x => x.id == tmp.id).image = tmp.image;
                    programsList.Find(x => x.id == tmp.id).path = tmp.path;
                    programsList.Find(x => x.id == tmp.id).isVisible = tmp.isVisible;
                    programsList.Find(x => x.id == tmp.id).name = tmp.SetText;
                    update();
                }
            }
            else
            {
                Process.Start((sender as UserButton).path);
            }
        }

        private void cbUseShell_Click(object sender, EventArgs e)
        {
            if (cbUseShell.Checked)
                setShell(Application.ExecutablePath);
            else
                setShell("explorer.exe");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = richTextBox1.Font;
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }
        
        private void cbUseDisp_Click(object sender, EventArgs e)
        {
            if (!cbUseDisp.Checked)
                setDisp(true);
            else
                setDisp(false);
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            UserButton button = new UserButton();
            button.TabIndex = 100;
            while (programsList.Find(x => x.id == button.TabIndex) != null)
            {
                button.TabIndex = button.TabIndex + 1;
            }
            SettingBut form = new SettingBut();
            form.setButton(button.TabIndex);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UserButton tmp = form.getButtonSetting();
                tmp.Parent = pnContents;
                tmp.Top = 0;
                tmp.Left = (pnContents.Controls.Count - 3) * 75;
                (sender as Button).Left += 75;
                programsList.Add(form.getSetting());
                update();
            }
            else
                Controls.Remove(button);
        }
        
        private void buttonApp2_Click(object sender, EventArgs e)
        {
            Autorization form = new Autorization();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Process.Start((sender as ButtonApp).path);
            }
        }

        private void buttonApp4_Click(object sender, EventArgs e)
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
                }
            }
            else
            {
                Autorization form = new Autorization();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Process.Start("control", "printers");
                }
            }
        }
         
        private void standartButt_Click(object sender, EventArgs e)
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
                    (sender as UserButton).SetText = tmp.SetText;
                }
            }
            else
            {
                try
                {
                    Process.Start((sender as UserButton).path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Файл не найден!");
                }

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
