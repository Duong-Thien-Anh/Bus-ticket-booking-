namespace GUI
{
    partial class frmQLXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Xe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soXe = new System.Windows.Forms.TextBox();
            this.txt_tenTaiXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_loaiXe = new System.Windows.Forms.ComboBox();
            this.cbb_trangThai = new System.Windows.Forms.ComboBox();
            this.cbb_hangXe = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.txt_maXe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_THKhoa = new System.Windows.Forms.Button();
            this.cbb_trangThaiGhe = new System.Windows.Forms.ComboBox();
            this.time_huyVe = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.time_xuatPhat = new System.Windows.Forms.DateTimePicker();
            this.cbb_chuyen = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_luaChon = new System.Windows.Forms.ComboBox();
            this.btn_themDV = new System.Windows.Forms.Button();
            this.pn_list = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_gia = new DesignControl.txt_ChiNhapSo();
            this.btn_THTrong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Xe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Xe
            // 
            this.dtg_Xe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_Xe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Xe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Xe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtg_Xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Xe.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtg_Xe.Location = new System.Drawing.Point(30, 283);
            this.dtg_Xe.Name = "dtg_Xe";
            this.dtg_Xe.RowHeadersWidth = 51;
            this.dtg_Xe.RowTemplate.Height = 24;
            this.dtg_Xe.Size = new System.Drawing.Size(1198, 511);
            this.dtg_Xe.TabIndex = 0;
            this.dtg_Xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Xe_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số xe";
            // 
            // txt_soXe
            // 
            this.txt_soXe.Enabled = false;
            this.txt_soXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soXe.Location = new System.Drawing.Point(143, 181);
            this.txt_soXe.Name = "txt_soXe";
            this.txt_soXe.Size = new System.Drawing.Size(119, 30);
            this.txt_soXe.TabIndex = 5;
            // 
            // txt_tenTaiXe
            // 
            this.txt_tenTaiXe.Enabled = false;
            this.txt_tenTaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenTaiXe.Location = new System.Drawing.Point(543, 117);
            this.txt_tenTaiXe.Name = "txt_tenTaiXe";
            this.txt_tenTaiXe.Size = new System.Drawing.Size(166, 30);
            this.txt_tenTaiXe.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên tài xế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(877, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1312, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hãng xe";
            // 
            // cbb_loaiXe
            // 
            this.cbb_loaiXe.Enabled = false;
            this.cbb_loaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loaiXe.FormattingEnabled = true;
            this.cbb_loaiXe.Location = new System.Drawing.Point(995, 111);
            this.cbb_loaiXe.Name = "cbb_loaiXe";
            this.cbb_loaiXe.Size = new System.Drawing.Size(233, 33);
            this.cbb_loaiXe.TabIndex = 13;
            // 
            // cbb_trangThai
            // 
            this.cbb_trangThai.Enabled = false;
            this.cbb_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_trangThai.FormattingEnabled = true;
            this.cbb_trangThai.Location = new System.Drawing.Point(543, 180);
            this.cbb_trangThai.Name = "cbb_trangThai";
            this.cbb_trangThai.Size = new System.Drawing.Size(166, 33);
            this.cbb_trangThai.TabIndex = 14;
            // 
            // cbb_hangXe
            // 
            this.cbb_hangXe.Enabled = false;
            this.cbb_hangXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hangXe.FormattingEnabled = true;
            this.cbb_hangXe.Location = new System.Drawing.Point(1447, 113);
            this.cbb_hangXe.Name = "cbb_hangXe";
            this.cbb_hangXe.Size = new System.Drawing.Size(185, 33);
            this.cbb_hangXe.TabIndex = 15;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(163, 848);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(153, 90);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(543, 848);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(153, 90);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_capNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhat.Location = new System.Drawing.Point(995, 848);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(153, 90);
            this.btn_capNhat.TabIndex = 18;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = false;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // txt_maXe
            // 
            this.txt_maXe.Enabled = false;
            this.txt_maXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maXe.Location = new System.Drawing.Point(143, 118);
            this.txt_maXe.Name = "txt_maXe";
            this.txt_maXe.Size = new System.Drawing.Size(119, 30);
            this.txt_maXe.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1358, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Giá";
            // 
            // btn_THKhoa
            // 
            this.btn_THKhoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_THKhoa.Enabled = false;
            this.btn_THKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_THKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THKhoa.Location = new System.Drawing.Point(1575, 848);
            this.btn_THKhoa.Name = "btn_THKhoa";
            this.btn_THKhoa.Size = new System.Drawing.Size(115, 90);
            this.btn_THKhoa.TabIndex = 28;
            this.btn_THKhoa.Text = "Khóa";
            this.btn_THKhoa.UseVisualStyleBackColor = false;
            this.btn_THKhoa.Click += new System.EventHandler(this.btn_THKhoa_Click);
            // 
            // cbb_trangThaiGhe
            // 
            this.cbb_trangThaiGhe.Enabled = false;
            this.cbb_trangThaiGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_trangThaiGhe.FormattingEnabled = true;
            this.cbb_trangThaiGhe.Location = new System.Drawing.Point(1347, 231);
            this.cbb_trangThaiGhe.Name = "cbb_trangThaiGhe";
            this.cbb_trangThaiGhe.Size = new System.Drawing.Size(140, 33);
            this.cbb_trangThaiGhe.TabIndex = 29;
            this.cbb_trangThaiGhe.SelectedIndexChanged += new System.EventHandler(this.cbb_trangThaiGhe_SelectedIndexChanged);
            // 
            // time_huyVe
            // 
            this.time_huyVe.CustomFormat = "HH:mm";
            this.time_huyVe.Enabled = false;
            this.time_huyVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_huyVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_huyVe.Location = new System.Drawing.Point(282, 233);
            this.time_huyVe.Name = "time_huyVe";
            this.time_huyVe.ShowUpDown = true;
            this.time_huyVe.Size = new System.Drawing.Size(125, 30);
            this.time_huyVe.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Thời gian hủy vé";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(561, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "Thời gian xuất phát";
            // 
            // time_xuatPhat
            // 
            this.time_xuatPhat.CustomFormat = "HH:mm:ss | yyyy-MM-dd ";
            this.time_xuatPhat.Enabled = false;
            this.time_xuatPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_xuatPhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_xuatPhat.Location = new System.Drawing.Point(810, 233);
            this.time_xuatPhat.Name = "time_xuatPhat";
            this.time_xuatPhat.Size = new System.Drawing.Size(272, 30);
            this.time_xuatPhat.TabIndex = 34;
            // 
            // cbb_chuyen
            // 
            this.cbb_chuyen.Enabled = false;
            this.cbb_chuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chuyen.FormattingEnabled = true;
            this.cbb_chuyen.Location = new System.Drawing.Point(995, 176);
            this.cbb_chuyen.Name = "cbb_chuyen";
            this.cbb_chuyen.Size = new System.Drawing.Size(233, 33);
            this.cbb_chuyen.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(877, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 29);
            this.label11.TabIndex = 35;
            this.label11.Text = "Chuyến:";
            // 
            // cbb_luaChon
            // 
            this.cbb_luaChon.Enabled = false;
            this.cbb_luaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_luaChon.FormattingEnabled = true;
            this.cbb_luaChon.Location = new System.Drawing.Point(1575, 230);
            this.cbb_luaChon.Name = "cbb_luaChon";
            this.cbb_luaChon.Size = new System.Drawing.Size(121, 33);
            this.cbb_luaChon.TabIndex = 37;
            this.cbb_luaChon.SelectedIndexChanged += new System.EventHandler(this.cbb_luaChon_SelectedIndexChanged);
            // 
            // btn_themDV
            // 
            this.btn_themDV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_themDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themDV.Location = new System.Drawing.Point(1438, 848);
            this.btn_themDV.Name = "btn_themDV";
            this.btn_themDV.Size = new System.Drawing.Size(153, 90);
            this.btn_themDV.TabIndex = 38;
            this.btn_themDV.Text = "Thêm";
            this.btn_themDV.UseVisualStyleBackColor = false;
            this.btn_themDV.Visible = false;
            this.btn_themDV.Click += new System.EventHandler(this.btn_themDV_Click);
            // 
            // pn_list
            // 
            this.pn_list.AutoScroll = true;
            this.pn_list.BackColor = System.Drawing.Color.Transparent;
            this.pn_list.Location = new System.Drawing.Point(1295, 283);
            this.pn_list.Name = "pn_list";
            this.pn_list.Size = new System.Drawing.Size(410, 511);
            this.pn_list.TabIndex = 42;
            // 
            // txt_gia
            // 
            this.txt_gia.Enabled = false;
            this.txt_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(1462, 166);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(170, 30);
            this.txt_gia.TabIndex = 41;
            // 
            // btn_THTrong
            // 
            this.btn_THTrong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_THTrong.Enabled = false;
            this.btn_THTrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_THTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THTrong.Location = new System.Drawing.Point(1347, 848);
            this.btn_THTrong.Name = "btn_THTrong";
            this.btn_THTrong.Size = new System.Drawing.Size(115, 90);
            this.btn_THTrong.TabIndex = 27;
            this.btn_THTrong.Text = "Mở khóa";
            this.btn_THTrong.UseVisualStyleBackColor = false;
            this.btn_THTrong.Click += new System.EventHandler(this.btn_THTrong_Click);
            // 
            // frmQLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 974);
            this.Controls.Add(this.pn_list);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.btn_themDV);
            this.Controls.Add(this.cbb_luaChon);
            this.Controls.Add(this.cbb_chuyen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.time_xuatPhat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.time_huyVe);
            this.Controls.Add(this.cbb_trangThaiGhe);
            this.Controls.Add(this.btn_THKhoa);
            this.Controls.Add(this.btn_THTrong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_maXe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cbb_hangXe);
            this.Controls.Add(this.cbb_trangThai);
            this.Controls.Add(this.cbb_loaiXe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenTaiXe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_Xe);
            this.Name = "frmQLXe";
            this.Text = "frmQLXe";
            this.Load += new System.EventHandler(this.frmQLXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Xe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Xe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soXe;
        private System.Windows.Forms.TextBox txt_tenTaiXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_loaiXe;
        private System.Windows.Forms.ComboBox cbb_trangThai;
        private System.Windows.Forms.ComboBox cbb_hangXe;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.TextBox txt_maXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_THKhoa;
        private System.Windows.Forms.ComboBox cbb_trangThaiGhe;
        private System.Windows.Forms.DateTimePicker time_huyVe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker time_xuatPhat;
        private System.Windows.Forms.ComboBox cbb_chuyen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbb_luaChon;
        private System.Windows.Forms.Button btn_themDV;
        private DesignControl.txt_ChiNhapSo txt_gia;
        private System.Windows.Forms.FlowLayoutPanel pn_list;
        private System.Windows.Forms.Button btn_THTrong;
    }
}