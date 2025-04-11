using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace client2
{
    public partial class Client2 : Form
    {
        public Client2()
        {
            InitializeComponent();
        }

        string fileName;
        string filePath;
        int chunkSize = 512;
        private UdpClient udpClient;
        private IPEndPoint ipRemote;
        private Thread receiveThread;
        private void Form1_Load(object sender, EventArgs e) { }
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn tập tin để gửi";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                txtfileName.Text = filePath;
                fileName = Path.GetFileName(filePath);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                udpClient = new UdpClient(int.Parse(txtlocalP.Text));
                ipRemote = new IPEndPoint(IPAddress.Parse(txtRIP.Text.Trim()), int.Parse(txtRemoteP.Text));
                receiveThread = new Thread(ReceiveData);
                receiveThread.IsBackground = true;
                receiveThread.Start();
                MessageBox.Show("Đã khởi động chế độ lắng nghe.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi động UDP: " + ex.Message);
            }
        }
        private void ReceiveData()
        {
            try
            {
                IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
                MemoryStream ms = new MemoryStream();

                // Nhận tên file đầu tiên
                byte[] fileNameBytes = udpClient.Receive(ref remote);
                string receivedFileName = Encoding.UTF8.GetString(fileNameBytes);

                Console.WriteLine("Đang nhận file: " + receivedFileName);

                while (true)
                {
                    byte[] data = udpClient.Receive(ref remote);
                    string msg = Encoding.UTF8.GetString(data);

                    if (msg == "<EOF>")
                    {
                        Console.WriteLine("Đã nhận xong file.");
                        break;
                    }

                    ms.Write(data, 0, data.Length);
                }
                // Lưu với đúng tên file nhận được
                string folderPath = @"C:\ReceivedFiles";

                // Tạo thư mục nếu chưa có
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string savePath = Path.Combine(folderPath, receivedFileName);

                // Ghi file
                File.WriteAllBytes(savePath, ms.ToArray());
                MessageBox.Show("Đã lưu file tại: " + savePath);

                Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Đã lưu file: " + savePath);
                }));
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Lỗi khi nhận: " + ex.Message);
                }));
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Vui lòng chọn file trước khi gửi.");
                    return;
                }

                UdpClient senderClient = new UdpClient();

                // Gửi tên file trước
                byte[] fileNameBytes = Encoding.UTF8.GetBytes(fileName);
                senderClient.Send(fileNameBytes, fileNameBytes.Length, ipRemote);

                // Gửi nội dung file theo chunk
                byte[] fileBytes = File.ReadAllBytes(filePath);
                for (int i = 0; i < fileBytes.Length; i += chunkSize)
                {
                    int size = Math.Min(chunkSize, fileBytes.Length - i);
                    byte[] chunk = new byte[size];
                    Array.Copy(fileBytes, i, chunk, 0, size);
                    senderClient.Send(chunk, chunk.Length, ipRemote);
                    Thread.Sleep(5); // tránh nghẽn gói
                }

                // Gửi <EOF>
                byte[] eof = Encoding.UTF8.GetBytes("<EOF>");
                senderClient.Send(eof, eof.Length, ipRemote);

                MessageBox.Show("Gửi file thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi: " + ex.Message);
            }
        }
    }
}
