using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TaiKhoanController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var result = from user in db.Users
                         from role in db.Roles
                         where role.Users.Any(r => r.UserId == user.Id)
                         select new UserWithRole
                         {
                             fname = user.UserName,
                             rname = role.Name
                         };

            return View(result);
        }

    }
}