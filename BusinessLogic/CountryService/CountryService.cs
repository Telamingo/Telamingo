using Domain.AggregateModels.CountryAggregate;
using Domain.Dtos.AddCountry;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.CountryService
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository countryRepository;

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
        public async Task DeleteAsync(int countryId)
        {
            await countryRepository.DeleteCountryAsync(countryId);
        }
        public async Task EditAsync(AddCountryDto countryDto)
        {
            await countryRepository.EditAsync(countryDto);
        }

    }
    public class CountryListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}