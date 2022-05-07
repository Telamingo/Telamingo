using Domain.Dtos.AddCountry;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.JobService
{
    public interface IJobService
    {
        Task<List<JobDto>> GetAllAsync();
        Task AddAsync(JobDto model);
        Task EditAsync(JobDto model);
        Task DeleteAsync(int jobId);
    }
}