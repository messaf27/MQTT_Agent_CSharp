using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace MqttAgent
{
    public partial class FormSettings : Form
    {
        SettingsOperate settingsOperate = new SettingsOperate();
        ApplicationOptions applicationOptions = new ApplicationOptions();
        Mqtt client = new Mqtt();
        Thread clientThread;
        bool clientThreadEnable;

        public void Connect()
        {
            Debug.WriteLine("Mqttt disconnected begin connection...");

            bool result = client.Connect(applicationOptions.servAddr,
                                            applicationOptions.servPort,
                                            applicationOptions.servLogin,
                                            applicationOptions.servPassword);

            Debug.WriteLine($"Mqtt connect result: {result}");
        }

        public void ClientStart()
        {
            Debug.WriteLine("Client Start.");
            //clientThread = new Thread(new ParameterizedThreadStart(ClientApp));
            clientThread = new Thread(ClientApp);
            clientThreadEnable = true;
            clientThread.Start();
        }

        public void ClientStop()
        {
            Debug.WriteLine("Client Stop.");
            //clientThread.Abort();
            clientThreadEnable = false;
            clientThread.Join(500);

            client.Disconnect();
        }

        public void ClientRestart()
        {
            Debug.WriteLine("Client ReStart.");
            ClientStop();
            ClientStart();
        }

        public void ClientApp()
        {
            UInt32 pubCounter = 0;
            UInt16 pubTimeout = 0;

            Connect();

            while (clientThreadEnable)
            {
                //Debug.WriteLine("Loop Thread...");

                if (client.IsConnected())
                {
                    if(pubTimeout >= 50) // 5 seconds
                    {
                        pubCounter++;
                        client.Publish(applicationOptions.topicDataSet, $"Test dataset: {pubCounter}");
                        Debug.WriteLine($"Publish loop: {pubCounter}");

                        pubTimeout = 0;
                    }
                }
                else
                {
                    Connect();
                    pubTimeout = 0;
                }

                Thread.Sleep(100);
                pubTimeout++;
            }
        }

        public FormSettings()
        {
            InitializeComponent();
            //this.Icon = Res
            Debug.WriteLine("Start MQTT Agent");
        }

        private void FormSettings_Deactivate(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                agentIconTray.Visible = true;
            }
        }

        private async void FormSettings_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            applicationOptions = await settingsOperate.ReadOptionsAsync();

            textBoxServAddr.Text = applicationOptions.servAddr;
            textBoxServPort.Text = applicationOptions.servPort.ToString();
            textBoxServLogin.Text = applicationOptions.servLogin;
            textBoxServPassw.Text = applicationOptions.servPassword;
            textBoxTopicStatus.Text = applicationOptions.topicOnlineStatus;
            textBoxTopicJsonDataset.Text = applicationOptions.topicDataSet;

            checkBoxPcOnlineStatusEnable.Checked = applicationOptions.onlineStatusEnable;
            checkBoxCPULoadEnable.Checked = applicationOptions.CpuLoadEnable;
            checkBoxCPUTempEnable.Checked = applicationOptions.CpuTemperEnable;

            ClientStart();
        }

        private void agentIconTray_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    if (this.WindowState == FormWindowState.Minimized)
            //    {
            //        this.WindowState = FormWindowState.Normal;
            //        this.ShowInTaskbar = true;
            //        agentIconTray.Visible = false;
            //    }
            //}

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                agentIconTray.Visible = true;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                agentIconTray.Visible = false;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            applicationOptions.servAddr = textBoxServAddr.Text;
            applicationOptions.servPort = int.Parse(textBoxServPort.Text);
            applicationOptions.servLogin = textBoxServLogin.Text;
            applicationOptions.servPassword = textBoxServPassw.Text;
            applicationOptions.topicOnlineStatus = textBoxTopicStatus.Text;
            applicationOptions.topicDataSet = textBoxTopicJsonDataset.Text;
            applicationOptions.onlineStatusEnable = checkBoxPcOnlineStatusEnable.Checked;
            applicationOptions.CpuLoadEnable = checkBoxCPULoadEnable.Checked;
            applicationOptions.CpuTemperEnable = checkBoxCPUTempEnable.Checked;

            await settingsOperate.SaveOptionsAsync(applicationOptions);

            ClientRestart();
        }

        private void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClientStop();
        }
    }
}