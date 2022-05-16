using Domain.SeedWork;

namespace Domain.AggregateModels.UserAggregate
{
    public class UserInformation : Entity
    {
        public UserInformation() { }

        public UserInformation(UserInformationDto model)
        {
            Name = model.Name;
            Email = model.Email;
            PhoneNumber = model.PhoneNumber;
        }
        public int UserAnswerId { get; set; }
        public virtual UserAnswer UserAnswer { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class UserInformationDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}