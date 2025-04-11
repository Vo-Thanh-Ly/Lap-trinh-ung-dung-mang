using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TH4
{
    public partial class Client : Form
    {
        private UdpClient udpClient;
        private IPEndPoint ipRemote;
        private Thread receiveThread;
        public Client()
        {
            InitializeComponent();
        }
        private void Client_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.FormClosed += new FormClosedEventHandler(CloseForm);
        }
        private void CloseForm(object sender, EventArgs e)
        {
            try
            {
                receiveThread?.Abort();
                udpClient?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void OpenInput(bool state)
        {
            btnGui.Enabled = !state;
            txtIPR.ReadOnly = !state;
            txtPortL.ReadOnly = !state;
            txtPortR.ReadOnly = !state;
            btntKN.Enabled = state;
        }
        private void btntKN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPortL.Text.Trim(), out int portL) || portL < 1 || portL > 65535)
                {
                    MessageBox.Show("Cổng local không hợp lệ!");
                    return;
                }

                if (!int.TryParse(txtPortR.Text.Trim(), out int portR) || portR < 1 || portR > 65535)
                {
                    MessageBox.Show("Cổng remote không hợp lệ!");
                    return;
                }

                udpClient = new UdpClient(portL);
                ipRemote = new IPEndPoint(IPAddress.Parse(txtIPR.Text.Trim()), portR);
                OpenInput(false);
                receiveThread = new Thread(ReceiveData);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                OpenInput(true);
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(txtMsg.Text);
                udpClient.Send(data, data.Length, ipRemote);
                rtxMsg.AppendText("Send: " + txtMsg.Text + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ReceiveData()
        {
            try
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                while (true)
                {
                    byte[] data = udpClient.Receive(ref remoteEndPoint);
                    string message = Encoding.UTF8.GetString(data);
                    rtxMsg.AppendText("Receive: " + message + "\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}