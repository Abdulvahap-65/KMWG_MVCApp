using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebPortalUser.Models;

namespace WebPortalUser.Controllers
{
    public class DenemeController : Controller
    {
        // GET: Deneme
        public ActionResult Index()
        {

            DenemeModel m1 = new DenemeModel();
            m1.Title = "Hello MVC";
            m1.BDate = DateTime.Today;
            m1.Items = new List<string>();
            m1.Items.Add("Bu bir anasafadır");
            m1.Items.Add("Home Controller içersindeki Index Action.");
            m1.Items.Add("Bu sayfa bir model ile dolmaktadır.");
            return View(m1);
        }

        public ActionResult Profile(int id)
        {
            DenemeModel user = new DenemeModel()
            {
                BDate = new DateTime(1992, 08, 30),
                Cinsiyet = cinsiyet.Erkek,
                Id = id,
                Kilo = 72,
                Name = "Fatih GÜRDAL",
                Password = "123456",
                UserName = "fatihgurdal",
            };
            user.Address.Add("Kocaeli Gölcük");
            user.Address.Add("Trabzon Merkez");
            user.Address.Add("İstanbul Kadıköy");
            user.UserGroup = new DenemeGroupModel()
            {
                Id = 1,
                Name = "Admin"
            };
            user.UserGroup = new DenemeGroupModel()
            {
                Id = 2,
                Name = "Editor"
            };
            user.UserGroup = new DenemeGroupModel()
            {
                Id = 3,
                Name = "User"
            };
            user.UserGroup = new DenemeGroupModel()
            {
                Id = 4,
                Name = "SystemAdmin"
            };


            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem()
            {
                Value = "1",
                Text = "Admin"
            });
            list.Add(new SelectListItem()
            {
                Value = "2",
                Text = "Editor"
            });
            list.Add(new SelectListItem()
            {
                Value = "3",
                Text = "User"
            });
            list.Add(new SelectListItem()
            {
                Value = "4",
                Text = "SystemAdmin"
            });
            //ViewData["KullaniciGruplari"] = list;
            ViewBag.KullaniciGruplari = list;
            TempData["KullaniciGruplari"] = list;

            return View(user);
        }


    }
}