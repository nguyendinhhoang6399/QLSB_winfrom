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
    public partial class frmSan : Form
    {
        public frmSan()
        {
            InitializeComponent();
        }

        private void btnBangGia_Click(object sender, EventArgs e)
        {
            frmBangGia bangGia = new frmBangGia();
            this.Hide();
            bangGia.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //frmSan san = new frmSan();
            this.Close();
        }
    }
}
