namespace TTCM_QuanLySanBong
{
    partial class frmBangGia
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
            this.gbBangGia = new System.Windows.Forms.GroupBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBangGia = new Guna.UI.WinForms.GunaDataGridView();
            this.btnSua = new Guna.UI.WinForms.GunaGradientButton();
            this.btnXoa = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLuu = new Guna.UI.WinForms.GunaGradientButton();
            this.btnThemMoi = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.btnHuy = new Guna.UI.WinForms.GunaGradientButton();
            this.panTTBG = new System.Windows.Forms.Panel();
            this.dtpDenGio = new System.Windows.Forms.DateTimePicker();
            this.dtpTuGio = new System.Windows.Forms.DateTimePicker();
            this.txtDonGia = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.mals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tugio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dengio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxTenLs = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.gbBangGia.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).BeginInit();
            this.panTTBG.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng giá sân";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_close_window_64;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // gbBangGia
            // 
            this.gbBangGia.Controls.Add(this.cboxTenLs);
            this.gbBangGia.Controls.Add(this.panTTBG);
            this.gbBangGia.Controls.Add(this.gunaLabel2);
            this.gbBangGia.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.gbBangGia.Location = new System.Drawing.Point(433, 39);
            this.gbBangGia.Name = "gbBangGia";
            this.gbBangGia.Size = new System.Drawing.Size(446, 265);
            this.gbBangGia.TabIndex = 7;
            this.gbBangGia.TabStop = false;
            this.gbBangGia.Text = "Thông tin bảng giá giờ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(6, 44);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(152, 37);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Tên Loại sân";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBangGia);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.groupBox2.Location = new System.Drawing.Point(0, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 516);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng giá giờ";
            // 
            // dgvBangGia
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBangGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBangGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvBangGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBangGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBangGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBangGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mals,
            this.loaisan,
            this.tugio,
            this.dengio,
            this.dongia});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangGia.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBangGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBangGia.EnableHeadersVisualStyles = false;
            this.dgvBangGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangGia.Location = new System.Drawing.Point(3, 28);
            this.dgvBangGia.Name = "dgvBangGia";
            this.dgvBangGia.ReadOnly = true;
            this.dgvBangGia.RowHeadersVisible = false;
            this.dgvBangGia.RowHeadersWidth = 51;
            this.dgvBangGia.RowTemplate.Height = 24;
            this.dgvBangGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangGia.Size = new System.Drawing.Size(421, 485);
            this.dgvBangGia.TabIndex = 2;
            this.dgvBangGia.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBangGia.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangGia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBangGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBangGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvBangGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBangGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBangGia.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvBangGia.ThemeStyle.ReadOnly = true;
            this.dgvBangGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBangGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvBangGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangGia.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBangGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGia_CellClick);
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
            this.btnSua.Location = new System.Drawing.Point(743, 310);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSua.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(131, 50);
            this.btnSua.TabIndex = 22;
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
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_delete_1001;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(681, 377);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXoa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(131, 50);
            this.btnXoa.TabIndex = 19;
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
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_save_64;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(594, 310);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLuu.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(131, 50);
            this.btnLuu.TabIndex = 20;
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
            this.btnThemMoi.Location = new System.Drawing.Point(442, 310);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnThemMoi.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnThemMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemMoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemMoi.OnHoverImage = null;
            this.btnThemMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemMoi.Size = new System.Drawing.Size(131, 50);
            this.btnThemMoi.TabIndex = 21;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(429, 39);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 514);
            this.gunaVSeparator1.TabIndex = 23;
            this.gunaVSeparator1.Thickness = 5;
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
            this.btnHuy.Location = new System.Drawing.Point(496, 377);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnHuy.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Size = new System.Drawing.Size(131, 50);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panTTBG
            // 
            this.panTTBG.Controls.Add(this.dtpDenGio);
            this.panTTBG.Controls.Add(this.dtpTuGio);
            this.panTTBG.Controls.Add(this.txtDonGia);
            this.panTTBG.Controls.Add(this.gunaLabel4);
            this.panTTBG.Controls.Add(this.gunaLabel3);
            this.panTTBG.Controls.Add(this.gunaLabel1);
            this.panTTBG.Location = new System.Drawing.Point(9, 87);
            this.panTTBG.Name = "panTTBG";
            this.panTTBG.Size = new System.Drawing.Size(428, 170);
            this.panTTBG.TabIndex = 19;
            // 
            // dtpDenGio
            // 
            this.dtpDenGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDenGio.CustomFormat = "HH:mm";
            this.dtpDenGio.Font = new System.Drawing.Font("UVN Thay Giao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenGio.Location = new System.Drawing.Point(171, 69);
            this.dtpDenGio.Name = "dtpDenGio";
            this.dtpDenGio.ShowUpDown = true;
            this.dtpDenGio.Size = new System.Drawing.Size(222, 35);
            this.dtpDenGio.TabIndex = 23;
            this.dtpDenGio.Value = new System.DateTime(2020, 7, 8, 0, 0, 0, 0);
            // 
            // dtpTuGio
            // 
            this.dtpTuGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpTuGio.CustomFormat = "HH:mm";
            this.dtpTuGio.Font = new System.Drawing.Font("UVN Thay Giao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuGio.Location = new System.Drawing.Point(171, 24);
            this.dtpTuGio.Name = "dtpTuGio";
            this.dtpTuGio.ShowUpDown = true;
            this.dtpTuGio.Size = new System.Drawing.Size(222, 35);
            this.dtpTuGio.TabIndex = 24;
            this.dtpTuGio.Value = new System.DateTime(2020, 7, 8, 0, 0, 0, 0);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonGia.LineColor = System.Drawing.Color.Gainsboro;
            this.txtDonGia.Location = new System.Drawing.Point(171, 122);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.Size = new System.Drawing.Size(230, 30);
            this.txtDonGia.TabIndex = 22;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(27, 115);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(126, 37);
            this.gunaLabel4.TabIndex = 19;
            this.gunaLabel4.Text = "Đơn giá";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(27, 68);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(126, 37);
            this.gunaLabel3.TabIndex = 20;
            this.gunaLabel3.Text = "Đến giờ";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(27, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(126, 37);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Từ giờ";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mals
            // 
            this.mals.DataPropertyName = "mals";
            this.mals.HeaderText = "Mã LS";
            this.mals.MinimumWidth = 6;
            this.mals.Name = "mals";
            this.mals.ReadOnly = true;
            // 
            // loaisan
            // 
            this.loaisan.DataPropertyName = "tenls";
            this.loaisan.HeaderText = "Tên LS";
            this.loaisan.MinimumWidth = 6;
            this.loaisan.Name = "loaisan";
            this.loaisan.ReadOnly = true;
            // 
            // tugio
            // 
            this.tugio.DataPropertyName = "giobatdau";
            this.tugio.HeaderText = "Từ giờ";
            this.tugio.MinimumWidth = 6;
            this.tugio.Name = "tugio";
            this.tugio.ReadOnly = true;
            // 
            // dengio
            // 
            this.dengio.DataPropertyName = "gioketthuc";
            this.dengio.HeaderText = "Đến giờ";
            this.dengio.MinimumWidth = 6;
            this.dengio.Name = "dengio";
            this.dengio.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // cboxTenLs
            // 
            this.cboxTenLs.FormattingEnabled = true;
            this.cboxTenLs.Location = new System.Drawing.Point(183, 48);
            this.cboxTenLs.Name = "cboxTenLs";
            this.cboxTenLs.Size = new System.Drawing.Size(222, 33);
            this.cboxTenLs.TabIndex = 21;
            // 
            // frmBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 555);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbBangGia);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBangGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBangGia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbBangGia.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).EndInit();
            this.panTTBG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private System.Windows.Forms.GroupBox gbBangGia;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvBangGia;
        private Guna.UI.WinForms.GunaGradientButton btnSua;
        private Guna.UI.WinForms.GunaGradientButton btnXoa;
        private Guna.UI.WinForms.GunaGradientButton btnLuu;
        private Guna.UI.WinForms.GunaGradientButton btnThemMoi;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaGradientButton btnHuy;
        private System.Windows.Forms.Panel panTTBG;
        private System.Windows.Forms.DateTimePicker dtpDenGio;
        private System.Windows.Forms.DateTimePicker dtpTuGio;
        private Guna.UI.WinForms.GunaLineTextBox txtDonGia;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mals;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tugio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dengio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.ComboBox cboxTenLs;
    }
}