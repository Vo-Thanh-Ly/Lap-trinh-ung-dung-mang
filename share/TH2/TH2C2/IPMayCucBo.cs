using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2C2
{
    public partial class IPMayCucBo : Form
    {
        public IPMayCucBo()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            listIP.Items.Clear();
            try
            {
                IPHostEntry iPs = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in iPs.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        listIP.Items.Add(ip.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
