using Telamingo.BusinessLogic.Actions.Calculation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Telamingo.Domain.Dtos.User;

namespace HTM.Pages
{
    public class FormModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost([FromServices] ICalculationService calculationService, UserAnswers mdl, CancellationToken cancellationToken)
        {
            try
            {
                ResultDto result = calculationService.GetAsync(mdl, cancellationToken);
                ViewData["Cultural"] = $"Cultural: { result.Cultural}";
                ViewData["PhysicalHealth"] = $"PhysicalHealth: { result.PhysicalHealth}";
                ViewData["MentalHealth"] = $"MentalHealth: { result.MentalHealth}";
                ViewData["Environmental"] = $"Environmental: { result.Environmental}";
                ViewData["Educational"] = $"Educational: { result.Educational}";
                ViewData["Welfare"] = $"Welfare: { result.Welfare}";

                ViewData["Result"] = $"Result: {result.Result}";
                ViewData["Percentage"] = $"Conformity percentage: {(int)(result.Result * 100)}  %";

                string Message = string.Empty;
                if (result.Result < 0.2)
                {
                    Message = "Its not good";
                }
                else if (result.Result < 0.4)
                {
                    Message = "Not good Enough";
                }
                else if (result.Result < 0.6)
                {
                    Message = "It makes no difference";
                }
                else if (result.Result < 0.8)
                {
                    Message = "Its beter";
                }
                else if (result.Result < 0.1)
                {
                    Message = "Do it :)";
                }

                ViewData["Message"] = Message;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}