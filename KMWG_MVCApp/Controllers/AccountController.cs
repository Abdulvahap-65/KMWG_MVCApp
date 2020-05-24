using KMWG_MVCApp.DB;
using KMWG_MVCApp.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KMWG_MVCApp.Models;
using Microsoft.Xrm.Sdk;

//using System.ComponentModel.DataAnnotations;
namespace KMWG_MVCApp.Controllers
{
    public class AccountController : Controller
    {
        #region Kurulum(BİLMEME GEREK YOK)
        CrmSdkService _crmSdkService = CrmSdkService.GetService();
        XrmServiceContext _xrmContext = null;
        MyDBEntities db;
        public AccountController()
        {
            db = new MyDBEntities();
            if (_crmSdkService != null)
                _xrmContext = new XrmServiceContext(_crmSdkService.OrganizationService);
        }

        #endregion



        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveAccount(AccountModel accountmodel)
        {
            AddAccount(accountmodel);
            return RedirectToAction("Index");
        }


        public void AddAccount(AccountModel accountmodel)
        {
            Entity entity = new Entity("uzm_account");
            entity["uzm_name"] = accountmodel.Name != null ? accountmodel.Name : "";
            entity["uzm_city"] = accountmodel.City!= null ? accountmodel.City: "";
            entity["uzm_description"] = accountmodel.Description!= null ? accountmodel.Description: "";
            entity["uzm_email"] = accountmodel.Email!= null ? accountmodel.Email: "";
            entity["uzm_fax"] = accountmodel.Fax!= null ? accountmodel.Fax: "";
            entity["uzm_numberofemployees"] = accountmodel.NumberofEmployees!= 1? accountmodel.NumberofEmployees:0;
            entity["uzm_telephone"] = accountmodel.Telephone!= null ? accountmodel.Telephone: "";
            entity["uzm_websiteurl"] = accountmodel.Websiteurl!= null ? accountmodel.Websiteurl: "";
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
