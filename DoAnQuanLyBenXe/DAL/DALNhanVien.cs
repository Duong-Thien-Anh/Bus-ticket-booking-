using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhanVien
    {
        QLBXDataContext qlbx = new QLBXDataContext();

        public DALNhanVien()
        {

        }

        // Lấy danh sách nhân viên
        public List<NhanVien> getListNV()
        {
            var nv = from lstNV in qlbx.NhanViens select lstNV;
            return nv.ToList();
        }

        //Kiêm tra tài khoản mật khẩu
        public NhanVien checkTK(string tk, string mk)
        {
            var nv = qlbx.NhanViens.SingleOrDefault(x => x.MaNhanVien == tk && x.MatKhau == mk);
            return nv;
        }
        // Cập nhật
        public void CapNhat(string ma, string ten, string quyen, string mk)
        {
            NhanVien t = qlbx.NhanViens.Where(x => x.MaNhanVien == ma).FirstOrDefault();
            if (t != null)
            {
                t.Quyen = quyen;
                t.MatKhau = mk;
                t.TenNhanVien = ten;
                qlbx.SubmitChanges();
            }
        }
        //Xóa
        public void Xoa(string ma)
        {
            NhanVien t = qlbx.NhanViens.Where(kh => kh.MaNhanVien == ma).FirstOrDefault();

            if (t != null)
            {
                qlbx.NhanViens.DeleteOnSubmit(t);
                qlbx.SubmitChanges();
            }
        }

        //Thêm
        public void Them(string ma, string ten, string quyen, string mk)
        {
            NhanVien t = new NhanVien();
            t.MaNhanVien = ma;
            t.TenNhanVien = ten;
            t.Quyen = quyen;
            t.MatKhau = mk;
            qlbx.NhanViens.InsertOnSubmit(t);
            qlbx.SubmitChanges();
        }

        //Tạo mã tự động
        public string MaTuDong()
        {
            List<string> listMa = new List<string>();
            foreach (var item in getListNV())
            {
                listMa.Add(item.MaNhanVien);
            }
            if (listMa.Count == 0)
            {
                return "NV001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "NV" + t.ToString("000");
        }

    }
}
