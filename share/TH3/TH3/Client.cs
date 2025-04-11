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

namespace TH3
{
    public partial class Client : Form
    {
        TcpClient client;
        StreamReader reader;
        StreamWriter sw;
        StreamReader sr;
        public Client()
        {
            InitializeComponent();
        }
        public void send()
        {
            string s = txta.Text + '#' + cbbpheptoan.Text + '#' + txtb.Text;
        //    MessageBox.Show(s);
            sw.WriteLine(s);
            sw.Flush();
           txtkq.Text = sr.ReadLine();
        }



        private void Client_Load(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.1.100"), 6500);
                client = new TcpClient();
                client.Connect(ipe);
                sr = new StreamReader(client.GetStream());
                sw = new StreamWriter(client.GetStream());
            }
            catch (Exception)
            {
                MessageBox.Show("Máy chủ chưa khởi động");
                this.Close();
            }
        }

        private void btnkq_Click(object sender, EventArgs e)
        {
            if (lable1.Text != "" && cbbpheptoan.Text != "" && lable2.Text != "") send();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            sw.WriteLine("QUIT");
            sw.Flush(); ; sr.Close(); sw.Close(); client.Close();
            this.Close();
        }
    }
}
