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

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        DALNhanVien nv = new DALNhanVien();
        public frmDangNhap()
        {
            InitializeComponent();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_mk.PasswordChar == '*')
            {
                txt_mk.PasswordChar = '\0';
            }
            else
            {
                txt_mk.PasswordChar = '*';
            }
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            string tk = txt_tk.Text;
            string mk = txt_mk.Text;
            if (tk.Trim() == "")
                MessageBox.Show("Vui lòng nhập thông tin tài khoản");
            if (mk.Trim() == "")
                MessageBox.Show("Vui lòng nhập thông tin mât khẩu");
            else
            {
                NhanVien a = nv.checkTK(tk, mk);
                if (a != null)
                {
                    frmHome frm = new frmHome(a);
                    frm.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!");
                }
            }
        }
    }
}
