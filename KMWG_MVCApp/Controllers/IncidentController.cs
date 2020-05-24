
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
    public class IncidentController : Controller

    {
        #region Kurulum(BİLMEME GEREK YOK)
        CrmSdkService _crmSdkService = CrmSdkService.GetService();
        XrmServiceContext _xrmContext = null;
        MyDBEntities db;
        public IncidentController()
        {
            db = new MyDBEntities();
            if (_crmSdkService != null)
                _xrmContext = new XrmServiceContext(_crmSdkService.OrganizationService);
        }

        #endregion
        // GET: Incident
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveIncident(IncidentModel incidentmodel)
        {
            AddIncident(incidentmodel);
            return RedirectToAction("Index");
        }
        public void AddIncident(IncidentModel incidentmodel)
        {
            Entity entity = new Entity("uzm_incident");
            entity["uzm_name"] = incidentmodel.FirstName != null ? incidentmodel.FirstName : "";
            entity["uzm_surname"] = incidentmodel.Surname != null ? incidentmodel.Surname : "";
            entity["uzm_iscountry"] = (new OptionSetValue((int)incidentmodel.Country)) != null ? (new OptionSetValue((int)incidentmodel.Country)) : null;//???dene
            entity["uzm_subject"] = incidentmodel.Subject != null ? incidentmodel.Subject : "";
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