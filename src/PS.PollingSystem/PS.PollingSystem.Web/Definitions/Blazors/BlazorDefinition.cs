using PS.PollingSystem.Web.Definitions.Base;

namespace PS.PollingSystem.Web.Definitions.Blazors
{
    public class BlazorDefinition : AppDefinitions
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddServerSideBlazor();
        }

        public override void ConfigureApplication(WebApplication app, IWebHostEnvironment environment)
        {
            app.MapBlazorHub();
        }
    }
}
