using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.BusinessLogic.CountryService;

namespace Telamingo.AdminPanel.Pages
{
    public class DeleteCountryModel : PageModel
    {
        private readonly ICountryService countryService;

        public DeleteCountryModel(ICountryService countryService)
        {
            this.countryService = countryService;
        }

        public async Task<ActionResult> OnGet(int Id)
        {
            await countryService.DeleteAsync(Id);
            return RedirectToPage("./Countrys");
        }
    }
}
