using DataAccessLibrary.DataAccessLayer.DBContext;
using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using DataAccessLibrary.DataAccessLayer.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Repository.Repositories
{
    public class ErrorHandlingRepository: IErrorHandlingRepository
    {
        private readonly VendorDbContext _vendorDbContext;
        public ErrorHandlingRepository(VendorDbContext vendorDbContext)
        {
            _vendorDbContext = vendorDbContext;
        }

        public void LogError(ErrorLog errorLog)
        {
            _vendorDbContext.ErrorLogs.Add(errorLog);
            _vendorDbContext.SaveChanges();

        }

    }
}
