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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server3
{
    public partial class Server3 : Form
    {
        int BufferSize = 1024;
        private delegate void dlgAddItem(String str);
        private void AddItem(String str)
        {
            if (this.lstConnect.InvokeRequired)
            {
                this.Invoke(new dlgAddItem(AddItem), str);
            }
            else { this.lstConnect.Items.Add(str); }
        }

        public Server3()
        {
            InitializeComponent();
        }

        private void Server3_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            Thread thdListener = new Thread(new ThreadStart(ListenerThead));
            thdListener.Start();
            AddItem("Server đã khởi động");
        }

        public void ListenerThead()
        {
            try
            {
                ReceiveTCP(int.Parse(txtPort.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc cổng");
            }
        }

        public void ReceiveTCP(int portN)
        {
            TcpListener Listener = null;
            try
            {
                Listener = new TcpListener(IPAddress.Any, portN);
                Listener.Start();
                byte[] RecData = new byte[BufferSize];
                int RecBytes;
                while (true)
                {
                    TcpClient client = null;
                    NetworkStream networkStream = null;
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        networkStream = client.GetStream();
                        AddItem("Kết nối với client");
                        string SaveFileName = "Z:/TH3/Server3/test01.txt";
                        int totalrecbytes = 0;
                        FileStream Fs = new FileStream(SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
                        while ((RecBytes = networkStream.Read(RecData, 0, RecData.Length)) > 0)
                        {
                            Fs.Write(RecData, 0, RecBytes);
                            totalrecbytes += RecBytes;
                        }
                        Fs.Close();
                        networkStream.Close();
                        client.Close();
                        AddItem("Đã lưu tập tin");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu file thất bại");
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstConnect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
