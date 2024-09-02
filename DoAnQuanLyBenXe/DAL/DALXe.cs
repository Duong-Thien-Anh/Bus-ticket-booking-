        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALXe
    {
        QLBXDataContext qlbx = new QLBXDataContext();
        DALGhe ghe = new DALGhe();
        DALDichVu dichVu = new DALDichVu();

        public DALXe()
        {

        }

        public List<XeOTA> getListXe()
        {
            var chuyenList = from xe in qlbx.Xes
                             join chuyen in qlbx.Chuyens on xe.MaChuyen equals chuyen.MaChuyen
                             join loaiXe in qlbx.LoaiXes on xe.LoaiXe equals loaiXe.MaLoaiXe
                             join hangXe in qlbx.HangXes on xe.MaHangXe equals hangXe.MaHangXe
                             select new XeOTA
                             {
                                 SoXe = xe.SoXe,
                                 MaXe = xe.MaXe,
                                 TenTaiXe = xe.TenTaiXe,
                                 TenChuyen = chuyen.TenChuyen,
                                 LoaiXe = loaiXe.TenLoaiXe,
                                 TGKhoiHanh = (DateTime)xe.TGXuatPhat,
                                 TGHuyVe = (TimeSpan)xe.TGHuyVe,
                                 TrangThai = xe.TrangThai,
                                 MaHangXe = hangXe.TenHangXe,
                                 Gia = (int)xe.Gia,
                             };

            return chuyenList.ToList();
        }

        //Tạo mã tự động
        public string MaTuDong()
        {
            List<string> listMa = new List<string>();
            foreach (var item in getListXe())
            {
                listMa.Add(item.MaXe);
            }
            if (listMa.Count == 0)
            {
                return "XE001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "XE" + t.ToString("000");
        }

        // Thêm xe
        public void AddXe(string maXe, string soXe, string chuyen, string tenTX, string trangThai, string loaiXe, string hangXe, int gia, TimeSpan tgHuy, DateTime TGBatDau)
        {
            Xe xe = new Xe();
            xe.MaXe = maXe;
            xe.SoXe = soXe;
            xe.MaChuyen = chuyen;
            xe.TenTaiXe = tenTX;
            xe.TrangThai = trangThai;
            xe.LoaiXe = loaiXe;
            xe.MaHangXe = hangXe;
            xe.Gia = gia;
            xe.TGHuyVe = tgHuy;
            xe.TGXuatPhat = TGBatDau;
            qlbx.Xes.InsertOnSubmit(xe);
            qlbx.SubmitChanges();
            
        }

        // Cập nhật xe
        public void UppdateXe(string maXe, string soXe,string chuyen, string tenTX, string trangThai, string loaiXe, string hangXe, int gia, TimeSpan TGHuy, DateTime TGBatDau)
        {
            Xe xe = qlbx.Xes.Where(kh => kh.MaXe == maXe).FirstOrDefault();
            if (xe != null)
            {
                xe.MaXe = maXe;
                xe.SoXe = soXe;
                xe.MaChuyen = chuyen;
                xe.TenTaiXe = tenTX;
                xe.TrangThai = trangThai;
                xe.LoaiXe = loaiXe;
                xe.MaHangXe = hangXe;
                xe.Gia = gia;
                xe.TGHuyVe = TGHuy;
                xe.TGXuatPhat = TGBatDau;
                qlbx.SubmitChanges();
            }
        }
        //Xóa xe
        public void DeleteXe(string maXe)
        {
            Xe xe = qlbx.Xes.Where(kh => kh.MaXe == maXe).FirstOrDefault();

            if (xe != null)
            {
                ghe.deleteALLGhe(xe.MaXe);
                dichVu.deleteCTAllDV(xe.MaXe);

                qlbx.Xes.DeleteOnSubmit(xe);
                qlbx.SubmitChanges();
            }
        }
    }

    public class XeOTA
    {
        public string MaXe { get; set; }
        public string SoXe { get; set; }
        public string TenTaiXe { get; set; }
        public string TenChuyen { get; set; }
        public string LoaiXe { get; set; }
        public string TrangThai { get; set; }
        public DateTime TGKhoiHanh { get; set; }
        public TimeSpan TGHuyVe {  get; set; }
        public string MaHangXe { get; set; }
        public int Gia { get; set; }





    }
}
