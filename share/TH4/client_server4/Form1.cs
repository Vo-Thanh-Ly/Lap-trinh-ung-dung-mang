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

namespace client_server4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Socket udpLocal = null;
        private IPEndPoint ipRemote, ipLocal;
        Thread getThread = null;

        string filePath = "", fileName = "";
        const int BUFFER_SIZE = 8192;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.FormClosed += new FormClosedEventHandler(closeForm);
        }
        private void closeForm(object sender, EventArgs e)
        {
            try
            {
                getThread?.Abort();
                udpLocal?.Close();
            }
            catch { }
        }

        private void openinput(bool state)
        {
            btnGui.Enabled = !state;
            //btnSendFile.Enabled = !state;
            //btnBrowseFile.Enabled = !state;
            txtIPR.ReadOnly = !state;
            txtPortL.ReadOnly = !state;
            txtPortR.ReadOnly = !state;
            btntKN.Enabled = state;
        }

        private void btntKN_Click(object sender, EventArgs e)
        {
            try
            {
                int portL = int.Parse(txtPortL.Text.Trim());
                int portR = int.Parse(txtPortR.Text.Trim());

                udpLocal = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                ipLocal = new IPEndPoint(IPAddress.Parse("0.0.0.0"), portL);
                udpLocal.Bind(ipLocal);

                ipRemote = new IPEndPoint(IPAddress.Parse(txtIPR.Text.Trim()), portR);

                openinput(false);
                getThread = new Thread(new ThreadStart(ReceiveData));
                getThread.Start();
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
                byte[] data = Encoding.UTF8.GetBytes(txtMsg.Text);
                udpLocal.SendTo(data, ipRemote);
                rtxMsg.AppendText("Send: " + txtMsg.Text + "\r\n");
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
                EndPoint remote = new IPEndPoint(IPAddress.Any, 0);
                MemoryStream ms = null;
                string receivedFileName = "";
                while (true)
                {
                    byte[] buffer = new byte[BUFFER_SIZE];
                    int rec = udpLocal.ReceiveFrom(buffer, ref remote);
                    string header = Encoding.UTF8.GetString(buffer, 0, rec);

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
                        ms.Write(buffer, 0, rec);
                    }
                    else
                    {
                        string text = Encoding.UTF8.GetString(buffer, 0, rec);
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
                udpLocal.SendTo(headerBytes, ipRemote);

                // Gửi nội dung file
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[BUFFER_SIZE];
                    int bytesRead;
                    while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        udpLocal.SendTo(buffer.Take(bytesRead).ToArray(), ipRemote);
                        Thread.Sleep(1); // tránh nghẽn buffer
                    }
                }

                // Gửi EOF
                byte[] eof = Encoding.UTF8.GetBytes("<EOF>");
                udpLocal.SendTo(eof, ipRemote);
                rtxMsg.AppendText($"[Đã gửi file: {fileName}]\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi file: " + ex.Message);
            }
        }
    }
}