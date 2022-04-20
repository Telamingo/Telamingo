using Microsoft.AspNetCore.Identity;

namespace Telamingo.Domain.AggregateModels.AdminAggregate;

public class AdminRole: IdentityRole<int>
{
    public int Role { get; set; }
}
