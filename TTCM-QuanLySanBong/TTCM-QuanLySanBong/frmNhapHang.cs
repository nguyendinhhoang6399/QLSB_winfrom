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
            string querry = "Insert into PhieuNhap(NgayNhap,ThanhTien,MaNcc) values('"+DateTime.Now+"',0,null)";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            frmPhieuNhap phieuNhap = new frmPhieuNhap();
            this.Hide();
            phieuNhap.ShowDialog();
        }

        void LoadPhieuNhap()
        {
            string querry = "select NH.maphieu, NCC.tenncc, NH.ngaynhap,PARSENAME(CONVERT(varchar, CAST(NH.thanhtien AS money), 1), 2) as thanhtien from PhieuNhap NH, NhaCungCap NCC where NH.mancc=NCC.mancc ";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDsPhieu.DataSource = data;
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            frmPhieuNhap phieuNhap = new frmPhieuNhap();
            this.Hide();
            phieuNhap.ShowDialog();
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            string querry = "select * from PhieuNhap where ngaynhap >= N'" + dtpTuNgay.Text + "' and ngaynhap <= N'" + dtpDenNgay.Text + "' ";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDsPhieu.DataSource = data;
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            string querry = "select * from PhieuNhap where ngaynhap >= N'" + dtpTuNgay.Text + "' and ngaynhap <= N'" + dtpDenNgay.Text + "' ";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDsPhieu.DataSource = data;
        }

        private void dgvDsPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                lbMaPhieu.Text = dgvDsPhieu.Rows[numrow].Cells[0].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string querry1 = "delete CTPhieuNhap where maphieu = N'" + lbMaPhieu.Text + "'";
            DataTable data1 = KetNoi.Istance.ExcuteQuerry(querry1);
            string querry = "delete PhieuNhap where maphieu = N'" + lbMaPhieu.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            
            LoadPhieuNhap();
        }

        
    }
}
