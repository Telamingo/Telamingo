using Telamingo.BusinessLogic.Identity.GenerateToken;
using Telamingo.BusinessLogic.Login.Dto;
using Telamingo.Domain.AggregateModels.UserAggregate;
using Telamingo.Domain.Dtos.User;

namespace Telamingo.BusinessLogic.Login;

public class LoginService : ILoginService
{
    private readonly IUserRepository _userRepository;
    private readonly IGenerateTokenService generateTokenService;

    public LoginService(IUserRepository userRepository,
        IGenerateTokenService generateTokenService)
    {
        _userRepository = userRepository;
        this.generateTokenService = generateTokenService;
    }
    public async Task<string> GetAsync(LoginDto model, CancellationToken cancellationToken)
    {
        UserDto user = await _userRepository.GetUserByEmailAndPasswordAsync(model.Email, model.Password, cancellationToken);

        #region JWT
        string token = generateTokenService.Authenticate(user);
        #endregion

        return token;
    }
}
