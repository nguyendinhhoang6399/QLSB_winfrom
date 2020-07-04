using Guna.UI.WinForms;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            userDatSan1.Hide();
            userTinhTien1.Hide();
            userHangHoa1.Hide();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            userMain1.Hide();
            userDatSan1.Hide();
            userHangHoa1.Hide();
            gunaTransition1.Show(userTinhTien1);
        }

        private void btnSan_Click(object sender, EventArgs e)
        {
            userMain1.Hide();
            userTinhTien1.Hide();
            userHangHoa1.Hide();
            gunaTransition1.Show(userDatSan1);
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            userMain1.Hide();
            userTinhTien1.Hide();
            userDatSan1.Hide();
            gunaTransition1.Show(userHangHoa1);
        }
    }
}
