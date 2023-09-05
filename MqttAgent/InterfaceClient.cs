using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttAgent
{
    internal interface InterfaceClient
    {
        public bool Connect(string clientName, string serv, int port, string login, string password);
        public bool Connect(string clientName, string serv, int port, string login, string password, string willTopic);
        public bool IsConnected();
        public bool Disconnect();
        public bool Publish(string topic, string message);
    }
}
