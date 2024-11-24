using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.DBContext
{
    public class ErrorHandlingDbContext : DbContext
    {
        public ErrorHandlingDbContext(DbContextOptions<ErrorHandlingDbContext> options) : base(options)
        {
            
        }

        public DbSet<ErrorLog> ErrorLogs { get; set; }
    }
}
