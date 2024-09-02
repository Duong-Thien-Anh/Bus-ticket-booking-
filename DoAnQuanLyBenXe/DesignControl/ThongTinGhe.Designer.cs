namespace DesignControl
{
    partial class ThongTinGhe
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
            this.pic_ghe = new System.Windows.Forms.PictureBox();
            this.lb_soGhe = new System.Windows.Forms.Label();
            this.lb_trangThai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ghe)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_ghe
            // 
            this.pic_ghe.Location = new System.Drawing.Point(106, 3);
            this.pic_ghe.Name = "pic_ghe";
            this.pic_ghe.Size = new System.Drawing.Size(59, 80);
            this.pic_ghe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ghe.TabIndex = 0;
            this.pic_ghe.TabStop = false;
            this.pic_ghe.Click += new System.EventHandler(this.pic_ghe_Click);
            // 
            // lb_soGhe
            // 
            this.lb_soGhe.AutoSize = true;
            this.lb_soGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soGhe.Location = new System.Drawing.Point(3, 0);
            this.lb_soGhe.Name = "lb_soGhe";
            this.lb_soGhe.Size = new System.Drawing.Size(81, 25);
            this.lb_soGhe.TabIndex = 1;
            this.lb_soGhe.Text = "Số ghế";
            // 
            // lb_trangThai
            // 
            this.lb_trangThai.AutoSize = true;
            this.lb_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangThai.Location = new System.Drawing.Point(31, 40);
            this.lb_trangThai.Name = "lb_trangThai";
            this.lb_trangThai.Size = new System.Drawing.Size(39, 25);
            this.lb_trangThai.TabIndex = 2;
            this.lb_trangThai.Text = "TH";
            // 
            // ThongTinGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_trangThai);
            this.Controls.Add(this.lb_soGhe);
            this.Controls.Add(this.pic_ghe);
            this.Name = "ThongTinGhe";
            this.Size = new System.Drawing.Size(168, 86);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ghe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ghe;
        private System.Windows.Forms.Label lb_soGhe;
        private System.Windows.Forms.Label lb_trangThai;
    }
}
