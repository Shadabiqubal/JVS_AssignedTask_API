using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary.DataAccessLayer.DBContext
{
    public class VendorDbContext:DbContext
    {
        public VendorDbContext(DbContextOptions<VendorDbContext> options) :base(options)
        {
            
        }

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorType> VendorTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }

        

    }
}
