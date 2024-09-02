namespace DesignControl
{
    partial class ThongTinhDV
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
            this.lb_tenDV = new System.Windows.Forms.Label();
            this.lb_maDV = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_tenDV
            // 
            this.lb_tenDV.AutoSize = true;
            this.lb_tenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenDV.Location = new System.Drawing.Point(48, 47);
            this.lb_tenDV.Name = "lb_tenDV";
            this.lb_tenDV.Size = new System.Drawing.Size(39, 25);
            this.lb_tenDV.TabIndex = 4;
            this.lb_tenDV.Text = "TH";
            this.lb_tenDV.Click += new System.EventHandler(this.lb_tenDV_Click);
            // 
            // lb_maDV
            // 
            this.lb_maDV.AutoSize = true;
            this.lb_maDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maDV.Location = new System.Drawing.Point(3, 10);
            this.lb_maDV.Name = "lb_maDV";
            this.lb_maDV.Size = new System.Drawing.Size(84, 25);
            this.lb_maDV.TabIndex = 3;
            this.lb_maDV.Text = "Mã ghế";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(219, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(69, 45);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // ThongTinhDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.lb_tenDV);
            this.Controls.Add(this.lb_maDV);
            this.Name = "ThongTinhDV";
            this.Size = new System.Drawing.Size(304, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tenDV;
        private System.Windows.Forms.Label lb_maDV;
        private System.Windows.Forms.Button btn_xoa;
    }
}
