using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;
using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.AdminPanel.Pages
{
    public class AddCountryModel : PageModel
    {
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

        }
        public void OnPost(AddCountryDto model)
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

        }
    }
}
