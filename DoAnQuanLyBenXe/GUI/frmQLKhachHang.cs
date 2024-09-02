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
    public partial class frmQLKhachHang : Form
    {
        DALKhach khach = new DALKhach();
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dtg.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
            dtg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg.BackgroundColor = SystemColors.Control;

            dtg.DataSource = khach.getList();
            dtg.Columns["MaKhach"].HeaderText = "Mã khách";
            dtg.Columns["TenKhachHang"].HeaderText = "Tên khách";
            dtg.Columns["CCCD"].HeaderText = "CCCD";
            dtg.Columns["Tuoi"].HeaderText = "Tuổi";
            dtg.Columns["SDT"].HeaderText = "SDT";
            dtg.Columns["TaiKhoan"].HeaderText = "Tài khoản";
            dtg.Columns["MK"].HeaderText = "Mât khẩu";

            txt_ma.Enabled = false;
            txt_ten.Enabled = false;
            txt_cccd.Enabled = false;
            txt_tuoi.Enabled = false;
            txt_sdt.Enabled = false;
            txt_tk.Enabled = false;
            txt_mk.Enabled = false;

        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtg.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtg.Rows[rowIndex];
            if (row != null)
            {
                txt_ma.Text = row.Cells["MaKhach"].Value.ToString();
                txt_ten.Text = row.Cells["TenKhachHang"].Value.ToString();
                txt_cccd.Text = row.Cells["CCCD"].Value.ToString();
                txt_tuoi.Text = row.Cells["Tuoi"].Value.ToString();
                txt_sdt.Text = row.Cells["SDT"].Value.ToString();
                txt_tk.Text = row.Cells["TaiKhoan"].Value.ToString();
                txt_mk.Text = row.Cells["MK"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                txt_ten.Enabled = true;
                txt_cccd.Enabled = true;
                txt_tuoi.Enabled = true;
                txt_sdt.Enabled = true;
                txt_tk.Enabled = true;
                txt_mk.Enabled = true;

                dtg.Enabled = false;
                txt_ma.Text = khach.MaTuDong();
                btn_them.Text = "Lưu";
                txt_ten.Clear();
                txt_cccd.Clear();
                txt_tuoi.Clear();
                txt_tuoi.Clear();
                txt_tk.Clear();
                txt_mk.Clear();

            }
            else
            {
                if (txt_ten.Text != "" && txt_cccd.Text != "" && txt_tuoi.Text != "" && txt_sdt.Text != "" && txt_tk.Text != "" && txt_mk.Text != "")
                {
                    khach.them(txt_ma.Text, txt_ten.Text, txt_cccd.Text, int.Parse(txt_tuoi.Text), txt_sdt.Text, txt_tk.Text,txt_mk.Text);
                    dtg.Enabled = true;

                    txt_cccd.Enabled = false;
                    txt_tuoi.Enabled = false;
                    txt_sdt.Enabled = false;
                    txt_tk.Enabled = false;
                    txt_mk.Enabled = false;
                    txt_ten.Enabled = false;
                    btn_them.Text = "Thêm";
                    dtg.DataSource = khach.getList();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            khach.Xoa(txt_ma.Text);
            dtg.DataSource = khach.getList();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Cập nhật")
            {
                txt_ten.Enabled = true;
                txt_cccd.Enabled = true;
                txt_tuoi.Enabled = true;
                txt_sdt.Enabled = true;
                txt_tk.Enabled = true;
                txt_mk.Enabled = true;
                dtg.Enabled = false;
                btn_sua.Text = "Lưu";
            }
            else
            {
                if (txt_ten.Text != "" && txt_cccd.Text != "" && txt_tuoi.Text != "" && txt_sdt.Text != "" && txt_tk.Text != "" && txt_mk.Text != "")
                {
                    khach.CapNhat(txt_ma.Text, txt_ten.Text, txt_cccd.Text, int.Parse(txt_tuoi.Text), txt_sdt.Text, txt_tk.Text, txt_mk.Text);
                    dtg.Enabled = true;
                    txt_ten.Enabled = false;
                    txt_cccd.Enabled = false;
                    txt_tuoi.Enabled = false;
                    txt_sdt.Enabled = false;
                    txt_tk.Enabled = false;
                    txt_mk.Enabled = false;
                    btn_sua.Text = "Cập nhật";
                    dtg.DataSource = khach.getList();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }
    }
}
