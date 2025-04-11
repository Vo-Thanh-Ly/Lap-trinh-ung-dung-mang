using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2
{

    public partial class udpForm1 : Form
    {
        // 1⃣ Tạo socket client
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string s;

        public udpForm1()
        {
            InitializeComponent();
        }


        private void udpForm1_Load(object sender, EventArgs e)
        {

            // 2⃣ Kết nối đến server
            try
            {
                clientSocket.Connect(new IPEndPoint(IPAddress.Parse("192.168.43.17"), 8080));
                MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìn thấy server!");
            }

        }
        private void btnkq_Click(object sender, EventArgs e)
        {
            if (lable1.Text != "" && cbbpheptoan.Text != "" && lable2.Text != "") send();
        }

        public void send()
        {
            s = txta.Text + '#' + cbbpheptoan.Text + '#' + txtb.Text;
            clientSocket.Send(Encoding.UTF8.GetBytes(s));
            byte[] buffer = new byte[1024];
            int receivedBytes = clientSocket.Receive(buffer);
            string response = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
            txtkq.Text = response.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            try
            {
                s = "QUIT";
                clientSocket.Send(Encoding.UTF8.GetBytes(s));
                // Gửi thông báo đóng kết nối đến server (nếu cần)
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Đóng ứng dụng
            this.Close();
        }
    }
}
