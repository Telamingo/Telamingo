using Domain.AggregateModels.SharedAggregate;
using Domain.Dtos.AddCountry;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.JobService
{
    public class JobService : IJobService
    {
        private readonly ISharedRepository sharedRepository;

        public JobService(ISharedRepository sharedRepository)
        {
            this.sharedRepository = sharedRepository;
        }
        public async Task AddAsync(JobDto model)
        {
            await sharedRepository.AddJobAsync(model);
        }

        public async Task DeleteAsync(int jobId)
        {
            await sharedRepository.DeleteJobAsync(jobId);
        }

        public async Task EditAsync(JobDto model)
        {
            await sharedRepository.EditJobAsync(model);
        }

        public async Task<List<JobDto>> GetAllAsync()
        {
            List<Job> jobs = await sharedRepository.GetAllJobsAsync();
            List<JobDto> jobDtos = new List<JobDto>();

            foreach (var item in jobs)
            {
                JobDto job = new JobDto(item);
                jobDtos.Add(job);
            }

            return jobDtos;
        }
    }
}