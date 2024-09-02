using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALVe
    {
        QLBXDataContext qlbx = new QLBXDataContext();
        DALGhe DALghe = new DALGhe();
        public DALVe() { }
        // Lấy ds vé
        public List<VeOTA> getList()
        {
            var veList = from ve in qlbx.Ves
                         join ghe in qlbx.Ghes on new { ve.SoGhe, ve.Xe } equals new { ghe.SoGhe, ghe.Xe }
                         join xe in qlbx.Xes on ve.Xe equals xe.MaXe
                         join khach in qlbx.Khaches on ve.MaKhach equals khach.MaKhach
                         select new VeOTA
                         {
                             MaVe = ve.MaVe,
                             NgayDat = (DateTime)ve.NgayDat,
                             TrangThai = ve.TrangThai,
                             Khach = khach.TenKhachHang,
                             SoGhe = ghe.SoGhe,
                             Xe = xe.SoXe,
                         };

            return veList.ToList();
        }
        public List<VeOTA> getList(string trangThai)
        {
            var veList = from ve in qlbx.Ves
                         join ghe in qlbx.Ghes on new { ve.SoGhe, ve.Xe } equals new { ghe.SoGhe, ghe.Xe }
                         join xe in qlbx.Xes on ve.Xe equals xe.MaXe
                         join khach in qlbx.Khaches on ve.MaKhach equals khach.MaKhach
                         where ve.TrangThai == trangThai
                         select new VeOTA
                         {
                             MaVe = ve.MaVe,
                             NgayDat = (DateTime)ve.NgayDat,
                             TrangThai = ve.TrangThai,
                             Khach = khach.TenKhachHang,
                             SoGhe = ghe.SoGhe,
                             Xe = xe.SoXe,
                         };

            return veList.ToList();
        }

        //Tạo mã tự động
        public string MaTuDong()
        {
            List<string> listMa = new List<string>();
            foreach (var item in getList())
            {
                listMa.Add(item.MaVe);
            }
            if(listMa.Count == 0)
            {
                return "VE001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "VE" + t.ToString("000");
        }
        // Thêm vé mới
        public void addVe(string maVe, string trangThai, string khach, string xe, string ghe, DateTime ngayDat)
        {
            Ve ve = new Ve();
            ve.MaVe = maVe;
            ve.TrangThai = trangThai;
            ve.MaKhach = khach;
            ve.Xe = xe;
            ve.SoGhe = ghe;
            ve.NgayDat = ngayDat;
            DALghe.uppdateTrangThai(ghe, xe, "Đã đặt");
            qlbx.Ves.InsertOnSubmit(ve);
            qlbx.SubmitChanges();
        }

        // Thêm nhiều vé
        public void addNhieuVe( string trangThai, string khach, string xe, DateTime ngayDat, int soLuong)
        {
            List<Ghe> lst = DALghe.getList(xe);
            string maVe;
            int cout = 0;
            foreach (Ghe item in lst)
            {
                maVe = MaTuDong();
                if (cout >= soLuong)
                    return;
                if(item.TrangThai == "Trống")
                {
                    addVe(maVe, trangThai, khach, xe, item.SoGhe, ngayDat);
                    cout++;
                }
            }
        }

        // Cập nhận vé
        public void uppdatVe(string maVe, string trangThai, string khach, string xe, string ghe, DateTime ngayDat)
        {
            Ve ve = qlbx.Ves.Where(kh => kh.MaVe == maVe).FirstOrDefault();
            if (ve != null)
            {
                ve.TrangThai = trangThai;
                ve.MaKhach = khach;
                ve.Xe = xe;
                ve.TrangThai = trangThai;
                ve.SoGhe = ghe;
                ve.NgayDat = ngayDat;
                if (trangThai == "Hủy thành công") 
                    DALghe.uppdateTrangThai(ghe, xe, "Trống");
                qlbx.SubmitChanges();
            }
        }
        //Xóa vé
        public void DeleteVe(string maVe)
        {
            Ve ve = qlbx.Ves.Where(v => v.MaVe == maVe).FirstOrDefault();

            if (ve != null)
            {
                qlbx.Ves.DeleteOnSubmit(ve);
                qlbx.SubmitChanges();
            }
        }
        // Lấy thông tin 1 vé
        public ThongTinVe getThongTin(string maVe)
        {
            var veList = from ve in qlbx.Ves
                         join ghe in qlbx.Ghes on new { ve.SoGhe, ve.Xe } equals new { ghe.SoGhe, ghe.Xe }
                         join xe in qlbx.Xes on ve.Xe equals xe.MaXe
                         join khach in qlbx.Khaches on ve.MaKhach equals khach.MaKhach
                         join chuyen in qlbx.Chuyens on xe.MaChuyen equals chuyen.MaChuyen
                         where ve.MaVe == maVe
                         select new ThongTinVe
                         {
                             TenKhach = khach.TenKhachHang,
                             TenChuyen = chuyen.MaChuyen,
                             TrangThai = ve.TrangThai,
                             NgayDat = ve.NgayDat,
                             TGXuatPhat = xe.TGXuatPhat,
                             TGChuyenĐi = chuyen.TGChuyen,
                             TGHuy = xe.TGHuyVe,
                             LoaiXe = xe.SoXe,
                             Gia = xe.Gia
                         };

            return veList.FirstOrDefault();
        }

        // Chấp nhận trạng thái thành đổi thành công cho tất cả
            public void UpHuyALL()
            {
                var Ves = qlbx.Ves.Where(v => v.TrangThai == "Hủy").ToList();
                foreach (Ve ve in Ves)
                {
                    DALghe.uppdateTrangThai(ve.SoGhe, ve.Xe, "Trống");
                    ve.TrangThai = "Hủy thành công";
                }
                qlbx.SubmitChanges();
            }

        // Diếm số vé của từng loại thái theo tháng
        public int countVe(string trangThai, int thang, int nam)
        {
            int dem = 0;
            var lstVe = from lstTT in qlbx.Ves select lstTT;
            if(trangThai == "Tất cả")
            {
                foreach (Ve item in lstVe)
                {
                    ThongTinVe tt = getThongTin(item.MaVe);
                    if (tt.NgayDat.Value.Month == thang && tt.NgayDat.Value.Year == nam)
                        dem++;
                }
            }
            else
            {
                foreach (Ve item in lstVe)
                {
                    ThongTinVe tt = getThongTin(item.MaVe);
                    if (tt.NgayDat.Value.Month == thang && tt.TrangThai == trangThai && tt.NgayDat.Value.Year == nam)
                        dem++;
                }
            }
            return dem;
        }
        // Xuất mảng dự liệu theo tháng
        public int[] duLieuThang(string trangThai, int nam)
        {
            int[] t = new int[12];
            for (int i = 0; i < 12; i++)
            {
                t[i] = countVe(trangThai, i+1, nam);
            }
            return t;
        }

        // Diếm số vé của từng loại thái theo tháng
        public int countDTVe(string trangThai, int thang, int nam)
        {
            int dem = 0;
            var lstVe = from lstTT in qlbx.Ves select lstTT;
            if (trangThai == "Tất cả")
            {
                foreach (Ve item in lstVe)
                {
                    ThongTinVe tt = getThongTin(item.MaVe);
                    if (tt.NgayDat.Value.Month == thang && tt.NgayDat.Value.Year == nam)
                        dem += tt.Gia ?? 0;
                }
            }
            else
            {
                foreach (Ve item in lstVe)
                {
                    ThongTinVe tt = getThongTin(item.MaVe);
                    if (tt.NgayDat.Value.Month == thang && tt.TrangThai == trangThai && tt.NgayDat.Value.Year == nam)
                        dem += tt.Gia ?? 0;
                }
            }
            return dem;
        }
        // Xuất mảng danh thu theo tháng
        public int[] duLieuDTThang(string trangThai, int nam)
        {
            int[] t = new int[12];
            for (int i = 0; i < 12; i++)
            {
                t[i] = countDTVe(trangThai, i+1, nam);
            }
            return t;
        }
    }

    public class VeOTA
    {
        public string MaVe { get; set; }
        public DateTime NgayDat { get; set; }
        public string TrangThai { get; set; }
        public string Khach { get; set; }
        public string SoGhe { get; set; }
        public string Xe { get; set; }
    }

    public class ThongTinVe
    {
        public string TenKhach { get; set; }
        public string TenChuyen { get; set; }
        public string TrangThai { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? TGXuatPhat { get; set; }
        public TimeSpan? TGChuyenĐi { get; set; }
        public TimeSpan? TGHuy { get; set; }
        public string LoaiXe { get; set; }
        public int? Gia { get; set; }
    }
}
