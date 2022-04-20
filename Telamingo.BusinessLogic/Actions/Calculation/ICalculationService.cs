using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Telamingo.BusinessLogic.Actions.Calculation.CalculationService;
using Telamingo.Domain.Dtos.User;

namespace Telamingo.BusinessLogic.Actions.Calculation
{
    public interface ICalculationService
    {
        ResultDto GetAsync(UserAnswers model, CancellationToken cancellationToken);
    }
}
