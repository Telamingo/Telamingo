using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public interface ICountryRepository
{
    Task<Country> GetAsync(int Id);
    Task<List<Country>> GetAllAsync();
}
