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
    public partial class ThongTinhDV : UserControl
    {
        string _ma;
        string _xe;
        public event EventHandler<EventArgs> Xoa;

        DALDichVu dichVu = new DALDichVu();
        public ThongTinhDV(DichVu dv, string maXe)
        {
            _ma = dv.MaDV;
            _xe = maXe;
            InitializeComponent();
            lb_maDV.Text = dv.MaDV;
            lb_tenDV.Text = dv.TenDV;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dichVu.XoaKhoiXe(_xe,_ma);
            Xoa?.Invoke(this, new EventArgs());

        }

        private void lb_tenDV_Click(object sender, EventArgs e)
        {

        }
    }
}
