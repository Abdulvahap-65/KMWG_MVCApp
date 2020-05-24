using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPortalUser.Context;
using WebPortalUser.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        DataContext dataContext = new DataContext();
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonelEkle(Personel personel)
        {
            dataContext.personel.Add(personel);
            dataContext.SaveChanges();
            return RedirectToAction("Personel","Home");
        }
        public ActionResult Personel(Personel person)
        {
            return View(dataContext.personel.ToList());
        }


    }
}