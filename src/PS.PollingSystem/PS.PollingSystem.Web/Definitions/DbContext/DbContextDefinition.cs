using Microsoft.EntityFrameworkCore;
using PS.PollingSystem.Application;
using PS.PollingSystem.Web.Definitions.Base;

namespace PS.PollingSystem.Web.Definitions.DbContext
{
    public class DbContextDefinition : AppDefinitions

    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(nameof(ApplicationDbContext)));
            });
        }
    }
}
