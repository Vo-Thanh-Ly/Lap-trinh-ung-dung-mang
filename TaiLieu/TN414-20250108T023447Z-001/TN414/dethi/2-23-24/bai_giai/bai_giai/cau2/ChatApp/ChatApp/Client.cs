using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Client : Form
    {
        IPEndPoint iep;
        TcpClient client;
        StreamReader sr;
        StreamWriter sw;
        public Client()
        {
            try
            {
                InitializeComponent();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AddInfo(String cnt)
        {
            rtxInfo.AppendText(cnt + "\n\r");
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            iep = new IPEndPoint(IPAddress.Parse(txtServerIP.Text), int.Parse(txtServerPort.Text));
            client = new TcpClient();
            client.Connect(iep);
            sr = new StreamReader(client.GetStream());
            sw = new StreamWriter(client.GetStream());
            AddInfo(sr.ReadLine());
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            sw.WriteLine("REA#" + txtTitle.Text + "#" + txtPassword.Text);
            sw.Flush();
            AddInfo(sr.ReadLine());
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            sw.WriteLine("CRE#" + txtTitle.Text+"#" + txtPassword.Text + "#"+txtMessage.Text);
            sw.Flush();
            AddInfo(sr.ReadLine());
        }    
    }
}