using Domain.AggregateModels.SharedAggregate;
using Domain.Dtos.AddCountry;
using Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.SharedRepository
{
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
            Job job = new Job(model.Id, model.Name);
            _context.Jobs.Add(job);
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
            _context.Jobs.Remove(job);
            await UnitOfWork.SaveChangesAsync();
        }
    }
}