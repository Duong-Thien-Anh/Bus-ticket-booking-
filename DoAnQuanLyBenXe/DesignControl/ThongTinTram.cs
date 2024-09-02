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

namespace DesignControl
{
    public partial class ThongTinTram : UserControl
    {
        DALTram tram = new DALTram();
        public event EventHandler<EventArgs> XoaTram;
        string _maXe;
        string _maTram;

        public ThongTinTram(TramOTA tram, string maXe)
        {
            _maXe = maXe;
            _maTram = tram.MaTram;
            InitializeComponent();
            lb_maTram.Text = tram.MaTram;
            lb_tenTram.Text = tram.TenTram;
            lb_thanhPho.Text = tram.Tinh;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tram.DeletteTram(_maTram);
                XoaTram?.Invoke(this, new EventArgs());

            }
        }
    }
}
