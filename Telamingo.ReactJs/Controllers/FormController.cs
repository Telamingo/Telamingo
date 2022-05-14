using BusinessLogic.FormAnswer;
using Domain.AggregateModels.UserAggregate;
using Domain.Dtos.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Telamingo.ReactJs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IAnswerService answerService;
        public FormController(IAnswerService answerService)
        {
            this.answerService = answerService;
        }

        [HttpGet]
        [Route("Questions")]
        public async Task<ActionResult> GetQuestions()
        {

            return Ok();
        }
        [HttpPost]
        [Route("UserAnwer")]
        public async Task<ActionResult> UserAnwer(UserAnswerDto model)
        {
            await answerService.AddAsync(model);
            return Ok();
        }
    }
}
