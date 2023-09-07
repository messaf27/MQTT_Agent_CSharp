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
        private string clientUniqID = Environment.MachineName;
        private string? willTopic;
        private MqttClient? client;

        public bool Connect(string clientName, string serv, int port, string login, string password)
        {
            this.clientUniqID = clientName;
            this.willTopic = "status";

            Debug.WriteLine($"Client topic: {this.clientUniqID + "/" + this.willTopic}");

            this.client = new MqttClient(serv);

            try
            {
                if (!this.client.IsConnected)
                {
                    client.Connect(clientUniqID,
                        login,
                        password,
                        willRetain: true, 
                        willTopic: this.clientUniqID + "/" + this.willTopic,
                        willMessage: "offline",
                        willQosLevel: MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
                        //willQosLevel: MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE,
                        willFlag: true,
                        cleanSession: true,
                        keepAlivePeriod: 15);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Connection failure: {ex.Message}");
            }



            if (this.client.IsConnected)
                client.Publish(this.clientUniqID + "/" + this.willTopic, Encoding.UTF8.GetBytes("online"));

            return this.client.IsConnected;
        }

        public bool Connect(string clientName, string serv, int port, string login, string password, string willTopic)
        {
            this.client = new MqttClient(serv);
            this.clientUniqID = clientName;
            this.willTopic = willTopic;

            Debug.WriteLine($"Client topic: {this.clientUniqID + "/" + this.willTopic}");

            try
            {
                if (!this.client.IsConnected)
                {
                    this.client.Connect(clientUniqID,
                        login,
                        password,
                        willRetain: true, 
                        willTopic: this.clientUniqID + "/" + this.willTopic,
                        willMessage: "offline",
                        willQosLevel: MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
                        //willQosLevel: MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE,
                        willFlag: true,
                        cleanSession: true,
                        keepAlivePeriod: 15);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Connection failure: {ex.Message}");
            }

            if (this.client.IsConnected)
                this.client.Publish(this.clientUniqID + "/" + this.willTopic, Encoding.UTF8.GetBytes("online"));

            return this.client.IsConnected;
        }

        public bool Disconnect()
        {
            try 
            {
                this.client.Publish(this.clientUniqID + "/" + this.willTopic, Encoding.UTF8.GetBytes("offline"));
                this.client.Disconnect();
            }
            catch
            {
                Debug.WriteLine("Disconnect failure");
            }

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
