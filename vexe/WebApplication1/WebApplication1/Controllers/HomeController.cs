using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        QLBenXeEntities db = new QLBenXeEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public List<TinhThanh> DanhSachTinhThanh()
        {
            List<TinhThanh> danhsachTinhThanh = db.TinhThanhs.ToList();
            return danhsachTinhThanh;
        }
        public string TimTinh(string id)
        { 
            var tinh = db.TinhThanhs
                .Where(x => x.MaTinh == id).FirstOrDefault();
            return tinh.TenTinh.ToString();
        }
        public string GetHangXe(string id)
        {
            var xe = db.Xes.Where(x => x.MaChuyen == id).FirstOrDefault();
            var hangxe = db.HangXes.Where(d => d.MaHangXe == xe.MaHangXe).FirstOrDefault();
            return hangxe.TenHangXe.ToString();
        }
        public ActionResult TimChuyenXe(string DiemBatDau, string DiemDen, DateTime? date) 
        {

            if (!string.IsNullOrEmpty(DiemBatDau) && !string.IsNullOrEmpty(DiemDen) && date.HasValue)
            {
                // Thực hiện truy vấn để tìm chuyến xe

                // Thực hiện truy vấn để tìm chuyến xe
                List<Chuyen> listChuyen = new List<Chuyen>();
                listChuyen = db.Chuyens
                    .Where(x => x.DiemBatDau == DiemBatDau && x.DiemDen == DiemDen).ToList();
                if (listChuyen != null)
                {
                    foreach (Chuyen item in listChuyen)
                    {
                        var xe = db.Xes
                           .Where(d => d.MaChuyen == item.MaChuyen && d.TGXuatPhat == date).ToList();
                        if (xe != null)
                        {
                            // Truyền thông tin tìm kiếm đúng tới view
                            // Trả về kết quả tìm kiếm
                            ViewBag.DiemBatDau = TimTinh(DiemBatDau);
                            ViewBag.DiemDen = TimTinh(DiemDen);
                            ViewBag.Ngay = date.Value.Date;
                            return View("TimChuyenXe", listChuyen);
                        }
                    }
                }
            }
            // Nếu tìm kiếm không thấy, trả về view tìm kiếm
            else
            {
                ViewBag.DiemBatDau = TimTinh(DiemBatDau);
                ViewBag.DiemDen = TimTinh(DiemDen);
                ViewBag.Ngay = date.Value.Date;
                return View("TimChuyenXe");
            }
            ViewBag.DiemBatDau = TimTinh(DiemBatDau);
            ViewBag.DiemDen = TimTinh(DiemDen);
            ViewBag.Ngay = date.Value.Date;
            return View();
        }
        public ActionResult AboutUs() 
        {
            return View();
        }
    }
}