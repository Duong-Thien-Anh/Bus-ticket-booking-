using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALKhach
    {
        QLBXDataContext qlbx = new QLBXDataContext();
        public DALKhach() { }

        // Lấy danh sách
        public List<Khach> getList()
        {
            var khach = from lstTram in qlbx.Khaches select lstTram;
            return khach.ToList();
        }
        // Cập nhật
        public void CapNhat(string ma, string ten, string cccd, int tuoi, string sdt, string tk, string mk )
        {
            Khach t = qlbx.Khaches.Where(x => x.MaKhach == ma).FirstOrDefault();
            if (t != null)
            {
                t.CCCD = cccd;
                t.Tuoi = tuoi;
                t.SDT = sdt;
                t.TaiKhoan = tk;
                t.MK = mk;
                t.TenKhachHang = ten;
                qlbx.SubmitChanges();
            }
        }
        //Xóa
        public void Xoa(string ma)
        {
            Khach t = qlbx.Khaches.Where(kh => kh.MaKhach == ma).FirstOrDefault();

            if (t != null)
            {
                qlbx.Khaches.DeleteOnSubmit(t);
                qlbx.SubmitChanges();
            }
        }

        //Thêm
        public void them(string ma, string ten, string cccd, int tuoi, string sdt, string tk, string mk)
        {
            Khach t = new Khach();
            t.MaKhach = ma;
            t.CCCD = cccd;
            t.Tuoi = tuoi;
            t.SDT = sdt;
            t.TaiKhoan = tk;
            t.MK = mk;
            t.TenKhachHang = ten;
            qlbx.Khaches.InsertOnSubmit(t);
            qlbx.SubmitChanges();
        }

        //Tạo mã tự động
        public string MaTuDong()
        {
            List<string> listMa = new List<string>();
            foreach (var item in getList())
            {
                listMa.Add(item.MaKhach);
            }
            if (listMa.Count == 0)
            {
                return "KH001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "KH" + t.ToString("000");
        }
    }
}
