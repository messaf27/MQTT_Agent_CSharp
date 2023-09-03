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
using static System.Net.Mime.MediaTypeNames;

namespace MqttAgent
{
    public class SettingsParametres
    {
        //public DateTimeOffset Date { get; set; }
        public string? ServerName { get; set; }
        public int ServerPort { get; set; }
        public string? ServerLogin { get; set; }
        public string? ServerPassw { get; set; }
        //public string? StatusTopic { get; set; }
        //public string? DataTopic { get; set; }
        //public bool OnlineStatusEnable { get; set; }
        //public bool CPULoadEnable { get; set; }
        //public bool CPUTempEnable { get; set; }
    }

    internal class SettingsOperate
    {
        const string settingsFolderName = "Settings";  // для Windows
        const string settingsFileName = "config.cfg";  // 
        string settingFolderPath = "";

        private string serverName = "";
        private int serverPort = 1884;
        private string serverLogin = "";
        private string serverPassword = "";

        public SettingsOperate()
        {
            //settingFolderPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFolderName);
            settingFolderPath = Path.Combine(@"c:\", settingsFolderName);
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

        public string GetServerName()
        {
            return serverName;
        }

        public int GetServerPort()
        {
            return serverPort;
        }

        public string GetServerLogin()
        {
            return serverLogin;
        }

        public string GetServerPassword() 
        { 
            return serverPassword;
        }

        public async Task<bool> SaveSettingsAsync()
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

            //try
            //{
            //    FileInfo fileInfo = new FileInfo(Path.Combine(settingFolderPath, settingsFileName));
            //    StreamWriter sw = fileInfo.CreateText();
            //    sw.WriteLine(jsonSettingsString);
            //    sw.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return false;
            //}

            if (!Directory.Exists(settingFolderPath))
            {
                Directory.CreateDirectory(settingFolderPath);
                Debug.WriteLine($"Create Settings Folder: {settingFolderPath}");
            }

            if (File.Exists(Path.Combine(settingFolderPath, settingsFileName)))
            {
                File.Delete(Path.Combine(settingFolderPath, settingsFileName));
            }

            // запись в файл
            using (FileStream fstream = new FileStream(Path.Combine(settingFolderPath, settingsFileName), FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] buffer = Encoding.Default.GetBytes(jsonSettingsString);
                // запись массива байтов в файл
                await fstream.WriteAsync(buffer);
            }

            return true;
        }

        public async Task<bool> ReadSettingsAsync()
        {
            if(File.Exists(Path.Combine(settingFolderPath, settingsFileName)))
            {
                // чтение из файла
                using (FileStream fstream = File.OpenRead(Path.Combine(settingFolderPath, settingsFileName)))
                {
                    // выделяем массив для считывания данных из файла
                    byte[] buffer = new byte[fstream.Length];
                    // считываем данные
                    await fstream.ReadAsync(buffer);
                    // декодируем байты в строку
                    string jsonString = Encoding.Default.GetString(buffer);

                    Console.WriteLine($"Текст из файла: {jsonString}");

                    SettingsParametres settingsParametres = JsonSerializer.Deserialize<SettingsParametres>(jsonString);

                    this.serverName = settingsParametres.ServerName;
                    this.serverPort = settingsParametres.ServerPort;
                    this.serverLogin = settingsParametres.ServerLogin;
                    this.serverPassword = settingsParametres.ServerPassw;

                    Debug.WriteLine($"ServerName: {this.serverName}");
                    Debug.WriteLine($"ServerPort: {this.serverPort}");
                    Debug.WriteLine($"ServerLogin: {this.serverLogin}");
                    Debug.WriteLine($"ServerPassw: {this.serverPassword}");
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
