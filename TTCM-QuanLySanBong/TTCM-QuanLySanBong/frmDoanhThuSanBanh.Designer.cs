namespace TTCM_QuanLySanBong
{
    partial class frmDoanhThuSanBanh
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pr_HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLySanBongDataSet1 = new TTCM_QuanLySanBong.QuanLySanBongDataSet1();
            this.LayNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLySanBongDataSet2 = new TTCM_QuanLySanBong.QuanLySanBongDataSet2();
            this.getTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLySanBongDataSet3 = new TTCM_QuanLySanBong.QuanLySanBongDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.pr_HoaDonTableAdapter = new TTCM_QuanLySanBong.QuanLySanBongDataSet1TableAdapters.pr_HoaDonTableAdapter();
            this.LayNgayTableAdapter = new TTCM_QuanLySanBong.QuanLySanBongDataSet2TableAdapters.LayNgayTableAdapter();
            this.getTienTableAdapter = new TTCM_QuanLySanBong.QuanLySanBongDataSet3TableAdapters.getTienTableAdapter();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.btnBieuDo = new Guna.UI.WinForms.GunaGradientButton();
            this.btnEmail = new Guna.UI.WinForms.GunaGradientButton();
            this.btnXuatExcel = new Guna.UI.WinForms.GunaGradientButton();
            this.btnBatDau = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pr_HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pr_HoaDonBindingSource
            // 
            this.pr_HoaDonBindingSource.DataMember = "pr_HoaDon";
            this.pr_HoaDonBindingSource.DataSource = this.QuanLySanBongDataSet1;
            // 
            // QuanLySanBongDataSet1
            // 
            this.QuanLySanBongDataSet1.DataSetName = "QuanLySanBongDataSet1";
            this.QuanLySanBongDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LayNgayBindingSource
            // 
            this.LayNgayBindingSource.DataMember = "LayNgay";
            this.LayNgayBindingSource.DataSource = this.QuanLySanBongDataSet2;
            // 
            // QuanLySanBongDataSet2
            // 
            this.QuanLySanBongDataSet2.DataSetName = "QuanLySanBongDataSet2";
            this.QuanLySanBongDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTienBindingSource
            // 
            this.getTienBindingSource.DataMember = "getTien";
            this.getTienBindingSource.DataSource = this.QuanLySanBongDataSet3;
            // 
            // QuanLySanBongDataSet3
            // 
            this.QuanLySanBongDataSet3.DataSetName = "QuanLySanBongDataSet3";
            this.QuanLySanBongDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pr_HoaDonBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.LayNgayBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.getTienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TTCM_QuanLySanBong.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 113);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1052, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(443, 84);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(196, 22);
            this.dtpDenNgay.TabIndex = 19;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(443, 50);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(196, 22);
            this.dtpTuNgay.TabIndex = 18;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(291, 76);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(132, 34);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "Đến Ngày";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(296, 42);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(127, 34);
            this.gunaLabel4.TabIndex = 17;
            this.gunaLabel4.Text = "Từ Ngày";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pr_HoaDonTableAdapter
            // 
            this.pr_HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // LayNgayTableAdapter
            // 
            this.LayNgayTableAdapter.ClearBeforeFill = true;
            // 
            // getTienTableAdapter
            // 
            this.getTienTableAdapter.ClearBeforeFill = true;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(3, 34);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(1056, 10);
            this.gunaSeparator1.TabIndex = 23;
            this.gunaSeparator1.Thickness = 5;
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
            this.panel1.Size = new System.Drawing.Size(1058, 39);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo cáo doanh thu sân bóng";
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
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_close_window_64;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Location = new System.Drawing.Point(1014, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Size = new System.Drawing.Size(45, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBieuDo
            // 
            this.btnBieuDo.AnimationHoverSpeed = 0.07F;
            this.btnBieuDo.AnimationSpeed = 0.03F;
            this.btnBieuDo.BaseColor1 = System.Drawing.Color.Snow;
            this.btnBieuDo.BaseColor2 = System.Drawing.Color.Lime;
            this.btnBieuDo.BorderColor = System.Drawing.Color.Black;
            this.btnBieuDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBieuDo.FocusedColor = System.Drawing.Color.Empty;
            this.btnBieuDo.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold);
            this.btnBieuDo.ForeColor = System.Drawing.Color.Black;
            this.btnBieuDo.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_combo_chart_100;
            this.btnBieuDo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBieuDo.Location = new System.Drawing.Point(570, 560);
            this.btnBieuDo.Name = "btnBieuDo";
            this.btnBieuDo.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBieuDo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBieuDo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBieuDo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBieuDo.OnHoverImage = null;
            this.btnBieuDo.OnPressedColor = System.Drawing.Color.Black;
            this.btnBieuDo.Size = new System.Drawing.Size(109, 43);
            this.btnBieuDo.TabIndex = 22;
            this.btnBieuDo.Text = "Biểu Đồ";
            this.btnBieuDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBieuDo.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.AnimationHoverSpeed = 0.07F;
            this.btnEmail.AnimationSpeed = 0.03F;
            this.btnEmail.BaseColor1 = System.Drawing.Color.Snow;
            this.btnEmail.BaseColor2 = System.Drawing.Color.Lime;
            this.btnEmail.BorderColor = System.Drawing.Color.Black;
            this.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmail.FocusedColor = System.Drawing.Color.Empty;
            this.btnEmail.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmail.ForeColor = System.Drawing.Color.Black;
            this.btnEmail.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_send_email_100;
            this.btnEmail.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEmail.Location = new System.Drawing.Point(451, 560);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnEmail.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnEmail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEmail.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEmail.OnHoverImage = null;
            this.btnEmail.OnPressedColor = System.Drawing.Color.Black;
            this.btnEmail.Size = new System.Drawing.Size(92, 43);
            this.btnEmail.TabIndex = 21;
            this.btnEmail.Text = "Email";
            this.btnEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEmail.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.AnimationHoverSpeed = 0.07F;
            this.btnXuatExcel.AnimationSpeed = 0.03F;
            this.btnXuatExcel.BaseColor1 = System.Drawing.Color.Snow;
            this.btnXuatExcel.BaseColor2 = System.Drawing.Color.Lime;
            this.btnXuatExcel.BorderColor = System.Drawing.Color.Black;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnXuatExcel.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.Black;
            this.btnXuatExcel.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_microsoft_excel_2019_100;
            this.btnXuatExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXuatExcel.Location = new System.Drawing.Point(336, 560);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXuatExcel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXuatExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXuatExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.OnHoverImage = null;
            this.btnXuatExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnXuatExcel.Size = new System.Drawing.Size(92, 43);
            this.btnXuatExcel.TabIndex = 20;
            this.btnXuatExcel.Text = "Xuất";
            this.btnXuatExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXuatExcel.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.AnimationHoverSpeed = 0.07F;
            this.btnBatDau.AnimationSpeed = 0.03F;
            this.btnBatDau.BaseColor1 = System.Drawing.Color.Snow;
            this.btnBatDau.BaseColor2 = System.Drawing.Color.Lime;
            this.btnBatDau.BorderColor = System.Drawing.Color.Black;
            this.btnBatDau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatDau.FocusedColor = System.Drawing.Color.Empty;
            this.btnBatDau.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold);
            this.btnBatDau.ForeColor = System.Drawing.Color.Black;
            this.btnBatDau.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_search_more_1002;
            this.btnBatDau.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBatDau.Location = new System.Drawing.Point(675, 50);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBatDau.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBatDau.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBatDau.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBatDau.OnHoverImage = null;
            this.btnBatDau.OnPressedColor = System.Drawing.Color.Black;
            this.btnBatDau.Size = new System.Drawing.Size(92, 43);
            this.btnBatDau.TabIndex = 15;
            this.btnBatDau.Text = "Xem";
            this.btnBatDau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // frmDoanhThuSanBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.btnBieuDo);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoanhThuSanBanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoanhThuSanBanh";
            this.Load += new System.EventHandler(this.frmDoanhThuSanBanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pr_HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI.WinForms.GunaGradientButton btnBatDau;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaGradientButton btnXuatExcel;
        private System.Windows.Forms.BindingSource pr_HoaDonBindingSource;
        private QuanLySanBongDataSet1 QuanLySanBongDataSet1;
        private System.Windows.Forms.BindingSource LayNgayBindingSource;
        private QuanLySanBongDataSet2 QuanLySanBongDataSet2;
        private System.Windows.Forms.BindingSource getTienBindingSource;
        private QuanLySanBongDataSet3 QuanLySanBongDataSet3;
        private QuanLySanBongDataSet1TableAdapters.pr_HoaDonTableAdapter pr_HoaDonTableAdapter;
        private QuanLySanBongDataSet2TableAdapters.LayNgayTableAdapter LayNgayTableAdapter;
        private QuanLySanBongDataSet3TableAdapters.getTienTableAdapter getTienTableAdapter;
        private Guna.UI.WinForms.GunaGradientButton btnEmail;
        private Guna.UI.WinForms.GunaGradientButton btnBieuDo;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton btnClose;
    }
}