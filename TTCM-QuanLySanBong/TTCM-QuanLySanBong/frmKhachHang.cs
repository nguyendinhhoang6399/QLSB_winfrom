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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            LoadKH();
            
        }

        void LoadKH()
        {
            string querry = "select * from KhachHang";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvKhachHang.DataSource = data;
            gbKhachHang.Enabled = false;
        }



        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                txtTenKh.Text = dgvKhachHang.Rows[numrow].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[numrow].Cells[2].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[numrow].Cells[3].Value.ToString();
                txtEmail.Text = dgvKhachHang.Rows[numrow].Cells[4].Value.ToString();
            }
        }
        void loadNull()
        {
            txtTenKh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        int dem;
        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            dem = 1;
            gbKhachHang.Enabled = true ;
            loadNull();
            dgvKhachHang.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            dem = 2;
            gbKhachHang.Enabled = true;
            if (txtTenKh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnThemMoi.Enabled = false;
        }

        Boolean kiemTra(string tenkh)
        {
            string querry = "select * from KhachHang where tenkh = '" + tenkh + "'";
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
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            gbKhachHang.Enabled = false;
            loadNull();
            dgvKhachHang.Enabled = true;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    string makh = txtMaKh.Text;
                    string tenkh = txtTenKh.Text;
                    string diachi = txtDiaChi.Text;
                    string email = txtEmail.Text;
                    decimal sodienthoai = 0;
                    if (txtTenKh.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (kiemTra(tenkh) == true)
                    {
                        MessageBox.Show("Khách hàng đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            sodienthoai = decimal.Parse(txtSDT.Text);
                        }
                        catch
                        {

                            MessageBox.Show("Số điện thoại nhập không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                            
                        try
                        {
                            string querry = "insert into KhachHang(tenkh,diachi,sodienthoai,email) values(N'" + txtTenKh.Text + "',N'" + txtDiaChi.Text + "'," +
                                            "N'" + txtSDT.Text + "',N'" + txtEmail.Text + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadKH();
                        }
                        catch
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (dem == 2)
                {
                    string makh = txtMaKh.Text;
                    string tenkh = txtTenKh.Text;
                    string diachi = txtDiaChi.Text;
                    string email = txtEmail.Text;
                    decimal sodienthoai = 0;
                    if (txtTenKh.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn đối tượng muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtTenKh.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            sodienthoai = decimal.Parse(txtSDT.Text);
                        }
                        catch
                        {

                            MessageBox.Show("Số điện thoại nhập không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            string querry = "update KhachHang set tenkh = N'" + tenkh + "',diachi =N'" + diachi + "',sodienthoai='" + sodienthoai + "',email=N'" + email + "' where makh ='" + makh + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadKH();
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
            string tenKh = txtTenKh.Text;
            if (tenKh == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng muốn xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string querry = "delete KhachHang where tenkh = N'" + tenKh + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNull();
                    LoadKH();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
