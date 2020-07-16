namespace TTCM_QuanLySanBong
{
    partial class frmBaoCaoVonNH
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
            this.LayNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLySanBongDataSet2 = new TTCM_QuanLySanBong.QuanLySanBongDataSet2();
            this.getPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLySanBongDataSet4 = new TTCM_QuanLySanBong.QuanLySanBongDataSet4();
            this.getTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLySanBongDataSet5 = new TTCM_QuanLySanBong.QuanLySanBongDataSet5();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaImageButton();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBieuDo = new Guna.UI.WinForms.GunaGradientButton();
            this.btnEmail = new Guna.UI.WinForms.GunaGradientButton();
            this.btnXuatExcel = new Guna.UI.WinForms.GunaGradientButton();
            this.btnXem = new Guna.UI.WinForms.GunaGradientButton();
            this.LayNgayTableAdapter = new TTCM_QuanLySanBong.QuanLySanBongDataSet2TableAdapters.LayNgayTableAdapter();
            this.getPhieuNhapTableAdapter = new TTCM_QuanLySanBong.QuanLySanBongDataSet4TableAdapters.getPhieuNhapTableAdapter();
            this.getTienTableAdapter = new TTCM_QuanLySanBong.QuanLySanBongDataSet5TableAdapters.getTienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LayNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // getPhieuNhapBindingSource
            // 
            this.getPhieuNhapBindingSource.DataMember = "getPhieuNhap";
            this.getPhieuNhapBindingSource.DataSource = this.QuanLySanBongDataSet4;
            // 
            // QuanLySanBongDataSet4
            // 
            this.QuanLySanBongDataSet4.DataSetName = "QuanLySanBongDataSet4";
            this.QuanLySanBongDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTienBindingSource
            // 
            this.getTienBindingSource.DataMember = "getTien";
            this.getTienBindingSource.DataSource = this.QuanLySanBongDataSet5;
            // 
            // QuanLySanBongDataSet5
            // 
            this.QuanLySanBongDataSet5.DataSetName = "QuanLySanBongDataSet5";
            this.QuanLySanBongDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.Size = new System.Drawing.Size(1056, 39);
            this.panel1.TabIndex = 25;
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
            this.label1.Location = new System.Drawing.Point(386, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo cáo vốn nhập hàng";
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
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(447, 84);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(196, 22);
            this.dtpDenNgay.TabIndex = 24;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(447, 50);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(196, 22);
            this.dtpTuNgay.TabIndex = 23;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(295, 76);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(132, 34);
            this.gunaLabel5.TabIndex = 21;
            this.gunaLabel5.Text = "Đến Ngày";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(300, 42);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(127, 34);
            this.gunaLabel4.TabIndex = 22;
            this.gunaLabel4.Text = "Từ Ngày";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LayNgayBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.getPhieuNhapBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.getTienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TTCM_QuanLySanBong.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1044, 451);
            this.reportViewer1.TabIndex = 26;
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
            this.btnBieuDo.Location = new System.Drawing.Point(588, 570);
            this.btnBieuDo.Name = "btnBieuDo";
            this.btnBieuDo.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBieuDo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBieuDo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBieuDo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBieuDo.OnHoverImage = null;
            this.btnBieuDo.OnPressedColor = System.Drawing.Color.Black;
            this.btnBieuDo.Size = new System.Drawing.Size(109, 43);
            this.btnBieuDo.TabIndex = 29;
            this.btnBieuDo.Text = "Biểu Đồ";
            this.btnBieuDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBieuDo.Click += new System.EventHandler(this.btnBieuDo_Click);
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
            this.btnEmail.Location = new System.Drawing.Point(469, 570);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnEmail.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnEmail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEmail.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEmail.OnHoverImage = null;
            this.btnEmail.OnPressedColor = System.Drawing.Color.Black;
            this.btnEmail.Size = new System.Drawing.Size(92, 43);
            this.btnEmail.TabIndex = 28;
            this.btnEmail.Text = "Email";
            this.btnEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
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
            this.btnXuatExcel.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_microsoft_excel_2019_1001;
            this.btnXuatExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXuatExcel.Location = new System.Drawing.Point(354, 570);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXuatExcel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXuatExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXuatExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.OnHoverImage = null;
            this.btnXuatExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnXuatExcel.Size = new System.Drawing.Size(92, 43);
            this.btnXuatExcel.TabIndex = 27;
            this.btnXuatExcel.Text = "Xuất";
            this.btnXuatExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnXem
            // 
            this.btnXem.AnimationHoverSpeed = 0.07F;
            this.btnXem.AnimationSpeed = 0.03F;
            this.btnXem.BaseColor1 = System.Drawing.Color.Snow;
            this.btnXem.BaseColor2 = System.Drawing.Color.Lime;
            this.btnXem.BorderColor = System.Drawing.Color.Black;
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.FocusedColor = System.Drawing.Color.Empty;
            this.btnXem.Font = new System.Drawing.Font("UVN Thanh Pho", 12F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.Image = global::TTCM_QuanLySanBong.Properties.Resources.icons8_search_more_1002;
            this.btnXem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXem.Location = new System.Drawing.Point(679, 50);
            this.btnXem.Name = "btnXem";
            this.btnXem.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXem.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXem.OnHoverImage = null;
            this.btnXem.OnPressedColor = System.Drawing.Color.Black;
            this.btnXem.Size = new System.Drawing.Size(92, 43);
            this.btnXem.TabIndex = 20;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // LayNgayTableAdapter
            // 
            this.LayNgayTableAdapter.ClearBeforeFill = true;
            // 
            // getPhieuNhapTableAdapter
            // 
            this.getPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // getTienTableAdapter
            // 
            this.getTienTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoVonNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.btnBieuDo);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.btnXem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCaoVonNH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoCaoVonNH";
            this.Load += new System.EventHandler(this.frmBaoCaoVonNH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LayNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLySanBongDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton btnClose;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaGradientButton btnXem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI.WinForms.GunaGradientButton btnBieuDo;
        private Guna.UI.WinForms.GunaGradientButton btnEmail;
        private Guna.UI.WinForms.GunaGradientButton btnXuatExcel;
        private System.Windows.Forms.BindingSource LayNgayBindingSource;
        private QuanLySanBongDataSet2 QuanLySanBongDataSet2;
        private System.Windows.Forms.BindingSource getPhieuNhapBindingSource;
        private QuanLySanBongDataSet4 QuanLySanBongDataSet4;
        private System.Windows.Forms.BindingSource getTienBindingSource;
        private QuanLySanBongDataSet5 QuanLySanBongDataSet5;
        private QuanLySanBongDataSet2TableAdapters.LayNgayTableAdapter LayNgayTableAdapter;
        private QuanLySanBongDataSet4TableAdapters.getPhieuNhapTableAdapter getPhieuNhapTableAdapter;
        private QuanLySanBongDataSet5TableAdapters.getTienTableAdapter getTienTableAdapter;
    }
}