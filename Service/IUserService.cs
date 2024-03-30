namespace DemoApp.API.Service;

public interface IUserService
{
    public List<User> GetUsers();
    public User AddUser(User user);

    public User DeleteUser(User user);
}