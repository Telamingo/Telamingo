using Telamingo.BusinessLogic.Actions.Calculation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.Domain.Dtos.User;

namespace HTM.Pages
{
    public class About_usModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost([FromServices] ICalculationService calculationService, UserAnswers model, CancellationToken cancellationToken)
        {
            var result = calculationService.GetAsync(model, cancellationToken);
            //return result;
        }

    }
}
