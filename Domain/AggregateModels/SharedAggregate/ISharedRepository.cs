using Domain.Dtos.AddCountry;

namespace Domain.AggregateModels.SharedAggregate;

public interface ISharedRepository
{
    Task<List<Job>> GetAllJobsAsync();
    Task AddJobAsync(JobDto model);
    Task EditJobAsync(JobDto model);
    Task DeleteJobAsync(int Id);
}
