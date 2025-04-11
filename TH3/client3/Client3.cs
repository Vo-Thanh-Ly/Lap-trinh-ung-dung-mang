using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client3
{
    public partial class Client3 : Form
    {
        int BufferSize = 1024;
        public Client3()
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
                if (lblFile.Text != "")
                    SendTCP(lblFile.Text, txtIP.Text, int.Parse(txtPort.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void SendTCP(string M, string IPA, Int32 PortN)
        {
            byte[] SendingBuffer = null;
            TcpClient client = null;
            NetworkStream netstream = null;
            try
            {
                client = new TcpClient(IPA, PortN);
                MessageBox.Show("Kết đến server thành công");
                lblState.Text = "Kết nối server...\n";
                netstream = client.GetStream();
                FileStream Fs = new FileStream(M, FileMode.Open, FileAccess.Read);
                int NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));
                progressBar1.Maximum = NoOfPackets;
                int TotalLength = (int)Fs.Length, CurrentPacketLength;
                for (int i = 0; i < NoOfPackets; i++)
                {
                    if (TotalLength > BufferSize)
                    {
                        CurrentPacketLength = BufferSize;
                        TotalLength = TotalLength - CurrentPacketLength;
                    }
                    else CurrentPacketLength = TotalLength;

                    SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                    netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                    if (progressBar1.Value >= progressBar1.Maximum)
                        progressBar1.Value = progressBar1.Minimum;
                    progressBar1.PerformStep();
                }
                lblState.Text = lblState.Text + " Đã gửi " + Fs.Length.ToString() + " bytes đến Server";
                Fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                netstream.Close(); client.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFile_Click(object sender, EventArgs e)
        {

        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void fdlg_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
