using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALGhe
    {
        QLBXDataContext qlbx = new QLBXDataContext();

        public DALGhe() { }
        // Lấy danh sách ghế của 1 xe
        public List<Ghe> getList(string maXe)
        {
            var ghe = from lst in qlbx.Ghes.Where(gh => gh.Xe == maXe) select lst;
            if (ghe.Count() > 0)
                return ghe.ToList();
            return null;
        }

        // Lấy danh sách ghế của 1 xe và trang thái
        public List<Ghe> getList(string maXe, string trangThai)
        {
            var ghe = from lst in qlbx.Ghes.Where(gh => gh.Xe == maXe && gh.TrangThai == trangThai) select lst;
            if (ghe.Count() > 0)
                return ghe.ToList();
            return null;
        }

        // Tạo 1 ghế
        public void CreateGhe(string soGhe, string maXe)
        {
            Ghe ghe = new Ghe()
            {
                SoGhe = soGhe,
                TrangThai = "Trống",
                Xe = maXe
            };
            qlbx.Ghes.InsertOnSubmit(ghe);
            qlbx.SubmitChanges();
        }

        //Xóa tất cả ghế của mã xe
        public void deleteALLGhe(string maXe)
        {
            var ghes = qlbx.Ghes.Where(gh => gh.Xe == maXe).ToList();
            foreach (Ghe gh in ghes)
            {
                var ves = qlbx.Ves.Where(v => v.SoGhe == gh.SoGhe && v.Xe == gh.Xe).ToList();
                qlbx.Ves.DeleteAllOnSubmit(ves);

                qlbx.Ghes.DeleteOnSubmit(gh);
                qlbx.SubmitChanges();
            }
        }

        // Cập nhật trạng thái
        public void uppdateTrangThai(string SoGhe,string maXe, string trangThai)
        {
            var ghe = qlbx.Ghes.FirstOrDefault(gh => gh.SoGhe == SoGhe && gh.Xe == maXe);
            if(ghe != null)
            {
                ghe.TrangThai = trangThai;
                qlbx.SubmitChanges();
            }

        }
    }
}
