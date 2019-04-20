using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class WebController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Web
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult GopY()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GopY([Bind(Include = "id,tenKH,email,tieuDe,noiDung")] GopY gopY)
        {
            if (ModelState.IsValid)
            {
                db.GopYs.Add(gopY);
                db.SaveChanges();
            }

            return View(gopY);
        }
    }
}