using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Telamingo.BusinessLogic.CountryService;
using Telamingo.BusinessLogic.Identity.VerifyToken;
using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.AdminPanel.Pages
{
    public class CountrysModel : PageModel
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public List<AddCountryDto> Result { get; set; }


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

            List<Country> country = await countryService.GetAllAsync();
            this.Id = country.FirstOrDefault().Id;
            this.CountryName = country.FirstOrDefault().Name;
        }
    }
}
