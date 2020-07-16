using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app = Microsoft.Office.Interop.Excel.Application;

using System.Windows.Forms;
using Guna.UI.WinForms;
using System.IO;

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
            toolTip1.SetToolTip(btnLamMoi, "Làm mới");
        }
        
        void LoadPhieuN()
        {
            string querry = "select PN.maphieu, HH.tenhh, ctPN.dvt, ctPN.soluongnhap,PARSENAME(CONVERT(varchar, CAST(ctPN.gianhap AS money), 1), 2) as gianhap, NCC.tenncc from phieuNhap PN, hanghoa HH, CTphieuNhap ctPN, nhacungcap NCC where PN.maphieu = ctPN.maphieu and ctPN.mahh = HH.mahh and ctPN.mancc = NCC.mancc";
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
                cboxDVT.Text = dgvNhapHang.Rows[numrow].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvNhapHang.Rows[numrow].Cells[3].Value.ToString();
                txtGiaNhap.Text = dgvNhapHang.Rows[numrow].Cells[4].Value.ToString();
                cboxNcc.Text = dgvNhapHang.Rows[numrow].Cells[5].Value.ToString();
            }
        }
        void loadNull()
        {
            cboxMaPhieu.Text = "";
            cboxTenHang.Text = "";
            cboxDVT.Text = "";
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
            
            if (cboxMaPhieu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThemMoi.Enabled = true;
                btnXoa.Enabled = true;
                gbPhieuNhap.Enabled = false;
            }
            else
            {
                btnThemMoi.Enabled = false;
                btnXoa.Enabled = false;
                gbPhieuNhap.Enabled = true;
            }
            
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
                    string dvt = cboxDVT.Text;
                    string tenNcc = cboxNcc.Text;
                    decimal soLuong, gia = 0;
                    if (cboxTenHang.Text == "" || cboxDVT.Text == "" || txtSoLuong.Text == "" || txtGiaNhap.Text == "" || cboxNcc.Text == "")
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
                            string querry = "insert into CTPhieuNhap values(N'" + cboxMaPhieu.Text + "',N'" + cboxDVT.Text + "'," +
                                            "N'" + txtSoLuong.Text + "',N'" + txtGiaNhap.Text + "',N'" + cboxTenHang.SelectedValue + "',N'" + cboxNcc.SelectedValue + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            string querry1 = "update PhieuNhap set mancc = '" + cboxNcc.SelectedValue + "' where maphieu='"+cboxMaPhieu.Text+"'";
                            DataTable data1 = KetNoi.Istance.ExcuteQuerry(querry1); 
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
                    string dvt = cboxDVT.Text;
                    string tenNcc = cboxNcc.Text;
                    decimal soLuong, gia = 0;
                    if (cboxMaPhieu.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn đối tượng muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (cboxTenHang.Text == "" || cboxDVT.Text == "" || txtSoLuong.Text == "" || txtGiaNhap.Text == "" || cboxNcc.Text =="")
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
        
        void LoadThanhTien()
        {
            string querry = "select PARSENAME(CONVERT(varchar, CAST(ThanhTien AS money), 1), 2) as ThanhTien from PhieuNhap where maphieu = N'" + cboxMaPhieu.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxThanhTien.DataSource = data;
            cboxThanhTien.DisplayMember = "ThanhTien";
            //cboxThanhTien.ValueMember = "maPhieu";
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            LoadThanhTien();
            if (cboxMaPhieu.Text == "")
            {
                MessageBox.Show("Chưa có dữ liệu để in");

            }
            else
            {
                exportExel();
            }
        }
        private void exportExel()
        {
            bool fileError = false;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLSX(*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "PhieuNhapHang.xlsx";
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
                    obj.Rows[6].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    obj.Rows[3].Font.Bold = true;
                    obj.Rows[4].Font.Bold = true;
                    obj.Rows[5].Font.Bold = true;
                   
                    obj.Cells[1, 1] = "         Phiếu Nhập Hàng    ";
                    obj.Cells[2, 1] = "Mã Phiếu: " + cboxMaPhieu.Text;
                    obj.Cells[2, 2] = "Ngày Lập: " + DateTime.Now;
                    

                    obj.Cells[5, 1] = "Tên Hàng Hóa ";
                    obj.Cells[5, 2] = "Đơn Vị Tính ";
                    obj.Cells[5, 3] = "Số Lượng Nhập ";
                    obj.Cells[5, 4] = "Giá Nhập ";
                    obj.Cells[5, 1] = "Tên Nhà Cung Cấp ";

                    obj.Cells[6, 1] = cboxTenHang.Text;
                    obj.Cells[6, 2] = cboxDVT.Text;
                    obj.Cells[6, 3] = txtSoLuong.Text;
                    obj.Cells[6, 4] = txtGiaNhap.Text;
                    obj.Cells[6, 5] = cboxNcc.Text;

                    obj.Cells[8, 1] = "Tiền Nhập Hàng: " + cboxThanhTien.Text;
                    obj.Rows[8].Font.Color = Color.Red;
                    obj.Rows[8].Font.Bold = true;
                    obj.Rows[8].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadNcc();
        }
    }
}
