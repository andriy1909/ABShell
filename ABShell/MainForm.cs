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
        private List<UserSetting> usersList;

        public MainForm()
        {
            InitializeComponent();
            usersList = new List<UserSetting>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (File.Exists(Application.StartupPath + "\\ABShellSetting.conf"))
            if (File.Exists(@"D:\ABShellSetting.conf"))
                loadSetting();
            UserSetting locUser = usersList.Find(x => x.name == Environment.UserName.ToString());
            if (locUser == null || !locUser.changeShell)
            {
                //if (MessageBox.Show("Start explorer", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //{
                    var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
                if (runningProcs.Count(p => p.ProcessName.Contains("explorer")) == 0)
                {
                    /*var proc = new Process();
                    proc.StartInfo.FileName = "C:\\Windows\\explorer.exe";
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();*/
                    setShell("explorer.exe");
                    var p = new ProcessStartInfo("cmd", "/r shutdown -f -r") { CreateNoWindow = true };
                    Process.Start(p);
                    //Process.Start(@"C:\Windows\explorer.exe");
                    Application.Exit();

                }
                //}
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            /*RegistryKey hklm = Registry.LocalMachine;
            RegistryKey hkSoftware = hklm.OpenSubKey("Software");
            RegistryKey hkMicrosoft = hkSoftware.OpenSubKey("Microsoft");
            RegistryKey hkWindowsNT = hkMicrosoft.OpenSubKey("Windows NT");
            RegistryKey hkCurrentVersion = hkWindowsNT.OpenSubKey("CurrentVersion");
            RegistryKey hkWinlogon = hkCurrentVersion.OpenSubKey("Winlogon", true);
            hkWinlogon.SetValue("Shell", "ABShell.exe");
            MessageBox.Show(hkWinlogon.GetValue("Shell").ToString());*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*RegistryKey hklm = Registry.LocalMachine;
            RegistryKey hkSoftware = hklm.OpenSubKey("Software");
            RegistryKey hkMicrosoft = hkSoftware.OpenSubKey("Microsoft");
            RegistryKey hkWindowsNT = hkMicrosoft.OpenSubKey("Windows NT");
            RegistryKey hkCurrentVersion = hkWindowsNT.OpenSubKey("CurrentVersion");
            RegistryKey hkWinlogon = hkCurrentVersion.OpenSubKey("Winlogon", true);
            hkWinlogon.SetValue("Shell", "explorer.exe");
            MessageBox.Show(hkWinlogon.GetValue("Shell").ToString());*/
        }

        public void saveSetting()
        {
            //StreamWriter swtr = new StreamWriter(Application.StartupPath + "\\ABShellSetting.conf", false);
            StreamWriter swtr = new StreamWriter(@"D:\ABShellSetting.conf", false);
            try
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(List<UserSetting>));
                xmlser.Serialize(swtr, usersList);
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
                XmlSerializer xmlser = new XmlSerializer(typeof(List<UserSetting>));
                usersList = (List<UserSetting>)xmlser.Deserialize(srdr);
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
            if (e.ColumnIndex==1 && e.RowIndex >=0)
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
    }
}
