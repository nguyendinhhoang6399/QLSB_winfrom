using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCM_QuanLySanBong
{
    public partial class FrmMain : Form
    {
        private string maNv;

        public string MaNv { get => maNv; set => maNv = value; }


        public FrmMain(string MANV)
        {
            this.maNv = MANV;
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnTinhTien, "Tính Tiền");
            toolTip1.SetToolTip(btnDatSan, "Đặt Sân");
            toolTip1.SetToolTip(btnHoaDon, "Hóa Đơn");
            toolTip1.SetToolTip(btnBaoCao, "Báo Cáo");
            toolTip1.SetToolTip(btnHangHoa, "Hàng Hóa ");
            toolTip1.SetToolTip(btnNhanSu, "Nhân Sự");
            toolTip1.SetToolTip(btnThoat, "Đăng Xuất");
            userDatSan1.Hide();
            userTinhTien1.Hide();
            userHangHoa1.Hide();
            userBaoCao1.Hide();
            userHoaDon1.Hide();
            userNhanSu1.Hide();
            userTinhTien1.MaNv = MaNv;
            nullButton();
            check();
            GetPhanQuyen();
            timer1.Start();
            
            //userHoaDon1.MaNv = MaNv;

        }
        void check()
        {
            string sql = "Select * from taiKhoan where maNv='"+MaNv+"'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            foreach (DataRow row in data.Rows)
            {
                if (row["MaLoaiTK"].ToString() == "1")
                {
                    openALL();
                }
              
            }
        } 
        void nullButton()
        {
            btnBaoCao.Enabled = false;
            btnDatSan.Enabled = false;
            btnHangHoa.Enabled = false;
            btnHoaDon.Enabled = false;
            btnNhanSu.Enabled = false;
            btnTinhTien.Enabled = false;
        }
        void GetPhanQuyen()
        {
            string sql = "Select * from PhanViec where manv='" + MaNv + "'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(sql);
            foreach(DataRow row in data.Rows)
            {
                if(row["tenCv"].ToString()== "Quản Lý Tính Tiền")
                {
                    MessageBox.Show("here");
                    btnTinhTien.Enabled = true;
                }
                if (row["tenCv"].ToString() == "Quản Lý Đặt Sân")
                {
                    btnDatSan.Enabled = true;
                }
                if (row["tenCv"].ToString() == "Quản Lý Hóa Đơn")
                {
                    btnHoaDon.Enabled = true;
                    btnBaoCao.Enabled = true;
                    btnHangHoa.Enabled = true;
                }
                if (row["tenCv"].ToString() == "Admin")
                {
                    openALL();
                }

            }
        }
        void openALL()
        {
            btnBaoCao.Enabled = true;
            btnDatSan.Enabled = true;
            btnHangHoa.Enabled = true;
            btnHoaDon.Enabled = true;
            btnNhanSu.Enabled = true;
            btnTinhTien.Enabled = true;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            userMain1.Hide();
            userDatSan1.Hide();
            userHangHoa1.Hide();
            userHoaDon1.Hide();
            userBaoCao1.Hide();
            userNhanSu1.Hide();
            gunaTransition1.Show(userTinhTien1);
        }

        private void btnSan_Click(object sender, EventArgs e)
        {
            userMain1.Hide();
            userTinhTien1.Hide();
            userHangHoa1.Hide();
            userHoaDon1.Hide();
            userBaoCao1.Hide();
            userNhanSu1.Hide();
            gunaTransition1.Show(userDatSan1);
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            userMain1.Hide();
            userTinhTien1.Hide();
            userDatSan1.Hide();
            userHoaDon1.Hide();
            userBaoCao1.Hide();
            userNhanSu1.Hide();
            gunaTransition1.Show(userHangHoa1);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            userMain1.Hide();
            userTinhTien1.Hide();
            userDatSan1.Hide();
            userHangHoa1.Hide();
            userBaoCao1.Hide();
            userNhanSu1.Hide();
            gunaTransition1.Show(userHoaDon1);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            userMain1.Hide();
            userTinhTien1.Hide();
            userDatSan1.Hide();
            userHangHoa1.Hide();
            userHoaDon1.Hide();
            userNhanSu1.Hide();
            gunaTransition1.Show(userBaoCao1);
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            userMain1.Hide();
            userTinhTien1.Hide();
            userDatSan1.Hide();
            userHangHoa1.Hide();
            userHoaDon1.Hide();
            userBaoCao1.Hide();
            gunaTransition1.Show(userNhanSu1);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            this.Hide();
            frmDangNhap.ShowDialog();
        }

        private void userNhanSu1_Load(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            userTinhTien1.Hide();
            userDatSan1.Hide();
            userHangHoa1.Hide();
            userHoaDon1.Hide();
            userNhanSu1.Hide();
            userBaoCao1.Hide();
            gunaTransition1.Show(userMain1);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            string time = "";
            if (hour < 10)
            {
                time += "0" + hour;

            }
            else
                time += hour;
            time += ":";
            if (min < 10)
                time += "0" + min;
            else
                time += min;
            time += ":";
            if (second < 10)
                time += "0" + second;
            else
                time += second;
            lbTime.Text = time;
        }
    }
}
