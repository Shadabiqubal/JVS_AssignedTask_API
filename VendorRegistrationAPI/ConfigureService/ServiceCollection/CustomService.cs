using DataAccessLibrary.DataAccessLayer.Repository.IRepositories;
using DataAccessLibrary.DataAccessLayer.Repository.Repositories;
using DataAccessLibrary.DataAccessLayer.Service.IServices;
using DataAccessLibrary.DataAccessLayer.Service.Services;

namespace VendorRegistrationAPI.ConfigureService.ServiceCollection
{
    public class CustomService : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IVendorRepository, VendorRepository>();
            services.AddScoped<IVendorService, VendorService>();

            services.AddScoped<IMasterRepository, MasterRepository>();
            services.AddScoped<IMasterService, MasterService>();

            services.AddMemoryCache();
        }
    }
}
