namespace TTCM_QuanLySanBong
{
    partial class frmPhieuNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhapHang = new Guna.UI.WinForms.GunaDataGridView();
            this.maPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaPhieu = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDvt = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtSoLuong = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtGiaNhap = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.gbPhieuNhap = new System.Windows.Forms.GroupBox();
            this.cboxNcc = new System.Windows.Forms.ComboBox();
            this.btnOpenNcc = new Guna.UI.WinForms.GunaImageButton();
            this.txtTenHangHoa = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnXoa = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSua = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLuu = new Guna.UI.WinForms.GunaGradientButton();
            this.btnThemMoi = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHuy = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.gbPhieuNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 39);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_stadium_96;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 38);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu Nhập Hàng";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_close_window_64;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Location = new System.Drawing.Point(1172, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Size = new System.Drawing.Size(45, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhapHang);
            this.groupBox2.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.groupBox2.Location = new System.Drawing.Point(0, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 620);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập hàng";
            // 
            // dgvNhapHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNhapHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhapHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieu,
            this.tenHh,
            this.dvt,
            this.soLuong,
            this.gianhap,
            this.tenNcc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhapHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapHang.EnableHeadersVisualStyles = false;
            this.dgvNhapHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapHang.Location = new System.Drawing.Point(3, 28);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowHeadersVisible = false;
            this.dgvNhapHang.RowHeadersWidth = 51;
            this.dgvNhapHang.RowTemplate.Height = 24;
            this.dgvNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapHang.Size = new System.Drawing.Size(772, 589);
            this.dgvNhapHang.TabIndex = 2;
            this.dgvNhapHang.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhapHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNhapHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhapHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvNhapHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhapHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhapHang.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvNhapHang.ThemeStyle.ReadOnly = false;
            this.dgvNhapHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvNhapHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhapHang.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNhapHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellClick);
            // 
            // maPhieu
            // 
            this.maPhieu.HeaderText = "Mã Phiếu";
            this.maPhieu.MinimumWidth = 6;
            this.maPhieu.Name = "maPhieu";
            // 
            // tenHh
            // 
            this.tenHh.HeaderText = "Tên Hàng hóa";
            this.tenHh.MinimumWidth = 6;
            this.tenHh.Name = "tenHh";
            // 
            // dvt
            // 
            this.dvt.HeaderText = "Đơn Vị Tính";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            // 
            // gianhap
            // 
            this.gianhap.HeaderText = "Giá Nhập";
            this.gianhap.MinimumWidth = 6;
            this.gianhap.Name = "gianhap";
            // 
            // tenNcc
            // 
            this.tenNcc.HeaderText = "Tên NCC";
            this.tenNcc.MinimumWidth = 6;
            this.tenNcc.Name = "tenNcc";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(16, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(140, 37);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Tên hàng hóa";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(30, 112);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(126, 37);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "ĐVT";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(16, 239);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(140, 37);
            this.gunaLabel6.TabIndex = 3;
            this.gunaLabel6.Text = "Tên NCC";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(16, 28);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(140, 37);
            this.gunaLabel5.TabIndex = 3;
            this.gunaLabel5.Text = "Mã Phiếu";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(30, 149);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(126, 37);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Số lượng";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(30, 186);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(126, 37);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Giá nhập";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BackColor = System.Drawing.Color.White;
            this.txtMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieu.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaPhieu.LineColor = System.Drawing.Color.Gainsboro;
            this.txtMaPhieu.Location = new System.Drawing.Point(174, 31);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.PasswordChar = '\0';
            this.txtMaPhieu.Size = new System.Drawing.Size(230, 30);
            this.txtMaPhieu.TabIndex = 4;
            // 
            // txtDvt
            // 
            this.txtDvt.BackColor = System.Drawing.Color.White;
            this.txtDvt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDvt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDvt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDvt.LineColor = System.Drawing.Color.Gainsboro;
            this.txtDvt.Location = new System.Drawing.Point(174, 119);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.PasswordChar = '\0';
            this.txtDvt.Size = new System.Drawing.Size(230, 30);
            this.txtDvt.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSoLuong.Location = new System.Drawing.Point(174, 156);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.Size = new System.Drawing.Size(230, 30);
            this.txtSoLuong.TabIndex = 4;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.White;
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaNhap.LineColor = System.Drawing.Color.Gainsboro;
            this.txtGiaNhap.Location = new System.Drawing.Point(174, 193);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.Size = new System.Drawing.Size(230, 30);
            this.txtGiaNhap.TabIndex = 4;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(784, 39);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 622);
            this.gunaVSeparator1.TabIndex = 3;
            this.gunaVSeparator1.Thickness = 5;
            // 
            // gbPhieuNhap
            // 
            this.gbPhieuNhap.Controls.Add(this.cboxNcc);
            this.gbPhieuNhap.Controls.Add(this.btnOpenNcc);
            this.gbPhieuNhap.Controls.Add(this.txtGiaNhap);
            this.gbPhieuNhap.Controls.Add(this.txtSoLuong);
            this.gbPhieuNhap.Controls.Add(this.txtDvt);
            this.gbPhieuNhap.Controls.Add(this.txtMaPhieu);
            this.gbPhieuNhap.Controls.Add(this.txtTenHangHoa);
            this.gbPhieuNhap.Controls.Add(this.gunaLabel4);
            this.gbPhieuNhap.Controls.Add(this.gunaLabel3);
            this.gbPhieuNhap.Controls.Add(this.gunaLabel5);
            this.gbPhieuNhap.Controls.Add(this.gunaLabel6);
            this.gbPhieuNhap.Controls.Add(this.gunaLabel2);
            this.gbPhieuNhap.Controls.Add(this.gunaLabel1);
            this.gbPhieuNhap.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.gbPhieuNhap.Location = new System.Drawing.Point(800, 39);
            this.gbPhieuNhap.Name = "gbPhieuNhap";
            this.gbPhieuNhap.Size = new System.Drawing.Size(417, 308);
            this.gbPhieuNhap.TabIndex = 7;
            this.gbPhieuNhap.TabStop = false;
            this.gbPhieuNhap.Text = "Thông tin phiếu nhập";
            // 
            // cboxNcc
            // 
            this.cboxNcc.FormattingEnabled = true;
            this.cboxNcc.Location = new System.Drawing.Point(174, 239);
            this.cboxNcc.Name = "cboxNcc";
            this.cboxNcc.Size = new System.Drawing.Size(191, 33);
            this.cboxNcc.TabIndex = 17;
            // 
            // btnOpenNcc
            // 
            this.btnOpenNcc.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_plus_math_64;
            this.btnOpenNcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenNcc.Image = null;
            this.btnOpenNcc.ImageSize = new System.Drawing.Size(64, 64);
            this.btnOpenNcc.Location = new System.Drawing.Point(371, 243);
            this.btnOpenNcc.Name = "btnOpenNcc";
            this.btnOpenNcc.OnHoverImage = null;
            this.btnOpenNcc.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnOpenNcc.Size = new System.Drawing.Size(33, 29);
            this.btnOpenNcc.TabIndex = 16;
            this.btnOpenNcc.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.BackColor = System.Drawing.Color.White;
            this.txtTenHangHoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHangHoa.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenHangHoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenHangHoa.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTenHangHoa.Location = new System.Drawing.Point(174, 78);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.PasswordChar = '\0';
            this.txtTenHangHoa.Size = new System.Drawing.Size(230, 30);
            this.txtTenHangHoa.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BaseColor1 = System.Drawing.Color.Snow;
            this.btnXoa.BaseColor2 = System.Drawing.Color.Lime;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_delete_1001;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(1079, 385);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXoa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(131, 50);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AnimationHoverSpeed = 0.07F;
            this.btnSua.AnimationSpeed = 0.03F;
            this.btnSua.BaseColor1 = System.Drawing.Color.Snow;
            this.btnSua.BaseColor2 = System.Drawing.Color.Lime;
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_support_100;
            this.btnSua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSua.Location = new System.Drawing.Point(933, 385);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSua.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(131, 50);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BaseColor1 = System.Drawing.Color.Snow;
            this.btnLuu.BaseColor2 = System.Drawing.Color.Lime;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_save_64;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(1012, 455);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLuu.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(131, 50);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.AnimationHoverSpeed = 0.07F;
            this.btnThemMoi.AnimationSpeed = 0.03F;
            this.btnThemMoi.BaseColor1 = System.Drawing.Color.Snow;
            this.btnThemMoi.BaseColor2 = System.Drawing.Color.Lime;
            this.btnThemMoi.BorderColor = System.Drawing.Color.Black;
            this.btnThemMoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemMoi.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemMoi.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_plus_math_801;
            this.btnThemMoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemMoi.Location = new System.Drawing.Point(786, 385);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnThemMoi.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnThemMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemMoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemMoi.OnHoverImage = null;
            this.btnThemMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemMoi.Size = new System.Drawing.Size(131, 50);
            this.btnThemMoi.TabIndex = 20;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BaseColor1 = System.Drawing.Color.Snow;
            this.btnHuy.BaseColor2 = System.Drawing.Color.Lime;
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_unavailable_240;
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.Location = new System.Drawing.Point(853, 455);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnHuy.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Size = new System.Drawing.Size(131, 50);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 659);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.gbPhieuNhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.gbPhieuNhap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvNhapHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLineTextBox txtMaPhieu;
        private Guna.UI.WinForms.GunaLineTextBox txtDvt;
        private Guna.UI.WinForms.GunaLineTextBox txtSoLuong;
        private Guna.UI.WinForms.GunaLineTextBox txtGiaNhap;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private System.Windows.Forms.GroupBox gbPhieuNhap;
        private System.Windows.Forms.ComboBox cboxNcc;
        private Guna.UI.WinForms.GunaImageButton btnOpenNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNcc;
        private Guna.UI.WinForms.GunaGradientButton btnXoa;
        private Guna.UI.WinForms.GunaGradientButton btnSua;
        private Guna.UI.WinForms.GunaGradientButton btnLuu;
        private Guna.UI.WinForms.GunaGradientButton btnThemMoi;
        private Guna.UI.WinForms.GunaGradientButton btnHuy;
        private Guna.UI.WinForms.GunaLineTextBox txtTenHangHoa;
    }
}