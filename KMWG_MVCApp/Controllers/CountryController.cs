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
    public class CountryController : Controller
    {
        #region Kurulum(BİLMEME GEREK YOK)
        CrmSdkService _crmSdkService = CrmSdkService.GetService();
        XrmServiceContext _xrmContext = null;
        MyDBEntities db;
        public CountryController()
        {
            db = new MyDBEntities();
            if (_crmSdkService != null)
                _xrmContext = new XrmServiceContext(_crmSdkService.OrganizationService);
        }

        #endregion
        // GET: Country
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveCountry(CountryModel countrymodel)
        {
            AddCountry(countrymodel);
            return RedirectToAction("Index");
        }

        private void AddCountry(CountryModel countrymodel)
        {

            Entity entity = new Entity("uzm_country");
            entity["uzm_name"] = countrymodel.Name != null ? countrymodel.Name : "";
            entity["uzm_continent"] = countrymodel.Name != null ? countrymodel.Name : "";
            entity["uzm_hemisphere"] = countrymodel.Hemisphere != null ? countrymodel.Hemisphere : "";
            if (countrymodel.Nationality != null)
                entity["uzm_isnationality"] = new OptionSetValue((int)countrymodel.Nationality);
            entity["uzm_phonecode"] = countrymodel.PhoneCode != null ? countrymodel.PhoneCode : "";
            if (countrymodel.Population != null)
                entity["uzm_population"] = countrymodel.Population;
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