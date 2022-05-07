using Domain.AggregateModels.CountryAggregate;
using Domain.Dtos.AddCountry;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.CountryService
{
    public interface ICountryService
    {
        Task<Country> GetAsync(int Id);
        Task<List<Country>> GetAllAsync();
        Task DeleteAsync(int countryId);
        Task EditAsync(AddCountryDto countryDto);
    }
}