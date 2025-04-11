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

namespace Server2
{
    public partial class udpServer2 : Form
    {

        Socket serverSocket;
      bool isRunning;

        public udpServer2()
        {
            InitializeComponent();
        }

        private void udpServer2_Load(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(RunServer);
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void RunServer()
        {
            isRunning = true;
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, 8080));
                serverSocket.Listen(5);
                MessageBox.Show("Server đang chạy");

                while (isRunning) // Kiểm tra biến isRunning
                {
                    if (serverSocket.Poll(1000, SelectMode.SelectRead)) // Kiểm tra có kết nối không
                        continue;

                    Socket clientsSocket = serverSocket.Accept();
                    Thread clientThread = new Thread(() => HandleClient(clientsSocket));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                if (isRunning) // Chỉ báo lỗi nếu server chưa đóng
                    MessageBox.Show("Lỗi Server: " + ex.Message);
            }
        }


        private void HandleClient(Socket clientsSocket)
        {
            byte[] buffes = new byte[1024];
            int receivedBytes;
            try
            {
                while ((receivedBytes = clientsSocket.Receive(buffes)) > 0)
                {
                    string s = Encoding.UTF8.GetString(buffes, 0, receivedBytes);
                    if (string.IsNullOrEmpty(s)) break;
                    if (s.ToUpper().Equals("QUIT")) break;

                    string[] arr = s.Split('#');
                    if (arr.Length != 3) continue;

                    int a, b, kq = 0;
                    if (!int.TryParse(arr[0], out a) || !int.TryParse(arr[2], out b)) continue;

                    switch (arr[1])
                    {
                        case "cộng":
                            kq = a + b;
                            break;
                        case "trừ":
                            kq = a - b;
                            break;
                        case "nhân":
                            kq = a * b;
                            break;
                        case "chia":
                            kq = (b != 0) ? (a / b) : int.MaxValue;
                            break;
                        default:
                            kq = 0;
                            break;
                    }

                    string response = kq.ToString(); // Gửi kết quả thay vì dữ liệu thô
                    clientsSocket.Send(Encoding.UTF8.GetBytes(response));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Client: " + ex.Message);
            }
            finally
            {
                clientsSocket.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isRunning = false; // Dừng vòng lặp trong RunServer
            serverSocket?.Close(); // Đóng socket server nếu có
            Application.Exit(); // Thoát ứng dụng
        }
    }
}
