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
    public async Task<Country> GetAsync(int Id)
    {
        return await countryRepository.GetAsync(Id);
    }
    public async Task<List<Country>> GetAllAsync()
    {
        
        return await countryRepository.GetAllAsync();
    }
    public async Task AddAsync(AddCountryDto model)
    {
        
        await countryRepository.AddAsync(model);
    }

}
public class CountryListDto
{
    public int Id { get; set; }
    public string Name { get; set; }
}
