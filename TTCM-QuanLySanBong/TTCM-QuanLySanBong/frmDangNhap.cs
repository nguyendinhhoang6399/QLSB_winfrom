using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCM_QuanLySanBong
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(picDangNhap, "Đăng Nhập");
            toolTip1.SetToolTip(txtTaiKhoan, "Nhập tài khoản");
            toolTip1.SetToolTip(txtPass, "Nhập mật khẩu");
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
        public static string Decrypt(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            if (ckboxLuuMK.Checked == true)
            {
                Properties.Settings.Default.UserName = txtTaiKhoan.Text;
                Properties.Settings.Default.Pass = txtPass.Text;
                Properties.Settings.Default.Save();
            }
            else if (ckboxLuuMK.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Pass = "";
                Properties.Settings.Default.Save();
            }
            string querry = "Select * from TaiKhoan where UserName='" + txtTaiKhoan.Text + "' and Pass='" + Encrypt(txtPass.Text) + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            if (txtTaiKhoan.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (data.Rows.Count > 0)
            {
                //MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string maNv = "";
                foreach (DataRow item in data.Rows)
                {
                    maNv = item["maNv"].ToString();
                }
                string querry1 = "select manv from taikhoan where username =N'" + txtTaiKhoan.Text + "'";
                DataTable data1 = KetNoi.Istance.ExcuteQuerry(querry1);
                foreach(DataRow item in data1.Rows)
                {
                    maNv = item["manv"].ToString();
                }
                FrmMain main = new FrmMain(maNv);
                this.Hide();
                main.ShowDialog();

            }
            else
            {
               
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void llaThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void llaDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            this.Hide();
            frmDangKy.ShowDialog();
            this.Show();
        }

        private void llaQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMK frmQuen = new frmQuenMK();
            this.Hide();
            frmQuen.ShowDialog();
            this.Show();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtTaiKhoan.Text = Properties.Settings.Default.UserName;
                txtPass.Text = Properties.Settings.Default.Pass;
            }
        }
    }
}
