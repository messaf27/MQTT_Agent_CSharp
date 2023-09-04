﻿using System;
using System.Collections.Generic;
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
        private MqttClient client;
        private string idClient = "MqttAgentPC";
        private string willTopic;

        public bool Connect(string serv, int port, string login, string password)
        {
            this.willTopic = "status/";

            this.client = new MqttClient(serv);
            if (!this.client.IsConnected)
            {
                client.Connect("MqttAgentPC",
                    login,
                    password,
                    willRetain: true,
                    willTopic: this.idClient + "/" + this.willTopic,
                    willMessage: "offline",
                    willQosLevel: MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
                    willFlag: true,
                    cleanSession: true,
                    keepAlivePeriod: 15);
            }

            return true;
        }

        public bool Connect(string serv, int port, string login, string password, string willTopic, string willMessage)
        {
            this.client = new MqttClient(serv);
            this.willTopic = willTopic;

            if (!this.client.IsConnected)
            {
                client.Connect("MqttAgentPC", 
                    login, 
                    password, 
                    willRetain:true, 
                    willTopic:this.idClient + "/" + this.willTopic, 
                    willMessage:willMessage, 
                    willQosLevel: MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
                    willFlag:true,
                    cleanSession:true,
                    keepAlivePeriod:15);
            }

            return this.client.IsConnected;
        }

        public bool Disconnect()
        {
            client.Publish(this.idClient + "/" + this.willTopic, Encoding.UTF8.GetBytes("offline"));
            client.Disconnect();

            return this.client.IsConnected;
        }

        public bool Publish(string topic, string message)
        {
            int msgId = client.Publish(topic, Encoding.UTF8.GetBytes(message));

            if (msgId == 0)
                return false;

            return true;
        }
    }
}
