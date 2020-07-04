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
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userDatSan1 = new TTCM_QuanLySanBong.UserDatSan();
            this.userMain1 = new TTCM_QuanLySanBong.UserMain();
            this.userTinhTien1 = new TTCM_QuanLySanBong.UserTinhTien();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnThoat = new Guna.UI.WinForms.GunaImageButton();
            this.btnHangHoa = new Guna.UI.WinForms.GunaImageButton();
            this.btnBaoCao = new Guna.UI.WinForms.GunaImageButton();
            this.btnHoaDon = new Guna.UI.WinForms.GunaImageButton();
            this.btnSan = new Guna.UI.WinForms.GunaImageButton();
            this.btnTinhTien = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.userHangHoa1 = new TTCM_QuanLySanBong.UserHangHoa();
            this.panel1.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.gunaLinePanel1.Controls.Add(this.btnThoat);
            this.gunaLinePanel1.Controls.Add(this.btnHangHoa);
            this.gunaLinePanel1.Controls.Add(this.btnBaoCao);
            this.gunaLinePanel1.Controls.Add(this.btnHoaDon);
            this.gunaLinePanel1.Controls.Add(this.btnSan);
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
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_shutdown_64;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.btnThoat, Guna.UI.Animation.DecorationType.None);
            this.btnThoat.Image = null;
            this.btnThoat.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThoat.Location = new System.Drawing.Point(12, 598);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnThoat.Size = new System.Drawing.Size(77, 68);
            this.btnThoat.TabIndex = 2;
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_trolley_64;
            this.btnHangHoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.btnHangHoa, Guna.UI.Animation.DecorationType.None);
            this.btnHangHoa.Image = null;
            this.btnHangHoa.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHangHoa.Location = new System.Drawing.Point(12, 494);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.OnHoverImage = null;
            this.btnHangHoa.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnHangHoa.Size = new System.Drawing.Size(77, 76);
            this.btnHangHoa.TabIndex = 2;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_increase_64;
            this.btnBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.btnBaoCao, Guna.UI.Animation.DecorationType.None);
            this.btnBaoCao.Image = null;
            this.btnBaoCao.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBaoCao.Location = new System.Drawing.Point(12, 385);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.OnHoverImage = null;
            this.btnBaoCao.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(77, 84);
            this.btnBaoCao.TabIndex = 2;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_bill_64;
            this.btnHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.btnHoaDon, Guna.UI.Animation.DecorationType.None);
            this.btnHoaDon.Image = null;
            this.btnHoaDon.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHoaDon.Location = new System.Drawing.Point(12, 295);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.OnHoverImage = null;
            this.btnHoaDon.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(77, 84);
            this.btnHoaDon.TabIndex = 2;
            // 
            // btnSan
            // 
            this.btnSan.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_performance_64;
            this.btnSan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.btnSan, Guna.UI.Animation.DecorationType.None);
            this.btnSan.Image = null;
            this.btnSan.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSan.Location = new System.Drawing.Point(12, 205);
            this.btnSan.Name = "btnSan";
            this.btnSan.OnHoverImage = null;
            this.btnSan.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnSan.Size = new System.Drawing.Size(77, 67);
            this.btnSan.TabIndex = 2;
            this.btnSan.Click += new System.EventHandler(this.btnSan_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources.icons8_cash_register_64;
            this.btnTinhTien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaTransition1.SetDecoration(this.btnTinhTien, Guna.UI.Animation.DecorationType.None);
            this.btnTinhTien.Image = null;
            this.btnTinhTien.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTinhTien.Location = new System.Drawing.Point(12, 104);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.OnHoverImage = null;
            this.btnTinhTien.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnTinhTien.Size = new System.Drawing.Size(77, 74);
            this.btnTinhTien.TabIndex = 2;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaTransition1.SetDecoration(this.gunaLinePanel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLinePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(103, 0);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(1215, 64);
            this.gunaLinePanel2.TabIndex = 3;
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
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlideAndRotate;
            this.gunaTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 0.3F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation2;
            this.gunaTransition1.Interval = 6;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 733);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.panel1);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
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
        private Guna.UI.WinForms.GunaImageButton btnSan;
        private Guna.UI.WinForms.GunaImageButton btnTinhTien;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private UserMain userMain1;
        private UserDatSan userDatSan1;
        private UserHangHoa userHangHoa1;
    }
}