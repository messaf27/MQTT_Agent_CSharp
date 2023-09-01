using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace MqttAgent
{
    internal class SettingsOperate
    {
        const string settingsFolderName = "Settings";  // для Windows
        string settingFolderPath = ""; 

        public SettingsOperate()
        {
            settingFolderPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), settingsFolderName);
            Debug.WriteLine("Folder for settings: " + settingFolderPath);

        }

        public void setServerAddr(string addr)
        {

        }

        public void setServerPort(int port)
        {

        }
    }
}
