using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LogInController : Controller
    {
        QLBenXeEntities db = new QLBenXeEntities();
        // GET: LogIn
        public ActionResult Signin(string username, string password)
        {
            var khach = db.Khaches
                .Where(x => x.TaiKhoan == username && x.MK == password).FirstOrDefault();
            if (khach != null)
            {
                Session["UserId"] = khach.MaKhach;
                return RedirectToAction("Index", "Home", khach);
            }
            else
            {
                ViewBag.NotFound = "Không thông tin đăng nhập sai hoặc không tồn tại";
                return View("Login");
            }
        }
        public ActionResult Signup(string username, string password, string name, int tuoi, string SDT, string CCCD)
        {
            Khach khach = new Khach
            {
                MaKhach = generateMakhach(),
                CCCD = CCCD,
                TenKhachHang = name,
                Tuoi = tuoi,
                SDT = SDT,
                TaiKhoan = username,
                MK = password,
            };
            var test = db.Khaches.Where(x => x.CCCD == khach.CCCD).FirstOrDefault();
            if (test == null)
            {
                db.Khaches.Add(khach);
                db.SaveChanges();
                ViewBag.RegSuccess = "Đăng ký thành công!";
                Session["UserId"] = khach.MaKhach;
                return RedirectToAction("Index", "Home");
            }
            else 
            {
                ViewBag.RegFailed = "Thông tin đăng ký đã tồn tại!";
                return View("Login");
            }
        }

        private string generateMakhach()
        {
            // Lấy mã khách hàng lớn nhất hiện tại
            var maxMaKhach = db.Khaches.Max(kh => kh.MaKhach);

            // Nếu không có khách hàng nào trong cơ sở dữ liệu, bắt đầu từ "KH001"
            if (string.IsNullOrEmpty(maxMaKhach))
            {
                return "KH001";
            }

            // Tách phần số và tăng giá trị
            string prefix = maxMaKhach.Substring(0, 2);
            int number = int.Parse(maxMaKhach.Substring(2)) + 1;

            // Format lại mã khách hàng
            return $"{prefix}{number:D3}";
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult InfUser(string id)
        {
            var khach = db.Khaches
                .Where(x => x.MaKhach == id)
                .FirstOrDefault();
            if (khach != null)
            {
                return View(khach);
            }
            return View();
        }
        public ActionResult TicketInf()
        {
            var id = Session["UserId"];
            List<Ve> listve = new List<Ve>();
            listve = db.Ves
                .Where(x => x.MaKhach == id.ToString()).ToList();
            if (listve != null)
            {
                return View(listve);
            }
            else 
            {
                ViewBag.EmptyVe = "Bạn chưa có vé đã đặt";
                return View();
            }
        }
        public ActionResult Comment()
        {
            return View();
        }
        public ActionResult HuyVe(string idve)
        { 
            var ve = db.Ves.Where(x => x.MaVe == idve)
                .FirstOrDefault();
            if (ve != null)
            {
                var ghe = db.Ghes.Where(x => x.SoGhe == ve.SoGhe).FirstOrDefault();
                ghe.TrangThai = "Trống";
                ve.TrangThai = "Đã Hủy";
                db.SaveChanges();
                ViewBag.CancelSuccess = "Vé đã được hủy!";
            }
            else {
                ViewBag.TicketNotFound = "Không tìm thấy vé yêu cầu hủy!";
            }

            return RedirectToAction("TicketInf", "LogIn", Session["UserId"].ToString());
        }
        public ActionResult Logout() 
        {
            Session["UserId"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}