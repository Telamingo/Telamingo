using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Telamingo.BusinessLogic.Identity.VerifyToken;

namespace Telamingo.AdminPanel.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly IVerifyTokenService verifyTokenService;

        public DashboardModel(IVerifyTokenService verifyTokenService)
        {
            this.verifyTokenService = verifyTokenService;
        }
        public void OnGet()
        {
            ClaimsPrincipal? claims = verifyTokenService.VerifyToken(Request.Headers["Authentication"]);

            if (claims == null)
            {
                RedirectToAction("Sign_in");
            }
            int? adminId = Convert.ToInt32(claims.Claims.Where(x => x.Type == "AdminId").Select(x => x.Value).FirstOrDefault());
            if (adminId == null)
            {
                RedirectToAction("Sign_in");
            }


        }
    }
}
