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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
            LoadPhieuN();
        }

        void LoadPhieuN()
        {
            string querry = "select * from CTPhieuNhap";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvNhapHang.DataSource = data;
            gbPhieuNhap.Enabled = false;
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            frmNhaCungCap.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                txtMaPhieu.Text = dgvNhapHang.Rows[numrow].Cells[0].Value.ToString();
                txtTenHangHoa.Text = dgvNhapHang.Rows[numrow].Cells[1].Value.ToString();
                txtDvt.Text = dgvNhapHang.Rows[numrow].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvNhapHang.Rows[numrow].Cells[3].Value.ToString();
                txtGiaNhap.Text = dgvNhapHang.Rows[numrow].Cells[4].Value.ToString();
                cboxNcc.Text = dgvNhapHang.Rows[numrow].Cells[7].Value.ToString();
            }
        }
        void loadNull()
        {
            txtMaPhieu.Text = "";
            txtTenHangHoa.Text = "";
            txtDvt.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            cboxNcc.Text = "";
        }
        int dem;

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            dem = 1;
            gbPhieuNhap.Enabled = true;
            loadNull();
            dgvNhapHang.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dem = 2;
            gbPhieuNhap.Enabled = true;
            if (txtMaPhieu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnThemMoi.Enabled = false;
        }
        Boolean kiemTra(string maphieu)
        {
            string querry = "select * from CTPhieuNhap where maPhieu = '" + maphieu + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            int dem = 0;
            foreach (DataRow item in data.Rows)
            {
                dem++;
            }
            if (dem > 0)
                return true;
            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gbPhieuNhap.Enabled = false;
            loadNull();
            dgvNhapHang.Enabled = true;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    string maPhieu = txtMaPhieu.Text;
                    string tenhh = txtTenHangHoa.Text;
                    string dvt = txtDvt.Text;
                    string tenNcc = cboxNcc.Text;
                    decimal soLuong, gia = 0;
                    if (txtTenHangHoa.Text == "" || txtDvt.Text == "" || txtSoLuong.Text == "" || txtGiaNhap.Text == "" || cboxNcc.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (kiemTra(maPhieu) == true)
                    {
                        MessageBox.Show("Khách hàng đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            soLuong = decimal.Parse(txtSoLuong.Text);
                            gia = decimal.Parse(txtGiaNhap.Text);
                        }
                        catch
                        {

                            MessageBox.Show("Số lượng hoặc giá nhập nhập không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            string querry = "insert into CTPhieuNhap(tenHh,dvt,soluongnhap,gianhap,tenNcc) values(N'" + txtTenHangHoa.Text + "',N'" + txtDvt.Text + "'," +
                                            "N'" + txtSoLuong.Text + "',N'" + txtGiaNhap.Text + "',N'" + cboxNcc.Text + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadPhieuN();
                        }
                        catch
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (dem == 2)
                {
                    string maPhieu = txtMaPhieu.Text;
                    string tenhh = txtTenHangHoa.Text;
                    string dvt = txtDvt.Text;
                    string tenNcc = cboxNcc.Text;
                    decimal soLuong, gia = 0;
                    if (txtMaPhieu.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn đối tượng muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtTenHangHoa.Text == "" || txtDvt.Text == "" || txtSoLuong.Text == "" || txtGiaNhap.Text == "" || cboxNcc.Text =="")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            soLuong = decimal.Parse(txtSoLuong.Text);
                            gia = decimal.Parse(txtGiaNhap.Text);
                        }
                        catch
                        {

                            MessageBox.Show("Số lượng hoặc giá nhập nhập không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            string querry = "update CTPhieuNhap set tenhh = N'" + tenhh + "',dvt =N'" + dvt + "',soluongnhap='" + soLuong + "',gianhap=N'" + gia + "' where maPhieu ='" + maPhieu + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadPhieuN();
                        }
                        catch
                        {
                            MessageBox.Show("Sửa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text;
            if (maPhieu == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng muốn xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string querry = "delete CTPhieuNhap where maphieu = N'" + maPhieu + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNull();
                    LoadPhieuN ();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
