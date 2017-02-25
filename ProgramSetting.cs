using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ABShell
{
    [Serializable]
    public class ProgramSetting
    {
        public int id;
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

        public void setSetting(ButtonApp button)
        {
            id = button.id;
            path = button.path;
            image = button.image;
            login = button.login;
            password = button.password;
            server = button.server;
            isVisible = button.isVisible;
        }
        public ButtonApp getButton()
        {
            ButtonApp button = new ButtonApp();
            button.id = id;
            button.path = path;
            button.password = password;
            button.image = image;
            button.login = login;
            button.server = server;
            button.isVisible = isVisible;
            return button;
        }
    }
}

