namespace VendorRegistrationAPI.ConfigureService.ServiceCollection
{
    public interface IServiceInstaller
    {
        void Install(IServiceCollection services, IConfiguration configuration);
    }
}
