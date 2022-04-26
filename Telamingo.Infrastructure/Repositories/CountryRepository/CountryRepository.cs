using Microsoft.EntityFrameworkCore;
using Telamingo.Domain.AggregateModels.CountryAggregate;
using Telamingo.Domain.Dtos.AddCountry;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Infrastructure.Repositories.CountryRepository;

public class CountryRepository : ICountryRepository
{
    private readonly TelamingoDbContext _context;
    public IUnitOfWork UnitOfWork
    {
        get
        {
            return _context;
        }
    }

    public CountryRepository(TelamingoDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));

    }
    public async Task<AddCountryDto> GetAsync()
    {
        Country country = await _context.Countries.Where(x => x.Id == 1).FirstOrDefaultAsync();
        if (country == null)
        {
            throw new Exception("Null");
        }

        return new AddCountryDto();
    }
    public async Task<List<Country>> GetAllAsync()
    {
        List<Country> countrys = await _context.Countries.ToListAsync();
        if (countrys == null)
        {
            throw new Exception("Null");
        }
        return countrys;
    }
    //public async Task<List<AddCountryDto>> GetAllAsync()
    //{
    //    List<Country> countrys = await _context.Countries.ToListAsync();
    //    if (countrys == null)
    //    {
    //        throw new Exception("Null");
    //    }
    //    List<AddCountryDto>
    //    return countrys;
    //}
    public async Task<List<AddCountryDto>> AddAsync(AddCountryDto model)
    {
        Country country = await _context.Countries.Where(x => x.Id == 1).FirstOrDefaultAsync();
        if (country == null)
        {
            throw new Exception("Null");
        }

        return new List<AddCountryDto>();
    }
    public async Task<List<AddCountryDto>> UpdateAsync(AddCountryDto model)
    {
        Country country = await _context.Countries.Where(x => x.Id == 1).FirstOrDefaultAsync();
        if (country == null)
        {
            throw new Exception("Null");
        }

        return new List<AddCountryDto>();
    }
    public async Task<bool> DeleteAsync(int id)
    {
        Country country = await _context.Countries.Where(x => x.Id == 1).FirstOrDefaultAsync();
        if (country == null)
        {
            throw new Exception("Null");
        }

        return false;
    }
}

