using DemoApp.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        this._userService = userService;
    }

    [HttpGet]
    public ActionResult GetAll()
    {
        var res = this._userService.GetUsers();
        return this.Ok(res);
    }
    
    [HttpPost]
    public ActionResult CreateUser(User user)
    {
        this._userService.AddUser(user);
        return Ok(user);
    }


    [HttpDelete]
    public ActionResult RemoveUser(User user)
    {
        this._userService.DeleteUser(user);
        return Ok(user);
    }
}