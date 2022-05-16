using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.BusinessLogic.UserService;
using Telamingo.Domain.AggregateModels.UserAggregate;

namespace Telamingo.AdminPanel.Pages
{
    public class UserAnswerModel : PageModel
    {
        public UserAnswer Result { get; set; } = new UserAnswer();

        private readonly IUserService userService;

        public UserAnswerModel(IUserService userService)
        {
            this.userService = userService;
        }
        //public async Task<List<Country>> OnGet()
        public async Task OnGet(int Id)
        {
            Result = await userService.GetUserAnswer(Id);
        }
    }
}
