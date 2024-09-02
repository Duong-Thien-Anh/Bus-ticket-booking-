using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTinhThanh
    {
        QLBXDataContext qlbx = new QLBXDataContext();

        public DALTinhThanh()
        {

        }

        // Lấy danh sách tỉnh thành
        public List<TinhThanh> getListTT()
        {
            var tt = from lstTT in qlbx.TinhThanhs select lstTT;
            return tt.ToList();
        }
        // Cập nhật
        public void CapNhat(string ma, string ten)
        {
            TinhThanh t = qlbx.TinhThanhs.Where(x => x.MaTinh == ma).FirstOrDefault();
            if (t != null)
            {
                t.TenTinh = ten;
                qlbx.SubmitChanges();
            }
        }
        //Xóa
        public void Xoa(string ma)
        {
            TinhThanh t = qlbx.TinhThanhs.Where(kh => kh.MaTinh == ma).FirstOrDefault();

            if (t != null)
            {
                qlbx.TinhThanhs.DeleteOnSubmit(t);
                qlbx.SubmitChanges();
            }
        }

        //Thêm
        public void Them(string ma, string ten)
        {
            TinhThanh t = new TinhThanh();
            t.MaTinh = ma;
            t.TenTinh = ten;
            qlbx.TinhThanhs.InsertOnSubmit(t);
            qlbx.SubmitChanges();
        }

        //Tạo mã tự động
        public string MaTuDong()
        {
            List<string> listMa = new List<string>();
            foreach (var item in getListTT())
            {
                listMa.Add(item.MaTinh);
            }
            if (listMa.Count == 0)
            {
                return "TT001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "TT" + t.ToString("000");
        }
    }
}
