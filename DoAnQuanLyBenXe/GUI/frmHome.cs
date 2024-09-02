using DAL;
using DevExpress.Drawing.Internal.Fonts.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace GUI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        public frmHome(NhanVien nv)
        {
           
            InitializeComponent();
            lb_quyenNV.Text = nv.Quyen;
            lb_tenNV.Text = nv.TenNhanVien;
            if(nv.Quyen != "Admin")
            {
                btn_QLNhanVien.Visible = false;
                pn_QLThongTin.Visible = false;
            }

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            btn_chuyen.PerformClick();

        }




        bool thongTinExpand = false;
        // Timer mở rộng cho nút thông tin
        private void time_btnThongTin_Tick(object sender, EventArgs e)
        {

            if (!thongTinExpand)
            {
                pn_QLThongTin.Height += 10;
                if (pn_QLThongTin.Height >= 212)
                {
                    time_btnThongTin.Stop();
                    thongTinExpand = true;
                }
            }
            else
            {
                pn_QLThongTin.Height -= 10;
                if (pn_QLThongTin.Height <= 68)
                {
                    time_btnThongTin.Stop();
                    thongTinExpand = false;
                }
            }
        }

        bool taiKhoanExpand = false;
        // Timer mở rộng cho nút thông tin
        private void time_btnTaiKhoan_Tick(object sender, EventArgs e)
        {
            if (!taiKhoanExpand)
            {
                pn_QLTaiKhoan.Height += 10;
                if (pn_QLTaiKhoan.Height >= 132)
                {
                    time_btnTaiKhoan.Stop();
                    taiKhoanExpand = true;
                }
            }
            else
            {
                pn_QLTaiKhoan.Height -= 10;
                if (pn_QLTaiKhoan.Height <= 65)
                {
                    time_btnTaiKhoan.Stop();
                    taiKhoanExpand = false;
                }
            }
        }
        // Nút thông tin
        private void btn_QLThongTinh_Click(object sender, EventArgs e)
        {
            time_btnThongTin.Start();
        }
        // nút tái khoản
        private void btn_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            time_btnTaiKhoan.Start();
        }
        //Thoát
        private void pic_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm;
        // Hiện form con lên panel
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pn_frmCon.Controls.Add(childForm);
            this.pn_frmCon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //btn_tieuDe.Text = childForm.Text;
        }

        private void btn_chuyen_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLChuyen());
        }

        private void btn_xe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLXe());
        }

        private void btn_ve_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLVe());
        }

        private void btn_QLDichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLDichVu());
        }

        private void btn_QLHangXe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLHangXe());
        }

        private void btn_QLLoaiXe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLLoaiXe());
        }

        private void btn_tinhThanh_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLTinhThanh());
        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLNhanVien());
        }

        private void btn_QLKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLKhachHang());
        }

        private void btn_danhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLDanhThu());
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Program.DN.Show();
            }
            else
                return;
        }

        private void pn_frmCon_Paint(object sender, PaintEventArgs e)
        {
                
        }
    }
}
