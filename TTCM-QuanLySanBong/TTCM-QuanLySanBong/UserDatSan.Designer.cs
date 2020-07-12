namespace TTCM_QuanLySanBong
{
    partial class UserDatSan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.dgvDatSan = new Guna.UI.WinForms.GunaDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.cboxTenSan = new System.Windows.Forms.ComboBox();
            this.cboxKhachHang = new System.Windows.Forms.ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btnThemSan = new Guna.UI.WinForms.GunaImageButton();
            this.btnLichSan = new Guna.UI.WinForms.GunaGradientButton();
            this.btnXoaLich = new Guna.UI.WinForms.GunaGradientButton();
            this.btnBoHuy = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHuySan = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSuaLich = new Guna.UI.WinForms.GunaGradientButton();
            this.btnTaoMoi = new Guna.UI.WinForms.GunaGradientButton();
            this.lbMaDS = new Guna.UI.WinForms.GunaLabel();
            this.MaDatSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.san = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tungay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tugio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dengio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatSan)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Thanh Pho", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH ĐẶT SÂN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.lbMaDS);
            this.panel1.Controls.Add(this.gunaVSeparator1);
            this.panel1.Controls.Add(this.btnThemSan);
            this.panel1.Controls.Add(this.dgvDatSan);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.cboxTenSan);
            this.panel1.Controls.Add(this.cboxKhachHang);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 614);
            this.panel1.TabIndex = 1;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(996, -3);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(21, 617);
            this.gunaVSeparator1.TabIndex = 15;
            this.gunaVSeparator1.Thickness = 5;
            // 
            // dgvDatSan
            // 
            this.dgvDatSan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDatSan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatSan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatSan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatSan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatSan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatSan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatSan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatSan.ColumnHeadersHeight = 27;
            this.dgvDatSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDatSan,
            this.khachhang,
            this.san,
            this.tungay,
            this.denngay,
            this.tugio,
            this.dengio,
            this.tg,
            this.trangthai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatSan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatSan.EnableHeadersVisualStyles = false;
            this.dgvDatSan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatSan.Location = new System.Drawing.Point(9, 104);
            this.dgvDatSan.Name = "dgvDatSan";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatSan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatSan.RowHeadersVisible = false;
            this.dgvDatSan.RowHeadersWidth = 51;
            this.dgvDatSan.RowTemplate.Height = 24;
            this.dgvDatSan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatSan.Size = new System.Drawing.Size(981, 507);
            this.dgvDatSan.TabIndex = 13;
            this.dgvDatSan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDatSan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatSan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDatSan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDatSan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDatSan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDatSan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatSan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatSan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDatSan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatSan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDatSan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDatSan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDatSan.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvDatSan.ThemeStyle.ReadOnly = false;
            this.dgvDatSan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatSan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatSan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDatSan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDatSan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDatSan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDatSan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDatSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatSan_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLichSan);
            this.panel2.Controls.Add(this.btnXoaLich);
            this.panel2.Controls.Add(this.btnBoHuy);
            this.panel2.Controls.Add(this.btnHuySan);
            this.panel2.Controls.Add(this.btnSuaLich);
            this.panel2.Controls.Add(this.btnTaoMoi);
            this.panel2.Location = new System.Drawing.Point(1026, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 480);
            this.panel2.TabIndex = 12;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(827, 53);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(163, 34);
            this.dtpDenNgay.TabIndex = 3;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(663, 53);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(149, 34);
            this.dtpTuNgay.TabIndex = 3;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // cboxTenSan
            // 
            this.cboxTenSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTenSan.FormattingEnabled = true;
            this.cboxTenSan.Location = new System.Drawing.Point(355, 49);
            this.cboxTenSan.Name = "cboxTenSan";
            this.cboxTenSan.Size = new System.Drawing.Size(222, 37);
            this.cboxTenSan.TabIndex = 2;
            this.cboxTenSan.SelectedIndexChanged += new System.EventHandler(this.cboxTenSan_SelectedIndexChanged);
            // 
            // cboxKhachHang
            // 
            this.cboxKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKhachHang.FormattingEnabled = true;
            this.cboxKhachHang.Location = new System.Drawing.Point(9, 50);
            this.cboxKhachHang.Name = "cboxKhachHang";
            this.cboxKhachHang.Size = new System.Drawing.Size(316, 37);
            this.cboxKhachHang.TabIndex = 2;
            this.cboxKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboxKhachHang_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("UVN Thanh Pho", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(821, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(116, 37);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Đến ngày";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("UVN Thanh Pho", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(657, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 37);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Từ ngày";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("UVN Thanh Pho", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(359, 8);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(137, 37);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Tên Sân";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("UVN Thanh Pho", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(13, 9);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(137, 37);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Khách hàng";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(6, 33);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(1208, 15);
            this.gunaSeparator1.TabIndex = 2;
            this.gunaSeparator1.Thickness = 5;
            // 
            // btnThemSan
            // 
            this.btnThemSan.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_plus_math_64;
            this.btnThemSan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSan.Image = null;
            this.btnThemSan.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemSan.Location = new System.Drawing.Point(597, 50);
            this.btnThemSan.Name = "btnThemSan";
            this.btnThemSan.OnHoverImage = null;
            this.btnThemSan.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnThemSan.Size = new System.Drawing.Size(38, 37);
            this.btnThemSan.TabIndex = 14;
            this.btnThemSan.Click += new System.EventHandler(this.btnThemSan_Click);
            // 
            // btnLichSan
            // 
            this.btnLichSan.AnimationHoverSpeed = 0.07F;
            this.btnLichSan.AnimationSpeed = 0.03F;
            this.btnLichSan.BaseColor1 = System.Drawing.Color.Snow;
            this.btnLichSan.BaseColor2 = System.Drawing.Color.Lime;
            this.btnLichSan.BorderColor = System.Drawing.Color.Black;
            this.btnLichSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSan.FocusedColor = System.Drawing.Color.Empty;
            this.btnLichSan.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSan.ForeColor = System.Drawing.Color.Black;
            this.btnLichSan.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_stadium_48;
            this.btnLichSan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLichSan.Location = new System.Drawing.Point(14, 40);
            this.btnLichSan.Name = "btnLichSan";
            this.btnLichSan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLichSan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLichSan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLichSan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLichSan.OnHoverImage = null;
            this.btnLichSan.OnPressedColor = System.Drawing.Color.Black;
            this.btnLichSan.Size = new System.Drawing.Size(146, 50);
            this.btnLichSan.TabIndex = 11;
            this.btnLichSan.Text = "LỊCH SÂN";
            this.btnLichSan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLichSan.Click += new System.EventHandler(this.btnLichSan_Click);
            // 
            // btnXoaLich
            // 
            this.btnXoaLich.AnimationHoverSpeed = 0.07F;
            this.btnXoaLich.AnimationSpeed = 0.03F;
            this.btnXoaLich.BaseColor1 = System.Drawing.Color.Snow;
            this.btnXoaLich.BaseColor2 = System.Drawing.Color.Lime;
            this.btnXoaLich.BorderColor = System.Drawing.Color.Black;
            this.btnXoaLich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLich.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaLich.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLich.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLich.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_delete_100;
            this.btnXoaLich.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaLich.Location = new System.Drawing.Point(14, 382);
            this.btnXoaLich.Name = "btnXoaLich";
            this.btnXoaLich.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXoaLich.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXoaLich.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaLich.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaLich.OnHoverImage = null;
            this.btnXoaLich.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaLich.Size = new System.Drawing.Size(146, 50);
            this.btnXoaLich.TabIndex = 11;
            this.btnXoaLich.Text = "XÓA LỊCH";
            this.btnXoaLich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoaLich.Click += new System.EventHandler(this.btnXoaLich_Click);
            // 
            // btnBoHuy
            // 
            this.btnBoHuy.AnimationHoverSpeed = 0.07F;
            this.btnBoHuy.AnimationSpeed = 0.03F;
            this.btnBoHuy.BaseColor1 = System.Drawing.Color.Snow;
            this.btnBoHuy.BaseColor2 = System.Drawing.Color.Lime;
            this.btnBoHuy.BorderColor = System.Drawing.Color.Black;
            this.btnBoHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnBoHuy.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoHuy.ForeColor = System.Drawing.Color.Black;
            this.btnBoHuy.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_file_144;
            this.btnBoHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBoHuy.Location = new System.Drawing.Point(14, 315);
            this.btnBoHuy.Name = "btnBoHuy";
            this.btnBoHuy.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBoHuy.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBoHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBoHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBoHuy.OnHoverImage = null;
            this.btnBoHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnBoHuy.Size = new System.Drawing.Size(146, 50);
            this.btnBoHuy.TabIndex = 11;
            this.btnBoHuy.Text = "BỎ HỦY";
            this.btnBoHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBoHuy.Click += new System.EventHandler(this.btnBoHuy_Click);
            // 
            // btnHuySan
            // 
            this.btnHuySan.AnimationHoverSpeed = 0.07F;
            this.btnHuySan.AnimationSpeed = 0.03F;
            this.btnHuySan.BaseColor1 = System.Drawing.Color.Snow;
            this.btnHuySan.BaseColor2 = System.Drawing.Color.Lime;
            this.btnHuySan.BorderColor = System.Drawing.Color.Black;
            this.btnHuySan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuySan.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuySan.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuySan.ForeColor = System.Drawing.Color.Black;
            this.btnHuySan.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_file_delete_96;
            this.btnHuySan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuySan.Location = new System.Drawing.Point(14, 246);
            this.btnHuySan.Name = "btnHuySan";
            this.btnHuySan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnHuySan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnHuySan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuySan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuySan.OnHoverImage = null;
            this.btnHuySan.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuySan.Size = new System.Drawing.Size(146, 50);
            this.btnHuySan.TabIndex = 11;
            this.btnHuySan.Text = "HỦY SÂN";
            this.btnHuySan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHuySan.Click += new System.EventHandler(this.btnHuySan_Click);
            // 
            // btnSuaLich
            // 
            this.btnSuaLich.AnimationHoverSpeed = 0.07F;
            this.btnSuaLich.AnimationSpeed = 0.03F;
            this.btnSuaLich.BaseColor1 = System.Drawing.Color.Snow;
            this.btnSuaLich.BaseColor2 = System.Drawing.Color.Lime;
            this.btnSuaLich.BorderColor = System.Drawing.Color.Black;
            this.btnSuaLich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaLich.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaLich.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLich.ForeColor = System.Drawing.Color.Black;
            this.btnSuaLich.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_inscription_96;
            this.btnSuaLich.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaLich.Location = new System.Drawing.Point(14, 179);
            this.btnSuaLich.Name = "btnSuaLich";
            this.btnSuaLich.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSuaLich.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSuaLich.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaLich.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaLich.OnHoverImage = null;
            this.btnSuaLich.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaLich.Size = new System.Drawing.Size(146, 50);
            this.btnSuaLich.TabIndex = 11;
            this.btnSuaLich.Text = "SỬA LỊCH";
            this.btnSuaLich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSuaLich.Click += new System.EventHandler(this.btnSuaLich_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.AnimationHoverSpeed = 0.07F;
            this.btnTaoMoi.AnimationSpeed = 0.03F;
            this.btnTaoMoi.BaseColor1 = System.Drawing.Color.Snow;
            this.btnTaoMoi.BaseColor2 = System.Drawing.Color.Lime;
            this.btnTaoMoi.BorderColor = System.Drawing.Color.Black;
            this.btnTaoMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoMoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnTaoMoi.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.Black;
            this.btnTaoMoi.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_plus_math_80;
            this.btnTaoMoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTaoMoi.Location = new System.Drawing.Point(14, 108);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnTaoMoi.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnTaoMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTaoMoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTaoMoi.OnHoverImage = null;
            this.btnTaoMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnTaoMoi.Size = new System.Drawing.Size(146, 50);
            this.btnTaoMoi.TabIndex = 11;
            this.btnTaoMoi.Text = "TẠO MỚI";
            this.btnTaoMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // lbMaDS
            // 
            this.lbMaDS.Font = new System.Drawing.Font("UVN Thanh Pho", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDS.ForeColor = System.Drawing.Color.Red;
            this.lbMaDS.Location = new System.Drawing.Point(1046, 41);
            this.lbMaDS.Name = "lbMaDS";
            this.lbMaDS.Size = new System.Drawing.Size(147, 41);
            this.lbMaDS.TabIndex = 16;
            this.lbMaDS.Text = "\r\nabc";
            this.lbMaDS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaDatSan
            // 
            this.MaDatSan.DataPropertyName = "madatsan";
            this.MaDatSan.HeaderText = "Mã Đặt Sân";
            this.MaDatSan.MinimumWidth = 6;
            this.MaDatSan.Name = "MaDatSan";
            // 
            // khachhang
            // 
            this.khachhang.DataPropertyName = "tenkh";
            this.khachhang.HeaderText = "Khách";
            this.khachhang.MinimumWidth = 6;
            this.khachhang.Name = "khachhang";
            // 
            // san
            // 
            this.san.DataPropertyName = "tensan";
            this.san.HeaderText = "Sân";
            this.san.MinimumWidth = 6;
            this.san.Name = "san";
            // 
            // tungay
            // 
            this.tungay.DataPropertyName = "tungay";
            this.tungay.HeaderText = "Từ Ngày";
            this.tungay.MinimumWidth = 6;
            this.tungay.Name = "tungay";
            // 
            // denngay
            // 
            this.denngay.DataPropertyName = "denngay";
            this.denngay.HeaderText = "Đến Ngày";
            this.denngay.MinimumWidth = 6;
            this.denngay.Name = "denngay";
            // 
            // tugio
            // 
            this.tugio.DataPropertyName = "tugio";
            this.tugio.HeaderText = "Từ Giờ";
            this.tugio.MinimumWidth = 6;
            this.tugio.Name = "tugio";
            // 
            // dengio
            // 
            this.dengio.DataPropertyName = "dengio";
            this.dengio.HeaderText = "Đến Giờ";
            this.dengio.MinimumWidth = 6;
            this.dengio.Name = "dengio";
            // 
            // tg
            // 
            this.tg.DataPropertyName = "thoigian";
            this.tg.HeaderText = "Thời Gian";
            this.tg.MinimumWidth = 6;
            this.tg.Name = "tg";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("UVN Nhat Ky", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Blue;
            this.gunaLabel5.Location = new System.Drawing.Point(1048, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(147, 41);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "MÃ ĐẶT SÂN";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserDatSan";
            this.Size = new System.Drawing.Size(1217, 659);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatSan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxKhachHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private Guna.UI.WinForms.GunaGradientButton btnLichSan;
        private Guna.UI.WinForms.GunaGradientButton btnTaoMoi;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradientButton btnSuaLich;
        private Guna.UI.WinForms.GunaGradientButton btnHuySan;
        private System.Windows.Forms.ComboBox cboxTenSan;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaGradientButton btnXoaLich;
        private Guna.UI.WinForms.GunaGradientButton btnBoHuy;
        private Guna.UI.WinForms.GunaDataGridView dgvDatSan;
        private Guna.UI.WinForms.GunaImageButton btnThemSan;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaLabel lbMaDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDatSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn san;
        private System.Windows.Forms.DataGridViewTextBoxColumn tungay;
        private System.Windows.Forms.DataGridViewTextBoxColumn denngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tugio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dengio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}
