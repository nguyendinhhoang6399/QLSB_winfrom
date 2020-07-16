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
    public partial class frmDatSan : Form
    {
        public frmDatSan()
        {
            InitializeComponent();
            LoadKh();
            LoadTs();
            LoadMaDS();
            cboxMaDatSan.Enabled = false;
            //gbDatSan.Enabled = false;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnThemKH, "Thêm");
            
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            frmKhachHang fm = new frmKhachHang();
            this.Hide();
            fm.ShowDialog();
        }

        void LoadKh()
        {
            string querry = "select * from khachhang";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxKhachHang.DataSource = data;
            cboxKhachHang.DisplayMember = "tenkh";
            cboxKhachHang.ValueMember = "makh";
            cboxKhachHang.SelectedIndex = -1;
        }
        void LoadMaDS()
        {
            string querry = "select * from DatSan";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxMaDatSan.DataSource = data;
            cboxMaDatSan.DisplayMember = "madatsan";
            cboxMaDatSan.ValueMember = "madatsan";
            cboxMaDatSan.SelectedIndex = -1;
        }
        void LoadTs()
        {
            string querry = "select * from san";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
            cboxTenSan.DataSource = data;
            cboxTenSan.DisplayMember = "tensan";
            cboxTenSan.ValueMember = "masan";
            cboxTenSan.SelectedIndex = -1;
        }
        void LoadNull()
        {
            cboxMaDatSan.Text = "";
            cboxKhachHang.Text = "";
            cboxTenSan.Text = "";
           
            dtpTuGio.Text = "00:00";
            dtpDenGio.Text = "00:00";
            dtpThoiGian.Text = "00:00";
            cboxtrangThai.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadNull();
            //gbDatSan.Enabled = false;
            //btnSua.Enabled = true;
            //btnThem.Enabled = true;
            cboxMaDatSan.Enabled = false;
        }
        bool kiemTraTgian()
        {
            string querry = "select * from DatSan where tugio >=CONVERT(time,'"+dtpTuGio.Text+ ":00') and tugio <=CONVERT(time,'"+dtpDenGio.Text+ ":00') or denGio >=CONVERT(time,'" + dtpTuGio.Text + ":00') and denGio <=CONVERT(time,'" + dtpDenGio.Text + ":00') and Tungay=N'" + dtpTuNgay.Text+ "' and DenNgay=N'" + dtpDenNgay.Text + "' and maSan='"+cboxTenSan.SelectedValue+"'";
            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
          if(data.Rows.Count>0)
                return true;
            return false;
        }
        
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxMaDatSan.Text == "")
                {
                    string madatsan = cboxMaDatSan.Text;
                    string tenkh = cboxKhachHang.Text;
                    string tensan = cboxTenSan.Text;
                    string trangthai = cboxtrangThai.Text;
                    DateTime dateTN = dtpTuNgay.Value;
                    DateTime dateDN = dtpDenNgay.Value;
                    DateTime dateTime = DateTime.Now;

                    if (cboxKhachHang.Text == "" || cboxTenSan.Text == "" || cboxtrangThai.Text == "" || dtpTuNgay.Text == "" || dtpDenNgay.Text == "" || dtpTuGio.Text == "00:00" || dtpDenGio.Text == "00:00" || dtpThoiGian.Text == "00:00")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (kiemTraTgian() == true)
                    {
                        MessageBox.Show("Thời gian đặt không phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dateTN < dateTime || dateDN < dateTime || dateTN > dateDN)
                    {
                        MessageBox.Show("Ngày đặt không phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            string querry = "insert into DatSan(masan,makh,tugio,dengio,tungay,denngay,thoigian,trangthai) values(N'" + cboxTenSan.SelectedValue + "',N'" + cboxKhachHang.SelectedValue + "',N'" + dtpTuGio.Text + "',N'" + dtpDenGio.Text + "',N'" + dtpTuNgay.Text + "',N'" + dtpDenNgay.Text + "',N'"+dtpThoiGian.Text+"',N'" + cboxtrangThai.SelectedItem + "')";
                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadNull();
                        }
                        catch
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    string madatsan = cboxMaDatSan.Text;
                    string tenkh = cboxKhachHang.Text;
                    string tensan = cboxTenSan.Text;
                    string trangthai = cboxtrangThai.Text;

                    if (cboxKhachHang.Text == "" || cboxTenSan.Text == "" || cboxtrangThai.Text == "" || dtpTuNgay.Text == "" || dtpDenNgay.Text == "" || dtpTuGio.Text == "00:00" || dtpDenGio.Text == "00:00" || dtpThoiGian.Text == "00:00")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        try
                        {
                            string querry = "update DatSan set masan ='"+cboxTenSan.SelectedValue+"', makh = '"+cboxKhachHang.SelectedValue+"',tugio = '"+dtpTuGio.Text+"',dengio='"+dtpDenGio.Text+"',tungay='"+dtpTuNgay.Text+"',denngay='"+dtpDenNgay.Text+"',thoigian='"+dtpThoiGian.Text+"',trangthai=N'"+cboxtrangThai.Text+"' where madatsan = '"+cboxMaDatSan.Text+"'";

                            DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
                            MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadNull();
                        }
                        catch
                        {
                            MessageBox.Show("Sửa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                
            }catch
            {
                MessageBox.Show("Dữ hiệu không hợp lệ hoặc lỗi kết nối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void cboxMaDatSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string querry = "select  KH.tenkh,S.tensan ,DS.tungay,DS.denngay,DS.tugio,DS.dengio,DS.thoigian,DS.trangthai from DatSan DS, KhachHang KH, San S where DS.makh=KH.makh and S.masan = DS.masan and DS.madatsan = '" + cboxMaDatSan.Text + "'";
            //DataTable data = KetNoi.Istance.ExcuteQuerry(querry);
        }

        private void frmDatSan_Load(object sender, EventArgs e)
        {

        }
    }
}
