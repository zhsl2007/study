using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POK_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            sendSock = new SendSocket("211.88.25.236", 8088);
        }

        SendSocket sendSock;

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            int nR = Common.StringToHex(this.textBox1.Text);

            byte[] send = new byte[5];
            send[0] = Convert.ToByte(nR);

            string str = Common.HexToString(10);


            int a = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sendSock.ConnnectServer();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String strMsg = this.textBox1.Text;
            sendSock.SendMsg(strMsg);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            sendSock.Disconnect();
        }
    }
}
