
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
            ////CRM'de nationalities varlığından nationality name çekme
            //List<uzm_nationality> NationalityList = _xrmContext.uzm_nationalitySet.ToList();
            //uzm_nationality ulus = NationalityList.Where(i => i.uzm_name == "British").FirstOrDefault();
            //Guid ulusid = ulus.uzm_nationalityId.Value;

            //List<uzm_customer> CustomerList = _xrmContext.uzm_customerSet.ToList();
            //uzm_customer Customer = new uzm_customer();
            //Console.WriteLine(ulusid);
            //Customer.uzm_nationalityid = new EntityReference("uzm_nationality", ulusid);//Xrm.Shemada  nationality lookup setleme





            return Json(countyList);
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

        #region -NOT:C# null controlers-
        #region -1.Date_Time-
        //public DateTime? CreatedOn { get; set; }//Modelde olacak.
        /* if(countrymodel.CreatedOn != null)
           {
               entity["createdon"] = countrymodel.CreatedOn;
           }*///Conroler'da olacak.
        #endregion
        #region -2.Option Setleme-
        // public nationalityEnum? Nationality { get; set; }//Modelde oacak.
        /* public enum nationalityEnum
         {
             American = 1,
             Turkish = 2,
             French = 3,
             British = 4,
             Others = 5
         }*/
        //if (countrymodel.Nationality != null)
        //      entity["uzm_isnationality"] = new OptionSetValue((int) countrymodel.Nationality);
        //Controler tarafında olacak
        #endregion
        #region -3.Int-
        //public int? Population { get; set; }//model tarafında olacak.

        //  if (countrymodel.Population != null)
        //            entity["uzm_population"] = countrymodel.Population;//Controler tarafında olacak.

        #endregion
        #endregion
        public void AddPortalUser(UserModel usermodel)
        {
            Entity entity = new Entity("uzm_portaluser");

            entity["uzm_bdate"] = usermodel.BDate;
            entity["uzm_iscinsiyet"] = new OptionSetValue((int)usermodel.Cinsiyet);
            entity["uzm_iscountry"] = new OptionSetValue((int)usermodel.Country);
            entity["uzm_password"] = usermodel.Password;
            entity["uzm_subject"] = usermodel.Konu;
            entity["uzm_username"] = usermodel.Name;
            entity["uzm_weight"] = usermodel.Kilo;
            entity["uzm_name"] = usermodel.Name;
            //entity["new_cityid"] = new EntityReference("new_cityid", usermodel.CityId.Value);

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




