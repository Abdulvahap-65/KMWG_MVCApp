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
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        
        public DateTime? BDate { get; set; }
       
        public int? Kilo{ get; set; }

        public List<string> Address { get; set; }

        public UserGroupModel UserGroup { get; set; }

        public string Password { get; set; }
        public cinsiyet Cinsiyet{ get; set; }

        public country Country{ get; set; }

        public string Konu { get; set; }

        public Guid? CityId { get; set; }

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