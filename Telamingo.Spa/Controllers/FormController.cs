using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Telamingo.Spa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        public FormController()
        {

        }

        [HttpGet]
        [Route("Questions")]
        public async Task<ActionResult> GetQuestions()
        {

            return Ok();
        }
    }
}
