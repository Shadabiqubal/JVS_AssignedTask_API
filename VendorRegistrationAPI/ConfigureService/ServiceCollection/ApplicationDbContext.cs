using DataAccessLibrary.DataAccessLayer.DBContext;
using Microsoft.EntityFrameworkCore;

namespace VendorRegistrationAPI.ConfigureService.ServiceCollection
{
    public class ApplicationDbContext : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnStr");
            services.AddDbContext<VendorDbContext>(options => options.UseSqlServer(connectionString));
            services.AddDbContext<ErrorHandlingDbContext>(options => options.UseSqlServer(connectionString));

        }
    }
}
