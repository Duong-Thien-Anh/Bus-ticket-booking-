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
    public partial class frmQLHangXe : Form
    {
        DALHangXe hangXe = new DALHangXe();
        public frmQLHangXe()
        {
            InitializeComponent();
        }

        private void frmQLHangXe_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dtg.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            }
            dtg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg.BackgroundColor = SystemColors.Control;

            dtg.DataSource = hangXe.getList();
            dtg.Columns["MaHangXe"].HeaderText = "Mã hãng xe";
            dtg.Columns["TenHangXe"].HeaderText = "Tên hãng xe";
            txt_ma.Enabled = false;
            txt_ten.Enabled = false;



        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtg.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtg.Rows[rowIndex];
            if (row != null)
            {
                txt_ma.Text = row.Cells["MaHangXe"].Value.ToString();
                txt_ten.Text = row.Cells["TenHangXe"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                txt_ten.Enabled = true;
                dtg.Enabled = false;
                txt_ma.Text = hangXe.MaTuDong();
                btn_them.Text = "Lưu";
                txt_ten.Clear();
            }
            else
            {
                if (txt_ten.Text != "")
                {
                    hangXe.Them(txt_ma.Text, txt_ten.Text);
                    dtg.Enabled = true;
                    txt_ten.Enabled = false;
                    btn_them.Text = "Thêm";
                    dtg.DataSource = hangXe.getList();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            hangXe.Xoa(txt_ma.Text);
            dtg.DataSource = hangXe.getList();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Cập nhật")
            {
                txt_ten.Enabled = true;
                dtg.Enabled = false;
                btn_sua.Text = "Lưu";
            }
            else
            {
                if (txt_ten.Text != "")
                {
                    hangXe.CapNhat(txt_ma.Text, txt_ten.Text);
                    dtg.Enabled = true;
                    txt_ten.Enabled = false;
                    btn_sua.Text = "Cập nhật";
                    dtg.DataSource = hangXe.getList();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }
    }
}
