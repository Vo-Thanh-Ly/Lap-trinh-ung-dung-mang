using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(listen));
            t.IsBackground = true; // Đảm bảo thread dừng khi đóng form
            t.Start();
        }

        public void listen()
        {
            try
            {
                // Lắng nghe trên mọi địa chỉ IP
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("192.168.1.100"), 6500);
                TcpListener server = new TcpListener(ipe);
                server.Start();
                MessageBox.Show("Server đã khởi động, chờ kết nối từ client...");

                // Chấp nhận kết nối từ client
                TcpClient client = server.AcceptTcpClient();
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());

                while (true)
                {
                    // Đọc dữ liệu từ client
                    string s = sr.ReadLine();
           //         MessageBox.Show(s);
                    if (string.IsNullOrEmpty(s)) break; // Nếu dữ liệu rỗng, thoát vòng lặp
                    if (s.ToUpper().Equals("QUIT")) break;

                    string[] arr = s.Split('#');
                    if (arr.Length != 3) continue; // Đảm bảo dữ liệu đúng định dạng

                    int a, b, kq = 0;
                    if (!int.TryParse(arr[0], out a) || !int.TryParse(arr[2], out b)) continue;

                    // Sử dụng switch-case truyền thống
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
                            if (b != 0)
                                kq = a / b;
                            else
                                kq = int.MaxValue; // Tránh lỗi chia 0
                            break;
                        default:
                            kq = 0;
                            break;
                    }

                    // Gửi kết quả về client
                    sw.WriteLine(kq.ToString());
                    sw.Flush();
                }

                // Đóng kết nối
                sr.Close();
                sw.Close();
                client.Close();
                server.Stop();
                MessageBox.Show("Server đã dừng.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Server: " + ex.Message);
            }
        }
    }
}
