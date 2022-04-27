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
    public async Task<Country> GetAsync(int Id)
    {
        Country country = await _context.Countries.Where(z => z.Id == Id)
            .Include(x => x.educationalInformation)
            .ThenInclude(a => a.educationalInformationTuitions)
            .ThenInclude(d => d.FildOfStudy)
            
            .Include(x => x.educationalInformation)
            .ThenInclude(a => a.educationalProbabilityOfAcceptances)
            .ThenInclude(d => d.FildOfStudy)

            .Include(x => x.environmentalInformation)
            .ThenInclude(a => a.environmentalLanguageInformation)
            .ThenInclude(d => d.Language)
            
            .Include(x => x.mentalHealthInformation)
            .ThenInclude(a => a.mentalHealthPossibilityOfExacerbationOfTheDisorders)
            .ThenInclude(d => d.Disorder)
            .FirstAsync();


        country = await _context.Countries.Where(z => z.Id == Id)
            .Include(x => x.PhysicalHealthInformation)
            .ThenInclude(a => a.physicalHealthDesiredFoods)
            .ThenInclude(d => d.Food)
            
            .Include(x => x.welfareInformation)
            .ThenInclude(d => d.Job)
            .FirstAsync();


        country = await _context.Countries.Where(z => z.Id == Id)
            .Include(x => x.culturalInformation)
            .ThenInclude(a => a.culturalClimateInformation)
            .ThenInclude(d => d.Climate)
            
            .Include(x => x.culturalInformation)
            .ThenInclude(a => a.culturalweatherInformation)
            .ThenInclude(d => d.Weather)
            .FirstAsync();

        //Country country = await _context.Countries.Where(z => z.Id == Id)
        //    .Include(x => x.educationalInformation)
        //    .ThenInclude(a => a.educationalInformationTuitions)
        //    .ThenInclude(d => d.FildOfStudy)
            
        //    .Include(x => x.educationalInformation)
        //    .ThenInclude(a => a.educationalProbabilityOfAcceptances)
        //    .ThenInclude(d => d.FildOfStudy)

        //    .Include(x => x.environmentalInformation)
        //    .ThenInclude(a => a.environmentalLanguageInformation)
        //    .ThenInclude(d => d.Language)
            
        //    .Include(x => x.mentalHealthInformation)
        //    .ThenInclude(a => a.mentalHealthPossibilityOfExacerbationOfTheDisorders)
        //    .ThenInclude(d => d.Disorder)
            
        //    .Include(x => x.PhysicalHealthInformation)
        //    .ThenInclude(a => a.physicalHealthDesiredFoods)
        //    .ThenInclude(d => d.Food)
            
        //    .Include(x => x.welfareInformation)
            
        //    .Include(x => x.culturalInformation)
        //    .ThenInclude(a => a.culturalClimateInformation)
        //    .ThenInclude(d => d.Climate)
            
        //    .Include(x => x.culturalInformation)
        //    .ThenInclude(a => a.culturalweatherInformation)
        //    .ThenInclude(d => d.Weather)
        //    .FirstAsync();

        if (country == null)
        {
            throw new Exception("Null");
        }
        return country;
    }
    public async Task<List<Country>> GetAllAsync()
    {
        List<Country> countrys = await _context.Countries
            //.Include(x => x.educationalInformation)
            //.ThenInclude(a => a.educationalInformationTuitions)
            //.Include(x => x.educationalInformation)
            //.ThenInclude(a => a.educationalProbabilityOfAcceptances)
            //.Include(x => x.environmentalInformation)
            //.ThenInclude(a => a.environmentalLanguageInformation)
            //.Include(x => x.mentalHealthInformation)
            //.ThenInclude(a => a.mentalHealthPossibilityOfExacerbationOfTheDisorders)
            //.Include(x => x.PhysicalHealthInformation)
            //.ThenInclude(a => a.physicalHealthDesiredFoods)
            //.Include(x => x.welfareInformation)
            //.Include(x => x.culturalInformation)
            //.ThenInclude(a => a.culturalClimateInformation)
            //.Include(x => x.culturalInformation)
            //.ThenInclude(a => a.culturalweatherInformation)
            .ToListAsync();

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
    public async Task AddAsync(AddCountryDto model)
    {
        Country newCountry = new Country(model);

        await UnitOfWork.SaveChangesAsync();
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

