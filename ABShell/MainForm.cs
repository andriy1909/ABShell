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
using System.Runtime.InteropServices;

namespace ABShell
{
    public partial class MainForm : Form
    {
        private bool isSetting = false;
        private MainData mainData;
        private List<UserSetting> usersList;
        private List<ProgramSetting> programsList;

        public MainForm()
        {
            InitializeComponent();
            usersList = new List<UserSetting>();
            programsList = new List<ProgramSetting>();
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
                UserSetting tmpUser = usersList.Find(x => x.name == user["Name"].ToString());
                if (tmpUser == null)
                {
                    usersList.Add(new UserSetting() { name = user["Name"].ToString() });
                    dataGridView1.Rows.Add(new object[] { user["Name"], false });
                }
                else
                {
                    dataGridView1.Rows.Add(new object[] { tmpUser.name, tmpUser.changeShell });
                }
            }
            Height = 133;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process.Start(@"C:\Windows\explorer.exe");
            var proc = new Process();
            proc.StartInfo.FileName = "C:\\Windows\\explorer.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ABOFFICE\client\O4Client.exe");
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
                    tmpUser.changeShell = (bool)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
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
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey hkSoftware = hklm.OpenSubKey("Software");
            RegistryKey hkMicrosoft = hkSoftware.OpenSubKey("Microsoft");
            RegistryKey hkWindowsNT = hkMicrosoft.OpenSubKey("Windows NT");
            RegistryKey hkCurrentVersion = hkWindowsNT.OpenSubKey("CurrentVersion");
            RegistryKey hkWinlogon = hkCurrentVersion.OpenSubKey("Winlogon", true);
            hkWinlogon.SetValue("Shell", name);
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
                Height = 328;
            else
                Height = 133;
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
            if (isSetting)
                loadButton(sender as Button);
            else
                Process.Start();
        }

        private void loadButton(Button button)
        {
        }
    }
}
