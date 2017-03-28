using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RakNetServer
{
    public partial class HexDataForm : Form
    {
        public HexDataForm()
        {
            InitializeComponent();
        }
        public void Show(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("        00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F"));
            for (int i = 0; i < data.Length; ++i)
            {
                if (i % 16 == 0)
                {
                    sb.AppendLine();
                    sb.Append(string.Format("{0:X6} ", i));
                }
                sb.Append(string.Format(" {0:X2}", data[i]));
            }
            textBox1.Text = sb.ToString();
            this.Show();
        }
    }
}
