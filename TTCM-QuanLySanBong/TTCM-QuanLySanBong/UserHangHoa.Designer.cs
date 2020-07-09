namespace TTCM_QuanLySanBong
{
    partial class UserHangHoa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHangHoa));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvHangHoa = new Guna.UI.WinForms.GunaDataGridView();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.panHangHoa = new System.Windows.Forms.Panel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtDonGia = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtSLTon = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDVT = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTenHang = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtMaHang = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.btnNhapHang = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHuy = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSua = new Guna.UI.WinForms.GunaGradientButton();
            this.btnXoa = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLuu = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.panHangHoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaTransition1.SetDecoration(this.gunaLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("UVN Thanh Pho", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(375, 49);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Danh Sách Mặt Hàng";
            // 
            // dgvHangHoa
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHangHoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHangHoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHangHoa.ColumnHeadersHeight = 77;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.tenhanghoa,
            this.dvt,
            this.soLuongTon,
            this.donGia});
            this.gunaTransition1.SetDecoration(this.dgvHangHoa, Guna.UI.Animation.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHangHoa.EnableHeadersVisualStyles = false;
            this.dgvHangHoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHangHoa.Location = new System.Drawing.Point(3, 52);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersVisible = false;
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(639, 607);
            this.dgvHangHoa.TabIndex = 5;
            this.dgvHangHoa.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHangHoa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHangHoa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHangHoa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHangHoa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHangHoa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHangHoa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHangHoa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHangHoa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHangHoa.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvHangHoa.ThemeStyle.ReadOnly = false;
            this.dgvHangHoa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHangHoa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHangHoa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHangHoa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHangHoa.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHangHoa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHangHoa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // maHang
            // 
            this.maHang.DataPropertyName = "maHh";
            this.maHang.HeaderText = "Mã Hàng Hóa";
            this.maHang.MinimumWidth = 6;
            this.maHang.Name = "maHang";
            // 
            // tenhanghoa
            // 
            this.tenhanghoa.DataPropertyName = "tenhh";
            this.tenhanghoa.HeaderText = "Tên Hàng Hóa";
            this.tenhanghoa.MinimumWidth = 6;
            this.tenhanghoa.Name = "tenhanghoa";
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "dvt";
            this.dvt.HeaderText = "Đơn Vị Tính";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            // 
            // soLuongTon
            // 
            this.soLuongTon.DataPropertyName = "soluongton";
            this.soLuongTon.HeaderText = "Số Lượng Tồn";
            this.soLuongTon.MinimumWidth = 6;
            this.soLuongTon.Name = "soLuongTon";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "dongia";
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            // 
            // gunaLabel2
            // 
            this.gunaTransition1.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("UVN Thanh Pho", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(648, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(347, 49);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Thông Tin Mặt Hàng";
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaTransition1.SetDecoration(this.gunaVSeparator1, Guna.UI.Animation.DecorationType.None);
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(640, -4);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 663);
            this.gunaVSeparator1.TabIndex = 7;
            this.gunaVSeparator1.Thickness = 5;
            // 
            // gunaSeparator1
            // 
            this.gunaTransition1.SetDecoration(this.gunaSeparator1, Guna.UI.Animation.DecorationType.None);
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(3, 39);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(639, 10);
            this.gunaSeparator1.TabIndex = 8;
            this.gunaSeparator1.Thickness = 5;
            // 
            // gunaSeparator2
            // 
            this.gunaTransition1.SetDecoration(this.gunaSeparator2, Guna.UI.Animation.DecorationType.None);
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(648, 39);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(566, 13);
            this.gunaSeparator2.TabIndex = 12;
            this.gunaSeparator2.Thickness = 5;
            // 
            // panHangHoa
            // 
            this.panHangHoa.Controls.Add(this.gunaLabel7);
            this.panHangHoa.Controls.Add(this.txtDonGia);
            this.panHangHoa.Controls.Add(this.txtSLTon);
            this.panHangHoa.Controls.Add(this.txtDVT);
            this.panHangHoa.Controls.Add(this.txtTenHang);
            this.panHangHoa.Controls.Add(this.txtMaHang);
            this.panHangHoa.Controls.Add(this.gunaLabel8);
            this.panHangHoa.Controls.Add(this.gunaLabel6);
            this.panHangHoa.Controls.Add(this.gunaLabel5);
            this.panHangHoa.Controls.Add(this.gunaLabel4);
            this.panHangHoa.Controls.Add(this.gunaLabel3);
            this.gunaTransition1.SetDecoration(this.panHangHoa, Guna.UI.Animation.DecorationType.None);
            this.panHangHoa.Location = new System.Drawing.Point(655, 52);
            this.panHangHoa.Name = "panHangHoa";
            this.panHangHoa.Size = new System.Drawing.Size(559, 220);
            this.panHangHoa.TabIndex = 13;
            // 
            // gunaLabel7
            // 
            this.gunaTransition1.SetDecoration(this.gunaLabel7, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel7.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(440, 160);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(52, 37);
            this.gunaLabel7.TabIndex = 32;
            this.gunaLabel7.Text = "VND";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtDonGia, Guna.UI.Animation.DecorationType.None);
            this.txtDonGia.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonGia.LineColor = System.Drawing.Color.Gainsboro;
            this.txtDonGia.Location = new System.Drawing.Point(149, 167);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.Size = new System.Drawing.Size(293, 30);
            this.txtDonGia.TabIndex = 28;
            // 
            // txtSLTon
            // 
            this.txtSLTon.BackColor = System.Drawing.Color.White;
            this.txtSLTon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtSLTon, Guna.UI.Animation.DecorationType.None);
            this.txtSLTon.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSLTon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSLTon.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSLTon.Location = new System.Drawing.Point(149, 127);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.PasswordChar = '\0';
            this.txtSLTon.ReadOnly = true;
            this.txtSLTon.Size = new System.Drawing.Size(343, 30);
            this.txtSLTon.TabIndex = 29;
            // 
            // txtDVT
            // 
            this.txtDVT.BackColor = System.Drawing.Color.White;
            this.txtDVT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtDVT, Guna.UI.Animation.DecorationType.None);
            this.txtDVT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDVT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDVT.LineColor = System.Drawing.Color.Gainsboro;
            this.txtDVT.Location = new System.Drawing.Point(149, 87);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.PasswordChar = '\0';
            this.txtDVT.Size = new System.Drawing.Size(343, 30);
            this.txtDVT.TabIndex = 29;
            // 
            // txtTenHang
            // 
            this.txtTenHang.BackColor = System.Drawing.Color.White;
            this.txtTenHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtTenHang, Guna.UI.Animation.DecorationType.None);
            this.txtTenHang.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenHang.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTenHang.Location = new System.Drawing.Point(149, 50);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.PasswordChar = '\0';
            this.txtTenHang.Size = new System.Drawing.Size(343, 30);
            this.txtTenHang.TabIndex = 30;
            // 
            // txtMaHang
            // 
            this.txtMaHang.BackColor = System.Drawing.Color.White;
            this.txtMaHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtMaHang, Guna.UI.Animation.DecorationType.None);
            this.txtMaHang.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaHang.LineColor = System.Drawing.Color.Gainsboro;
            this.txtMaHang.Location = new System.Drawing.Point(149, 13);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.PasswordChar = '\0';
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(343, 30);
            this.txtMaHang.TabIndex = 31;
            // 
            // gunaLabel8
            // 
            this.gunaTransition1.SetDecoration(this.gunaLabel8, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel8.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(3, 120);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(140, 37);
            this.gunaLabel8.TabIndex = 25;
            this.gunaLabel8.Text = "Số lượng tồn";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel6
            // 
            this.gunaTransition1.SetDecoration(this.gunaLabel6, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel6.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(31, 160);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(112, 37);
            this.gunaLabel6.TabIndex = 24;
            this.gunaLabel6.Text = "Đơn giá";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel5
            // 
            this.gunaTransition1.SetDecoration(this.gunaLabel5, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel5.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(31, 80);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(112, 37);
            this.gunaLabel5.TabIndex = 25;
            this.gunaLabel5.Text = "Đơn vị tính";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel4
            // 
            this.gunaTransition1.SetDecoration(this.gunaLabel4, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel4.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(31, 43);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(112, 37);
            this.gunaLabel4.TabIndex = 26;
            this.gunaLabel4.Text = "Tên hàng";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel3
            // 
            this.gunaTransition1.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(36, 7);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(107, 37);
            this.gunaLabel3.TabIndex = 27;
            this.gunaLabel3.Text = "Mã hàng";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.gunaTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation1;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.AnimationHoverSpeed = 0.07F;
            this.btnNhapHang.AnimationSpeed = 0.03F;
            this.btnNhapHang.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNhapHang.BaseColor2 = System.Drawing.Color.DarkOrange;
            this.btnNhapHang.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnNhapHang, Guna.UI.Animation.DecorationType.None);
            this.btnNhapHang.FocusedColor = System.Drawing.Color.Empty;
            this.btnNhapHang.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.Black;
            this.btnNhapHang.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_box_480;
            this.btnNhapHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNhapHang.Location = new System.Drawing.Point(707, 296);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnNhapHang.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnNhapHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNhapHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNhapHang.OnHoverImage = null;
            this.btnNhapHang.OnPressedColor = System.Drawing.Color.Black;
            this.btnNhapHang.Size = new System.Drawing.Size(153, 67);
            this.btnNhapHang.TabIndex = 37;
            this.btnNhapHang.Text = "NHẬP HÀNG";
            this.btnNhapHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BaseColor1 = System.Drawing.Color.Snow;
            this.btnHuy.BaseColor2 = System.Drawing.Color.Lime;
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnHuy, Guna.UI.Animation.DecorationType.None);
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_unavailable_240;
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.Location = new System.Drawing.Point(903, 337);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnHuy.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Size = new System.Drawing.Size(131, 50);
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.AnimationHoverSpeed = 0.07F;
            this.btnSua.AnimationSpeed = 0.03F;
            this.btnSua.BaseColor1 = System.Drawing.Color.Snow;
            this.btnSua.BaseColor2 = System.Drawing.Color.Lime;
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnSua, Guna.UI.Animation.DecorationType.None);
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_support_100;
            this.btnSua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSua.Location = new System.Drawing.Point(903, 281);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSua.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(131, 50);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BaseColor1 = System.Drawing.Color.Snow;
            this.btnXoa.BaseColor2 = System.Drawing.Color.Lime;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnXoa, Guna.UI.Animation.DecorationType.None);
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_delete_1001;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(1055, 337);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXoa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(131, 50);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BaseColor1 = System.Drawing.Color.Snow;
            this.btnLuu.BaseColor2 = System.Drawing.Color.Lime;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnLuu, Guna.UI.Animation.DecorationType.None);
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_save_64;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(1055, 281);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLuu.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(131, 50);
            this.btnLuu.TabIndex = 41;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // UserHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panHangHoa);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.gunaLabel1);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Name = "UserHangHoa";
            this.Size = new System.Drawing.Size(1217, 659);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.panHangHoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dgvHangHoa;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private System.Windows.Forms.Panel panHangHoa;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLineTextBox txtDonGia;
        private Guna.UI.WinForms.GunaLineTextBox txtDVT;
        private Guna.UI.WinForms.GunaLineTextBox txtTenHang;
        private Guna.UI.WinForms.GunaLineTextBox txtMaHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaGradientButton btnNhapHang;
        private Guna.UI.WinForms.GunaGradientButton btnHuy;
        private Guna.UI.WinForms.GunaGradientButton btnSua;
        private Guna.UI.WinForms.GunaGradientButton btnXoa;
        private Guna.UI.WinForms.GunaGradientButton btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private Guna.UI.WinForms.GunaLineTextBox txtSLTon;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
    }
}
