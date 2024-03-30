using DemoApp.API.Data;

namespace DemoApp.API.Service;

public class UserService : IUserService
{
    private readonly AppDbContext _dbContext;
    List<User> _users = new List<User>();

    public UserService(AppDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public List<User> GetUsers()
    {
        
        var users = this._dbContext.Users.ToList();
        return users;
    }

    public User AddUser(User user)
    {
        this._dbContext.Users.Add(user);
        this._dbContext.SaveChanges();
        // this._users.Add(user);
        return user;
    }

    public User DeleteUser(User user)
    {
        this._dbContext.Users.Remove(user);
        this._dbContext.SaveChanges();
        // this._users.Remove(user);
        return user;
    }
}