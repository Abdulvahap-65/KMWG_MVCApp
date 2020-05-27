
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

        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Details(Guid id)
        {
            var user = _xrmContext.uzm_portaluserSet.Where(u => u.Id == id).FirstOrDefault();

            return View(user);
        }

        [HttpPost]
        public ActionResult Login(UserLogin loginModel)
        {
            var user = _xrmContext.uzm_portaluserSet.Where(u => u.uzm_username == loginModel.UserName && u.uzm_password == loginModel.Password).FirstOrDefault();
            if (user != null)
            {
                Session["UserInfo"] = user.uzm_username;
                return RedirectToAction("TumListe");
            }

            else
                return RedirectToAction("Error");
        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult Exit()
        {
            return RedirectToAction("Login");
        }

        #endregion

        [HttpPost]
        public ActionResult SaveUser(UserModel usermodel)
        {
            AddPortalUser(usermodel);
            return RedirectToAction("TumListe");
        }

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            #region -Alıştırma-
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
            #endregion


            List<uzm_city> cityList = (from k in _xrmContext.uzm_citySet
                                       select new uzm_city
                                       {
                                           uzm_name = k.uzm_name,
                                           uzm_cityId = k.uzm_cityId
                                       }
        ).ToList();

            foreach (uzm_city cid in cityList)
            {
                Guid cityid = cid.uzm_cityId.Value;


            }
            ViewBag.CityList = new SelectList(cityList, "uzm_cityId", "uzm_name");

            return View();
        }
        public ActionResult TumListe()
        {
            List<uzm_portaluser> tumListe = _xrmContext.uzm_portaluserSet.ToList();
            return View(tumListe);
        }

        [HttpPost]
        public ActionResult GetCounty(Guid? cityId)
        {
            var tekCity = _xrmContext.uzm_citySet.Where(c => c.uzm_cityId == cityId).FirstOrDefault();

            List<uzm_county> countyList = _xrmContext.uzm_countySet.Where(x => x.uzm_cityid.Id == cityId).ToList();
            return Json(countyList);
        }

        #region -DB'ye Ekleme-
        //public ActionResult Index(DB.User user, DB.Addresses addresses, DB.UserGroup userGroup)
        //{
        //    db.User.Add(user);
        //    db.Addresses.Add(addresses);
        //    db.UserGroup.Add(userGroup);
        //    db.SaveChanges();
        //    return View();
        //}

        #endregion

       
        [HttpPost]
        public void AddPortalUser(UserModel usermodel)
        {
            Guid CityId = new Guid(usermodel.CityId);
            Entity entity = new Entity("uzm_portaluser");
            Entity cityEntity = new Entity("uzm_city");
            if (CityId != null)
                entity["new_cityid"] = new EntityReference("uzm_city", CityId);
   
            if (usermodel.BDate != null)
            {
                entity["uzm_bdate"] = usermodel.BDate;
            }
            if (usermodel.Cinsiyet != null)
                entity["uzm_iscinsiyet"] = new OptionSetValue((int)usermodel.Cinsiyet);
            if (usermodel.Country != null)
                entity["uzm_iscountry"] = new OptionSetValue((int)usermodel.Country);
            entity["uzm_password"] = usermodel.Password != null ? usermodel.Password : "";
            entity["uzm_subject"] = usermodel.Konu != null ? usermodel.Konu : "";
            if (usermodel.Kilo != null)
                entity["uzm_weight"] = usermodel.Kilo;
            entity["uzm_name"] = usermodel.Name != null ? usermodel.Name : "";
            entity["uzm_username"] = usermodel.UserName != null ? usermodel.UserName : "";


            var id = SaveToCrm(entity);

            if (id != null)
            {
                RedirectToAction("TumListe");
            }
            else
                RedirectToAction("Error");
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


    }

}




