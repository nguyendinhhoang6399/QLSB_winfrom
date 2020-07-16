namespace TTCM_QuanLySanBong
{
    partial class frmNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDsPhieu = new Guna.UI.WinForms.GunaDataGridView();
            this.maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnXoa = new Guna.UI.WinForms.GunaGradientButton();
            this.btnTaoMoi = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhieu)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Hàng";
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
            this.groupBox2.Controls.Add(this.dgvDsPhieu);
            this.groupBox2.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.groupBox2.Location = new System.Drawing.Point(3, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 471);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // dgvDsPhieu
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDsPhieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDsPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsPhieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDsPhieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDsPhieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsPhieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDsPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieu,
            this.nhacungcap,
            this.ngaylap,
            this.thanhtien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDsPhieu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDsPhieu.EnableHeadersVisualStyles = false;
            this.dgvDsPhieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsPhieu.Location = new System.Drawing.Point(3, 28);
            this.dgvDsPhieu.Name = "dgvDsPhieu";
            this.dgvDsPhieu.ReadOnly = true;
            this.dgvDsPhieu.RowHeadersVisible = false;
            this.dgvDsPhieu.RowHeadersWidth = 51;
            this.dgvDsPhieu.RowTemplate.Height = 24;
            this.dgvDsPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsPhieu.Size = new System.Drawing.Size(660, 443);
            this.dgvDsPhieu.TabIndex = 2;
            this.dgvDsPhieu.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDsPhieu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsPhieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDsPhieu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDsPhieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDsPhieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDsPhieu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsPhieu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsPhieu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDsPhieu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDsPhieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvDsPhieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDsPhieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDsPhieu.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDsPhieu.ThemeStyle.ReadOnly = true;
            this.dgvDsPhieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsPhieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDsPhieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvDsPhieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDsPhieu.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDsPhieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsPhieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDsPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsPhieu_CellClick);
            // 
            // maphieu
            // 
            this.maphieu.DataPropertyName = "maphieu";
            this.maphieu.HeaderText = "Mã Phiếu";
            this.maphieu.MinimumWidth = 6;
            this.maphieu.Name = "maphieu";
            this.maphieu.ReadOnly = true;
            // 
            // nhacungcap
            // 
            this.nhacungcap.DataPropertyName = "tenNcc";
            this.nhacungcap.HeaderText = "Nhà Cung Cấp";
            this.nhacungcap.MinimumWidth = 6;
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.ReadOnly = true;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngayNhap";
            this.ngaylap.HeaderText = "Ngày Lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(249, 44);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 37);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Đến ngày";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 44);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(93, 37);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Từ ngày";
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(672, 44);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(29, 511);
            this.gunaVSeparator1.TabIndex = 16;
            this.gunaVSeparator1.Thickness = 5;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(94, 44);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(149, 34);
            this.dtpTuNgay.TabIndex = 17;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(339, 45);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(163, 34);
            this.dtpDenNgay.TabIndex = 18;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UVN Thay Giao", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(724, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã Phiếu";
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.Font = new System.Drawing.Font("UVN Thay Giao", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieu.ForeColor = System.Drawing.Color.Red;
            this.lbMaPhieu.Location = new System.Drawing.Point(724, 97);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(143, 40);
            this.lbMaPhieu.TabIndex = 19;
            this.lbMaPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.Snow;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Lime;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_search_more_1001;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(723, 184);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(144, 50);
            this.gunaGradientButton1.TabIndex = 12;
            this.gunaGradientButton1.Text = "XEM CT";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(723, 317);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXoa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(144, 50);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "XÓA PHIẾU";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnTaoMoi.Location = new System.Drawing.Point(723, 252);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnTaoMoi.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnTaoMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTaoMoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTaoMoi.OnHoverImage = null;
            this.btnTaoMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnTaoMoi.Size = new System.Drawing.Size(144, 50);
            this.btnTaoMoi.TabIndex = 12;
            this.btnTaoMoi.Text = "TẠO MỚI";
            this.btnTaoMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::TTCM_QuanLySanBong.Properties.Resources.giphy__16_;
            this.gunaPictureBox1.Location = new System.Drawing.Point(678, 373);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(228, 182);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 24;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 555);
            this.Controls.Add(this.lbMaPhieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvDsPhieu;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientButton btnTaoMoi;
        private Guna.UI.WinForms.GunaGradientButton btnXoa;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaPhieu;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}