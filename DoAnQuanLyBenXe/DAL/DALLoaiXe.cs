using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLoaiXe
    {
        QLBXDataContext qlbx = new QLBXDataContext();

        public DALLoaiXe() { }

        // Lấy danh sách hãng xe
        public List<LoaiXe> getList()
        {
            var loaiXe = from lst in qlbx.LoaiXes select lst;
            return loaiXe.ToList();
        }

        // Lấy số lượng
        public int getSoGhe(string maLoaiXe)
        {
            var loaiXe = qlbx.LoaiXes.FirstOrDefault(lx => lx.MaLoaiXe == maLoaiXe);
            return loaiXe?.SoGhe ?? 0;
        }

        // Cập nhật
        public void CapNhat(string ma, string ten, int soGhe)
        {
            LoaiXe t = qlbx.LoaiXes.Where(x => x.MaLoaiXe == ma).FirstOrDefault();
            if (t != null)
            {
                t.TenLoaiXe = ten;
                t.SoGhe = soGhe;
                qlbx.SubmitChanges();
            }
        }
        //Xóa
        public void Xoa(string ma)
        {
            LoaiXe t = qlbx.LoaiXes.Where(kh => kh.MaLoaiXe == ma).FirstOrDefault();

            if (t != null)
            {
                qlbx.LoaiXes.DeleteOnSubmit(t);
                qlbx.SubmitChanges();
            }
        }

        //Thêm
        public void Them(string ma, string ten, int soGhe)
        {
            LoaiXe t = new LoaiXe();
            t.MaLoaiXe = ma;
            t.TenLoaiXe = ten;
            t.SoGhe = soGhe;
            qlbx.LoaiXes.InsertOnSubmit(t);
            qlbx.SubmitChanges();
        }

        //Tạo mã tự động
        public string MaTuDong()
        {
            List<string> listMa = new List<string>();
            foreach (var item in getList())
            {
                listMa.Add(item.MaLoaiXe);
            }
            if (listMa.Count == 0)
            {
                return "LX001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "LX" + t.ToString("000");
        }
    }
}
