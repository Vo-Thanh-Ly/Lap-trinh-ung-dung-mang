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

namespace TH4
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
                private void Client_Load(object sender, EventArgs e)
        {
            // InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.FormClosed += new FormClosedEventHandler(closeForm);
        }

        private void closeForm(object sender, EventArgs e)
        {
            try
            {
                if (getThread.IsAlive)
                {
                    getThread.Abort();
                    udpLocal.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private Socket udpLocal = null;
        private IPEndPoint ipremote, iplocal;
        Thread getThread = null;
        private void openinput(bool state)
        {
            this.btnGui.Enabled = !state;
            this.txtIPR.ReadOnly = !state;
            this.txtPortL.ReadOnly = !state;
            this.txtPortR.ReadOnly = !state;
            this.btntKN.Enabled = state;
        }
        private void btntKN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPortL.Text.Trim(), out int portL) || portL < 1 || portL > 65535)
                {
                    MessageBox.Show("Cổng local không hợp lệ! Hãy nhập một số trong khoảng 1-65535. " + "\"" + txtPortL.Text + "\"");
                    return;
                }
                if (!int.TryParse(txtPortR.Text.Trim(), out int portR) || portR < 1 || portR > 65535)
                {
                    MessageBox.Show("Cổng remote không hợp lệ! Hãy nhập một số trong khoảng 1-65535." + "\"" + txtPortR.Text + "\"");
                    return;
                }
                udpLocal = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                iplocal = new IPEndPoint(IPAddress.Parse("192.168.1.15"), portL);
                udpLocal.Bind(iplocal);
                ipremote = new IPEndPoint(IPAddress.Parse(txtIPR.Text.Trim()), portR);
                openinput(false);
                getThread = new Thread(new ThreadStart(NhanDL));
                getThread.Start();
            }
            catch (Exception ex)
            {
                openinput(true);
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[1024];
                data = Encoding.UTF8.GetBytes(txtMsg.Text);

                udpLocal.SendTo(data, ipremote);
                rtxMsg.Text += "Send: " + txtMsg.Text + "\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void NhanDL()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    IPEndPoint ipe = new IPEndPoint(IPAddress.Any, int.Parse(txtPortL.Text.Trim()));
                    EndPoint rm = (EndPoint)ipe;
                    int rec = udpLocal.ReceiveFrom(data, ref rm);
                    string s = Encoding.UTF8.GetString(data, 0, rec);
                    rtxMsg.Text += "Receive: " + s + "\r\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
