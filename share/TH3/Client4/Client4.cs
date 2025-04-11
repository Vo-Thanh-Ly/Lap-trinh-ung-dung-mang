using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client4
{
    public partial class Client4 : Form
    {
        private const int BufferSize = 1024;

        public Client4()
        {
            InitializeComponent();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                lblFile.Text = fdlg.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblFile.Text))
                {
                    SendFile(lblFile.Text, txtIP.Text, int.Parse(txtPort.Text.Trim()));
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn file trước khi gửi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void SendFile(string filePath, string serverIP, int serverPort)
        {
            try
            {
                using (TcpClient client = new TcpClient(serverIP, serverPort))
                using (NetworkStream netStream = client.GetStream())
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    lblState.Text = "Kết nối server thành công...\n";

                    // 1️⃣ **Gửi tên file trước**
                    string fileName = Path.GetFileName(filePath);
                    byte[] fileNameBytes = Encoding.UTF8.GetBytes(fileName);
                    netStream.Write(fileNameBytes, 0, fileNameBytes.Length);
                    netStream.Flush();
                    System.Threading.Thread.Sleep(500); // Đợi server xử lý tên file

                    // 2️⃣ **Gửi dữ liệu file**
                    byte[] buffer = new byte[BufferSize];
                    int bytesRead;
                    long totalBytes = fileStream.Length;
                    long bytesSent = 0;

                    progressBar1.Maximum = 100;
                    progressBar1.Value = 0;

                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        netStream.Write(buffer, 0, bytesRead);
                        bytesSent += bytesRead;

                        // Cập nhật progressBar1
                        int percent = (int)((bytesSent * 100) / totalBytes);
                        progressBar1.Value = percent;

                        Application.DoEvents();
                    }

                    lblState.Text += $" Đã gửi {totalBytes} bytes đến Server\n";
                    MessageBox.Show("File đã gửi thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi file: " + ex.Message);
            }
        }
    }
}
