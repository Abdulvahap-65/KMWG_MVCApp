using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebPortalUser.Models;

namespace WebPortalUser.Context
{
    public class DataContext:DbContext
    {
        public DataContext():base("name=MySqlConnection")
        {

        }

        public DbSet<Personel> personel { get; set; }
    }
}