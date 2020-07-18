using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;
using Guna.UI.WinForms;
using System.IO;

namespace TTCM_QuanLySanBong
{
    public partial class UserTinhTien : UserControl
    {
        public UserTinhTien()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnThem, "Thêm");
            toolTip1.SetToolTip(btnXoa, "Xóa");
            
            toolTip1.SetToolTip(btnBatDau, "Bắt đầu");
            toolTip1.SetToolTip(btnDoiSan, "Đổi sân");
            toolTip1.SetToolTip(btnHuySan, "Hủy sân");
            toolTip1.SetToolTip(btnIn, "In hóa đơn");
            
            toolTip1.SetToolTip(btnLamMoi, "Làm mới");
            LoadDV();
            LoadSan5();
            LoadSan7();
            LoadKh();
            LoadcboxMH();
            dtpGioVao.Value = DateTime.Now;
            panTinhTien.Enabled = false;
            gbDv.Enabled = false;
            dgvDichVu.Enabled = false;
        }
        public string MaNv
        {
            set
            {
                lbMaNv.Text = value;
            }
        }

        void LoadDV()
        {
            try
            {
                string querry = "Select tenHh,PARSENAME(CONVERT(varchar, CAST(dongia AS money), 1), 2) as dongia from HangHoa";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                dgvDichVu.DataSource = data;

            }
            catch
            {
                MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void LoadKh()
        {
            string querry = "select * from khachhang";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cbKhachHang.DataSource = data;
            cbKhachHang.DisplayMember = "tenkh";
            cbKhachHang.ValueMember = "makh";
            cbKhachHang.SelectedIndex = -1;
        }
        void LoadSan5()
        {
            try
            {
                PanSan5.Controls.Clear();
                string querry = "select * from San where mals = '"+ 1 +"'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                foreach (DataRow item in data.Rows)
                {
                    Button bt = new Button() { Width = 140, Height = 100 };
                    bt.BackgroundImage = TTCM_QuanLySanBong.Properties.Resources.icons8_stadium_96;
                    bt.BackgroundImageLayout = ImageLayout.Stretch;
                    bt.BackColor = Color.YellowGreen;
                    bt.Text = item["tenSan"] + "\n";
                    bt.TextAlign = ContentAlignment.BottomCenter;
                    bt.Tag = item["maSan"];
                    bt.Name = item["tenSan"].ToString();
                    bt.Click += bt_clicksan5;
                    bt.Cursor = Cursors.Hand;

                    //if (item["trangthai"].ToString() == "Đang hoạt động")
                    //{

                    //    bt.BackColor = Color.Red;
                    //    bt.ForeColor = Color.White;
                    //    //bt.Text += "(Đầy !)";
                    //}
                    //else
                    //{

                    //    bt.BackColor = Color.YellowGreen;
                    //}

                    PanSan5.Controls.Add(bt);
                }
            }catch
            {
                MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void getGioVaoRa()
        {
            string sql = "Select * from hoadon where maHd='" + cboxMaHd.Text + "'";
            DataTable dataTable = KetNoi.Istance.ExcuteQuerry(sql);
            foreach(DataRow row in dataTable.Rows)
            {
                dtpGioVao.Text = row["GioBatDau"].ToString();
                dtpGioRa.Text = row["GioKetThuc"].ToString();
            }
        }
        private void bt_clicksan5(object sender, EventArgs e)
        {
           
            string tenSan = (sender as Button).Name;
            string maSan = (sender as Button).Tag.ToString();
            lbSanName.Text = tenSan;
            lbMaSan.Text = maSan;
            string query = "select * from HoaDon where maSan='" + lbMaSan.Text + "' and trangThai=N'Chưa Thanh Toán'";
            
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            if(data.Rows.Count>0)
            {
                panTinhTien.Enabled = false;
                LoadMaHD();
                Loadgv();
                loadTT();
                loadTienSanAndichVu();
                gbDv.Enabled = true;
                dgvDichVu.Enabled = true;
                getGioVaoRa();
            }
            else
            {
                panTinhTien.Enabled = true;
                dgvDichVu.Enabled = true;
                
            }
            PanSan5.Enabled = false;
            PanSan7.Enabled = false;

        }

        void LoadSan7()
        {
            try
            {
                PanSan7.Controls.Clear();
                string querry = "select * from San where mals = '" + 2 + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                foreach (DataRow item in data.Rows)
                {
                    Button bt = new Button() { Width = 140, Height = 100 };
                    bt.BackgroundImage = TTCM_QuanLySanBong.Properties.Resources.icons8_stadium_96;
                    bt.BackgroundImageLayout = ImageLayout.Stretch;
                    bt.BackColor = Color.YellowGreen;
                    bt.Text = item["tenSan"] + "\n";
                    bt.TextAlign = ContentAlignment.BottomCenter;
                    bt.Tag = item["maSan"];
                    bt.Name = item["tenSan"].ToString();
                    bt.Cursor = Cursors.Hand;
                    bt.Click += bt_click;
                    PanSan7.Controls.Add(bt);
                   
                }
            }
            catch
            {
                MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_click(object sender, EventArgs e)
        {

            string tenSan = (sender as Button).Name;
            string maSan = (sender as Button).Tag.ToString();
            lbSanName.Text = tenSan;
            lbMaSan.Text = maSan;
            string query = "select * from HoaDon where maSan='" + lbMaSan.Text + "' and trangThai=N'Chưa Thanh Toán'";

            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            if (data.Rows.Count > 0)
            {
                panTinhTien.Enabled = false;
                LoadMaHD();
                Loadgv();
                gbDv.Enabled = true;
                dgvDichVu.Enabled = true;
                loadTT();
                loadTienSanAndichVu();
                getGioVaoRa();
            }
            else
            {
                panTinhTien.Enabled = true;
                dgvDichVu.Enabled = true;

            }
            PanSan5.Enabled = false;
            PanSan7.Enabled = false;
      
        }

        void LoadcboxMH()
        {
            
            string querry = "select * from hanghoa";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxMatHang.DataSource = data;
            cboxMatHang.DisplayMember = "tenhh";
            cboxMatHang.ValueMember = "mahh";
            cboxMatHang.SelectedIndex = -1;
        }
        private void btnDoiSan_Click(object sender, EventArgs e)
        {
            lbSanName.Text = "Sân";
            Loadnull();
            panTinhTien.Enabled = false;
            if (dgvTinhTien.RowCount > 0 && dgvTinhTien.DataSource !=null)
                ((DataTable)dgvTinhTien.DataSource).Rows.Clear();
            gbDv.Enabled = false;
            dgvDichVu.Enabled = false;
            PanSan5.Enabled = true;
            PanSan7.Enabled = true;

            txtTienDichVu.ResetText();
            txtTienSan.ResetText();
            txtTongTien.ResetText();
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            cboxMatHang.Text = dgvDichVu.Rows[numrow].Cells[0].Value.ToString();
            cboxDonGia.Text = dgvDichVu.Rows[numrow].Cells[1].Value.ToString();
        }
        
        void LoadMaHD()
        {
            string querry = "select top 1 with ties mahd from HoaDon where manv =N'" + lbMaNv.Text + "' and masan ='" + lbMaSan.Text + "' order by (maHd) DESC";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxMaHd.DataSource = data;
            cboxMaHd.DisplayMember = "mahd";
        }
        
       
        private void cboxMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "select PARSENAME(CONVERT(varchar, CAST(dongia AS money), 1), 2) as dongia from hanghoa where tenhh = N'" + cboxMatHang.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxDonGia.DataSource = data;
            cboxDonGia.DisplayMember = "dongia"; 
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            string gioV = dtpGioVao.Value.ToShortTimeString();
            string gioR = dtpGioRa.Value.ToShortTimeString();

        }

        private void btnThemKh_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.ShowDialog();
            //LoadcboxMH();
        }
         void Loadnull()
        {
            cbKhachHang.Text = "";
            
            dtpGioRa.Text = "00:00";
        }
        void loadNullHH()
        {
            cboxMatHang.Text = "";
            numUpSL.Value = 0;
            cboxDonGia.Text = "";
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string querry = "delete CTHoaDon where mahh = N'" + cboxMatHang.SelectedValue + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            Loadgv();
            loadTT();
        }
        void Loadgv()
        {
            string querry1 = "select HH.tenhh,CT.soluongban,PARSENAME(CONVERT(varchar, CAST(CT.dongia AS money), 1), 2) as dongia,PARSENAME(CONVERT(varchar, CAST(CT.thanhtien AS money), 1), 2) as thanhtien from HangHoa HH,CTHoaDon CT where HH.mahh = CT.mahh and CT.mahd = N'" + cboxMaHd.Text + "'";
            DataTable data1 = KetNoi.Istance.ExcuteQuerry(querry1);
            dgvTinhTien.DataSource = data1;
        }
        bool KtraHang()
        {
            string querry = "select mahh from CTHoaDon where mahd = N'" + cboxMaHd.Text + "' and mahh = N'" + cboxMatHang.SelectedValue + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        void loadTT()
        {
            string sql = "Select PARSENAME(CONVERT(varchar, CAST(TongTien AS money), 1), 2) as TongTien from HoaDon where mahd='" + cboxMaHd.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            foreach(DataRow row in data.Rows)
            {
                txtTongTien.Text = row["TongTien"].ToString();
            }
        }
        void loadTienSanAndichVu()
        {
            string sql = "Select PARSENAME(CONVERT(varchar, CAST(ThanhTien AS money), 1), 2) as ThanhTien from CTHoaDon where maHd='" + cboxMaHd.Text + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            foreach(DataRow row in data.Rows)
            {
                if (row["thanhTien"].ToString() == "")
                    txtTienDichVu.Text = "0";
                else
                    txtTienDichVu.Text = row["thanhTien"].ToString();
            }
            string sql1 = "Select * from HoaDon where mahd='" + cboxMaHd.Text + "'";
            DataTable data1 = KetNoi.Istance.ExcuteQuerry(sql1);
            decimal tongTien = 0;
            foreach (DataRow row in data1.Rows)
            {
                tongTien = decimal.Parse(row["TongTien"].ToString());
            }
            decimal tienDv = 0;
            string sql2 = "Select PARSENAME(CONVERT(varchar, CAST(sum(ThanhTien) AS money), 1), 2) as thanhTien from CTHoaDon where maHd='" + cboxMaHd.Text + "'";
            DataTable data2 = KetNoi.Istance.ExcuteQuerry(sql2);
            foreach (DataRow row in data2.Rows)
            {
                if (row["thanhTien"].ToString() == "")
                    tienDv = 0;
                else
                    tienDv = decimal.Parse(row["thanhTien"].ToString());
            }
            txtTienSan.Text = (tongTien - tienDv).ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string querry = "";
            if(numUpSL.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng khác 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (KtraHang())
            {
                querry = "Update CTHoaDon set SoLuongBan=SoLuongBan +'" + numUpSL.Value + "' where maHd='" + cboxMaHd.Text + "' and maHh='" + cboxMatHang.SelectedValue + "'";
            }
            else
            {
                querry = "insert into CTHoaDon values('" + numUpSL.Value + "','" + cboxDonGia.Text + "','0','" + cboxMaHd.Text + "','" + cboxMatHang.SelectedValue + "')";

            }
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            Loadgv();

            loadNullHH();
            loadTT();
            loadTienSanAndichVu();

        }
   
        private void btnBatDau_Click_1(object sender, EventArgs e)
        {
            
            if(cbKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            else
            {
                gbDv.Enabled = true;
                string querry = "insert into HoaDon(giobatdau,gioketthuc,ngayxuat,tongtien,trangthai,manv,makh,masan) values('" + dtpGioVao.Text + ":00','" + dtpGioRa.Text + ":00','" + DateTime.Now + "','0',N'Chưa Thanh Toán','" + lbMaNv.Text + "','" + cbKhachHang.SelectedValue + "','" + lbMaSan.Text + "')";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                string querry1 = "update San set trangthai = N'Đang hoạt động' where masan = '" + lbMaSan.Text + "'";
                DataTable data1 = KetNoi.Istance.ExcuteQuerry(querry1);
                LoadMaHD();
                loadTT();
                loadTienSanAndichVu();
            }
            btnBatDau.Enabled = false;
            panTinhTien.Enabled = false;
           
        }

        private void dgvTinhTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                cboxMatHang.Text = dgvTinhTien.Rows[numrow].Cells[0].Value.ToString();

            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cboxMaHd.Text == "")
            {
                MessageBox.Show("Chưa có dữ liệu để in", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                exportExel(dgvTinhTien);
                
                string querry = "update HoaDon set trangthai = N'Đã thanh toán', ngayxuat = '"+DateTime.Now+"' where mahd = N'" + cboxMaHd.Text + "'";
                DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                string querry1 = "update San set trangthai =N'Trống' where masan = '" + lbMaSan.Text + "' ";
                DataTable data1 = KetNoi.Istance.ExcuteQuerry(querry1);
                Loadnull();
                loadNullHH();
                panTinhTien.Enabled = false;
                gbDv.Enabled = false;
                dgvDichVu.Enabled = false;
                if (dgvTinhTien.RowCount > 0 && dgvTinhTien.DataSource != null)
                    ((DataTable)dgvTinhTien.DataSource).Rows.Clear();
                cboxMaHd.DataSource = null;
                txtTienDichVu.ResetText();
                txtTienSan.ResetText();
                txtTongTien.ResetText();
                PanSan5.Enabled = true;
                PanSan7.Enabled = true;
            }
            
        }

        private void exportExel(GunaDataGridView dgvTinhTien)
        {
            bool fileError = false;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XLSX(*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "HoaDon"+cbKhachHang.Text+".xlsx";
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
                    obj.Rows[5].Font.Bold = true;
                    int dem1 = 5;
                    obj.Cells[1, 1] = "         Hóa Đơn Sân Banh     ";
                    obj.Cells[2, 1] = "Mã Hóa Đơn: " + cboxMaHd.Text;
                    obj.Cells[2, 2] = "Ngày Lập: " + DateTime.Now;
                    obj.Cells[3, 1] = "Mã Nhân Viên: " +lbMaNv.Text;
                    obj.Cells[4, 1] = "Từ Giờ: " + dtpGioVao.Text;
                    obj.Cells[4, 2] = "Đến Giờ: " + dtpGioRa.Text;

                    if (dgvTinhTien.RowCount > 0)
                    {

                        for (int i = 1; i < dgvTinhTien.Columns.Count + 1; i++)
                        {

                            obj.Cells[5, i] = dgvTinhTien.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < dgvTinhTien.Rows.Count; i++)
                        {
                            dem1 += 1;
                            obj.Rows[dem1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            for (int j = 0; j < dgvTinhTien.Columns.Count; j++)
                            {
                                if (dgvTinhTien.Rows[i].Cells[j].Value != null)
                                {
                                    obj.Cells[i + 6, j + 1] = dgvTinhTien.Rows[i].Cells[j].Value.ToString();
                                }
                                else
                                {
                                    obj.Cells[i + 6, j + 1] = "";
                                }
                            }
                        }
                    }
                    obj.Cells[dem1 + 1, 1] = "Tiền Sân: " + txtTienSan.Text;
                    obj.Rows[dem1 + 1].Font.Color = Color.Red;
                    obj.Rows[dem1 + 1].Font.Bold = true;
                    obj.Rows[dem1 + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    obj.Cells[dem1 + 2, 1] = "Tổng dịch Vụ: " + txtTienDichVu.Text;
                    obj.Rows[dem1 + 2].Font.Color = Color.Red;
                    obj.Rows[dem1 + 2].Font.Bold = true;
                    obj.Rows[dem1 + 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    obj.Cells[dem1 + 3, 1] = "Tổng Tiền: " + txtTongTien.Text;
                    obj.Rows[dem1 + 3].Font.Color = Color.Red;
                    obj.Rows[dem1 + 3].Font.Bold = true;
                    obj.Rows[dem1 + 3].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

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
                MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnHuySan_Click(object sender, EventArgs e)
        {
            Loadnull();
            loadNullHH();
            panTinhTien.Enabled = false;
            gbDv.Enabled = false;
            dgvDichVu.Enabled = false;
            if (dgvTinhTien.RowCount > 0 && dgvTinhTien.DataSource != null)
                ((DataTable)dgvTinhTien.DataSource).Rows.Clear();
            cboxMaHd.DataSource = null;
            txtTienDichVu.ResetText();
            txtTienSan.ResetText();
            txtTongTien.ResetText();
            PanSan5.Enabled = true;
            PanSan7.Enabled = true;
            lbSanName.Text = "Sân";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadKh();
        }
    }
}
