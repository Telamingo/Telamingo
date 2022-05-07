using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain.AggregateModels.AdminAggregate
{
    public class AdminRole : IdentityRole<int>
    {
        public AdminRole()
        {

        }
        public int Role { get; set; }
        public override string Name { get; set; } = string.Empty;

        public IReadOnlyCollection<Admin> Admins => _Admin;
        private readonly List<Admin> _Admin;

    }
}