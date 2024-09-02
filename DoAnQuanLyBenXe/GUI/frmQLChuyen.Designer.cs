namespace GUI
{
    partial class frmQLChuyen
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
            this.dtg_chuyen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maChuyen = new System.Windows.Forms.TextBox();
            this.txt_tenChuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.time_tgDi = new System.Windows.Forms.DateTimePicker();
            this.realTimeSource1 = new DevExpress.Data.RealTimeSource();
            this.txt_tenTram = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maTram = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_diemDi = new System.Windows.Forms.ComboBox();
            this.cbb_diemDen = new System.Windows.Forms.ComboBox();
            this.btn_xoaChuyen = new System.Windows.Forms.Button();
            this.btn_capNhatThoiGian = new System.Windows.Forms.Button();
            this.btn_themChuyen = new System.Windows.Forms.Button();
            this.btn_themTram = new System.Windows.Forms.Button();
            this.cbb_tinhThanh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pn_thongTin = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_chuyen
            // 
            this.dtg_chuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_chuyen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtg_chuyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_chuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_chuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_chuyen.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_chuyen.Location = new System.Drawing.Point(116, 378);
            this.dtg_chuyen.Name = "dtg_chuyen";
            this.dtg_chuyen.RowHeadersWidth = 51;
            this.dtg_chuyen.RowTemplate.Height = 24;
            this.dtg_chuyen.Size = new System.Drawing.Size(1058, 439);
            this.dtg_chuyen.TabIndex = 0;
            this.dtg_chuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_chuyen_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(757, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý chuyến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã chuyến";
            // 
            // txt_maChuyen
            // 
            this.txt_maChuyen.Enabled = false;
            this.txt_maChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maChuyen.Location = new System.Drawing.Point(344, 147);
            this.txt_maChuyen.Name = "txt_maChuyen";
            this.txt_maChuyen.Size = new System.Drawing.Size(205, 28);
            this.txt_maChuyen.TabIndex = 3;
            // 
            // txt_tenChuyen
            // 
            this.txt_tenChuyen.Enabled = false;
            this.txt_tenChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenChuyen.Location = new System.Drawing.Point(344, 235);
            this.txt_tenChuyen.Name = "txt_tenChuyen";
            this.txt_tenChuyen.Size = new System.Drawing.Size(205, 28);
            this.txt_tenChuyen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên chuyến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời gian chuyến đi: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(823, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Điểm đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(823, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Diểm bắt đầu";
            // 
            // time_tgDi
            // 
            this.time_tgDi.CustomFormat = "HH:mm";
            this.time_tgDi.Enabled = false;
            this.time_tgDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_tgDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_tgDi.Location = new System.Drawing.Point(760, 311);
            this.time_tgDi.Name = "time_tgDi";
            this.time_tgDi.ShowUpDown = true;
            this.time_tgDi.Size = new System.Drawing.Size(125, 28);
            this.time_tgDi.TabIndex = 13;
            // 
            // realTimeSource1
            // 
            this.realTimeSource1.DisplayableProperties = null;
            // 
            // txt_tenTram
            // 
            this.txt_tenTram.Enabled = false;
            this.txt_tenTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenTram.Location = new System.Drawing.Point(1423, 220);
            this.txt_tenTram.Name = "txt_tenTram";
            this.txt_tenTram.Size = new System.Drawing.Size(148, 28);
            this.txt_tenTram.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1313, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tên trạm";
            // 
            // txt_maTram
            // 
            this.txt_maTram.Enabled = false;
            this.txt_maTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maTram.Location = new System.Drawing.Point(1420, 140);
            this.txt_maTram.Name = "txt_maTram";
            this.txt_maTram.Size = new System.Drawing.Size(148, 28);
            this.txt_maTram.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1310, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã trạm";
            // 
            // cbb_diemDi
            // 
            this.cbb_diemDi.Enabled = false;
            this.cbb_diemDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_diemDi.FormattingEnabled = true;
            this.cbb_diemDi.Location = new System.Drawing.Point(962, 144);
            this.cbb_diemDi.Name = "cbb_diemDi";
            this.cbb_diemDi.Size = new System.Drawing.Size(223, 30);
            this.cbb_diemDi.TabIndex = 23;
            this.cbb_diemDi.SelectedIndexChanged += new System.EventHandler(this.cbb_diemDi_SelectedIndexChanged);
            // 
            // cbb_diemDen
            // 
            this.cbb_diemDen.Enabled = false;
            this.cbb_diemDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_diemDen.FormattingEnabled = true;
            this.cbb_diemDen.Location = new System.Drawing.Point(962, 232);
            this.cbb_diemDen.Name = "cbb_diemDen";
            this.cbb_diemDen.Size = new System.Drawing.Size(223, 30);
            this.cbb_diemDen.TabIndex = 24;
            this.cbb_diemDen.SelectedIndexChanged += new System.EventHandler(this.cbb_diemDen_SelectedIndexChanged);
            // 
            // btn_xoaChuyen
            // 
            this.btn_xoaChuyen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoaChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaChuyen.Location = new System.Drawing.Point(211, 878);
            this.btn_xoaChuyen.Name = "btn_xoaChuyen";
            this.btn_xoaChuyen.Size = new System.Drawing.Size(178, 80);
            this.btn_xoaChuyen.TabIndex = 25;
            this.btn_xoaChuyen.Text = "Xóa";
            this.btn_xoaChuyen.UseVisualStyleBackColor = false;
            this.btn_xoaChuyen.Click += new System.EventHandler(this.btn_xoaChuyen_Click);
            // 
            // btn_capNhatThoiGian
            // 
            this.btn_capNhatThoiGian.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_capNhatThoiGian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capNhatThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhatThoiGian.Location = new System.Drawing.Point(859, 883);
            this.btn_capNhatThoiGian.Name = "btn_capNhatThoiGian";
            this.btn_capNhatThoiGian.Size = new System.Drawing.Size(200, 80);
            this.btn_capNhatThoiGian.TabIndex = 26;
            this.btn_capNhatThoiGian.Text = "Câp nhân thời gian đi";
            this.btn_capNhatThoiGian.UseVisualStyleBackColor = false;
            this.btn_capNhatThoiGian.Click += new System.EventHandler(this.btn_capNhatThoiGian_Click);
            // 
            // btn_themChuyen
            // 
            this.btn_themChuyen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_themChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themChuyen.Location = new System.Drawing.Point(534, 878);
            this.btn_themChuyen.Name = "btn_themChuyen";
            this.btn_themChuyen.Size = new System.Drawing.Size(178, 80);
            this.btn_themChuyen.TabIndex = 27;
            this.btn_themChuyen.Text = "Thêm";
            this.btn_themChuyen.UseVisualStyleBackColor = false;
            this.btn_themChuyen.Click += new System.EventHandler(this.btn_themChuyen_Click);
            // 
            // btn_themTram
            // 
            this.btn_themTram.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_themTram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themTram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themTram.Location = new System.Drawing.Point(1342, 878);
            this.btn_themTram.Name = "btn_themTram";
            this.btn_themTram.Size = new System.Drawing.Size(149, 69);
            this.btn_themTram.TabIndex = 21;
            this.btn_themTram.Text = "Thêm";
            this.btn_themTram.UseVisualStyleBackColor = false;
            this.btn_themTram.Click += new System.EventHandler(this.btn_themTram_Click);
            // 
            // cbb_tinhThanh
            // 
            this.cbb_tinhThanh.Enabled = false;
            this.cbb_tinhThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tinhThanh.FormattingEnabled = true;
            this.cbb_tinhThanh.Location = new System.Drawing.Point(1428, 303);
            this.cbb_tinhThanh.Name = "cbb_tinhThanh";
            this.cbb_tinhThanh.Size = new System.Drawing.Size(143, 30);
            this.cbb_tinhThanh.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1310, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tỉnh thành";
            // 
            // pn_thongTin
            // 
            this.pn_thongTin.AutoScroll = true;
            this.pn_thongTin.Location = new System.Drawing.Point(1244, 374);
            this.pn_thongTin.Name = "pn_thongTin";
            this.pn_thongTin.Size = new System.Drawing.Size(388, 454);
            this.pn_thongTin.TabIndex = 41;
            // 
            // frmQLChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1021);
            this.Controls.Add(this.pn_thongTin);
            this.Controls.Add(this.cbb_tinhThanh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_themChuyen);
            this.Controls.Add(this.btn_capNhatThoiGian);
            this.Controls.Add(this.btn_xoaChuyen);
            this.Controls.Add(this.cbb_diemDen);
            this.Controls.Add(this.cbb_diemDi);
            this.Controls.Add(this.btn_themTram);
            this.Controls.Add(this.txt_tenTram);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_maTram);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.time_tgDi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenChuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maChuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_chuyen);
            this.Name = "frmQLChuyen";
            this.Load += new System.EventHandler(this.frmQLChuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_chuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maChuyen;
        private System.Windows.Forms.TextBox txt_tenChuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker time_tgDi;
        private DevExpress.Data.RealTimeSource realTimeSource1;
        private System.Windows.Forms.TextBox txt_tenTram;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maTram;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_diemDi;
        private System.Windows.Forms.ComboBox cbb_diemDen;
        private System.Windows.Forms.Button btn_xoaChuyen;
        private System.Windows.Forms.Button btn_capNhatThoiGian;
        private System.Windows.Forms.Button btn_themChuyen;
        private System.Windows.Forms.Button btn_themTram;
        private System.Windows.Forms.ComboBox cbb_tinhThanh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel pn_thongTin;
    }
}