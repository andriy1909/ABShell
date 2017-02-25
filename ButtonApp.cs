using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABShell
{
    public partial class ButtonApp : Button
    {
        public ButtonApp()
        {
            InitializeComponent();
        }

        public ButtonApp(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
