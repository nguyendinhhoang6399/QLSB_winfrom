using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using app = Microsoft.Office.Interop.Excel.Application;
using Guna.UI.WinForms;

namespace TTCM_QuanLySanBong
{
    public partial class UserHDNhapHang : UserControl
    {
        public UserHDNhapHang()
        {
            InitializeComponent();
            LoadPhieuNhap();
        }
        void LoadPhieuNhap()
        {
            string querry = "select NH.maphieu, NCC.tenncc,HH.tenhh,PN.dvt,PN.soluongnhap,PARSENAME(CONVERT(varchar, CAST(PN.gianhap AS money), 1), 2) as gianhap, PARSENAME(CONVERT(varchar, CAST(NH.thanhtien AS money), 1), 2) as thanhtien from PhieuNhap NH, NhaCungCap NCC, HangHoa HH, CTPhieuNhap PN where NH.mancc=NCC.mancc and PN.mahh = HH.mahh and NH.maphieu = PN.maphieu";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDsNhapHang.DataSource = data;
        }
        private void exportExel(GunaDataGridView dgvDsNhapHang)
        {
            bool fileError = false;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLSX(*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "ThongKeHoaDonNhapHang.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog.FileName);
                        }
                        catch
                        {
                            fileError = true;
                        }
                    }
                }
                if (!fileError)
                {
                    app obj = new app();
                    obj.Application.Workbooks.Add(Type.Missing);
                    obj.Columns.ColumnWidth = 35;
                    obj.StandardFontSize = 13;
                    obj.Cells[1].Font.Bold = true;
                    obj.Rows[2].Font.Bold = true;

                    obj.Rows[1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[3].Font.Bold = true;
                    obj.Rows[4].Font.Bold = true;
                   
                    int dem1 = 3;
                    obj.Cells[1, 1] = "         Thống Kê Hóa Đơn Nhập Hàng     ";
                    obj.Cells[2, 1] = "Ngày Lập: " + DateTime.Now;


                    if (dgvDsNhapHang.RowCount > 0)
                    {

                        for (int i = 1; i < dgvDsNhapHang.Columns.Count + 1; i++)
                        {

                            obj.Cells[4, i] = dgvDsNhapHang.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < dgvDsNhapHang.Rows.Count; i++)
                        {
                            dem1 += 1;
                            obj.Rows[dem1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            for (int j = 0; j < dgvDsNhapHang.Columns.Count; j++)
                            {
                                if (dgvDsNhapHang.Rows[i].Cells[j].Value != null)
                                {
                                    obj.Cells[i + 5, j + 1] = dgvDsNhapHang.Rows[i].Cells[j].Value.ToString();
                                }
                                else
                                {
                                    obj.Cells[i + 5, j + 1] = "";
                                }
                            }
                        }
                    }


                    obj.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                    obj.ActiveWorkbook.Saved = true;
                    MessageBox.Show("Xuất thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //try
                    //{
                    //    string dcmail = "";
                    //    string querry = "select email from khachhang where tenkh = N'" + cbTenKh.Text + "'";
                    //    DataTable DL = KetNoi.Istance.ExcuteQuerry(querry);
                    //    foreach (DataRow row in DL.Rows)
                    //    {
                    //        dcmail = row["email"].ToString();
                    //    }
                    //    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    //    mailclient.EnableSsl = true;
                    //    mailclient.Credentials = new NetworkCredential("hoanglaptrinh6399@gmail.com", "dinhhoang0603");

                    //    MailMessage message = new MailMessage("hoanglaptrinh6399@gmail.com", dcmail);
                    //    message.Subject = "THƯ CẢM ƠN KHÁCH HÀNG CỦA BENRI FARM";
                    //    message.Body = "Cảm ơn quý khách hàng " + cbTenKh.Text + " đã tin tưởng Benri Farm! " + "\n" + "Kính mong quý khách sẽ tiếp tục ủng hộ!" + "\n" +
                    //        "Thân ái!";

                    //    mailclient.Send(message);
                    //    message = null;
                    //    Alert b = new Alert("Mail đã được gửi đi!", AlertType.success);
                    //    b.ShowDialog();
                    //}
                    //catch
                    //{
                    //    Alert b = new Alert("Báo cáo chưa được gửi do lỗi mạng!", AlertType.info);
                    //    b.ShowDialog();
                    //}
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            exportExel(dgvDsNhapHang);
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            LoadPhieuNhap();
        }
    }
}
