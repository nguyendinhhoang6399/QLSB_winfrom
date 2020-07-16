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
    public partial class frmBangGia : Form
    {
        public frmBangGia()
        {
            InitializeComponent();
            LoadBG();
            LoadTLs();
            //LoadTLs();
        }

        void LoadBG()
        {
            string querry = "select LS.tenls, LS.mals , BG.giobatdau, BG.gioketthuc,PARSENAME(CONVERT(varchar, CAST(BG.dongia AS money), 1), 2) as dongia from loaisan LS, banggiasan BG where LS.mals = BG.mals";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvBangGia.DataSource = data;
            panTTBG.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                cboxTenLs.Text = dgvBangGia.Rows[numrow].Cells[0].Value.ToString();
               
                dtpTuGio.Text = dgvBangGia.Rows[numrow].Cells[2].Value.ToString();
                dtpDenGio.Text = dgvBangGia.Rows[numrow].Cells[3].Value.ToString();
                txtDonGia.Text = dgvBangGia.Rows[numrow].Cells[4].Value.ToString();
            }
        }
        void loadNull()
        {
            cboxTenLs.Text = "";
            dtpTuGio.Text = "00:00";
            dtpDenGio.Text = "00:00";
            txtDonGia.Text = "";
           
        }
        
       
        void LoadTLs()
        {
            string querry = "select * from loaisan";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            
            cboxTenLs.DataSource = data;
            cboxTenLs.DisplayMember = "tenls";
            cboxTenLs.ValueMember = "maLs";
            cboxTenLs.SelectedIndex = -1;
            
        }
        int dem;

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            dem = 1;
            panTTBG.Enabled = true;
            loadNull();
            dgvBangGia.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cboxTenLs.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dem = 2;
            
            if (dtpTuGio.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThemMoi.Enabled = true;
                btnXoa.Enabled = true;
                panTTBG.Enabled = false;
            }
            else
            {
                btnThemMoi.Enabled = false;
                btnXoa.Enabled = false;
                panTTBG.Enabled = true;
            }
            
        }
        Boolean kiemTra(string tugio,string dengio,string mals)
        {
            string querry = "select BG.giobatdau, BG.gioketthuc, LS.mals from BangGiaSan BG, LoaiSan LS where giobatdau = '" + tugio + "',gioketthuc = '"+dengio+"',mals='"+mals+"',LS.mals=BG.mals";
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
            panTTBG.Enabled = false;
            loadNull();
            dgvBangGia.Enabled = true;
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
                    
                    string tugio = dtpTuGio.Text;
                    string dengio = dtpDenGio.Text;
                    string mals = cboxTenLs.SelectedValue.ToString();
                    decimal dongia = 0;
                    if (dtpTuGio.Text == "" || dtpDenGio.Text == "" || txtDonGia.Text == "" || cboxTenLs.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (kiemTra(tugio,dengio,mals) == true)
                    {
                        MessageBox.Show("Giá sân đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            dongia = decimal.Parse(txtDonGia.Text);
                        }
                        catch
                        {

                            MessageBox.Show("Đơn giá nhập không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            string querry = "insert into BangGiaSan values(N'" + dtpTuGio.Text + "',N'" + dtpDenGio.Text + "'," +
                                            "N'" + txtDonGia.Text + "',N'" + cboxTenLs.SelectedValue + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            loadNull();
                            LoadBG();
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            dgvBangGia.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (dem == 2)
                {
                    string tugio = dtpTuGio.Text;
                    string dengio = dtpDenGio.Text;
                    string mals = cboxTenLs.SelectedValue.ToString();
                    decimal dongia = 0;
                    if (dtpTuGio.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn đối tượng muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dtpTuGio.Text == "" || dtpDenGio.Text == "" || txtDonGia.Text == "" ||  cboxTenLs.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            dongia = decimal.Parse(txtDonGia.Text);
                        }
                        catch
                        {

                            MessageBox.Show("Đơn giá nhập không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            string querry = "update BangGiaSan set dongia='" + dongia + "' where giobatdau ='" + tugio + "', gioketthuc ='" + dengio + "',mals ='" + mals + "'";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadBG();
                            btnThemMoi.Enabled = true;
                            btnXoa.Enabled = true;

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
            string tugio = dtpTuGio.Text;
            string dengio = dtpDenGio.Text;
            string mals = cboxTenLs.SelectedValue.ToString();
            if (tugio == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng muốn xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string querry = "delete BangGiaSan where giobatdau = N'" + tugio + "',gioketthuc = '"+dengio+"',mals = '"+mals+"'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNull();
                    LoadBG();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
