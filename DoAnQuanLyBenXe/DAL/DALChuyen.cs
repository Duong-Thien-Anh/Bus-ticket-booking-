using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALChuyen
    {
        QLBXDataContext qlbx = new QLBXDataContext();
        DALXe DALxe = new DALXe();

        public DALChuyen()
        {

        }

        // Lấy danh sách nhân viên
        public List<ChuyenPKTinhThanh> getListChuyen()
        {
            var chuyenList = from chuyen in qlbx.Chuyens
                             join diemBatDau in qlbx.TinhThanhs on chuyen.DiemBatDau equals diemBatDau.MaTinh
                             join diemDen in qlbx.TinhThanhs on chuyen.DiemDen equals diemDen.MaTinh
                             select new ChuyenPKTinhThanh
                             {
                                 MaChuyen = chuyen.MaChuyen,
                                 TenChuyen = chuyen.TenChuyen,
                                 DiemBatDau = diemBatDau.TenTinh,
                                 DiemDen = diemDen.TenTinh,
                                 TgChuyen = (TimeSpan)chuyen.TGChuyen
                             };

            return chuyenList.ToList();
        }

        // Cập nhật chuyến
        public void UppdateChuyen(string maChuyen, TimeSpan tgDi)
        {
            Chuyen chuyen = qlbx.Chuyens.Where(kh => kh.MaChuyen == maChuyen).FirstOrDefault();
            if (chuyen != null)
            {
                //qlbx.Chuyens.DeleteOnSubmit(chuyen);
                //qlbx.SubmitChanges();
                chuyen.TGChuyen = tgDi;
                qlbx.SubmitChanges();
            }
        }
        //Xóa chuyến
        public void XoaChuyen(string maChuyen)
        {
            Chuyen chuyen = qlbx.Chuyens.Where(kh => kh.MaChuyen == maChuyen).FirstOrDefault();

            if (chuyen != null)
            {
                var xes = qlbx.Xes.Where(x => x.MaChuyen == chuyen.MaChuyen).ToList();
                foreach (Xe xe in xes)
                {
                    DALxe.DeleteXe(xe.MaXe);
                }
                qlbx.Chuyens.DeleteOnSubmit(chuyen);
                qlbx.SubmitChanges();
            }
        }

        //Tạo mã tự động
        public string MaTuDong()
        {
            List<string> listMa = new List<string>();
            foreach (var item in getListChuyen())
            {
                listMa.Add(item.MaChuyen);
            }
            if (listMa.Count == 0)
            {
                return "CH001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "CH" + t.ToString("000");
        }

        //Thêm chuyến
        public void addChuyen(string maChuyen,string tenChuyen, string diemDi, string diemDen , TimeSpan tgđi)
        {
            Chuyen _chuyen = new Chuyen();
            _chuyen.MaChuyen = maChuyen;
            _chuyen.TenChuyen = tenChuyen;
            _chuyen.DiemBatDau = diemDi;
            _chuyen.DiemDen = diemDen;
            _chuyen.TGChuyen = tgđi;
            qlbx.Chuyens.InsertOnSubmit(_chuyen);
            qlbx.SubmitChanges();
        }
        
        //Kiểm tra chuyến đã tồn tại
        public bool CheckChuyen(string tenChuyen)
        {
            Chuyen chuyen = qlbx.Chuyens.Where(kh => kh.TenChuyen == tenChuyen).FirstOrDefault();
            if( chuyen == null)
                return false;
            return true;
        }

    }

    

    public class ChuyenPKTinhThanh
    {
        public string MaChuyen { get; set; }
        public string TenChuyen { get; set; }
        public string DiemBatDau { get; set; }
        public string DiemDen { get; set; }
        public TimeSpan TgChuyen { get; set; }
        // Thêm các trường khác nếu cần
    }
}
