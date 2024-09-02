using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ChuyenXeController : Controller
    {
        QLBenXeEntities db = new QLBenXeEntities();
        // GET: ChuyenXe
        public ActionResult Index()
        {
            return View();
        }
        public string SwitchToVND(int value) {
            string switched = value.ToString("#,##0") + "VNĐ";
            return switched;
        }
        public string GetHangXe(string id)
        {
            var xe = db.Xes.Where(x => x.MaXe == id).FirstOrDefault();
            var hangxe = db.HangXes.Where(d => d.MaHangXe == xe.MaHangXe).FirstOrDefault();
            return hangxe.TenHangXe.ToString();
        }
        public string GetLoaiXe(string id)
        {
            var loaixe = db.LoaiXes.Where(d => d.MaLoaiXe == id).FirstOrDefault();
            return loaixe.TenLoaiXe.ToString();
        }
        public ActionResult GetXeWithChuyen(string id, DateTime? date)
        {
            List<Xe> xes = db.Xes.Where(x => x.MaChuyen == id && x.TGXuatPhat == date).ToList();
            if (xes != null)
            {
                return View(xes);
            }
            else
            {
                ViewBag.NotFound = "Không có xe của hãng còn chỗ trong chuyến này. Xin vui lòng chọn chuyến khác";
                return View();
            }
        }
        public string GetSoXe(string idxe)
        {
            Xe xe = db.Xes.Where(x => x.MaXe == idxe).FirstOrDefault();
            return xe.SoXe;
        }
        public ActionResult Confirm(Ve ve)
        {
            ve.TrangThai = "Đã đặt";
            var ghe = db.Ghes.Where(x => x.SoGhe == ve.SoGhe && x.Xe == ve.Xe).FirstOrDefault();
            if (ghe == null)
            {
                Ghe newghe = new Ghe
                {
                    SoGhe = ve.SoGhe,
                    TrangThai = ve.TrangThai,
                    Xe = ve.Xe
                };
                db.Ghes.Add(newghe);
                db.SaveChanges();
            }
            else 
            {
                if (ghe.TrangThai == "Trống")
                {
                    ghe.TrangThai = "Đã đặt";
                    db.SaveChanges();
                }
                
            }
            db.Ves.Add(ve);
            db.SaveChanges();
            ViewBag.OrderSucess = "Đặt vé thành công";
            return RedirectToAction("TicketInf","LogIn");
        }
        public ActionResult XacNhanVe(string idxe)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "LogIn");
            }
            else 
            {
                var xe = db.Xes.Where(x => x.MaXe == idxe).FirstOrDefault();
                ViewBag.GiaVe = SwitchToVND((int)xe.Gia);
                Ve ve = new Ve
                {
                    MaVe = generateVexe(),
                    NgayDat = DateTime.Today,
                    TrangThai = "Chờ xác nhận",
                    MaKhach = Session["UserId"].ToString(),
                    SoGhe = generateSoghe(idxe),
                    Xe = idxe
                };
                return View(ve);
            }
        }
        public string generateSoghe(string id)
        {
            var listghe = db.Ghes.Where(x => x.Xe == id).ToList();
            string soghe;

            if (listghe.Count == 0)
            {
                return "01";
            }
            var ghe = db.Ghes.Where(x => x.Xe == id && x.TrangThai == "Trống").ToList();
            if (ghe.Count != 0)
            {
                soghe = ghe[0].SoGhe;
                return soghe;
            }
            else
            {
                var maxghe = listghe.Max(x => x.SoGhe);
                int number = int.Parse(maxghe) + 1;
                soghe = $"{number:D2}";
                return soghe;
            }
        }

        public string generateVexe()
        {
            var maxve = db.Ves.Max(x => x.MaVe);


            if (string.IsNullOrEmpty(maxve))
            {
                return "VE001";
            }

            string prefix = maxve.Substring(0, 2);
            int number = int.Parse(maxve.Substring(2)) + 1;

            return $"{prefix}{number:D3}";
        }

        public int GetGheTrong(string idxe)
        {
            var xe = db.Xes.Where(x => x.MaXe == idxe).FirstOrDefault();
            if (xe != null)
            {
                var loaixe = db.LoaiXes.Where(x => x.MaLoaiXe == xe.LoaiXe).FirstOrDefault();
                if (loaixe != null)
                {
                    int soghe = (int)loaixe.SoGhe;
                    var dadat = db.Ghes.Where(x => x.Xe == idxe && x.TrangThai == "Đã đặt").ToList();
                    if (dadat != null)
                    {
                        return soghe - dadat.Count();
                    }
                    else 
                    { 
                        return soghe; 
                    }
                }
            }
            return 0;
        }
    }
}