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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            Location = Cursor.Position;
        }
        public void setPassword(string value)
        {
            textBox1.Text = value;
        }
        public string getPassword()
        {
            return textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                panel2.Visible = true;
        }

        private static string Encoder(string input)
        {
            string str2 = null;
            foreach (char ch in input)
            {
                char tempChar = (char)(ch ^ 5);
                str2 += (int)tempChar + 4 + "x";
            }
            return str2.Substring(0, str2.Length - 1);
        }

        private static string Decoder(string input)
        {
            string[] splitted = input.Split(new char[] { 'x' });
            string tempString = null;
            foreach (string str in splitted)
            {
                int tempInt = Convert.ToInt32(str) - 5;
                tempString += (char)(tempInt ^ 4);
            }
            return tempString;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2.PerformClick();
        }
    }
}
