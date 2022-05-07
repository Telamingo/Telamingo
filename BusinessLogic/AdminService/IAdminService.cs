using Telamingo.Domain.Dtos.AdminDtos;

namespace BusinessLogic.AdminService;

public interface IAdminService
{
    Task<string> AdminLogin(AdminDto model);
}
