using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatTcpClient
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ip = txtServerIP.Text.Trim();
            int port = int.Parse(txtPort.Text.Trim());

            try
            {
                client = new TcpClient();
                client.Connect(ip, port);
                stream = client.GetStream();
                txtChat.AppendText("Đã kết nối đến server!\r\n");

                Thread receiveThread = new Thread(ReceiveData);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (stream != null && client.Connected)
            {
                byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
                stream.Write(data, 0, data.Length);
                txtChat.AppendText("Bạn: " + txtMessage.Text + "\r\n");
                txtMessage.Clear();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

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
                    txtChat.Invoke(new Action(() =>
                    {
                        txtChat.AppendText("Server: " + msg + "\r\n");
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
