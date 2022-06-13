using KiemTra_NguyenLyHoangThien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra_NguyenLyHoangThien.Controllers
{
    public class HomeController : Controller
    {
        TestContext context = new TestContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HocPhan()
        {
            var all_hp = from tt in context.HocPhans select tt;
            return View(all_hp);
        }

        public ActionResult DangKy()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}