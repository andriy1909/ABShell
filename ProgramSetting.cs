﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABShell
{
    [Serializable]
    public class ProgramSetting
    {
        public int id;
        public string name;
        public string path;
        public Image image;
        public string login;
        public string password;
        public string server;
        public bool isVisible;

        public ProgramSetting()
        {

        }

        public void revers()
        {
            isVisible = !isVisible;
        }
    }
}

