using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Telamingo.Domain.AggregateModels.AdminAggregate;
using Telamingo.Domain.Dtos.AdminDtos;
using Telamingo.Domain.SeedWork;

namespace Infrastructure.Repositories.AdminRepository;

public class AdminRepository : IAdminRepository
{
    private readonly TelamingoDbContext _context;
    public IUnitOfWork UnitOfWork
    {
        get
        {
            return _context;
        }
    }

    public AdminRepository(TelamingoDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));

    }
    public async Task<AdminDto> GetAdminAsync(AdminDto model)
    {
        Admin? admin = await _context.Admins.Where(x => x.UserName == model.UserName && x.Password == model.Password).FirstOrDefaultAsync();
        if (admin == null)
        {
            throw new UnauthorizedAccessException("Unauthorized");
        }

        return new AdminDto
        {
            Id = admin.Id,
            UserName = admin.UserName,
            Password = admin.Password,
        };
    }
}
