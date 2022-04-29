using Microsoft.EntityFrameworkCore;
using Telamingo.Domain.AggregateModels.SharedAggregate;
using Telamingo.Domain.Dtos.AddCountry;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Infrastructure.Repositories.SharedRepository;

public class SharedRepository : ISharedRepository
{
    private readonly TelamingoDbContext _context;
    public IUnitOfWork UnitOfWork
    {
        get
        {
            return _context;
        }
    }

    public SharedRepository(TelamingoDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));

    }

    public async Task<List<Job>> GetAllJobsAsync()
    {
        return await _context.Jobs.ToListAsync();
    }
    public async Task AddJobAsync(JobDto model)
    {
        Job job = new Job(model.Id , model.Name);
        await UnitOfWork.SaveChangesAsync();
    }
    public async Task EditJobAsync(JobDto model)
    {
        Job job = await _context.Jobs.Where(a => a.Id == model.Id).FirstAsync();
        job.Name = model.Name;

        await UnitOfWork.SaveChangesAsync();
    }
    public async Task DeleteJobAsync(int Id)
    {
        Job job = await _context.Jobs.Where(a => a.Id == Id).FirstOrDefaultAsync();

    }
}
