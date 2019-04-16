using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account objUser)
        {
            if (ModelState.IsValid)
            {
                using (WebDBContext db = new WebDBContext())
                {
                    var obj = db.Accounts.Where(a => a.id.Equals(objUser.id) && a.pass.Equals(objUser.pass)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["ID"] = obj.id.ToString();
                        return RedirectToAction("Web/Index");
                    }
                }
            }
            return View(objUser);
        }
    }
}