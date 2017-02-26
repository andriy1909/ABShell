using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABShell
{
    public partial class CheckBox2 : UserControl
    {
        string text;
        bool isChecked;

        public string SetText
        {
            get
            {
                return text;
            }
            set
            {
                lbText.Text = value;
                text = value;
            }
        }

        public bool Checked
        {
            get
            {
                return isChecked;
            }
            set
            {
                pbOn.Visible = value;
                pbOff.Visible = !value;
                isChecked = value;
            }
        }

        public CheckBox2()
        {
            InitializeComponent();
        }

        private void CheckBox2_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
        }
    }
}
