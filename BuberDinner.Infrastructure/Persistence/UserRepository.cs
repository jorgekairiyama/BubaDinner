using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();

    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }

    public void AddUser(User user)
    {
        if (GetUserByEmail(user.Email) is not null)
        {
            throw new Exception("User already exists with this email.");
        }
        
        _users.Add(user);
    }
}