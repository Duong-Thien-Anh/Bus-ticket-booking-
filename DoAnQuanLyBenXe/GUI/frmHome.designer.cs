namespace GUI
{
    partial class frmHome
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
            this.time_btnThongTin = new System.Windows.Forms.Timer(this.components);
            this.time_btnTaiKhoan = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_quyenNV = new System.Windows.Forms.Label();
            this.lb_tenNV = new System.Windows.Forms.Label();
            this.btn_chuyen = new System.Windows.Forms.Button();
            this.btn_xe = new System.Windows.Forms.Button();
            this.btn_ve = new System.Windows.Forms.Button();
            this.pn_QLThongTin = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_QLThongTinh = new System.Windows.Forms.Button();
            this.btn_tinhThanh = new System.Windows.Forms.Button();
            this.btn_QLHangXe = new System.Windows.Forms.Button();
            this.btn_QLLoaiXe = new System.Windows.Forms.Button();
            this.btn_QLDichVu = new System.Windows.Forms.Button();
            this.pn_QLTaiKhoan = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_QLTaiKhoan = new System.Windows.Forms.Button();
            this.btn_QLKhachHang = new System.Windows.Forms.Button();
            this.btn_QLNhanVien = new System.Windows.Forms.Button();
            this.btn_danhThu = new System.Windows.Forms.Button();
            this.btn_dangXuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_frmCon = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pic_thoat = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_QLThongTin.SuspendLayout();
            this.pn_QLTaiKhoan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_thoat)).BeginInit();
            this.SuspendLayout();
            // 
            // time_btnThongTin
            // 
            this.time_btnThongTin.Interval = 10;
            this.time_btnThongTin.Tick += new System.EventHandler(this.time_btnThongTin_Tick);
            // 
            // time_btnTaiKhoan
            // 
            this.time_btnTaiKhoan.Interval = 10;
            this.time_btnTaiKhoan.Tick += new System.EventHandler(this.time_btnTaiKhoan_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.btn_chuyen);
            this.flowLayoutPanel1.Controls.Add(this.btn_xe);
            this.flowLayoutPanel1.Controls.Add(this.btn_ve);
            this.flowLayoutPanel1.Controls.Add(this.pn_QLThongTin);
            this.flowLayoutPanel1.Controls.Add(this.pn_QLTaiKhoan);
            this.flowLayoutPanel1.Controls.Add(this.btn_danhThu);
            this.flowLayoutPanel1.Controls.Add(this.btn_dangXuat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 1055);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lb_quyenNV);
            this.panel3.Controls.Add(this.lb_tenNV);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 240);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_quyenNV
            // 
            this.lb_quyenNV.AutoSize = true;
            this.lb_quyenNV.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyenNV.Location = new System.Drawing.Point(156, 202);
            this.lb_quyenNV.Name = "lb_quyenNV";
            this.lb_quyenNV.Size = new System.Drawing.Size(73, 23);
            this.lb_quyenNV.TabIndex = 1;
            this.lb_quyenNV.Text = "Quyền";
            // 
            // lb_tenNV
            // 
            this.lb_tenNV.AutoSize = true;
            this.lb_tenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenNV.Location = new System.Drawing.Point(9, 165);
            this.lb_tenNV.Name = "lb_tenNV";
            this.lb_tenNV.Size = new System.Drawing.Size(50, 25);
            this.lb_tenNV.TabIndex = 0;
            this.lb_tenNV.Text = "Ten";
            // 
            // btn_chuyen
            // 
            this.btn_chuyen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_chuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_chuyen.Location = new System.Drawing.Point(3, 249);
            this.btn_chuyen.Name = "btn_chuyen";
            this.btn_chuyen.Size = new System.Drawing.Size(321, 59);
            this.btn_chuyen.TabIndex = 6;
            this.btn_chuyen.Text = "Quản lý chuyến";
            this.btn_chuyen.UseVisualStyleBackColor = false;
            this.btn_chuyen.Click += new System.EventHandler(this.btn_chuyen_Click);
            // 
            // btn_xe
            // 
            this.btn_xe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xe.Location = new System.Drawing.Point(3, 314);
            this.btn_xe.Name = "btn_xe";
            this.btn_xe.Size = new System.Drawing.Size(321, 59);
            this.btn_xe.TabIndex = 7;
            this.btn_xe.Text = "Quản lý xe";
            this.btn_xe.UseVisualStyleBackColor = false;
            this.btn_xe.Click += new System.EventHandler(this.btn_xe_Click);
            // 
            // btn_ve
            // 
            this.btn_ve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ve.Location = new System.Drawing.Point(3, 379);
            this.btn_ve.Name = "btn_ve";
            this.btn_ve.Size = new System.Drawing.Size(321, 59);
            this.btn_ve.TabIndex = 8;
            this.btn_ve.Text = "Quản lý vé";
            this.btn_ve.UseVisualStyleBackColor = false;
            this.btn_ve.Click += new System.EventHandler(this.btn_ve_Click);
            // 
            // pn_QLThongTin
            // 
            this.pn_QLThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_QLThongTin.Controls.Add(this.btn_QLThongTinh);
            this.pn_QLThongTin.Controls.Add(this.btn_tinhThanh);
            this.pn_QLThongTin.Controls.Add(this.btn_QLHangXe);
            this.pn_QLThongTin.Controls.Add(this.btn_QLLoaiXe);
            this.pn_QLThongTin.Controls.Add(this.btn_QLDichVu);
            this.pn_QLThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_QLThongTin.Location = new System.Drawing.Point(3, 444);
            this.pn_QLThongTin.Name = "pn_QLThongTin";
            this.pn_QLThongTin.Size = new System.Drawing.Size(324, 73);
            this.pn_QLThongTin.TabIndex = 2;
            // 
            // btn_QLThongTinh
            // 
            this.btn_QLThongTinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLThongTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLThongTinh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QLThongTinh.Location = new System.Drawing.Point(3, 3);
            this.btn_QLThongTinh.Name = "btn_QLThongTinh";
            this.btn_QLThongTinh.Size = new System.Drawing.Size(317, 70);
            this.btn_QLThongTinh.TabIndex = 1;
            this.btn_QLThongTinh.Text = "Quản lý thông tin";
            this.btn_QLThongTinh.UseVisualStyleBackColor = false;
            this.btn_QLThongTinh.Click += new System.EventHandler(this.btn_QLThongTinh_Click);
            // 
            // btn_tinhThanh
            // 
            this.btn_tinhThanh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tinhThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tinhThanh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_tinhThanh.Location = new System.Drawing.Point(3, 79);
            this.btn_tinhThanh.Name = "btn_tinhThanh";
            this.btn_tinhThanh.Size = new System.Drawing.Size(321, 45);
            this.btn_tinhThanh.TabIndex = 2;
            this.btn_tinhThanh.Text = "Tỉnh thành";
            this.btn_tinhThanh.UseVisualStyleBackColor = false;
            this.btn_tinhThanh.Click += new System.EventHandler(this.btn_tinhThanh_Click);
            // 
            // btn_QLHangXe
            // 
            this.btn_QLHangXe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLHangXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLHangXe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QLHangXe.Location = new System.Drawing.Point(3, 130);
            this.btn_QLHangXe.Name = "btn_QLHangXe";
            this.btn_QLHangXe.Size = new System.Drawing.Size(321, 45);
            this.btn_QLHangXe.TabIndex = 3;
            this.btn_QLHangXe.Text = "Hãng xe";
            this.btn_QLHangXe.UseVisualStyleBackColor = false;
            this.btn_QLHangXe.Click += new System.EventHandler(this.btn_QLHangXe_Click);
            // 
            // btn_QLLoaiXe
            // 
            this.btn_QLLoaiXe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLLoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLLoaiXe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QLLoaiXe.Location = new System.Drawing.Point(3, 181);
            this.btn_QLLoaiXe.Name = "btn_QLLoaiXe";
            this.btn_QLLoaiXe.Size = new System.Drawing.Size(321, 45);
            this.btn_QLLoaiXe.TabIndex = 4;
            this.btn_QLLoaiXe.Text = "Loại xe";
            this.btn_QLLoaiXe.UseVisualStyleBackColor = false;
            this.btn_QLLoaiXe.Click += new System.EventHandler(this.btn_QLLoaiXe_Click);
            // 
            // btn_QLDichVu
            // 
            this.btn_QLDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLDichVu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QLDichVu.Location = new System.Drawing.Point(3, 232);
            this.btn_QLDichVu.Name = "btn_QLDichVu";
            this.btn_QLDichVu.Size = new System.Drawing.Size(321, 45);
            this.btn_QLDichVu.TabIndex = 5;
            this.btn_QLDichVu.Text = "Dich vụ";
            this.btn_QLDichVu.UseVisualStyleBackColor = false;
            this.btn_QLDichVu.Click += new System.EventHandler(this.btn_QLDichVu_Click);
            // 
            // pn_QLTaiKhoan
            // 
            this.pn_QLTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_QLTaiKhoan.Controls.Add(this.btn_QLTaiKhoan);
            this.pn_QLTaiKhoan.Controls.Add(this.btn_QLKhachHang);
            this.pn_QLTaiKhoan.Controls.Add(this.btn_QLNhanVien);
            this.pn_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_QLTaiKhoan.Location = new System.Drawing.Point(3, 523);
            this.pn_QLTaiKhoan.Name = "pn_QLTaiKhoan";
            this.pn_QLTaiKhoan.Size = new System.Drawing.Size(324, 72);
            this.pn_QLTaiKhoan.TabIndex = 3;
            // 
            // btn_QLTaiKhoan
            // 
            this.btn_QLTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QLTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.btn_QLTaiKhoan.Name = "btn_QLTaiKhoan";
            this.btn_QLTaiKhoan.Size = new System.Drawing.Size(321, 64);
            this.btn_QLTaiKhoan.TabIndex = 1;
            this.btn_QLTaiKhoan.Text = "Quản lý tài khoản";
            this.btn_QLTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_QLTaiKhoan.Click += new System.EventHandler(this.btn_QLTaiKhoan_Click);
            // 
            // btn_QLKhachHang
            // 
            this.btn_QLKhachHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLKhachHang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QLKhachHang.Location = new System.Drawing.Point(3, 73);
            this.btn_QLKhachHang.Name = "btn_QLKhachHang";
            this.btn_QLKhachHang.Size = new System.Drawing.Size(321, 45);
            this.btn_QLKhachHang.TabIndex = 2;
            this.btn_QLKhachHang.Text = "Khách hàng";
            this.btn_QLKhachHang.UseVisualStyleBackColor = false;
            this.btn_QLKhachHang.Click += new System.EventHandler(this.btn_QLKhachHang_Click);
            // 
            // btn_QLNhanVien
            // 
            this.btn_QLNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_QLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLNhanVien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QLNhanVien.Location = new System.Drawing.Point(3, 124);
            this.btn_QLNhanVien.Name = "btn_QLNhanVien";
            this.btn_QLNhanVien.Size = new System.Drawing.Size(321, 45);
            this.btn_QLNhanVien.TabIndex = 3;
            this.btn_QLNhanVien.Text = "Nhân viên";
            this.btn_QLNhanVien.UseVisualStyleBackColor = false;
            this.btn_QLNhanVien.Click += new System.EventHandler(this.btn_QLNhanVien_Click);
            // 
            // btn_danhThu
            // 
            this.btn_danhThu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_danhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_danhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhThu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_danhThu.Location = new System.Drawing.Point(3, 601);
            this.btn_danhThu.Name = "btn_danhThu";
            this.btn_danhThu.Size = new System.Drawing.Size(321, 59);
            this.btn_danhThu.TabIndex = 9;
            this.btn_danhThu.Text = "Danh thu";
            this.btn_danhThu.UseVisualStyleBackColor = false;
            this.btn_danhThu.Click += new System.EventHandler(this.btn_danhThu_Click);
            // 
            // btn_dangXuat
            // 
            this.btn_dangXuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangXuat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_dangXuat.Location = new System.Drawing.Point(3, 666);
            this.btn_dangXuat.Name = "btn_dangXuat";
            this.btn_dangXuat.Size = new System.Drawing.Size(321, 59);
            this.btn_dangXuat.TabIndex = 9;
            this.btn_dangXuat.Text = "Đăng xuất";
            this.btn_dangXuat.UseVisualStyleBackColor = false;
            this.btn_dangXuat.Click += new System.EventHandler(this.btn_dangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 1055);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pn_frmCon);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(262, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1680, 1055);
            this.panel2.TabIndex = 1;
            // 
            // pn_frmCon
            // 
            this.pn_frmCon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pn_frmCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_frmCon.Location = new System.Drawing.Point(0, 34);
            this.pn_frmCon.Name = "pn_frmCon";
            this.pn_frmCon.Size = new System.Drawing.Size(1680, 1021);
            this.pn_frmCon.TabIndex = 1;
            this.pn_frmCon.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_frmCon_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.pic_thoat);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1680, 34);
            this.panel4.TabIndex = 0;
            // 
            // pic_thoat
            // 
            this.pic_thoat.Image = global::GUI.Properties.Resources.reject1;
            this.pic_thoat.Location = new System.Drawing.Point(1676, 3);
            this.pic_thoat.Name = "pic_thoat";
            this.pic_thoat.Size = new System.Drawing.Size(39, 31);
            this.pic_thoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_thoat.TabIndex = 1;
            this.pic_thoat.TabStop = false;
            this.pic_thoat.Click += new System.EventHandler(this.pic_thoat_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1942, 1055);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_QLThongTin.ResumeLayout(false);
            this.pn_QLTaiKhoan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_thoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer time_btnThongTin;
        private System.Windows.Forms.Timer time_btnTaiKhoan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_quyenNV;
        private System.Windows.Forms.Label lb_tenNV;
        private System.Windows.Forms.Button btn_chuyen;
        private System.Windows.Forms.Button btn_xe;
        private System.Windows.Forms.Button btn_ve;
        private System.Windows.Forms.FlowLayoutPanel pn_QLThongTin;
        private System.Windows.Forms.Button btn_QLThongTinh;
        private System.Windows.Forms.Button btn_tinhThanh;
        private System.Windows.Forms.Button btn_QLHangXe;
        private System.Windows.Forms.Button btn_QLLoaiXe;
        private System.Windows.Forms.Button btn_QLDichVu;
        private System.Windows.Forms.FlowLayoutPanel pn_QLTaiKhoan;
        private System.Windows.Forms.Button btn_QLTaiKhoan;
        private System.Windows.Forms.Button btn_QLKhachHang;
        private System.Windows.Forms.Button btn_QLNhanVien;
        private System.Windows.Forms.Button btn_danhThu;
        private System.Windows.Forms.Button btn_dangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_frmCon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pic_thoat;
    }
}