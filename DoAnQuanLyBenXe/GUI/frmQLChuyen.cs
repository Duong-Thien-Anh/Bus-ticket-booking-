using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DesignControl;
using DevExpress.Data.Filtering;

namespace GUI
{
    public partial class frmQLChuyen : Form
    {
        DALChuyen chuyen = new  DALChuyen();
        DALTinhThanh tinhThanh = new DALTinhThanh();
        DALTram tram = new DALTram();
        public frmQLChuyen()
        {
            InitializeComponent();
        }

        private void frmQLChuyen_Load(object sender, EventArgs e)
        {
            dtg_chuyen.DataSource = chuyen.getListChuyen();
            dtg_chuyen.Columns["MaChuyen"].HeaderText = "Mã chuyến";
            dtg_chuyen.Columns["TenChuyen"].HeaderText = "Tên chuyến";
            dtg_chuyen.Columns["DiemBatDau"].HeaderText = "Điểm bắt đầu";
            dtg_chuyen.Columns["DiemDen"].HeaderText = "Điểm đến";
            dtg_chuyen.Columns["TgChuyen"].HeaderText = "Thời gian chuyến";

            cbb_diemDi.DataSource = tinhThanh.getListTT();
            cbb_diemDi.DisplayMember = "TenTinh";
            cbb_diemDi.ValueMember = "MaTinh";

            cbb_diemDen.DataSource = tinhThanh.getListTT();
            cbb_diemDen.DisplayMember = "TenTinh";
            cbb_diemDen.ValueMember = "MaTinh";

            cbb_tinhThanh.DataSource = tinhThanh.getListTT();
            cbb_tinhThanh.DisplayMember = "TenTinh";
            cbb_tinhThanh.ValueMember = "MaTinh";

            dtg_chuyen_CellClick(dtg_chuyen, new DataGridViewCellEventArgs(0, 0));


        }
        // Bảng chuyen
        private void dtg_chuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtg_chuyen.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtg_chuyen.Rows[rowIndex];
            if (row != null)
            {
                txt_maChuyen.Text = row.Cells["MaChuyen"].Value.ToString();
                txt_tenChuyen.Text = row.Cells["TenChuyen"].Value.ToString();
                string diemBatDau = row.Cells["DiemBatDau"].Value.ToString();
                string diemDen = row.Cells["DiemDen"].Value.ToString();

                TimeSpan timeSpanValue = (TimeSpan)row.Cells["TgChuyen"].Value;
                DateTime fixedDate = DateTime.Today;
                DateTime dateTimeValue = fixedDate.Add(timeSpanValue);
                time_tgDi.Value = dateTimeValue;

                var di = tinhThanh.getListTT().FirstOrDefault(t => t.TenTinh == diemBatDau);
                var den = tinhThanh.getListTT().FirstOrDefault(t => t.TenTinh == diemDen);
                cbb_diemDi.SelectedItem = di;
                cbb_diemDen.SelectedItem = den;
                loadDSTram(txt_maChuyen.Text);

            }
        }
        

        // Xóa chuyến
        private void btn_xoaChuyen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                chuyen.XoaChuyen(txt_maChuyen.Text);
                dtg_chuyen.DataSource = chuyen.getListChuyen();
            }
        }

        // Thêm chuyến
        private void btn_themChuyen_Click(object sender, EventArgs e)
        {
            if(btn_themChuyen.Text == "Thêm")
            {
                time_tgDi.Enabled = true;
                btn_capNhatThoiGian.Enabled = false;
                btn_xoaChuyen.Enabled = false;
                cbb_diemDi.Enabled = true;
                cbb_diemDen.Enabled = true;
                dtg_chuyen.Enabled = false;
                btn_themChuyen.Text = "lưu";
                txt_tenChuyen.Clear();
                time_tgDi.Value = DateTime.Today;
                txt_maChuyen.Text = chuyen.MaTuDong();
            }
            else
            {
                TinhThanh tt1 = (TinhThanh)cbb_diemDi.SelectedItem;
                TinhThanh tt2 = (TinhThanh)cbb_diemDen.SelectedItem;

                if (chuyen.CheckChuyen(txt_tenChuyen.Text))
                {
                    MessageBox.Show("Đã có chuyến " + txt_tenChuyen.Text + ", xin chọn lại!");
                }
                else if (txt_tenChuyen.Text != "")
                {
                    TimeSpan time = time_tgDi.Value.TimeOfDay;
                    chuyen.addChuyen(txt_maChuyen.Text, txt_tenChuyen.Text, cbb_diemDi.SelectedValue.ToString(), cbb_diemDen.SelectedValue.ToString(), time);
                    dtg_chuyen.DataSource = chuyen.getListChuyen();
                    time_tgDi.Enabled = false;
                    cbb_diemDi.Enabled = false;
                    cbb_diemDen.Enabled = false;
                    btn_capNhatThoiGian.Enabled = true;
                    btn_xoaChuyen.Enabled = true;
                    dtg_chuyen.Enabled = true;
                    btn_themChuyen.Text = "Thêm";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
            }
            
        }

        // Cập nhận thời gian chuyến
        private void btn_capNhatThoiGian_Click(object sender, EventArgs e)
        {
            if (btn_capNhatThoiGian.Text == "Câp nhân thời gian đi")
            {
                time_tgDi.Enabled = true;
                btn_capNhatThoiGian.Text = "lưu";
                txt_tenChuyen.Clear();
                btn_themChuyen.Enabled = false;
                btn_xoaChuyen.Enabled = false;
            }
            else
            {
                TimeSpan time = time_tgDi.Value.TimeOfDay;
                chuyen.UppdateChuyen(txt_maChuyen.Text, time);
                dtg_chuyen.DataSource = chuyen.getListChuyen();
                time_tgDi.Enabled = false;
                btn_themChuyen.Enabled = true;
                btn_xoaChuyen.Enabled = true;
                btn_capNhatThoiGian.Text = "Câp nhân thời gian đi";
            }
        }

        // Thêm trạm
        private void btn_themTram_Click(object sender, EventArgs e)
        {
            if (btn_themTram.Text == "Thêm")
            {
                txt_tenTram.Enabled = true;
                cbb_tinhThanh.Enabled = true;
                btn_themTram.Text = "lưu";
                txt_maTram.Text = tram.MaTuDong(txt_maChuyen.Text);
            }
            else
            {
                if (txt_tenTram.Text != "")
                {
                    
                    tram.addTram(txt_maTram.Text,txt_maChuyen.Text, txt_tenTram.Text, cbb_tinhThanh.SelectedValue.ToString());
                    loadDSTram(txt_maChuyen.Text);
                    txt_tenTram.Enabled = false;
                    cbb_tinhThanh.Enabled = false;
                    btn_themTram.Text = "Thêm";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
            }
        }

        // Nhấn vào chọn điểm bắt đầu
        private void cbb_diemDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(btn_themChuyen.Text == "lưu")
            {
                TinhThanh tt = (TinhThanh)cbb_diemDi.SelectedItem;
                txt_tenChuyen.Text = tt.TenTinh + " - ";

            }
        }
        // Nhấn vào chọn điểm kết thúc
        private void cbb_diemDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btn_themChuyen.Text == "lưu")
            {
                TinhThanh tt1 = (TinhThanh)cbb_diemDi.SelectedItem;
                TinhThanh tt2 = (TinhThanh)cbb_diemDen.SelectedItem;

                txt_tenChuyen.Text = tt1.TenTinh + " - " + tt2.TenTinh;

            }
        }

        // Load danh sách trạm
        public void loadDSTram(string maXe)
        {
            foreach (Control control in pn_thongTin.Controls)
            {
                control.Dispose();
            }
            // Xóa tất cả control trong Panel
            pn_thongTin.Controls.Clear();
            List<TramOTA> lst = tram.getListTram(maXe);
            foreach (TramOTA t in lst)
            {
                ThongTinTram ctrTram = new ThongTinTram(t, maXe);
                ctrTram.XoaTram += CtrTram_XoaTram;
                pn_thongTin.Controls.Add(ctrTram);
            }
        }

        private void CtrTram_XoaTram(object sender, EventArgs e)
        {
            loadDSTram(txt_maChuyen.Text);
        }
    }
}
