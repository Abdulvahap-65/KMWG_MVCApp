using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebPortalUser.Models
{
    [Table("Personel")]
    public class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Ulke { get; set; }
        public string Konu { get; set; }

    }
}