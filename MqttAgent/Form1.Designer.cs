namespace MqttAgent
{
    partial class FormSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.btnSave = new System.Windows.Forms.Button();
            this.agentIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxServPassw = new System.Windows.Forms.TextBox();
            this.textBoxServLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxServAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.textBoxTopicJsonDataset = new System.Windows.Forms.TextBox();
            this.textBoxTopicStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxPcOnlineStatusEnable = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxCPUTempEnable = new System.Windows.Forms.CheckBox();
            this.checkBoxCPULoadEnable = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // agentIconTray
            // 
            this.agentIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("agentIconTray.Icon")));
            this.agentIconTray.Text = "MQTT Agent";
            this.agentIconTray.Visible = true;
            this.agentIconTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.agentIconTray_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.ExitToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 70);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxServPassw);
            this.groupBox1.Controls.Add(this.textBoxServLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxServPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxServAddr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки сервера:";
            // 
            // textBoxServPassw
            // 
            this.textBoxServPassw.Location = new System.Drawing.Point(223, 51);
            this.textBoxServPassw.Name = "textBoxServPassw";
            this.textBoxServPassw.Size = new System.Drawing.Size(109, 23);
            this.textBoxServPassw.TabIndex = 4;
            // 
            // textBoxServLogin
            // 
            this.textBoxServLogin.Location = new System.Drawing.Point(61, 51);
            this.textBoxServLogin.Name = "textBoxServLogin";
            this.textBoxServLogin.Size = new System.Drawing.Size(95, 23);
            this.textBoxServLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Порт:";
            // 
            // textBoxServPort
            // 
            this.textBoxServPort.Location = new System.Drawing.Point(275, 17);
            this.textBoxServPort.Name = "textBoxServPort";
            this.textBoxServPort.Size = new System.Drawing.Size(57, 23);
            this.textBoxServPort.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пароль:";
            // 
            // textBoxServAddr
            // 
            this.textBoxServAddr.Location = new System.Drawing.Point(113, 17);
            this.textBoxServAddr.Name = "textBoxServAddr";
            this.textBoxServAddr.Size = new System.Drawing.Size(112, 23);
            this.textBoxServAddr.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP (URL) сервера:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxClientID);
            this.groupBox2.Controls.Add(this.textBoxTopicJsonDataset);
            this.groupBox2.Controls.Add(this.textBoxTopicStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки топика:";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(113, 22);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(171, 23);
            this.textBoxClientID.TabIndex = 5;
            // 
            // textBoxTopicJsonDataset
            // 
            this.textBoxTopicJsonDataset.Location = new System.Drawing.Point(113, 80);
            this.textBoxTopicJsonDataset.Name = "textBoxTopicJsonDataset";
            this.textBoxTopicJsonDataset.Size = new System.Drawing.Size(171, 23);
            this.textBoxTopicJsonDataset.TabIndex = 7;
            // 
            // textBoxTopicStatus
            // 
            this.textBoxTopicStatus.Location = new System.Drawing.Point(113, 51);
            this.textBoxTopicStatus.Name = "textBoxTopicStatus";
            this.textBoxTopicStatus.Size = new System.Drawing.Size(171, 23);
            this.textBoxTopicStatus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Данные (JSON):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Статус топик:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Клиент ID:";
            // 
            // checkBoxPcOnlineStatusEnable
            // 
            this.checkBoxPcOnlineStatusEnable.AutoSize = true;
            this.checkBoxPcOnlineStatusEnable.Location = new System.Drawing.Point(6, 22);
            this.checkBoxPcOnlineStatusEnable.Name = "checkBoxPcOnlineStatusEnable";
            this.checkBoxPcOnlineStatusEnable.Size = new System.Drawing.Size(123, 19);
            this.checkBoxPcOnlineStatusEnable.TabIndex = 8;
            this.checkBoxPcOnlineStatusEnable.Text = "ПК онлайн статус";
            this.checkBoxPcOnlineStatusEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxCPUTempEnable);
            this.groupBox3.Controls.Add(this.checkBoxCPULoadEnable);
            this.groupBox3.Controls.Add(this.checkBoxPcOnlineStatusEnable);
            this.groupBox3.Location = new System.Drawing.Point(12, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 75);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отправляемая информация:";
            // 
            // checkBoxCPUTempEnable
            // 
            this.checkBoxCPUTempEnable.AutoSize = true;
            this.checkBoxCPUTempEnable.Location = new System.Drawing.Point(181, 50);
            this.checkBoxCPUTempEnable.Name = "checkBoxCPUTempEnable";
            this.checkBoxCPUTempEnable.Size = new System.Drawing.Size(118, 19);
            this.checkBoxCPUTempEnable.TabIndex = 10;
            this.checkBoxCPUTempEnable.Text = "Температура ЦП";
            this.checkBoxCPUTempEnable.UseVisualStyleBackColor = true;
            // 
            // checkBoxCPULoadEnable
            // 
            this.checkBoxCPULoadEnable.AutoSize = true;
            this.checkBoxCPULoadEnable.Location = new System.Drawing.Point(181, 22);
            this.checkBoxCPULoadEnable.Name = "checkBoxCPULoadEnable";
            this.checkBoxCPULoadEnable.Size = new System.Drawing.Size(95, 19);
            this.checkBoxCPULoadEnable.TabIndex = 9;
            this.checkBoxCPULoadEnable.Text = "Загрузка ЦП";
            this.checkBoxCPULoadEnable.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 372);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MQTT Agent";
            this.Deactivate += new System.EventHandler(this.FormSettings_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSettings_FormClosed);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSave;
        private NotifyIcon agentIconTray;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem SettingsToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox checkBoxPcOnlineStatusEnable;
        private GroupBox groupBox3;
        private CheckBox checkBoxCPUTempEnable;
        private CheckBox checkBoxCPULoadEnable;
        private TextBox textBoxServLogin;
        private Label label2;
        private TextBox textBoxServAddr;
        private Label label1;
        private TextBox textBoxServPassw;
        private TextBox textBoxServPort;
        private Label label4;
        private Label label3;
        private TextBox textBoxTopicJsonDataset;
        private TextBox textBoxTopicStatus;
        private Label label6;
        private Label label5;
        private TextBox textBoxClientID;
        private Label label7;
    }
}