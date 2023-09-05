using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Windows.Forms.Design.AxImporter;

namespace MqttAgent
{
    public class Pc
    {
        public string? cpu { get; set; }
        public string? ram { get; set; }
        public string? uptime { get; set; }
        //public string? TempZone { get; set; }
    }

    internal class StatusPC
    {
        PerformanceCounter perfCpuCount;
        PerformanceCounter perfMemCount;
        PerformanceCounter perfUptimeCount;
        //PerformanceCounter perfTempZone;

        public StatusPC() 
        {
            //cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            //ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            perfCpuCount = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            perfMemCount = new PerformanceCounter("Memory", "Available Mbytes");
            perfUptimeCount = new PerformanceCounter("System", "System Up Time");
            //perfTempZone = new PerformanceCounter("Thermal Zone Information", "Temperature", @"\_TZ.TZ00");
        }

        public string getJsonFormat()
        {
            string jsData = "";

            var pc = new Pc()
            {
                cpu = $"{(int)perfCpuCount.NextValue()}",
                ram = $"{(int)perfMemCount.NextValue()}",
                uptime = $"{perfUptimeCount.NextValue()}",
                //TempZone = $"{(int)perfTempZone.NextValue()}",
            };

            jsData = JsonSerializer.Serialize(pc);
            Debug.WriteLine($"JSON: {jsData}");

            return jsData;
        }
    }
}
