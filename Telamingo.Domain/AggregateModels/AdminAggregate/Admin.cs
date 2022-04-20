using Microsoft.AspNetCore.Identity;

namespace Telamingo.Domain.AggregateModels.AdminAggregate;

public class Admin: IdentityUser<int>
{
    public string Name { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int RoleId { get; set; }
}
