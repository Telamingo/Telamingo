using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.BusinessLogic.CountryService;

public class CountryService : ICountryService
{
    private readonly ICountryRepository  countryRepository;

    public CountryService(ICountryRepository countryRepository)
    {
        this.countryRepository = countryRepository;
    }
    public async Task<AddCountryDto> GetAsync()
    {
        var country = new AddCountryDto();

        return country;
    }
    public async Task<List<Country>> GetAllAsync()
    {
        
        return await countryRepository.GetAllAsync();
    }

}
