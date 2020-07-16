using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TTCM_QuanLySanBong
{
    public partial class frmBaoCaoVonNH : Form
    {
        public frmBaoCaoVonNH()
        {
            InitializeComponent();
        }

        private void frmBaoCaoVonNH_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'QuanLySanBongDataSet2.LayNgay' table. You can move, or remove it, as needed.
            //this.LayNgayTableAdapter.Fill(this.QuanLySanBongDataSet2.LayNgay);
            //// TODO: This line of code loads data into the 'QuanLySanBongDataSet4.getPhieuNhap' table. You can move, or remove it, as needed.
            //this.getPhieuNhapTableAdapter.Fill(this.QuanLySanBongDataSet4.getPhieuNhap);
            //// TODO: This line of code loads data into the 'QuanLySanBongDataSet5.getTien' table. You can move, or remove it, as needed.
            //this.getTienTableAdapter.Fill(this.QuanLySanBongDataSet5.getTien);

            //this.reportViewer1.RefreshReport();
        }
        int bien = 0;
        private void btnXem_Click(object sender, EventArgs e)
        {
            string sql1 = "select NH.maphieu, NCC.tenncc,convert(nvarchar(30), NH.NgayNhap, 20)as NgayNhap,HH.tenhh,PN.dvt,PN.soluongnhap,PARSENAME(CONVERT(varchar, CAST(PN.gianhap AS money), 1), 2)as gianhap," +
                " PARSENAME(CONVERT(varchar, CAST(NH.thanhtien AS money), 1), 2)as thanhtien from PhieuNhap NH, NhaCungCap NCC, HangHoa HH, CTPhieuNhap PN" +
                " where NH.mancc=NCC.mancc and PN.mahh = HH.mahh and NH.maphieu = PN.maphieu and NH.NgayNhap" +
                " betWeen N'" + dtpTuNgay.Text + "' and N'" + dtpDenNgay.Text + "'";
            string sql2 = "select N'" + dtpTuNgay.Text + "'as tuNgay,N'" + dtpDenNgay.Text + "' as denNgay ";
            string sql3 = "select PARSENAME(CONVERT(varchar, CAST(sum(thanhTien) AS money), 1), 2)as thanhTien from PhieuNhap  where NgayNhap betWeen N'" + dtpTuNgay.Text + "' and N'" + dtpDenNgay.Text + "'";
            DataTable data1 = KetNoi.Istance.ExcuteQuerry(sql1);
            DataTable data2 = KetNoi.Istance.ExcuteQuerry(sql2);
            DataTable data3 = KetNoi.Istance.ExcuteQuerry(sql3);
            ReportDataSource rds = new ReportDataSource("DataSet2", data1);
            ReportDataSource rds1 = new ReportDataSource("DataSet1", data2);
            ReportDataSource rds2 = new ReportDataSource("DataSet3", data3);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            bien = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string path;
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (bien == 0)
            {
                MessageBox.Show("Hiện tại chưa có dữ liệu để xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                bool fileError = true;
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel(*.xls)|*.xls";
                    saveFileDialog.FileName = "TienNhapHang.xls";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileError = false;
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
                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;

                        byte[] bytes = reportViewer1.LocalReport.Render(
                           "Excel", null, out mimeType, out encoding,
                            out extension,
                           out streamids, out warnings);
                        System.Text.ASCIIEncoding x = new System.Text.ASCIIEncoding();
                        FileStream fs = new FileStream(saveFileDialog.FileName,
                          FileMode.Create);

                        fs.Write(bytes, 0, bytes.Length);

                        fs.Close();
                        path = Convert.ToString(Path.GetFullPath(saveFileDialog.FileName));
                        MessageBox.Show("In Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch
                {
                    MessageBox.Show("Xuất không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("hoanglaptrinh6399@gmail.com", "dinhhoang0603");

                MailMessage message = new MailMessage("hoanglaptrinh6399@gmail.com", "trumpbaby6969@gmail.com");
                message.Subject = "BÁO CÁO TIỀN NHẬP HÀNG SÂN BÓNG";
                message.Body = "Gửi admin báo cáo doanh thu " + dtpTuNgay.Value.ToString() + " đến ngày " + dtpDenNgay.Value.ToString();
                message.Attachments.Add(new Attachment(Convert.ToString(path)));

                mailclient.Send(message);
                message = null;
                MessageBox.Show("Mail đã được gửi đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Báo cáo chưa được gửi do lỗi mạng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            if (bien == 0)
            {
                MessageBox.Show("Hiện tại chưa có dữ liệu để xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                string query = "select convert(nvarchar(30), NgayNhap, 23)as NgayNhap,sum(ThanhTien)as ThanhTien" +
                    " from PhieuNhap  where NgayNhap between N'" + dtpTuNgay.Text + "' and N'" + dtpDenNgay.Text + "' group by convert(nvarchar(30), NgayNhap, 23)";

                this.Hide();
                frmBieuDo2 fbd = new frmBieuDo2(query);
                fbd.ShowDialog();
                this.Show();
            }
        }
    }
}
