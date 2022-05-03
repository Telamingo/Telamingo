using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.BusinessLogic.JobService;
using Telamingo.Domain.Dtos.AddCountry;

namespace Telamingo.AdminPanel.Pages
{
    public class JobsModel : PageModel
    {
        public List<JobDto> Result { get; set; } = new List<JobDto>();

        private readonly IJobService jobService;

        public JobsModel(IJobService jobService)
        {
            this.jobService = jobService;
        }
        public async Task OnGet()
        {
             Result = await jobService.GetAllAsync();
        }
        public async Task OnPost(JobDto job)
        {
            await jobService.AddAsync(job);
            Result = await jobService.GetAllAsync();
        }
        public async Task OnPostEdit(JobDto job)
        {
            await jobService.AddAsync(job);
        }
        public async Task OnPostDelete(int Id)
        {
            await jobService.DeleteAsync(Id);
        }
    }
}
