using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.BusinessLogic.CountryService;
using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.AdminPanel.Pages
{
    public class EditeCountryModel : PageModel
    {
        public AddCountryDto Result { get; set; } = new AddCountryDto();

        private readonly ICountryService countryService;

        public EditeCountryModel(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        //public async Task<List<Country>> OnGet()
        public async Task OnGet(int Id)
        {
            Country country = await countryService.GetAsync(Id);
            this.Result.Id = country.Id;
            this.Result.CountryName = country.Name;
            this.Result.Cultural.Id = country.culturalInformation.First().Id;


            foreach (var item in country.culturalInformation.First().culturalClimateInformation)
            {
                this.Result.Cultural.CulturalClimate.Add(new CulturalClimateDto(item, item.Climate));
            }
            foreach (var item in country.culturalInformation.First().culturalweatherInformation)
            {
                this.Result.Cultural.CulturalWeather.Add(new CulturalWeatherDto(item, item.Weather));
            }


            this.Result.PhysicalHealth.Id = country.PhysicalHealthInformation.First().Id;
            this.Result.PhysicalHealth.StatusOfTheTreatmentSystemForSpecificDiseases =
                country.PhysicalHealthInformation.First().StatusOfTheTreatmentSystemForSpecificDiseases;
            this.Result.PhysicalHealth.DoctorAccess = country.PhysicalHealthInformation.First().DoctorAccess;
            this.Result.PhysicalHealth.AveragePerCapitaHealthExpenditure = country.PhysicalHealthInformation.First().AveragePerCapitaHealthExpenditure;

            foreach (var item in country.PhysicalHealthInformation.First().physicalHealthDesiredFoods)
            {
                this.Result.PhysicalHealth.PhysicalHealthDesiredFood.Add(new PhysicalHealthDesiredFoodDto(item, item.Food));
            }


            this.Result.MentalHealth.Id = country.mentalHealthInformation.First().Id;
            this.Result.MentalHealth.AbilityToVisitFamily = country.mentalHealthInformation.First().AbilityToVisitFamily;

            foreach (var item in country.mentalHealthInformation.First().mentalHealthPossibilityOfExacerbationOfTheDisorders)
            {
                this.Result.MentalHealth.mentalHealthPossibilityOfExacerbationOfTheDisorder.Add(
                    new MentalHealthPossibilityOfExacerbationOfTheDisorderDto(item, item.Disorder));
            }


            this.Result.Environmental.Id = country.environmentalInformation.First().Id;
            this.Result.Environmental.Immigration = country.environmentalInformation.First().Immigration;
            this.Result.Environmental.ReligiousIssues = country.environmentalInformation.First().ReligiousIssues;
            this.Result.Environmental.SocialRelationshipMatching = country.environmentalInformation.First().SocialRelationshipMatching;

            foreach (var item in country.environmentalInformation.First().environmentalLanguageInformation)
            {
                this.Result.Environmental.environmentalLanguageInformation.Add(
                    new EnvironmentalLanguageInformationDto(item, item.Language));
            }


            Result.Educational.Id = country.educationalInformation.First().Id;

            foreach (var item in country.educationalInformation.First().educationalInformationTuitions)
            {
                Result.Educational.Tuition.Add(new TuitionDto(item, item.FildOfStudy));
            }
            foreach (var item in country.educationalInformation.First().educationalProbabilityOfAcceptances)
            {
                Result.Educational.ProbabilityOfAcceptance.Add(new ProbabilityOfAcceptanceDto(item, item.FildOfStudy));
            }


            foreach (var item in country.welfareInformation)
            {
                WelfareDto welfare = new WelfareDto();
                welfare.Id = item.Id;
                welfare.JobId = item.JobId;
                welfare.CountryId = item.CountryId;
                welfare.JobName = item.Job.Name;
                welfare.AnnualSavingsRates = item.AnnualSavingsRates;
                welfare.RequiredSpecialization = item.RequiredSpecialization;
                Result.Welfare.Add(welfare);
            }

        }
        public async Task<ActionResult> OnPost(AddCountryDto c)
        {
            //await countryService.EditAsync(c);
            return RedirectToPage("./Countrys");
        }
    }
}
