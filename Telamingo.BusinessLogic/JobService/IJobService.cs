using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.BusinessLogic.JobService;

public interface IJobService
{
    Task<List<JobDto>> GetAllAsync();
    Task AddAsync(JobDto model);
    Task EditAsync(JobDto model);
    Task DeleteAsync(int  jobId);
}
