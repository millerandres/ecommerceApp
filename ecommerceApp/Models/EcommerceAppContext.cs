using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ecommerceApp.Models
{
    public class EcommerceAppContext : DbContext
    {
        public EcommerceAppContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<ecommerceApp.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ecommerceApp.Models.City> Cities { get; set; }
    }
}