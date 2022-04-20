using Telamingo.Domain.Dtos.AdminDtos;

namespace Telamingo.Domain.AggregateModels.AdminAggregate;

public interface IAdminRepository
{
    Task<AdminDto> GetAdminAsync(AdminDto model);
}
