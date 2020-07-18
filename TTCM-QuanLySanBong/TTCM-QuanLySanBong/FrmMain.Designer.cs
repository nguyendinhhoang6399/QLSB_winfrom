namespace TTCM_QuanLySanBong
{
    partial class FrmMain
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
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.lbTime = new System.Windows.Forms.Label();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnMain = new Guna.UI.WinForms.GunaImageButton();
            this.btnNhanSu = new Guna.UI.WinForms.GunaImageButton();
            this.btnThoat = new Guna.UI.WinForms.GunaImageButton();
            this.btnHangHoa = new Guna.UI.WinForms.GunaImageButton();
            this.btnBaoCao = new Guna.UI.WinForms.GunaImageButton();
            this.btnHoaDon = new Guna.UI.WinForms.GunaImageButton();
            this.btnDatSan = new Guna.UI.WinForms.GunaImageButton();
            this.btnTinhTien = new Guna.UI.WinForms.GunaImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.userNhanSu1 = new TTCM_QuanLySanBong.UserNhanSu();
            this.userBaoCao1 = new TTCM_QuanLySanBong.UserBaoCao();
            this.userHoaDon1 = new TTCM_QuanLySanBong.UserHoaDon();
            this.userHangHoa1 = new TTCM_QuanLySanBong.UserHangHoa();
            this.userDatSan1 = new TTCM_QuanLySanBong.UserDatSan();
            this.userMain1 = new TTCM_QuanLySanBong.UserMain();
            this.userTinhTien1 = new TTCM_QuanLySanBong.UserTinhTien();
            this.panel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userNhanSu1);
            this.panel1.Controls.Add(this.userBaoCao1);
            this.panel1.Controls.Add(this.userHoaDon1);
            this.panel1.Controls.Add(this.userHangHoa1);
            this.panel1.Controls.Add(this.userDatSan1);
            this.panel1.Controls.Add(this.userMain1);
            this.panel1.Controls.Add(this.userTinhTien1);
            this.gunaTransition1.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(109, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 659);
            this.panel1.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaLinePanel2;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaLinePanel2.Controls.Add(this.label1);
            this.gunaLinePanel2.Controls.Add(this.lbTime);
            this.gunaTransition1.SetDecoration(this.gunaLinePanel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(103, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1215, 64);
            this.gunaLinePanel2.TabIndex = 3;
            this.gunaLinePanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaLinePanel2_Paint);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.lbTime, Guna.UI.Animation.DecorationType.None);
            this.lbTime.Font = new System.Drawing.Font("UVN Banh Mi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(31, 9);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(146, 41);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "00:00:00";
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlideAndRotate;
            this.gunaTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 0.3F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation1;
            this.gunaTransition1.Interval = 6;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Yellow;
            this.gunaLinePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaLinePanel1.Controls.Add(this.btnMain);
            this.gunaLinePanel1.Controls.Add(this.btnNhanSu);
            this.gunaLinePanel1.Controls.Add(this.btnThoat);
            this.gunaLinePanel1.Controls.Add(this.btnHangHoa);
            this.gunaLinePanel1.Controls.Add(this.btnBaoCao);
            this.gunaLinePanel1.Controls.Add(this.btnHoaDon);
            this.gunaLinePanel1.Controls.Add(this.btnDatSan);
            this.gunaLinePanel1.Controls.Add(this.btnTinhTien);
            this.gunaTransition1.SetDecoration(this.gunaLinePanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(103, 733);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.spartan_icon_16974;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnMain, Guna.UI.Animation.DecorationType.None);
            this.btnMain.Image = null;
            this.btnMain.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMain.Location = new System.Drawing.Point(4, 12);
            this.btnMain.Name = "btnMain";
            this.btnMain.OnHoverImage = null;
            this.btnMain.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnMain.Size = new System.Drawing.Size(85, 76);
            this.btnMain.TabIndex = 3;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnNhanSu
            // 
            this.btnNhanSu.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanSu.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_employee_100;
            this.btnNhanSu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnNhanSu, Guna.UI.Animation.DecorationType.None);
            this.btnNhanSu.Image = null;
            this.btnNhanSu.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNhanSu.Location = new System.Drawing.Point(12, 570);
            this.btnNhanSu.Name = "btnNhanSu";
            this.btnNhanSu.OnHoverImage = null;
            this.btnNhanSu.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnNhanSu.Size = new System.Drawing.Size(77, 76);
            this.btnNhanSu.TabIndex = 3;
            this.btnNhanSu.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_exit_642;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnThoat, Guna.UI.Animation.DecorationType.None);
            this.btnThoat.Image = null;
            this.btnThoat.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThoat.Location = new System.Drawing.Point(12, 653);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnThoat.Size = new System.Drawing.Size(77, 68);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.BackColor = System.Drawing.Color.Transparent;
            this.btnHangHoa.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_commodity_100;
            this.btnHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnHangHoa, Guna.UI.Animation.DecorationType.None);
            this.btnHangHoa.Image = null;
            this.btnHangHoa.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHangHoa.Location = new System.Drawing.Point(12, 479);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.OnHoverImage = null;
            this.btnHangHoa.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnHangHoa.Size = new System.Drawing.Size(77, 76);
            this.btnHangHoa.TabIndex = 2;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCao.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_combo_chart_1001;
            this.btnBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnBaoCao, Guna.UI.Animation.DecorationType.None);
            this.btnBaoCao.Image = null;
            this.btnBaoCao.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBaoCao.Location = new System.Drawing.Point(12, 370);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.OnHoverImage = null;
            this.btnBaoCao.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(77, 84);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_paid_bill_100;
            this.btnHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnHoaDon, Guna.UI.Animation.DecorationType.None);
            this.btnHoaDon.Image = null;
            this.btnHoaDon.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHoaDon.Location = new System.Drawing.Point(12, 280);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.OnHoverImage = null;
            this.btnHoaDon.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(77, 84);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnDatSan
            // 
            this.btnDatSan.BackColor = System.Drawing.Color.Transparent;
            this.btnDatSan.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_calendar_1002;
            this.btnDatSan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnDatSan, Guna.UI.Animation.DecorationType.None);
            this.btnDatSan.Image = null;
            this.btnDatSan.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDatSan.Location = new System.Drawing.Point(12, 207);
            this.btnDatSan.Name = "btnDatSan";
            this.btnDatSan.OnHoverImage = null;
            this.btnDatSan.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnDatSan.Size = new System.Drawing.Size(77, 67);
            this.btnDatSan.TabIndex = 2;
            this.btnDatSan.Click += new System.EventHandler(this.btnSan_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.Color.Transparent;
            this.btnTinhTien.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_cash_register_64__1_;
            this.btnTinhTien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTinhTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTransition1.SetDecoration(this.btnTinhTien, Guna.UI.Animation.DecorationType.None);
            this.btnTinhTien.Image = null;
            this.btnTinhTien.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTinhTien.Location = new System.Drawing.Point(12, 108);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.OnHoverImage = null;
            this.btnTinhTien.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnTinhTien.Size = new System.Drawing.Size(77, 74);
            this.btnTinhTien.TabIndex = 2;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.gunaTransition1.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("UVN Thanh Pho", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(589, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "SÂN BÓNG THE SPARTAN KÍNH CHÀO QUÝ KHÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNhanSu1
            // 
            this.userNhanSu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.userNhanSu1, Guna.UI.Animation.DecorationType.None);
            this.userNhanSu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNhanSu1.Location = new System.Drawing.Point(0, 0);
            this.userNhanSu1.Name = "userNhanSu1";
            this.userNhanSu1.Size = new System.Drawing.Size(1217, 659);
            this.userNhanSu1.TabIndex = 6;
            this.userNhanSu1.Load += new System.EventHandler(this.userNhanSu1_Load);
            // 
            // userBaoCao1
            // 
            this.gunaTransition1.SetDecoration(this.userBaoCao1, Guna.UI.Animation.DecorationType.None);
            this.userBaoCao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBaoCao1.Location = new System.Drawing.Point(0, 0);
            this.userBaoCao1.Name = "userBaoCao1";
            this.userBaoCao1.Size = new System.Drawing.Size(1217, 659);
            this.userBaoCao1.TabIndex = 5;
            // 
            // userHoaDon1
            // 
            this.gunaTransition1.SetDecoration(this.userHoaDon1, Guna.UI.Animation.DecorationType.None);
            this.userHoaDon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userHoaDon1.Location = new System.Drawing.Point(0, 0);
            this.userHoaDon1.Name = "userHoaDon1";
            this.userHoaDon1.Size = new System.Drawing.Size(1217, 659);
            this.userHoaDon1.TabIndex = 4;
            // 
            // userHangHoa1
            // 
            this.gunaTransition1.SetDecoration(this.userHangHoa1, Guna.UI.Animation.DecorationType.None);
            this.userHangHoa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userHangHoa1.Location = new System.Drawing.Point(0, 0);
            this.userHangHoa1.Name = "userHangHoa1";
            this.userHangHoa1.Size = new System.Drawing.Size(1217, 659);
            this.userHangHoa1.TabIndex = 3;
            // 
            // userDatSan1
            // 
            this.gunaTransition1.SetDecoration(this.userDatSan1, Guna.UI.Animation.DecorationType.None);
            this.userDatSan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDatSan1.Location = new System.Drawing.Point(0, 0);
            this.userDatSan1.Name = "userDatSan1";
            this.userDatSan1.Size = new System.Drawing.Size(1217, 659);
            this.userDatSan1.TabIndex = 2;
            // 
            // userMain1
            // 
            this.userMain1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userMain1.BackgroundImage")));
            this.userMain1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.userMain1, Guna.UI.Animation.DecorationType.None);
            this.userMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userMain1.Location = new System.Drawing.Point(0, 0);
            this.userMain1.Name = "userMain1";
            this.userMain1.Size = new System.Drawing.Size(1217, 659);
            this.userMain1.TabIndex = 1;
            // 
            // userTinhTien1
            // 
            this.gunaTransition1.SetDecoration(this.userTinhTien1, Guna.UI.Animation.DecorationType.None);
            this.userTinhTien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTinhTien1.Location = new System.Drawing.Point(0, 0);
            this.userTinhTien1.Name = "userTinhTien1";
            this.userTinhTien1.Size = new System.Drawing.Size(1217, 659);
            this.userTinhTien1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1318, 733);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.panel1);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.gunaLinePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserTinhTien userTinhTien1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaImageButton btnThoat;
        private Guna.UI.WinForms.GunaImageButton btnHangHoa;
        private Guna.UI.WinForms.GunaImageButton btnBaoCao;
        private Guna.UI.WinForms.GunaImageButton btnHoaDon;
        private Guna.UI.WinForms.GunaImageButton btnDatSan;
        private Guna.UI.WinForms.GunaImageButton btnTinhTien;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private UserMain userMain1;
        private UserDatSan userDatSan1;
        private UserHangHoa userHangHoa1;
        private UserHoaDon userHoaDon1;
        private UserBaoCao userBaoCao1;
        private UserNhanSu userNhanSu1;
        private Guna.UI.WinForms.GunaImageButton btnNhanSu;
        private Guna.UI.WinForms.GunaImageButton btnMain;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
    }
}