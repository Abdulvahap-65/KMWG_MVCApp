using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPortalUser.Models
{
    public class DenemeModel
    {
        public DenemeModel()
        {
            this.Address = new List<string>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public List<string> Items { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime BDate { get; set; }
        public int Kilo { get; set; }
        public List<string> Address { get; set; }
        public DenemeGroupModel UserGroup { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public cinsiyet Cinsiyet { get; set; }

    }

    public class DenemeGroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum cinsiyet
    {
        None = 0,
        Erkek = 1,
        Kadın = 2
    }
}

