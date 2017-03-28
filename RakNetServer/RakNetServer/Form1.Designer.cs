namespace RakNetServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_seq = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_sendback = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listReceivedData = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.发送字符ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkOccucationalPing = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMaxConn = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listSendersInfo = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusGUID = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox_print = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxConn)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_print);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBox_seq);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox_sendback);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "响应处理";
            // 
            // checkBox_seq
            // 
            this.checkBox_seq.AutoSize = true;
            this.checkBox_seq.Checked = true;
            this.checkBox_seq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_seq.Location = new System.Drawing.Point(130, 38);
            this.checkBox_seq.Name = "checkBox_seq";
            this.checkBox_seq.Size = new System.Drawing.Size(15, 14);
            this.checkBox_seq.TabIndex = 12;
            this.checkBox_seq.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "检测顺序";
            // 
            // checkBox_sendback
            // 
            this.checkBox_sendback.AutoSize = true;
            this.checkBox_sendback.Checked = true;
            this.checkBox_sendback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_sendback.Location = new System.Drawing.Point(130, 17);
            this.checkBox_sendback.Name = "checkBox_sendback";
            this.checkBox_sendback.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sendback.TabIndex = 10;
            this.checkBox_sendback.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "收到即发回";
            // 
            // listReceivedData
            // 
            this.listReceivedData.FormattingEnabled = true;
            this.listReceivedData.HorizontalScrollbar = true;
            this.listReceivedData.ItemHeight = 12;
            this.listReceivedData.Location = new System.Drawing.Point(679, 32);
            this.listReceivedData.Name = "listReceivedData";
            this.listReceivedData.Size = new System.Drawing.Size(482, 220);
            this.listReceivedData.TabIndex = 1;
            this.listReceivedData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listReceivedData_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.窗口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 启动ToolStripMenuItem
            // 
            this.启动ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动ToolStripMenuItem1,
            this.停止ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.启动ToolStripMenuItem.Name = "启动ToolStripMenuItem";
            this.启动ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.启动ToolStripMenuItem.Text = "服务";
            // 
            // 启动ToolStripMenuItem1
            // 
            this.启动ToolStripMenuItem1.Name = "启动ToolStripMenuItem1";
            this.启动ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.启动ToolStripMenuItem1.Text = "启动";
            this.启动ToolStripMenuItem1.Click += new System.EventHandler(this.启动ToolStripMenuItem1_Click);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.停止ToolStripMenuItem.Text = "停止";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发送字符ToolStripMenuItem,
            this.pingToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "测试";
            // 
            // 发送字符ToolStripMenuItem
            // 
            this.发送字符ToolStripMenuItem.Name = "发送字符ToolStripMenuItem";
            this.发送字符ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.发送字符ToolStripMenuItem.Text = "发送字符";
            this.发送字符ToolStripMenuItem.Click += new System.EventHandler(this.发送字符ToolStripMenuItem_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空列表ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 清空列表ToolStripMenuItem
            // 
            this.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem";
            this.清空列表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清空列表ToolStripMenuItem.Text = "清空列表";
            this.清空列表ToolStripMenuItem.Click += new System.EventHandler(this.清空列表ToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkOccucationalPing);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDownMaxConn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textPassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 142);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "启动设置";
            // 
            // checkOccucationalPing
            // 
            this.checkOccucationalPing.AutoSize = true;
            this.checkOccucationalPing.Checked = true;
            this.checkOccucationalPing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOccucationalPing.Location = new System.Drawing.Point(130, 115);
            this.checkOccucationalPing.Name = "checkOccucationalPing";
            this.checkOccucationalPing.Size = new System.Drawing.Size(15, 14);
            this.checkOccucationalPing.TabIndex = 8;
            this.checkOccucationalPing.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "OccucationalPing:";
            // 
            // numericUpDownMaxConn
            // 
            this.numericUpDownMaxConn.Location = new System.Drawing.Point(109, 79);
            this.numericUpDownMaxConn.Name = "numericUpDownMaxConn";
            this.numericUpDownMaxConn.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownMaxConn.TabIndex = 6;
            this.numericUpDownMaxConn.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "MaxConnection:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(109, 47);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(120, 21);
            this.textPassword.TabIndex = 3;
            this.textPassword.Text = "Rumpelstiltskin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(109, 20);
            this.textPort.MaxLength = 5;
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(120, 21);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "1234";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port:";
            // 
            // listSendersInfo
            // 
            this.listSendersInfo.FormattingEnabled = true;
            this.listSendersInfo.HorizontalScrollbar = true;
            this.listSendersInfo.ItemHeight = 12;
            this.listSendersInfo.Location = new System.Drawing.Point(266, 32);
            this.listSendersInfo.Name = "listSendersInfo";
            this.listSendersInfo.Size = new System.Drawing.Size(407, 220);
            this.listSendersInfo.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusIP,
            this.toolStripStatusGUID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1173, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusIP
            // 
            this.toolStripStatusIP.Name = "toolStripStatusIP";
            this.toolStripStatusIP.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusIP.Text = "IP:";
            // 
            // toolStripStatusGUID
            // 
            this.toolStripStatusGUID.Name = "toolStripStatusGUID";
            this.toolStripStatusGUID.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusGUID.Text = "GUID:";
            // 
            // checkBox_print
            // 
            this.checkBox_print.AutoSize = true;
            this.checkBox_print.Location = new System.Drawing.Point(130, 64);
            this.checkBox_print.Name = "checkBox_print";
            this.checkBox_print.Size = new System.Drawing.Size(15, 14);
            this.checkBox_print.TabIndex = 14;
            this.checkBox_print.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "打印消息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 598);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listSendersInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listReceivedData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxConn)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listReceivedData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 启动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listSendersInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIP;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusGUID;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxConn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkOccucationalPing;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 发送字符ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空列表ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_sendback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_seq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_print;
        private System.Windows.Forms.Label label7;
    }
}

