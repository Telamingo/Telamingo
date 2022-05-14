using Domain.AggregateModels.UserAggregate;
using Domain.Dtos.User;
using Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.UserRepository
{
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

        public async Task AddUserAnswerAsync(UserAnswer model, CancellationToken cancellationToken)
        {
            UserAnswer userAnwer = model;

            await UnitOfWork.SaveChangesAsync();

        }

    }
}