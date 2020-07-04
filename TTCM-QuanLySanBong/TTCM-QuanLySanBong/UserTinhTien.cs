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
    public partial class UserTinhTien : UserControl
    {
        public UserTinhTien()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnThem, "Thêm");
            toolTip1.SetToolTip(btnXoa, "Xóa");
            toolTip1.SetToolTip(btnDoiGio, "Đổi giờ");
            toolTip1.SetToolTip(btnBatDau, "Bắt đầu");
            toolTip1.SetToolTip(btnDoiSan, "Đổi sân");
            toolTip1.SetToolTip(btnHuySan, "Hủy sân");
            toolTip1.SetToolTip(btnIn, "In hóa đơn");
            toolTip1.SetToolTip(btnThoat, "Thoát");
        }

        private void btnDoiSan_Click(object sender, EventArgs e)
        {

        }
    }
}
