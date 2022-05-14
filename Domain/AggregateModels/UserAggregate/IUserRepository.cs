using Domain.Dtos.User;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.AggregateModels.UserAggregate
{
    public interface IUserRepository
    {
        Task<UserDto> GetUserByEmailAndPasswordAsync(string email, string password, CancellationToken cancellationToken);
        Task<List<UserInformation>> GetUserList();
        Task AddUserAnswerAsync(UserAnswer model, CancellationToken cancellationToken);
    }
}