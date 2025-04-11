using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatTCPServer
{
    public partial class ServerForm : Form
    {
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            int port = int.Parse(txtPort.Text);
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            txtLog.AppendText("Server đang lắng nghe trên cổng " + port + "\r\n");

            Thread acceptThread = new Thread(() =>
            {
                client = listener.AcceptTcpClient();
                stream = client.GetStream();
                txtLog.Invoke(new Action(() =>
                {
                    txtLog.AppendText("Client đã kết nối!\r\n");
                }));
                ReceiveData();
            });
            acceptThread.IsBackground = true;
            acceptThread.Start();
        }

        private void ReceiveData()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (client.Connected)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string msg = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    txtLog.Invoke(new Action(() =>
                    {
                        txtLog.AppendText("Client: " + msg + "\r\n");
                    }));
                }
                catch
                {
                    break;
                }
            }
        }
    }

}
