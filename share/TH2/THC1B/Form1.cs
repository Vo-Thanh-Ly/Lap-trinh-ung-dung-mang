using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace THC1B
{
    public partial class Form1 : Form
    {
        private TcpClient tcp;
        private StreamWriter writer;
        private StreamReader reader;
        private Thread Th;
        private volatile bool Exit = false;
        private delegate void SafeCallDelegate(string text);

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                int RPort = int.Parse(txtRemotePort.Text);
                IPAddress ipAddress = IPAddress.Parse(txtRemoteHost.Text);
                IPEndPoint IpEnd = new IPEndPoint(ipAddress, RPort);

                tcp = new TcpClient();
                tcp.Connect(IpEnd);
                reader = new StreamReader(tcp.GetStream());
                writer = new StreamWriter(tcp.GetStream());

                Exit = false;
                Th = new Thread(ReceivedData) { IsBackground = true };
                Th.Start();
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcp != null && tcp.Connected)
                {
                    writer.WriteLine(txtMsg.Text);
                    writer.Flush();
                    lstSent.Items.Insert(0, txtMsg.Text);
                    txtMsg.Clear();
                }
                else
                {
                    MessageBox.Show("Chưa kết nối đến máy chủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceivedData()
        {
            try
            {
                while (!Exit)
                {
                    if (tcp == null || !tcp.Connected)
                        break;

                    string str = reader.ReadLine();
                    if (str != null)
                    {
                        AddItemSafe(str);
                    }
                    else
                    {
                        break; // Dừng vòng lặp nếu kết nối bị đóng
                    }
                }
            }
            catch (Exception ex)
            {
                AddItemSafe("Lỗi nhận dữ liệu: " + ex.Message);
            }
        }

        private void AddItemSafe(string text)
        {
            if (lstReceived.InvokeRequired)
            {
                var d = new SafeCallDelegate(AddItemSafe);
                lstReceived.Invoke(d, text);
            }
            else
            {
                lstReceived.Items.Insert(0, text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit = true;

            if (Th != null && Th.IsAlive)
            {
                Th.Join(); // Đợi thread kết thúc
            }

            writer?.Close();
            reader?.Close();
            tcp?.Close();
        }
    }
}
