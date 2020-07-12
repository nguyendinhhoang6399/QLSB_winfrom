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
            LoadPhieuNhap();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            string querry = "Insert into PhieuNhap(NgayNhap,ThanhTien,MaNcc,MaNv) values(null,null,null,null)";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            frmPhieuNhap phieuNhap = new frmPhieuNhap();
            this.Hide();
            phieuNhap.ShowDialog();
        }

        void LoadPhieuNhap()
        {
            string querry = "select NH.maphieu, NCC.tenncc, NV.tennv, NH.ngaynhap, NH.thanhtien from PhieuNhap NH, NhaCungCap NCC, NhanVien NV where NH.mancc=NCC.mancc and NH.manv=NV.manv";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDsPhieu.DataSource = data;
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
