using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace client_server3
{
    public partial class client_server3 : Form
    {
        private UdpClient udpClient;
        private IPEndPoint ipRemote;
        private Thread receiveThread;

        string filePath;
        string fileName;
        int chunkSize = 8192; // 8KB cho mỗi gói UDP
        public client_server3()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int localPort = int.Parse(txtlocalP.Text.Trim());
            int remotePort = int.Parse(txtRemoteP.Text.Trim());
            string remoteIP = txtRIP.Text.Trim();

            udpClient = new UdpClient(localPort);
            ipRemote = new IPEndPoint(IPAddress.Parse(remoteIP), remotePort);

            receiveThread = new Thread(ReceiveData);
            receiveThread.IsBackground = true;
            receiveThread.Start();

            MessageBox.Show("Bắt đầu lắng nghe...");
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.Title = "Chọn tập tin để gửi";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                fileName = Path.GetFileName(filePath);
                txtfileName.Text = filePath;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Vui lòng chọn file hợp lệ.");
                return;
            }

            Thread sendThread = new Thread(SendFile);
            sendThread.IsBackground = true;
            sendThread.Start();
        }

        private void client_server3_Load(object sender, EventArgs e)
        {

        }
        private void SendFile()
        {
            try
            {
                // Gửi tên file trước
                byte[] nameBytes = Encoding.UTF8.GetBytes(fileName);
                udpClient.Send(nameBytes, nameBytes.Length, ipRemote);
                Thread.Sleep(100); // tránh trùng gói

                // Gửi nội dung file theo từng chunk
                byte[] buffer = new byte[chunkSize];
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int bytesRead;
                    while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        udpClient.Send(buffer, bytesRead, ipRemote);
                        Thread.Sleep(5); // delay nhỏ tránh nghẽn mạng
                    }
                }

                // Gửi ký hiệu kết thúc
                byte[] endSignal = Encoding.UTF8.GetBytes("<EOF>");
                udpClient.Send(endSignal, endSignal.Length, ipRemote);

                MessageBox.Show("Gửi file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi: " + ex.Message);
            }
        }
        private void ReceiveData()
        {
            try
            {
                string receivedFileName = "";
                bool receivedFileNameFlag = false;
                MemoryStream ms = new MemoryStream();

                while (true)
                {
                    IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = udpClient.Receive(ref remote);

                    string msg = Encoding.UTF8.GetString(data);

                    if (!receivedFileNameFlag)
                    {
                        receivedFileName = msg;
                        receivedFileNameFlag = true;
                        continue;
                    }

                    if (msg == "<EOF>")
                    {
                        string saveDir = @"C:\ReceivedFiles";
                        if (!Directory.Exists(saveDir))
                            Directory.CreateDirectory(saveDir);

                        string savePath = Path.Combine(saveDir, receivedFileName);
                        File.WriteAllBytes(savePath, ms.ToArray());
                        ms.Dispose();

                        this.Invoke((MethodInvoker)(() =>
                        {
                            MessageBox.Show("Đã nhận xong file: " + receivedFileName);
                        }));

                        // Reset
                        receivedFileNameFlag = false;
                        ms = new MemoryStream();
                    }
                    else
                    {
                        ms.Write(data, 0, data.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Lỗi nhận: " + ex.Message);
                }));
            }
        }
    }
}
