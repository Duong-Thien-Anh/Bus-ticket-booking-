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
    public partial class frmQLLoaiXe : Form
    {
        DALLoaiXe loaiXe = new DALLoaiXe();
        public frmQLLoaiXe()
        {
            InitializeComponent();
        }

        private void frmQLLoaiXe_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dtg.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            }
            dtg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dtg.BackgroundColor = SystemColors.Control;
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtg.DataSource = loaiXe.getList();
            dtg.Columns["MaLoaiXe"].HeaderText = "Mã loại xe";
            dtg.Columns["TenLoaiXe"].HeaderText = "Tên loại xe";
            dtg.Columns["SoGhe"].HeaderText = "Số lượng ghế";
            txt_ma.Enabled = false;
            txt_ten.Enabled = false;
            txt_soLuong.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            loaiXe.Xoa(txt_ma.Text);
            dtg.DataSource = loaiXe.getList();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Cập nhật")
            {
                txt_ten.Enabled = true;
                txt_soLuong.Enabled = true;
                dtg.Enabled = false;
                btn_sua.Text = "Lưu";
            }
            else
            {
                if (txt_ten.Text != "" && txt_soLuong.Text != "")
                {
                    loaiXe.CapNhat(txt_ma.Text, txt_ten.Text, int.Parse(txt_soLuong.Text));
                    dtg.Enabled = true;
                    txt_soLuong.Enabled = false;
                    txt_ten.Enabled = false;
                    btn_sua.Text = "Cập nhật";
                    dtg.DataSource = loaiXe.getList();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                txt_ten.Enabled = true;
                txt_soLuong.Enabled = true;
                dtg.Enabled = false;
                txt_ma.Text = loaiXe.MaTuDong();
                btn_them.Text = "Lưu";
                txt_ten.Clear();
            }
            else
            {
                if (txt_ten.Text != "" && txt_soLuong.Text != "")
                {
                    loaiXe.Them(txt_ma.Text, txt_ten.Text, int.Parse(txt_soLuong.Text));
                    dtg.Enabled = true;
                    txt_ten.Enabled = false;
                    txt_soLuong.Enabled = false;
                    btn_them.Text = "Thêm";
                    dtg.DataSource = loaiXe.getList();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtg.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtg.Rows[rowIndex];
            if (row != null)
            {
                txt_ma.Text = row.Cells["MaLoaiXe"].Value.ToString();
                txt_ten.Text = row.Cells["TenLoaiXe"].Value.ToString();
                txt_soLuong.Text = row.Cells["SoGhe"].Value.ToString();
            }
        }

        
    }
}
