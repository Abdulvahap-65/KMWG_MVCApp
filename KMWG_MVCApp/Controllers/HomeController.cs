
using KMWG_MVCApp.DB;
using KMWG_MVCApp.Models;
using KMWG_MVCApp.Scripts;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KMWG_MVCApp.Controllers
{
    public class HomeController : Controller
    {
        #region Kurulum(BİLMEME GEREK YOK)
        CrmSdkService _crmSdkService = CrmSdkService.GetService();
        XrmServiceContext _xrmContext = null;
        MyDBEntities db;
        public HomeController()
        {
            db = new MyDBEntities();
            if (_crmSdkService != null)
                _xrmContext = new XrmServiceContext(_crmSdkService.OrganizationService);
        }

        #endregion

        [HttpPost]
        public ActionResult SaveUser(UserModel usermodel)
        {
            AddPortalUser(usermodel);
            return RedirectToAction("Index");
        }

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {

            //HomeModel m = new HomeModel();
            //m.Title = "Hello MVC";
            //m.Date = DateTime.Today;
            //m.Items = new List<string>();
            //m.Items.Add("Bu bir anasafadır");
            //m.Items.Add("Hoem Controller içersindeki Index Action.");
            //m.Items.Add("Bu sayfa bir model ile dolmaktadır.");
            //List<User> lastUSers = db.User.OrderByDescending(x => x.Id).Take(4).ToList();
            //ViewBag.LastUsers = lastUSers;
            //UserModel userModel = new UserModel();
            //userModel = GetCity();
            //List<uzm_city> cityList = new List<uzm_city>();
            //cityList = GetCity();

            //GetCity();
            List<City> IcerikTurListe = (from k in _xrmContext.uzm_citySet
                                                   select new City
                                                   {
                                                      Name = k.uzm_name,
                                                      Id = k.Id
                                                   }
        ).ToList();
        
            ViewBag.List = new SelectList(IcerikTurListe, "Id", "Name");
            return View();

           // return View(userModel);
        }



        [HttpPost]

        public ActionResult Index(DB.User user, DB.Addresses addresses, DB.UserGroup userGroup)
        {
            db.User.Add(user);
            db.Addresses.Add(addresses);
            db.UserGroup.Add(userGroup);
            db.SaveChanges();
            return View();
        }

        #region -Result Tiplerinde İşlenecek-
        //public FileResult Download(string adi)
        //{
        //    return File("", "");
        //}
        #endregion
        public new ActionResult Profile(int id = 10)
        {
            #region -1.Model Oluşturma-
            //UserModel user = new UserModel()
            //{
            //    BDate = new DateTime(1992, 8, 30),
            //    Cinsiyet = cinsiyet.Erkek,
            //    Country = country.Türkiye,
            //    Id = id,
            //    Kilo = 72,
            //    Name = "Fatih GÜRDAL",
            //    Password = "123456",
            //    UserName = "fatihgurdal",

            //};
            //user.Address.Add("Kocaeli Gölcük");
            //user.Address.Add("Trabzon Merkez");
            //user.Address.Add("İstanbul Kadıköy");

            //user.UserGroup = new UserGroupModel()
            //{
            //    Id = 1,
            //    Name = "Admin",
            //};

            #endregion
            DB.User user = db.User.FirstOrDefault(x => x.Id == id);

            List<SelectListItem> list = db.UserGroup.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();

            TempData["KullaniciGruplari"] = list;

            List<SelectListItem> item8 = new List<SelectListItem>();
            item8.Add(new SelectListItem
            {
                Text = "USA",
                Value = "1"
            });
            ViewBag.country = item8;

            ViewBag.LastUsers = db.User.OrderByDescending(x => x.Id).Take(4).ToList();

            return View(user);
        }

        public void AddPortalUser(UserModel usermodel)
        {
            Entity entity = new Entity("uzm_portaluser");
            entity["uzm_username"] = usermodel.UserName;
            entity["uzm_bdate"] = usermodel.BDate;
            entity["uzm_iscinsiyet"] = new OptionSetValue((int)usermodel.Cinsiyet);
            entity["uzm_iscountry"] = new OptionSetValue((int)usermodel.Country);
            entity["uzm_name"] = usermodel.Name;
            entity["uzm_sifre"] = usermodel.Password;
            entity["uzm_subject"] = usermodel.Konu;
            entity["uzm_weight"] = usermodel.Kilo;
            entity["uzm_password"] = usermodel.Password1;
            var id = SaveToCrm(entity);
        }

        public Guid? SaveToCrm(Entity entity)
        {
            Guid? id = null;
            try
            {
                id = _crmSdkService.OrganizationService.Create(entity);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                id = null;
            }
            return id;
        }
        // List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.ToList();
        // uzm_nationality ulus = (from I in NationalityList
        //                        where I.uzm_name == wantedNationality
        //                     select I).FirstOrDefault();


        // List<uzm_city> CityList = _xrmContext.uzm_citySet.ToList();
       //// uzm_city CityName = _xrmContext.uzm_citySet.Select(x => new uzm_city()
       // {
       //     uzm_name = x.uzm_name,
       //     uzm_cityId = x.uzm_cityId
       // }).ToList();//4 tane ayrı alan döndürür.



        public List<uzm_city> GetCity()
        {
            List<uzm_city> CityList = _xrmContext.uzm_citySet.ToList();
             //// uzm_city CityName = _xrmContext.uzm_citySet.Select(x => new uzm_city()
       // {
       //     uzm_name = x.uzm_name,
       //     uzm_cityId = x.uzm_cityId
       // }).ToList();//4 tane ayrı alan döndürür.

            //List<string[]> cities = new List<string[]>();

            try
            {

                //var query = (from I  in _xrmContext.CreateQuery("uzm_city")
                //             select new string[]
                //             {
                //                 I["uzm_cityId"].ToString(),
                //                 (string)I["uzm_name"]
                //             }).ToList();
                //if (query != null && query.Count > 0)
                //    cities = query;

                List<uzm_city> CityName = _xrmContext.uzm_citySet.Select(x => new uzm_city()
                {
                    uzm_name = x.uzm_name,
                    uzm_cityId = x.uzm_cityId
                }).ToList();//4 tane ayrı alan döndürür.

                foreach (uzm_city city1 in CityName)
                {
                    Console.WriteLine("Adı:{0} Soyadı:{1} ", city1.uzm_name, city1.uzm_cityId);
                }
                if (CityName != null && CityName.Count > 0)
                    CityList = CityName;


            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
            return CityList;
        }

        //public List<string[]> GetCity()
        //{

        //    List<string[]> cities = new List<string[]>();
        //    try
        //    {

        //        var query = (from I in _xrmContext.CreateQuery("uzm_city")
        //                     select new string[]
        //                     {
        //                         I["uzm_cityId"].ToString(),
        //                         (string)I["uzm_name"]
        //                     }).ToList();
        //        if (query != null && query.Count > 0)
        //            cities = query;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex.GetBaseException();
        //    }
        //    return cities;
        //}

    }

}
// name = (c.Attributes.Contains("name")) ? c["name"].ToString() : "",
//  IsNullOrEmpty(String str)
//DateTime dat = new DateTime();
//entity["uzm_username"] = usermodel.UserName != null ? usermodel.UserName : "";NOT:C# null controler a bak:




