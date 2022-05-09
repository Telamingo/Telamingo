using BusinessLogic.CountryService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Telamingo.ReactJs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICountryService countryService;

        public HomeController(ICountryService countryService)
        {
            this.countryService = countryService;
        }

        [HttpGet]
        [Route("Countrys")]
        public async Task<ActionResult> GetCountrys()
        {
            var country = await countryService.GetAllAsync();

            return Ok(country);
        }
    }
}
