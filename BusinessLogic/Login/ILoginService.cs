using BusinessLogic.Login.Dto;

namespace BusinessLogic.Login;

public interface ILoginService
{
    Task<string> GetAsync(LoginDto model, CancellationToken cancellationToken);
}
