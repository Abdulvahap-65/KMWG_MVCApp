using KMWG_MVCApp.DB;
using KMWG_MVCApp.Models;
using KMWG_MVCApp.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KMWG_MVCApp.Controllers
{
    public class BayramController : Controller
    {

        CrmSdkService _crmSdkService = CrmSdkService.GetService();
        XrmServiceContext _xrmContext = null;
        MyDBEntities db;

        public BayramController()
        {
            db = new MyDBEntities();
            if (_crmSdkService != null)
                _xrmContext = new XrmServiceContext(_crmSdkService.OrganizationService);

        }

        public ActionResult Index()
        {
            List<SelectListItem> IcerikTurListe = (from k in _xrmContext.uzm_citySet
                                                   select new SelectListItem
                                                   {
                                                       Text = k.uzm_name,
                                                       Value = k.Id.ToString()
                                                   }).ToList();
            ViewBag.Liste = IcerikTurListe;
            return View();
        }
    }
}