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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
            LoadNcc();
        }

        void LoadNcc()
        {
            string querry = "select * from NhaCungCap";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvNcc.DataSource = data;
            gboxNcc.Enabled = false;
        }
 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                txtTenNcc.Text = dgvNcc.Rows[numrow].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNcc.Rows[numrow].Cells[2].Value.ToString();
                txtSDT.Text = dgvNcc.Rows[numrow].Cells[3].Value.ToString();
            }
        }
        void loadNull()
        {
            txtTenNcc.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        int dem;

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            dem = 1;
            gboxNcc.Enabled = true;
            loadNull();
            dgvNcc.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dem = 2;
            
            if (txtTenNcc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThemMoi.Enabled = true;
                btnXoa.Enabled = true;
                gboxNcc.Enabled = false;
            }
            else
            {
                btnThemMoi.Enabled = false;
                btnXoa.Enabled = false;
                gboxNcc.Enabled = true;
            }
           
        }
        Boolean kiemTra(string tenNcc)
        {
            string querry = "select * from NhaCungCap where tenNcc = '" + tenNcc + "'";
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
            gboxNcc.Enabled = false;
            loadNull();
            dgvNcc.Enabled = true;
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
                    string maNcc = txtMaNcc.Text;
                    string tenNcc = txtTenNcc.Text;
                    string diachi = txtDiaChi.Text;
                    
                    decimal sodienthoai = 0;
                    if (txtTenNcc.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" )
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (kiemTra(tenNcc) == true)
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
                            string querry = "insert into NhaCungCap(tenncc,diachi,sodienthoai) values(N'" + txtTenNcc.Text + "',N'" + txtDiaChi.Text + "'," +
                                            "N'" + txtSDT.Text + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadNcc();
                            dgvNcc.Enabled = true;
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (dem == 2)
                {
                    string maNcc = txtMaNcc.Text;
                    string tenNcc = txtTenNcc.Text;
                    string diachi = txtDiaChi.Text;
                    
                    decimal sodienthoai = 0;
                    if (txtTenNcc.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn đối tượng muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtTenNcc.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" )
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
                            string querry = "update NhaCungCap set tenNcc = N'" + tenNcc + "',diachi =N'" + diachi + "',sodienthoai='" + sodienthoai + "' where maNcc ='" + maNcc + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadNcc();
                            btnThemMoi.Enabled = true;
                            btnXoa.Enabled = true;
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

            string tenNcc = txtTenNcc.Text;
            if (tenNcc == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng muốn xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string querry = "delete NhaCungCap where tenNcc = N'" + tenNcc + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNull();
                    LoadNcc();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
