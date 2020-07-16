using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.SymbolStore;

namespace TTCM_QuanLySanBong
{
    public partial class UserDatSan : UserControl
    {
        public UserDatSan()
        {
            InitializeComponent();
            LoadTs();
            LoadKh();
            LoadLichDS();
            btnBoHuy.Enabled = false;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnThemSan, "Thêm");
        }
        void LoadLichDS()
        {
            string querry = "select DS.MaDatSan, KH.tenkh,S.tensan ,DS.tungay,DS.denngay,DS.tugio,DS.dengio,DS.thoigian,DS.trangthai from DatSan DS, KhachHang KH, San S where DS.makh=KH.makh and S.masan = DS.masan";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDatSan.DataSource = data;
            //int dem = 0;
           //foreach(DataRow row in data.Rows)
           // {
           //     if(row["Trangthai"].ToString()=="Đang Đặt")
           //     {
           //         MessageBox.Show("dem is: " + dem);
           //         dgvDatSan.Rows[dem].DefaultCellStyle.BackColor = Color.Red;
           //     }
           // }
            
        }
        void LoadTs()
        {
            string querry = "select * from San";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxTenSan.DataSource = data;
            cboxTenSan.DisplayMember = "tensan";
            cboxTenSan.ValueMember = "masan";
            cboxTenSan.SelectedIndex = -1;
        }
        void LoadKh()
        {
            string querry = "select * from KhachHang";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxKhachHang.DataSource = data;
            cboxKhachHang.DisplayMember = "tenKh";
            cboxKhachHang.ValueMember = "makh";
            cboxKhachHang.SelectedIndex = -1;
        }
        void LoadNull()
        {
            cboxKhachHang.Text = "";
            cboxTenSan.Text = "";
            
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

        private void btnLichSan_Click(object sender, EventArgs e)
        {
            LoadLichDS();
            LoadNull();
            
        }


        private void cboxKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string querry = "select DS.MaDatSan, KH.tenkh,S.tensan ,DS.tungay,DS.denngay,DS.tugio,DS.dengio,DS.thoigian,DS.trangthai from DatSan DS, KhachHang KH, San S where DS.makh=KH.makh and S.masan = DS.masan and DS.makh like N'%" + cboxKhachHang.SelectedValue + "%'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDatSan.DataSource = data;
        }

        private void cboxTenSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string querry = "select DS.MaDatSan, KH.tenkh,S.tensan ,DS.tungay,DS.denngay,DS.tugio,DS.dengio,DS.thoigian,DS.trangthai from DatSan DS, KhachHang KH, San S where DS.makh=KH.makh and S.masan = DS.masan and S.masan like N'%" + cboxTenSan.SelectedValue + "%'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDatSan.DataSource = data;
        }

        

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            
            string querry = "select DS.MaDatSan, KH.tenkh,S.tensan ,DS.tungay,DS.denngay,DS.tugio,DS.dengio,DS.thoigian,DS.trangthai from DatSan DS, KhachHang KH, San S where DS.makh = KH.makh and S.masan = DS.masan and tungay >= N'" + dtpTuNgay.Text + "' and denngay <= N'" + dtpDenNgay.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDatSan.DataSource = data;

        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            string querry = "select DS.MaDatSan, KH.tenkh,S.tensan ,DS.tungay,DS.denngay,DS.tugio,DS.dengio,DS.thoigian,DS.trangthai from DatSan DS, KhachHang KH, San S where DS.makh = KH.makh and S.masan = DS.masan and tungay >= N'" + dtpTuNgay.Text + "' and denngay <= N'" + dtpDenNgay.Text + "'";
            
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDatSan.DataSource = data;
        }

        private void dgvDatSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                lbMaDS.Text = dgvDatSan.Rows[numrow].Cells[0].Value.ToString();
            }

        }

        private void btnHuySan_Click(object sender, EventArgs e)
        {
            
            string querry = "update DatSan set trangthai =N'Đã Hủy' where madatsan = '" + lbMaDS.Text + "' ";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            LoadLichDS();
            
        }

        private void btnBoHuy_Click(object sender, EventArgs e)
        {

           
            string querry = "update DatSan set trangthai =N'Đang Đặt' where madatsan = '" + lbMaDS.Text + "' ";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            LoadLichDS();
           

        }

        private void btnXoaLich_Click(object sender, EventArgs e)
        {
            string querry = "delete DatSan where madatsan = N'"+lbMaDS.Text+"'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLichDS();
        }
    }
}
