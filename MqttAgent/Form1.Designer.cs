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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            btnSave = new Button();
            agentIconTray = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            SettingsToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            textBoxServPassw = new TextBox();
            textBoxServLogin = new TextBox();
            label2 = new Label();
            textBoxServPort = new TextBox();
            label4 = new Label();
            textBoxServAddr = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            groupBox3 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(275, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // agentIconTray
            // 
            agentIconTray.Icon = (Icon)resources.GetObject("agentIconTray.Icon");
            agentIconTray.Text = "MQTT Agent";
            agentIconTray.Visible = true;
            agentIconTray.MouseClick += agentIconTray_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { SettingsToolStripMenuItem, ExitToolStripMenuItem, AboutToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(150, 70);
            // 
            // SettingsToolStripMenuItem
            // 
            SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            SettingsToolStripMenuItem.Size = new Size(149, 22);
            SettingsToolStripMenuItem.Text = "Настройки";
            SettingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(149, 22);
            ExitToolStripMenuItem.Text = "Выход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(149, 22);
            AboutToolStripMenuItem.Text = "О программе";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxServPassw);
            groupBox1.Controls.Add(textBoxServLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxServPort);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxServAddr);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 89);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки сервера:";
            // 
            // textBoxServPassw
            // 
            textBoxServPassw.Location = new Point(221, 50);
            textBoxServPassw.Name = "textBoxServPassw";
            textBoxServPassw.Size = new Size(109, 23);
            textBoxServPassw.TabIndex = 1;
            // 
            // textBoxServLogin
            // 
            textBoxServLogin.Location = new Point(59, 50);
            textBoxServLogin.Name = "textBoxServLogin";
            textBoxServLogin.Size = new Size(95, 23);
            textBoxServLogin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "Порт:";
            // 
            // textBoxServPort
            // 
            textBoxServPort.Location = new Point(273, 16);
            textBoxServPort.Name = "textBoxServPort";
            textBoxServPort.Size = new Size(57, 23);
            textBoxServPort.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 53);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 0;
            label4.Text = "Пароль:";
            // 
            // textBoxServAddr
            // 
            textBoxServAddr.Location = new Point(111, 16);
            textBoxServAddr.Name = "textBoxServAddr";
            textBoxServAddr.Size = new Size(112, 23);
            textBoxServAddr.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 53);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Логин:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "IP (URL) сервера:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 79);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Настройки топика:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(111, 45);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(171, 23);
            textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(111, 16);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 23);
            textBox5.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 48);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 0;
            label6.Text = "Данные (JSON):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 19);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 0;
            label5.Text = "Статус топик:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "ПК онлайн статус";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Location = new Point(12, 210);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(338, 75);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Отправляемая информация:";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(181, 50);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(118, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Температура ЦП";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(181, 22);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(95, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Загрузка ЦП";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 326);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MQTT Agent";
            Deactivate += FormSettings_Deactivate;
            FormClosing += FormSettings_FormClosing;
            Load += FormSettings_Load;
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private CheckBox checkBox1;
        private GroupBox groupBox3;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private TextBox textBoxServLogin;
        private Label label2;
        private TextBox textBoxServAddr;
        private Label label1;
        private TextBox textBoxServPassw;
        private TextBox textBoxServPort;
        private Label label4;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
    }
}