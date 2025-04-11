using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_server4_tcp
{
    public partial class Form1: Form
    {
        TcpClient tcpClient = null;
        NetworkStream netStream = null;
        Thread receiveThread = null;
        const int BUFFER_SIZE = 8192;

        string filePath = "", fileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.FormClosed += new FormClosedEventHandler(closeForm);
        }

        private void closeForm(object sender, EventArgs e)
        {
            try
            {
                receiveThread?.Abort();
                netStream?.Close();
                tcpClient?.Close();
            }
            catch { }
        }

        private void openinput(bool state)
        {
            btnGui.Enabled = !state;
            btnSendFile.Enabled = !state;
            btnBrowseFile.Enabled = !state;
            txtIPR.ReadOnly = !state;
            txtPortL.ReadOnly = !state;
            txtPortR.ReadOnly = !state;
            btntKN.Enabled = state;
        }

        private void btntKN_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIPR.Text.Trim();
                int port = int.Parse(txtPortR.Text.Trim());

                tcpClient = new TcpClient();
                tcpClient.Connect(ip, port);
                netStream = tcpClient.GetStream();

                openinput(false);

                receiveThread = new Thread(new ThreadStart(ReceiveData));
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtMsg.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                netStream.Write(data, 0, data.Length);
                rtxMsg.AppendText("Send: " + message + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi tin nhắn: " + ex.Message);
            }
        }

        private void ReceiveData()
        {
            try
            {
                byte[] buffer = new byte[BUFFER_SIZE];
                MemoryStream ms = null;
                string receivedFileName = "";

                while (true)
                {
                    int bytesRead = netStream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break; // Ngắt kết nối

                    string header = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    if (header.StartsWith("<FILE>:"))
                    {
                        receivedFileName = header.Substring(7);
                        ms = new MemoryStream();
                        continue;
                    }

                    if (header == "<EOF>")
                    {
                        string saveDir = @"C:\ReceivedFiles";
                        Directory.CreateDirectory(saveDir);
                        string savePath = Path.Combine(saveDir, receivedFileName);
                        File.WriteAllBytes(savePath, ms.ToArray());
                        rtxMsg.AppendText($"[Đã nhận file: {receivedFileName}]\r\n");
                        ms.Close();
                        ms = null;
                        continue;
                    }

                    if (ms != null)
                    {
                        ms.Write(buffer, 0, bytesRead);
                    }
                    else
                    {
                        string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        rtxMsg.AppendText("Receive: " + text + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhận dữ liệu: " + ex.Message);
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = Path.GetFileName(filePath);
                txtMsg.Text = fileName;
            }
        }
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath)) return;

                // Gửi tên file
                string header = "<FILE>:" + fileName;
                byte[] headerBytes = Encoding.UTF8.GetBytes(header);
                netStream.Write(headerBytes, 0, headerBytes.Length);
                Thread.Sleep(10);

                // Gửi nội dung file
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[BUFFER_SIZE];
                    int bytesRead;
                    while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        netStream.Write(buffer, 0, bytesRead);
                        Thread.Sleep(1); // tránh nghẽn buffer
                    }
                }

                // Gửi EOF
                byte[] eof = Encoding.UTF8.GetBytes("<EOF>");
                netStream.Write(eof, 0, eof.Length);
                rtxMsg.AppendText($"[Đã gửi file: {fileName}]\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi file: " + ex.Message);
            }
        }
    }

}