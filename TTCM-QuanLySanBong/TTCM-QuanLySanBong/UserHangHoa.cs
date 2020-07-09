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
            LoadHH();
        }

        void LoadHH()
        {
            string querry = "select * from  HangHoa";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvHangHoa.DataSource = data;
            panHangHoa.Enabled = false;
        }


        private void btnBangGia_Click(object sender, EventArgs e)
        {
            frmNhapHang nhapHang = new frmNhapHang();
            
            nhapHang.ShowDialog();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                txtMaHang.Text = dgvHangHoa.Rows[numrow].Cells[0].Value.ToString();
                txtTenHang.Text = dgvHangHoa.Rows[numrow].Cells[1].Value.ToString();
                txtDVT.Text = dgvHangHoa.Rows[numrow].Cells[2].Value.ToString();
                txtSLTon.Text = dgvHangHoa.Rows[numrow].Cells[3].Value.ToString();
                txtDonGia.Text = dgvHangHoa.Rows[numrow].Cells[4].Value.ToString();
                
            }
        }
        void loadNull()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtDVT.Text = "";
            txtDonGia.Text = "";
            txtSLTon.Text = "";
        }
        
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            panHangHoa.Enabled = true;
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnXoa.Enabled = false;
            dgvHangHoa.Enabled = false;
            
        }
        Boolean kiemTra(string mahh)
        {
            string querry = "select * from HangHoa where mahh = '" + mahh + "'";
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
            panHangHoa.Enabled = false;
            loadNull();
            dgvHangHoa.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvHangHoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                    string mahh = txtMaHang.Text;
                    string tenhh = txtTenHang.Text;
                    string dvt = txtDVT.Text;
                    string slTon = txtSLTon.Text;
                    decimal dongia = 0;
                    if (txtMaHang.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn đối tượng muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtTenHang.Text == "" || txtDonGia.Text == "" || txtDVT.Text == "" || txtSLTon.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            dongia = decimal.Parse(txtDonGia.Text);
                        }
                        catch
                        {

                            MessageBox.Show("Đơn giá nhập không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            string querry = "update HangHoa set tenhh = N'" + tenhh + "',dvt = N'" + dvt + "',soluongton ='" + slTon + "',dongia=N'" + dongia + "' where mahh ='" + mahh + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadHH();
                        dgvHangHoa.Enabled = true;
                        btnXoa.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Sửa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string mahh = txtMaHang.Text;
            if (mahh == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng muốn xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string querry = "delete HangHoa where mahh = N'" + mahh + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNull();
                    LoadHH();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frmNhapHang = new frmNhapHang();
            frmNhapHang.ShowDialog();
        }

        
    }
}
