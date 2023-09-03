using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MqttAgent
{
    public partial class FormSettings : Form
    {
        SettingsOperate settingsOperate = new SettingsOperate();

        public FormSettings()
        {
            InitializeComponent();
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


        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingsOperate.SetServerAddrPort(textBoxServAddr.Text, int.Parse(textBoxServPort.Text));
            settingsOperate.SetServerLoginPassword(textBoxServLogin.Text, textBoxServPassw.Text);
            settingsOperate.SaveSettings();
        }
    }
}