using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace GUI
{
    public partial class frmQLDanhThu : Form
    {
        DALVe ve = new DALVe();
        public frmQLDanhThu()
        {
            InitializeComponent();
        }

        private void frmQLDanhThu_Load(object sender, EventArgs e)
        {
            List<string> listTrangThaiVeBang = new List<string>() { "Tất cả", "Đã đặt", "Hủy thành công" };
            List<string> listNam = new List<string>() { "2023", "2022", "2021", "2020", "2019" };
            cbb_trangThai.DataSource = listTrangThaiVeBang;
            cbb_nam.DataSource = listNam;
        }
        // Thêm dữ liệu vào sơ đồ vé
        public void themDuLieuVE(int[] duLieu, string ten)
        {
            Series newSeries = new Series($"{ten}");
            DateTime startDate = new DateTime(2023, 1, 1);
            for (int j = 0; j < 12; j++)
            {
                DateTime month = startDate.AddMonths(j);
                double dataPoint = duLieu[j]; 
                newSeries.Points.AddXY(month.ToString("MMMM"), dataPoint);
            }
            chart1.Series.Add(newSeries);
        }
        // Thêm dữ liệu vào sơ đồ danh số
        public void themDuLieuDS(int[] duLieu)
        {
            Series newSeries = new Series($"Danh số");
            DateTime startDate = new DateTime(2023, 1, 1);
            for (int j = 0; j < 12; j++)
            {
                DateTime month = startDate.AddMonths(j);
                double dataPoint = duLieu[j];
                newSeries.Points.AddXY(month.ToString("MMMM"), dataPoint);
            }
            chart2.Series.Add(newSeries);
        }

        private void cbb_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_nam.SelectedItem != null)
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Series.Clear();
                string str = cbb_trangThai.SelectedItem.ToString();
                int nam = int.Parse(cbb_nam.SelectedItem.ToString());

                if (str == "Tất cả")
                {
                    themDuLieuVE(ve.duLieuThang("Đã đặt", nam), "Đã đặt");
                    themDuLieuVE(ve.duLieuThang("Hủy thành công", nam), "Hủy thành công");
                }
                else
                    themDuLieuVE(ve.duLieuThang(str, nam), str);
            }
            
        }

        private void cbb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Series.Clear();

            cbb_trangThai.SelectedItem = "Tất cả";
            int nam = int.Parse(cbb_nam.SelectedItem.ToString());


            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            chart2.Series.Clear();

            themDuLieuDS(ve.duLieuDTThang("Đã đặt", nam));
        }
    }
}
