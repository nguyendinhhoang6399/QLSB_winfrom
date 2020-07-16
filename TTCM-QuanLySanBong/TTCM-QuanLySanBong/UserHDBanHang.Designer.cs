namespace TTCM_QuanLySanBong
{
    partial class UserHDBanHang
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
            this.dgvCTHoaDon = new Guna.UI.WinForms.GunaDataGridView();
            this.maHd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTHoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCTHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHoaDon.ColumnHeadersHeight = 52;
            this.dgvCTHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHd,
            this.tenHang,
            this.soLuong,
            this.donGia,
            this.thanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTHoaDon.EnableHeadersVisualStyles = false;
            this.dgvCTHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvCTHoaDon.Name = "dgvCTHoaDon";
            this.dgvCTHoaDon.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTHoaDon.RowHeadersVisible = false;
            this.dgvCTHoaDon.RowHeadersWidth = 51;
            this.dgvCTHoaDon.RowTemplate.Height = 24;
            this.dgvCTHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHoaDon.Size = new System.Drawing.Size(784, 547);
            this.dgvCTHoaDon.TabIndex = 0;
            this.dgvCTHoaDon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvCTHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCTHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTHoaDon.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvCTHoaDon.ThemeStyle.ReadOnly = true;
            this.dgvCTHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCTHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maHd
            // 
            this.maHd.DataPropertyName = "mahd";
            this.maHd.HeaderText = "Mã Hóa Đơn";
            this.maHd.MinimumWidth = 6;
            this.maHd.Name = "maHd";
            this.maHd.ReadOnly = true;
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "tenhh";
            this.tenHang.HeaderText = "Tên Hàng";
            this.tenHang.MinimumWidth = 6;
            this.tenHang.Name = "tenHang";
            this.tenHang.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soluongban";
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "dongia";
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "thanhtien";
            this.thanhTien.HeaderText = "Thành Tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            // 
            // btnIn
            // 
            this.btnIn.AnimationHoverSpeed = 0.07F;
            this.btnIn.AnimationSpeed = 0.03F;
            this.btnIn.BaseColor1 = System.Drawing.Color.Snow;
            this.btnIn.BaseColor2 = System.Drawing.Color.Lime;
            this.btnIn.BorderColor = System.Drawing.Color.Black;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnIn.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_print_100;
            this.btnIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIn.Location = new System.Drawing.Point(408, 553);
            this.btnIn.Name = "btnIn";
            this.btnIn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnIn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIn.OnHoverImage = null;
            this.btnIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnIn.Size = new System.Drawing.Size(131, 50);
            this.btnIn.TabIndex = 23;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            this.gunaGradientButton1.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_available_updates_1001;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(215, 553);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(144, 50);
            this.gunaGradientButton1.TabIndex = 48;
            this.gunaGradientButton1.Text = "Làm Mới";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // UserHDBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dgvCTHoaDon);
            this.Name = "UserHDBanHang";
            this.Size = new System.Drawing.Size(784, 606);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvCTHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private Guna.UI.WinForms.GunaGradientButton btnIn;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}
