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
    public partial class ButtonRedLine : UserControl
    {
        private bool LineVisible { get; set; }
        public ButtonRedLine()
        {
            InitializeComponent();
            LineVisible = false;
        }

        private void imgRedLine_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void ButtonRedLine_Click(object sender, EventArgs e)
        {
            //imgLine.Visible = !imgLine.Visible;
        }
        public void setLinevisible(bool value)
        {
            imgLine.Visible = value;
        }
        public bool getLinevisible()
        {
            return imgLine.Visible;
        }
    }
}
