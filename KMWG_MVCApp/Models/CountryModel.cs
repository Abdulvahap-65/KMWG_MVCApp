using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMWG_MVCApp.Models
{
    public class CountryModel
    {
        public string Name{ get; set; }
        public string Continent{ get; set; }
        public string Hemisphere{ get; set; }
        public nationalityEnum? Nationality{ get; set; }
        public string PhoneCode{ get; set; }
        public int? Population { get; set; }


    }
    public enum nationalityEnum
    {
        American = 1,
        Turkish = 2,
        French = 3,
        British = 4,
        Others = 5
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

}