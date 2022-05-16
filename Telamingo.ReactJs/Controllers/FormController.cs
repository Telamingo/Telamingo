using BusinessLogic.FormAnswer;
using Domain.AggregateModels.UserAggregate;
using Domain.Dtos.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Linq;

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
        public async Task<ActionResult> UserAnwer([FromBody]dynamic model)
        {
            try
            {
                string s = Convert.ToString(model);

                string w = s.Remove(1, 17);
                string k = w.Remove((w.Length - 2), 1);

                var options = new JsonSerializerOptions { IncludeFields = true };
                UserAnswerDto? answer = System.Text.Json.JsonSerializer.Deserialize<UserAnswerDto>(k, options);

                answer.MostImportants.FirstProblem = "-";
                answer.MostImportants.SecendProblem = "-";

                await answerService.AddAsync(answer);
                return Ok();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
