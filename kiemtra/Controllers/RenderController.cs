using kiemtra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kiemtra.Controllers
{
    public class RenderController : Controller
    {
        WebProgramming_HTAEntities db = new WebProgramming_HTAEntities();
        // GET: Render
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadMenu()
        {
            var listmenu = db.ThuongHieux.ToList();
            ViewBag.listMenu = listmenu;
            return PartialView("~/Views/Shared/Left.cshtml");
        }
    }
}