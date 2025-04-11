using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcp_server_form
{
    public partial class Form1 : Form
    {
        TcpListener listener = null;
        NetworkStream netStream = null;
        TcpClient client = null;
        Thread listenThread = null;
        Thread receiveThread = null;

        const int BUFFER_SIZE = 8192;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.FormClosed += (s, ev) => StopServer();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int port = int.Parse(txtPort.Text.Trim());
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            listenThread = new Thread(() =>
            {
                AppendLog($"🟢 Đang chờ client kết nối trên port {port}...");
                client = listener.AcceptTcpClient(); // Block đến khi có client
                netStream = client.GetStream();
                AppendLog("✅ Client đã kết nối!");

                receiveThread = new Thread(ReceiveData);
                receiveThread.Start();
            });
            listenThread.Start();
        }
        private void ReceiveData()
        {
            try
            {
                byte[] buffer = new byte[BUFFER_SIZE];
                MemoryStream ms = null;
                string fileName = "";
                bool isReceivingFile = false;

                while (true)
                {
                    int bytesRead = netStream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    // Nếu đang không ở chế độ nhận file, ta kiểm tra header
                    if (!isReceivingFile)
                    {
                        string header = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        if (header.StartsWith("<FILE>:"))
                        {
                            fileName = header.Substring(7).Trim();
                            ms = new MemoryStream();
                            isReceivingFile = true;
                            AppendLog($"📥 Bắt đầu nhận file: {fileName}");
                            continue;
                        }

                        if (header == "<EOF>")
                        {
                            // Đề phòng nếu nhận EOF mà chưa có dữ liệu
                            continue;
                        }

                        // Nếu không phải là file, xem là tin nhắn
                        string msg = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        AppendLog("💬 Client: " + msg);
                    }
                    else
                    {
                        // Kiểm tra nếu buffer chứa EOF
                        string maybeEOF = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        if (maybeEOF.Contains("<EOF>"))
                        {
                            // Cắt bỏ phần "<EOF>" nếu có
                            int eofIndex = maybeEOF.IndexOf("<EOF>");
                            if (eofIndex > 0)
                                ms.Write(buffer, 0, eofIndex);

                            // Lưu file
                            string saveDir = @"C:\ReceivedFiles";
                            Directory.CreateDirectory(saveDir);
                            string savePath = Path.Combine(saveDir, fileName);
                            File.WriteAllBytes(savePath, ms.ToArray());

                            ms.Close();
                            ms = null;
                            isReceivingFile = false;

                            AppendLog($"✅ Đã lưu file: {fileName}");
                        }
                        else
                        {
                            // Ghi dữ liệu nhị phân vào MemoryStream
                            ms.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog("❌ Lỗi nhận dữ liệu: " + ex.Message);
            }
        }

        private void AppendLog(string text)
        {
            rtxLog.AppendText(text + "\r\n");
        }

        private void StopServer()
        {
            try
            {
                receiveThread?.Abort();
                listenThread?.Abort();
                netStream?.Close();
                client?.Close();
                listener?.Stop();
            }
            catch { }
        }

    }

}