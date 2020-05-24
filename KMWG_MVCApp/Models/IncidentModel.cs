using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMWG_MVCApp.Models
{
    public class IncidentModel
    {
        //public int ID { get; set; }
        public string FirstName{ get; set; }
        public string Surname { get; set; }
        public string Subject{ get; set; }
       //public string Country{ get; set; }
       public country1 Country { get; set; }
    }

    public enum country1
    {
        None = 0,
        Turkey = 1,
        Canada= 2,
        USA = 3,
        UK = 4,
        Italy = 5,
        Others=6,
    }
}