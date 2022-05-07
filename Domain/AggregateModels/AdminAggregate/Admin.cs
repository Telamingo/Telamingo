using Microsoft.AspNetCore.Identity;

namespace Domain.AggregateModels.AdminAggregate;

public class Admin : IdentityUser<int>
{
    public Admin()
    {

    }
    public string Name { get; set; } = string.Empty;
    public override string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int RoleId { get; set; }
    public virtual AdminRole AdminRole { get; set; }

}

