using kiemtra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace kiemtra.Controllers
{
    public class HomeController : Controller
    {
        WebProgramming_HTAEntities db = new WebProgramming_HTAEntities();
        // GET: Home
        public ActionResult Index()
        {
            var listItem = db.DienThoais.Where(x=>x.SPMoi==true).ToList();
            return View(listItem);
        }
        public ActionResult Sanpham(int id)
        {
            var sp = db.DienThoais.Where(n => n.MaThuongHieu == id).Where(y=>y.SPMoi==true).ToList();
            
            return View(sp);
        }
        public ActionResult ChiTietSanpham(int idpro)
        {
            var spdetail = db.DienThoais.Find(idpro);

            return View(spdetail);
        }
        public ActionResult Create()
        {
            ViewBag.MaThuongHieu = new SelectList(db.ThuongHieux, "MaThuongHieu", "TenThuongHieu");
            return View();
        }
        [HttpPost]
        public ActionResult Create(DienThoai dt)
        {
            
            db.DienThoais.Add(dt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}