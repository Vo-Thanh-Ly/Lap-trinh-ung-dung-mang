using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2C2
{
    public partial class TimIPTuTenMien : Form
    {
        public TimIPTuTenMien()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            listIP.Items.Clear();
            try
            {
                IPHostEntry host = Dns.GetHostEntry(txtIP.Text.Trim());
                IPAddress[] ips = host.AddressList;
                foreach (IPAddress iP in ips)
                {
                    listIP.Items.Add(iP.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
