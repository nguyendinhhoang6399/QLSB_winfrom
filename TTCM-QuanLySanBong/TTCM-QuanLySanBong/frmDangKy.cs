using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCM_QuanLySanBong
{
    public partial class frmDangKy : Form
    {
        private string manv = null;
        public frmDangKy(string maNv = null)
        {
            this.manv = maNv;
            InitializeComponent();
            
        }
        public string Manv { get => manv; set => manv = value; }
        bool kiemtraTenTK(string UserName)
        {
            string query = "select * from TaiKhoan where tenDn=N'" + UserName + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            return data.Rows.Count > 0;
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
        bool kiemtraMaNv(string maNv)
        {
            string query = "Select * from NhanVien where maNv='" + maNv + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        bool kiemtraTkTonTai(string maNv)
        {
            string query = "Select * from TaiKhoan where maNv='" + maNv + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtMatKhau2.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (kiemtraMaNv(txtMaNv.Text) == false)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (kiemtraTkTonTai(txtMaNv.Text) == true)
            {
                MessageBox.Show("Mỗi nhân viên chỉ có một tài khoản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if (kiemtraTenTK(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên Tài khoản đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtMatKhau.Text != txtMatKhau2.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            else
            {
                string query;
                if (Manv == null)
                    query = "Insert into account values(N'" + txtTaiKhoan.Text + "',N'" + Encrypt(txtMatKhau.Text) + "','2','" + txtMaNv.Text + "')";
                else
                    query = "Insert into account values(N'" + txtTaiKhoan.Text + "',N'" + Encrypt(txtMatKhau.Text) + "','2','" + Manv + "')";

                DataTable data = KetNoi.Istance.ExcuteQuerry(query);

                MessageBox.Show("Đăng ký thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.ResetText();
                txtMatKhau.ResetText();
                txtMatKhau2.ResetText();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
