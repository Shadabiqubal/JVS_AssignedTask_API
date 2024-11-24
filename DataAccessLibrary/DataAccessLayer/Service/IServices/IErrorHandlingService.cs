using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Service.IServices
{
    public interface IErrorHandlingService
    {
        void LogError(ErrorLog errorLog);
    }
}
