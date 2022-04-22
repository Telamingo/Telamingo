using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Telamingo.BusinessLogic.Identity.VerifyToken;

namespace Telamingo.AdminPanel.Pages
{
    //[Authorize(Policy = "Jwt")]
    public class DashboardModel : PageModel
    {
        private readonly IVerifyTokenService verifyTokenService;

        public DashboardModel(IVerifyTokenService verifyTokenService)
        {
            this.verifyTokenService = verifyTokenService;
        }
        public void OnGet()
        {
            string? authentication = Request.Headers["Authentication"];

            string? token = HttpContext.Request.Cookies["Authentication"];
            if (string.IsNullOrEmpty(token))
            {
                RedirectToAction("Sign_in");
            }

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            var adminId = jwtToken.Claims.Where(x => x.Type == "AdminId").First().Value;
            if (adminId == null)
            {
                RedirectToAction("Sign_in");
            }

            //if (authentication != null)
            //{
            //    ClaimsPrincipal? claims = verifyTokenService.VerifyToken(authentication);

            //    if (claims == null)
            //    {
            //        RedirectToAction("Sign_in");
            //    }
            //    int? adminId = Convert.ToInt32(claims.Claims.Where(x => x.Type == "AdminId").Select(x => x.Value).FirstOrDefault());
            //    if (adminId == null)
            //    {
            //        RedirectToAction("Sign_in");
            //    }
            //}

        }
    }
}
