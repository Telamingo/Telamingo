using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using Telamingo.BusinessLogic.AdminService;
using Telamingo.BusinessLogic.Identity.VerifyToken;
using Telamingo.Domain.Dtos.AdminDtos;

namespace Telamingo.AdminPanel.Pages
{
    [Authorize(Policy = "Jwt")]
    [AllowAnonymous]
    public class Sign_inModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Sign_inModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet([FromServices] IVerifyTokenService verifyTokenService)
        {
            string? authentication = Request.Headers["Authentication"];
            string? token = HttpContext.Request.Cookies["Authentication"];
            if (!string.IsNullOrEmpty(token))
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(token);

                var adminId = jwtToken.Claims.Where(x => x.Type == "AdminId").First().Value;
                if (adminId != null)
                {
                    Response.Redirect("./Dashboard");
                }
            }


            if (authentication != null)
            {
                ClaimsPrincipal? claims = verifyTokenService.VerifyToken(authentication);

                if (claims != null)
                {
                    int? adminId = Convert.ToInt32(claims.Claims.Where(x => x.Type == "AdminId").Select(x => x.Value).FirstOrDefault());
                    if (adminId != null)
                    {
                        Response.Redirect("./Dashboard");
                    }
                }

            }

        }
        public async Task OnPost([FromServices] IAdminService adminService, AdminDto model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.UserName))
                {
                    throw new Exception("UserName was null");
                }
                if (string.IsNullOrWhiteSpace(model.Password))
                {
                    throw new Exception("Password was null");
                }
                string token = await adminService.AdminLogin(model);


                Response.Headers.Add("Authentication", $"{token}");

                HttpContext.Response.Cookies.Append("Authentication", $"{token}",
                    new CookieOptions { Expires = DateTime.Now.AddDays(1) });

                Response.Redirect("./Dashboard");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
