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
    public partial class UserBaoCao : UserControl
    {
        public UserBaoCao()
        {
            InitializeComponent();
        }

      
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            frmDoanhThuSanBanh frmDoanhThu = new frmDoanhThuSanBanh();
            frmDoanhThu.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmBaoCaoVonNH frmBaoCaoVonNH = new frmBaoCaoVonNH();
            frmBaoCaoVonNH.ShowDialog();
        }
    }
}
