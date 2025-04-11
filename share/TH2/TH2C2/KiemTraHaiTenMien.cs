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
    public partial class KiemTraHaiTenMien : Form
    {
        public KiemTraHaiTenMien()
        {
            InitializeComponent();
        }

        private void btnkt_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = "Hai địa chỉ không thuộc cùng một tên miền";
                IPHostEntry iPHost1 = Dns.GetHostEntry(textTM1.Text.Trim());
                IPHostEntry iPHost2 = Dns.GetHostEntry(textTM2.Text.Trim());

                // So sánh từng địa chỉ IP
                foreach (IPAddress ip1 in iPHost1.AddressList)
                {
                    if (iPHost2.AddressList.Contains(ip1))
                    {
                        mess = "Hai địa chỉ thuộc cùng một tên miền";
                        break;
                    }
                }

                MessageBox.Show(mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
