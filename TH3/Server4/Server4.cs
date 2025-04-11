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

namespace Server4
{

    public partial class Server4 : Form
    {
        private TcpListener _listener;
        private bool _isRunning = false;
        private const int BufferSize = 1024;

        public Server4()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int port;
            if (!int.TryParse(txtPort.Text, out port))
            {
                MessageBox.Show("Vui lòng nhập số cổng hợp lệ.");
                return;
            }

            _isRunning = true;
            Thread serverThread = new Thread(() => StartServer(port));
            serverThread.IsBackground = true;
            serverThread.Start();

            AddItem("Server đã khởi động trên cổng " + port);
        }

        private void StartServer(int port)
        {
            try
            {
                _listener = new TcpListener(IPAddress.Any, port);
                _listener.Start();

                while (_isRunning)
                {
                    TcpClient client = _listener.AcceptTcpClient();
                    ThreadPool.QueueUserWorkItem(HandleClient, client);
                }
            }
            catch (Exception ex)
            {
                AddItem("Lỗi server: " + ex.Message);
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = obj as TcpClient;
            if (client == null) return;

            try
            {
                using (NetworkStream networkStream = client.GetStream())
                {
                    byte[] buffer = new byte[BufferSize];
                    int bytesRead;

                    // Đọc tên file trước (giả sử client gửi tên file đầu tiên)
                    bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                    string fileName = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
                    string savePath = Path.Combine("C:\\ReceivedFiles", fileName);

                    AddItem($"Đang nhận file: {fileName}");

                    // Tạo thư mục nếu chưa có
                    Directory.CreateDirectory("C:\\ReceivedFiles");

                    using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                    {
                        while ((bytesRead = networkStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fs.Write(buffer, 0, bytesRead);
                        }
                    }

                    AddItem($"Đã lưu tập tin: {fileName}");
                }
            }
            catch (Exception ex)
            {
                AddItem("Lỗi khi xử lý client: " + ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        private delegate void dlgAddItem(string str);
        private void AddItem(string str)
        {
            if (lstConnect.InvokeRequired)
            {
                this.Invoke(new dlgAddItem(AddItem), str);
            }
            else
            {
                lstConnect.Items.Add(str);
            }
        }





        private void buttonThoat_Click(object sender, EventArgs e)
        {
            _isRunning = false;
            _listener?.Stop();
            AddItem("Server đã dừng.");

        }
    }
}
