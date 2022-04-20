using Telamingo.BusinessLogic.Login.Dto;

namespace Telamingo.BusinessLogic.Login;

public interface ILoginService
{
    Task<string> GetAsync(LoginDto model, CancellationToken cancellationToken);
}
