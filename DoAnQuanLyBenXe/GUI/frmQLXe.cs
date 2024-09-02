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
using DevExpress.ClipboardSource.SpreadsheetML;

namespace GUI
{
    public partial class frmQLXe : Form
    {
        string gheDangChon = "";
        string dvdagnChon = "";
        DALXe xe = new DALXe();   
        DALChuyen chuyen = new DALChuyen();
        DALHangXe hangXe = new DALHangXe();
        DALLoaiXe loaiXe = new DALLoaiXe();
        DALXe xr = new DALXe();
        DALGhe ghe = new DALGhe();
        DALDichVu dichVu = new DALDichVu();
        List<string> listTrangThaiGhe = new List<string>() { "Tất cả", "Đã đặt", "Trống", "Đã khóa" };

        public frmQLXe()
        {
            InitializeComponent();
        }
        private void frmQLXe_Load(object sender, EventArgs e)
        {

            dtg_Xe.DataSource = xe.getListXe();
            if (dtg_Xe.RowCount > 0)
            {
                dtg_Xe.Columns["MaXe"].HeaderText = "Mã xe";
                dtg_Xe.Columns["SoXe"].HeaderText = "Số xe";
                dtg_Xe.Columns["TenTaiXe"].HeaderText = "Tên tài xe";
                dtg_Xe.Columns["TGKhoiHanh"].HeaderText = "Khởi hành";
                dtg_Xe.Columns["TGHuyVe"].HeaderText = "TG hủy vé";
                dtg_Xe.Columns["LoaiXe"].HeaderText = "Loại xe";
                dtg_Xe.Columns["TrangThai"].HeaderText = "Trạng thái";
                dtg_Xe.Columns["MaHangXe"].HeaderText = " Mã hãng xe";
                dtg_Xe.Columns["Gia"].HeaderText = "Giá";
            }

            time_huyVe.Value = DateTime.Now;
            time_xuatPhat.Value = DateTime.Now;



            cbb_chuyen.DataSource = chuyen.getListChuyen();
            cbb_chuyen.DisplayMember = "TenChuyen";
            cbb_chuyen.ValueMember = "MaChuyen";


            cbb_hangXe.DataSource = hangXe.getList();
            cbb_hangXe.DisplayMember = "TenHangXe";
            cbb_hangXe.ValueMember = "MaHangXe";

            cbb_loaiXe.DataSource = loaiXe.getList();
            cbb_loaiXe.DisplayMember = "TenLoaiXe";
            cbb_loaiXe.ValueMember = "MaLoaiXe";

            List<string> listTrangThaiXe = new List<string>() { "Hoạt động", "Nghĩ" };
            cbb_trangThai.DataSource = listTrangThaiXe;
            List<string> listLuaChon = new List<string>() { "Ghế", "Dịch vụ"};
            cbb_luaChon.DataSource = listLuaChon;

            dtg_Xe_CellClick(dtg_Xe, new DataGridViewCellEventArgs(0, 0));


        }
        // Bảng chuyến xe
        private void dtg_Xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtg_Xe.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtg_Xe.Rows[rowIndex];
            if(row !=  null )
            {
                cbb_trangThaiGhe.Enabled = true;
                cbb_luaChon.Enabled = true;
                txt_maXe.Text = row.Cells["MaXe"].Value.ToString();
                txt_soXe.Text = row.Cells["SoXe"].Value.ToString();
                txt_gia.Text = row.Cells["Gia"].Value.ToString();
                txt_tenTaiXe.Text = row.Cells["TenTaiXe"].Value.ToString();
                cbb_trangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();

                time_xuatPhat.Value = (DateTime)row.Cells["TGKhoihanh"].Value;
                TimeSpan tgHuy = (TimeSpan)row.Cells["TGHuyVe"].Value;
                DateTime fixedDate = DateTime.Today;
                DateTime dateTimeValue = fixedDate.Add(tgHuy);
                time_huyVe.Value = dateTimeValue;          

                var HX = hangXe.getList().FirstOrDefault(ma => ma.TenHangXe == row.Cells["MaHangXe"].Value.ToString());
                var LX = loaiXe.getList().FirstOrDefault(ma => ma.TenLoaiXe == row.Cells["LoaiXe"].Value.ToString());
                var CH = chuyen.getListChuyen().FirstOrDefault(ma => ma.TenChuyen == row.Cells["TenChuyen"].Value.ToString());
                cbb_hangXe.SelectedItem = HX;
                cbb_loaiXe.SelectedItem = LX;
                cbb_chuyen.SelectedValue = CH.MaChuyen;


                if (cbb_luaChon.SelectedItem.ToString() == "Ghế")
                {
                    showDSGhe(txt_maXe.Text, "Tất cả");
                }
                else 
                {
                    ShowDSDV(txt_maXe.Text);
                }


            }
        }
        // Thêm xe
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                txt_soXe.Enabled = true;
                txt_tenTaiXe.Enabled = true;
                cbb_loaiXe.Enabled = true;
                cbb_hangXe.Enabled = true;
                cbb_trangThai.Enabled = true;
                cbb_chuyen.Enabled = true;
                txt_gia.Enabled = true;
                txt_maXe.Enabled = true;
                time_huyVe.Enabled = true;
                time_xuatPhat.Enabled = true;



                btn_capNhat.Enabled = false;
                btn_xoa.Enabled = false;
                btn_them.Text = "lưu";
                txt_soXe.Clear();
                txt_tenTaiXe.Clear();
                txt_gia.Clear();
                txt_maXe.Text = xe.MaTuDong();
                dtg_Xe.Enabled = false;
            }
            else
            {
                if (txt_soXe.Text != "" && txt_tenTaiXe.Text != "" && txt_gia.Text != "")
                {
                    TimeSpan tgHuy = time_huyVe.Value.TimeOfDay;
                    xe.AddXe(txt_maXe.Text, txt_soXe.Text, cbb_chuyen.SelectedValue.ToString(), txt_tenTaiXe.Text, cbb_trangThai.SelectedItem.ToString(), cbb_loaiXe.SelectedValue.ToString(), cbb_hangXe.SelectedValue.ToString(), int.Parse(txt_gia.Text), tgHuy, time_xuatPhat.Value);
                    craeteAllGhe(txt_maXe.Text);
                    dtg_Xe.DataSource = xe.getListXe();
                    txt_soXe.Enabled = false;
                    txt_tenTaiXe.Enabled = false;
                    txt_maXe.Enabled = false;

                    cbb_loaiXe.Enabled = false;
                    cbb_hangXe.Enabled = false;
                    cbb_trangThai.Enabled = false;
                    cbb_chuyen.Enabled = false;
                    txt_gia.Enabled = false;
                    time_huyVe.Enabled = false;
                    time_xuatPhat.Enabled = false;

                    btn_capNhat.Enabled = true;
                    btn_xoa.Enabled = true;
                    dtg_Xe.Enabled = true;
                    btn_them.Text = "Thêm";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
                
            }
        }
        // Xóa xe
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            xe.DeleteXe(txt_maXe.Text);
            dtg_Xe.DataSource = xe.getListXe();

        }
        // Cập nhật xe
        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            if(txt_maXe.Text != "")
            {
                if (btn_capNhat.Text == "Cập nhật")
                {
                    txt_soXe.Enabled = true;
                    txt_tenTaiXe.Enabled = true;
                    txt_gia.Enabled = true;
                    //cbb_loaiXe.Enabled = true;
                    cbb_hangXe.Enabled = true;
                    cbb_trangThai.Enabled = true;
                    cbb_chuyen.Enabled = true;
                    time_huyVe.Enabled = true;
                    time_xuatPhat.Enabled = true;

                    btn_them.Enabled = false;
                    btn_xoa.Enabled = false;
                    btn_capNhat.Text = "lưu";
                    dtg_Xe.Enabled = false;
                }
                else
                {
                    TimeSpan tgHuy = time_huyVe.Value.TimeOfDay;
                    xe.UppdateXe(txt_maXe.Text, txt_soXe.Text, cbb_chuyen.SelectedValue.ToString(), txt_tenTaiXe.Text, cbb_trangThai.SelectedItem.ToString(), cbb_loaiXe.SelectedValue.ToString(), cbb_hangXe.SelectedValue.ToString(), int.Parse(txt_gia.Text), tgHuy, time_xuatPhat.Value);
                    dtg_Xe.DataSource = xe.getListXe();
                    txt_soXe.Enabled = false;
                    txt_gia.Enabled = false;
                    txt_tenTaiXe.Enabled = false;
                    //cbb_loaiXe.Enabled = false;
                    cbb_hangXe.Enabled = false;
                    cbb_chuyen.Enabled = false;
                    cbb_trangThai.Enabled = false;
                    time_huyVe.Enabled = false;
                    time_xuatPhat.Enabled = false;

                    btn_them.Enabled = true;
                    btn_xoa.Enabled = true;
                    dtg_Xe.Enabled = true;
                    btn_capNhat.Text = "Cập nhật";
                }
            }
        }
        
        // Tạo ghế theo số lượng ghế của xe
        public void craeteAllGhe(string maXe)
        {
            int soLuonGhe = loaiXe.getSoGhe(cbb_loaiXe.SelectedValue.ToString());
            for (int i = 0; i < soLuonGhe; i++)
            {
                ghe.CreateGhe(i.ToString("00"), maXe);
            }
        }
        // Hiện ds ghế bện của xe
        public void showDSGhe(string maXe, string trangThai)
        {
            cbb_trangThaiGhe.DataSource = listTrangThaiGhe;
            loadDSTram(txt_maXe.Text, trangThai);
            btn_themDV.Visible = false;
            btn_THKhoa.Visible = true;
            //btn_THTrong.Visible = true;
            //btb_THDat.Visible = true;

        }
        // Show DS dich vu
        public void ShowDSDV(string maXe)
        {
            cbb_trangThaiGhe.DataSource = dichVu.getList();
            cbb_trangThaiGhe.DisplayMember = "TenDV";
            cbb_trangThaiGhe.ValueMember = "MaDV";
            loadDSDV(txt_maXe.Text);
            

            btn_themDV.Visible = true;
            btn_THKhoa.Visible = false;
            btn_THTrong.Visible = false;
            //btb_THDat.Visible = false;
        }
        

        // Cập nhật trạng thái Đã đặt cho vé
        private void btb_THDat_Click(object sender, EventArgs e)
        {
            ghe.uppdateTrangThai(gheDangChon, txt_maXe.Text, "Đã đặt");
            showDSGhe(txt_maXe.Text, cbb_trangThaiGhe.SelectedItem.ToString());
            btn_THKhoa.Enabled = false;
            btn_THTrong.Enabled = false;
            //    btb_THDat.Enabled = false;
        }
        // Cập nhật trạng thái Trống cho vé
        private void btn_THTrong_Click(object sender, EventArgs e)
        {
            ghe.uppdateTrangThai(gheDangChon, txt_maXe.Text, "Trống");
            showDSGhe(txt_maXe.Text, cbb_trangThaiGhe.SelectedItem.ToString());
            btn_THKhoa.Enabled = false;
            btn_THTrong.Enabled = false;
            //btb_THDat.Enabled = false;
        }
        // Cập nhật trạng thái Đã khóa cho vé
        private void btn_THKhoa_Click(object sender, EventArgs e)
        {
            ghe.uppdateTrangThai(gheDangChon, txt_maXe.Text, "Đã khóa");
            showDSGhe(txt_maXe.Text, cbb_trangThaiGhe.SelectedItem.ToString());
            btn_THKhoa.Enabled = false;
            btn_THTrong.Enabled = false;
            //btb_THDat.Enabled = false;
        }
        // Chọn trạng thái
        private void cbb_trangThaiGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_maXe.Text != "")
            {
                if (cbb_luaChon.SelectedItem.ToString() == "Ghế")
                    showDSGhe(txt_maXe.Text, cbb_trangThaiGhe.SelectedItem.ToString());
            }
           
        }

        private void cbb_luaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_maXe.Text != "")
            {
                if (cbb_luaChon.SelectedItem.ToString() == "Ghế")
                {
                    showDSGhe(txt_maXe.Text, "Tất cả");
                }
                else
                {
                    ShowDSDV(txt_maXe.Text);
                }
            }
        }

        private void btn_themDV_Click(object sender, EventArgs e)
        {
            if (dichVu.ThemVaoXe(txt_maXe.Text, cbb_trangThaiGhe.SelectedValue.ToString()) == -1)
                MessageBox.Show("Xe đã có dịch vụ này rồi!");
            ShowDSDV(txt_maXe.Text);
        }

        public void btn_xoaDV_Click(object sender, EventArgs e)
        {
            dichVu.XoaKhoiXe(txt_maXe.Text, dvdagnChon);
            ShowDSDV(txt_maXe.Text);
        }

        // Load danh sách trạm
        public void loadDSTram(string maXe, string trangThai)
        {
            foreach (Control control in pn_list.Controls)
            {
                control.Dispose();
            }
            // Xóa tất cả control trong Panel
            pn_list.Controls.Clear();
            List<Ghe> lst;
            if (trangThai == "Tất cả")
            {
                lst = ghe.getList(maXe);
            }
            else
                lst = ghe.getList(maXe, trangThai);

            if (lst != null)
            {
                foreach (Ghe t in lst)
                {
                    ThongTinGhe ctrTram = new ThongTinGhe(t);
                    ctrTram.chon += CtrTram_chon;
                    pn_list.Controls.Add(ctrTram);
                }
            }
        }
        // Load danh sách DV
        public void loadDSDV(string maXe)
        {
            foreach (Control control in pn_list.Controls)
            {
                control.Dispose();
            }
            // Xóa tất cả control trong Panel
            pn_list.Controls.Clear();
            List<DichVu> lst = dichVu.getList(maXe);
            if (lst != null)
            {
                foreach (DichVu t in lst)
                {
                    ThongTinhDV ctrTram = new ThongTinhDV(t, maXe);
                    ctrTram.Xoa += CtrTram_Xoa; ;
                    pn_list.Controls.Add(ctrTram);
                }
            }

        }

        private void CtrTram_Xoa(object sender, EventArgs e)
        {
            loadDSDV(txt_maXe.Text);
        }

        private void CtrTram_chon(object sender, MyEventArgsBan e)
        {
            gheDangChon = e.Data;
            btn_THKhoa.Enabled = true;
            btn_THTrong.Enabled = true;
            //btb_THDat.Enabled = true;


        }
    }
}
