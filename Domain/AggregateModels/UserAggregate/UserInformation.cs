using Domain.SeedWork;

namespace Domain.AggregateModels.UserAggregate
{
    public class UserInformation : Entity
    {
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}