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
    public partial class KiemTraDacDiemIP : Form
    {
        public KiemTraDacDiemIP()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            String mess = "Địa chỉ IP bình thường";
            try
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress myIp = IPAddress.Parse(txtTenMien.Text.Trim());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (myIp.Equals(ip))
                    {
                        mess = "Địa chỉ IP máy cụ bộ";
                        break;
                    }
                }

                if (IPAddress.IsLoopback(myIp))
                {
                    mess = "Địa chỉ IP Loopback";
                }
                labelTenMine.Text = mess;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi");
            }

        }
    }
}
