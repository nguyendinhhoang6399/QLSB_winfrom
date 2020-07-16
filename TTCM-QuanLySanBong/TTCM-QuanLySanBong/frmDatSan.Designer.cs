namespace TTCM_QuanLySanBong
{
    partial class frmDatSan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.gbDatSan = new System.Windows.Forms.GroupBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.cboxtrangThai = new System.Windows.Forms.ComboBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.dtpDenGio = new System.Windows.Forms.DateTimePicker();
            this.dtpTuGio = new System.Windows.Forms.DateTimePicker();
            this.btnThemKH = new Guna.UI.WinForms.GunaImageButton();
            this.cboxMaDatSan = new System.Windows.Forms.ComboBox();
            this.cboxTenSan = new System.Windows.Forms.ComboBox();
            this.cboxKhachHang = new System.Windows.Forms.ComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnLuu = new Guna.UI.WinForms.GunaGradientButton();
            this.btnReset = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            this.gbDatSan.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(803, 39);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(351, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đặt Sân";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_close_window_64;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Location = new System.Drawing.Point(758, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Size = new System.Drawing.Size(45, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbDatSan
            // 
            this.gbDatSan.Controls.Add(this.dtpDenNgay);
            this.gbDatSan.Controls.Add(this.dtpTuNgay);
            this.gbDatSan.Controls.Add(this.cboxtrangThai);
            this.gbDatSan.Controls.Add(this.dtpThoiGian);
            this.gbDatSan.Controls.Add(this.dtpDenGio);
            this.gbDatSan.Controls.Add(this.dtpTuGio);
            this.gbDatSan.Controls.Add(this.btnThemKH);
            this.gbDatSan.Controls.Add(this.cboxMaDatSan);
            this.gbDatSan.Controls.Add(this.cboxTenSan);
            this.gbDatSan.Controls.Add(this.cboxKhachHang);
            this.gbDatSan.Controls.Add(this.gunaLabel8);
            this.gbDatSan.Controls.Add(this.gunaLabel7);
            this.gbDatSan.Controls.Add(this.gunaLabel5);
            this.gbDatSan.Controls.Add(this.gunaLabel10);
            this.gbDatSan.Controls.Add(this.gunaLabel6);
            this.gbDatSan.Controls.Add(this.gunaLabel4);
            this.gbDatSan.Controls.Add(this.gunaLabel2);
            this.gbDatSan.Controls.Add(this.gunaLabel1);
            this.gbDatSan.Controls.Add(this.gunaLabel3);
            this.gbDatSan.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatSan.Location = new System.Drawing.Point(3, 45);
            this.gbDatSan.Name = "gbDatSan";
            this.gbDatSan.Size = new System.Drawing.Size(800, 331);
            this.gbDatSan.TabIndex = 1;
            this.gbDatSan.TabStop = false;
            this.gbDatSan.Text = "Thông tin đặt sân";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(455, 170);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(183, 32);
            this.dtpDenNgay.TabIndex = 5;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(150, 170);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(196, 32);
            this.dtpTuNgay.TabIndex = 4;
            // 
            // cboxtrangThai
            // 
            this.cboxtrangThai.FormattingEnabled = true;
            this.cboxtrangThai.Items.AddRange(new object[] {
            "Đang Đặt",
            "Đã Hủy"});
            this.cboxtrangThai.Location = new System.Drawing.Point(152, 275);
            this.cboxtrangThai.Name = "cboxtrangThai";
            this.cboxtrangThai.Size = new System.Drawing.Size(171, 33);
            this.cboxtrangThai.TabIndex = 9;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpThoiGian.CustomFormat = "HH:mm";
            this.dtpThoiGian.Font = new System.Drawing.Font("UVN Thay Giao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(682, 207);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.ShowUpDown = true;
            this.dtpThoiGian.Size = new System.Drawing.Size(98, 35);
            this.dtpThoiGian.TabIndex = 8;
            this.dtpThoiGian.Value = new System.DateTime(2020, 7, 8, 0, 0, 0, 0);
            // 
            // dtpDenGio
            // 
            this.dtpDenGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDenGio.CustomFormat = "HH:mm";
            this.dtpDenGio.Font = new System.Drawing.Font("UVN Thay Giao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenGio.Location = new System.Drawing.Point(455, 211);
            this.dtpDenGio.Name = "dtpDenGio";
            this.dtpDenGio.ShowUpDown = true;
            this.dtpDenGio.Size = new System.Drawing.Size(183, 35);
            this.dtpDenGio.TabIndex = 7;
            this.dtpDenGio.Value = new System.DateTime(2020, 7, 8, 0, 0, 0, 0);
            // 
            // dtpTuGio
            // 
            this.dtpTuGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpTuGio.CustomFormat = "HH:mm";
            this.dtpTuGio.Font = new System.Drawing.Font("UVN Thay Giao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuGio.Location = new System.Drawing.Point(150, 213);
            this.dtpTuGio.Name = "dtpTuGio";
            this.dtpTuGio.ShowUpDown = true;
            this.dtpTuGio.Size = new System.Drawing.Size(196, 35);
            this.dtpTuGio.TabIndex = 6;
            this.dtpTuGio.Value = new System.DateTime(2020, 7, 8, 0, 0, 0, 0);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_plus_math_64;
            this.btnThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKH.Image = null;
            this.btnThemKH.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemKH.Location = new System.Drawing.Point(755, 74);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.OnHoverImage = null;
            this.btnThemKH.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnThemKH.Size = new System.Drawing.Size(33, 29);
            this.btnThemKH.TabIndex = 1;
            this.btnThemKH.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // cboxMaDatSan
            // 
            this.cboxMaDatSan.Font = new System.Drawing.Font("UVN Thanh Pho", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMaDatSan.FormattingEnabled = true;
            this.cboxMaDatSan.Location = new System.Drawing.Point(150, 31);
            this.cboxMaDatSan.Name = "cboxMaDatSan";
            this.cboxMaDatSan.Size = new System.Drawing.Size(636, 29);
            this.cboxMaDatSan.TabIndex = 1;
            this.cboxMaDatSan.SelectedIndexChanged += new System.EventHandler(this.cboxMaDatSan_SelectedIndexChanged);
            // 
            // cboxTenSan
            // 
            this.cboxTenSan.Font = new System.Drawing.Font("UVN Thanh Pho", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTenSan.FormattingEnabled = true;
            this.cboxTenSan.Location = new System.Drawing.Point(152, 123);
            this.cboxTenSan.Name = "cboxTenSan";
            this.cboxTenSan.Size = new System.Drawing.Size(636, 29);
            this.cboxTenSan.TabIndex = 3;
            // 
            // cboxKhachHang
            // 
            this.cboxKhachHang.Font = new System.Drawing.Font("UVN Thanh Pho", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKhachHang.FormattingEnabled = true;
            this.cboxKhachHang.Location = new System.Drawing.Point(152, 74);
            this.cboxKhachHang.Name = "cboxKhachHang";
            this.cboxKhachHang.Size = new System.Drawing.Size(602, 29);
            this.cboxKhachHang.TabIndex = 2;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(666, 170);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(128, 34);
            this.gunaLabel8.TabIndex = 2;
            this.gunaLabel8.Text = "Thời gian";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(352, 213);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(82, 34);
            this.gunaLabel7.TabIndex = 2;
            this.gunaLabel7.Text = "Đến giờ";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(352, 170);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(97, 34);
            this.gunaLabel5.TabIndex = 2;
            this.gunaLabel5.Text = "Đến ngày";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel10.Location = new System.Drawing.Point(11, 272);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(117, 34);
            this.gunaLabel10.TabIndex = 2;
            this.gunaLabel10.Text = "Hiện Trạng";
            this.gunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(9, 213);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(117, 34);
            this.gunaLabel6.TabIndex = 2;
            this.gunaLabel6.Text = "Đặt từ giờ";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(9, 170);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(117, 34);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Đặt từ ngày";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(9, 120);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(117, 34);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Tên Sân";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 69);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(126, 34);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Khách Hàng";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(9, 28);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(117, 34);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Mã đặt sân";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnLuu.Location = new System.Drawing.Point(445, 393);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLuu.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(131, 50);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BaseColor1 = System.Drawing.Color.Snow;
            this.btnReset.BaseColor2 = System.Drawing.Color.Lime;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_available_updates_100;
            this.btnReset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset.Location = new System.Drawing.Point(233, 393);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnReset.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Size = new System.Drawing.Size(131, 50);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 472);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbDatSan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Sân";
            this.Load += new System.EventHandler(this.frmDatSan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDatSan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbDatSan;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.ComboBox cboxKhachHang;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ComboBox cboxTenSan;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaImageButton btnThemKH;
        private Guna.UI.WinForms.GunaGradientButton btnReset;
        private Guna.UI.WinForms.GunaGradientButton btnLuu;
        private System.Windows.Forms.DateTimePicker dtpDenGio;
        private System.Windows.Forms.DateTimePicker dtpTuGio;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.ComboBox cboxtrangThai;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.ComboBox cboxMaDatSan;
    }
}