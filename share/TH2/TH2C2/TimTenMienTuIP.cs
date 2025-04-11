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
    public partial class TimTenMienTuIP : Form
    {
        public TimTenMienTuIP()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry iPHostEntry = Dns.GetHostEntry(txtTenMien.Text.Trim());
                labelTenMine.Text = iPHostEntry.HostName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
