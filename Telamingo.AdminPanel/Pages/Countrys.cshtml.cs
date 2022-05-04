using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Telamingo.BusinessLogic.CountryService;
using Telamingo.BusinessLogic.Identity.VerifyToken;
using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.AdminPanel.Pages
{
    public class CountrysModel : PageModel
    {
        public List<CountryListDto> Result { get; set; } = new List<CountryListDto>();


        private readonly IVerifyTokenService verifyTokenService;
        private readonly ICountryService countryService;

        public CountrysModel(ICountryService countryService,
            IVerifyTokenService verifyTokenService)
        {
            this.countryService = countryService;
            this.verifyTokenService = verifyTokenService;
        }
        public async Task OnGet()
        {
            //ClaimsPrincipal? claims = verifyTokenService.VerifyToken(Request.Headers["Authentication"]);

            //if (claims == null)
            //{
            //    RedirectToAction("Sign_in");
            //}
            //int? adminId = Convert.ToInt32(claims.Claims.Where(x => x.Type == "AdminId").Select(x => x.Value).FirstOrDefault());
            //if (adminId == null)
            //{
            //    RedirectToAction("Sign_in");
            //}

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

            List<Country> country = await countryService.GetAllAsync();
            foreach (var item in country)
            {
                CountryListDto result = new();
                result.Id = country.First().Id;
                result.Name = country.First().Name;
                Result.Add(result);
            }
        }
        //public async Task OnPost(int Id)
        //{
        //    string? authentication = Request.Headers["Authentication"];

        //    string? token = HttpContext.Request.Cookies["Authentication"];
        //    if (string.IsNullOrEmpty(token))
        //    {
        //        RedirectToAction("Sign_in");
        //    }

        //    var handler = new JwtSecurityTokenHandler();
        //    var jwtToken = handler.ReadJwtToken(token);

        //    var adminId = jwtToken.Claims.Where(x => x.Type == "AdminId").First().Value;
        //    if (adminId == null)
        //    {
        //        RedirectToAction("Sign_in");
        //    }

        //    List<Country> country = await countryService.GetAllAsync();
        //    foreach (var item in country)
        //    {
        //        CountryListDto result = new();
        //        result.Id = country.First().Id;
        //        result.Name = country.First().Name;
        //        Result.Add(result);
        //    }
        //}
    }
}
