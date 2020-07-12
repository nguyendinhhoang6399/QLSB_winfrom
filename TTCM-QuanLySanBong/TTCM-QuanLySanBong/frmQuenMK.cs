using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace TTCM_QuanLySanBong
{
    public partial class frmQuenMK : Form
    {
        public frmQuenMK()
        {
            InitializeComponent();
        }
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string querry1 = "select * from TaiKhoan where userName = '" + txtTaiKhoan.Text + "'";
            DataTable data1 = KetNoi.Istance.ExcuteQuerry(querry1);
            if (data1.Rows.Count == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                try
                {
                    string querry = "select email from NhanVien nv, TaiKhoan tk where tk.maNv = nv.MaNv and tk.userName = '" + txtTaiKhoan.Text + "'";
                    string email = "";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    foreach (DataRow row in data.Rows)
                        email = row["email"].ToString();
                    
                    string query2 = "select pass from TaiKhoan  where userName=N'" + txtTaiKhoan.Text + "'";
                    string mk = "";
                    DataTable data2 = KetNoi.Istance.ExcuteQuerry(query2);
                    foreach (DataRow row in data1.Rows)
                        mk = Decrypt(row["pass"].ToString());

                    SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
                    mailClient.EnableSsl = true;
                    mailClient.Credentials = new NetworkCredential("hoanglaptrinh6399@gmail.com", "dinhhoang0603");

                    MailMessage message = new MailMessage("hoanglaptrinh6399@gmail.com", email);
                    message.Subject = "Password tài khoản" + txtTaiKhoan.Text + "đã quên mật khẩu";
                    message.Body = "Mật khẩu của tài khoản " + txtTaiKhoan.Text + " là:" + "\n" + mk;

                    mailClient.Send(message);
                    message = null;
                    MessageBox.Show("Báo cáo đã được gửi! Check Mail để nhận lại mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch
                {
                    MessageBox.Show("Báo cáo chưa được gửi do lỗi mạng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
        }
    }
}
