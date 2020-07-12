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
            LoadHangHoa();
            LoadNcc();
            LoadMaPhieu();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnThemNcc, "Thêm");
        }

        void LoadPhieuN()
        {
            string querry = "select PN.maphieu, HH.tenhh, ctPN.dvt, ctPN.soluongnhap, ctPN.gianhap, NCC.tenncc from phieuNhap PN, hanghoa HH, CTphieuNhap ctPN, nhacungcap NCC where PN.maphieu = ctPN.maphieu and ctPN.mahh = HH.mahh and ctPN.mancc = NCC.mancc";
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
                cboxMaPhieu.Text = dgvNhapHang.Rows[numrow].Cells[0].Value.ToString();
                cboxTenHang.Text = dgvNhapHang.Rows[numrow].Cells[1].Value.ToString();
                txtDvt.Text = dgvNhapHang.Rows[numrow].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvNhapHang.Rows[numrow].Cells[3].Value.ToString();
                txtGiaNhap.Text = dgvNhapHang.Rows[numrow].Cells[4].Value.ToString();
                cboxNcc.Text = dgvNhapHang.Rows[numrow].Cells[5].Value.ToString();
            }
        }
        void loadNull()
        {
            cboxMaPhieu.Text = "";
            cboxTenHang.Text = "";
            txtDvt.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            cboxNcc.Text = "";
        }
        int dem;
        void LoadNcc()
        {
            string querry = "select * from Nhacungcap";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxNcc.DataSource = data;
            cboxNcc.DisplayMember = "tenncc";
            cboxNcc.ValueMember = "mancc";
            cboxNcc.SelectedIndex = -1;
        }
        void LoadHangHoa()
        {
            string querry = "select * from HangHoa";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxTenHang.DataSource = data;
            cboxTenHang.DisplayMember = "tenhh";
            cboxTenHang.ValueMember = "mahh";
            cboxTenHang.SelectedIndex = -1;
        }
        void LoadMaPhieu()
        {
            string querry = "select * from PhieuNhap";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxMaPhieu.DataSource = data;
            cboxMaPhieu.DisplayMember = "maphieu";
            cboxMaPhieu.ValueMember = "maphieu";
            cboxMaPhieu.SelectedIndex = -1;
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            dem = 1;
            gbPhieuNhap.Enabled = true;
            loadNull();
            dgvNhapHang.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dem = 2;
            gbPhieuNhap.Enabled = true;
            if (cboxMaPhieu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
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
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    string maPhieu = cboxMaPhieu.Text;
                    string tenhh = cboxTenHang.Text;
                    string dvt = txtDvt.Text;
                    string tenNcc = cboxNcc.Text;
                    decimal soLuong, gia = 0;
                    if (cboxTenHang.Text == "" || txtDvt.Text == "" || txtSoLuong.Text == "" || txtGiaNhap.Text == "" || cboxNcc.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (kiemTra(maPhieu) == true)
                    {
                        MessageBox.Show("Phiếu nhập đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            string querry = "insert into CTPhieuNhap values(N'" + cboxMaPhieu.Text + "',N'" + txtDvt.Text + "'," +
                                            "N'" + txtSoLuong.Text + "',N'" + txtGiaNhap.Text + "',N'" + cboxTenHang.SelectedValue + "',N'" + cboxNcc.SelectedValue + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            //string querry1 = "update PhieuNhap "
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
                    string maPhieu = cboxMaPhieu.Text;
                    string tenhh = cboxTenHang.Text;
                    string dvt = txtDvt.Text;
                    string tenNcc = cboxNcc.Text;
                    decimal soLuong, gia = 0;
                    if (cboxMaPhieu.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn đối tượng muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (cboxTenHang.Text == "" || txtDvt.Text == "" || txtSoLuong.Text == "" || txtGiaNhap.Text == "" || cboxNcc.Text =="")
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
                            string querry = "update CTPhieuNhap set dvt =N'" + dvt + "',soluongnhap='" + soLuong + "',gianhap=N'" + gia + "',mahh=N'"+cboxTenHang.SelectedValue+"',mancc = N'"+cboxNcc.SelectedValue+"' where maPhieu ='" + maPhieu + "'";
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
            string maPhieu = cboxMaPhieu.Text;
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
