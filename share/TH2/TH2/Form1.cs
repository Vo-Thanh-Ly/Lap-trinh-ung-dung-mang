//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

//namespace TH2
//{
//    public partial class Form1 : Form
//    {
//        String _localPort = "10";
//        String _remotelPort = "1000";
//        UdpClient _aplications = new UdpClient();
//        Thread _thread;
//        bool _exit = false;
//        delegate void ClearCacheReceivedData(String Data, string RemoteHost);


//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void btnConnect_Click(object sender, EventArgs e)
//        {
//            _localPort = this.txtLocalPort.Text;
//            _remotelPort = this.txtPort.Text;

//            _aplications = new UdpClient(int.Parse(_localPort));
//            _thread = new Thread(Explore);
//            _thread.Start();

//            this.btnSend.Click += btnSend_Click;
//            this.btnSend.Enabled = true;
//            this.btnConnect.Enabled = false;

//            txtIpAddress.ReadOnly = txtLocalPort.ReadOnly = txtPort.ReadOnly = true;
//        }

//        private void Explore()
//        {
//            IPAddress ip;
//            byte[] msg;
//            string str = "";
//            ip = Dns.GetHostEntry(txtIpAddress.Text).AddressList[0];
//            IPEndPoint ep = new IPEndPoint(ip, Convert.ToInt16(_remotelPort));

//            while (_exit == false)
//            {
//                System.Windows.Forms.Application.DoEvents();
//                if (_aplications.Available > 0)
//                {
//                    msg = _aplications.Receive(ref ep);
//                    str = System.Text.Encoding.UTF8.GetString(msg);
//                    ReceivedData(str, ep.Address.ToString());
//                }
//            }
//        }

//        private void btnSend_Click(object sender, EventArgs e)
//        {
//            IPAddress ip;
//            if (!IPAddress.TryParse(txtIpAddress.Text, out ip))
//                MessageBox.Show("Hãy nhập chính xác IP của người nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            else
//            {
//                SendData();
//                lstSent.Items.Insert(0, txtSend.Text);
//                txtSend.Clear();
//            }
//        }


//        private void SendData()
//        {
//            byte[] msg;
//            msg = System.Text.Encoding.UTF8.GetBytes(txtSend.Text.Trim());
//            _aplications.Send(msg, msg.Length, txtIpAddress.Text, int.Parse(_remotelPort));
//        }

//        private void ReceivedData(string Data, string RemoteHost)
//        {
//            if (lstReceived.InvokeRequired)
//            {
//                ClearCacheReceivedData clearCacheReceivedData = new ClearCacheReceivedData(ReceivedData);
//                lstReceived.Invoke(clearCacheReceivedData, new object[] { Data, RemoteHost });
//                return;
//            }

//            string msg = "";
//            msg = "(Người gửi: " + RemoteHost + ") " + Data.TrimEnd();
//            lstReceived.Items.Insert(0, msg);
//        }


//    }
//}
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
using static System.Net.Mime.MediaTypeNames;

namespace TH2
{
    public partial class Form1 : Form
    {
        // Biến lưu trữ cổng cục bộ và cổng từ xa
        String _localPort = "10";
        String _remotelPort = "1000";

        // Đối tượng UDP client để gửi và nhận dữ liệu
        UdpClient _aplications = new UdpClient();

        // Luồng chạy để xử lý dữ liệu đến
        Thread _thread;

        // Biến kiểm soát việc dừng vòng lặp trong thread
        bool _exit = false;

        // Delegate để cập nhật giao diện khi nhận dữ liệu
        delegate void ClearCacheReceivedData(String Data, string RemoteHost);

        // Constructor của Form1
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sự kiện load form, hiện tại chưa làm gì
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Gán giá trị cổng từ ô nhập
            _localPort = this.txtLocalPort.Text;
            _remotelPort = this.txtPort.Text;

            // Khởi tạo UdpClient để lắng nghe trên cổng cục bộ
            _aplications = new UdpClient(int.Parse(_localPort));

            // Khởi động luồng nhận dữ liệu
            _thread = new Thread(Explore);
            _thread.Start();

            // Gán sự kiện click cho nút gửi
            this.btnSend.Click += btnSend_Click;

            // Bật nút gửi và vô hiệu hóa nút kết nối
            this.btnSend.Enabled = true;
            this.btnConnect.Enabled = false;

            // Đặt các ô nhập thành chỉ đọc
            txtIpAddress.ReadOnly = txtLocalPort.ReadOnly = txtPort.ReadOnly = true;
        }

        private void Explore()
        {
            IPAddress ip;
            byte[] msg;
            string str = "";

            // Lấy địa chỉ IP của người nhận từ tên miền hoặc IP nhập vào
            ip = Dns.GetHostEntry(txtIpAddress.Text).AddressList[0];

            // Khởi tạo endpoint từ địa chỉ IP và cổng từ xa
            IPEndPoint ep = new IPEndPoint(ip, Convert.ToInt16(_remotelPort));

            // Vòng lặp nhận dữ liệu
            while (_exit == false)
            {
                // Xử lý sự kiện để tránh treo UI
                System.Windows.Forms.Application.DoEvents();

                // Kiểm tra nếu có dữ liệu đến
                if (_aplications.Available > 0)
                {
                    // Nhận dữ liệu
                    msg = _aplications.Receive(ref ep);

                    // Chuyển dữ liệu nhận được sang chuỗi
                    str = System.Text.Encoding.UTF8.GetString(msg);

                    // Gửi dữ liệu nhận được đến giao diện
                    ReceivedData(str, ep.Address.ToString());
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            IPAddress ip;

            // Kiểm tra địa chỉ IP có hợp lệ không
            if (!IPAddress.TryParse(txtIpAddress.Text, out ip))
            {
                MessageBox.Show("Hãy nhập chính xác IP của người nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Gửi dữ liệu
                SendData();

                // Hiển thị tin nhắn đã gửi lên danh sách
                lstSent.Items.Insert(0, txtSend.Text);

                // Xóa nội dung nhập sau khi gửi
                txtSend.Clear();
            }
        }

        private void SendData()
        {
            byte[] msg;

            // Chuyển chuỗi tin nhắn thành byte array
            msg = System.Text.Encoding.UTF8.GetBytes(txtSend.Text.Trim());

            // Gửi dữ liệu qua UDP đến địa chỉ IP và cổng từ xa
            _aplications.Send(msg, msg.Length, txtIpAddress.Text, int.Parse(_remotelPort));
        }

        private void ReceivedData(string Data, string RemoteHost)
        {
            // Kiểm tra xem có cần gọi từ luồng UI không
            if (lstReceived.InvokeRequired)
            {
                // Gọi lại phương thức này trong luồng UI
                ClearCacheReceivedData clearCacheReceivedData = new ClearCacheReceivedData(ReceivedData);
                lstReceived.Invoke(clearCacheReceivedData, new object[] { Data, RemoteHost });
                return;
            }

            // Hiển thị tin nhắn nhận được lên danh sách
            string msg = "(Người gửi: " + RemoteHost + ") " + Data.TrimEnd();
            lstReceived.Items.Insert(0, msg);
        }
    }
}
