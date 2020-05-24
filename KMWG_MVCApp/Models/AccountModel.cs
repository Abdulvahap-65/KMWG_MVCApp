using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMWG_MVCApp.Models
{
    public class AccountModel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public int NumberofEmployees{ get; set; }
        public string Telephone { get; set; }
        public string Websiteurl { get; set; }
    }
}