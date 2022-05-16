using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;
using Telamingo.BusinessLogic.UserService;
using Telamingo.Domain.AggregateModels.UserAggregate;
using Telamingo.Domain.Dtos.User;

namespace Telamingo.AdminPanel.Pages
{
    public class UserAnswersModel : PageModel
    {
        public List<UserListDto> Result { get; set; } = new List<UserListDto>();

        private readonly IUserService userService;

        public UserAnswersModel(IUserService userService)
        {
            this.userService = userService;
        }
        public async Task OnGet()
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

            List<UserInformation> model  = await userService.GetUserList();
            foreach (var item in model)
            {
                UserListDto result = new();
                result.Id = item.Id;
                result.Name = item.Name;
                Result.Add(result);
            }
        }
    }
}
