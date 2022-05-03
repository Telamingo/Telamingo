using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.BusinessLogic.JobService;

namespace Telamingo.AdminPanel.Pages
{
    public class DeleteJobModel : PageModel
    {
        private readonly IJobService jobService;

        public DeleteJobModel(IJobService jobService)
        {
            this.jobService = jobService;
        }

        public async Task<ActionResult> OnGet(int Id)
        {
            await jobService.DeleteAsync(Id);
            return RedirectToPage("./Jobs");
        }
    }
}
