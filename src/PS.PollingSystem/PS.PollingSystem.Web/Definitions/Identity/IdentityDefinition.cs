using Microsoft.AspNetCore.Authentication.Cookies;
using PS.PollingSystem.Web.Definitions.Base;

namespace PS.PollingSystem.Web.Definitions.Identity
{
    public class IdentityDefinition : AppDefinitions
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(config =>
                {
                    config.LoginPath = "/admin/login";
                });


        }
    }
}
