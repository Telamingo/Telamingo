using Domain.Dtos.User;
using System.Threading;

namespace BusinessLogic.Actions.Calculation
{
    public interface ICalculationService
    {
        ResultDto GetAsync(UserAnswers model, CancellationToken cancellationToken);
    }
}
