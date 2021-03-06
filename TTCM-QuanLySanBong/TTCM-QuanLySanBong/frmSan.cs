﻿using System;
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
    public partial class frmSan : Form
    {
        public frmSan()
        {
            InitializeComponent();
            LoadSan();
            LoadTLs();
            LoadMas();
        }

       

        void LoadSan()
        {
            string querry = "select S.masan, S.TenSan, LS.tenls, S.TrangThai from loaisan LS, San S where LS.mals = S.mals";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            dgvDsSanBong.DataSource = data;
            gbSan.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDsSanBong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow == -1)
                return;
            else
            {
                cboxMaSan.Text = dgvDsSanBong.Rows[numrow].Cells[0].Value.ToString();
                txtTenSan.Text = dgvDsSanBong.Rows[numrow].Cells[1].Value.ToString();
                cboxTenLs.Text = dgvDsSanBong.Rows[numrow].Cells[2].Value.ToString();
                cboxTrangThai.Text = dgvDsSanBong.Rows[numrow].Cells[3].Value.ToString();
            }
        }
        void LoadTLs()
        {
            string querry = "select * from loaisan";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxTenLs.DataSource = data;
            cboxTenLs.DisplayMember = "tenls";
            cboxTenLs.ValueMember = "mals";
            cboxTenLs.SelectedIndex = -1;
        }
        void LoadMas()
        {
            string querry = "select * from san";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxMaSan.DataSource = data;
            cboxMaSan.DisplayMember = "masan";
            cboxMaSan.ValueMember = "masan";
            cboxMaSan.SelectedIndex = -1;
        }
        private void btnBangGia_Click_1(object sender, EventArgs e)
        {
            frmBangGia bangGia = new frmBangGia();
            this.Hide();
            bangGia.ShowDialog();
        }
        void loadNull()
        {
            txtTenSan.Text = "";
            cboxMaSan.Text = "";
            cboxTenLs.Text = "";
            cboxTrangThai.Text = "";

        }
        int dem;

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            dem = 1;
            gbSan.Enabled = true;
            loadNull();
            dgvDsSanBong.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cboxMaSan.Enabled = false;
            txtTenSan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dem = 2;
            
            if (txtTenSan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnThemMoi.Enabled = true;
                btnXoa.Enabled = true;
                gbSan.Enabled = false;
            }
            else
            {
                btnThemMoi.Enabled = false;
                btnXoa.Enabled = false;
                gbSan.Enabled = true;
            }

        }
        Boolean kiemTra(string tensan)
        {
            string querry = "select tensan from San where tenSan =N'"+tensan+"'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            
             if(data.Rows.Count>0)
                return true;
            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gbSan.Enabled = false;
            loadNull();
            dgvDsSanBong.Enabled = true;
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
                    string masan = cboxMaSan.Text;
                    string tensan = txtTenSan.Text;
                    string loaisan = cboxTenLs.Text;
                    string trangthai = cboxTrangThai.Text;

                    if (txtTenSan.Text == "" || cboxTenLs.Text == "" || cboxTrangThai.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (kiemTra(tensan) == true)
                    {
                        MessageBox.Show("Sân đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        try
                        {
                            string querry = "insert into San(tensan,trangthai,mals) values(N'" + txtTenSan.Text + "',N'" + cboxTrangThai.Text + "',N'" + cboxTenLs.SelectedValue + "')";

                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            loadNull();
                            LoadSan();
                            btnSua.Enabled = true;
                            btnXoa.Enabled = true;
                            dgvDsSanBong.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (dem == 2)
                {
                    string masan = cboxMaSan.Text;
                    string tensan = txtTenSan.Text;
                    string loaisan = cboxTenLs.Text;
                    string trangthai = cboxTrangThai.Text;
                    if (txtTenSan.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn đối tượng muốn sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtTenSan.Text == "" || cboxTenLs.Text == "" || cboxTrangThai.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        try
                        {
                            string querry = "update San set tensan=N'" + tensan + "',trangthai = N'"+trangthai+"',mals = N'"+cboxTenLs.SelectedValue+"' where masan =N'"+masan+"' ";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNull();
                            LoadSan();
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
            string tensan = txtTenSan.Text;
           
            if (tensan == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng muốn xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string querry = "delete San where tensan = N'" + tensan + "'";
                    DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNull();
                    LoadSan();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
