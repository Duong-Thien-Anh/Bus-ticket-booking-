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
    public partial class frmQLNhanVien : Form
    {
        DALNhanVien nhanVien = new DALNhanVien();
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dtg.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            }
            dtg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dtg.BackgroundColor = SystemColors.Control;
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtg.DataSource = nhanVien.getListNV();
            dtg.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dtg.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dtg.Columns["Quyen"].HeaderText = "Quyền";
            dtg.Columns["MatKhau"].HeaderText = "Mật khẩu";

            List<string> list = new List<string>() { "Admin", "User"};
            cbb_quyen.DataSource = list;

            txt_ma.Enabled = false;
            txt_ten.Enabled = false;
            cbb_quyen.Enabled = false;
            txt_MK.Enabled = false;
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtg.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtg.Rows[rowIndex];
            if (row != null)
            {
                txt_ma.Text = row.Cells["MaNhanVien"].Value.ToString();
                txt_ten.Text = row.Cells["TenNhanVien"].Value.ToString();
                cbb_quyen.Text = row.Cells["Quyen"].Value.ToString();
                txt_MK.Text = row.Cells["MatKhau"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                txt_ten.Enabled = true;
                cbb_quyen.Enabled = true;
                txt_MK.Enabled = true;
                dtg.Enabled = false;
                txt_ma.Text = nhanVien.MaTuDong();
                btn_them.Text = "Lưu";
                txt_ten.Clear();
                txt_MK.Clear();

            }
            else
            {
                if (txt_ten.Text != "" && txt_MK.Text != "")
                {
                    nhanVien.Them(txt_ma.Text, txt_ten.Text, cbb_quyen.SelectedItem.ToString(), txt_MK.Text);
                    dtg.Enabled = true;
                    cbb_quyen.Enabled = false;
                    txt_MK.Enabled = false;
                    txt_ten.Enabled = false;
                    btn_them.Text = "Thêm";
                    dtg.DataSource = nhanVien.getListNV();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            nhanVien.Xoa(txt_ma.Text);
            dtg.DataSource = nhanVien.getListNV();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(btn_sua.Text == "Cập nhật")
            {
                txt_ten.Enabled = true;
                txt_MK.Enabled = true;
                cbb_quyen.Enabled = true;
                dtg.Enabled = false;
                btn_sua.Text = "Lưu";
            }
            else
            {
                if (txt_ten.Text != "" && txt_MK.Text != "")
                {
                    nhanVien.CapNhat(txt_ma.Text, txt_ten.Text, cbb_quyen.SelectedItem.ToString(), txt_MK.Text);
                    dtg.Enabled = true;
                    txt_MK.Enabled = false;
                    cbb_quyen.Enabled = false;
                    txt_ten.Enabled = false;
                    btn_sua.Text = "Cập nhật";
                    dtg.DataSource = nhanVien.getListNV();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }
    }
}
