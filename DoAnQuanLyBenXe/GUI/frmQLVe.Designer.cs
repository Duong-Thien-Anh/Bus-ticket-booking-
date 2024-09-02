namespace GUI
{
    partial class frmQLVe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_ve = new System.Windows.Forms.DataGridView();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_trangThai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.time_DatVe = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_Khach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_xe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_ghe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_suaVe = new System.Windows.Forms.Button();
            this.btn_huyVe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_trangThaiBang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_tenKhach = new System.Windows.Forms.Label();
            this.lb_tenChuyen = new System.Windows.Forms.Label();
            this.lb_tgHuy = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_loaiXe = new System.Windows.Forms.Label();
            this.lb_tgXuatPhat = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lb_tgChuyenĐi = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_huyVeAll = new System.Windows.Forms.Button();
            this.btn_datNhieuVe = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.num_veNhieu = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_veNhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_ve
            // 
            this.dtg_ve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ve.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtg_ve.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_ve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_ve.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_ve.Location = new System.Drawing.Point(35, 297);
            this.dtg_ve.Name = "dtg_ve";
            this.dtg_ve.RowHeadersWidth = 51;
            this.dtg_ve.RowTemplate.Height = 24;
            this.dtg_ve.Size = new System.Drawing.Size(1174, 438);
            this.dtg_ve.TabIndex = 0;
            this.dtg_ve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ve_CellClick);
            // 
            // txtMaVe
            // 
            this.txtMaVe.Enabled = false;
            this.txtMaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVe.Location = new System.Drawing.Point(188, 124);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(156, 28);
            this.txtMaVe.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã chuyến";
            // 
            // cbb_trangThai
            // 
            this.cbb_trangThai.Enabled = false;
            this.cbb_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_trangThai.FormattingEnabled = true;
            this.cbb_trangThai.Location = new System.Drawing.Point(188, 173);
            this.cbb_trangThai.Name = "cbb_trangThai";
            this.cbb_trangThai.Size = new System.Drawing.Size(156, 30);
            this.cbb_trangThai.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "Trạng thái";
            // 
            // time_DatVe
            // 
            this.time_DatVe.CustomFormat = "HH:mm:ss | yyyy-MM-dd ";
            this.time_DatVe.Enabled = false;
            this.time_DatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_DatVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_DatVe.Location = new System.Drawing.Point(613, 181);
            this.time_DatVe.Name = "time_DatVe";
            this.time_DatVe.Size = new System.Drawing.Size(252, 30);
            this.time_DatVe.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(483, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "TG đặt vé";
            // 
            // cbb_Khach
            // 
            this.cbb_Khach.Enabled = false;
            this.cbb_Khach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Khach.FormattingEnabled = true;
            this.cbb_Khach.Location = new System.Drawing.Point(577, 124);
            this.cbb_Khach.Name = "cbb_Khach";
            this.cbb_Khach.Size = new System.Drawing.Size(187, 30);
            this.cbb_Khach.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Khách";
            // 
            // cbb_xe
            // 
            this.cbb_xe.Enabled = false;
            this.cbb_xe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_xe.FormattingEnabled = true;
            this.cbb_xe.Location = new System.Drawing.Point(1009, 131);
            this.cbb_xe.Name = "cbb_xe";
            this.cbb_xe.Size = new System.Drawing.Size(187, 30);
            this.cbb_xe.TabIndex = 40;
            this.cbb_xe.SelectedIndexChanged += new System.EventHandler(this.cbb_xe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(921, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Xe";
            // 
            // cbb_ghe
            // 
            this.cbb_ghe.Enabled = false;
            this.cbb_ghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ghe.FormattingEnabled = true;
            this.cbb_ghe.Location = new System.Drawing.Point(1009, 178);
            this.cbb_ghe.Name = "cbb_ghe";
            this.cbb_ghe.Size = new System.Drawing.Size(187, 30);
            this.cbb_ghe.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(921, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ghe";
            // 
            // btn_suaVe
            // 
            this.btn_suaVe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_suaVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suaVe.Location = new System.Drawing.Point(331, 821);
            this.btn_suaVe.Name = "btn_suaVe";
            this.btn_suaVe.Size = new System.Drawing.Size(162, 92);
            this.btn_suaVe.TabIndex = 43;
            this.btn_suaVe.Text = "Sửa vé";
            this.btn_suaVe.UseVisualStyleBackColor = false;
            this.btn_suaVe.Click += new System.EventHandler(this.btn_suaVe_Click);
            // 
            // btn_huyVe
            // 
            this.btn_huyVe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_huyVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huyVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huyVe.Location = new System.Drawing.Point(824, 821);
            this.btn_huyVe.Name = "btn_huyVe";
            this.btn_huyVe.Size = new System.Drawing.Size(172, 92);
            this.btn_huyVe.TabIndex = 44;
            this.btn_huyVe.Text = "Xác nhận hủy vé";
            this.btn_huyVe.UseVisualStyleBackColor = false;
            this.btn_huyVe.Click += new System.EventHandler(this.btn_huyVe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1324, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tên khách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1324, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tên chuyến:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1324, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 22);
            this.label11.TabIndex = 50;
            this.label11.Text = "Thời gian hủy:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1324, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 22);
            this.label12.TabIndex = 51;
            this.label12.Text = "Thời gian xuất phát:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1324, 713);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 52;
            this.label8.Text = "Giá vé:";
            // 
            // cbb_trangThaiBang
            // 
            this.cbb_trangThaiBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_trangThaiBang.FormattingEnabled = true;
            this.cbb_trangThaiBang.Location = new System.Drawing.Point(1053, 261);
            this.cbb_trangThaiBang.Name = "cbb_trangThaiBang";
            this.cbb_trangThaiBang.Size = new System.Drawing.Size(156, 30);
            this.cbb_trangThaiBang.TabIndex = 53;
            this.cbb_trangThaiBang.SelectedIndexChanged += new System.EventHandler(this.cbb_trangThaiBang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 49);
            this.label4.TabIndex = 54;
            this.label4.Text = "Quản lý vé";
            // 
            // lb_tenKhach
            // 
            this.lb_tenKhach.AutoSize = true;
            this.lb_tenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenKhach.Location = new System.Drawing.Point(1528, 155);
            this.lb_tenKhach.Name = "lb_tenKhach";
            this.lb_tenKhach.Size = new System.Drawing.Size(59, 20);
            this.lb_tenKhach.TabIndex = 55;
            this.lb_tenKhach.Text = "..........";
            // 
            // lb_tenChuyen
            // 
            this.lb_tenChuyen.AutoSize = true;
            this.lb_tenChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenChuyen.Location = new System.Drawing.Point(1528, 235);
            this.lb_tenChuyen.Name = "lb_tenChuyen";
            this.lb_tenChuyen.Size = new System.Drawing.Size(59, 20);
            this.lb_tenChuyen.TabIndex = 56;
            this.lb_tenChuyen.Text = "..........";
            // 
            // lb_tgHuy
            // 
            this.lb_tgHuy.AutoSize = true;
            this.lb_tgHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tgHuy.Location = new System.Drawing.Point(1528, 520);
            this.lb_tgHuy.Name = "lb_tgHuy";
            this.lb_tgHuy.Size = new System.Drawing.Size(59, 20);
            this.lb_tgHuy.TabIndex = 57;
            this.lb_tgHuy.Text = "..........";
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia.Location = new System.Drawing.Point(1528, 715);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(59, 20);
            this.lb_gia.TabIndex = 60;
            this.lb_gia.Text = "..........";
            // 
            // lb_loaiXe
            // 
            this.lb_loaiXe.AutoSize = true;
            this.lb_loaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaiXe.Location = new System.Drawing.Point(1528, 621);
            this.lb_loaiXe.Name = "lb_loaiXe";
            this.lb_loaiXe.Size = new System.Drawing.Size(59, 20);
            this.lb_loaiXe.TabIndex = 59;
            this.lb_loaiXe.Text = "..........";
            // 
            // lb_tgXuatPhat
            // 
            this.lb_tgXuatPhat.AutoSize = true;
            this.lb_tgXuatPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tgXuatPhat.Location = new System.Drawing.Point(1528, 322);
            this.lb_tgXuatPhat.Name = "lb_tgXuatPhat";
            this.lb_tgXuatPhat.Size = new System.Drawing.Size(59, 20);
            this.lb_tgXuatPhat.TabIndex = 58;
            this.lb_tgXuatPhat.Text = "..........";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1324, 619);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 22);
            this.label18.TabIndex = 61;
            this.label18.Text = "Loại xe:";
            // 
            // lb_tgChuyenĐi
            // 
            this.lb_tgChuyenĐi.AutoSize = true;
            this.lb_tgChuyenĐi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tgChuyenĐi.Location = new System.Drawing.Point(1528, 424);
            this.lb_tgChuyenĐi.Name = "lb_tgChuyenĐi";
            this.lb_tgChuyenĐi.Size = new System.Drawing.Size(59, 20);
            this.lb_tgChuyenĐi.TabIndex = 63;
            this.lb_tgChuyenĐi.Text = "..........";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1324, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 22);
            this.label14.TabIndex = 62;
            this.label14.Text = "Thời gian chuyến đi:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(602, 821);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(162, 92);
            this.btn_xoa.TabIndex = 64;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(63, 821);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(162, 92);
            this.btn_them.TabIndex = 65;
            this.btn_them.Text = "Thêm vé";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_huyVeAll
            // 
            this.btn_huyVeAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_huyVeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huyVeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huyVeAll.Location = new System.Drawing.Point(1083, 821);
            this.btn_huyVeAll.Name = "btn_huyVeAll";
            this.btn_huyVeAll.Size = new System.Drawing.Size(181, 92);
            this.btn_huyVeAll.TabIndex = 45;
            this.btn_huyVeAll.Text = "Xác nhận hủy tất cả";
            this.btn_huyVeAll.UseVisualStyleBackColor = false;
            this.btn_huyVeAll.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // btn_datNhieuVe
            // 
            this.btn_datNhieuVe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_datNhieuVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datNhieuVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datNhieuVe.Location = new System.Drawing.Point(46, 246);
            this.btn_datNhieuVe.Name = "btn_datNhieuVe";
            this.btn_datNhieuVe.Size = new System.Drawing.Size(168, 43);
            this.btn_datNhieuVe.TabIndex = 66;
            this.btn_datNhieuVe.Text = "Đặt nhiều vé";
            this.btn_datNhieuVe.UseVisualStyleBackColor = false;
            this.btn_datNhieuVe.Click += new System.EventHandler(this.btn_datNhieuVe_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(494, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 22);
            this.label13.TabIndex = 67;
            this.label13.Text = "Mã chuyến";
            // 
            // num_veNhieu
            // 
            this.num_veNhieu.Enabled = false;
            this.num_veNhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_veNhieu.Location = new System.Drawing.Point(626, 256);
            this.num_veNhieu.Name = "num_veNhieu";
            this.num_veNhieu.Size = new System.Drawing.Size(50, 30);
            this.num_veNhieu.TabIndex = 69;
            // 
            // frmQLVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 974);
            this.Controls.Add(this.num_veNhieu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_datNhieuVe);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.lb_tgChuyenĐi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lb_gia);
            this.Controls.Add(this.lb_loaiXe);
            this.Controls.Add(this.lb_tgXuatPhat);
            this.Controls.Add(this.lb_tgHuy);
            this.Controls.Add(this.lb_tenChuyen);
            this.Controls.Add(this.lb_tenKhach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_trangThaiBang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_huyVeAll);
            this.Controls.Add(this.btn_huyVe);
            this.Controls.Add(this.btn_suaVe);
            this.Controls.Add(this.cbb_ghe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_xe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_Khach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.time_DatVe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbb_trangThai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_ve);
            this.Name = "frmQLVe";
            this.Text = "frmQLVe";
            this.Load += new System.EventHandler(this.frmQLVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_veNhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_ve;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_trangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker time_DatVe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_Khach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_xe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_ghe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_suaVe;
        private System.Windows.Forms.Button btn_huyVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_trangThaiBang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_tenKhach;
        private System.Windows.Forms.Label lb_tenChuyen;
        private System.Windows.Forms.Label lb_tgHuy;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_loaiXe;
        private System.Windows.Forms.Label lb_tgXuatPhat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lb_tgChuyenĐi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_huyVeAll;
        private System.Windows.Forms.Button btn_datNhieuVe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown num_veNhieu;
    }
}