using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQLVe : Form
    {
        DALVe ve = new DALVe();
        DALKhach khach = new DALKhach();
        DALXe xe = new DALXe();
        DALGhe ghe = new DALGhe();
        public frmQLVe()
        {
            InitializeComponent();
        }

        private void frmQLVe_Load(object sender, EventArgs e)
        {
            dtg_ve.DataSource = ve.getList();
            dtg_ve.Columns["MaVe"].HeaderText = "Mã vé";
            dtg_ve.Columns["NgayDat"].HeaderText = "Ngày đăt";
            dtg_ve.Columns["TrangThai"].HeaderText = "Điểm bắt đầu";
            dtg_ve.Columns["Khach"].HeaderText = "Tên khách";
            dtg_ve.Columns["SoGhe"].HeaderText = "Số ghế";
            dtg_ve.Columns["Xe"].HeaderText = "Số xe";

            cbb_Khach.DataSource = khach.getList();
            cbb_Khach.DisplayMember = "TenKhachHang";
            cbb_Khach.ValueMember = "MaKhach";

            cbb_xe.DataSource = xe.getListXe();
            cbb_xe.DisplayMember = "SoXe";
            cbb_xe.ValueMember = "MaXe";

            var xes = (XeOTA)cbb_xe.SelectedItem;
            cbb_ghe.DataSource = ghe.getList(xes.MaXe, "Trống");
            cbb_ghe.DisplayMember = "SoGhe";
            cbb_ghe.ValueMember = "SoGhe";
            time_DatVe.Value = DateTime.Now;

            List<string> listTrangThaiVeBang = new List<string>() {"Tất cả", "Đã đặt", "Hủy", "Hủy thành công" };
            cbb_trangThaiBang.DataSource = listTrangThaiVeBang;

            List<string> listTrangThaiVe = new List<string>() { "Đã đặt", "Hủy" };
            cbb_trangThai.DataSource = listTrangThaiVe;
        }

        private void dtg_ve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtg_ve.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtg_ve.Rows[rowIndex];
            if (row != null)
            {
                txtMaVe.Text = row.Cells["MaVe"].Value.ToString();
                cbb_trangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
                time_DatVe.Value =(DateTime)row.Cells["NgayDat"].Value;


                var kh = khach.getList().FirstOrDefault(t => t.TenKhachHang == row.Cells["Khach"].Value.ToString());
                cbb_Khach.SelectedItem = kh;
                var xes = xe.getListXe().FirstOrDefault(t => t.SoXe == row.Cells["Xe"].Value.ToString());
                cbb_xe.SelectedValue = xes.MaXe;
                cbb_ghe.DataSource = ghe.getList(xes.MaXe) ?? null;
                var gh = ghe.getList(xes.MaXe).FirstOrDefault(t => t.SoGhe == row.Cells["SoGhe"].Value.ToString());
                cbb_ghe.SelectedValue = gh.SoGhe;
                ShowTTVe(txtMaVe.Text);
            }
            }

        private void btn_suaVe_Click(object sender, EventArgs e)
        {
             if(btn_suaVe.Text == "Sửa vé")
            {
                //txtMaVe.Text = ve.MaTuDong();
                cbb_trangThai.Enabled = true;
                cbb_Khach.Enabled = true;
                cbb_xe.Enabled = true;
                cbb_ghe.Enabled = true;
                time_DatVe.Enabled = true;
                btn_suaVe.Text = "Lưu";
                dtg_ve.Enabled = false;

                btn_huyVe.Enabled = false;
                btn_huyVeAll.Enabled = false;
                btn_xoa.Enabled = false;
                btn_them.Enabled = false;

            }
            else
            {
                if (cbb_ghe.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    ve.uppdatVe(txtMaVe.Text, cbb_trangThai.SelectedValue.ToString(), cbb_Khach.SelectedValue.ToString(), cbb_xe.SelectedValue.ToString(), cbb_ghe.SelectedValue.ToString(), time_DatVe.Value);
                    cbb_trangThai.Enabled = false;
                    cbb_Khach.Enabled = false;
                    cbb_xe.Enabled = false;
                    cbb_ghe.Enabled = false;
                    btn_suaVe.Text = "Sửa vé";
                    dtg_ve.DataSource = ve.getList();
                    dtg_ve.Enabled = true;

                    btn_huyVe.Enabled = true;
                    btn_huyVeAll.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_them.Enabled = true;

                }
            }
            
        }

        private void cbb_xe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_xe.SelectedItem != null)
            {
                var xes = (XeOTA)cbb_xe.SelectedItem;
                cbb_ghe.DataSource = ghe.getList(xes.MaXe, "Trống");
                cbb_ghe.DisplayMember = "SoGhe";
                cbb_ghe.ValueMember = "SoGhe";
            }

        }

        private void btn_huyVe_Click(object sender, EventArgs e)
        {

            ve.uppdatVe(txtMaVe.Text, "Hủy thành công", cbb_Khach.SelectedValue.ToString(), cbb_xe.SelectedValue.ToString(), cbb_ghe.SelectedValue.ToString(), time_DatVe.Value);
            dtg_ve.DataSource = ve.getList();
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            ve.UpHuyALL();
            dtg_ve.DataSource = ve.getList();
        }

        // Hiện thông tin vé
        public void ShowTTVe(string maVE)
        {
            ThongTinVe TTVe = ve.getThongTin(maVE);
            if (TTVe != null)
            {
                lb_tenKhach.Text = TTVe.TenKhach;
                lb_tenChuyen.Text = TTVe.TenChuyen;
                lb_tgXuatPhat.Text = TTVe.TGXuatPhat.Value.ToString();
                lb_tgChuyenĐi.Text = TTVe.TGHuy.Value.ToString();
                lb_tgHuy.Text = TTVe.TGHuy.Value.ToString();
                lb_loaiXe.Text = TTVe.LoaiXe;
                lb_gia.Text = TTVe.Gia.ToString();
            }

        }

        private void cbb_trangThaiBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_trangThaiBang.SelectedItem.ToString() == "Tất cả")
                dtg_ve.DataSource = ve.getList();
            else
                dtg_ve.DataSource= ve.getList(cbb_trangThaiBang.SelectedItem.ToString());
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ve.DeleteVe(txtMaVe.Text);
            dtg_ve.DataSource = ve.getList();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm vé")
            {
                txtMaVe.Text = ve.MaTuDong();
                cbb_Khach.Enabled = true;
                cbb_xe.Enabled = true;
                cbb_ghe.Enabled = true;
                time_DatVe.Enabled = true;
                btn_them.Text = "Lưu";
                dtg_ve.Enabled = false;

                btn_huyVe.Enabled = false;
                btn_huyVeAll.Enabled = false;
                btn_xoa.Enabled = false;
                btn_suaVe.Enabled = false;

                cbb_ghe.SelectedItem = null;
                cbb_Khach.SelectedItem = null;
                cbb_trangThai.SelectedItem = "Đã đặt";
                cbb_xe.SelectedItem = null;


            }
            else
            {
                if (cbb_ghe.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    ve.addVe(txtMaVe.Text, cbb_trangThai.SelectedValue.ToString(), cbb_Khach.SelectedValue.ToString(), cbb_xe.SelectedValue.ToString(), cbb_ghe.SelectedValue.ToString(), time_DatVe.Value);
                    cbb_Khach.Enabled = false;
                    cbb_xe.Enabled = false;
                    cbb_ghe.Enabled = false;
                    btn_them.Text = "Thêm vé";
                    dtg_ve.DataSource = ve.getList();
                    dtg_ve.Enabled = true;

                    btn_huyVe.Enabled = true;
                    btn_huyVeAll.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_suaVe.Enabled = true;

                }
            }
        }

        private void btn_datNhieuVe_Click(object sender, EventArgs e)
        {
            if (btn_datNhieuVe.Text == "Đặt nhiều vé")
            {
                cbb_Khach.Enabled = true;
                cbb_xe.Enabled = true;
                time_DatVe.Enabled = true;
                dtg_ve.Enabled = false;
                btn_datNhieuVe.Text = "Lưu";
                num_veNhieu.Enabled = true;

                btn_huyVe.Enabled = false;
                btn_huyVeAll.Enabled = false;
                btn_xoa.Enabled = false;
                btn_suaVe.Enabled = false;
                btn_them.Enabled = false;

                cbb_ghe.SelectedItem = null;
                cbb_Khach.SelectedItem = null;
                cbb_xe.SelectedItem = null;
               
            }
            else
            {
                if (num_veNhieu.Value == 0)
                {
                    MessageBox.Show("Vui lòng điền số lượng vé cần đặt!");
                }
                else
                {
                    ve.addNhieuVe("Đã đặt", cbb_Khach.SelectedValue.ToString(), cbb_xe.SelectedValue.ToString(), time_DatVe.Value, int.Parse(num_veNhieu.Value.ToString()));
                    btn_datNhieuVe.Text = "Đặt nhiều vé";
                    num_veNhieu.Enabled = false;
                    dtg_ve.DataSource = ve.getList();

                    dtg_ve.Enabled = true;
                    btn_huyVe.Enabled = true;
                    btn_huyVeAll.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_suaVe.Enabled = true;
                    btn_them.Enabled = true;
                }
            }
        }
    }
}
