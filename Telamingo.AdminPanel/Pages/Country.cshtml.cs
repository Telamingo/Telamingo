using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.BusinessLogic.CountryService;
using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.AdminPanel.Pages
{


    public class CountryModel : PageModel
    {
        private readonly ICountryService countryService;

        public CountryModel(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        public async Task<List<Country>> OnGet()
        {
            return await countryService.GetAllAsync();
        }
    }
}
