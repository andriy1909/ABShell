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

namespace ABShell
{
    public partial class MainForm : Form
    {
        private bool isSetting = false;
        private MainData mainData;
        private List<UserSetting> usersList;
        private List<ProgramSetting> programsList;
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public MainForm()
        {
            InitializeComponent();
            usersList = new List<UserSetting>();
            programsList = new List<ProgramSetting>();
        }

        private void SaveValue(string name, string value)
        {
            //Properties.Settings.Default.PropertyValues.Add(new SettingsPropertyValue(new SettingsProperty(name)));
            Properties.Settings.Default.Setting = value;
            Properties.Settings.Default.Save();
           /* if (config.AppSettings.Settings[name] == null)
            {
                config.AppSettings.Settings.Add(name, value);
            }
            else config.AppSettings.Settings[name].Value = value;
            config.Save(ConfigurationSaveMode.Modified);*/
        }

        private string LoadValue(string name)
        {
            object ob = Properties.Settings.Default.Setting;
            return ob.ToString();
            /*
            if (config.AppSettings.Settings[name] == null)
            {
                return null;
            }
            else return config.AppSettings.Settings[name].Value;
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (File.Exists(Application.StartupPath + "\\ABShellSetting.conf"))
            //if (File.Exists(@"D:\ABShellSetting.conf"))
            //    loadSetting();
            /*
            UserSetting locUser = usersList.Find(x => x.name == Environment.UserName.ToString());
            if (locUser == null || !locUser.changeShell)
            {
                //if (MessageBox.Show("Start explorer", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //{
                    var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
                if (runningProcs.Count(p => p.ProcessName.Contains("explorer")) == 0)
                {
                    //var proc = new Process();
                    //proc.StartInfo.FileName = "C:\\Windows\\explorer.exe";
                    //proc.StartInfo.UseShellExecute = true;
                    //proc.Start();
                    setShell("explorer.exe");
                    var p = new ProcessStartInfo("cmd", "/r shutdown -f -r") { CreateNoWindow = true };
                    Process.Start(p);
                    //Process.Start(@"C:\Windows\explorer.exe");
                    Application.Exit();

                }
                //}
            }*/

            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher users = new ManagementObjectSearcher(query);
            foreach (ManagementObject user in users.Get())
            {
                //if (user.)
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
            Height = 135;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        public void saveSetting()
        {
            //StreamWriter swtr = new StreamWriter(Application.StartupPath + "\\ABShellSetting.conf", false);
            StreamWriter swtr = new StreamWriter(@"D:\ABShellSetting.conf", false);
            try
            {
                mainData = new MainData() { usersList = usersList, programsList = programsList };
                XmlSerializer xmlser = new XmlSerializer(typeof(MainData));
                xmlser.Serialize(swtr, mainData);
            }
            finally
            {
                swtr.Close();
            }
        }
        public void loadSetting()
        {
            //StreamReader srdr = new StreamReader(Application.StartupPath + "\\ABShellSetting.conf");
            StreamReader srdr = new StreamReader(@"D:\ABShellSetting.conf");
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
                UserSetting tmpUser = usersList.Find(x => x.name == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (tmpUser != null)
                {
                   // tmpUser.changeShell = (bool)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setShell("ABShell.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\regedit.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setShell("explorer.exe");
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
            foreach (var item in pnButtons.Controls)
            {
                if (item.GetType() == new ButtonNew().GetType())
                {
                    ((ButtonNew)item).setVisible(isSetting);
                    ((ButtonNew)item).Visible = isSetting || ((ButtonNew)item).getIsVisible();
                }
            }
            button1.Visible = isSetting;
            if (isSetting)
                Height = 310;
            else
                Height = 135;
        }

        private void buttonNew2_Load(object sender, EventArgs e)
        {
            Process.Start(@"C:\ABOFFICE\client\O4Client.exe");
        }

        private void buttonNew6_Load(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\excel.exe");
        }

        private void buttonNew1_Load(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\winword.exe");
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (isSetting)
                loadButton(button);
            else
                Process.Start(programsList.Find(x=> x.id == button.TabIndex).path);
        }

        private void loadButton(Button button)
        {
        }

        private void btUseShell_Click(object sender, EventArgs e)
        {
            btUseShell.LineVisible = !btUseShell.LineVisible;
            if (!btUseShell.LineVisible)
            {
                setShell(Application.ExecutablePath);
                label8.Text = "Заменить Windows Shell";
            }
            else
            {
                setShell("explorer.exe");
                label8.Text = "Разрешить Windows Shell";
            }
        }

        private void btDisp_Click(object sender, EventArgs e)
        {
            btDisp.LineVisible = !btDisp.LineVisible;
            if (!btUseShell.LineVisible)
            {
                setShell(Application.ExecutablePath);
                label6.Text = "Запретить диспечер задач";
            }
            else
            {
                setShell("explorer.exe");
                label6.Text = "Разрешить диспечер задач";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("explorer");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveValue("v", textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = LoadValue("v");
        }
    }
}
