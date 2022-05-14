using Microsoft.EntityFrameworkCore;
using Telamingo.Domain.AggregateModels.UserAggregate;
using Telamingo.Domain.Dtos.User;
using Telamingo.Domain.SeedWork;

namespace Telamingo.Infrastructure.Repositories.UserRepository;

public class UserRepository : IUserRepository
{
    private readonly TelamingoDbContext _context;
    public IUnitOfWork UnitOfWork
    {
        get
        {
            return _context;
        }
    }

    public UserRepository(TelamingoDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    public async Task<UserDto> GetUserByEmailAndPasswordAsync(string email, string password, CancellationToken cancellationToken)
    {
        User? user = await _context.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefaultAsync(cancellationToken);
        if (user == null)
        {
            throw new Exception("user was not found");
        }
        return new UserDto
        {
            Id = user.Id,
            Email = user.Email,
            Password = user.Password,
        };
    }
    public async Task<List<UserInformation>> GetUserList()
    {
        List<UserInformation>? users = await _context.UserInformations.ToListAsync();
        if (users == null)
        {
            throw new Exception("user was not found");
        }
        return users;
    }
    public async Task<UserAnswer> GetAnswer(int id)
    {
        UserAnswer answer = await _context.UserAnswers.Where(x => x.Id == id)
            .Include(a => a.Cultural)
            .Include(a => a.Economy)
            .Include(a => a.Environmental)
            .Include(a => a.Mental)
            .Include(a => a.MostImportants)
            .Include(a => a.Physical)
            .Include(a => a.Primary).ThenInclude(b => b.Companions)
            .Include(a => a.UserInformation)
            .FirstOrDefaultAsync();

        return answer;
    }

    //public async Task<UserDto> GetUserByEmailAndPasswordAsync(string email, string password, CancellationToken cancellationToken)
    //{
    //    if (UsersRecords.Any(x => x.Key == email && x.Value == password))
    //    {
    //        return new UserDto
    //        {
    //            Id = 1,
    //            Email = UsersRecords.FirstOrDefault(x => x.Key == email && x.Value == password).Key,
    //            Password = UsersRecords.FirstOrDefault(x => x.Key == email && x.Value == password).Value,
    //        };
    //    }
    //    else
    //    {
    //        throw new UnauthorizedAccessException(message: "user was not found");
    //    }
    //}
}
