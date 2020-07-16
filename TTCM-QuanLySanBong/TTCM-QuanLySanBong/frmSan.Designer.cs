namespace TTCM_QuanLySanBong
{
    partial class frmSan
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
            this.dgvDsSanBong = new Guna.UI.WinForms.GunaDataGridView();
            this.masan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSan = new System.Windows.Forms.GroupBox();
            this.cboxMaSan = new System.Windows.Forms.ComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cboxTrangThai = new System.Windows.Forms.ComboBox();
            this.cboxTenLs = new System.Windows.Forms.ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenSan = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.btnHuy = new Guna.UI.WinForms.GunaGradientButton();
            this.btnBangGia = new Guna.UI.WinForms.GunaGradientButton();
            this.btnXoa = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSua = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLuu = new Guna.UI.WinForms.GunaGradientButton();
            this.btnThemMoi = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSanBong)).BeginInit();
            this.gbSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(879, 39);
            this.panel1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(371, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sân Bóng";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_close_window_64;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Location = new System.Drawing.Point(834, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Size = new System.Drawing.Size(45, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDsSanBong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.groupBox2.Location = new System.Drawing.Point(0, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 516);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sân bóng";
            // 
            // dgvDsSanBong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDsSanBong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDsSanBong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsSanBong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsSanBong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDsSanBong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDsSanBong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsSanBong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDsSanBong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masan,
            this.tenSan,
            this.tenLoaiSan,
            this.trangthai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDsSanBong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDsSanBong.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDsSanBong.EnableHeadersVisualStyles = false;
            this.dgvDsSanBong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsSanBong.Location = new System.Drawing.Point(3, 28);
            this.dgvDsSanBong.Name = "dgvDsSanBong";
            this.dgvDsSanBong.ReadOnly = true;
            this.dgvDsSanBong.RowHeadersVisible = false;
            this.dgvDsSanBong.RowHeadersWidth = 51;
            this.dgvDsSanBong.RowTemplate.Height = 24;
            this.dgvDsSanBong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsSanBong.Size = new System.Drawing.Size(421, 485);
            this.dgvDsSanBong.TabIndex = 2;
            this.dgvDsSanBong.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDsSanBong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsSanBong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDsSanBong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDsSanBong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDsSanBong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDsSanBong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsSanBong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsSanBong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDsSanBong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDsSanBong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvDsSanBong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDsSanBong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDsSanBong.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDsSanBong.ThemeStyle.ReadOnly = true;
            this.dgvDsSanBong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsSanBong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDsSanBong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvDsSanBong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDsSanBong.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDsSanBong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsSanBong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDsSanBong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsSanBong_CellClick);
            // 
            // masan
            // 
            this.masan.DataPropertyName = "masan";
            this.masan.HeaderText = "Mã Sân";
            this.masan.MinimumWidth = 6;
            this.masan.Name = "masan";
            this.masan.ReadOnly = true;
            // 
            // tenSan
            // 
            this.tenSan.DataPropertyName = "tensan";
            this.tenSan.HeaderText = "Tên Sân";
            this.tenSan.MinimumWidth = 6;
            this.tenSan.Name = "tenSan";
            this.tenSan.ReadOnly = true;
            // 
            // tenLoaiSan
            // 
            this.tenLoaiSan.DataPropertyName = "tenls";
            this.tenLoaiSan.HeaderText = "Tên Loại Sân";
            this.tenLoaiSan.MinimumWidth = 6;
            this.tenLoaiSan.Name = "tenLoaiSan";
            this.tenLoaiSan.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // gbSan
            // 
            this.gbSan.Controls.Add(this.cboxMaSan);
            this.gbSan.Controls.Add(this.gunaLabel4);
            this.gbSan.Controls.Add(this.cboxTrangThai);
            this.gbSan.Controls.Add(this.cboxTenLs);
            this.gbSan.Controls.Add(this.gunaLabel3);
            this.gbSan.Controls.Add(this.gunaLabel2);
            this.gbSan.Controls.Add(this.txtTenSan);
            this.gbSan.Controls.Add(this.gunaLabel1);
            this.gbSan.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.gbSan.Location = new System.Drawing.Point(445, 39);
            this.gbSan.Name = "gbSan";
            this.gbSan.Size = new System.Drawing.Size(434, 188);
            this.gbSan.TabIndex = 6;
            this.gbSan.TabStop = false;
            this.gbSan.Text = "Thông tin sân";
            // 
            // cboxMaSan
            // 
            this.cboxMaSan.FormattingEnabled = true;
            this.cboxMaSan.Location = new System.Drawing.Point(189, 28);
            this.cboxMaSan.Name = "cboxMaSan";
            this.cboxMaSan.Size = new System.Drawing.Size(230, 33);
            this.cboxMaSan.TabIndex = 1;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(15, 24);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(154, 37);
            this.gunaLabel4.TabIndex = 45;
            this.gunaLabel4.Text = "Mã sân";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxTrangThai
            // 
            this.cboxTrangThai.FormattingEnabled = true;
            this.cboxTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Đang thuê"});
            this.cboxTrangThai.Location = new System.Drawing.Point(189, 149);
            this.cboxTrangThai.Name = "cboxTrangThai";
            this.cboxTrangThai.Size = new System.Drawing.Size(230, 33);
            this.cboxTrangThai.TabIndex = 4;
            // 
            // cboxTenLs
            // 
            this.cboxTenLs.FormattingEnabled = true;
            this.cboxTenLs.Location = new System.Drawing.Point(189, 107);
            this.cboxTenLs.Name = "cboxTenLs";
            this.cboxTenLs.Size = new System.Drawing.Size(230, 33);
            this.cboxTenLs.TabIndex = 3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(43, 145);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(126, 37);
            this.gunaLabel3.TabIndex = 43;
            this.gunaLabel3.Text = "Trạng thái";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(15, 103);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(154, 37);
            this.gunaLabel2.TabIndex = 44;
            this.gunaLabel2.Text = "Tên Loại sân";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenSan
            // 
            this.txtTenSan.BackColor = System.Drawing.Color.White;
            this.txtTenSan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSan.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenSan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSan.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTenSan.Location = new System.Drawing.Point(189, 71);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.PasswordChar = '\0';
            this.txtTenSan.Size = new System.Drawing.Size(230, 30);
            this.txtTenSan.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(28, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(140, 37);
            this.gunaLabel1.TabIndex = 41;
            this.gunaLabel1.Text = "Tên sân";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(429, 39);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 507);
            this.gunaVSeparator1.TabIndex = 3;
            this.gunaVSeparator1.Thickness = 5;
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BaseColor1 = System.Drawing.Color.Snow;
            this.btnHuy.BaseColor2 = System.Drawing.Color.Lime;
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_unavailable_240;
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.Location = new System.Drawing.Point(529, 374);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnHuy.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Size = new System.Drawing.Size(131, 50);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnBangGia
            // 
            this.btnBangGia.AnimationHoverSpeed = 0.07F;
            this.btnBangGia.AnimationSpeed = 0.03F;
            this.btnBangGia.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBangGia.BaseColor2 = System.Drawing.Color.DarkOrange;
            this.btnBangGia.BorderColor = System.Drawing.Color.Black;
            this.btnBangGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBangGia.FocusedColor = System.Drawing.Color.Empty;
            this.btnBangGia.Font = new System.Drawing.Font("UVN Thanh Pho", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangGia.ForeColor = System.Drawing.Color.Black;
            this.btnBangGia.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_money_pound_80;
            this.btnBangGia.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBangGia.Location = new System.Drawing.Point(634, 233);
            this.btnBangGia.Name = "btnBangGia";
            this.btnBangGia.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBangGia.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBangGia.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBangGia.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBangGia.OnHoverImage = null;
            this.btnBangGia.OnPressedColor = System.Drawing.Color.Black;
            this.btnBangGia.Size = new System.Drawing.Size(230, 52);
            this.btnBangGia.TabIndex = 5;
            this.btnBangGia.Text = "BẢNG GIÁ";
            this.btnBangGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBangGia.Click += new System.EventHandler(this.btnBangGia_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BaseColor1 = System.Drawing.Color.Snow;
            this.btnXoa.BaseColor2 = System.Drawing.Color.Lime;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_delete_1001;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(707, 374);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXoa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(131, 50);
            this.btnXoa.TabIndex = 26;
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
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_support_100;
            this.btnSua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSua.Location = new System.Drawing.Point(751, 303);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSua.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(131, 50);
            this.btnSua.TabIndex = 27;
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
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_save_64;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(607, 303);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLuu.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(131, 50);
            this.btnLuu.TabIndex = 28;
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
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemMoi.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemMoi.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_plus_math_801;
            this.btnThemMoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemMoi.Location = new System.Drawing.Point(458, 303);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnThemMoi.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnThemMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemMoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemMoi.OnHoverImage = null;
            this.btnThemMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemMoi.Size = new System.Drawing.Size(131, 50);
            this.btnThemMoi.TabIndex = 6;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::TTCM_QuanLySanBong.Properties.Resources.giphy__13_;
            this.gunaPictureBox1.Location = new System.Drawing.Point(449, 430);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(418, 122);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 32;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 555);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnBangGia);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.gbSan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SanBong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSanBong)).EndInit();
            this.gbSan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvDsSanBong;
        private System.Windows.Forms.GroupBox gbSan;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaGradientButton btnHuy;
        private Guna.UI.WinForms.GunaGradientButton btnBangGia;
        private Guna.UI.WinForms.GunaGradientButton btnXoa;
        private Guna.UI.WinForms.GunaGradientButton btnSua;
        private Guna.UI.WinForms.GunaGradientButton btnLuu;
        private Guna.UI.WinForms.GunaGradientButton btnThemMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn masan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.ComboBox cboxMaSan;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.ComboBox cboxTrangThai;
        private System.Windows.Forms.ComboBox cboxTenLs;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txtTenSan;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}