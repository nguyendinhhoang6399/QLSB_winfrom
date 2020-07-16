using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace TTCM_QuanLySanBong
{
    public partial class UserNhanSu : UserControl
    {
        public UserNhanSu()
        {
            InitializeComponent();
            LoadNV();
            loadCongViec();
            LoadNullCV();
            
            panTTCv.Enabled = false;
            LoadNullCV();
            LoadTkNv();
            
            panTTTK.Enabled = false;
            panDoiMK.Enabled = false;
        }
        
        void LoadNV()
        {
            string querry = "select * from NhanVien";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvNhanVien.DataSource = data;
            panTTNv.Enabled = false;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                txtMaNv.Text = dgvNhanVien.Rows[numrow].Cells[0].Value.ToString();
                txtTenNv.Text = dgvNhanVien.Rows[numrow].Cells[1].Value.ToString();
                cboxGioiTinh.Text = dgvNhanVien.Rows[numrow].Cells[2].Value.ToString();
                dtpNgayVaoLam.Text = dgvNhanVien.Rows[numrow].Cells[3].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[numrow].Cells[4].Value.ToString();
                txtEmail.Text = dgvNhanVien.Rows[numrow].Cells[5].Value.ToString();
            }
            linkCapTk.Visible = true;
        }
        void loadNull()
        {
            txtMaNv.Text = "";
            txtTenNv.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            cboxGioiTinh.Text = "";
        }
        int dem;
        

        private void btnSuaNv_Click(object sender, EventArgs e)
        {
            dem = 2;
            
            if (txtMaNv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThemNv.Enabled = true;
                btnXoaNv.Enabled = true;
                panTTNv.Enabled = false;
            }
            else
            {
                btnThemNv.Enabled = false;
                btnXoaNv.Enabled = false;
                panTTNv.Enabled = true;
            }
            
        }
        Boolean kiemTra(string manv)
        {
            string querry = "select * from NhanVien where maNv = '" + manv + "'";
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

        private void btnHuyNv_Click(object sender, EventArgs e)
        {
            panTTNv.Enabled = false;
            loadNull();
            dgvNhanVien.Enabled = true;
            btnThemNv.Enabled = true;
            btnSuaNv.Enabled = true;
            btnXoaNv.Enabled = true;
            
        }

        private void btnLuuNv_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem == 1)
                {
                    string manv = txtMaNv.Text;
                    string tennv = txtTenNv.Text; 
                    string email = txtEmail.Text;
                    decimal sodienthoai = 0;
                    if (txtMaNv.Text == ""|| txtTenNv.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || dtpNgayVaoLam.Text == "" || cboxGioiTinh.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (kiemTra(manv) == true)
                    {
                        MessageBox.Show("Nhân viên đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            string querry = "insert into NhanVien values(N'" + txtMaNv.Text + "',N'" + txtTenNv.Text + "'," +
                                            "N'" + cboxGioiTinh.Text + "',N'" + dtpNgayVaoLam.Text + "',N'" + txtSDT.Text + "',N'" + txtEmail.Text + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadNV();
                            btnSuaNv.Enabled = true;
                            btnXoaNv.Enabled = true;
                            dgvNhanVien.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (dem == 2)
                {
                    string manv = txtMaNv.Text;
                    string tennv = txtTenNv.Text;
                    string email = txtEmail.Text;
                    decimal sodienthoai = 0;
                    
                    if (txtMaNv.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn đối tượng muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtMaNv.Text == "" || txtTenNv.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || dtpNgayVaoLam.Text == "" || cboxGioiTinh.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            string querry = "update NhanVien set tennv = N'" + tennv + "',gioitinh =N'" + cboxGioiTinh.Text + "',ngayvaolam='" + dtpNgayVaoLam.Text + "',sodienthoai='" + sodienthoai + "',email=N'" + email + "' where manv ='" + manv + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadNV();
                            btnThemNv.Enabled = true;
                            btnXoaNv.Enabled = true;

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

        private void btnXoaNv_Click(object sender, EventArgs e)
        {
            string manv = txtMaNv.Text;
            if (manv == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng muốn xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string querry = "delete NhanVien where manv = N'" + manv + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNull();
                    LoadNV();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThemNv_Click(object sender, EventArgs e)
        {
            dem = 1;

            loadNull();
            panTTNv.Enabled = true;
            dgvNhanVien.Enabled = false;
            btnSuaNv.Enabled = false;
            btnXoaNv.Enabled = false;
        }

        void loadCongViec()
        {
            
            try
            {
                string query = "Select * from PhanViec where manv not like 'A000'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                dgvCongViec.DataSource = data;
            }
            catch
            {
                MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void loadNvPQ()
        {
            string query = "select * from NhanVien where maNv not like N'A000'";
            DataTable Data = KetNoi.Istance.ExcuteQuerry(query);

            cboxMaNv.DataSource = Data;
            cboxMaNv.DisplayMember = "maNv";
            cboxMaNv.ValueMember = "maNv";
            cboxMaNv.SelectedIndex = -1;
        }
        void loadTenCV()
        {
            List<string> listCv = new List<string>();
            listCv.Add("Quản Lý Tính Tiền");
            listCv.Add("Quản Lý Đặt Sân");
            listCv.Add("Quản Lý Hóa Đơn");           
            listCv.Add("Admin");
            cboxTenCv.DataSource = listCv;
            cboxTenCv.SelectedIndex = -1;
        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                cboxMaNv.Text = dgvCongViec.Rows[numrow].Cells[0].Value.ToString();
                txNhap.Text = dgvCongViec.Rows[numrow].Cells[0].Value.ToString();
                cboxTenCv.Text = dgvCongViec.Rows[numrow].Cells[1].Value.ToString();
            }
        }
        int tam;
        private void btnThemCv_Click(object sender, EventArgs e)
        {
            panTTCv.Enabled = true;
            tam = 1;
            btnThemCv.Enabled = false;
            btnXoaCv.Enabled = false;
            groupBox1.Enabled = false;
            LoadNullCV();
            loadNvPQ();
            loadTenCV();
        }

        private void btnLuuCv_Click(object sender, EventArgs e)
        {

            try
            {
                if (tam == 1)
                {
                    string query = "Insert into PhanViec values('" + cboxMaNv.Text + "',N'" + cboxTenCv.Text + "')";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    loadCongViec();
                    LoadNullCV();
                    panTTCv.Enabled = false;
                    dem = 0;
                    btnThemCv.Enabled = true;
                    btnXoaCv.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaCv_Click(object sender, EventArgs e)
        {
            if (txNhap.Text == "")
            {
                MessageBox.Show("Hãy chọn nhân viên cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                try
                {
                    string query = "Delete PhanViec where maNv='" + cboxMaNv.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    loadCongViec();
                    LoadNullCV();
                    panTTCv.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void LoadNullCV()
        {
            cboxMaNv.Text = "";
            cboxTenCv.Text = "";
        }
        private void btnHuyCv_Click(object sender, EventArgs e)
        {
            panTTCv.Enabled = false;
            dgvCongViec.ClearSelection();
            loadCongViec();
            LoadNullCV();
            tam = 0;
            btnThemCv.Enabled = true;
            btnXoaCv.Enabled = true;
        }
        void LoadTkNv()
        {
            try
            {
                string querry = "select NV.TenNv, TK.username from NhanVien NV , TaiKhoan TK where TK.maNv = NV.MaNv and TK.manv not like 'A000' ";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                dgvTaiKhoan.DataSource = data;
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            panTTTK.Enabled = false;
            panDoiMK.Enabled = false;

        }
        private void btnXoaTk_Click(object sender, EventArgs e)
        {
            if (txtTenNvTk.Text == "")
            {
                MessageBox.Show("Chọn tài khoản muốn xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                try
                {
                    string querry = "delete account where tennv = '" + txtTenNvTk.Text + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    LoadTkNv();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int numrow;
            numrow = e.RowIndex;

            txtTenNvTk.Text = dgvTaiKhoan.Rows[numrow].Cells[0].Value.ToString();
            txtTenTk.Text = dgvTaiKhoan.Rows[numrow].Cells[1].Value.ToString();
            //panDoiMK.Enabled = true;
        }
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";
        public static string Encrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }
        int demTK = 0;
        private void btnSuaTk_Click(object sender, EventArgs e)
        {
            if(txtTenNvTk.Text == "ADMIN")
            {
                MessageBox.Show("Không thể đổi mật khẩu admin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTenNvTk.Text == "")
            {
                MessageBox.Show("Hãy chọn tài khoản cần đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                panDoiMK.Enabled = true;
                demTK = 1;
                btnXoaTk.Enabled = false;

            }
        }

        private void btnLuuTk_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenTk.Text;
            try
            {
                if (demTK == 1)
                {
                    if (txtMKLan1.Text != txtMKLan2.Text)
                    {
                        MessageBox.Show("Mật khẩu nhập lại không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMKLan2.Text = "";
                        txtMKLan2.Focus();
                        
                    }
                    else
                    {
                        string query = "Update taikhoan set pass='" + Encrypt(txtMKLan1.Text) + "' where username='" + tendangnhap + "'";
                        DataTable data = KetNoi.Istance.ExcuteQuerry(query);
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        btnXoaTk.Enabled = true;
                        panDoiMK.Enabled = false;
                        LoadNullTKNV();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void LoadNullTKNV()
        {
            txtTenNvTk.Text = "";
            txtTenTk.Text = "";
            txtMKLan1.Text = "";
            txtMKLan2.Text = "";
        }
        private void btnHuyTk_Click(object sender, EventArgs e)
        {
            LoadNullTKNV();
            panDoiMK.Enabled = false;
            btnXoaTk.Enabled = true;
        }
        bool kiemtraTkTonTai(string maNv)
        {
            string query = "Select * from taikhoan where maNv='" + maNv + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        private void linkCapTk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (kiemtraTkTonTai(txtMaNv.Text) == true)
            {
                MessageBox.Show("Mỗi nhân viên chỉ có một tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                this.Hide();
                frmDangKy fdk = new frmDangKy(txtMaNv.Text);

                fdk.ShowDialog();
                this.Show();
            }
        }

        private void btnResetTK_Click(object sender, EventArgs e)
        {
            LoadTkNv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadNvPQ();
        }
    }
}
