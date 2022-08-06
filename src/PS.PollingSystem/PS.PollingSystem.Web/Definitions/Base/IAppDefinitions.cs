namespace PS.PollingSystem.Web.Definitions.Base
{
    public interface IAppDefinitions
    {
        void ConfigureServices(IServiceCollection services, IConfiguration configuration);
        void ConfigureApplication(WebApplication app, IWebHostEnvironment environment);
    }
}
