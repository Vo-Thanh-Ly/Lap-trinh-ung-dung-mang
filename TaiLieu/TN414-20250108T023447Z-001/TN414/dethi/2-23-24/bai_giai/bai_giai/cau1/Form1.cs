using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Reflection;
namespace UDPChatSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;       
        }
        private UdpClient udpLocal = null;
        private IPEndPoint ipremote;
        Thread getThread = null;
       
        private void openinput(bool state)
        {
            this.btnGui.Enabled = !state;
            this.txtIPR.ReadOnly = !state;
            this.txtPortL.ReadOnly = !state;
            this.txtPortR.ReadOnly = !state; 
            this.btnKN.Enabled = state;

        }
        private bool IsContainFilter(string msg,string[] key)
        {
            string[] msgToken = msg.Split(' ');
            for (int i = 0; i < msgToken.Length; i++)
            {
                //MessageBox.Show(msgToken[i]);
                for (int j = 0; j < key.Length; j++)
                    if (msgToken[i].Equals(key[j]))
                        return true;
            }
            return false;
        }
        private void NhanDL()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    IPEndPoint ipe = new IPEndPoint(IPAddress.Any, int.Parse(txtPortL.Text.Trim()));
                    data = udpLocal.Receive(ref ipe);
                    string s = Encoding.UTF8.GetString(data, 0, data.Length);
                    if(s.StartsWith("UNS:"))
                    {
                        string[] tmp=s.Split(' ');
                        lstMsg.Items[Int32.Parse(tmp[1])] = "UNSENT MESSAGE [FRIEND]";
                    } 
                    else if(s.StartsWith("CLE:"))
                    {
                        lstMsg.Items.Clear();
                    }    
                    else
                        lstMsg.Items.Add("REC: " + s);                                       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnKN_Click(object sender, EventArgs e)
        {
            try
            {
                udpLocal = new UdpClient(int.Parse(txtPortL.Text.Trim()),AddressFamily.InterNetwork);                
                ipremote = new IPEndPoint(IPAddress.Parse(txtIPR.Text.Trim()), int.Parse(txtPortR.Text.Trim()));
                openinput(false);
                getThread = new Thread(new ThreadStart(NhanDL));
                getThread.IsBackground = true;
                getThread.Start();
            }
            catch (Exception ex)
            {
                openinput(true);
                MessageBox.Show(ex.ToString()); 
            }
        } 
        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
            byte[] data = new byte[1024];
            data = Encoding.UTF8.GetBytes(txtMsg.Text);
            udpLocal.Send(data,data.Length,ipremote);
            lstMsg.Items.Add("SEN: " + txtMsg.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
        private void btnUnsent_Click(object sender, EventArgs e)
        {
            int index = lstMsg.SelectedIndex;
            string line = lstMsg.Items[index].ToString();
            if (line.Substring(0, 4) == "SEN:")
            {
                byte[] data = new byte[1024];
                data = Encoding.UTF8.GetBytes("UNS: "+index.ToString());
                udpLocal.Send(data, data.Length, ipremote);
              lstMsg.Items[index] = "UNSENT MESSAGE [YOU]";
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            data = Encoding.UTF8.GetBytes("CLE:");
            udpLocal.Send(data, data.Length, ipremote);
            lstMsg.Items.Clear();
        }
    }
}
