using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDichVu
    {
        QLBXDataContext qlbx = new QLBXDataContext();

        public DALDichVu() { }
        // lấy danh sách dịch vụ
        public List<DichVu> getList()
        {
            var dv = from lst in qlbx.DichVus select lst;
            if (dv.Count() > 0)
                return dv.ToList();
            return null;
        }

        // Lấy danh sách dịch vu theo maXe
        public List<DichVu> getList(string maXe)
        {
            var listdv = from dv in qlbx.DichVus
                         join ct in qlbx.CTDichVus on dv.MaDV equals ct.MaDV
                         join xe in qlbx.Xes on ct.Xe equals xe.MaXe
                         where xe.MaXe == maXe
                         select dv;

            return listdv.ToList();
        }

        // Xóa danh sách dịch vụ theo mã xe
        public void deleteCTAllDV(string maXe)
        {
            var dv = qlbx.CTDichVus.Where(ct => ct.Xe == maXe).ToList();
            qlbx.CTDichVus.DeleteAllOnSubmit(dv);
            qlbx.SubmitChanges();
        }

        // Cập nhật
        public void CapNhat(string ma, string ten)
        {
            DichVu t = qlbx.DichVus.Where(x => x.MaDV == ma).FirstOrDefault();
            if (t != null)
            {
                t.TenDV = ten;
                qlbx.SubmitChanges();
            }
        }
        //Xóa
        public void Xoa(string ma)
        {
            DichVu t = qlbx.DichVus.Where(kh => kh.MaDV == ma).FirstOrDefault();

            if (t != null)
            {
                qlbx.DichVus.DeleteOnSubmit(t);
                qlbx.SubmitChanges();
            }
        }

        //Xóa
        public void XoaKhoiXe(string maXe, string maDV)
        {
            CTDichVu t = qlbx.CTDichVus.Where(kh => kh.MaDV == maDV && kh.Xe == maXe).FirstOrDefault();

            if (t != null)
            {
                qlbx.CTDichVus.DeleteOnSubmit(t);
                qlbx.SubmitChanges();
            }
        }

        //Thêm
        public void Them(string ma, string ten)
        {
            DichVu t = new DichVu();
            t.MaDV = ma;
            t.TenDV = ten;
            qlbx.DichVus.InsertOnSubmit(t);
            qlbx.SubmitChanges();
        }

        // Thêm vào 1 xe
        public int ThemVaoXe(string maXe, string maDV)
        {
            CTDichVu t = new CTDichVu();
            t.MaDV = maDV;
            t.Xe = maXe;
            try
            {
                qlbx.CTDichVus.InsertOnSubmit(t);
                qlbx.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }


        //Tạo mã tự động
        public string MaTuDong()
        {
            List<string> listMa = new List<string>();
            foreach (var item in getList())
            {
                listMa.Add(item.MaDV);
            }
            if (listMa.Count == 0)
            {
                return "DV001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "DV" + t.ToString("000");
        }
    }
}
