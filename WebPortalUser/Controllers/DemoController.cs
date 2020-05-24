using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPortalUser.Context;
using WebPortalUser.Models;

namespace WebPortalUser.Controllers
{
    public class DemoController : Controller
    {

        DataContext dataContext = new DataContext();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Personel(Personel person)
        {
            return View(dataContext.personel.ToList());
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult create(Personel personel)
        {
            dataContext.personel.Add(personel);
            dataContext.SaveChanges();
            return View();
        }
    }
}