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
            toolTip1.SetToolTip(btnThoat, "Thoát");
            LoadDV();
            LoadSan5();
            LoadSan7();
            LoadKh();
            LoadcboxMH();
            panTinhTien.Enabled = false;
            gbDv.Enabled = false;
            dgvDichVu.Enabled = false;
        }

        void LoadDV()
        {
            try
            {
                string querry = "Select tenHh, dongia from HangHoa";
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
                    PanSan5.Controls.Add(bt);
                }
            }catch
            {
                MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_clicksan5(object sender, EventArgs e)
        {
           
            string tenSan = (sender as System.Windows.Forms.Button).Name;
            string maSan = (sender as Button).Tag.ToString();
            lbSanName.Text = tenSan;
            panTinhTien.Enabled = true;
            gbDv.Enabled = true;
            dgvDichVu.Enabled = true;
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
            
             string tenSan= (sender as System.Windows.Forms.Button).Name;
            lbSanName.Text = tenSan;
            panTinhTien.Enabled = true;
            gbDv.Enabled = true;
            dgvDichVu.Enabled = true;
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

        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            cboxMatHang.Text = dgvDichVu.Rows[numrow].Cells[0].Value.ToString();
            txtDonGia.Text = dgvDichVu.Rows[numrow].Cells[1].Value.ToString();
        }
        
        

       

        

        private void cboxMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }
    }
}
