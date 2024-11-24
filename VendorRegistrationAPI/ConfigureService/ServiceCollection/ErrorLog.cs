using DataAccessLibrary.DataAccessLayer.DBContext;
using DataAccessLibrary.DataAccessLayer.Repository.IRepositories;
using DataAccessLibrary.DataAccessLayer.Repository.Repositories;
using DataAccessLibrary.DataAccessLayer.Service.IServices;
using DataAccessLibrary.DataAccessLayer.Service.Services;
using VendorRegistrationAPI.Middlewares;

namespace VendorRegistrationAPI.ConfigureService.ServiceCollection
{
    public class ErrorLog : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ErrorHandlingDbContext>();
            services.AddTransient<IErrorHandlingService, ErrorHandlingService>();
            services.AddTransient<IErrorHandlingRepository, ErrorHandlingRepository>();
            services.AddTransient<GlobalErrorHandlingMiddleware>();
        }
    }
}
