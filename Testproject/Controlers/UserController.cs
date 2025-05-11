using Microsoft.AspNetCore.Mvc;
using Testproject.Models;
using Testproject.Services;

namespace Testproject.Controlers;

[ApiController]
[Route("/api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public List<User> Get([FromServices] IUserService userService)
    {
        return userService.GetallUsers();
    }
}