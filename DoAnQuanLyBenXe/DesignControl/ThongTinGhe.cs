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
    public partial class ThongTinGhe : UserControl
    {
        public event EventHandler<MyEventArgsBan> chon;
        string _maGhe;
        public ThongTinGhe(Ghe ghe)
        {
            _maGhe = ghe.SoGhe;
            InitializeComponent();
            lb_soGhe.Text = ghe.SoGhe;
            lb_trangThai.Text = ghe.TrangThai;
            if(ghe.TrangThai == "Đã đặt")
                pic_ghe.Image = new Bitmap("E:\\GitHub\\XeKhach\\Project\\DoAnQuanLyBenXe\\GUI\\Resources\\dat.png");
            else if (ghe.TrangThai == "Trống")
            {
                pic_ghe.Image = new Bitmap("E:\\GitHub\\XeKhach\\Project\\DoAnQuanLyBenXe\\GUI\\Resources\\trong.png");
            }
            else
                pic_ghe.Image = new Bitmap("E:\\GitHub\\XeKhach\\Project\\DoAnQuanLyBenXe\\GUI\\Resources\\khoa.png");
        }

        private void pic_ghe_Click(object sender, EventArgs e)
        {
            chon?.Invoke(this, new MyEventArgsBan(_maGhe));

        }
    }
    public class MyEventArgsBan : EventArgs
    {
        public string Data { get; set; }

        public MyEventArgsBan(string data)
        {
            Data = data;
        }
    }
}
