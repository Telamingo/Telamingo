using Telamingo.Domain.Dtos.AdminDtos;
using Telamingo.Domain.Dtos.User;

namespace Telamingo.BusinessLogic.Identity.GenerateToken;

public interface IGenerateTokenService
{
    string Authenticate(UserDto user);
    string AdminAuthentication(AdminDto admin);
}
