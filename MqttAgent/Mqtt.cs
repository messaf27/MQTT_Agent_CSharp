using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// including the M2Mqtt Library
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MqttAgent
{
    internal class Mqtt : InterfaceClient
    {
        private string clientUniqID = "MqttAgentPC";
        private string? willTopic;
        private MqttClient? client;

        public bool Connect(string serv, int port, string login, string password)
        {
            this.willTopic = "status";

            Debug.WriteLine($"Client topic: {this.clientUniqID + "/" + this.willTopic}");

            this.client = new MqttClient(serv);
            if (!this.client.IsConnected)
            {
                client.Connect(clientUniqID,
                    login,
                    password,
                    willRetain: false, // true 
                    willTopic: this.clientUniqID + "/" + this.willTopic,
                    willMessage: "offline",
                    //willQosLevel: MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
                    willQosLevel: MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE,
                    willFlag: true,
                    cleanSession: true,
                    keepAlivePeriod: 15);
            }

            if (this.client.IsConnected)
                client.Publish(this.clientUniqID + "/" + this.willTopic, Encoding.UTF8.GetBytes("online"));

            return this.client.IsConnected;
        }

        public bool Connect(string serv, int port, string login, string password, string willTopic, string willMessage)
        {
            this.client = new MqttClient(serv);
            this.willTopic = willTopic;

            Debug.WriteLine($"Client topic: {this.clientUniqID + "/" + this.willTopic}");

            if (!this.client.IsConnected)
            {
                this.client.Connect(clientUniqID,
                    login,
                    password,
                    willRetain: false, // true 
                    willTopic: this.clientUniqID + "/" + this.willTopic,
                    willMessage: willMessage,
                    //willQosLevel: MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
                    willQosLevel: MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE,
                    willFlag: true,
                    cleanSession: true,
                    keepAlivePeriod: 15);
            }

            if (this.client.IsConnected)
                this.client.Publish(this.clientUniqID + "/" + this.willTopic, Encoding.UTF8.GetBytes("online"));

            return this.client.IsConnected;
        }

        public bool Disconnect()
        {
            this.client.Publish(this.clientUniqID + "/" + this.willTopic, Encoding.UTF8.GetBytes("offline"));
            this.client.Disconnect();

            return this.client.IsConnected;
        }

        public bool IsConnected()
        {
            return this.client.IsConnected;
        }

        public bool Publish(string topic, string message)
        {
            int msgId = client.Publish(this.clientUniqID + "/" + topic, Encoding.UTF8.GetBytes(message));

            if (msgId == 0)
                return false;

            return true;
        }
    }
}
