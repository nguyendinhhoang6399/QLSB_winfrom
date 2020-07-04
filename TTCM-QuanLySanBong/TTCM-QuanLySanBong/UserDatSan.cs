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
    public partial class UserDatSan : UserControl
    {
        public UserDatSan()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
           
            frmDatSan frmDat = new frmDatSan();
            
            frmDat.ShowDialog();
        }

        private void btnThemSan_Click(object sender, EventArgs e)
        {
            frmSan san = new frmSan();
            
            san.ShowDialog();
        }
    }
}
