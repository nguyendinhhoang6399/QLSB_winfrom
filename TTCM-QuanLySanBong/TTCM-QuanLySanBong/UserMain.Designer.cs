namespace TTCM_QuanLySanBong
{
    partial class UserMain
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
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Image = global::TTCM_QuanLySanBong.Properties.Resources.stadium1;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(300, 300);
            this.gunaImageButton1.Location = new System.Drawing.Point(187, 54);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(859, 539);
            this.gunaImageButton1.TabIndex = 0;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaImageButton1);
            this.Name = "UserMain";
            this.Size = new System.Drawing.Size(1217, 659);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}
