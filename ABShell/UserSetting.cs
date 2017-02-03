using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABShell
{
    [Serializable]
    public class UserSetting
    {
        public string name;
        public bool changeShell;

        public UserSetting()
        {
            name = "";
            changeShell = false;
        }
    }
}

