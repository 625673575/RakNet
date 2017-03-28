using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RakNet;

namespace RakNetServer
{
    public partial class TestSendString : Form
    {
        public TestSendString()
        {
            InitializeComponent();
        }
        Action<string, PacketPriority, PacketReliability> sendStringCallback;


        private void button1_Click(object sender, EventArgs e)
        {
            if (sendStringCallback != null)
                sendStringCallback.Invoke(textBox1.Text, PacketPriority.MEDIUM_PRIORITY, PacketReliability.RELIABLE);
        }

        internal void Show(Action<string, PacketPriority, PacketReliability> sendString)
        {
            sendStringCallback = sendString;
            this.ShowDialog();
        }
    }
}
