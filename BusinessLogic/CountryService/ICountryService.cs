using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.Dtos.AddCountry;

namespace BusinessLogic.CountryService;

public interface ICountryService
{
    Task<Country> GetAsync(int Id);
    Task<List<Country>> GetAllAsync();
    Task DeleteAsync(int countryId);
    Task EditAsync(AddCountryDto countryDto);
}
