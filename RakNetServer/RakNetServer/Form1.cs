using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using RakNet;
namespace RakNetServer
{
    public partial class Form1 : Form
    {
        ServerEntry entry = null;
        delegate void AddReceivedDataCallback(string text);
        public Form1()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //MessageBox.Show(RakNetPINVOKE.CSharp_RakNet_Add(4, 6).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entry = new ServerEntry();
            entry.MessageBox += (string text) => { MessageBox.Show(text); };
            entry.AddReceivedData += AddReceivedData;
            entry.AddSenderInfo += AddSenderInfo;
        }

        private void AddReceivedData(string text)
        {
            if (checkBox_print.Checked)
                this.listReceivedData.Items.Add(text);
            if (checkBox_sendback.Checked)
                entry.SendString(text, PacketPriority.IMMEDIATE_PRIORITY, PacketReliability.RELIABLE_SEQUENCED);
        }
        private void AddSenderInfo(string text)
        {
            if (checkBox_print.Checked)
                this.listSendersInfo.Items.Add(text);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            entry.Destroy();
        }

        private void 启动ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ushort port = (Convert.ToUInt16(textPort.Text));
                entry.StartServer(port, textPassword.Text, checkOccucationalPing.Checked, (ushort)numericUpDownMaxConn.Value);
                toolStripStatusIP.Text = "IP:" + entry.ServerIP;
                toolStripStatusGUID.Text = "GUID:" + entry.GUID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listReceivedData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectIndex = listReceivedData.SelectedIndex;
            if (selectIndex > -1)
            {
                HexDataForm f = new HexDataForm();
                f.Show(ServerEntry.BinaryData[selectIndex]);
            }
        }

        private void 发送字符ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entry.GUID != null)
            {
                TestSendString f = new TestSendString();
                f.Show(entry.SendString);
            }
            else
                MessageBox.Show("请先启动服务器");
        }

        private void 清空列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listReceivedData.Items.Clear();
            listSendersInfo.Items.Clear();
        }
    }
}
