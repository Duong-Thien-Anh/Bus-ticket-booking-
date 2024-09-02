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
    public partial class frmQLDichVu : Form
    {
        DALDichVu dichVu = new DALDichVu();
        public frmQLDichVu()
        {
            InitializeComponent();
        }

        private void frmQLDichVu_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dtg.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
            dtg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dtg.DataSource = dichVu.getList();
            dtg.Columns["MaDV"].HeaderText = "Mã dịch vụ";
            dtg.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            txt_ma.Enabled = false;
            txt_ten.Enabled = false;
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtg.SelectedCells[0].RowIndex;
            DataGridViewRow row = dtg.Rows[rowIndex];
            if (row != null)
            {
                txt_ma.Text = row.Cells["MaDV"].Value.ToString();
                txt_ten.Text = row.Cells["TenDV"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                txt_ten.Enabled = true;
                dtg.Enabled = false;
                txt_ma.Text = dichVu.MaTuDong();
                btn_them.Text = "Lưu";
                txt_ten.Clear();
            }
            else
            {
                if (txt_ten.Text != "")
                {
                    dichVu.Them(txt_ma.Text, txt_ten.Text);
                    dtg.Enabled = true;
                    txt_ten.Enabled = false;
                    btn_them.Text = "Thêm";
                    dtg.DataSource = dichVu.getList();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dichVu.Xoa(txt_ma.Text);
            dtg.DataSource = dichVu.getList();
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
                    dichVu.CapNhat(txt_ma.Text, txt_ten.Text);
                    dtg.Enabled = true;
                    txt_ten.Enabled = false;
                    btn_sua.Text = "Cập nhật";
                    dtg.DataSource = dichVu.getList();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }
    }
}
