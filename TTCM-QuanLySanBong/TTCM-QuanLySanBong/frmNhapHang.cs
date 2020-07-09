using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCM_QuanLySanBong
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmPhieuNhap phieuNhap = new frmPhieuNhap();
            this.Hide();
            phieuNhap.Show();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
