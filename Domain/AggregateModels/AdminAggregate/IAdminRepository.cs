using Domain.Dtos.AdminDtos;

namespace Domain.AggregateModels.AdminAggregate;

public interface IAdminRepository
{
    Task<AdminDto> GetAdminAsync(AdminDto model);
}
