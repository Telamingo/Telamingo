using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public interface ICountryRepository
{
    Task<Country> GetAsync(int Id);
    Task<List<Country>> GetAllAsync();
    Task AddAsync(AddCountryDto model);
    Task DeleteCountryAsync(int countryId);
    Task EditAsync(AddCountryDto countryDto);
}
