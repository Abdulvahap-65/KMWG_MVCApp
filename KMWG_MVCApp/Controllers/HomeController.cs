using KMWG_MVCApp.DB;
using KMWG_MVCApp.Models;
using KMWG_MVCApp.Scripts;
using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;
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
            var user =
                _xrmContext.uzm_portaluserSet
                .Where(u => u.Id == id)
                .FirstOrDefault();
            return View(user);
        }

        public ActionResult DeleteUser(Guid id)
        {
            uzm_portaluser movie = _xrmContext.uzm_portaluserSet.Where(u => u.Id == id).FirstOrDefault();
            if (movie != null)
            {
                _xrmContext.DeleteObject(movie); ;
                SaveChangesResultCollection result = _xrmContext.SaveChanges();
            }
            return RedirectToAction("TumListe");
        }
        public ActionResult GetCountyAll(Guid UpdateTargetId)
        {
            var user =
               _xrmContext.uzm_portaluserSet
               .Where(u => u.Id == UpdateTargetId)
               .FirstOrDefault();
            return View(user);
        }

        public ActionResult UpdateUser(Guid id)
        {
            uzm_portaluser movie = _xrmContext.uzm_portaluserSet.Where(u => u.Id == id).FirstOrDefault();
            if (movie != null)
            {
                _xrmContext.DeleteObject(movie); ;
                SaveChangesResultCollection result = _xrmContext.SaveChanges();
            }
            return RedirectToAction("TumListe");
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

        [HttpGet]
        public ActionResult ShowDiscrit(Guid cityId)
        {
            var resList = _xrmContext.uzm_countySet.Where(c => c.uzm_cityid.Id == cityId).ToList();
            ViewBag.Test = resList;
            return View(resList);
        }

        public ActionResult UlkeIlIlceTum()
        {
            List<uzm_country> countryList = (from k in _xrmContext.uzm_countrySet
                                             select new uzm_country
                                             {
                                                 uzm_name = k.uzm_name,
                                                 uzm_countryId = k.uzm_countryId
                                             }
        ).ToList();
            foreach (uzm_country contry in countryList)
            {
                Guid countryid = contry.uzm_countryId.Value;
            }
            ViewBag.CountryList = new SelectList(countryList, "uzm_countryId", "uzm_name");
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
            List<uzm_country> countryList = (from k in _xrmContext.uzm_countrySet
                                             select new uzm_country
                                             {
                                                 uzm_name = k.uzm_name,
                                                 uzm_countryId = k.uzm_countryId
                                             }
      ).ToList();

            ViewBag.CountryList = new SelectList(countryList, "uzm_countryId", "uzm_name");

            List<uzm_company> companyList = (from I in _xrmContext.uzm_companySet
                                             select new uzm_company
                                             {
                                                 uzm_name = I.uzm_name,
                                                 uzm_companyId = I.uzm_companyId
                                             }
    ).ToList();
            ViewBag.CompanyList = new SelectList(companyList, "uzm_companyId", "uzm_name");


            List<uzm_incident> incidentList = (from i in _xrmContext.uzm_incidentSet
                                               select new uzm_incident
                                               {
                                                   uzm_name = i.uzm_name,
                                                   uzm_incidentId = i.uzm_incidentId
                                               }
 ).ToList();

            ViewBag.IncidentList = new SelectList(incidentList, "uzm_incidentId", "uzm_name");

            List<uzm_category> categorytList = (from i in _xrmContext.uzm_categorySet
                                                select new uzm_category
                                                {
                                                    uzm_name = i.uzm_name,
                                                    uzm_categoryId = i.uzm_categoryId
                                                }
 ).ToList();
            ViewBag.CategoryList = new SelectList(categorytList, "uzm_categoryId", "uzm_name");
            return View();
        }

        public ActionResult TumListe()
        {
            List<uzm_portaluser> tumListe = _xrmContext.uzm_portaluserSet.ToList();
            return View(tumListe);
        }

        [HttpPost]

        public ActionResult GetCity(Guid? countryId)
        {
            List<uzm_city> countryList = _xrmContext.uzm_citySet.Where(c => c.uzm_countryid.Id == countryId).ToList();
            return Json(countryList);
        }
        public ActionResult GetCounty(Guid? cityId)
        {
            //var tekCity = _xrmContext.uzm_citySet.Where(c => c.uzm_cityId == cityId).FirstOrDefault();
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
            Guid CountryId = new Guid(usermodel.CountryId);
            Guid CityId = new Guid(usermodel.CityId);
            Guid CountyId = new Guid(usermodel.CountyId);
            Guid CompanyId = new Guid(usermodel.CompanyId);
            Guid IncidentId = new Guid(usermodel.IncidentId);
            Guid CategoryId = new Guid(usermodel.CategoryId);
            Entity entity = new Entity("uzm_portaluser");
            if (CityId != null)
                entity["uzm_countryid"] = new EntityReference("uzm_country", CountryId);

            if (CountryId != null)
                entity["new_cityid"] = new EntityReference("uzm_city", CityId);
            if (CountyId != null)
                entity["new_countyid"] = new EntityReference("uzm_county", CountyId);
            if (CompanyId != null)
                entity["uzm_companyid"] = new EntityReference("uzm_company", CompanyId);
            if (IncidentId != null)
                entity["uzm_incidentid"] = new EntityReference("uzm_incident", IncidentId);
            if (CategoryId != null)
                entity["uzm_categoryid"] = new EntityReference("uzm_category", CategoryId);

            if (usermodel.BDate != null)
            {
                entity["uzm_bdate"] = usermodel.BDate;
            }
            if (usermodel.Cinsiyet != null)
                entity["uzm_iscinsiyet"] = new OptionSetValue((int)usermodel.Cinsiyet);
            //if (usermodel.Country != null)
            //    entity["uzm_iscountry"] = new OptionSetValue((int)usermodel.Country);
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