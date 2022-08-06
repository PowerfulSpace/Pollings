namespace PS.PollingSystem.Web.Definitions.Base
{
    public abstract class AppDefinitions : IAppDefinitions
    {
        public virtual void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {

        }
        public virtual void ConfigureApplication(WebApplication app, IWebHostEnvironment environment)
        {

        }
    }
}
