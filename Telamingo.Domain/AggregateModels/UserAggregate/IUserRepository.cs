using Telamingo.Domain.Dtos.User;

namespace Telamingo.Domain.AggregateModels.UserAggregate;

public interface IUserRepository
{
    Task<UserDto> GetUserByEmailAndPasswordAsync(string email, string password, CancellationToken cancellationToken);
}
