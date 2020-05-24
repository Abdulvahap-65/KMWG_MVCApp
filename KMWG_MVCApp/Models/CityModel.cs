using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace KMWG_MVCApp.Models
{
    public class CityModel
    {
        public string Name { get; set; }
        public string CountryName { get; set; }
        public capitalEnum Capital { get; set; }
        public int PlateNumber { get; set; }
        public int Population { get; set; }
        public int ZipCode { get; set; }
    }
   // (int) CapitalEnum.Yes

    public enum capitalEnum
    {
        Yes = 1,
        No = 0,
    }
}

