using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using DataAccessLibrary.DataAccessLayer.Repository.IRepositories;
using DataAccessLibrary.DataAccessLayer.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccessLayer.Service.Services
{
    public class ErrorHandlingService:IErrorHandlingService
    {
        private readonly IErrorHandlingRepository _errorHandlingRepository;

        public ErrorHandlingService(IErrorHandlingRepository errorHandling)
        {
            _errorHandlingRepository = errorHandling;   
        }
        public void LogError(ErrorLog errorLog)
        {
            _errorHandlingRepository.LogError(errorLog);


        }
    }
}
