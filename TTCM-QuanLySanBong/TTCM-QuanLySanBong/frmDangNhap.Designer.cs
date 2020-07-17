namespace TTCM_QuanLySanBong
{
    partial class frmDangNhap
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.ckboxLuuMK = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.llaQMK = new Guna.UI.WinForms.GunaLinkLabel();
            this.llaDangKy = new Guna.UI.WinForms.GunaLinkLabel();
            this.picDangNhap = new Guna.UI.WinForms.GunaPictureBox();
            this.llaThoat = new Guna.UI.WinForms.GunaLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // ckboxLuuMK
            // 
            this.ckboxLuuMK.BackColor = System.Drawing.Color.Transparent;
            this.ckboxLuuMK.BaseColor = System.Drawing.Color.White;
            this.ckboxLuuMK.CheckedOffColor = System.Drawing.Color.Gray;
            this.ckboxLuuMK.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ckboxLuuMK.FillColor = System.Drawing.Color.White;
            this.ckboxLuuMK.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxLuuMK.ForeColor = System.Drawing.Color.White;
            this.ckboxLuuMK.Location = new System.Drawing.Point(121, 500);
            this.ckboxLuuMK.Name = "ckboxLuuMK";
            this.ckboxLuuMK.Size = new System.Drawing.Size(156, 33);
            this.ckboxLuuMK.TabIndex = 3;
            this.ckboxLuuMK.Text = "Nhớ mật khẩu";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::TTCM_QuanLySanBong.Properties.Resources.ZBO91;
            this.gunaPictureBox1.Location = new System.Drawing.Point(-151, 50);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(703, 354);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UVN Bai Hoc", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaiKhoan.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTaiKhoan.Location = new System.Drawing.Point(100, 410);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.Size = new System.Drawing.Size(198, 32);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPass.Location = new System.Drawing.Point(100, 462);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(198, 32);
            this.txtPass.TabIndex = 2;
            // 
            // llaQMK
            // 
            this.llaQMK.AutoSize = true;
            this.llaQMK.BackColor = System.Drawing.Color.Transparent;
            this.llaQMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llaQMK.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llaQMK.LinkColor = System.Drawing.Color.White;
            this.llaQMK.Location = new System.Drawing.Point(132, 637);
            this.llaQMK.Name = "llaQMK";
            this.llaQMK.Size = new System.Drawing.Size(153, 30);
            this.llaQMK.TabIndex = 6;
            this.llaQMK.TabStop = true;
            this.llaQMK.Text = "Quên mật khẩu?";
            this.llaQMK.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.llaQMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llaQMK_LinkClicked);
            // 
            // llaDangKy
            // 
            this.llaDangKy.AutoSize = true;
            this.llaDangKy.BackColor = System.Drawing.Color.Transparent;
            this.llaDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llaDangKy.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llaDangKy.LinkColor = System.Drawing.Color.White;
            this.llaDangKy.Location = new System.Drawing.Point(12, 637);
            this.llaDangKy.Name = "llaDangKy";
            this.llaDangKy.Size = new System.Drawing.Size(84, 30);
            this.llaDangKy.TabIndex = 6;
            this.llaDangKy.TabStop = true;
            this.llaDangKy.Text = "Đăng ký";
            this.llaDangKy.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.llaDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llaDangKy_LinkClicked);
            // 
            // picDangNhap
            // 
            this.picDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.picDangNhap.BaseColor = System.Drawing.Color.White;
            this.picDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDangNhap.Image = global::TTCM_QuanLySanBong.Properties.Resources.giphy__23_;
            this.picDangNhap.Location = new System.Drawing.Point(137, 539);
            this.picDangNhap.Name = "picDangNhap";
            this.picDangNhap.Size = new System.Drawing.Size(112, 95);
            this.picDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDangNhap.TabIndex = 7;
            this.picDangNhap.TabStop = false;
            this.picDangNhap.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // llaThoat
            // 
            this.llaThoat.AutoSize = true;
            this.llaThoat.BackColor = System.Drawing.Color.Transparent;
            this.llaThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llaThoat.Font = new System.Drawing.Font("UVN Thanh Pho", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llaThoat.LinkColor = System.Drawing.Color.White;
            this.llaThoat.Location = new System.Drawing.Point(323, 637);
            this.llaThoat.Name = "llaThoat";
            this.llaThoat.Size = new System.Drawing.Size(61, 30);
            this.llaThoat.TabIndex = 6;
            this.llaThoat.TabStop = true;
            this.llaThoat.Text = "Thoát";
            this.llaThoat.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.llaThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llaThoat_LinkClicked);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TTCM_QuanLySanBong.Properties.Resources._47ccc0738a4247a03863922199d5e257;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 676);
            this.Controls.Add(this.picDangNhap);
            this.Controls.Add(this.llaThoat);
            this.Controls.Add(this.llaDangKy);
            this.Controls.Add(this.llaQMK);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckboxLuuMK);
            this.Controls.Add(this.gunaPictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaCheckBox ckboxLuuMK;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txtPass;
        private Guna.UI.WinForms.GunaLineTextBox txtTaiKhoan;
        private Guna.UI.WinForms.GunaLinkLabel llaQMK;
        private Guna.UI.WinForms.GunaLinkLabel llaDangKy;
        private Guna.UI.WinForms.GunaPictureBox picDangNhap;
        private Guna.UI.WinForms.GunaLinkLabel llaThoat;
    }
}