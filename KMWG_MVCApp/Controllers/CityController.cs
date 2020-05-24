using KMWG_MVCApp.DB;
using KMWG_MVCApp.Models;
using KMWG_MVCApp.Scripts;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace KMWG_MVCApp.Controllers
{
    public class CityController : Controller
    {

        #region Kurulum(BİLMEME GEREK YOK)
        CrmSdkService _crmSdkService = CrmSdkService.GetService();
        XrmServiceContext _xrmContext = null;
        MyDBEntities db;
        public CityController()
        {
            db = new MyDBEntities();
            if (_crmSdkService != null)
                _xrmContext = new XrmServiceContext(_crmSdkService.OrganizationService);
        }

        #endregion
        // GET: City

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveCity(CityModel citymodel)
        {
            AddCity(citymodel);
            return RedirectToAction("Index");
        }



        public void AddCity(CityModel citymodel)
        {
            Entity entity = new Entity("uzm_city");
            entity["uzm_name"] = citymodel.Name != null ? citymodel.Name : "";
            entity["uzm_countryname"] = citymodel.CountryName != null ? citymodel.CountryName : "";




            if (citymodel.Capital != 0)
            {
                entity["uzm_iscapital"] =citymodel.Capital;
            }
           
            entity["uzm_platenumber"] = citymodel.PlateNumber != 1 ? citymodel.PlateNumber : 0;
            entity["uzm_population"] = citymodel.Population != 1 ? citymodel.Population : 0;
            entity["uzm_zipcode"] = citymodel.ZipCode != 1 ? citymodel.ZipCode : 0;



            //entity["uzm_name"] = citymodel.Name;
            //entity["uzm_countryname"] = citymodel.CountryName;
            //entity["uzm_iscapital"] = (new OptionSetValue((int)citymodel.Capital));
            //entity["uzm_platenumber"] = citymodel.PlateNumber;
            //entity["uzm_population"] = citymodel.Population;
            //entity["uzm_zipcode"] = citymodel.ZipCode;
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


    }
}