namespace Domain.AggregateModels.UserAggregate;

public class User
{
    public User(string email, string password)
    {
        Email = email;
        Password = password;
    }
    public int Id { get; set; }
    public string Password { get; private set; }
    public string Email { get; private set; }
}
