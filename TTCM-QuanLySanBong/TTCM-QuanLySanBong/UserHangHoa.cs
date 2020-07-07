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
    public partial class UserHangHoa : UserControl
    {
        public UserHangHoa()
        {
            InitializeComponent();
        }

        

        private void btnBangGia_Click(object sender, EventArgs e)
        {
            frmNhapHang nhapHang = new frmNhapHang();
            
            nhapHang.ShowDialog();
        }

        
    }
}
