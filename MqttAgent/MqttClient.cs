using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using uPLibrary.Networking.M2Mqtt;

namespace MqttAgent
{
    internal class ServerClient
    {
        string brokerAddr;
        int brokerPort;
        string login;
        string password;
        MqttClient client;


        public ServerClient(string brokerAddr, int brokerPort, string login, string password)
        {
            this.brokerAddr = brokerAddr;
            this.brokerPort = brokerPort;
            this.login = login;
            this.password = password;
        }

        public bool Connect()
        {

            return true;
        }

        public bool Disconnect()
        {

            return true;
        }
    }
}
