using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KMWG_MVCApp.Models
{
   
    public class UserModel
    {
        public UserModel()
        {
            this.Address = new List<string>();
        }
        public int Id { get; set; }
        [Display(Name="Adı Soyadı")]
        public string Name { get; set; }

        // [System.ComponentModel.DataAnnotations.DataType(DataType.Date)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name= "Doğum Tarihi")]
        
        public DateTime? BDate { get; set; }
        [Display(Name = "Kilo")]
        public int? Kilo{ get; set; }

        [Display(Name = "Adres")]
        public List<string> Address { get; set; }

        [Display(Name = "Kullanıcı Grubu")]
        public UserGroupModel UserGroup { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Cinsiyeti")]

        public cinsiyet Cinsiyet{ get; set; }

        [Display(Name = "Ülke")]
        public country Country{ get; set; }

        [Display(Name = "Subject")]
        public string Konu { get; set; }

        public string CityId { get; set; }
       // public List<string[]> Cities { get; set; }

    }
    public class UserGroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public  enum cinsiyet
    {
        None=0,
        Erkek=1,
        Kadın=2,
    }

    public enum country
    {
        None = 0,
        Türkiye= 1,
        ABD= 2,
        Kanada= 3,
        İspanya= 4,
        İngiltere= 5,
    }
    
}

//TEST

//public int? Population { get; set; }
/*
  if (countrymodel.Population != null)
            entity["uzm_population"] = countrymodel.Population;
     */
//public DateTime? CreatedOn { get; set; }
/* if(countrymodel.CreatedOn != null)
   {
       entity["createdon"] = countrymodel.CreatedOn;
   }*/
// public nationalityEnum? Nationality { get; set; }
/* public enum nationalityEnum
 {
     American = 1,
     Turkish = 2,
     French = 3,
     British = 4,
     Others = 5
 }*/
