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
    public partial class frmDatSan : Form
    {
        public frmDatSan()
        {
            InitializeComponent();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            frmKhachHang fm = new frmKhachHang();
            this.Hide();
            fm.ShowDialog();
        }
    }
}
