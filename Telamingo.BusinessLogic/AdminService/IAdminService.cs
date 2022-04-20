using Telamingo.Domain.Dtos.AdminDtos;

namespace Telamingo.BusinessLogic.AdminService;

public interface IAdminService
{
    Task<string> AdminLogin(AdminDto model);
}
