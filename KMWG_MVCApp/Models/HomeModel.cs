using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMWG_MVCApp.Models
{
    public class HomeModel
    {
        //Bu bir anasayfa modeli olsun.Bu modelde title,maddeler, tarih vb olabilir.
        public string Title { get; set; }
        public List<string> Items { get; set; }
        public DateTime Date { get; set; }
        public cinsiyet Cinsiyet { get; set; }
        public country Country{ get; set; }
        public UserGroupModel UserGroup { get; set; }

    }
}