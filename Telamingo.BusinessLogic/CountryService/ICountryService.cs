using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.BusinessLogic.CountryService;

public interface ICountryService
{
    Task<AddCountryDto> GetAsync();
    Task<List<Country>> GetAllAsync();
}
