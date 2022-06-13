using KiemTra_NguyenLyHoangThien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra_NguyenLyHoangThien.Controllers
{
    public class DangNhapController : Controller
    {
        // GET: DangNhap
        TestContext context = new TestContext();
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var tendangnhap = collection["MaSV"];
            SinhVien sv = context.SinhViens.SingleOrDefault(n => n.MaSV == tendangnhap);
            if(sv == null)
            {
                ViewBag.ThongBao = "Đăng nhập thành công";
                Session["MaSV"] = sv;
            }
            else
            {
                ViewBag.ThongBao = "Không tìm thấy mã số sinh viên";
            }
            return RedirectToAction("Index", "Home");
        }

    }
}