using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTram
    {
        QLBXDataContext qlbx = new QLBXDataContext();

        public DALTram()
        {

        }

        // Lấy danh sách trạm
        public List<TramOTA> getListTram(string maChuyen)
        {
            var tram = from lstTram in qlbx.Trams
                       join tinh in qlbx.TinhThanhs on lstTram.MaTinh equals tinh.MaTinh
                       where lstTram.Chuyen == maChuyen
                       select new TramOTA
                       {
                           MaTram = lstTram.MaTram,
                           TenTram = lstTram.TenTram,
                           Chuyen = lstTram.Chuyen,
                           Tinh = tinh.TenTinh

                       };
            return tram.ToList();
        }

        //Thêm trạm
        public void addTram(string maTram,string maChuyen, string tenTram, string maTinh)
        {
            Tram _tram = new Tram();
            _tram.MaTram = maTram;
            _tram.Chuyen = maChuyen;
            _tram.TenTram = tenTram;
            _tram.MaTinh = maTinh;
            qlbx.Trams.InsertOnSubmit(_tram);
            qlbx.SubmitChanges();
        }

        // Xóa trạm
        public void DeletteTram(string maTram)
        {
            
            Tram _tram = qlbx.Trams.Where(kh => kh.MaTram == maTram).FirstOrDefault();
            if (_tram != null)
            {
                qlbx.Trams.DeleteOnSubmit(_tram);
                qlbx.SubmitChanges();
            }
        }

        //Tạo mã tự động
        public string MaTuDong(string maChuyen)
        {
            List<string> listMa = new List<string>();
            foreach (var item in getListTram(maChuyen))
            {
                listMa.Add(item.MaTram);
            }
            if (listMa.Count == 0)
            {
                return "TM001";
            }
            string last = listMa[listMa.Count - 1].ToString();
            string str = last.Substring(last.Length - 3);
            int t = int.Parse(str) + 1;
            return "TM" + t.ToString("000");
        }
    }

    public class TramOTA
    {
        public string MaTram { get; set; }
        public string Chuyen { get; set; }
        public string TenTram { get; set; }
        public string Tinh { get; set; }
    }
}

