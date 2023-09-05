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
    struct ApplicationOptions 
    { 
        public string servAddr;
        public int servPort;
        public string servLogin;
        public string servPassword;
        public string machineName;
        public string topicOnlineStatus;
        public string topicDataSet;
        public bool onlineStatusEnable;
        public bool CpuLoadEnable;
        public bool CpuTemperEnable;
    }

    public class SettingsParametres
    {
        //public DateTimeOffset Date { get; set; }
        public string? ServerName { get; set; }
        public int ServerPort { get; set; }
        public string? ServerLogin { get; set; }
        public string? ServerPassw { get; set; }
        public string? MachineName { get; set; }
        public string? StatusTopic { get; set; }
        public string? DataTopic { get; set; }
        public bool OnlineStatusEnable { get; set; }
        public bool CPULoadEnable { get; set; }
        public bool CPUTempEnable { get; set; }
    }

    internal class SettingsOperate
    {
        const string settingsFolderName = "Settings";  // для Windows
        const string settingsFileName = "config.cfg";  // 
        string settingFolderPath = "";

        public SettingsOperate()
        {
            //settingFolderPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFolderName);
            settingFolderPath = Path.Combine(@"C:\", settingsFolderName);
            Debug.WriteLine("Folder for settings: " + settingFolderPath);
        }

        public async Task<bool> SaveOptionsAsync(ApplicationOptions options)
        {
            var settingsParametres = new SettingsParametres()
            {
                ServerName = options.servAddr,
                ServerPort = options.servPort,
                ServerLogin = options.servLogin,
                ServerPassw = options.servPassword,
                MachineName = options.machineName,
                StatusTopic = options.topicOnlineStatus,
                DataTopic = options.topicDataSet,
                OnlineStatusEnable = options.onlineStatusEnable,
                CPULoadEnable = options.CpuLoadEnable,
                CPUTempEnable = options.CpuTemperEnable
            };

            string jsonSettingsString = JsonSerializer.Serialize(settingsParametres);
            Debug.WriteLine($"JSON: {jsonSettingsString}");

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

        public async Task<ApplicationOptions> ReadOptionsAsync()
        {
            var options = new ApplicationOptions();

            if (File.Exists(Path.Combine(settingFolderPath, settingsFileName)))
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

                    options.servAddr = settingsParametres.ServerName;
                    options.servPort = settingsParametres.ServerPort;
                    options.servLogin = settingsParametres.ServerLogin;
                    options.servPassword = settingsParametres.ServerPassw;
                    options.machineName = settingsParametres.MachineName;
                    options.topicOnlineStatus = settingsParametres.StatusTopic;
                    options.topicDataSet = settingsParametres.DataTopic;
                    options.onlineStatusEnable = (bool)settingsParametres.OnlineStatusEnable;
                    options.CpuLoadEnable = (bool)settingsParametres.CPULoadEnable;
                    options.CpuTemperEnable = (bool)settingsParametres.CPUTempEnable;

                    Debug.WriteLine($"ServerName: {options.servAddr}");
                    Debug.WriteLine($"ServerPort: {options.servPort}");
                    Debug.WriteLine($"ServerLogin: {options.servLogin}");
                    Debug.WriteLine($"ServerPassw: {options.servPassword}");
                    Debug.WriteLine($"MachineName: {options.machineName}");
                    Debug.WriteLine($"onlineStatusEnable: {options.onlineStatusEnable}");
                    Debug.WriteLine($"topicDataSet: {options.topicDataSet}");
                    Debug.WriteLine($"onlineStatusEnable: {options.onlineStatusEnable}");
                    Debug.WriteLine($"CpuLoadEnable: {options.CpuLoadEnable}");
                    Debug.WriteLine($"CpuTemperEnable: {options.CpuTemperEnable}");
                }
            }

            return options;
        }
    }
}
