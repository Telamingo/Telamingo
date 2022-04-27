using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.BusinessLogic.CountryService;
using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.AdminPanel.Pages
{


    public class CountryModel : PageModel
    {
        public AddCountryDto Result { get; set; } = new AddCountryDto();

        private readonly ICountryService countryService;

        public CountryModel(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        //public async Task<List<Country>> OnGet()
        public async Task OnGet(int Id)
        {
            Country country = await countryService.GetAsync(Id);
            this.Result.Id = country.Id;
            this.Result.CountryName = country.Name;
            this.Result.Cultural.Id = country.culturalInformation.FirstOrDefault().Id;

            foreach (var item in country.culturalInformation.FirstOrDefault().culturalClimateInformation)
            {
                this.Result.Cultural.CulturalClimate.Add(new CulturalClimateDto(item , item.Climate));
            }
            foreach (var item in country.culturalInformation.FirstOrDefault().culturalweatherInformation)
            {

            }
        }
    }
}
