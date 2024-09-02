using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHangXe
    {
        QLBXDataContext qlbx = new QLBXDataContext();

        public DALHangXe() { }

        // Lấy danh sách hãng xe
        public List<HangXe> getList()
        {
            var hangXe = from lst in qlbx.HangXes select lst;
            return hangXe.ToList();
        }

        // Cập nhật
        public void CapNhat(string ma, string ten)
        {
            HangXe t = qlbx.HangXes.Where(x => x.MaHangXe == ma).FirstOrDefault();
            if (t != null)
            {
                t.TenHangXe = ten;
                qlbx.SubmitChanges();
            }
        }
        //Xóa
        public void Xoa(string ma)
        {
            HangXe t = qlbx.HangXes.Where(kh => kh.MaHangXe == ma).FirstOrDefault();

            if (t != null)
            {
                qlbx.HangXes.DeleteOnSubmit(t);
                qlbx.SubmitChanges();
            }
        }

        //Thêm
        public void Them(string ma, string ten)
        {
            HangXe t = new HangXe();
            t.MaHangXe = ma;
            t.TenHangXe = ten;
            qlbx.HangXes.InsertOnSubmit(t);
            qlbx.SubmitChanges();
        }

        //Tạo mã tự động
        public string MaTuDong()
        {
            List<string> listMa = new List<string>();
            foreach (var item in getList())
            {
                listMa.Add(item.MaHangXe);
            }
            if (listMa.Count == 0)
            {
                return "HX001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "HX" + t.ToString("000");
        }
    }
}
