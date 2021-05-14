using kiemtra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kiemtra.Controllers
{
    public class ThuongHieuController : Controller
    {
        WebProgramming_HTAEntities db = new WebProgramming_HTAEntities();
        // GET: ThuongHieu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ThuongHieu th)
        {
            
            db.ThuongHieux.Add(th);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}