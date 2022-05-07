using Domain.Dtos.User;

namespace Domain.AggregateModels.UserAggregate;

public interface IUserRepository
{
    Task<UserDto> GetUserByEmailAndPasswordAsync(string email, string password, CancellationToken cancellationToken);
}
