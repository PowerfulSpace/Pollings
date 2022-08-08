using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PS.PollingSystem.Web.Pages.Admin
{
    [Authorize]
    public class LogoutModel : PageModel
    {
        private readonly ILogger<LogoutModel> _logger;

        public LogoutModel(ILogger<LogoutModel> logger) => _logger = logger;


        public async Task<IActionResult> OnPost(string? returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            await HttpContext.SignOutAsync();
            _logger.LogInformation("User logger out.");
            if (returnUrl != null) { return LocalRedirect(returnUrl); }

            return RedirectToPage();
        }
    }
}
