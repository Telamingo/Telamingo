using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.BusinessLogic.AdminService;
using Telamingo.Domain.Dtos.AdminDtos;

namespace Telamingo.AdminPanel.Pages
{
    public class Sign_inModel : PageModel
    {
        public void OnGet()
        {
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
                HttpContext.Response.Headers.Add("Authentication", $"{token}");
                RedirectToAction("Dashboard");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
