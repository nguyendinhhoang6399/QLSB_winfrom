namespace TTCM_QuanLySanBong
{
    partial class frmNhaCungCap
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dgvNcc = new Guna.UI.WinForms.GunaDataGridView();
            this.maNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxNcc = new System.Windows.Forms.GroupBox();
            this.txtSDT = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDiaChi = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTenNcc = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSua = new Guna.UI.WinForms.GunaGradientButton();
            this.btnXoa = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLuu = new Guna.UI.WinForms.GunaGradientButton();
            this.btnThemMoi = new Guna.UI.WinForms.GunaGradientButton();
            this.txtMaNcc = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNcc)).BeginInit();
            this.gboxNcc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dgvNcc);
            this.groupBox.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.groupBox.Location = new System.Drawing.Point(1, 38);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(423, 516);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Danh sách nhà cung cấp";
            // 
            // dgvNcc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNcc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNcc.BackgroundColor = System.Drawing.Color.White;
            this.dgvNcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNcc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNcc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNcc,
            this.tenNCC,
            this.diaChi,
            this.soDienThoai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNcc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNcc.EnableHeadersVisualStyles = false;
            this.dgvNcc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNcc.Location = new System.Drawing.Point(3, 28);
            this.dgvNcc.Name = "dgvNcc";
            this.dgvNcc.ReadOnly = true;
            this.dgvNcc.RowHeadersVisible = false;
            this.dgvNcc.RowHeadersWidth = 51;
            this.dgvNcc.RowTemplate.Height = 24;
            this.dgvNcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNcc.Size = new System.Drawing.Size(421, 485);
            this.dgvNcc.TabIndex = 2;
            this.dgvNcc.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvNcc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNcc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNcc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNcc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNcc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNcc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNcc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNcc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNcc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNcc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvNcc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNcc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNcc.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvNcc.ThemeStyle.ReadOnly = true;
            this.dgvNcc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNcc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNcc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.dgvNcc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNcc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNcc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNcc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNcc_CellClick);
            // 
            // maNcc
            // 
            this.maNcc.DataPropertyName = "maNcc";
            this.maNcc.HeaderText = "Mã NCC";
            this.maNcc.MinimumWidth = 6;
            this.maNcc.Name = "maNcc";
            this.maNcc.ReadOnly = true;
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "TenNcc";
            this.tenNCC.HeaderText = "Tên NCC";
            this.tenNCC.MinimumWidth = 6;
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diachi";
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "sodienthoai";
            this.soDienThoai.HeaderText = "Số điện thoại";
            this.soDienThoai.MinimumWidth = 6;
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            // 
            // gboxNcc
            // 
            this.gboxNcc.Controls.Add(this.txtSDT);
            this.gboxNcc.Controls.Add(this.txtDiaChi);
            this.gboxNcc.Controls.Add(this.txtTenNcc);
            this.gboxNcc.Controls.Add(this.gunaLabel3);
            this.gboxNcc.Controls.Add(this.gunaLabel2);
            this.gboxNcc.Controls.Add(this.gunaLabel1);
            this.gboxNcc.Font = new System.Drawing.Font("UVN Thanh Pho", 12F);
            this.gboxNcc.Location = new System.Drawing.Point(443, 39);
            this.gboxNcc.Name = "gboxNcc";
            this.gboxNcc.Size = new System.Drawing.Size(448, 176);
            this.gboxNcc.TabIndex = 6;
            this.gboxNcc.TabStop = false;
            this.gboxNcc.Text = "Thông tin nhà cung cấp";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSDT.Location = new System.Drawing.Point(174, 109);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.Size = new System.Drawing.Size(230, 30);
            this.txtSDT.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.LineColor = System.Drawing.Color.Gainsboro;
            this.txtDiaChi.Location = new System.Drawing.Point(174, 72);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.Size = new System.Drawing.Size(230, 30);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtTenNcc
            // 
            this.txtTenNcc.BackColor = System.Drawing.Color.White;
            this.txtTenNcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNcc.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenNcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNcc.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTenNcc.Location = new System.Drawing.Point(174, 31);
            this.txtTenNcc.Name = "txtTenNcc";
            this.txtTenNcc.PasswordChar = '\0';
            this.txtTenNcc.Size = new System.Drawing.Size(230, 30);
            this.txtTenNcc.TabIndex = 1;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(30, 102);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(126, 37);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Số điện thoại";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(30, 65);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(126, 37);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Địa chỉ";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(16, 28);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(140, 37);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Tên NCC";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label1.Location = new System.Drawing.Point(345, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhà Cung Cấp";
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
            this.panel1.TabIndex = 5;
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
            this.btnHuy.Location = new System.Drawing.Point(518, 313);
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
            this.btnSua.Location = new System.Drawing.Point(740, 242);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSua.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(131, 50);
            this.btnSua.TabIndex = 23;
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
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_delete_1001;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(681, 313);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXoa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(131, 50);
            this.btnXoa.TabIndex = 20;
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
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_save_64;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(596, 242);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLuu.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(131, 50);
            this.btnLuu.TabIndex = 21;
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
            this.btnThemMoi.Location = new System.Drawing.Point(447, 242);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnThemMoi.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnThemMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemMoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemMoi.OnHoverImage = null;
            this.btnThemMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemMoi.Size = new System.Drawing.Size(131, 50);
            this.btnThemMoi.TabIndex = 22;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtMaNcc
            // 
            this.txtMaNcc.BackColor = System.Drawing.Color.White;
            this.txtMaNcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNcc.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaNcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNcc.LineColor = System.Drawing.Color.Gainsboro;
            this.txtMaNcc.Location = new System.Drawing.Point(466, 511);
            this.txtMaNcc.Name = "txtMaNcc";
            this.txtMaNcc.PasswordChar = '\0';
            this.txtMaNcc.Size = new System.Drawing.Size(230, 30);
            this.txtMaNcc.TabIndex = 19;
            this.txtMaNcc.Visible = false;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(431, 38);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 518);
            this.gunaVSeparator1.TabIndex = 25;
            this.gunaVSeparator1.Thickness = 5;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::TTCM_QuanLySanBong.Properties.Resources.giphy__20_;
            this.gunaPictureBox1.Location = new System.Drawing.Point(453, 381);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(418, 160);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 26;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 555);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtMaNcc);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.gboxNcc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhaCungCap";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNcc)).EndInit();
            this.gboxNcc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private Guna.UI.WinForms.GunaDataGridView dgvNcc;
        private System.Windows.Forms.GroupBox gboxNcc;
        private Guna.UI.WinForms.GunaLineTextBox txtSDT;
        private Guna.UI.WinForms.GunaLineTextBox txtDiaChi;
        private Guna.UI.WinForms.GunaLineTextBox txtTenNcc;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private Guna.UI.WinForms.GunaGradientButton btnHuy;
        private Guna.UI.WinForms.GunaGradientButton btnSua;
        private Guna.UI.WinForms.GunaGradientButton btnXoa;
        private Guna.UI.WinForms.GunaGradientButton btnLuu;
        private Guna.UI.WinForms.GunaGradientButton btnThemMoi;
        private Guna.UI.WinForms.GunaLineTextBox txtMaNcc;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}