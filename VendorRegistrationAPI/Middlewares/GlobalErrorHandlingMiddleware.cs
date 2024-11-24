
using DataAccessLibrary.DataAccessLayer.Model.ServiceModels;
using DataAccessLibrary.DataAccessLayer.Service.IServices;
using DataAccessLibrary.DataAccessLayer.Service.Services;

namespace VendorRegistrationAPI.Middlewares
{
    public class GlobalErrorHandlingMiddleware : IMiddleware
    {
        private readonly IErrorHandlingService _errorHandlingService;

        public GlobalErrorHandlingMiddleware(IErrorHandlingService errorHandlingService)
        {
            _errorHandlingService = errorHandlingService;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                ErrorLog errorHandling = new ErrorLog()
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    CreatedDate = DateTime.Now,
                };

                _errorHandlingService.LogError(errorHandling);


            }

        }
    }
}
