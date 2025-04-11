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
    public partial class KiemTraIPv4_Ipv6 : Form
    {
        public KiemTraIPv4_Ipv6()
        {
            InitializeComponent();
        }

        private void btnkt_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress address;
                IPAddress.TryParse(this.txtIP.Text, out address);
                if (address != null)
                {
                    if (address.ToString().IndexOf(".") != -1)
                    {
                        MessageBox.Show("Đây là địa chỉ IPv4");
                    }
                    else
                    {
                        MessageBox.Show("Đây là địa chỉ IPv6");
                    }
                }
                if (address == null)
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ IP hợp lệ");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập địa chỉ IP hợp lệ");
            }
        }
    }
}
