namespace DesignControl
{
    partial class ThongTinTram
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
            this.lb_tenTram = new System.Windows.Forms.Label();
            this.lb_thanhPho = new System.Windows.Forms.Label();
            this.lb_maTram = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_tenTram
            // 
            this.lb_tenTram.AutoSize = true;
            this.lb_tenTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenTram.Location = new System.Drawing.Point(50, 43);
            this.lb_tenTram.Name = "lb_tenTram";
            this.lb_tenTram.Size = new System.Drawing.Size(90, 25);
            this.lb_tenTram.TabIndex = 0;
            this.lb_tenTram.Text = "Tên trạm";
            // 
            // lb_thanhPho
            // 
            this.lb_thanhPho.AutoSize = true;
            this.lb_thanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhPho.Location = new System.Drawing.Point(111, -1);
            this.lb_thanhPho.Name = "lb_thanhPho";
            this.lb_thanhPho.Size = new System.Drawing.Size(87, 20);
            this.lb_thanhPho.TabIndex = 1;
            this.lb_thanhPho.Text = "Thành phố";
            // 
            // lb_maTram
            // 
            this.lb_maTram.AutoSize = true;
            this.lb_maTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maTram.Location = new System.Drawing.Point(13, 1);
            this.lb_maTram.Name = "lb_maTram";
            this.lb_maTram.Size = new System.Drawing.Size(31, 18);
            this.lb_maTram.TabIndex = 2;
            this.lb_maTram.Text = "Mã";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(251, 14);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 54);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.lb_tenTram);
            this.panel1.Controls.Add(this.lb_maTram);
            this.panel1.Controls.Add(this.lb_thanhPho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 74);
            this.panel1.TabIndex = 4;
            // 
            // ThongTinTram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinTram";
            this.Size = new System.Drawing.Size(346, 74);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_tenTram;
        private System.Windows.Forms.Label lb_thanhPho;
        private System.Windows.Forms.Label lb_maTram;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Panel panel1;
    }
}
