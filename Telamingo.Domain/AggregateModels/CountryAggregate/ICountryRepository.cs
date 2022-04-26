using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.Domain.AggregateModels.CountryAggregate;

public interface ICountryRepository
{
    Task<List<Country>> GetAllAsync();
}
