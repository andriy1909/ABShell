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
            if (getShell()!= "explorer.exe")
            {
                btnUseShell.setLinevisible(true);
                label8.Text = "Разрешить Windows Shell";
            }
            if (getDispVisible()!="-1")
            {
                btnDisp.setLinevisible(true);
                label6.Text = "Разрешить диспечер задач";
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

            //if (File.Exists(Application.StartupPath + "\\ABShellSetting.conf"))
            loadSetting();
           /*
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher users = new ManagementObjectSearcher(query);
            foreach (ManagementObject user in users.Get())
            {
                UserSetting tmpUser = usersList.Find(x => x.name == user["Name"].ToString());
                if (tmpUser == null)
                {
                    usersList.Add(new UserSetting() { name = user["Name"].ToString() });
                    dataGridView1.Rows.Add(new object[] { user["Name"] });
                }
                else
                {
                    dataGridView1.Rows.Add(new object[] { tmpUser.name });
                }
            }
            Height = min;*/
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        public void saveSetting()
        {
            /* StreamWriter swtr = new StreamWriter(Application.StartupPath + "\\ABShellSetting.conf", false);
             try
             {
                 mainData = new MainData() { usersList = usersList, programsList = programsList };
                 XmlSerializer xmlser = new XmlSerializer(typeof(MainData));
                 xmlser.Serialize(swtr, mainData);
             }
             finally
             {
                 swtr.Close();
             }*/

            //Сохраняем состояние объекта superHuman в двоичном формате
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = new FileStream("./ABShellSetting.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fStream, programsList);
            }
        }
        public void loadSetting()
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
        public void loadSetting2()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = File.OpenRead("./ABShellSetting.dat"))
            {
                programsList = (List<ProgramSetting>)formatter.Deserialize(fStream);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveSetting();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                //UserSetting tmpUser = usersList.Find(x => x.name == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //if (tmpUser != null)
                //{
                    // tmpUser.changeShell = (bool)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                //}
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
            //addBut.Visible = isSetting;
            btnFont.Visible = isSetting;
            richTextBox1.ReadOnly = !isSetting;
            if (isSetting)
            {
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
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (isSetting)
            {
                SettingBut form = new SettingBut();
                form.setButton(sender as ButtonApp);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ButtonApp tmp = form.getButtonSetting();
                    (sender as ButtonApp).image = tmp.image;
                    (sender as ButtonApp).path = tmp.path;
                    (sender as ButtonApp).isVisible = tmp.isVisible;
                    (sender as ButtonApp).login = tmp.login;
                    (sender as ButtonApp).password = tmp.password;
                    (sender as ButtonApp).server = tmp.server;
                    (sender as ButtonApp).path = tmp.path;
                    paintButtons(pnHead, false);
                    paintButtons(pnContents, true);
                }
            }
            else
            {
                Process.Start(programsList.Find(x => x.id == (sender as Button).TabIndex).path);
            }
            
        }

        private void btUseShell_Click(object sender, EventArgs e)
        {
            btnUseShell.setLinevisible(!btnUseShell.getLinevisible());
            if (btnUseShell.getLinevisible())
            {
                setShell(Application.ExecutablePath);
                label8.Text = "Разрешить Windows Shell";
            }
            else
            {
                setShell("explorer.exe");                
                label8.Text = "Заменить Windows Shell";
            }
        }

        private void btDisp_Click(object sender, EventArgs e)
        {
            btnDisp.setLinevisible(!btnDisp.getLinevisible());
            if (!btnDisp.getLinevisible())
            {
                label6.Text = "Запретить диспечер задач";
                setDispVisible(true);
            }
            else
            {
                label6.Text = "Разрешить диспечер задач";
                setDispVisible(false);
            }
        }
        
        public void paintButtons(object panel,bool comtents)
        {
            /*int i = 0;
            foreach (Button item in ((Panel)panel).Controls)
            {
                ProgramSetting setting = programsList.Find(x => x.id == item.TabIndex);
                if (setting != null && setting.isVisible == !comtents)
                {
                    item.BackgroundImage = setting.image;
                    item.Left = i * 75 + 5;
                    i++;
                }
            }*/
        }

        public void addButton(Button button)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SettingBut form = new SettingBut();
            form.ShowDialog();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            if (programsList.Find(x => x.id == button.TabIndex) != null)
            {
                button.TabIndex = button.TabIndex + 1;
                addButton(button);
            }
            SettingBut form = new SettingBut();
            form.setButton(button.TabIndex);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ButtonApp tmp = form.getButtonSetting();
                (sender as ButtonApp).image = tmp.image;
                (sender as ButtonApp).path = tmp.path;
                (sender as ButtonApp).isVisible = tmp.isVisible;
                (sender as ButtonApp).login = tmp.login;
                (sender as ButtonApp).password = tmp.password;
                (sender as ButtonApp).server = tmp.server;
                (sender as ButtonApp).path = tmp.path;
                paintButtons(pnContents, true);
                button.Parent = pnContents;
            }
            else
                Controls.Remove(button);
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
            string keyValueInt = null;// = "1";
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

        private void button1_Click(object sender, EventArgs e)
        {
            paintButtons(pnHead,false);
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            //if(e.Button==MouseButtons.Right)
            //{
                programsList.Find(x => x.id == (sender as Button).TabIndex).revers();
                paintButtons(pnHead, false);
                paintButtons(pnContents, true);
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            saveSetting();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadSetting2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            pnHead.Controls.Clear();
            pnContents.Controls.Clear();
            int i = 0, j = 0;
            foreach (ProgramSetting item in programsList)
            {
                ButtonApp tmp = new ButtonApp();
                tmp = item.getButton();
                tmp.Click += buttonApp_Click;
                tmp.MouseDown += buttonApp_MouseDown;
                tmp.MouseMove += buttonApp_MouseMove;
                tmp.MouseUp += buttonApp_MouseUp;
                tmp.Top = 5;
                if (item.isVisible)
                {
                    tmp.Left = 5 + i * 75;
                    pnHead.Controls.Add(tmp);
                    i++;
                }
                else
                {
                    tmp.Left = 5 + j * 75;
                    pnContents.Controls.Add(tmp);
                    j++;
                }
            }
        }

        private void buttonApp_Click(object sender, EventArgs e)
        {
            if (isSetting)
            {
                SettingBut form = new SettingBut();
                form.setButton(sender as ButtonApp);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ButtonApp tmp = form.getButtonSetting();
                    (sender as ButtonApp).image = tmp.image;
                    (sender as ButtonApp).path = tmp.path;
                    (sender as ButtonApp).isVisible = tmp.isVisible;
                    (sender as ButtonApp).login = tmp.login;
                    (sender as ButtonApp).password = tmp.password;
                    (sender as ButtonApp).server = tmp.server;
                    (sender as ButtonApp).path = tmp.path;
                    paintButtons(pnHead, false);
                    paintButtons(pnContents, true);
                }
            }
            else
            {
                Process.Start((sender as ButtonApp).path);
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
