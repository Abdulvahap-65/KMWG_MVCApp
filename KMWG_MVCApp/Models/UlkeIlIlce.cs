using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMWG_MVCApp.Models
{
    public class UlkeIlIlce
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string County { get; set; }
    }
}