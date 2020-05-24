using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KMWG_MVCApp.DB;
using KMWG_MVCApp.Scripts;
using KMWG_MVCApp.Models;
using Microsoft.Xrm.Sdk;

namespace KMWG_MVCApp.Controllers
{
    public class Deneme1Controller : Controller
    {


        #region Kurulum(BİLMEME GEREK YOK)
        CrmSdkService _crmSdkService = CrmSdkService.GetService();
        XrmServiceContext _xrmContext = null;
        MyDBEntities db;
        public Deneme1Controller()
        {
            db = new MyDBEntities();
            if (_crmSdkService != null)
                _xrmContext = new XrmServiceContext(_crmSdkService.OrganizationService);
        }

        #endregion
        // GET: Deneme1
        public ActionResult Index()
        {
            //veritabanımızdan instance alıyoruz.
           // NORTHWNDEntities db = new NORTHWNDEntities();
           Entity entity = new Entity("uzm_category");
            //bir list oluştuyoruz selectlistitem tipi alacak
            ////CRM'de nationalities varlığından nationality name çekme
           
            List<uzm_category> ProductList = _xrmContext.uzm_categorySet.ToList();
            
            List<SelectListItem> kategoriler = new List<SelectListItem>();
            //foreach ile db.Categories deki kategorileri listemize ekliyoruz
            foreach (var item in ProductList)
            {   //Text = Görünen kısımdır. Kategori ismini yazdıyoruz
                //Value = Değer kısmıdır.ID değerini atıyoruz
                kategoriler.Add(new SelectListItem { Text = item.uzm_name, Value = item.uzm_categoryId.ToString() });
            }
            //Dinamik bir yapı oluşturup kategoriler list mizi view mize göndereceğiz
            //bunun için viewbag kullanıyorum
            ViewBag.Kategoriler = kategoriler;



            return View();
        }
    }
}