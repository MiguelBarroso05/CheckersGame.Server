using Testproject.Data;
using Testproject.Models;

namespace Testproject.Services;

public interface IUserService
{
    public List<User> GetallUsers();
}

public class UserService : IUserService
{
    private readonly DataContext _context;

    public UserService(DataContext context)
    {
        _context = context;
    }

    public List<User> GetallUsers()
    {
        return _context.Users.ToList();
    }
}