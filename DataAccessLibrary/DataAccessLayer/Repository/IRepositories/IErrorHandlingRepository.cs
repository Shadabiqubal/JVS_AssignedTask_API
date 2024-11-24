using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Repository.IRepositories
{
    public interface IErrorHandlingRepository
    {
        void LogError(ErrorLog errorLog);
    }
}
