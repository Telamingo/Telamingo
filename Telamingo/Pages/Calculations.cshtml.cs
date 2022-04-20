using Telamingo.BusinessLogic.Actions.Calculation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.Domain.Dtos.User;

namespace HTM.Pages
{
    public class CalculationsModel : PageModel
    {
        public string Message { get; set; }
                
        public void OnPost([FromServices] ICalculationService calculationService, UserAnswers mdl, CancellationToken cancellationToken)
        {
            try
            {
                ResultDto result = calculationService.GetAsync(mdl, cancellationToken);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public IActionResult OnGet(ResultDto model, CancellationToken cancellationToken)
        {
            try
            {
                Message = "Get used";
                return Page();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
