using Domain.Dtos.AdminDtos;
using System.Threading.Tasks;

namespace BusinessLogic.AdminService
{
    public interface IAdminService
    {
        Task<string> AdminLogin(AdminDto model);
    }
}