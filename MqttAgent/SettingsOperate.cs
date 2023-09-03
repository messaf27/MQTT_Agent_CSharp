using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Windows.Forms.Design.AxImporter;

namespace MqttAgent
{
    public class SettingsParametres
    {
        //public DateTimeOffset Date { get; set; }
        public string? ServerName { get; set; }
        public int ServerPort { get; set; }
        public string? ServerLogin { get; set; }
        public string? ServerPassw { get; set; }
        public string? StatusTopic { get; set; }
        //public string? DataTopic { get; set; }
        //public bool OnlineStatusEnable { get; set; }
        //public bool CPULoadEnable { get; set; }
        //public bool CPUTempEnable { get; set; }
    }

    internal class SettingsOperate
    {
        const string settingsFolderName = "Settings";  // для Windows
        string settingFolderPath = "";

        private string serverName = "";
        private int serverPort = 1884;
        private string serverLogin = "";
        private string serverPassword = "";

        public SettingsOperate()
        {
            settingFolderPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFolderName);
            Debug.WriteLine("Folder for settings: " + settingFolderPath);
        }

        public void SetServerAddrPort(string addr, int port)
        {
            serverName = addr;
            serverPort = port;
        }

        public void SetServerLoginPassword(string login, string password)
        {
            serverLogin = login;
            serverPassword = password;
        }

        public bool SaveSettings()
        {
            var settingsParametres = new SettingsParametres()
            {
                ServerName = this.serverName,
                ServerPort = this.serverPort,
                ServerLogin = this.serverLogin,
                ServerPassw = this.serverPassword
            };

            string jsonSettingsString = JsonSerializer.Serialize(settingsParametres);
            Debug.WriteLine($"JSON: {jsonSettingsString}");

            return true;
        }
    }
}
