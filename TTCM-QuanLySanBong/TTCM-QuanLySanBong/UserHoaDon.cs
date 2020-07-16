using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCM_QuanLySanBong
{
    public partial class UserHoaDon : UserControl
    {
        public UserHoaDon()
        {
            InitializeComponent();
            userHDBanHang1.Hide();
            userHDNhapHang1.Hide();
           
        }

        private void rbtnHDBan_CheckedChanged(object sender, EventArgs e)
        {
            userHDNhapHang1.Hide();
            userHDBG1.Hide();
            gunaTransition1.Show(userHDBanHang1);
        }

        private void rbtnHDNhap_CheckedChanged(object sender, EventArgs e)
        {
            userHDBanHang1.Hide();
            userHDBG1.Hide();
            gunaTransition1.Show(userHDNhapHang1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(rbtnHDBan.Checked == true)
            {
                frmHDBan frmHDBan = new frmHDBan();
                frmHDBan.ShowDialog();
            }
            else if(rbtnHDNhap.Checked == true)
            {
                frmNhapHang frmNhapHang = new frmNhapHang();
                frmNhapHang.ShowDialog();
            }
        }
    }
}
