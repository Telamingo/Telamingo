using Domain.Dtos.AdminDtos;
using System.Threading.Tasks;

namespace Domain.AggregateModels.AdminAggregate
{
    public interface IAdminRepository
    {
        Task<AdminDto> GetAdminAsync(AdminDto model);
    }
}