using Domain.Dtos.AdminDtos;
using Domain.Dtos.User;

namespace BusinessLogic.Identity.GenerateToken
{
    public interface IGenerateTokenService
    {
        string Authenticate(UserDto user);
        string AdminAuthentication(AdminDto admin);
    }
}